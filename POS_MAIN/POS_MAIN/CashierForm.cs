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
using BusinessObject;

namespace POS_MAIN
{
    public partial class CashierForm : Form
    {
        private static float totalPrice = 0;

        private static string order_id = "";

        private List<OrderDetailsRepo> orderDetailsRepos;

        private delegate void delPassLayer(CashierOperationBL cashierOperation, string order_id);

        public CashierForm()
        {
            InitializeComponent();
            this.orderListView.MultiSelect = false;
            this.orderListView.HideSelection = false;
            this.orderListView.FullRowSelect = true;
            this.CashierOperation = new CashierOperationBL();

            date_label.Text = this.CashierOperation.GetDate();

            orderDetailsRepos = new List<OrderDetailsRepo>();

        }

        private CashierOperationBL CashierOperation
        {
            set;
            get;
        }

        protected void Label_Click(object sender, EventArgs e)
        {
            //attempt to cast the sender as a label
            Label lbl = sender as Label;

            //if the cast was successful (i.e. not null), navigate to the site
            if (lbl != null)
                ShowMenuList(lbl.Text);
        }


        private void ShowMenuList(string categoryName)
        {
            this.menu_listview.Clear();

           // CashierOperationBL cashierOperationLayer = new CashierOperationBL();
            List<MenuInfo> menuList = this.CashierOperation.GetList(categoryName);
            foreach (MenuInfo singleMenu in menuList)
            {
                //menu_listview.Items.Add(new ListViewItem(singleMenu.Name));
                CreateListViewItem(this.menu_listview, singleMenu);
            }
        }

        protected void MenuListView_Click(object sender, EventArgs e)
        {

        }

        private void OrderListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            //MessageBox.Show(orderListView.SelectedItems[0].SubItems[1].Text);
            this.quantityTextBox.Text = this.orderListView.SelectedItems[0].SubItems[1].Text;

        }

        public static void CreateListViewItem(ListView listView, MenuInfo obj)
        {
            ListViewItem item = new ListViewItem();
            item.Text = obj.Name;
            item.Tag = obj;
            listView.Items.Add(item);
        }

        private void Menu_listview_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            MenuInfo menuInfo = (MenuInfo)e.Item.Tag;
            int menuID = menuInfo.Menu_Id;
            string menuName = menuInfo.Name;
            float price = menuInfo.UnitPrice;
            //MessageBox.Show(menuInfo.Name+menuInfo.UnitPrice);
            if (this.menu_listview.SelectedItems.Count > 0)
            {
                ListViewItem listView = new ListViewItem(menuName);
                listView.SubItems.Add("1");
                listView.SubItems.Add("" + price);
                listView.SubItems.Add("" + menuID);
                this.orderListView.Items.Add(listView);
                totalPrice += price;
                totalPriceLabel.Text = Convert.ToString(totalPrice);
            }
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            

            if (this.orderListView.SelectedItems.Count > 0 && Convert.ToInt32(quantityTextBox.Text) > 0)
            {
                this.orderListView.SelectedItems[0].SubItems[1].Text = quantityTextBox.Text;
            }
            totalPrice = 0;
            for (int i = 0; i < this.orderListView.Items.Count; i++)
            {
                totalPrice += (float.Parse(orderListView.Items[i].SubItems[1].Text) * float.Parse(orderListView.Items[i].SubItems[2].Text));
            }

            this.totalPriceLabel.Text = Convert.ToString(totalPrice);

        }

        private void PayButton_Click(object sender, EventArgs e)
        {
            
            totalPrice = 0;

            orderDetailsRepos.Clear();
            //  CashierOperationBL cashierOperationBL = new CashierOperationBL();
            order_id = this.CashierOperation.RandomString();
            for (int i = 0; i <this.orderListView.Items.Count; i++)
            {
                orderDetailsRepos.Add(new OrderDetailsRepo(order_id, float.Parse(orderListView.Items[i].SubItems[2].Text), short.Parse(orderListView.Items[i].SubItems[1].Text), int.Parse(orderListView.Items[i].SubItems[3].Text)));
                totalPrice += (short.Parse(orderListView.Items[i].SubItems[1].Text) * float.Parse(orderListView.Items[i].SubItems[2].Text));
            }

            this.totalPriceLabel.Text = Convert.ToString(totalPrice);

            this.CashierOperation.Addorder(orderDetailsRepos, user_name_label.Text);

            MessageBox.Show("Order Completed");

            this.ClearReceipt();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            this.ClearReceipt();
            order_id = "";
        }

        private void user_type_label_Click(object sender, EventArgs e)
        {
            
        }

        private void search_button_Click(object sender, EventArgs e)
        {
            string search_text = search_textbox.Text;
            
        }

        private void ShowSearchList(string categoryName)
        {
            this.menu_listview.Clear();

          //  CashierOperationBL cashierOperationBL = new CashierOperationBL();
            List<MenuInfo> menuList = this.CashierOperation.SearchMenus(search_textbox.Text);
            foreach (MenuInfo singleMenu in menuList)
            {
                //menu_listview.Items.Add(new ListViewItem(singleMenu.Name));
                CreateListViewItem(this.menu_listview, singleMenu);
            }
        }

        private void search_textbox_TextChanged(object sender, EventArgs e)
        {
            ShowSearchList(search_textbox.Text);
        }

        private void log_out_button_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            StartForm startForm = new StartForm();
            startForm.Visible = true;
        }

        public void SaveUserName(TextBox textBox)

        {

            user_name_label.Text = textBox.Text;

        }

        private void print_button_Click(object sender, EventArgs e)
        {
            if(order_id.Length > 7)
            {
                OrderDetailsForm orderDetailsForm = new OrderDetailsForm();
                delPassLayer del = new delPassLayer(orderDetailsForm.ShowOrderDetails);

                del(this.CashierOperation, order_id);
                order_id = "";
                orderDetailsForm.Visible = true;

            }
            else
            {
                MessageBox.Show("Try again.");
            }
            
        }

        private void ClearReceipt()
        {
            this.orderListView.Items.Clear();
            this.totalPriceLabel.Text = "0.0";
            this.quantityTextBox.Text = "";
            totalPrice = 0;
        }
    }
}
