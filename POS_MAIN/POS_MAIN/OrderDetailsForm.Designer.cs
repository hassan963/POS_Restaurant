namespace POS_MAIN
{
    partial class OrderDetailsForm
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.total_price_label = new System.Windows.Forms.Label();
            this.sale_person_name_label = new System.Windows.Forms.Label();
            this.close_button = new System.Windows.Forms.Button();
            this.order_details_data_grid = new System.Windows.Forms.DataGridView();
            this.order_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unit_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menu_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.order_id_label = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.order_details_data_grid)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.order_details_data_grid);
            this.panel1.Location = new System.Drawing.Point(2, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(396, 426);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.order_id_label);
            this.panel2.Controls.Add(this.close_button);
            this.panel2.Controls.Add(this.sale_person_name_label);
            this.panel2.Controls.Add(this.total_price_label);
            this.panel2.Location = new System.Drawing.Point(404, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(283, 426);
            this.panel2.TabIndex = 1;
            // 
            // total_price_label
            // 
            this.total_price_label.AutoSize = true;
            this.total_price_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total_price_label.Location = new System.Drawing.Point(13, 119);
            this.total_price_label.Name = "total_price_label";
            this.total_price_label.Size = new System.Drawing.Size(115, 25);
            this.total_price_label.TabIndex = 2;
            this.total_price_label.Text = "Total Price";
            // 
            // sale_person_name_label
            // 
            this.sale_person_name_label.AutoSize = true;
            this.sale_person_name_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sale_person_name_label.Location = new System.Drawing.Point(13, 158);
            this.sale_person_name_label.Name = "sale_person_name_label";
            this.sale_person_name_label.Size = new System.Drawing.Size(131, 25);
            this.sale_person_name_label.TabIndex = 3;
            this.sale_person_name_label.Text = "Received by";
            // 
            // close_button
            // 
            this.close_button.Location = new System.Drawing.Point(84, 219);
            this.close_button.Name = "close_button";
            this.close_button.Size = new System.Drawing.Size(124, 64);
            this.close_button.TabIndex = 4;
            this.close_button.Text = "Close";
            this.close_button.UseVisualStyleBackColor = true;
            this.close_button.Click += new System.EventHandler(this.close_button_Click);
            // 
            // order_details_data_grid
            // 
            this.order_details_data_grid.AllowUserToAddRows = false;
            this.order_details_data_grid.AllowUserToDeleteRows = false;
            this.order_details_data_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.order_details_data_grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.order_id,
            this.unit_price,
            this.quantity,
            this.menu_id});
            this.order_details_data_grid.Location = new System.Drawing.Point(3, 3);
            this.order_details_data_grid.Name = "order_details_data_grid";
            this.order_details_data_grid.ReadOnly = true;
            this.order_details_data_grid.Size = new System.Drawing.Size(393, 420);
            this.order_details_data_grid.TabIndex = 15;
            // 
            // order_id
            // 
            this.order_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.order_id.DataPropertyName = "order_id";
            this.order_id.HeaderText = "Order Id";
            this.order_id.Name = "order_id";
            this.order_id.ReadOnly = true;
            // 
            // unit_price
            // 
            this.unit_price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.unit_price.DataPropertyName = "unit_price";
            this.unit_price.HeaderText = "Unit Price";
            this.unit_price.Name = "unit_price";
            this.unit_price.ReadOnly = true;
            // 
            // quantity
            // 
            this.quantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.quantity.DataPropertyName = "quantity";
            this.quantity.HeaderText = "Quantity";
            this.quantity.Name = "quantity";
            this.quantity.ReadOnly = true;
            // 
            // menu_id
            // 
            this.menu_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.menu_id.DataPropertyName = "menu_id";
            this.menu_id.HeaderText = "Menu Id";
            this.menu_id.Name = "menu_id";
            this.menu_id.ReadOnly = true;
            // 
            // order_id_label
            // 
            this.order_id_label.AutoSize = true;
            this.order_id_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.order_id_label.Location = new System.Drawing.Point(13, 82);
            this.order_id_label.Name = "order_id_label";
            this.order_id_label.Size = new System.Drawing.Size(89, 25);
            this.order_id_label.TabIndex = 5;
            this.order_id_label.Text = "Order Id";
            // 
            // OrderDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "OrderDetailsForm";
            this.Text = "OrderDetailsForm";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.order_details_data_grid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button close_button;
        private System.Windows.Forms.Label sale_person_name_label;
        private System.Windows.Forms.Label total_price_label;
        private System.Windows.Forms.DataGridView order_details_data_grid;
        private System.Windows.Forms.DataGridViewTextBoxColumn order_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn unit_price;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn menu_id;
        private System.Windows.Forms.Label order_id_label;
    }
}