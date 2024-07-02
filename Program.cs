using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Spend_Smart
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            string conString = "server=localhost;uid=root;pwd=;database=spend_smart";
            try
            {
                using (MySqlConnection connection = new MySqlConnection(conString))
                {
                    connection.Open();

                    int userId = Properties.Settings.Default.UserId;
                    string username = Properties.Settings.Default.Username;

                    Form startupForm;

                    if (userId != 0 && !string.IsNullOrEmpty(username))
                    {
                        startupForm = new MainForm();
                    }
                    else
                    {
                        startupForm = new FirstForm();
                    }

                    Application.Run(startupForm);
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Database connection error: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }
    }
}
