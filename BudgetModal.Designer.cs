namespace Spend_Smart
{
    partial class BudgetModal
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
            this.label1 = new System.Windows.Forms.Label();
            this.DueDate = new System.Windows.Forms.DateTimePicker();
            this.Recurring = new System.Windows.Forms.CheckBox();
            this.Amount = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.AddBudget = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.ExpenseChooser = new System.Windows.Forms.ComboBox();
            this.ModalTitle = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Amount)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.DueDate);
            this.panel1.Controls.Add(this.Recurring);
            this.panel1.Controls.Add(this.Amount);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.AddBudget);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.ExpenseChooser);
            this.panel1.Location = new System.Drawing.Point(12, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(320, 313);
            this.panel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(138, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 16);
            this.label1.TabIndex = 17;
            this.label1.Text = "Due Date";
            // 
            // DueDate
            // 
            this.DueDate.Location = new System.Drawing.Point(71, 102);
            this.DueDate.Name = "DueDate";
            this.DueDate.Size = new System.Drawing.Size(178, 20);
            this.DueDate.TabIndex = 16;
            // 
            // Recurring
            // 
            this.Recurring.AutoSize = true;
            this.Recurring.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Recurring.Location = new System.Drawing.Point(82, 198);
            this.Recurring.Name = "Recurring";
            this.Recurring.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Recurring.Size = new System.Drawing.Size(164, 20);
            this.Recurring.TabIndex = 15;
            this.Recurring.Text = "?Recurring Every month";
            this.Recurring.UseVisualStyleBackColor = true;
            // 
            // Amount
            // 
            this.Amount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(209)))), ((int)(((byte)(209)))));
            this.Amount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Amount.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Amount.Location = new System.Drawing.Point(73, 157);
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
            this.label4.Location = new System.Drawing.Point(138, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 16);
            this.label4.TabIndex = 13;
            this.label4.Text = "Amount";
            // 
            // AddBudget
            // 
            this.AddBudget.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.AddBudget.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(146)))), ((int)(((byte)(255)))));
            this.AddBudget.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddBudget.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddBudget.ForeColor = System.Drawing.SystemColors.Control;
            this.AddBudget.Location = new System.Drawing.Point(71, 275);
            this.AddBudget.Name = "AddBudget";
            this.AddBudget.Padding = new System.Windows.Forms.Padding(5);
            this.AddBudget.Size = new System.Drawing.Size(178, 35);
            this.AddBudget.TabIndex = 7;
            this.AddBudget.Text = "ADD BUDGET";
            this.AddBudget.UseVisualStyleBackColor = false;
            this.AddBudget.Click += new System.EventHandler(this.AddBudget_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(102, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Choose an Expense";
            // 
            // ExpenseChooser
            // 
            this.ExpenseChooser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(209)))), ((int)(((byte)(209)))));
            this.ExpenseChooser.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExpenseChooser.FormattingEnabled = true;
            this.ExpenseChooser.Location = new System.Drawing.Point(73, 43);
            this.ExpenseChooser.Name = "ExpenseChooser";
            this.ExpenseChooser.Size = new System.Drawing.Size(175, 23);
            this.ExpenseChooser.TabIndex = 0;
            // 
            // ModalTitle
            // 
            this.ModalTitle.AutoSize = true;
            this.ModalTitle.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModalTitle.Location = new System.Drawing.Point(118, 16);
            this.ModalTitle.Name = "ModalTitle";
            this.ModalTitle.Size = new System.Drawing.Size(117, 19);
            this.ModalTitle.TabIndex = 2;
            this.ModalTitle.Text = "ADD BUDGET";
            // 
            // BudgetModal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 369);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ModalTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BudgetModal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Budget Modal";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Amount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox Recurring;
        private System.Windows.Forms.NumericUpDown Amount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button AddBudget;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox ExpenseChooser;
        private System.Windows.Forms.Label ModalTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker DueDate;
    }
}