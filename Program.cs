using System;
using System.Windows.Forms;

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

            int userId = Properties.Settings.Default.UserId;
            string username = Properties.Settings.Default.Username;

            Form startupForm = null;

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
}
