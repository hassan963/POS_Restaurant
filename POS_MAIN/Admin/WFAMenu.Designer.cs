namespace Admin
{
    partial class WFAMenu
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
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.rbDessert = new System.Windows.Forms.RadioButton();
            this.rbDrinks = new System.Windows.Forms.RadioButton();
            this.rbCoffee = new System.Windows.Forms.RadioButton();
            this.rbStarter = new System.Windows.Forms.RadioButton();
            this.rbPizza = new System.Windows.Forms.RadioButton();
            this.rbBurger = new System.Windows.Forms.RadioButton();
            this.rbSandwich = new System.Windows.Forms.RadioButton();
            this.rbSetMeals = new System.Windows.Forms.RadioButton();
            this.rbBreakfast = new System.Windows.Forms.RadioButton();
            this.lblCategoryName = new System.Windows.Forms.Label();
            this.txtUnitPrice = new System.Windows.Forms.TextBox();
            this.lblUnitPrice = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtMenuId = new System.Windows.Forms.TextBox();
            this.menu_id = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnShowAll = new System.Windows.Forms.Button();
            this.dgvMenu = new System.Windows.Forms.DataGridView();
            this.menuid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unit_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMenu
            // 
            this.pnlMenu.Controls.Add(this.dgvMenu);
            this.pnlMenu.Controls.Add(this.btnShowAll);
            this.pnlMenu.Controls.Add(this.txtSearch);
            this.pnlMenu.Controls.Add(this.btnSearch);
            this.pnlMenu.Controls.Add(this.btnSave);
            this.pnlMenu.Controls.Add(this.rbDessert);
            this.pnlMenu.Controls.Add(this.rbDrinks);
            this.pnlMenu.Controls.Add(this.rbCoffee);
            this.pnlMenu.Controls.Add(this.rbStarter);
            this.pnlMenu.Controls.Add(this.rbPizza);
            this.pnlMenu.Controls.Add(this.rbBurger);
            this.pnlMenu.Controls.Add(this.rbSandwich);
            this.pnlMenu.Controls.Add(this.rbSetMeals);
            this.pnlMenu.Controls.Add(this.rbBreakfast);
            this.pnlMenu.Controls.Add(this.lblCategoryName);
            this.pnlMenu.Controls.Add(this.txtUnitPrice);
            this.pnlMenu.Controls.Add(this.lblUnitPrice);
            this.pnlMenu.Controls.Add(this.txtName);
            this.pnlMenu.Controls.Add(this.lblName);
            this.pnlMenu.Controls.Add(this.txtMenuId);
            this.pnlMenu.Controls.Add(this.menu_id);
            this.pnlMenu.Location = new System.Drawing.Point(4, 5);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(795, 442);
            this.pnlMenu.TabIndex = 0;
            this.pnlMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlMenu_Paint);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(30, 268);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 16;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // rbDessert
            // 
            this.rbDessert.AutoSize = true;
            this.rbDessert.Location = new System.Drawing.Point(297, 216);
            this.rbDessert.Name = "rbDessert";
            this.rbDessert.Size = new System.Drawing.Size(61, 17);
            this.rbDessert.TabIndex = 15;
            this.rbDessert.TabStop = true;
            this.rbDessert.Text = "Dessert";
            this.rbDessert.UseVisualStyleBackColor = true;
            this.rbDessert.CheckedChanged += new System.EventHandler(this.rbDessert_CheckedChanged);
            // 
            // rbDrinks
            // 
            this.rbDrinks.AutoSize = true;
            this.rbDrinks.Location = new System.Drawing.Point(219, 216);
            this.rbDrinks.Name = "rbDrinks";
            this.rbDrinks.Size = new System.Drawing.Size(55, 17);
            this.rbDrinks.TabIndex = 14;
            this.rbDrinks.TabStop = true;
            this.rbDrinks.Text = "Drinks";
            this.rbDrinks.UseVisualStyleBackColor = true;
            this.rbDrinks.CheckedChanged += new System.EventHandler(this.rbDrinks_CheckedChanged);
            // 
            // rbCoffee
            // 
            this.rbCoffee.AutoSize = true;
            this.rbCoffee.Location = new System.Drawing.Point(143, 216);
            this.rbCoffee.Name = "rbCoffee";
            this.rbCoffee.Size = new System.Drawing.Size(56, 17);
            this.rbCoffee.TabIndex = 13;
            this.rbCoffee.TabStop = true;
            this.rbCoffee.Text = "Coffee";
            this.rbCoffee.UseVisualStyleBackColor = true;
            this.rbCoffee.CheckedChanged += new System.EventHandler(this.rbCoffee_CheckedChanged);
            // 
            // rbStarter
            // 
            this.rbStarter.AutoSize = true;
            this.rbStarter.Location = new System.Drawing.Point(297, 193);
            this.rbStarter.Name = "rbStarter";
            this.rbStarter.Size = new System.Drawing.Size(56, 17);
            this.rbStarter.TabIndex = 12;
            this.rbStarter.TabStop = true;
            this.rbStarter.Text = "Starter";
            this.rbStarter.UseVisualStyleBackColor = true;
            this.rbStarter.CheckedChanged += new System.EventHandler(this.rbStarter_CheckedChanged);
            // 
            // rbPizza
            // 
            this.rbPizza.AutoSize = true;
            this.rbPizza.Location = new System.Drawing.Point(219, 193);
            this.rbPizza.Name = "rbPizza";
            this.rbPizza.Size = new System.Drawing.Size(50, 17);
            this.rbPizza.TabIndex = 11;
            this.rbPizza.TabStop = true;
            this.rbPizza.Text = "Pizza";
            this.rbPizza.UseVisualStyleBackColor = true;
            this.rbPizza.CheckedChanged += new System.EventHandler(this.rbPizza_CheckedChanged);
            // 
            // rbBurger
            // 
            this.rbBurger.AutoSize = true;
            this.rbBurger.Location = new System.Drawing.Point(143, 193);
            this.rbBurger.Name = "rbBurger";
            this.rbBurger.Size = new System.Drawing.Size(56, 17);
            this.rbBurger.TabIndex = 10;
            this.rbBurger.TabStop = true;
            this.rbBurger.Text = "Burger";
            this.rbBurger.UseVisualStyleBackColor = true;
            this.rbBurger.CheckedChanged += new System.EventHandler(this.rbBurger_CheckedChanged);
            // 
            // rbSandwich
            // 
            this.rbSandwich.AutoSize = true;
            this.rbSandwich.Location = new System.Drawing.Point(297, 170);
            this.rbSandwich.Name = "rbSandwich";
            this.rbSandwich.Size = new System.Drawing.Size(72, 17);
            this.rbSandwich.TabIndex = 9;
            this.rbSandwich.TabStop = true;
            this.rbSandwich.Text = "Sandwich";
            this.rbSandwich.UseVisualStyleBackColor = true;
            this.rbSandwich.CheckedChanged += new System.EventHandler(this.rbSandwich_CheckedChanged);
            // 
            // rbSetMeals
            // 
            this.rbSetMeals.AutoSize = true;
            this.rbSetMeals.Location = new System.Drawing.Point(219, 170);
            this.rbSetMeals.Name = "rbSetMeals";
            this.rbSetMeals.Size = new System.Drawing.Size(72, 17);
            this.rbSetMeals.TabIndex = 8;
            this.rbSetMeals.TabStop = true;
            this.rbSetMeals.Text = "Set Meals";
            this.rbSetMeals.UseVisualStyleBackColor = true;
            this.rbSetMeals.CheckedChanged += new System.EventHandler(this.rbSetMeals_CheckedChanged);
            // 
            // rbBreakfast
            // 
            this.rbBreakfast.AutoSize = true;
            this.rbBreakfast.Location = new System.Drawing.Point(143, 170);
            this.rbBreakfast.Name = "rbBreakfast";
            this.rbBreakfast.Size = new System.Drawing.Size(70, 17);
            this.rbBreakfast.TabIndex = 7;
            this.rbBreakfast.TabStop = true;
            this.rbBreakfast.Text = "Breakfast";
            this.rbBreakfast.UseVisualStyleBackColor = true;
            this.rbBreakfast.CheckedChanged += new System.EventHandler(this.rbBreakfast_CheckedChanged);
            // 
            // lblCategoryName
            // 
            this.lblCategoryName.AutoSize = true;
            this.lblCategoryName.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoryName.Location = new System.Drawing.Point(27, 170);
            this.lblCategoryName.Name = "lblCategoryName";
            this.lblCategoryName.Size = new System.Drawing.Size(89, 15);
            this.lblCategoryName.TabIndex = 6;
            this.lblCategoryName.Text = "Category Name";
            // 
            // txtUnitPrice
            // 
            this.txtUnitPrice.Location = new System.Drawing.Point(143, 118);
            this.txtUnitPrice.Name = "txtUnitPrice";
            this.txtUnitPrice.Size = new System.Drawing.Size(100, 20);
            this.txtUnitPrice.TabIndex = 5;
            // 
            // lblUnitPrice
            // 
            this.lblUnitPrice.AutoSize = true;
            this.lblUnitPrice.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnitPrice.Location = new System.Drawing.Point(27, 120);
            this.lblUnitPrice.Name = "lblUnitPrice";
            this.lblUnitPrice.Size = new System.Drawing.Size(61, 15);
            this.lblUnitPrice.TabIndex = 4;
            this.lblUnitPrice.Text = "Unit Price";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(143, 73);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 3;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(27, 75);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(38, 15);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Name";
            // 
            // txtMenuId
            // 
            this.txtMenuId.Location = new System.Drawing.Point(143, 29);
            this.txtMenuId.Name = "txtMenuId";
            this.txtMenuId.Size = new System.Drawing.Size(100, 20);
            this.txtMenuId.TabIndex = 1;
            // 
            // menu_id
            // 
            this.menu_id.AutoSize = true;
            this.menu_id.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu_id.Location = new System.Drawing.Point(27, 31);
            this.menu_id.Name = "menu_id";
            this.menu_id.Size = new System.Drawing.Size(52, 15);
            this.menu_id.TabIndex = 0;
            this.menu_id.Text = "Menu Id";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(377, 29);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 17;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(515, 32);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(100, 20);
            this.txtSearch.TabIndex = 18;
            // 
            // btnShowAll
            // 
            this.btnShowAll.Location = new System.Drawing.Point(377, 75);
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.Size = new System.Drawing.Size(75, 23);
            this.btnShowAll.TabIndex = 19;
            this.btnShowAll.Text = "Show All";
            this.btnShowAll.UseVisualStyleBackColor = true;
            this.btnShowAll.Click += new System.EventHandler(this.btnShowAll_Click);
            // 
            // dgvMenu
            // 
            this.dgvMenu.AllowUserToAddRows = false;
            this.dgvMenu.AllowUserToDeleteRows = false;
            this.dgvMenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMenu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.menuid,
            this.name,
            this.unit_price,
            this.category});
            this.dgvMenu.Location = new System.Drawing.Point(376, 112);
            this.dgvMenu.Name = "dgvMenu";
            this.dgvMenu.ReadOnly = true;
            this.dgvMenu.Size = new System.Drawing.Size(408, 214);
            this.dgvMenu.TabIndex = 20;
            // 
            // menuid
            // 
            this.menuid.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.menuid.DataPropertyName = "menu_id";
            this.menuid.HeaderText = "Menu Id";
            this.menuid.Name = "menuid";
            this.menuid.ReadOnly = true;
            // 
            // name
            // 
            this.name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.name.DataPropertyName = "name";
            this.name.HeaderText = "Name";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // unit_price
            // 
            this.unit_price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.unit_price.DataPropertyName = "unit_price";
            this.unit_price.HeaderText = "Unit Price";
            this.unit_price.Name = "unit_price";
            this.unit_price.ReadOnly = true;
            // 
            // category
            // 
            this.category.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.category.DataPropertyName = "category_name";
            this.category.HeaderText = "Category";
            this.category.Name = "category";
            this.category.ReadOnly = true;
            // 
            // WFAMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlMenu);
            this.Name = "WFAMenu";
            this.Text = "Menu";
            this.pnlMenu.ResumeLayout(false);
            this.pnlMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMenu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Label lblCategoryName;
        private System.Windows.Forms.TextBox txtUnitPrice;
        private System.Windows.Forms.Label lblUnitPrice;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtMenuId;
        private System.Windows.Forms.Label menu_id;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.RadioButton rbDessert;
        private System.Windows.Forms.RadioButton rbDrinks;
        private System.Windows.Forms.RadioButton rbCoffee;
        private System.Windows.Forms.RadioButton rbStarter;
        private System.Windows.Forms.RadioButton rbPizza;
        private System.Windows.Forms.RadioButton rbBurger;
        private System.Windows.Forms.RadioButton rbSandwich;
        private System.Windows.Forms.RadioButton rbSetMeals;
        private System.Windows.Forms.RadioButton rbBreakfast;
        private System.Windows.Forms.Button btnShowAll;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dgvMenu;
        private System.Windows.Forms.DataGridViewTextBoxColumn menuid;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn unit_price;
        private System.Windows.Forms.DataGridViewTextBoxColumn category;
    }
}