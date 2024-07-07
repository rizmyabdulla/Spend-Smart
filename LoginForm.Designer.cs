
namespace Spend_Smart
{
    partial class LoginForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.UsernameField = new System.Windows.Forms.TextBox();
            this.LoginBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.PasswordField = new System.Windows.Forms.TextBox();
            this.RegisterLink = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(313, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "SPEND SMART";
            // 
            // UsernameField
            // 
            this.UsernameField.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(209)))), ((int)(((byte)(209)))));
            this.UsernameField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UsernameField.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameField.ForeColor = System.Drawing.Color.Black;
            this.UsernameField.Location = new System.Drawing.Point(82, 84);
            this.UsernameField.Name = "UsernameField";
            this.UsernameField.Size = new System.Drawing.Size(178, 21);
            this.UsernameField.TabIndex = 3;
            // 
            // LoginBtn
            // 
            this.LoginBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(146)))), ((int)(((byte)(255)))));
            this.LoginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoginBtn.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.LoginBtn.Location = new System.Drawing.Point(82, 191);
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.Padding = new System.Windows.Forms.Padding(5);
            this.LoginBtn.Size = new System.Drawing.Size(178, 34);
            this.LoginBtn.TabIndex = 5;
            this.LoginBtn.Text = "LOGIN";
            this.LoginBtn.UseVisualStyleBackColor = false;
            this.LoginBtn.Click += new System.EventHandler(this.LoginBtn_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.PasswordField);
            this.panel1.Controls.Add(this.RegisterLink);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.UsernameField);
            this.panel1.Controls.Add(this.LoginBtn);
            this.panel1.Location = new System.Drawing.Point(246, 127);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(338, 278);
            this.panel1.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(137, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 22);
            this.label2.TabIndex = 13;
            this.label2.Text = "LOGIN";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(79, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(79, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "Username";
            // 
            // PasswordField
            // 
            this.PasswordField.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(209)))), ((int)(((byte)(209)))));
            this.PasswordField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PasswordField.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordField.ForeColor = System.Drawing.Color.Black;
            this.PasswordField.Location = new System.Drawing.Point(82, 143);
            this.PasswordField.Name = "PasswordField";
            this.PasswordField.Size = new System.Drawing.Size(178, 21);
            this.PasswordField.TabIndex = 10;
            this.PasswordField.UseSystemPasswordChar = true;
            // 
            // RegisterLink
            // 
            this.RegisterLink.AutoSize = true;
            this.RegisterLink.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegisterLink.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(146)))), ((int)(((byte)(255)))));
            this.RegisterLink.Location = new System.Drawing.Point(214, 241);
            this.RegisterLink.Name = "RegisterLink";
            this.RegisterLink.Size = new System.Drawing.Size(55, 14);
            this.RegisterLink.TabIndex = 9;
            this.RegisterLink.TabStop = true;
            this.RegisterLink.Text = "Click Here";
            this.RegisterLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.RegisterLink_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(76, 241);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 14);
            this.label3.TabIndex = 7;
            this.label3.Text = "Don\'t you have an account?";
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 461);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "LoginForm";
            this.Text = "Spend Smart - Login";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox UsernameField;
        private System.Windows.Forms.Button LoginBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.LinkLabel RegisterLink;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox PasswordField;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Label label2;
    }
}