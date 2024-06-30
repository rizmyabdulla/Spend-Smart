using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Spend_Smart
{
    public partial class RegisterForm : Form
    {
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
    }
}
