namespace VendingMachine2
{
    partial class UserInterface
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserInterface));
            this.vendingmachine = new System.Windows.Forms.Label();
            this.foodndrink = new System.Windows.Forms.Label();
            this.BUY1 = new System.Windows.Forms.Button();
            this.qtybox = new System.Windows.Forms.ComboBox();
            this.qty1 = new System.Windows.Forms.Label();
            this.adminloginUI = new System.Windows.Forms.Button();
            this.FoodTable = new System.Windows.Forms.ListBox();
            this.DrinkTable = new System.Windows.Forms.ListBox();
            this.FoodsLabel = new System.Windows.Forms.Label();
            this.drinksLabel = new System.Windows.Forms.Label();
            this.chooseCategoryLabel = new System.Windows.Forms.Label();
            this.categoryChooser = new System.Windows.Forms.ComboBox();
            this.chooseItemLabel = new System.Windows.Forms.Label();
            this.itemChooser = new System.Windows.Forms.ComboBox();
            this.balanceLabel = new System.Windows.Forms.Label();
            this.balanceBox = new System.Windows.Forms.ListBox();
            this.userChooser = new System.Windows.Forms.ComboBox();
            this.chooseUserLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // vendingmachine
            // 
            this.vendingmachine.AutoSize = true;
            this.vendingmachine.Font = new System.Drawing.Font("Showcard Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vendingmachine.ForeColor = System.Drawing.Color.DarkOrange;
            this.vendingmachine.Location = new System.Drawing.Point(267, 12);
            this.vendingmachine.Margin = new System.Windows.Forms.Padding(0);
            this.vendingmachine.Name = "vendingmachine";
            this.vendingmachine.Size = new System.Drawing.Size(371, 50);
            this.vendingmachine.TabIndex = 0;
            this.vendingmachine.Text = "VENDING MACHINE";
            this.vendingmachine.Click += new System.EventHandler(this.vendingmachine_Click);
            // 
            // foodndrink
            // 
            this.foodndrink.AutoSize = true;
            this.foodndrink.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.foodndrink.ForeColor = System.Drawing.Color.Orange;
            this.foodndrink.Location = new System.Drawing.Point(324, 62);
            this.foodndrink.Margin = new System.Windows.Forms.Padding(0);
            this.foodndrink.Name = "foodndrink";
            this.foodndrink.Size = new System.Drawing.Size(241, 26);
            this.foodndrink.TabIndex = 1;
            this.foodndrink.Text = "F  O  O  D     n     D  R  I  N  K";
            // 
            // BUY1
            // 
            this.BUY1.BackColor = System.Drawing.Color.White;
            this.BUY1.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BUY1.ForeColor = System.Drawing.Color.Orange;
            this.BUY1.Location = new System.Drawing.Point(677, 442);
            this.BUY1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.BUY1.Name = "BUY1";
            this.BUY1.Size = new System.Drawing.Size(65, 36);
            this.BUY1.TabIndex = 14;
            this.BUY1.Text = "BUY";
            this.BUY1.UseVisualStyleBackColor = false;
            this.BUY1.Click += new System.EventHandler(this.button1_Click);
            // 
            // qtybox
            // 
            this.qtybox.FormattingEnabled = true;
            this.qtybox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.qtybox.Location = new System.Drawing.Point(677, 386);
            this.qtybox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.qtybox.Name = "qtybox";
            this.qtybox.Size = new System.Drawing.Size(161, 25);
            this.qtybox.TabIndex = 13;
            this.qtybox.SelectedIndexChanged += new System.EventHandler(this.qtybox_SelectedIndexChanged);
            // 
            // qty1
            // 
            this.qty1.AutoSize = true;
            this.qty1.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qty1.ForeColor = System.Drawing.Color.Orange;
            this.qty1.Location = new System.Drawing.Point(672, 356);
            this.qty1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.qty1.Name = "qty1";
            this.qty1.Size = new System.Drawing.Size(64, 27);
            this.qty1.TabIndex = 12;
            this.qty1.Text = "Qty:";
            // 
            // adminloginUI
            // 
            this.adminloginUI.BackColor = System.Drawing.Color.White;
            this.adminloginUI.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminloginUI.ForeColor = System.Drawing.Color.MidnightBlue;
            this.adminloginUI.Location = new System.Drawing.Point(719, 572);
            this.adminloginUI.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.adminloginUI.Name = "adminloginUI";
            this.adminloginUI.Size = new System.Drawing.Size(119, 35);
            this.adminloginUI.TabIndex = 56;
            this.adminloginUI.Text = "Admin Login";
            this.adminloginUI.UseVisualStyleBackColor = false;
            this.adminloginUI.Click += new System.EventHandler(this.adminloginUI_Click);
            // 
            // FoodTable
            // 
            this.FoodTable.BackColor = System.Drawing.Color.MidnightBlue;
            this.FoodTable.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FoodTable.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FoodTable.ForeColor = System.Drawing.Color.Orange;
            this.FoodTable.FormattingEnabled = true;
            this.FoodTable.ItemHeight = 27;
            this.FoodTable.Location = new System.Drawing.Point(98, 152);
            this.FoodTable.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.FoodTable.Name = "FoodTable";
            this.FoodTable.Size = new System.Drawing.Size(230, 326);
            this.FoodTable.TabIndex = 60;
            this.FoodTable.SelectedIndexChanged += new System.EventHandler(this.FoodTable_SelectedIndexChanged);
            // 
            // DrinkTable
            // 
            this.DrinkTable.BackColor = System.Drawing.Color.MidnightBlue;
            this.DrinkTable.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DrinkTable.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DrinkTable.ForeColor = System.Drawing.Color.Orange;
            this.DrinkTable.FormattingEnabled = true;
            this.DrinkTable.ItemHeight = 27;
            this.DrinkTable.Location = new System.Drawing.Point(395, 152);
            this.DrinkTable.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.DrinkTable.Name = "DrinkTable";
            this.DrinkTable.Size = new System.Drawing.Size(230, 326);
            this.DrinkTable.TabIndex = 61;
            // 
            // FoodsLabel
            // 
            this.FoodsLabel.AutoSize = true;
            this.FoodsLabel.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FoodsLabel.ForeColor = System.Drawing.Color.Orange;
            this.FoodsLabel.Location = new System.Drawing.Point(93, 123);
            this.FoodsLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.FoodsLabel.Name = "FoodsLabel";
            this.FoodsLabel.Size = new System.Drawing.Size(114, 26);
            this.FoodsLabel.TabIndex = 62;
            this.FoodsLabel.Text = "F  O  O  D   S";
            // 
            // drinksLabel
            // 
            this.drinksLabel.AutoSize = true;
            this.drinksLabel.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drinksLabel.ForeColor = System.Drawing.Color.Orange;
            this.drinksLabel.Location = new System.Drawing.Point(390, 123);
            this.drinksLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.drinksLabel.Name = "drinksLabel";
            this.drinksLabel.Size = new System.Drawing.Size(126, 26);
            this.drinksLabel.TabIndex = 63;
            this.drinksLabel.Text = "D  R  I  N  K  S";
            // 
            // chooseCategoryLabel
            // 
            this.chooseCategoryLabel.AutoSize = true;
            this.chooseCategoryLabel.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chooseCategoryLabel.ForeColor = System.Drawing.Color.Orange;
            this.chooseCategoryLabel.Location = new System.Drawing.Point(672, 152);
            this.chooseCategoryLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.chooseCategoryLabel.Name = "chooseCategoryLabel";
            this.chooseCategoryLabel.Size = new System.Drawing.Size(220, 27);
            this.chooseCategoryLabel.TabIndex = 64;
            this.chooseCategoryLabel.Text = "Choose Category:";
            // 
            // categoryChooser
            // 
            this.categoryChooser.FormattingEnabled = true;
            this.categoryChooser.Items.AddRange(new object[] {
            "Foods",
            "Drinks"});
            this.categoryChooser.Location = new System.Drawing.Point(677, 182);
            this.categoryChooser.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.categoryChooser.Name = "categoryChooser";
            this.categoryChooser.Size = new System.Drawing.Size(161, 25);
            this.categoryChooser.TabIndex = 65;
            this.categoryChooser.SelectedIndexChanged += new System.EventHandler(this.categoryChooser_SelectedIndexChanged);
            // 
            // chooseItemLabel
            // 
            this.chooseItemLabel.AutoSize = true;
            this.chooseItemLabel.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chooseItemLabel.ForeColor = System.Drawing.Color.Orange;
            this.chooseItemLabel.Location = new System.Drawing.Point(672, 251);
            this.chooseItemLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.chooseItemLabel.Name = "chooseItemLabel";
            this.chooseItemLabel.Size = new System.Drawing.Size(168, 27);
            this.chooseItemLabel.TabIndex = 66;
            this.chooseItemLabel.Text = "Choose Item:";
            // 
            // itemChooser
            // 
            this.itemChooser.FormattingEnabled = true;
            this.itemChooser.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.itemChooser.Location = new System.Drawing.Point(677, 281);
            this.itemChooser.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.itemChooser.Name = "itemChooser";
            this.itemChooser.Size = new System.Drawing.Size(161, 25);
            this.itemChooser.TabIndex = 67;
            this.itemChooser.SelectedIndexChanged += new System.EventHandler(this.itemChooser_SelectedIndexChanged);
            // 
            // balanceLabel
            // 
            this.balanceLabel.AutoSize = true;
            this.balanceLabel.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.balanceLabel.ForeColor = System.Drawing.Color.Orange;
            this.balanceLabel.Location = new System.Drawing.Point(11, 581);
            this.balanceLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.balanceLabel.Name = "balanceLabel";
            this.balanceLabel.Size = new System.Drawing.Size(103, 26);
            this.balanceLabel.TabIndex = 68;
            this.balanceLabel.Text = "Balance:";
            // 
            // balanceBox
            // 
            this.balanceBox.BackColor = System.Drawing.Color.MidnightBlue;
            this.balanceBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.balanceBox.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.balanceBox.ForeColor = System.Drawing.Color.Orange;
            this.balanceBox.FormattingEnabled = true;
            this.balanceBox.ItemHeight = 27;
            this.balanceBox.Location = new System.Drawing.Point(167, 584);
            this.balanceBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.balanceBox.Name = "balanceBox";
            this.balanceBox.Size = new System.Drawing.Size(146, 27);
            this.balanceBox.TabIndex = 69;
            this.balanceBox.SelectedIndexChanged += new System.EventHandler(this.balanceBox_SelectedIndexChanged);
            // 
            // userChooser
            // 
            this.userChooser.FormattingEnabled = true;
            this.userChooser.Location = new System.Drawing.Point(167, 553);
            this.userChooser.Name = "userChooser";
            this.userChooser.Size = new System.Drawing.Size(146, 25);
            this.userChooser.TabIndex = 71;
            this.userChooser.SelectedIndexChanged += new System.EventHandler(this.userChooser_SelectedIndexChanged);
            // 
            // chooseUserLabel
            // 
            this.chooseUserLabel.AutoSize = true;
            this.chooseUserLabel.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chooseUserLabel.ForeColor = System.Drawing.Color.Moccasin;
            this.chooseUserLabel.Location = new System.Drawing.Point(11, 552);
            this.chooseUserLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.chooseUserLabel.Name = "chooseUserLabel";
            this.chooseUserLabel.Size = new System.Drawing.Size(151, 26);
            this.chooseUserLabel.TabIndex = 70;
            this.chooseUserLabel.Text = "Choose User:";
            this.chooseUserLabel.UseMnemonic = false;
            this.chooseUserLabel.Click += new System.EventHandler(this.chooseUserLabel_Click);
            // 
            // UserInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoScrollMargin = new System.Drawing.Size(15, 15);
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(914, 629);
            this.Controls.Add(this.userChooser);
            this.Controls.Add(this.chooseUserLabel);
            this.Controls.Add(this.balanceBox);
            this.Controls.Add(this.balanceLabel);
            this.Controls.Add(this.itemChooser);
            this.Controls.Add(this.chooseItemLabel);
            this.Controls.Add(this.categoryChooser);
            this.Controls.Add(this.chooseCategoryLabel);
            this.Controls.Add(this.drinksLabel);
            this.Controls.Add(this.FoodsLabel);
            this.Controls.Add(this.DrinkTable);
            this.Controls.Add(this.FoodTable);
            this.Controls.Add(this.adminloginUI);
            this.Controls.Add(this.BUY1);
            this.Controls.Add(this.qtybox);
            this.Controls.Add(this.qty1);
            this.Controls.Add(this.foodndrink);
            this.Controls.Add(this.vendingmachine);
            this.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "UserInterface";
            this.Text = "Vending Machine";
            this.Load += new System.EventHandler(this.UserInterface_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label vendingmachine;
        private System.Windows.Forms.Label foodndrink;
        private System.Windows.Forms.Button BUY1;
        private System.Windows.Forms.ComboBox qtybox;
        private System.Windows.Forms.Label qty1;
        private System.Windows.Forms.Button adminloginUI;
        private System.Windows.Forms.ListBox FoodTable;
        private System.Windows.Forms.ListBox DrinkTable;
        private System.Windows.Forms.Label FoodsLabel;
        private System.Windows.Forms.Label drinksLabel;
        private System.Windows.Forms.Label chooseCategoryLabel;
        private System.Windows.Forms.ComboBox categoryChooser;
        private System.Windows.Forms.Label chooseItemLabel;
        private System.Windows.Forms.ComboBox itemChooser;
        private System.Windows.Forms.Label balanceLabel;
        public System.Windows.Forms.ListBox balanceBox;
        public System.Windows.Forms.ComboBox userChooser;
        private System.Windows.Forms.Label chooseUserLabel;
    }
}