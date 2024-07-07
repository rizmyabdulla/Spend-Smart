namespace Spend_Smart
{
    partial class BudgetsForm
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
            this.panel5 = new System.Windows.Forms.Panel();
            this.AddBudgetBtn = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.SumOfBudgets = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.panel11 = new System.Windows.Forms.Panel();
            this.BudgetsCount = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.BudgetTable = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel11.SuspendLayout();
            this.BudgetTable.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(618, 355);
            this.panel3.TabIndex = 6;
            // 
            // panel5
            // 
            this.panel5.AutoScroll = true;
            this.panel5.AutoScrollMargin = new System.Drawing.Size(0, 20);
            this.panel5.Controls.Add(this.AddBudgetBtn);
            this.panel5.Controls.Add(this.panel4);
            this.panel5.Controls.Add(this.BudgetTable);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Padding = new System.Windows.Forms.Padding(3);
            this.panel5.Size = new System.Drawing.Size(618, 355);
            this.panel5.TabIndex = 6;
            // 
            // AddBudgetBtn
            // 
            this.AddBudgetBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.AddBudgetBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.AddBudgetBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddBudgetBtn.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddBudgetBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.AddBudgetBtn.Location = new System.Drawing.Point(440, 117);
            this.AddBudgetBtn.Name = "AddBudgetBtn";
            this.AddBudgetBtn.Size = new System.Drawing.Size(166, 27);
            this.AddBudgetBtn.TabIndex = 10;
            this.AddBudgetBtn.Text = "+ Add Budget for an expense";
            this.AddBudgetBtn.UseVisualStyleBackColor = false;
            this.AddBudgetBtn.Click += new System.EventHandler(this.AddBudgetBtn_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.LightGray;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.panel8);
            this.panel4.Controls.Add(this.panel11);
            this.panel4.Location = new System.Drawing.Point(16, 25);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(295, 103);
            this.panel4.TabIndex = 9;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(146)))), ((int)(((byte)(255)))));
            this.panel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel8.Controls.Add(this.SumOfBudgets);
            this.panel8.Controls.Add(this.label15);
            this.panel8.Location = new System.Drawing.Point(158, 13);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(118, 74);
            this.panel8.TabIndex = 5;
            // 
            // SumOfBudgets
            // 
            this.SumOfBudgets.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SumOfBudgets.ForeColor = System.Drawing.SystemColors.Control;
            this.SumOfBudgets.Location = new System.Drawing.Point(-1, 40);
            this.SumOfBudgets.Name = "SumOfBudgets";
            this.SumOfBudgets.Size = new System.Drawing.Size(118, 22);
            this.SumOfBudgets.TabIndex = 1;
            this.SumOfBudgets.Text = "$15,300";
            this.SumOfBudgets.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label15
            // 
            this.label15.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.SystemColors.Control;
            this.label15.Location = new System.Drawing.Point(21, 5);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(80, 34);
            this.label15.TabIndex = 0;
            this.label15.Text = "Total Budget amount";
            this.label15.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(146)))), ((int)(((byte)(255)))));
            this.panel11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel11.Controls.Add(this.BudgetsCount);
            this.panel11.Controls.Add(this.label19);
            this.panel11.Location = new System.Drawing.Point(13, 13);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(118, 74);
            this.panel11.TabIndex = 4;
            // 
            // BudgetsCount
            // 
            this.BudgetsCount.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BudgetsCount.ForeColor = System.Drawing.SystemColors.Control;
            this.BudgetsCount.Location = new System.Drawing.Point(-1, 40);
            this.BudgetsCount.Name = "BudgetsCount";
            this.BudgetsCount.Size = new System.Drawing.Size(118, 22);
            this.BudgetsCount.TabIndex = 1;
            this.BudgetsCount.Text = "0";
            this.BudgetsCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label19
            // 
            this.label19.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.SystemColors.Control;
            this.label19.Location = new System.Drawing.Point(12, 9);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(91, 20);
            this.label19.TabIndex = 0;
            this.label19.Text = "Total Budgets";
            this.label19.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // BudgetTable
            // 
            this.BudgetTable.AutoSize = true;
            this.BudgetTable.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.BudgetTable.ColumnCount = 5;
            this.BudgetTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.21408F));
            this.BudgetTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.23885F));
            this.BudgetTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.70195F));
            this.BudgetTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.BudgetTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.17845F));
            this.BudgetTable.Controls.Add(this.label3, 4, 0);
            this.BudgetTable.Controls.Add(this.label2, 1, 0);
            this.BudgetTable.Controls.Add(this.label1, 0, 0);
            this.BudgetTable.Controls.Add(this.label4, 1, 1);
            this.BudgetTable.Controls.Add(this.label6, 0, 1);
            this.BudgetTable.Controls.Add(this.panel1, 4, 1);
            this.BudgetTable.Controls.Add(this.label20, 2, 0);
            this.BudgetTable.Controls.Add(this.label24, 2, 1);
            this.BudgetTable.Controls.Add(this.label5, 3, 0);
            this.BudgetTable.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BudgetTable.Location = new System.Drawing.Point(16, 150);
            this.BudgetTable.Name = "BudgetTable";
            this.BudgetTable.RowCount = 2;
            this.BudgetTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.BudgetTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.BudgetTable.Size = new System.Drawing.Size(601, 75);
            this.BudgetTable.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(477, 11);
            this.label3.Margin = new System.Windows.Forms.Padding(10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Action";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(144, 11);
            this.label2.Margin = new System.Windows.Forms.Padding(10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Amount";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Budget Name";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(253, 11);
            this.label20.Margin = new System.Windows.Forms.Padding(10);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(74, 18);
            this.label20.TabIndex = 15;
            this.label20.Text = "Due Date";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Arial", 9.75F);
            this.label24.Location = new System.Drawing.Point(253, 52);
            this.label24.Margin = new System.Windows.Forms.Padding(10, 10, 0, 0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(64, 16);
            this.label24.TabIndex = 19;
            this.label24.Text = "2024/7/22";
            this.label24.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(146)))), ((int)(((byte)(255)))));
            this.linkLabel1.Location = new System.Drawing.Point(7, 5);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(35, 16);
            this.linkLabel1.TabIndex = 0;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "EDIT";
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel2.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(146)))), ((int)(((byte)(255)))));
            this.linkLabel2.Location = new System.Drawing.Point(48, 5);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(57, 16);
            this.linkLabel2.TabIndex = 1;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "DELETE";
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.linkLabel2);
            this.panel1.Controls.Add(this.linkLabel1);
            this.panel1.Location = new System.Drawing.Point(470, 45);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(108, 21);
            this.panel1.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9.75F);
            this.label6.Location = new System.Drawing.Point(11, 52);
            this.label6.Margin = new System.Windows.Forms.Padding(10, 10, 0, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Buy a Car";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F);
            this.label4.Location = new System.Drawing.Point(144, 52);
            this.label4.Margin = new System.Windows.Forms.Padding(10, 10, 0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "$25,000";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(377, 11);
            this.label5.Margin = new System.Windows.Forms.Padding(10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 18);
            this.label5.TabIndex = 20;
            this.label5.Text = "Recurring";
            // 
            // BudgetsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 355);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BudgetsForm";
            this.Text = "BudgetsForm";
            this.panel3.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            this.BudgetTable.ResumeLayout(false);
            this.BudgetTable.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label SumOfBudgets;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Label BudgetsCount;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TableLayoutPanel BudgetTable;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Button AddBudgetBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label5;
    }
}