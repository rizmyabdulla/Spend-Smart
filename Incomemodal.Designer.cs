namespace Spend_Smart
{
    partial class IncomeModal
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Amount = new System.Windows.Forms.NumericUpDown();
            this.AddIncome = new System.Windows.Forms.Button();
            this.IncomeSource = new System.Windows.Forms.TextBox();
            this.Recurring = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.Amount)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ModalTitle
            // 
            this.ModalTitle.AutoSize = true;
            this.ModalTitle.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModalTitle.Location = new System.Drawing.Point(120, 18);
            this.ModalTitle.Name = "ModalTitle";
            this.ModalTitle.Size = new System.Drawing.Size(112, 19);
            this.ModalTitle.TabIndex = 2;
            this.ModalTitle.Text = "ADD INCOME";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(115, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Income Source";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(137, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Amount";
            // 
            // Amount
            // 
            this.Amount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(209)))), ((int)(((byte)(209)))));
            this.Amount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Amount.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Amount.Location = new System.Drawing.Point(73, 105);
            this.Amount.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.Amount.Name = "Amount";
            this.Amount.Size = new System.Drawing.Size(175, 21);
            this.Amount.TabIndex = 6;
            // 
            // AddIncome
            // 
            this.AddIncome.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.AddIncome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(146)))), ((int)(((byte)(255)))));
            this.AddIncome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddIncome.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddIncome.ForeColor = System.Drawing.SystemColors.Control;
            this.AddIncome.Location = new System.Drawing.Point(70, 261);
            this.AddIncome.Name = "AddIncome";
            this.AddIncome.Padding = new System.Windows.Forms.Padding(5);
            this.AddIncome.Size = new System.Drawing.Size(178, 35);
            this.AddIncome.TabIndex = 7;
            this.AddIncome.Text = "ADD INCOME";
            this.AddIncome.UseVisualStyleBackColor = false;
            this.AddIncome.Click += new System.EventHandler(this.AddIncome_Click);
            // 
            // IncomeSource
            // 
            this.IncomeSource.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(209)))), ((int)(((byte)(209)))));
            this.IncomeSource.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.IncomeSource.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IncomeSource.ForeColor = System.Drawing.Color.Black;
            this.IncomeSource.Location = new System.Drawing.Point(70, 43);
            this.IncomeSource.Name = "IncomeSource";
            this.IncomeSource.Size = new System.Drawing.Size(178, 21);
            this.IncomeSource.TabIndex = 10;
            // 
            // Recurring
            // 
            this.Recurring.AutoSize = true;
            this.Recurring.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Recurring.Location = new System.Drawing.Point(81, 152);
            this.Recurring.Name = "Recurring";
            this.Recurring.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Recurring.Size = new System.Drawing.Size(160, 20);
            this.Recurring.TabIndex = 11;
            this.Recurring.Text = "?Recuring Every month";
            this.Recurring.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Recurring);
            this.panel1.Controls.Add(this.IncomeSource);
            this.panel1.Controls.Add(this.AddIncome);
            this.panel1.Controls.Add(this.Amount);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(12, 51);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(320, 299);
            this.panel1.TabIndex = 3;
            // 
            // IncomeModal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 369);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ModalTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "IncomeModal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Income Modal";
            ((System.ComponentModel.ISupportInitialize)(this.Amount)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ModalTitle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown Amount;
        private System.Windows.Forms.Button AddIncome;
        private System.Windows.Forms.TextBox IncomeSource;
        private System.Windows.Forms.CheckBox Recurring;
        private System.Windows.Forms.Panel panel1;
    }
}