namespace Spend_Smart
{
    partial class DashboardForm
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.cartesianChart1 = new LiveChartsCore.SkiaSharpView.WinForms.CartesianChart();
            this.ExpenseMessageLabel = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.TotalExpensesLabel = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.NetSavingsLabel = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.SavingGoalsLabel = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.TotalIncomeLabel = new System.Windows.Forms.Label();
            this.panel15 = new System.Windows.Forms.Panel();
            this.label31 = new System.Windows.Forms.Label();
            this.BudgetMessageLabel = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel15.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(634, 394);
            this.panel3.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.LightGray;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.ExpenseMessageLabel);
            this.panel4.Controls.Add(this.cartesianChart1);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Location = new System.Drawing.Point(16, 149);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(289, 292);
            this.panel4.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(76, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 15);
            this.label5.TabIndex = 3;
            this.label5.Text = "Top Expense Categories";
            // 
            // cartesianChart1
            // 
            this.cartesianChart1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cartesianChart1.Location = new System.Drawing.Point(3, 34);
            this.cartesianChart1.Name = "cartesianChart1";
            this.cartesianChart1.Size = new System.Drawing.Size(273, 255);
            this.cartesianChart1.TabIndex = 4;
            // 
            // ExpenseMessageLabel
            // 
            this.ExpenseMessageLabel.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.ExpenseMessageLabel.Location = new System.Drawing.Point(39, 119);
            this.ExpenseMessageLabel.Name = "ExpenseMessageLabel";
            this.ExpenseMessageLabel.Size = new System.Drawing.Size(215, 59);
            this.ExpenseMessageLabel.TabIndex = 5;
            this.ExpenseMessageLabel.Text = "Add four or more expenses to show the chart";
            this.ExpenseMessageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.LightGray;
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.panel9);
            this.panel6.Controls.Add(this.panel8);
            this.panel6.Controls.Add(this.panel10);
            this.panel6.Controls.Add(this.panel7);
            this.panel6.Location = new System.Drawing.Point(16, 14);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(594, 104);
            this.panel6.TabIndex = 5;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(146)))), ((int)(((byte)(255)))));
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Controls.Add(this.TotalExpensesLabel);
            this.panel7.Controls.Add(this.label8);
            this.panel7.Location = new System.Drawing.Point(16, 11);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(118, 74);
            this.panel7.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.Control;
            this.label8.Location = new System.Drawing.Point(15, 11);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 15);
            this.label8.TabIndex = 0;
            this.label8.Text = "Total Expenses";
            // 
            // TotalExpensesLabel
            // 
            this.TotalExpensesLabel.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalExpensesLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.TotalExpensesLabel.Location = new System.Drawing.Point(-1, 40);
            this.TotalExpensesLabel.Name = "TotalExpensesLabel";
            this.TotalExpensesLabel.Size = new System.Drawing.Size(118, 22);
            this.TotalExpensesLabel.TabIndex = 1;
            this.TotalExpensesLabel.Text = "$500";
            this.TotalExpensesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(146)))), ((int)(((byte)(255)))));
            this.panel10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel10.Controls.Add(this.NetSavingsLabel);
            this.panel10.Controls.Add(this.label15);
            this.panel10.Location = new System.Drawing.Point(313, 11);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(118, 74);
            this.panel10.TabIndex = 5;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.SystemColors.Control;
            this.label15.Location = new System.Drawing.Point(27, 11);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(66, 15);
            this.label15.TabIndex = 0;
            this.label15.Text = "Net Saving";
            // 
            // NetSavingsLabel
            // 
            this.NetSavingsLabel.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NetSavingsLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.NetSavingsLabel.Location = new System.Drawing.Point(-1, 40);
            this.NetSavingsLabel.Name = "NetSavingsLabel";
            this.NetSavingsLabel.Size = new System.Drawing.Size(118, 22);
            this.NetSavingsLabel.TabIndex = 1;
            this.NetSavingsLabel.Text = "$250";
            this.NetSavingsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(146)))), ((int)(((byte)(255)))));
            this.panel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel8.Controls.Add(this.SavingGoalsLabel);
            this.panel8.Controls.Add(this.label11);
            this.panel8.Location = new System.Drawing.Point(457, 11);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(118, 74);
            this.panel8.TabIndex = 5;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.Control;
            this.label11.Location = new System.Drawing.Point(18, 11);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(80, 15);
            this.label11.TabIndex = 0;
            this.label11.Text = "Saving Goals";
            // 
            // SavingGoalsLabel
            // 
            this.SavingGoalsLabel.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SavingGoalsLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.SavingGoalsLabel.Location = new System.Drawing.Point(-1, 39);
            this.SavingGoalsLabel.Name = "SavingGoalsLabel";
            this.SavingGoalsLabel.Size = new System.Drawing.Size(118, 22);
            this.SavingGoalsLabel.TabIndex = 1;
            this.SavingGoalsLabel.Text = "6";
            this.SavingGoalsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(146)))), ((int)(((byte)(255)))));
            this.panel9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel9.Controls.Add(this.TotalIncomeLabel);
            this.panel9.Controls.Add(this.label13);
            this.panel9.Location = new System.Drawing.Point(166, 11);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(118, 74);
            this.panel9.TabIndex = 5;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.Control;
            this.label13.Location = new System.Drawing.Point(19, 11);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(77, 15);
            this.label13.TabIndex = 0;
            this.label13.Text = "Total Income";
            // 
            // TotalIncomeLabel
            // 
            this.TotalIncomeLabel.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalIncomeLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.TotalIncomeLabel.Location = new System.Drawing.Point(-1, 40);
            this.TotalIncomeLabel.Name = "TotalIncomeLabel";
            this.TotalIncomeLabel.Size = new System.Drawing.Size(118, 22);
            this.TotalIncomeLabel.TabIndex = 1;
            this.TotalIncomeLabel.Text = "$10500";
            this.TotalIncomeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel15
            // 
            this.panel15.BackColor = System.Drawing.Color.LightGray;
            this.panel15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel15.Controls.Add(this.BudgetMessageLabel);
            this.panel15.Controls.Add(this.label31);
            this.panel15.Location = new System.Drawing.Point(321, 149);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(289, 292);
            this.panel15.TabIndex = 8;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label31.Location = new System.Drawing.Point(105, 9);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(84, 15);
            this.label31.TabIndex = 3;
            this.label31.Text = "Budget Status";
            // 
            // BudgetMessageLabel
            // 
            this.BudgetMessageLabel.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.BudgetMessageLabel.Location = new System.Drawing.Point(36, 119);
            this.BudgetMessageLabel.Name = "BudgetMessageLabel";
            this.BudgetMessageLabel.Size = new System.Drawing.Size(215, 59);
            this.BudgetMessageLabel.TabIndex = 6;
            this.BudgetMessageLabel.Text = "Add two or more budgets to show the chart";
            this.BudgetMessageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel5
            // 
            this.panel5.AutoScroll = true;
            this.panel5.AutoScrollMargin = new System.Drawing.Size(0, 20);
            this.panel5.Controls.Add(this.panel15);
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Controls.Add(this.panel4);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Padding = new System.Windows.Forms.Padding(3);
            this.panel5.Size = new System.Drawing.Size(634, 394);
            this.panel5.TabIndex = 6;
            // 
            // DashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 394);
            this.Controls.Add(this.panel3);
            this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DashboardForm";
            this.Text = "Dashboard";
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel15.ResumeLayout(false);
            this.panel15.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.Label BudgetMessageLabel;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label TotalIncomeLabel;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label SavingGoalsLabel;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Label NetSavingsLabel;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label TotalExpensesLabel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label ExpenseMessageLabel;
        private LiveChartsCore.SkiaSharpView.WinForms.CartesianChart cartesianChart1;
        private System.Windows.Forms.Label label5;
    }
}