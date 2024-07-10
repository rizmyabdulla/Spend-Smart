namespace Spend_Smart
{
    partial class IncomeForm
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
            this.panel5 = new System.Windows.Forms.Panel();
            this.ChartMessageLabel = new System.Windows.Forms.Label();
            this.IncomeChart = new LiveChartsCore.SkiaSharpView.WinForms.PieChart();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.TotalIncomeAmount = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.panel11 = new System.Windows.Forms.Panel();
            this.SourcesCount = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.IncomeTable = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label20 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel11.SuspendLayout();
            this.IncomeTable.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel5
            // 
            this.panel5.AutoScroll = true;
            this.panel5.AutoScrollMargin = new System.Drawing.Size(0, 20);
            this.panel5.Controls.Add(this.ChartMessageLabel);
            this.panel5.Controls.Add(this.IncomeChart);
            this.panel5.Controls.Add(this.panel4);
            this.panel5.Controls.Add(this.IncomeTable);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Padding = new System.Windows.Forms.Padding(3);
            this.panel5.Size = new System.Drawing.Size(618, 355);
            this.panel5.TabIndex = 7;
            // 
            // ChartMessageLabel
            // 
            this.ChartMessageLabel.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.ChartMessageLabel.Location = new System.Drawing.Point(93, 93);
            this.ChartMessageLabel.Name = "ChartMessageLabel";
            this.ChartMessageLabel.Size = new System.Drawing.Size(215, 59);
            this.ChartMessageLabel.TabIndex = 11;
            this.ChartMessageLabel.Text = "Add one or more Income to show the chart";
            this.ChartMessageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // IncomeChart
            // 
            this.IncomeChart.InitialRotation = 0D;
            this.IncomeChart.IsClockwise = true;
            this.IncomeChart.Location = new System.Drawing.Point(56, 16);
            this.IncomeChart.MaxAngle = 360D;
            this.IncomeChart.MaxValue = null;
            this.IncomeChart.MinValue = 0D;
            this.IncomeChart.Name = "IncomeChart";
            this.IncomeChart.Size = new System.Drawing.Size(287, 211);
            this.IncomeChart.TabIndex = 10;
            this.IncomeChart.MaxValue = null;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.LightGray;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.panel8);
            this.panel4.Controls.Add(this.panel11);
            this.panel4.Location = new System.Drawing.Point(379, 31);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(148, 183);
            this.panel4.TabIndex = 9;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(146)))), ((int)(((byte)(255)))));
            this.panel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel8.Controls.Add(this.TotalIncomeAmount);
            this.panel8.Controls.Add(this.label15);
            this.panel8.Location = new System.Drawing.Point(14, 97);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(118, 74);
            this.panel8.TabIndex = 5;
            // 
            // TotalIncomeAmount
            // 
            this.TotalIncomeAmount.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalIncomeAmount.ForeColor = System.Drawing.SystemColors.Control;
            this.TotalIncomeAmount.Location = new System.Drawing.Point(-1, 40);
            this.TotalIncomeAmount.Name = "TotalIncomeAmount";
            this.TotalIncomeAmount.Size = new System.Drawing.Size(118, 22);
            this.TotalIncomeAmount.TabIndex = 1;
            this.TotalIncomeAmount.Text = "$15,300";
            this.TotalIncomeAmount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label15
            // 
            this.label15.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.SystemColors.Control;
            this.label15.Location = new System.Drawing.Point(21, 11);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(80, 24);
            this.label15.TabIndex = 0;
            this.label15.Text = "Total Income";
            this.label15.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(146)))), ((int)(((byte)(255)))));
            this.panel11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel11.Controls.Add(this.SourcesCount);
            this.panel11.Controls.Add(this.label19);
            this.panel11.Location = new System.Drawing.Point(14, 9);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(118, 74);
            this.panel11.TabIndex = 4;
            // 
            // SourcesCount
            // 
            this.SourcesCount.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SourcesCount.ForeColor = System.Drawing.SystemColors.Control;
            this.SourcesCount.Location = new System.Drawing.Point(-1, 40);
            this.SourcesCount.Name = "SourcesCount";
            this.SourcesCount.Size = new System.Drawing.Size(118, 22);
            this.SourcesCount.TabIndex = 1;
            this.SourcesCount.Text = "5";
            this.SourcesCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label19
            // 
            this.label19.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.SystemColors.Control;
            this.label19.Location = new System.Drawing.Point(12, 5);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(91, 35);
            this.label19.TabIndex = 0;
            this.label19.Text = "Total Income Sources";
            this.label19.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // IncomeTable
            // 
            this.IncomeTable.AutoSize = true;
            this.IncomeTable.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.IncomeTable.ColumnCount = 4;
            this.IncomeTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.6569F));
            this.IncomeTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.88662F));
            this.IncomeTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.84234F));
            this.IncomeTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.61414F));
            this.IncomeTable.Controls.Add(this.label3, 3, 0);
            this.IncomeTable.Controls.Add(this.label2, 1, 0);
            this.IncomeTable.Controls.Add(this.label1, 0, 0);
            this.IncomeTable.Controls.Add(this.label4, 1, 1);
            this.IncomeTable.Controls.Add(this.label6, 0, 1);
            this.IncomeTable.Controls.Add(this.panel1, 3, 1);
            this.IncomeTable.Controls.Add(this.label20, 2, 0);
            this.IncomeTable.Controls.Add(this.label24, 2, 1);
            this.IncomeTable.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IncomeTable.Location = new System.Drawing.Point(16, 240);
            this.IncomeTable.Name = "IncomeTable";
            this.IncomeTable.RowCount = 2;
            this.IncomeTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.IncomeTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.IncomeTable.Size = new System.Drawing.Size(590, 186);
            this.IncomeTable.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(442, 11);
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
            this.label2.Location = new System.Drawing.Point(167, 11);
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
            this.label1.Size = new System.Drawing.Size(114, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Income Source";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F);
            this.label4.Location = new System.Drawing.Point(167, 52);
            this.label4.Margin = new System.Windows.Forms.Padding(10, 10, 0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "$25,000";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9.75F);
            this.label6.Location = new System.Drawing.Point(11, 52);
            this.label6.Margin = new System.Windows.Forms.Padding(10, 10, 0, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Office Work";
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.linkLabel2);
            this.panel1.Controls.Add(this.linkLabel1);
            this.panel1.Location = new System.Drawing.Point(435, 45);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(108, 21);
            this.panel1.TabIndex = 3;
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
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(296, 11);
            this.label20.Margin = new System.Windows.Forms.Padding(10);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(73, 18);
            this.label20.TabIndex = 15;
            this.label20.Text = "Recuring";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Arial", 9.75F);
            this.label24.Location = new System.Drawing.Point(296, 52);
            this.label24.Margin = new System.Windows.Forms.Padding(10, 10, 0, 0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(32, 16);
            this.label24.TabIndex = 19;
            this.label24.Text = "True";
            this.label24.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // IncomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 355);
            this.Controls.Add(this.panel5);
            this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "IncomeForm";
            this.Text = "IncomeForm";
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            this.IncomeTable.ResumeLayout(false);
            this.IncomeTable.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label TotalIncomeAmount;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Label SourcesCount;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TableLayoutPanel IncomeTable;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label24;
        private LiveChartsCore.SkiaSharpView.WinForms.PieChart IncomeChart;
        private System.Windows.Forms.Label ChartMessageLabel;
    }
}