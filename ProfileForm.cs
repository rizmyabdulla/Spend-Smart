using MySql.Data.MySqlClient;
using System;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Spend_Smart
{
    public partial class ProfileForm : Form
    {
        readonly string conString = "server=localhost;uid=root;pwd=;database=spend_smart";
        public ProfileForm()
        {
            InitializeComponent();
        }

        private void LogoutBtn_Click(object sender, EventArgs e)
        {
            // Clear session data
            Properties.Settings.Default.UserId = 0;
            Properties.Settings.Default.Username = string.Empty;
            Properties.Settings.Default.FullName = string.Empty;
            Properties.Settings.Default.Email = string.Empty;
            Properties.Settings.Default.PhoneNumber = 0;
            Properties.Settings.Default.Save();


            FirstForm firstForm = new FirstForm();
            ActiveForm.Close();
            firstForm.Show();
        }

        private void ChangeBasicBtn_Click(object sender, EventArgs e)
        {
            if (ValidateBasic() && IsUsernameOrEmailExists())
            {
                MessageBox.Show("Profile fields are valid!");
            }
        }

        private void ChangePasswordBtn_Click(object sender, EventArgs e)
        {
            if (ValidateChangePassword() == true)
            {
                ChangePassword();
            }
        }


        // UPDATE BASIC INFO Validations and DB

        bool ValidateBasic()
        {
            if (string.IsNullOrWhiteSpace(FullNameField.Text) &&
                string.IsNullOrWhiteSpace(UserNameField.Text) &&
                string.IsNullOrWhiteSpace(EmailField.Text) &&
                string.IsNullOrWhiteSpace(PhoneNumbField.Text))
            {
                MessageBox.Show("Please fill at least one field!");
                return false;
            }

            if (!string.IsNullOrWhiteSpace(FullNameField.Text))
            {
                if (!Regex.IsMatch(FullNameField.Text, @"^[a-zA-Z\s]+$"))
                {
                    MessageBox.Show("Full Name must contain only alphabets and spaces!");
                    return false;
                }

                if (FullNameField.TextLength < 4)
                {
                    MessageBox.Show("Full Name must be 4 or more characters!");
                    return false;
                }
            }

            if (!string.IsNullOrWhiteSpace(UserNameField.Text))
            {
                if (UserNameField.TextLength < 4)
                {
                    MessageBox.Show("Username must be 4 or more characters!");
                    return false;
                }

                if (UserNameField.Text == Properties.Settings.Default.Username)
                {
                    MessageBox.Show("Please enter a new Username or leave it empty!");
                    return false;
                }
            }

            if (!string.IsNullOrWhiteSpace(EmailField.Text))
            {
                if (!IsValidEmail(EmailField.Text))
                {
                    MessageBox.Show("Please enter a valid email address!");
                    return false;
                }

                if (EmailField.Text == Properties.Settings.Default.Email)
                {
                    MessageBox.Show("Please enter a new Email Address or leave it empty!");
                    return false;
                }
            }

            if (!string.IsNullOrWhiteSpace(PhoneNumbField.Text))
            {
                if (!Regex.IsMatch(PhoneNumbField.Text, @"^\d{10}$"))
                {
                    MessageBox.Show("Please enter a valid phone number!");
                    return false;
                }

                if (int.TryParse(PhoneNumbField.Text, out int phoneNumber))
                {
                    if (phoneNumber == Properties.Settings.Default.PhoneNumber)
                    {
                        MessageBox.Show("Please enter a new phone number or leave it empty!");
                        return false;
                    }
                }
                else
                {
                    MessageBox.Show("Phone number format is incorrect!");
                    return false;
                }
            }

            return true;
        }


        bool IsUsernameOrEmailExists()
        {
            using (MySqlConnection connection = new MySqlConnection(conString))
            {
                try
                {
                    connection.Open();
                    string checkQuery = "SELECT COUNT(*) FROM users WHERE username = @username OR email = @Email";
                    using (MySqlCommand checkCmd = new MySqlCommand(checkQuery, connection))
                    {
                        checkCmd.Parameters.AddWithValue("@username", UserNameField.Text);
                        checkCmd.Parameters.AddWithValue("@Email", EmailField.Text);

                        int userExists = Convert.ToInt32(checkCmd.ExecuteScalar());
                        if (userExists > 0)
                        {
                            MessageBox.Show("Username or Email already exists!");
                            return true;
                        }
                    }
                }
                catch (FormatException fe)
                {
                    MessageBox.Show("Format Error: " + fe.Message);
                    return false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                    return false;
                }
            }
            return false;
        }



        // CHANGE PASSWORD Validations and DB


        bool ValidateChangePassword()
        {
            if (string.IsNullOrWhiteSpace(OldPasswordField.Text) ||
                string.IsNullOrWhiteSpace(PasswordField.Text) ||
                string.IsNullOrWhiteSpace(ConfirmPasswordField.Text))
            {
                MessageBox.Show("Please fill in every field!");
                return false;
            }

            if (OldPasswordField.TextLength < 8)
            {
                MessageBox.Show("Password must be 8 or more characters!");
                return false;
            }

            if (PasswordField.Text != ConfirmPasswordField.Text)
            {
                MessageBox.Show("Passwords do not match!");
                return false;
            }

            if (PasswordField.Text == OldPasswordField.Text)
            {
                MessageBox.Show("You can't set your Old password for new Password!");
                return false;
            }

            if (PasswordField.TextLength < 8)
            {
                MessageBox.Show("Password must be 8 or more characters!");
                return false;
            }

            if(IsOldPasswordMatch() == false)
            {
                MessageBox.Show("Entered Old Password doesn't match for stored password!");
                return false;
            }
            return true;
        }

        bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }
   

        bool IsOldPasswordMatch()
        {
            using (MySqlConnection connection = new MySqlConnection(conString))
            {
                try
                {
                    connection.Open();
                    string checkQuery = "SELECT password FROM users WHERE id = @id";
                    using (MySqlCommand cmd = new MySqlCommand(checkQuery, connection))
                    {
                        cmd.Parameters.AddWithValue("@id", Properties.Settings.Default.UserId);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string storedOldPassword = reader["password"].ToString();
                                string enteredOldPassword = HashPassword(OldPasswordField.Text);

                                if (storedOldPassword == enteredOldPassword)
                                {
                                    return true;
                                }
                                else
                                {
                                    return false;
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                    return false;
                }
            }
            return true;
        }

        void ChangePassword()
        {
            using (MySqlConnection connection = new MySqlConnection(conString))
            {
                try
                {
                    connection.Open();
                    string query = "UPDATE users SET password=@password WHERE id = @id";
                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@id", Properties.Settings.Default.UserId);
                        cmd.Parameters.AddWithValue("@password", HashPassword(PasswordField.Text));

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Password Changed Successfully!");
                        OldPasswordField.Text = "";
                        PasswordField.Text = "";
                        ConfirmPasswordField.Text = "";
                        
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }



        string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                StringBuilder builder = new StringBuilder();
                foreach (byte b in bytes)
                {
                    builder.Append(b.ToString("x2"));
                }
                return builder.ToString();
            }
        }
    }
}
