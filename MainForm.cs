using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Spend_Smart
{
    public partial class MainForm : Form
    {

        public MainForm()
        {
            InitializeComponent();

            SidebarNavigator(new DashboardForm(), DashboardBtn);

            UsernameLabel.Text = "Welcome " + Properties.Settings.Default.Username + "!";
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void DateTimer_Tick(object sender, EventArgs e)
        {
            DateTime dateTime = DateTime.Now;
            label3.Text = dateTime.ToString("yyyy-MM-dd HH:mm:ss");
        }

        public void SidebarNavigator(Form form, Button activeButton)
        {
            if (this.MainPanel.Controls.Count > 0)
            {
                this.MainPanel.Controls.RemoveAt(0);
            }

            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            this.MainPanel.Controls.Add(form);
            this.MainPanel.Tag = form;
            form.Show();


            ResetButtonColors();

            activeButton.BackColor = Color.FromArgb(64, 64, 64);
            activeButton.ForeColor = Color.White;
        }

        private void ResetButtonColors()
        {
            foreach (Control control in SideBar.Controls)
            {
                if (control is Button button)
                {
                    button.BackColor = Color.Transparent;
                    button.ForeColor = SystemColors.Control;
                }
            }
        }

        private void DashboardBtn_Click(object sender, EventArgs e)
        {
            SidebarNavigator(new DashboardForm(), DashboardBtn);
        }

        private void ExpensesBtn_Click(object sender, EventArgs e)
        {
            SidebarNavigator(new ExpensesForm(), ExpensesBtn);
        }

        private void BudgetsBtn_Click(object sender, EventArgs e)
        {
            SidebarNavigator(new BudgetsForm(), BudgetsBtn);
        }

        private void SavingsBtn_Click(object sender, EventArgs e)
        {
            SidebarNavigator(new SavingsForm(), SavingBtn);
        }

        private void IncomeBtn_Click(object sender, EventArgs e)
        {
            SidebarNavigator(new IncomeForm(), IncomeBtn);
        }

        private void ProfileBtn_Click(object sender, EventArgs e)
        {
            SidebarNavigator(new ProfileForm(this), ProfileBtn);
        }

        private void AddExpense_Click(object sender, EventArgs e)
        {
            ExpenseModal.isAdd = true;
            Form fm = new ExpenseModal();
            fm.ShowDialog();
        }

        private void AddIncome_Click(object sender, EventArgs e)
        {
            Form fm = new Incomemodal();
            fm.ShowDialog();
        }

        private void AddSaving_Click(object sender, EventArgs e)
        {
            Form fm = new SavingModal();
            fm.ShowDialog();
        }
    }
}
