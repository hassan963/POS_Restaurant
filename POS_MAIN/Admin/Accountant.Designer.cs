namespace Admin
{
    partial class Accountant
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
            this.btnSeach = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnShowAll = new System.Windows.Forms.Button();
            this.dgvMenu = new System.Windows.Forms.DataGridView();
            this.category_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unit_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menu_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.lblMenuName = new System.Windows.Forms.Label();
            this.txtAutoTextSearch = new System.Windows.Forms.TextBox();
            this.lblSearchByPrice = new System.Windows.Forms.Label();
            this.lblSearchByName = new System.Windows.Forms.Label();
            this.lblShowPriceRange = new System.Windows.Forms.Label();
            this.pnlAccountant = new System.Windows.Forms.Panel();
            this.dgvSaleReport = new System.Windows.Forms.DataGridView();
            this.order_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date_of_purchase = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.user_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSalesHistory = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMenu)).BeginInit();
            this.pnlAccountant.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSaleReport)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSeach
            // 
            this.btnSeach.Location = new System.Drawing.Point(485, 34);
            this.btnSeach.Name = "btnSeach";
            this.btnSeach.Size = new System.Drawing.Size(75, 23);
            this.btnSeach.TabIndex = 0;
            this.btnSeach.Text = "Search";
            this.btnSeach.UseVisualStyleBackColor = true;
            this.btnSeach.Click += new System.EventHandler(this.btnSeach_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(356, 36);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(100, 20);
            this.txtSearch.TabIndex = 1;
            // 
            // btnShowAll
            // 
            this.btnShowAll.Location = new System.Drawing.Point(658, 98);
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.Size = new System.Drawing.Size(113, 59);
            this.btnShowAll.TabIndex = 2;
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
            this.menu_id,
            this.name,
            this.unit_price,
            this.category_name});
            this.dgvMenu.Location = new System.Drawing.Point(356, 163);
            this.dgvMenu.Name = "dgvMenu";
            this.dgvMenu.ReadOnly = true;
            this.dgvMenu.Size = new System.Drawing.Size(426, 231);
            this.dgvMenu.TabIndex = 3;
            this.dgvMenu.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMenu_CellContentDoubleClick);
            // 
            // category_name
            // 
            this.category_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.category_name.DataPropertyName = "category_name";
            this.category_name.HeaderText = "Category";
            this.category_name.Name = "category_name";
            this.category_name.ReadOnly = true;
            // 
            // unit_price
            // 
            this.unit_price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.unit_price.DataPropertyName = "unit_price";
            this.unit_price.HeaderText = "Unit Price";
            this.unit_price.Name = "unit_price";
            this.unit_price.ReadOnly = true;
            // 
            // name
            // 
            this.name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.name.DataPropertyName = "name";
            this.name.HeaderText = "Name";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // menu_id
            // 
            this.menu_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.menu_id.DataPropertyName = "menu_id";
            this.menu_id.HeaderText = "Menu Id";
            this.menu_id.Name = "menu_id";
            this.menu_id.ReadOnly = true;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(6, 62);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(31, 13);
            this.lblPrice.TabIndex = 5;
            this.lblPrice.Text = "Price";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(85, 64);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(100, 20);
            this.txtPrice.TabIndex = 6;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(3, 102);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(6, 21);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 8;
            this.lblName.Text = "Name";
            // 
            // lblMenuName
            // 
            this.lblMenuName.AutoSize = true;
            this.lblMenuName.Location = new System.Drawing.Point(82, 21);
            this.lblMenuName.Name = "lblMenuName";
            this.lblMenuName.Size = new System.Drawing.Size(0, 13);
            this.lblMenuName.TabIndex = 9;
            // 
            // txtAutoTextSearch
            // 
            this.txtAutoTextSearch.Location = new System.Drawing.Point(356, 126);
            this.txtAutoTextSearch.Name = "txtAutoTextSearch";
            this.txtAutoTextSearch.Size = new System.Drawing.Size(100, 20);
            this.txtAutoTextSearch.TabIndex = 10;
            this.txtAutoTextSearch.TextChanged += new System.EventHandler(this.txtAutoTextSearch_TextChanged);
            // 
            // lblSearchByPrice
            // 
            this.lblSearchByPrice.AutoSize = true;
            this.lblSearchByPrice.Location = new System.Drawing.Point(353, 20);
            this.lblSearchByPrice.Name = "lblSearchByPrice";
            this.lblSearchByPrice.Size = new System.Drawing.Size(117, 13);
            this.lblSearchByPrice.TabIndex = 11;
            this.lblSearchByPrice.Text = "Search by Price Range";
            // 
            // lblSearchByName
            // 
            this.lblSearchByName.AutoSize = true;
            this.lblSearchByName.Location = new System.Drawing.Point(353, 102);
            this.lblSearchByName.Name = "lblSearchByName";
            this.lblSearchByName.Size = new System.Drawing.Size(86, 13);
            this.lblSearchByName.TabIndex = 12;
            this.lblSearchByName.Text = "Search by Name";
            // 
            // lblShowPriceRange
            // 
            this.lblShowPriceRange.AutoSize = true;
            this.lblShowPriceRange.Location = new System.Drawing.Point(353, 59);
            this.lblShowPriceRange.Name = "lblShowPriceRange";
            this.lblShowPriceRange.Size = new System.Drawing.Size(0, 13);
            this.lblShowPriceRange.TabIndex = 13;
            // 
            // pnlAccountant
            // 
            this.pnlAccountant.Controls.Add(this.btnSalesHistory);
            this.pnlAccountant.Controls.Add(this.dgvSaleReport);
            this.pnlAccountant.Controls.Add(this.lblShowPriceRange);
            this.pnlAccountant.Controls.Add(this.lblSearchByName);
            this.pnlAccountant.Controls.Add(this.lblSearchByPrice);
            this.pnlAccountant.Controls.Add(this.txtAutoTextSearch);
            this.pnlAccountant.Controls.Add(this.lblMenuName);
            this.pnlAccountant.Controls.Add(this.lblName);
            this.pnlAccountant.Controls.Add(this.btnSave);
            this.pnlAccountant.Controls.Add(this.txtPrice);
            this.pnlAccountant.Controls.Add(this.lblPrice);
            this.pnlAccountant.Controls.Add(this.dgvMenu);
            this.pnlAccountant.Controls.Add(this.btnShowAll);
            this.pnlAccountant.Controls.Add(this.txtSearch);
            this.pnlAccountant.Controls.Add(this.btnSeach);
            this.pnlAccountant.Location = new System.Drawing.Point(6, 5);
            this.pnlAccountant.Name = "pnlAccountant";
            this.pnlAccountant.Size = new System.Drawing.Size(791, 445);
            this.pnlAccountant.TabIndex = 0;
            this.pnlAccountant.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlAccountant_Paint);
            // 
            // dgvSaleReport
            // 
            this.dgvSaleReport.AllowUserToAddRows = false;
            this.dgvSaleReport.AllowUserToDeleteRows = false;
            this.dgvSaleReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSaleReport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.order_id,
            this.total_price,
            this.date_of_purchase,
            this.user_name});
            this.dgvSaleReport.Location = new System.Drawing.Point(12, 172);
            this.dgvSaleReport.Name = "dgvSaleReport";
            this.dgvSaleReport.ReadOnly = true;
            this.dgvSaleReport.Size = new System.Drawing.Size(325, 221);
            this.dgvSaleReport.TabIndex = 14;
            // 
            // order_id
            // 
            this.order_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.order_id.DataPropertyName = "order_id";
            this.order_id.HeaderText = "Order Id";
            this.order_id.Name = "order_id";
            this.order_id.ReadOnly = true;
            // 
            // total_price
            // 
            this.total_price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.total_price.DataPropertyName = "total_price";
            this.total_price.HeaderText = "Total Price";
            this.total_price.Name = "total_price";
            this.total_price.ReadOnly = true;
            // 
            // date_of_purchase
            // 
            this.date_of_purchase.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.date_of_purchase.DataPropertyName = "date_of_purchase";
            this.date_of_purchase.HeaderText = "Date of Purchase";
            this.date_of_purchase.Name = "date_of_purchase";
            this.date_of_purchase.ReadOnly = true;
            // 
            // user_name
            // 
            this.user_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.user_name.DataPropertyName = "user_name";
            this.user_name.HeaderText = "User Name";
            this.user_name.Name = "user_name";
            this.user_name.ReadOnly = true;
            // 
            // btnSalesHistory
            // 
            this.btnSalesHistory.Location = new System.Drawing.Point(211, 98);
            this.btnSalesHistory.Name = "btnSalesHistory";
            this.btnSalesHistory.Size = new System.Drawing.Size(112, 48);
            this.btnSalesHistory.TabIndex = 15;
            this.btnSalesHistory.Text = "Sales History";
            this.btnSalesHistory.UseVisualStyleBackColor = true;
            this.btnSalesHistory.Click += new System.EventHandler(this.btnSalesHistory_Click);
            // 
            // Accountant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlAccountant);
            this.Name = "Accountant";
            this.Text = "Accountant";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMenu)).EndInit();
            this.pnlAccountant.ResumeLayout(false);
            this.pnlAccountant.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSaleReport)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSeach;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnShowAll;
        private System.Windows.Forms.DataGridView dgvMenu;
        private System.Windows.Forms.DataGridViewTextBoxColumn menu_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn unit_price;
        private System.Windows.Forms.DataGridViewTextBoxColumn category_name;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblMenuName;
        private System.Windows.Forms.TextBox txtAutoTextSearch;
        private System.Windows.Forms.Label lblSearchByPrice;
        private System.Windows.Forms.Label lblSearchByName;
        private System.Windows.Forms.Label lblShowPriceRange;
        private System.Windows.Forms.Panel pnlAccountant;
        private System.Windows.Forms.Button btnSalesHistory;
        private System.Windows.Forms.DataGridView dgvSaleReport;
        private System.Windows.Forms.DataGridViewTextBoxColumn order_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn total_price;
        private System.Windows.Forms.DataGridViewTextBoxColumn date_of_purchase;
        private System.Windows.Forms.DataGridViewTextBoxColumn user_name;
    }
}