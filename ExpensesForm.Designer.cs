namespace Spend_Smart
{
    partial class ExpensesForm
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
            this.ExpenseTable = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.ExpensesChart = new LiveChartsCore.SkiaSharpView.WinForms.CartesianChart();
            this.label5 = new System.Windows.Forms.Label();
            this.mySqlDataAdapter1 = new MySql.Data.MySqlClient.MySqlDataAdapter();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.ExpenseTable.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(602, 316);
            this.panel3.TabIndex = 4;
            // 
            // panel5
            // 
            this.panel5.AutoScroll = true;
            this.panel5.AutoScrollMargin = new System.Drawing.Size(0, 20);
            this.panel5.Controls.Add(this.ExpenseTable);
            this.panel5.Controls.Add(this.panel4);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Padding = new System.Windows.Forms.Padding(3);
            this.panel5.Size = new System.Drawing.Size(602, 316);
            this.panel5.TabIndex = 6;
            // 
            // ExpenseTable
            // 
            this.ExpenseTable.AutoSize = true;
            this.ExpenseTable.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.ExpenseTable.ColumnCount = 5;
            this.ExpenseTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.40145F));
            this.ExpenseTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.77789F));
            this.ExpenseTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.25495F));
            this.ExpenseTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.85563F));
            this.ExpenseTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.71008F));
            this.ExpenseTable.Controls.Add(this.label3, 4, 0);
            this.ExpenseTable.Controls.Add(this.label2, 1, 0);
            this.ExpenseTable.Controls.Add(this.label1, 0, 0);
            this.ExpenseTable.Controls.Add(this.label4, 1, 1);
            this.ExpenseTable.Controls.Add(this.label6, 0, 1);
            this.ExpenseTable.Controls.Add(this.label20, 2, 0);
            this.ExpenseTable.Controls.Add(this.label21, 3, 0);
            this.ExpenseTable.Controls.Add(this.label24, 2, 1);
            this.ExpenseTable.Controls.Add(this.label25, 3, 1);
            this.ExpenseTable.Controls.Add(this.flowLayoutPanel1, 4, 1);
            this.ExpenseTable.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExpenseTable.Location = new System.Drawing.Point(9, 258);
            this.ExpenseTable.Name = "ExpenseTable";
            this.ExpenseTable.RowCount = 2;
            this.ExpenseTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.ExpenseTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.ExpenseTable.Size = new System.Drawing.Size(601, 169);
            this.ExpenseTable.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(479, 11);
            this.label3.Margin = new System.Windows.Forms.Padding(10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Action";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(109, 11);
            this.label2.Margin = new System.Windows.Forms.Padding(10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Category";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Is Recurring";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(109, 52);
            this.label4.Margin = new System.Windows.Forms.Padding(10, 10, 0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 14);
            this.label4.TabIndex = 4;
            this.label4.Text = "Essentials";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(11, 52);
            this.label6.Margin = new System.Windows.Forms.Padding(10, 10, 0, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "YES";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(269, 11);
            this.label20.Margin = new System.Windows.Forms.Padding(10);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(83, 15);
            this.label20.TabIndex = 15;
            this.label20.Text = "Sub Category";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(396, 11);
            this.label21.Margin = new System.Windows.Forms.Padding(10);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(51, 15);
            this.label21.TabIndex = 16;
            this.label21.Text = "Amount";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(269, 52);
            this.label24.Margin = new System.Windows.Forms.Padding(10, 10, 0, 0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(46, 14);
            this.label24.TabIndex = 19;
            this.label24.Text = "Housing";
            this.label24.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(396, 52);
            this.label25.Margin = new System.Windows.Forms.Padding(10, 10, 0, 0);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(35, 15);
            this.label25.TabIndex = 20;
            this.label25.Text = "$200";
            this.label25.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.panel1);
            this.flowLayoutPanel1.Controls.Add(this.linkLabel1);
            this.flowLayoutPanel1.Controls.Add(this.linkLabel2);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(472, 45);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(70, 72);
            this.flowLayoutPanel1.TabIndex = 21;
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(0, 0);
            this.panel1.TabIndex = 4;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(146)))), ((int)(((byte)(255)))));
            this.linkLabel1.Location = new System.Drawing.Point(3, 6);
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
            this.linkLabel2.Location = new System.Drawing.Point(3, 32);
            this.linkLabel2.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(57, 16);
            this.linkLabel2.TabIndex = 1;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "DELETE";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.LightGray;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.ExpensesChart);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Location = new System.Drawing.Point(12, 12);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(578, 227);
            this.panel4.TabIndex = 3;
            // 
            // ExpensesChart
            // 
            this.ExpensesChart.Font = new System.Drawing.Font("Symbol", 8.25F);
            this.ExpensesChart.Location = new System.Drawing.Point(3, 34);
            this.ExpensesChart.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ExpensesChart.Name = "ExpensesChart";
            this.ExpensesChart.Size = new System.Drawing.Size(568, 189);
            this.ExpensesChart.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(201, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(195, 15);
            this.label5.TabIndex = 3;
            this.label5.Text = "All Expense Categories (Bar chart)";
            // 
            // mySqlDataAdapter1
            // 
            this.mySqlDataAdapter1.DeleteCommand = null;
            this.mySqlDataAdapter1.InsertCommand = null;
            this.mySqlDataAdapter1.SelectCommand = null;
            this.mySqlDataAdapter1.UpdateCommand = null;
            // 
            // ExpensesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 316);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ExpensesForm";
            this.Text = "ExpensesForm";
            this.panel3.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ExpenseTable.ResumeLayout(false);
            this.ExpenseTable.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private LiveChartsCore.SkiaSharpView.WinForms.CartesianChart ExpensesChart;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TableLayoutPanel ExpenseTable;
        private System.Windows.Forms.Label label3;
        private MySql.Data.MySqlClient.MySqlDataAdapter mySqlDataAdapter1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel linkLabel2;
    }
}