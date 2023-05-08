namespace VendingMachine2
{
    partial class AdminInterface
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminInterface));
            this.stock1 = new System.Windows.Forms.Label();
            this.gobacktomainmenu = new System.Windows.Forms.Button();
            this.stockBox = new System.Windows.Forms.ListBox();
            this.changeStockLabel = new System.Windows.Forms.Label();
            this.changeStockComboBox = new System.Windows.Forms.ComboBox();
            this.itemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.addButton = new System.Windows.Forms.Button();
            this.subtractButton = new System.Windows.Forms.Button();
            this.categoryChooser = new System.Windows.Forms.ComboBox();
            this.chooseCategory = new System.Windows.Forms.Label();
            this.addItemLabel = new System.Windows.Forms.Label();
            this.nameEnterLabel = new System.Windows.Forms.Label();
            this.categoryEnterLabel = new System.Windows.Forms.Label();
            this.priceEnterLabel = new System.Windows.Forms.Label();
            this.stockEnterLabel = new System.Windows.Forms.Label();
            this.nameEnter = new System.Windows.Forms.TextBox();
            this.priceEnter = new System.Windows.Forms.TextBox();
            this.stockEnter = new System.Windows.Forms.TextBox();
            this.categoryChooserEnter = new System.Windows.Forms.ComboBox();
            this.addItemButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // stock1
            // 
            this.stock1.AutoSize = true;
            this.stock1.Font = new System.Drawing.Font("Segoe UI Light", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stock1.ForeColor = System.Drawing.Color.Orange;
            this.stock1.Location = new System.Drawing.Point(101, 9);
            this.stock1.Name = "stock1";
            this.stock1.Size = new System.Drawing.Size(113, 54);
            this.stock1.TabIndex = 1;
            this.stock1.Text = "Stock";
            // 
            // gobacktomainmenu
            // 
            this.gobacktomainmenu.BackColor = System.Drawing.Color.White;
            this.gobacktomainmenu.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gobacktomainmenu.ForeColor = System.Drawing.Color.MidnightBlue;
            this.gobacktomainmenu.Location = new System.Drawing.Point(6, 552);
            this.gobacktomainmenu.Name = "gobacktomainmenu";
            this.gobacktomainmenu.Size = new System.Drawing.Size(194, 33);
            this.gobacktomainmenu.TabIndex = 58;
            this.gobacktomainmenu.Text = "Go Back to Main Menu";
            this.gobacktomainmenu.UseVisualStyleBackColor = false;
            this.gobacktomainmenu.Click += new System.EventHandler(this.gobacktomainmenu_Click);
            // 
            // stockBox
            // 
            this.stockBox.BackColor = System.Drawing.Color.RoyalBlue;
            this.stockBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.stockBox.Font = new System.Drawing.Font("Segoe UI Light", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stockBox.ForeColor = System.Drawing.Color.Navy;
            this.stockBox.FormattingEnabled = true;
            this.stockBox.ItemHeight = 31;
            this.stockBox.Location = new System.Drawing.Point(110, 140);
            this.stockBox.Name = "stockBox";
            this.stockBox.Size = new System.Drawing.Size(474, 343);
            this.stockBox.TabIndex = 59;
            this.stockBox.SelectedIndexChanged += new System.EventHandler(this.stockBox_SelectedIndexChanged);
            // 
            // changeStockLabel
            // 
            this.changeStockLabel.AutoSize = true;
            this.changeStockLabel.Font = new System.Drawing.Font("Segoe UI Light", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeStockLabel.Location = new System.Drawing.Point(607, 115);
            this.changeStockLabel.Name = "changeStockLabel";
            this.changeStockLabel.Size = new System.Drawing.Size(150, 31);
            this.changeStockLabel.TabIndex = 60;
            this.changeStockLabel.Text = "Change Stock:";
            // 
            // changeStockComboBox
            // 
            this.changeStockComboBox.FormattingEnabled = true;
            this.changeStockComboBox.Location = new System.Drawing.Point(613, 149);
            this.changeStockComboBox.Name = "changeStockComboBox";
            this.changeStockComboBox.Size = new System.Drawing.Size(121, 24);
            this.changeStockComboBox.TabIndex = 61;
            this.changeStockComboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // itemBindingSource
            // 
            this.itemBindingSource.DataMember = "Item";
            // 
            // vendingMachineDataSet
            // 
            // 
            // itemTableAdapter
            // 
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.White;
            this.addButton.Font = new System.Drawing.Font("Segoe UI Black", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addButton.ForeColor = System.Drawing.Color.Navy;
            this.addButton.Location = new System.Drawing.Point(613, 196);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(34, 31);
            this.addButton.TabIndex = 62;
            this.addButton.Text = "+";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // subtractButton
            // 
            this.subtractButton.BackColor = System.Drawing.Color.White;
            this.subtractButton.Font = new System.Drawing.Font("Segoe UI Black", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subtractButton.ForeColor = System.Drawing.Color.Navy;
            this.subtractButton.Location = new System.Drawing.Point(653, 196);
            this.subtractButton.Name = "subtractButton";
            this.subtractButton.Size = new System.Drawing.Size(34, 31);
            this.subtractButton.TabIndex = 63;
            this.subtractButton.Text = "-";
            this.subtractButton.UseVisualStyleBackColor = false;
            this.subtractButton.Click += new System.EventHandler(this.subtractButton_Click);
            // 
            // categoryChooser
            // 
            this.categoryChooser.FormattingEnabled = true;
            this.categoryChooser.Items.AddRange(new object[] {
            "Foods",
            "Drinks"});
            this.categoryChooser.Location = new System.Drawing.Point(463, 101);
            this.categoryChooser.Name = "categoryChooser";
            this.categoryChooser.Size = new System.Drawing.Size(121, 24);
            this.categoryChooser.TabIndex = 65;
            this.categoryChooser.SelectedIndexChanged += new System.EventHandler(this.categoryChooser_SelectedIndexChanged);
            // 
            // chooseCategory
            // 
            this.chooseCategory.AutoSize = true;
            this.chooseCategory.Font = new System.Drawing.Font("Segoe UI Light", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chooseCategory.ForeColor = System.Drawing.Color.Navy;
            this.chooseCategory.Location = new System.Drawing.Point(104, 101);
            this.chooseCategory.Name = "chooseCategory";
            this.chooseCategory.Size = new System.Drawing.Size(187, 31);
            this.chooseCategory.TabIndex = 66;
            this.chooseCategory.Text = "Choose Category:";
            // 
            // addItemLabel
            // 
            this.addItemLabel.AutoSize = true;
            this.addItemLabel.Font = new System.Drawing.Font("Segoe UI Light", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addItemLabel.Location = new System.Drawing.Point(607, 286);
            this.addItemLabel.Name = "addItemLabel";
            this.addItemLabel.Size = new System.Drawing.Size(158, 31);
            this.addItemLabel.TabIndex = 67;
            this.addItemLabel.Text = "Add New Item:";
            // 
            // nameEnterLabel
            // 
            this.nameEnterLabel.AutoSize = true;
            this.nameEnterLabel.Font = new System.Drawing.Font("Segoe UI Light", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameEnterLabel.Location = new System.Drawing.Point(608, 371);
            this.nameEnterLabel.Name = "nameEnterLabel";
            this.nameEnterLabel.Size = new System.Drawing.Size(62, 25);
            this.nameEnterLabel.TabIndex = 69;
            this.nameEnterLabel.Text = "Name:";
            // 
            // categoryEnterLabel
            // 
            this.categoryEnterLabel.AutoSize = true;
            this.categoryEnterLabel.Font = new System.Drawing.Font("Segoe UI Light", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryEnterLabel.Location = new System.Drawing.Point(608, 344);
            this.categoryEnterLabel.Name = "categoryEnterLabel";
            this.categoryEnterLabel.Size = new System.Drawing.Size(85, 25);
            this.categoryEnterLabel.TabIndex = 70;
            this.categoryEnterLabel.Text = "Category:";
            // 
            // priceEnterLabel
            // 
            this.priceEnterLabel.AutoSize = true;
            this.priceEnterLabel.Font = new System.Drawing.Font("Segoe UI Light", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceEnterLabel.Location = new System.Drawing.Point(608, 396);
            this.priceEnterLabel.Name = "priceEnterLabel";
            this.priceEnterLabel.Size = new System.Drawing.Size(53, 25);
            this.priceEnterLabel.TabIndex = 71;
            this.priceEnterLabel.Text = "Price:";
            // 
            // stockEnterLabel
            // 
            this.stockEnterLabel.AutoSize = true;
            this.stockEnterLabel.Font = new System.Drawing.Font("Segoe UI Light", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stockEnterLabel.Location = new System.Drawing.Point(608, 421);
            this.stockEnterLabel.Name = "stockEnterLabel";
            this.stockEnterLabel.Size = new System.Drawing.Size(56, 25);
            this.stockEnterLabel.TabIndex = 72;
            this.stockEnterLabel.Text = "Stock:";
            // 
            // nameEnter
            // 
            this.nameEnter.BackColor = System.Drawing.Color.White;
            this.nameEnter.Location = new System.Drawing.Point(711, 375);
            this.nameEnter.Name = "nameEnter";
            this.nameEnter.Size = new System.Drawing.Size(126, 22);
            this.nameEnter.TabIndex = 73;
            this.nameEnter.TextChanged += new System.EventHandler(this.nameEnter_TextChanged);
            // 
            // priceEnter
            // 
            this.priceEnter.BackColor = System.Drawing.Color.White;
            this.priceEnter.Location = new System.Drawing.Point(711, 400);
            this.priceEnter.Name = "priceEnter";
            this.priceEnter.Size = new System.Drawing.Size(126, 22);
            this.priceEnter.TabIndex = 74;
            // 
            // stockEnter
            // 
            this.stockEnter.BackColor = System.Drawing.Color.White;
            this.stockEnter.Location = new System.Drawing.Point(711, 424);
            this.stockEnter.Name = "stockEnter";
            this.stockEnter.Size = new System.Drawing.Size(126, 22);
            this.stockEnter.TabIndex = 75;
            // 
            // categoryChooserEnter
            // 
            this.categoryChooserEnter.FormattingEnabled = true;
            this.categoryChooserEnter.Items.AddRange(new object[] {
            "Foods",
            "Drinks"});
            this.categoryChooserEnter.Location = new System.Drawing.Point(711, 348);
            this.categoryChooserEnter.Name = "categoryChooserEnter";
            this.categoryChooserEnter.Size = new System.Drawing.Size(126, 24);
            this.categoryChooserEnter.TabIndex = 76;
            // 
            // addItemButton
            // 
            this.addItemButton.BackColor = System.Drawing.Color.White;
            this.addItemButton.Font = new System.Drawing.Font("Segoe UI Light", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addItemButton.ForeColor = System.Drawing.Color.Navy;
            this.addItemButton.Location = new System.Drawing.Point(754, 452);
            this.addItemButton.Name = "addItemButton";
            this.addItemButton.Size = new System.Drawing.Size(83, 31);
            this.addItemButton.TabIndex = 77;
            this.addItemButton.Text = "Add";
            this.addItemButton.UseVisualStyleBackColor = false;
            this.addItemButton.Click += new System.EventHandler(this.addItemButton_Click);
            // 
            // AdminInterface
            // 
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(914, 629);
            this.Controls.Add(this.addItemButton);
            this.Controls.Add(this.categoryChooserEnter);
            this.Controls.Add(this.stockEnter);
            this.Controls.Add(this.priceEnter);
            this.Controls.Add(this.nameEnter);
            this.Controls.Add(this.stockEnterLabel);
            this.Controls.Add(this.priceEnterLabel);
            this.Controls.Add(this.categoryEnterLabel);
            this.Controls.Add(this.nameEnterLabel);
            this.Controls.Add(this.addItemLabel);
            this.Controls.Add(this.chooseCategory);
            this.Controls.Add(this.categoryChooser);
            this.Controls.Add(this.subtractButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.changeStockComboBox);
            this.Controls.Add(this.changeStockLabel);
            this.Controls.Add(this.stockBox);
            this.Controls.Add(this.gobacktomainmenu);
            this.Controls.Add(this.stock1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdminInterface";
            this.Text = "Vending Machine";
            this.Load += new System.EventHandler(this.AdminInterface_Load);
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label stock1;
        private System.Windows.Forms.Button gobacktomainmenu;
        private System.Windows.Forms.ListBox stockBox;
        private System.Windows.Forms.Label changeStockLabel;
        private System.Windows.Forms.ComboBox changeStockComboBox;
        private System.Windows.Forms.BindingSource itemBindingSource;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button subtractButton;
        private System.Windows.Forms.ComboBox categoryChooser;
        private System.Windows.Forms.Label chooseCategory;
        private System.Windows.Forms.Label addItemLabel;
        private System.Windows.Forms.Label nameEnterLabel;
        private System.Windows.Forms.Label categoryEnterLabel;
        private System.Windows.Forms.Label priceEnterLabel;
        private System.Windows.Forms.Label stockEnterLabel;
        private System.Windows.Forms.TextBox nameEnter;
        private System.Windows.Forms.TextBox priceEnter;
        private System.Windows.Forms.TextBox stockEnter;
        private System.Windows.Forms.ComboBox categoryChooserEnter;
        private System.Windows.Forms.Button addItemButton;
    }
}