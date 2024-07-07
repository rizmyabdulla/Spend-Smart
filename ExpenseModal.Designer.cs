namespace Spend_Smart
{
    partial class ExpenseModal
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
            this.ModalTitle = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Recuring = new System.Windows.Forms.CheckBox();
            this.Amount = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SubCat = new System.Windows.Forms.ComboBox();
            this.AddExpense = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.MainCat = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Amount)).BeginInit();
            this.SuspendLayout();
            // 
            // ModalTitle
            // 
            this.ModalTitle.AutoSize = true;
            this.ModalTitle.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModalTitle.Location = new System.Drawing.Point(111, 20);
            this.ModalTitle.Name = "ModalTitle";
            this.ModalTitle.Size = new System.Drawing.Size(126, 19);
            this.ModalTitle.TabIndex = 0;
            this.ModalTitle.Text = "ADD EXPENSE";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.NameBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Recuring);
            this.panel1.Controls.Add(this.Amount);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.SubCat);
            this.panel1.Controls.Add(this.AddExpense);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.MainCat);
            this.panel1.Location = new System.Drawing.Point(12, 44);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(320, 313);
            this.panel1.TabIndex = 1;
            // 
            // Recuring
            // 
            this.Recuring.AutoSize = true;
            this.Recuring.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Recuring.Location = new System.Drawing.Point(82, 227);
            this.Recuring.Name = "Recuring";
            this.Recuring.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Recuring.Size = new System.Drawing.Size(160, 20);
            this.Recuring.TabIndex = 15;
            this.Recuring.Text = "?Recuring Every month";
            this.Recuring.UseVisualStyleBackColor = true;
            // 
            // Amount
            // 
            this.Amount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(209)))), ((int)(((byte)(209)))));
            this.Amount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Amount.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Amount.Location = new System.Drawing.Point(73, 195);
            this.Amount.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.Amount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Amount.Name = "Amount";
            this.Amount.Size = new System.Drawing.Size(175, 21);
            this.Amount.TabIndex = 14;
            this.Amount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(138, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 16);
            this.label4.TabIndex = 13;
            this.label4.Text = "Amount";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(120, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Sub Category";
            // 
            // SubCat
            // 
            this.SubCat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(209)))), ((int)(((byte)(209)))));
            this.SubCat.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubCat.FormattingEnabled = true;
            this.SubCat.Location = new System.Drawing.Point(73, 140);
            this.SubCat.Name = "SubCat";
            this.SubCat.Size = new System.Drawing.Size(175, 23);
            this.SubCat.TabIndex = 8;
            // 
            // AddExpense
            // 
            this.AddExpense.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.AddExpense.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(146)))), ((int)(((byte)(255)))));
            this.AddExpense.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddExpense.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddExpense.ForeColor = System.Drawing.SystemColors.Control;
            this.AddExpense.Location = new System.Drawing.Point(71, 275);
            this.AddExpense.Name = "AddExpense";
            this.AddExpense.Padding = new System.Windows.Forms.Padding(5);
            this.AddExpense.Size = new System.Drawing.Size(178, 35);
            this.AddExpense.TabIndex = 7;
            this.AddExpense.Text = "ADD EXPENSE";
            this.AddExpense.UseVisualStyleBackColor = false;
            this.AddExpense.Click += new System.EventHandler(this.AddExpense_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(133, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Category";
            // 
            // MainCat
            // 
            this.MainCat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(209)))), ((int)(((byte)(209)))));
            this.MainCat.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainCat.FormattingEnabled = true;
            this.MainCat.Items.AddRange(new object[] {
            "Essentials",
            "Non-Essentials",
            "Savings and Investments",
            "Debt Payments",
            "Miscellaneous"});
            this.MainCat.Location = new System.Drawing.Point(73, 84);
            this.MainCat.Name = "MainCat";
            this.MainCat.Size = new System.Drawing.Size(175, 23);
            this.MainCat.TabIndex = 0;
            this.MainCat.SelectedIndexChanged += new System.EventHandler(this.MainCat_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(142, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 16);
            this.label1.TabIndex = 16;
            this.label1.Text = "Name";
            // 
            // NameBox
            // 
            this.NameBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(209)))), ((int)(((byte)(209)))));
            this.NameBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NameBox.Location = new System.Drawing.Point(71, 30);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(177, 22);
            this.NameBox.TabIndex = 17;
            // 
            // ExpenseModal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 369);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ModalTitle);
            this.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ExpenseModal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add Expense";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Amount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ModalTitle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox MainCat;
        private System.Windows.Forms.Button AddExpense;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox SubCat;
        private System.Windows.Forms.NumericUpDown Amount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox Recuring;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.Label label1;
    }
}