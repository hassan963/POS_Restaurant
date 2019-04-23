using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using DataAccessLayer;

namespace Admin
{
    public partial class Accountant : Form
    {
        DataAccess Da { get; set; }
        DataSet Ds { get; set; }

        private int id;

        public Accountant()
        {
            InitializeComponent();
            this.Da = new DataAccess();
            this.PopulateGridView();
            this.PopulateGridViewSales();
        }

        public void PopulateGridView(string sql = "select * from tbl_menu")
        {
            this.Ds = this.Da.ExecuteQuery(sql);

            this.dgvMenu.AutoGenerateColumns = false;
            this.dgvMenu.DataSource = this.Ds.Tables[0];
        }

        public void PopulateGridViewSales(string sql = "select * from tbl_order")
        {
            this.Ds = this.Da.ExecuteQuery(sql);

            this.dgvSaleReport.AutoGenerateColumns = false;
            this.dgvSaleReport.DataSource = this.Ds.Tables[0];
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            //Show All
            this.PopulateGridView();
        }

        private void dgvMenu_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.lblMenuName.Text = this.dgvMenu.CurrentRow.Cells["name"].Value.ToString();
            this.txtPrice.Text = this.dgvMenu.CurrentRow.Cells["unit_price"].Value.ToString();
            id = Convert.ToInt32(this.dgvMenu.CurrentRow.Cells["menu_id"].Value);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //UPDATE PRICE

            string sql = "select * from tbl_menu where menu_id ='" + this.id + "'";
            this.Ds = this.Da.ExecuteQuery(sql);

            if (this.Ds.Tables[0].Rows.Count == 1)
            {
                sql = @"update tbl_menu
                set unit_price = '" + this.txtPrice.Text + @"'
                where menu_id = '" + this.id + "'";

                try
                {
                    this.Da.ExecuteUpdateQuery(sql);
                    MessageBox.Show("Upgradation Done.");
                    this.PopulateGridView();
                }
                catch (Exception exc)
                {
                    MessageBox.Show("Error: " + exc.Message);
                }
            }
        }

        private void btnSeach_Click(object sender, EventArgs e)
        {
            //Search with price range

            string sql = "select * from tbl_menu where unit_price <= '" + float.Parse(this.txtSearch.Text) + "'";
            this.PopulateGridView(sql);
        }

        private void txtAutoTextSearch_TextChanged(object sender, EventArgs e)
        {
            //Search with title

            string sql = "select * from tbl_menu where name like '" + this.txtAutoTextSearch.Text + "%'";
            this.PopulateGridView(sql);
        }

        private void pnlAccountant_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSalesHistory_Click(object sender, EventArgs e)
        {
            this.PopulateGridViewSales();
        }
    }
}
