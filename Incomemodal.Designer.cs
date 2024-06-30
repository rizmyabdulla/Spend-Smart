namespace Spend_Smart
{
    partial class Incomemodal
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.Recuring = new System.Windows.Forms.CheckBox();
            this.IncomeSource = new System.Windows.Forms.TextBox();
            this.AddExpense = new System.Windows.Forms.Button();
            this.Amount = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Category = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Amount)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Recuring);
            this.panel1.Controls.Add(this.IncomeSource);
            this.panel1.Controls.Add(this.AddExpense);
            this.panel1.Controls.Add(this.Amount);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.Category);
            this.panel1.Location = new System.Drawing.Point(12, 51);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(320, 299);
            this.panel1.TabIndex = 3;
            // 
            // Recuring
            // 
            this.Recuring.AutoSize = true;
            this.Recuring.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Recuring.Location = new System.Drawing.Point(78, 200);
            this.Recuring.Name = "Recuring";
            this.Recuring.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Recuring.Size = new System.Drawing.Size(160, 20);
            this.Recuring.TabIndex = 11;
            this.Recuring.Text = "?Recuring Every month";
            this.Recuring.UseVisualStyleBackColor = true;
            // 
            // IncomeSource
            // 
            this.IncomeSource.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(209)))), ((int)(((byte)(209)))));
            this.IncomeSource.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.IncomeSource.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IncomeSource.ForeColor = System.Drawing.Color.Black;
            this.IncomeSource.Location = new System.Drawing.Point(70, 32);
            this.IncomeSource.Name = "IncomeSource";
            this.IncomeSource.Size = new System.Drawing.Size(178, 21);
            this.IncomeSource.TabIndex = 10;
            // 
            // AddExpense
            // 
            this.AddExpense.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.AddExpense.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(146)))), ((int)(((byte)(255)))));
            this.AddExpense.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddExpense.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddExpense.ForeColor = System.Drawing.SystemColors.Control;
            this.AddExpense.Location = new System.Drawing.Point(70, 261);
            this.AddExpense.Name = "AddExpense";
            this.AddExpense.Padding = new System.Windows.Forms.Padding(5);
            this.AddExpense.Size = new System.Drawing.Size(178, 35);
            this.AddExpense.TabIndex = 7;
            this.AddExpense.Text = "ADD INCOME";
            this.AddExpense.UseVisualStyleBackColor = false;
            this.AddExpense.Click += new System.EventHandler(this.AddExpense_Click);
            // 
            // Amount
            // 
            this.Amount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(209)))), ((int)(((byte)(209)))));
            this.Amount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Amount.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Amount.Location = new System.Drawing.Point(73, 94);
            this.Amount.Name = "Amount";
            this.Amount.Size = new System.Drawing.Size(175, 21);
            this.Amount.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(137, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Amount";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(115, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Income Source";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(127, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = " Category";
            // 
            // Category
            // 
            this.Category.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(209)))), ((int)(((byte)(209)))));
            this.Category.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Category.FormattingEnabled = true;
            this.Category.Items.AddRange(new object[] {
            "Salary",
            "Business",
            "Investments",
            "Freelance",
            "Gifts",
            "Other"});
            this.Category.Location = new System.Drawing.Point(73, 148);
            this.Category.Name = "Category";
            this.Category.Size = new System.Drawing.Size(175, 23);
            this.Category.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(120, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "ADD INCOME";
            // 
            // Incomemodal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 369);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Incomemodal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Income Modal";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Amount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox IncomeSource;
        private System.Windows.Forms.Button AddExpense;
        private System.Windows.Forms.NumericUpDown Amount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox Category;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox Recuring;
    }
}