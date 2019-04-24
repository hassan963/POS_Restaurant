using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessAccessLayer;

namespace POS_MAIN
{
    public partial class OrderDetailsForm : Form
    {

        private CashierOperationBL CashierOperation
        {
            set;
            get;
        }


        public OrderDetailsForm()
        {
            InitializeComponent();
            //CashierOperation = new 
        }

        DataSet Ds { get; set; }

        private void PopulateGridView(string order_id)
        {
            this.Ds = CashierOperation.OrderDetails(order_id);

            this.order_details_data_grid.AutoGenerateColumns = false;
            this.order_details_data_grid.DataSource = this.Ds.Tables[0];
        }

        public void ShowOrderDetails(CashierOperationBL cashierOperationBL, string order_id)
        {
            this.CashierOperation = cashierOperationBL;
            PopulateGridView(order_id);

            this.Ds = cashierOperationBL.OrderStatus(order_id);

            this.order_id_label.Text = "ID: " + Ds.Tables[0].Rows[0][0].ToString();
            this.total_price_label.Text = "Total Price: " + Ds.Tables[0].Rows[0][1].ToString();
            this.sale_person_name_label.Text = "Received by. " + Ds.Tables[0].Rows[0][3].ToString();
        
        }

        private void close_button_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        
    }
}
