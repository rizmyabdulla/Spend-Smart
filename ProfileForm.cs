using System;
using System.Windows.Forms;

namespace Spend_Smart
{
    public partial class ProfileForm : Form
    {
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
            Properties.Settings.Default.Save();


            // Show FirstForm
            FirstForm firstForm = new FirstForm();
            ActiveForm.Close();
            firstForm.Show();

        }
    }
}
