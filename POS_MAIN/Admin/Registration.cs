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
using DataAccessLayer;

namespace Admin
{
    public partial class Registration : Form
    {
        private string checkedGender;
        private string checkedUserType;

        public Registration()
        {
            InitializeComponent();
            this.PopulateGridView();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            UserInfo userInfo = new UserInfo(this.txtName.Text, this.txtUserName.Text, this.txtPhone.Text, this.checkedGender, this.txtPassword.Text, this.checkedUserType);
            RegistrationRep regisrep = new RegistrationRep();

            string operationType = regisrep.AddUser(userInfo);
            MessageBox.Show(operationType);
            this.PopulateGridView();


            /*Console.WriteLine(this.txtUserId.Text);
            Console.WriteLine(this.txtName.Text);
            Console.WriteLine(this.txtUserName.Text);
            Console.WriteLine(this.txtPhone.Text);
            Console.WriteLine(this.GetGender());
            Console.WriteLine(this.txtPassword.Text);
            Console.WriteLine(this.GetUserType());*/
        }

        /*public string GetGender()
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
        }*/

        private void PopulateGridView()
        {
            //this.Ds = this.Da.ExecuteQuery(sql);

            RegistrationRep regisrep = new RegistrationRep();

            this.dgvRegistration.AutoGenerateColumns = false;
            //this.dgvRegistration.DataSource = this.Ds.Tables[0];
            this.dgvRegistration.DataSource = regisrep.GetUsers().Tables[0];
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            this.PopulateGridView();
        }

        private void rbMale_CheckedChanged(object sender, EventArgs e)
        {
            checkedGender = "Male";
        }

        private void rbFemale_CheckedChanged(object sender, EventArgs e)
        {
            checkedGender = "Female";
        }

        private void chkSale_CheckedChanged(object sender, EventArgs e)
        {
            checkedUserType = "Sale";

            if (chkSale.Checked)
            {
                chkAccountant.Checked = false;
            }
        }

        private void chkAccountant_CheckedChanged(object sender, EventArgs e)
        {
            checkedUserType = "Accountant";

            if (chkAccountant.Checked)
            {
                chkSale.Checked = false;
            }
        }

        /*private void rbSale_CheckedChanged(object sender, EventArgs e)
        {
            checkedUserType = "Sale";
        }

        private void rbAccountant_CheckedChanged(object sender, EventArgs e)
        {
            checkedUserType = "Accountant";
        }*/


    }
}
