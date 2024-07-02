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
    public partial class FirstForm : Form
    {
        public FirstForm()
        {
            InitializeComponent();
            this.Load += new EventHandler(Form1_Load);
            this.Resize += new EventHandler(Form1_Resize);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            CenterControl(label1, horizontal: true, vertical: false);
            CenterControl(label2, horizontal: true, vertical: false);
            CenterControl(LoginBtn, horizontal: true, vertical: false);
            CenterControl(RegisterBtn, horizontal: true, vertical: false);
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            CenterControl(label1, horizontal: true, vertical: false);
            CenterControl(label2, horizontal: true, vertical: false);
            CenterControl(LoginBtn, horizontal: true, vertical: false);
            CenterControl(RegisterBtn, horizontal: true, vertical: false);
        }


        private void LoginBtn_Click(object sender, EventArgs e)
        {
            LoginForm fm = new LoginForm();
            fm.Show();
            this.Hide();
        }

        private void Registerbtn_Click(object sender, EventArgs e)
        {
            RegisterForm fm = new RegisterForm();
            fm.Show();
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
