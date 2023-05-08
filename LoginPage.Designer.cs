namespace VendingMachine2
{
    partial class LoginPage
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginPage));
            this.vendingmachine = new System.Windows.Forms.Label();
            this.foodndrink = new System.Windows.Forms.Label();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vendingMachineDataSet = new VendingMachine2.VendingMachineDataSet();
            this.createUserButton = new System.Windows.Forms.Button();
            this.usersTableAdapter = new VendingMachine2.VendingMachineDataSetTableAdapters.UsersTableAdapter();
            this.enterLabel = new System.Windows.Forms.Button();
            this.orLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendingMachineDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // vendingmachine
            // 
            this.vendingmachine.AutoSize = true;
            this.vendingmachine.Font = new System.Drawing.Font("Showcard Gothic", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vendingmachine.ForeColor = System.Drawing.Color.DarkOrange;
            this.vendingmachine.Location = new System.Drawing.Point(86, 175);
            this.vendingmachine.Margin = new System.Windows.Forms.Padding(0);
            this.vendingmachine.Name = "vendingmachine";
            this.vendingmachine.Size = new System.Drawing.Size(752, 98);
            this.vendingmachine.TabIndex = 1;
            this.vendingmachine.Text = "VENDING MACHINE";
            // 
            // foodndrink
            // 
            this.foodndrink.AutoSize = true;
            this.foodndrink.Font = new System.Drawing.Font("Showcard Gothic", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.foodndrink.ForeColor = System.Drawing.Color.Orange;
            this.foodndrink.Location = new System.Drawing.Point(219, 273);
            this.foodndrink.Margin = new System.Windows.Forms.Padding(0);
            this.foodndrink.Name = "foodndrink";
            this.foodndrink.Size = new System.Drawing.Size(468, 50);
            this.foodndrink.TabIndex = 2;
            this.foodndrink.Text = "F  O  O  D     n     D  R  I  N  K";
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "Users";
            this.usersBindingSource.DataSource = this.vendingMachineDataSet;
            // 
            // vendingMachineDataSet
            // 
            this.vendingMachineDataSet.DataSetName = "VendingMachineDataSet";
            this.vendingMachineDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // createUserButton
            // 
            this.createUserButton.BackColor = System.Drawing.Color.White;
            this.createUserButton.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createUserButton.ForeColor = System.Drawing.Color.Orange;
            this.createUserButton.Location = new System.Drawing.Point(391, 495);
            this.createUserButton.Name = "createUserButton";
            this.createUserButton.Size = new System.Drawing.Size(146, 42);
            this.createUserButton.TabIndex = 66;
            this.createUserButton.Text = "Create User";
            this.createUserButton.UseVisualStyleBackColor = false;
            this.createUserButton.Click += new System.EventHandler(this.createUserButton_Click);
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // enterLabel
            // 
            this.enterLabel.BackColor = System.Drawing.Color.White;
            this.enterLabel.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enterLabel.ForeColor = System.Drawing.Color.Orange;
            this.enterLabel.Location = new System.Drawing.Point(391, 370);
            this.enterLabel.Name = "enterLabel";
            this.enterLabel.Size = new System.Drawing.Size(146, 42);
            this.enterLabel.TabIndex = 67;
            this.enterLabel.Text = "ENTER";
            this.enterLabel.UseVisualStyleBackColor = false;
            this.enterLabel.Click += new System.EventHandler(this.enterLabel_Click);
            // 
            // orLabel
            // 
            this.orLabel.AutoSize = true;
            this.orLabel.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orLabel.ForeColor = System.Drawing.Color.Moccasin;
            this.orLabel.Location = new System.Drawing.Point(439, 439);
            this.orLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.orLabel.Name = "orLabel";
            this.orLabel.Size = new System.Drawing.Size(48, 26);
            this.orLabel.TabIndex = 71;
            this.orLabel.Text = "or:";
            this.orLabel.UseMnemonic = false;
            // 
            // LoginPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(914, 629);
            this.Controls.Add(this.orLabel);
            this.Controls.Add(this.enterLabel);
            this.Controls.Add(this.createUserButton);
            this.Controls.Add(this.foodndrink);
            this.Controls.Add(this.vendingmachine);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoginPage";
            this.Text = "Vending Machine";
            this.Load += new System.EventHandler(this.LoginPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendingMachineDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label vendingmachine;
        private System.Windows.Forms.Label foodndrink;
        private System.Windows.Forms.Button createUserButton;
        private VendingMachineDataSet vendingMachineDataSet;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private VendingMachineDataSetTableAdapters.UsersTableAdapter usersTableAdapter;
        private System.Windows.Forms.Button enterLabel;
        private System.Windows.Forms.Label orLabel;
    }
}