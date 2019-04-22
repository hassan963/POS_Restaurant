using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Admin.Entity;
using Admin.Repository;

namespace Admin
{
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            UserInfo userInfo = new UserInfo(this.txtName.Text, this.txtUserName.Text, this.txtPhone.Text, this.GetGender(), this.txtPassword.Text, this.GetUserType());
            RegistrationRep regisrep = new RegistrationRep();

            regisrep.AddUser(userInfo);


            /*Console.WriteLine(this.txtUserId.Text);
            Console.WriteLine(this.txtName.Text);
            Console.WriteLine(this.txtUserName.Text);
            Console.WriteLine(this.txtPhone.Text);
            Console.WriteLine(this.GetGender());
            Console.WriteLine(this.txtPassword.Text);
            Console.WriteLine(this.GetUserType());*/
        }

        public string GetGender()
        {
            string value = "";
            bool isChecked = rbMale.Checked;

            if (isChecked)
                value = rbMale.Text;
            else
                value = rbFemale.Text;

            return value;
        }

        public string GetUserType()
        {
            string value = "";
            bool isChecked = rbSale.Checked;

            if (isChecked)
                value = rbSale.Text;
            else
                value = rbAccountant.Text;

            return value;
        }
    }
}
