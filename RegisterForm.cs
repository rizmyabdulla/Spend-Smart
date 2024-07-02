using System;
using System.Drawing;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Spend_Smart
{
    public partial class RegisterForm : Form
    {

        readonly string conString = "server=localhost;uid=root;pwd=;database=spend_smart";
        public RegisterForm()
        {
            InitializeComponent();
            this.Load += new EventHandler(Form3_Load);
            this.Resize += new EventHandler(Form3_Resize);
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            CenterControl(label1, horizontal: true, vertical: false);
            CenterControl(panel1, horizontal: true, vertical: true);
        }

        private void Form3_Resize(object sender, EventArgs e)
        {
            CenterControl(label1, horizontal: true, vertical: false);
            CenterControl(panel1, horizontal: true, vertical: true);
        }

        private void Login_Clicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoginForm fm2 = new LoginForm();
            fm2.Show();
            this.Hide();
        }

        private void CenterControl(Control control, bool horizontal, bool vertical)
        {
            // Get the dimensions of the form's client area and the control
            int formWidth = this.ClientSize.Width;
            int formHeight = this.ClientSize.Height;
            int controlWidth = control.Width;
            int controlHeight = control.Height;

            // Calculate new position to center the control
            int newX = control.Location.X;
            int newY = control.Location.Y;

            if (horizontal)
            {
                newX = (formWidth - controlWidth) / 2;
            }

            if (vertical)
            {
                newY = (formHeight - controlHeight) / 2;
            }

            // Set the new position
            control.Location = new Point(newX, newY);
        }

        private void Registerbtn_Click(object sender, EventArgs e)
        {
            if (ValidateRegister())
            {
                if (DBConnection())
                {
                    InsertRegisterData();
                }
            }
        }

        bool ValidateRegister()
        {
            if (string.IsNullOrWhiteSpace(FullNameField.Text) ||
                string.IsNullOrWhiteSpace(UserNameField.Text) ||
                string.IsNullOrWhiteSpace(EmailField.Text) ||
                string.IsNullOrWhiteSpace(PhoneNumbField.Text) ||
                string.IsNullOrWhiteSpace(PasswordField.Text) ||
                string.IsNullOrWhiteSpace(ConfirmPasswordField.Text))
            {
                MessageBox.Show("Please fill in every field!");
                return false;
            }

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

            if (UserNameField.TextLength < 4)
            {
                MessageBox.Show("Username must be 4 or more characters!");
                return false;
            }

            if (!IsValidEmail(EmailField.Text))
            {
                MessageBox.Show("Please enter a valid email address!");
                return false;
            }

            if (!Regex.IsMatch(PhoneNumbField.Text, @"^\d{10}$"))
            {
                MessageBox.Show("Please enter a valid phone number!");
                return false;
            }

            if (PasswordField.Text != ConfirmPasswordField.Text)
            {
                MessageBox.Show("Passwords do not match!");
                return false;
            }

            if (PasswordField.TextLength < 8)
            {
                MessageBox.Show("Password must be 8 or more characters!");
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

        bool DBConnection()
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
                            return false;
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

        void InsertRegisterData()
        {
            using (MySqlConnection connection = new MySqlConnection(conString))
            {
                try
                {
                    connection.Open();
                    string hashedPassword = HashPassword(PasswordField.Text);

                    string query = "INSERT INTO users (fullName, username, email, phoneNumber, password) VALUES (@fullName, @username, @Email, @PhoneNumber, @Password)";
                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@fullName", FullNameField.Text);
                        cmd.Parameters.AddWithValue("@username", UserNameField.Text);
                        cmd.Parameters.AddWithValue("@Email", EmailField.Text);
                        cmd.Parameters.AddWithValue("@PhoneNumber", PhoneNumbField.Text);
                        cmd.Parameters.AddWithValue("@Password", hashedPassword);

                        cmd.ExecuteNonQuery();
                        if(MessageBox.Show("Registration successful. Login to your account!") == DialogResult.OK) {
                            Form fm = new LoginForm();
                            fm.Show();
                            this.Close();
                        }
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
