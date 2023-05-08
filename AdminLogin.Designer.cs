namespace VendingMachine2
{
    partial class AdminLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminLogin));
            this.adminloginAL = new System.Windows.Forms.Label();
            this.username = new System.Windows.Forms.Label();
            this.usernameEnter = new System.Windows.Forms.TextBox();
            this.passwordEnter = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.Label();
            this.goback = new System.Windows.Forms.Button();
            this.loginButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // adminloginAL
            // 
            this.adminloginAL.AutoSize = true;
            this.adminloginAL.Font = new System.Drawing.Font("Segoe UI Light", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminloginAL.ForeColor = System.Drawing.Color.Orange;
            this.adminloginAL.Location = new System.Drawing.Point(121, 82);
            this.adminloginAL.Name = "adminloginAL";
            this.adminloginAL.Size = new System.Drawing.Size(255, 59);
            this.adminloginAL.TabIndex = 0;
            this.adminloginAL.Text = "Admin Login";
            // 
            // username
            // 
            this.username.AutoSize = true;
            this.username.BackColor = System.Drawing.Color.RoyalBlue;
            this.username.Font = new System.Drawing.Font("Segoe UI Light", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username.ForeColor = System.Drawing.Color.Navy;
            this.username.Location = new System.Drawing.Point(124, 199);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(141, 38);
            this.username.TabIndex = 1;
            this.username.Text = "Username:";
            // 
            // usernameEnter
            // 
            this.usernameEnter.Location = new System.Drawing.Point(131, 240);
            this.usernameEnter.Name = "usernameEnter";
            this.usernameEnter.Size = new System.Drawing.Size(252, 22);
            this.usernameEnter.TabIndex = 2;
            // 
            // passwordEnter
            // 
            this.passwordEnter.Location = new System.Drawing.Point(131, 353);
            this.passwordEnter.Name = "passwordEnter";
            this.passwordEnter.Size = new System.Drawing.Size(252, 22);
            this.passwordEnter.TabIndex = 4;
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.BackColor = System.Drawing.Color.RoyalBlue;
            this.password.Font = new System.Drawing.Font("Segoe UI Light", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.ForeColor = System.Drawing.Color.Navy;
            this.password.Location = new System.Drawing.Point(124, 312);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(132, 38);
            this.password.TabIndex = 3;
            this.password.Text = "Password:";
            // 
            // goback
            // 
            this.goback.BackColor = System.Drawing.Color.White;
            this.goback.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goback.ForeColor = System.Drawing.Color.MidnightBlue;
            this.goback.Location = new System.Drawing.Point(12, 552);
            this.goback.Name = "goback";
            this.goback.Size = new System.Drawing.Size(116, 33);
            this.goback.TabIndex = 57;
            this.goback.Text = "Go Back";
            this.goback.UseVisualStyleBackColor = false;
            this.goback.Click += new System.EventHandler(this.goback_Click);
            // 
            // loginButton
            // 
            this.loginButton.BackColor = System.Drawing.Color.White;
            this.loginButton.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginButton.ForeColor = System.Drawing.Color.MidnightBlue;
            this.loginButton.Location = new System.Drawing.Point(267, 427);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(116, 33);
            this.loginButton.TabIndex = 58;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = false;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // AdminLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(914, 629);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.goback);
            this.Controls.Add(this.passwordEnter);
            this.Controls.Add(this.password);
            this.Controls.Add(this.usernameEnter);
            this.Controls.Add(this.username);
            this.Controls.Add(this.adminloginAL);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdminLogin";
            this.Text = "Vending Machine";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label adminloginAL;
        private System.Windows.Forms.Label username;
        private System.Windows.Forms.TextBox usernameEnter;
        private System.Windows.Forms.TextBox passwordEnter;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.Button goback;
        private System.Windows.Forms.Button loginButton;
    }
}