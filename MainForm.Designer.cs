
namespace Spend_Smart
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.SideBar = new System.Windows.Forms.Panel();
            this.IncomeBtn = new System.Windows.Forms.Button();
            this.ExpensesBtn = new System.Windows.Forms.Button();
            this.ProfileBtn = new System.Windows.Forms.Button();
            this.SavingBtn = new System.Windows.Forms.Button();
            this.BudgetsBtn = new System.Windows.Forms.Button();
            this.DashboardBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.AddSaving = new System.Windows.Forms.Button();
            this.AddIncome = new System.Windows.Forms.Button();
            this.AddExpense = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.SideBar.SuspendLayout();
            this.panel2.SuspendLayout();
            this.MainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // SideBar
            // 
            this.SideBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(146)))), ((int)(((byte)(255)))));
            this.SideBar.Controls.Add(this.IncomeBtn);
            this.SideBar.Controls.Add(this.ExpensesBtn);
            this.SideBar.Controls.Add(this.ProfileBtn);
            this.SideBar.Controls.Add(this.SavingBtn);
            this.SideBar.Controls.Add(this.BudgetsBtn);
            this.SideBar.Controls.Add(this.DashboardBtn);
            this.SideBar.Controls.Add(this.label1);
            this.SideBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.SideBar.Location = new System.Drawing.Point(0, 0);
            this.SideBar.Name = "SideBar";
            this.SideBar.Size = new System.Drawing.Size(200, 461);
            this.SideBar.TabIndex = 0;
            // 
            // IncomeBtn
            // 
            this.IncomeBtn.BackColor = System.Drawing.Color.Transparent;
            this.IncomeBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.IncomeBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.IncomeBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.IncomeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IncomeBtn.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IncomeBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.IncomeBtn.Location = new System.Drawing.Point(15, 325);
            this.IncomeBtn.Name = "IncomeBtn";
            this.IncomeBtn.Size = new System.Drawing.Size(186, 37);
            this.IncomeBtn.TabIndex = 8;
            this.IncomeBtn.Text = "Manage Incomes";
            this.IncomeBtn.UseVisualStyleBackColor = false;
            this.IncomeBtn.Click += new System.EventHandler(this.IncomeBtn_Click);
            // 
            // ExpensesBtn
            // 
            this.ExpensesBtn.BackColor = System.Drawing.Color.Transparent;
            this.ExpensesBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ExpensesBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.ExpensesBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.ExpensesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExpensesBtn.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExpensesBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.ExpensesBtn.Location = new System.Drawing.Point(15, 143);
            this.ExpensesBtn.Name = "ExpensesBtn";
            this.ExpensesBtn.Size = new System.Drawing.Size(186, 37);
            this.ExpensesBtn.TabIndex = 7;
            this.ExpensesBtn.Text = "Manage Expenses";
            this.ExpensesBtn.UseVisualStyleBackColor = false;
            this.ExpensesBtn.Click += new System.EventHandler(this.ExpensesBtn_Click);
            // 
            // ProfileBtn
            // 
            this.ProfileBtn.BackColor = System.Drawing.Color.Transparent;
            this.ProfileBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ProfileBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.ProfileBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.ProfileBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ProfileBtn.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProfileBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.ProfileBtn.Location = new System.Drawing.Point(15, 383);
            this.ProfileBtn.Name = "ProfileBtn";
            this.ProfileBtn.Size = new System.Drawing.Size(186, 37);
            this.ProfileBtn.TabIndex = 4;
            this.ProfileBtn.Text = "Profile";
            this.ProfileBtn.UseVisualStyleBackColor = false;
            this.ProfileBtn.Click += new System.EventHandler(this.ProfileBtn_Click);
            // 
            // SavingBtn
            // 
            this.SavingBtn.BackColor = System.Drawing.Color.Transparent;
            this.SavingBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SavingBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.SavingBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.SavingBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SavingBtn.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SavingBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.SavingBtn.Location = new System.Drawing.Point(15, 265);
            this.SavingBtn.Name = "SavingBtn";
            this.SavingBtn.Size = new System.Drawing.Size(186, 37);
            this.SavingBtn.TabIndex = 3;
            this.SavingBtn.Text = "Manage Saving Goals";
            this.SavingBtn.UseVisualStyleBackColor = false;
            this.SavingBtn.Click += new System.EventHandler(this.SavingsBtn_Click);
            // 
            // BudgetsBtn
            // 
            this.BudgetsBtn.BackColor = System.Drawing.Color.Transparent;
            this.BudgetsBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BudgetsBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.BudgetsBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.BudgetsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BudgetsBtn.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BudgetsBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.BudgetsBtn.Location = new System.Drawing.Point(15, 203);
            this.BudgetsBtn.Name = "BudgetsBtn";
            this.BudgetsBtn.Size = new System.Drawing.Size(186, 37);
            this.BudgetsBtn.TabIndex = 2;
            this.BudgetsBtn.Text = "Manage Budgets";
            this.BudgetsBtn.UseVisualStyleBackColor = false;
            this.BudgetsBtn.Click += new System.EventHandler(this.BudgetsBtn_Click);
            // 
            // DashboardBtn
            // 
            this.DashboardBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.DashboardBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.DashboardBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.DashboardBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.DashboardBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DashboardBtn.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DashboardBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.DashboardBtn.Location = new System.Drawing.Point(15, 85);
            this.DashboardBtn.Name = "DashboardBtn";
            this.DashboardBtn.Size = new System.Drawing.Size(186, 37);
            this.DashboardBtn.TabIndex = 1;
            this.DashboardBtn.Text = "Dashboard";
            this.DashboardBtn.UseVisualStyleBackColor = false;
            this.DashboardBtn.Click += new System.EventHandler(this.DashboardBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "SPENT SMART";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(146)))), ((int)(((byte)(255)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.UsernameLabel);
            this.panel2.Controls.Add(this.AddSaving);
            this.panel2.Controls.Add(this.AddIncome);
            this.panel2.Controls.Add(this.AddExpense);
            this.panel2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(207, 11);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(603, 43);
            this.panel2.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(164, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Date";
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.AutoSize = true;
            this.UsernameLabel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.UsernameLabel.Location = new System.Drawing.Point(12, 15);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(131, 15);
            this.UsernameLabel.TabIndex = 5;
            this.UsernameLabel.Text = "WELCOME username!";
            // 
            // AddSaving
            // 
            this.AddSaving.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.AddSaving.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.AddSaving.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddSaving.ForeColor = System.Drawing.SystemColors.Control;
            this.AddSaving.Location = new System.Drawing.Point(501, 8);
            this.AddSaving.Name = "AddSaving";
            this.AddSaving.Size = new System.Drawing.Size(93, 27);
            this.AddSaving.TabIndex = 4;
            this.AddSaving.Text = "+ Add Savings";
            this.AddSaving.UseVisualStyleBackColor = false;
            this.AddSaving.Click += new System.EventHandler(this.AddSaving_Click);
            // 
            // AddIncome
            // 
            this.AddIncome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.AddIncome.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.AddIncome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddIncome.ForeColor = System.Drawing.SystemColors.Control;
            this.AddIncome.Location = new System.Drawing.Point(398, 8);
            this.AddIncome.Name = "AddIncome";
            this.AddIncome.Size = new System.Drawing.Size(93, 27);
            this.AddIncome.TabIndex = 3;
            this.AddIncome.Text = "+ Add Income";
            this.AddIncome.UseVisualStyleBackColor = false;
            this.AddIncome.Click += new System.EventHandler(this.AddIncome_Click);
            // 
            // AddExpense
            // 
            this.AddExpense.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.AddExpense.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.AddExpense.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddExpense.ForeColor = System.Drawing.SystemColors.Control;
            this.AddExpense.Location = new System.Drawing.Point(295, 8);
            this.AddExpense.Name = "AddExpense";
            this.AddExpense.Size = new System.Drawing.Size(93, 27);
            this.AddExpense.TabIndex = 2;
            this.AddExpense.Text = "+ Add Expense";
            this.AddExpense.UseVisualStyleBackColor = false;
            this.AddExpense.Click += new System.EventHandler(this.AddExpense_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.DateTimer_Tick);
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(200, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(634, 67);
            this.panel3.TabIndex = 2;
            // 
            // MainPanel
            // 
            this.MainPanel.Controls.Add(this.label5);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(200, 67);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(634, 394);
            this.MainPanel.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(286, 188);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "label5";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 461);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.SideBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Spend Smart - Dashboard";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.SideBar.ResumeLayout(false);
            this.SideBar.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel SideBar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SavingBtn;
        private System.Windows.Forms.Button BudgetsBtn;
        private System.Windows.Forms.Button DashboardBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label UsernameLabel;
        private System.Windows.Forms.Button AddSaving;
        private System.Windows.Forms.Button AddIncome;
        private System.Windows.Forms.Button AddExpense;
        private System.Windows.Forms.Button ProfileBtn;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button ExpensesBtn;
        private System.Windows.Forms.Button IncomeBtn;
    }
}