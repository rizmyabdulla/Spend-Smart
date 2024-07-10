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

        readonly private MainForm _mainForm;
        readonly string conString = "server=localhost;uid=root;pwd=;database=spend_smart";
        public ProfileForm(MainForm mainForm)
        {
            InitializeComponent();

            _mainForm = mainForm;
            GetUserData();
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


            _mainForm.Hide();

            FirstForm firstForm = new FirstForm();
            firstForm.FormClosed += (s, args) => _mainForm.Close();
            firstForm.Show();
        }

        private void ChangePasswordBtn_Click(object sender, EventArgs e)
        {
            if (ValidateChangePassword() == true)
            {
                ChangePassword();
            }
        }

        private void GetUserData()
        {
            using (MySqlConnection connection = new MySqlConnection(conString))
            {
                try
                {
                    connection.Open();

                    string query = "SELECT username, fullName, email, phoneNumber FROM users WHERE id = @UserId";
                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@UserId", Properties.Settings.Default.UserId);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                UserNameLabel.Text = reader["username"].ToString();
                                FNameLabel.Text = reader["fullname"].ToString();
                                EmailLabel.Text = reader["email"].ToString();
                                PNumberLabel.Text = reader["phoneNumber"].ToString();

                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
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
