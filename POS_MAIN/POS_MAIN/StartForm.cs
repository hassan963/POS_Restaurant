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
using DataAccessLayer;
using Admin;

namespace POS_MAIN
{
    public partial class StartForm : Form
    {


        public delegate void delPassData(TextBox text);

        private DataAccess Da { get; set; }
        private DataSet Ds { get; set; }


        public StartForm()
        {
            InitializeComponent();
            this.Da = new DataAccess();
            this.txtPassword.PasswordChar = '$';
        }

      

        private void btnLogin_Click(object sender, EventArgs e)
        {

            string sql = "select * from tbl_user where user_name = '" + txtUserName.Text.Trim() + "' and password = '" + txtPassword.Text.Trim() + "'";

            Console.WriteLine(sql);
            this.Ds = this.Da.ExecuteQuery(sql);

            if (this.Ds.Tables[0].Rows.Count == 1 && this.Ds.Tables[0].Rows[0][6].ToString() == "Admin")
            {
                //MessageBox.Show("Admin");

                this.Visible = false;
                AdminPanel ap = new AdminPanel();
                ap.Visible = true;
            }
            else if (this.Ds.Tables[0].Rows.Count == 1 && this.Ds.Tables[0].Rows[0][6].ToString() == "Sale")
            {
                //MessageBox.Show("Sale");

                this.Visible = false;
                CashierForm wfaMenu = new CashierForm();
                delPassData del = new delPassData(wfaMenu.SaveUserName);
           
                del(this.txtUserName);

                wfaMenu.Visible = true;
            }
            else if (this.Ds.Tables[0].Rows.Count == 1 && this.Ds.Tables[0].Rows[0][6].ToString() == "Accountant")
            {
                //MessageBox.Show("Accountant");
                this.Visible = false;
                Accountant ac = new Accountant();
                ac.Visible = true;
            }


        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //this.Close();
            Application.Exit();
        }

       
    }
}
