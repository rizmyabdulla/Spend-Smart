namespace Spend_Smart
{
    partial class SavingModal
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
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.IncomeSource = new System.Windows.Forms.TextBox();
            this.AddSaving = new System.Windows.Forms.Button();
            this.Amount = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Amount)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.numericUpDown1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.IncomeSource);
            this.panel1.Controls.Add(this.AddSaving);
            this.panel1.Controls.Add(this.Amount);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(12, 51);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(320, 299);
            this.panel1.TabIndex = 5;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(209)))), ((int)(((byte)(209)))));
            this.numericUpDown1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericUpDown1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown1.Location = new System.Drawing.Point(73, 160);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(175, 21);
            this.numericUpDown1.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(91, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "Saved Amount So Far";
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
            // AddSaving
            // 
            this.AddSaving.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.AddSaving.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(146)))), ((int)(((byte)(255)))));
            this.AddSaving.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddSaving.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddSaving.ForeColor = System.Drawing.SystemColors.Control;
            this.AddSaving.Location = new System.Drawing.Point(70, 261);
            this.AddSaving.Name = "AddSaving";
            this.AddSaving.Padding = new System.Windows.Forms.Padding(5);
            this.AddSaving.Size = new System.Drawing.Size(178, 35);
            this.AddSaving.TabIndex = 7;
            this.AddSaving.Text = "ADD INCOME";
            this.AddSaving.UseVisualStyleBackColor = false;
            this.AddSaving.Click += new System.EventHandler(this.AddSaving_Click);
            // 
            // Amount
            // 
            this.Amount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(209)))), ((int)(((byte)(209)))));
            this.Amount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Amount.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Amount.Location = new System.Drawing.Point(73, 96);
            this.Amount.Name = "Amount";
            this.Amount.Size = new System.Drawing.Size(175, 21);
            this.Amount.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(137, 74);
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
            this.label3.Size = new System.Drawing.Size(83, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Saving Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(118, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "ADD SAVING";
            // 
            // SavingModal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 369);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "SavingModal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Saving Modal";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Amount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox IncomeSource;
        private System.Windows.Forms.Button AddSaving;
        private System.Windows.Forms.NumericUpDown Amount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label2;
    }
}