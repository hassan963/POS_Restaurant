namespace POS_MAIN
{
    partial class CashierForm
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.PayButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.quantityTextBox = new System.Windows.Forms.TextBox();
            this.print_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.totalPriceLabel = new System.Windows.Forms.Label();
            this.orderListView = new System.Windows.Forms.ListView();
            this.menuName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.quantity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1 = new System.Windows.Forms.Panel();
            this.DessertLabel = new System.Windows.Forms.Label();
            this.DrinksLabel = new System.Windows.Forms.Label();
            this.StarterLabel = new System.Windows.Forms.Label();
            this.CoffeeLabel = new System.Windows.Forms.Label();
            this.PizzaLabel = new System.Windows.Forms.Label();
            this.BurgerLabel = new System.Windows.Forms.Label();
            this.SandwichLabel = new System.Windows.Forms.Label();
            this.SetMealsLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menu_listview = new System.Windows.Forms.ListView();
            this.menu_name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.date_label = new System.Windows.Forms.Label();
            this.user_name_label = new System.Windows.Forms.Label();
            this.search_textbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.log_out_button = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.AntiqueWhite;
            this.panel2.Controls.Add(this.PayButton);
            this.panel2.Controls.Add(this.ClearButton);
            this.panel2.Controls.Add(this.UpdateButton);
            this.panel2.Controls.Add(this.quantityTextBox);
            this.panel2.Controls.Add(this.print_button);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.totalPriceLabel);
            this.panel2.Controls.Add(this.orderListView);
            this.panel2.Location = new System.Drawing.Point(756, 37);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(471, 473);
            this.panel2.TabIndex = 1;
            // 
            // PayButton
            // 
            this.PayButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PayButton.Location = new System.Drawing.Point(347, 402);
            this.PayButton.Name = "PayButton";
            this.PayButton.Size = new System.Drawing.Size(95, 39);
            this.PayButton.TabIndex = 7;
            this.PayButton.Text = "Pay";
            this.PayButton.UseVisualStyleBackColor = true;
            this.PayButton.Click += new System.EventHandler(this.PayButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearButton.Location = new System.Drawing.Point(347, 22);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(112, 31);
            this.ClearButton.TabIndex = 6;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // UpdateButton
            // 
            this.UpdateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateButton.Location = new System.Drawing.Point(192, 22);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(112, 31);
            this.UpdateButton.TabIndex = 5;
            this.UpdateButton.Text = "Update";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // quantityTextBox
            // 
            this.quantityTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantityTextBox.Location = new System.Drawing.Point(3, 22);
            this.quantityTextBox.Name = "quantityTextBox";
            this.quantityTextBox.Size = new System.Drawing.Size(166, 31);
            this.quantityTextBox.TabIndex = 4;
            // 
            // print_button
            // 
            this.print_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.print_button.Location = new System.Drawing.Point(229, 402);
            this.print_button.Name = "print_button";
            this.print_button.Size = new System.Drawing.Size(112, 39);
            this.print_button.TabIndex = 3;
            this.print_button.Text = "Print";
            this.print_button.UseVisualStyleBackColor = true;
            this.print_button.Click += new System.EventHandler(this.print_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 357);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Total";
            // 
            // totalPriceLabel
            // 
            this.totalPriceLabel.AutoSize = true;
            this.totalPriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalPriceLabel.Location = new System.Drawing.Point(342, 357);
            this.totalPriceLabel.Name = "totalPriceLabel";
            this.totalPriceLabel.Size = new System.Drawing.Size(48, 29);
            this.totalPriceLabel.TabIndex = 1;
            this.totalPriceLabel.Text = "0.0";
            // 
            // orderListView
            // 
            this.orderListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.menuName,
            this.quantity,
            this.price});
            this.orderListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderListView.Location = new System.Drawing.Point(3, 59);
            this.orderListView.Name = "orderListView";
            this.orderListView.Size = new System.Drawing.Size(465, 295);
            this.orderListView.TabIndex = 0;
            this.orderListView.UseCompatibleStateImageBehavior = false;
            this.orderListView.View = System.Windows.Forms.View.Details;
            this.orderListView.DoubleClick += new System.EventHandler(this.OrderListView_SelectedIndexChanged);
            // 
            // menuName
            // 
            this.menuName.Text = "Menu Name";
            this.menuName.Width = 247;
            // 
            // quantity
            // 
            this.quantity.Text = "Quantity";
            this.quantity.Width = 103;
            // 
            // price
            // 
            this.price.Text = "Unit Price";
            this.price.Width = 105;
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.Color.PapayaWhip;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.Controls.Add(this.DessertLabel);
            this.panel1.Controls.Add(this.DrinksLabel);
            this.panel1.Controls.Add(this.StarterLabel);
            this.panel1.Controls.Add(this.CoffeeLabel);
            this.panel1.Controls.Add(this.PizzaLabel);
            this.panel1.Controls.Add(this.BurgerLabel);
            this.panel1.Controls.Add(this.SandwichLabel);
            this.panel1.Controls.Add(this.SetMealsLabel);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.menu_listview);
            this.panel1.Location = new System.Drawing.Point(12, 111);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(724, 372);
            this.panel1.TabIndex = 2;
            // 
            // DessertLabel
            // 
            this.DessertLabel.AutoSize = true;
            this.DessertLabel.BackColor = System.Drawing.Color.Chartreuse;
            this.DessertLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DessertLabel.ForeColor = System.Drawing.Color.White;
            this.DessertLabel.Location = new System.Drawing.Point(178, 6);
            this.DessertLabel.Name = "DessertLabel";
            this.DessertLabel.Size = new System.Drawing.Size(116, 31);
            this.DessertLabel.TabIndex = 21;
            this.DessertLabel.Text = "Dessert";
            this.DessertLabel.Click += new System.EventHandler(this.Label_Click);
            // 
            // DrinksLabel
            // 
            this.DrinksLabel.AutoSize = true;
            this.DrinksLabel.BackColor = System.Drawing.Color.DarkGreen;
            this.DrinksLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DrinksLabel.ForeColor = System.Drawing.Color.White;
            this.DrinksLabel.Location = new System.Drawing.Point(350, 50);
            this.DrinksLabel.Name = "DrinksLabel";
            this.DrinksLabel.Size = new System.Drawing.Size(98, 31);
            this.DrinksLabel.TabIndex = 20;
            this.DrinksLabel.Text = "Drinks";
            this.DrinksLabel.Click += new System.EventHandler(this.Label_Click);
            // 
            // StarterLabel
            // 
            this.StarterLabel.AutoSize = true;
            this.StarterLabel.BackColor = System.Drawing.Color.YellowGreen;
            this.StarterLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StarterLabel.ForeColor = System.Drawing.Color.White;
            this.StarterLabel.Location = new System.Drawing.Point(95, 50);
            this.StarterLabel.Name = "StarterLabel";
            this.StarterLabel.Size = new System.Drawing.Size(103, 31);
            this.StarterLabel.TabIndex = 19;
            this.StarterLabel.Text = "Starter";
            this.StarterLabel.Click += new System.EventHandler(this.Label_Click);
            // 
            // CoffeeLabel
            // 
            this.CoffeeLabel.AutoSize = true;
            this.CoffeeLabel.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.CoffeeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CoffeeLabel.ForeColor = System.Drawing.Color.White;
            this.CoffeeLabel.Location = new System.Drawing.Point(217, 50);
            this.CoffeeLabel.Name = "CoffeeLabel";
            this.CoffeeLabel.Size = new System.Drawing.Size(101, 31);
            this.CoffeeLabel.TabIndex = 18;
            this.CoffeeLabel.Text = "Coffee";
            this.CoffeeLabel.Click += new System.EventHandler(this.Label_Click);
            // 
            // PizzaLabel
            // 
            this.PizzaLabel.AutoSize = true;
            this.PizzaLabel.BackColor = System.Drawing.Color.Green;
            this.PizzaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PizzaLabel.ForeColor = System.Drawing.Color.White;
            this.PizzaLabel.Location = new System.Drawing.Point(3, 50);
            this.PizzaLabel.Name = "PizzaLabel";
            this.PizzaLabel.Size = new System.Drawing.Size(86, 31);
            this.PizzaLabel.TabIndex = 17;
            this.PizzaLabel.Text = "Pizza";
            this.PizzaLabel.Click += new System.EventHandler(this.Label_Click);
            // 
            // BurgerLabel
            // 
            this.BurgerLabel.AutoSize = true;
            this.BurgerLabel.BackColor = System.Drawing.Color.OliveDrab;
            this.BurgerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BurgerLabel.ForeColor = System.Drawing.Color.White;
            this.BurgerLabel.Location = new System.Drawing.Point(516, 6);
            this.BurgerLabel.Name = "BurgerLabel";
            this.BurgerLabel.Size = new System.Drawing.Size(101, 31);
            this.BurgerLabel.TabIndex = 15;
            this.BurgerLabel.Text = "Burger";
            this.BurgerLabel.Click += new System.EventHandler(this.Label_Click);
            // 
            // SandwichLabel
            // 
            this.SandwichLabel.AutoSize = true;
            this.SandwichLabel.BackColor = System.Drawing.Color.ForestGreen;
            this.SandwichLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SandwichLabel.ForeColor = System.Drawing.Color.White;
            this.SandwichLabel.Location = new System.Drawing.Point(318, 6);
            this.SandwichLabel.Name = "SandwichLabel";
            this.SandwichLabel.Size = new System.Drawing.Size(140, 31);
            this.SandwichLabel.TabIndex = 14;
            this.SandwichLabel.Text = "Sandwich";
            this.SandwichLabel.Click += new System.EventHandler(this.Label_Click);
            // 
            // SetMealsLabel
            // 
            this.SetMealsLabel.AutoSize = true;
            this.SetMealsLabel.BackColor = System.Drawing.Color.LawnGreen;
            this.SetMealsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SetMealsLabel.ForeColor = System.Drawing.Color.White;
            this.SetMealsLabel.Location = new System.Drawing.Point(474, 50);
            this.SetMealsLabel.Name = "SetMealsLabel";
            this.SetMealsLabel.Size = new System.Drawing.Size(143, 31);
            this.SetMealsLabel.TabIndex = 13;
            this.SetMealsLabel.Text = "Set Meals";
            this.SetMealsLabel.Click += new System.EventHandler(this.Label_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(3, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 31);
            this.label2.TabIndex = 12;
            this.label2.Text = "Breakfast";
            this.label2.Click += new System.EventHandler(this.Label_Click);
            // 
            // menu_listview
            // 
            this.menu_listview.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.menu_listview.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.menu_name});
            this.menu_listview.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu_listview.ForeColor = System.Drawing.Color.Maroon;
            this.menu_listview.Location = new System.Drawing.Point(3, 105);
            this.menu_listview.Name = "menu_listview";
            this.menu_listview.Size = new System.Drawing.Size(715, 264);
            this.menu_listview.TabIndex = 10;
            this.menu_listview.UseCompatibleStateImageBehavior = false;
            this.menu_listview.View = System.Windows.Forms.View.Tile;
            this.menu_listview.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.Menu_listview_ItemSelectionChanged);
            // 
            // date_label
            // 
            this.date_label.AutoSize = true;
            this.date_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_label.Location = new System.Drawing.Point(18, 9);
            this.date_label.Name = "date_label";
            this.date_label.Size = new System.Drawing.Size(139, 29);
            this.date_label.TabIndex = 3;
            this.date_label.Text = "23.04.2019";
            // 
            // user_name_label
            // 
            this.user_name_label.AutoSize = true;
            this.user_name_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user_name_label.Location = new System.Drawing.Point(20, 63);
            this.user_name_label.Name = "user_name_label";
            this.user_name_label.Size = new System.Drawing.Size(128, 25);
            this.user_name_label.TabIndex = 4;
            this.user_name_label.Text = "User Name";
            // 
            // search_textbox
            // 
            this.search_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_textbox.Location = new System.Drawing.Point(402, 60);
            this.search_textbox.Name = "search_textbox";
            this.search_textbox.Size = new System.Drawing.Size(166, 31);
            this.search_textbox.TabIndex = 7;
            this.search_textbox.TextChanged += new System.EventHandler(this.search_textbox_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(398, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(158, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Search by name or id";
            // 
            // log_out_button
            // 
            this.log_out_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.log_out_button.Location = new System.Drawing.Point(610, 37);
            this.log_out_button.Name = "log_out_button";
            this.log_out_button.Size = new System.Drawing.Size(120, 54);
            this.log_out_button.TabIndex = 8;
            this.log_out_button.Text = "Log Out";
            this.log_out_button.UseVisualStyleBackColor = true;
            this.log_out_button.Click += new System.EventHandler(this.log_out_button_Click);
            // 
            // CashierForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1239, 522);
            this.Controls.Add(this.log_out_button);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.search_textbox);
            this.Controls.Add(this.user_name_label);
            this.Controls.Add(this.date_label);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "CashierForm";
            this.Text = "CashierForm";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListView menu_listview;
        private System.Windows.Forms.ColumnHeader menu_name;
        private System.Windows.Forms.Label DessertLabel;
        private System.Windows.Forms.Label DrinksLabel;
        private System.Windows.Forms.Label StarterLabel;
        private System.Windows.Forms.Label CoffeeLabel;
        private System.Windows.Forms.Label PizzaLabel;
        private System.Windows.Forms.Label BurgerLabel;
        private System.Windows.Forms.Label SandwichLabel;
        private System.Windows.Forms.Label SetMealsLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView orderListView;
        private System.Windows.Forms.ColumnHeader menuName;
        private System.Windows.Forms.ColumnHeader quantity;
        private System.Windows.Forms.ColumnHeader price;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.TextBox quantityTextBox;
        private System.Windows.Forms.Button print_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label totalPriceLabel;
        private System.Windows.Forms.Button PayButton;
        private System.Windows.Forms.Label date_label;
        private System.Windows.Forms.Label user_name_label;
        private System.Windows.Forms.TextBox search_textbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button log_out_button;
    }
}