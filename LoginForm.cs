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


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainForm fm4 = new MainForm();
            fm4.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FirstForm fm1 = new FirstForm();
            fm1.Show();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegisterForm fm3 = new RegisterForm();
            fm3.Show();
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
