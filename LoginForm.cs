using System;
using System.Drawing;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Spend_Smart
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            this.Load += new EventHandler(Form2_Load);
            this.Resize += new EventHandler(Form2_Resize);
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            CenterControl(label1, horizontal: true, vertical: false);
            CenterControl(panel1, horizontal: true, vertical: true);
        }

        private void Form2_Resize(object sender, EventArgs e)
        {
            CenterControl(label1, horizontal: true, vertical: false);
            CenterControl(panel1, horizontal: true, vertical: true);
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            if (ValidateLogin())
            {
                if (DBConnection())
                {
                    MainForm fm = new MainForm();
                    fm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid username or password!");
                }
            }
        }

        private void RegisterBtn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegisterForm fm = new RegisterForm();
            fm.Show();
            this.Hide();
        }

        bool ValidateLogin()
        {
            if (string.IsNullOrWhiteSpace(UsernameField.Text) ||
                string.IsNullOrWhiteSpace(PasswordField.Text))
            {
                MessageBox.Show("Please fill in every field!");
                return false;
            }
            return true;
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

        bool DBConnection()
        {
            string conString = "server=localhost;uid=root;pwd=;database=spend_smart";
            using (MySqlConnection connection = new MySqlConnection(conString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT id, fullName, email, password, phoneNumber FROM users WHERE username = @username";
                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@username", UsernameField.Text);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string storedHashedPassword = reader["password"].ToString();
                                string enteredHashedPassword = HashPassword(PasswordField.Text);

                                if (storedHashedPassword == enteredHashedPassword)
                                {
                                    int userId = Convert.ToInt32(reader["id"]);
                                    int phoneNumber = Convert.ToInt32(reader["phoneNumber"]);
                                    string fullName = reader["fullName"].ToString();
                                    string email = reader["email"].ToString();

                                    Properties.Settings.Default.UserId = userId;
                                    Properties.Settings.Default.Username = UsernameField.Text;
                                    Properties.Settings.Default.FullName = fullName;
                                    Properties.Settings.Default.Email = email;
                                    Properties.Settings.Default.PhoneNumber = phoneNumber;
                                    Properties.Settings.Default.Save();

                                    return true;
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
            return false;
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
