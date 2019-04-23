using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccessLayer;

namespace Admin
{
    public partial class ValidateLogin : Form
    {
        private DataAccess Da { get; set; }
        private DataSet Ds { get; set; }

        public ValidateLogin()
        {
            InitializeComponent();
            this.Da = new DataAccess();
            this.txtPassword.PasswordChar = '$';
        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
           
            string sql = "select * from tbl_user where user_name = '"+txtUserName.Text.Trim()+"' and password = '"+txtPassword.Text.Trim()+"'";

            Console.WriteLine(sql);
            this.Ds = this.Da.ExecuteQuery(sql);

            if (this.Ds.Tables[0].Rows.Count == 1 && this.Ds.Tables[0].Rows[0][6].ToString() == "Admin")
            {
                MessageBox.Show("Admin");
            }
            else if (this.Ds.Tables[0].Rows.Count == 1 && this.Ds.Tables[0].Rows[0][6].ToString() == "Sale")
            {
                MessageBox.Show("Sale");
            }
            else if (this.Ds.Tables[0].Rows.Count == 1 && this.Ds.Tables[0].Rows[0][6].ToString() =="Accountant")
            {
                MessageBox.Show("Accountant");
            }

            
            
        }
    }
}
