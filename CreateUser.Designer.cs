namespace VendingMachine2
{
    partial class CreateUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateUser));
            this.createUserLabel = new System.Windows.Forms.Label();
            this.usernameEnter = new System.Windows.Forms.TextBox();
            this.nameEnterLabel = new System.Windows.Forms.Label();
            this.balanceEnter = new System.Windows.Forms.TextBox();
            this.Balance = new System.Windows.Forms.Label();
            this.createUserButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // createUserLabel
            // 
            resources.ApplyResources(this.createUserLabel, "createUserLabel");
            this.createUserLabel.ForeColor = System.Drawing.Color.Orange;
            this.createUserLabel.Name = "createUserLabel";
            // 
            // usernameEnter
            // 
            this.usernameEnter.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.usernameEnter, "usernameEnter");
            this.usernameEnter.Name = "usernameEnter";
            // 
            // nameEnterLabel
            // 
            resources.ApplyResources(this.nameEnterLabel, "nameEnterLabel");
            this.nameEnterLabel.Name = "nameEnterLabel";
            // 
            // balanceEnter
            // 
            this.balanceEnter.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.balanceEnter, "balanceEnter");
            this.balanceEnter.Name = "balanceEnter";
            // 
            // Balance
            // 
            resources.ApplyResources(this.Balance, "Balance");
            this.Balance.Name = "Balance";
            // 
            // createUserButton
            // 
            this.createUserButton.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.createUserButton, "createUserButton");
            this.createUserButton.ForeColor = System.Drawing.Color.Navy;
            this.createUserButton.Name = "createUserButton";
            this.createUserButton.UseVisualStyleBackColor = false;
            this.createUserButton.Click += new System.EventHandler(this.createUserButton_Click);
            // 
            // CreateUser
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.Controls.Add(this.createUserButton);
            this.Controls.Add(this.balanceEnter);
            this.Controls.Add(this.Balance);
            this.Controls.Add(this.usernameEnter);
            this.Controls.Add(this.nameEnterLabel);
            this.Controls.Add(this.createUserLabel);
            this.Name = "CreateUser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label createUserLabel;
        private System.Windows.Forms.TextBox usernameEnter;
        private System.Windows.Forms.Label nameEnterLabel;
        private System.Windows.Forms.TextBox balanceEnter;
        private System.Windows.Forms.Label Balance;
        private System.Windows.Forms.Button createUserButton;
    }
}