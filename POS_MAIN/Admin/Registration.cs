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
            UserInfo userinfo = new UserInfo(this.txtName.Text, this.txtUserName.Text, this.txtPhone.Text, this.checkedGender, this.txtPassword.Text, this.checkedUserType);

            if (this.txtPassword.Text.Length <= 3)
            {
                MessageBox.Show("Minimum Password Length is 4");
            }

            else
            {
                RegistrationRep regisrep = new RegistrationRep();

                string operationType = regisrep.AddUser(userinfo);
                MessageBox.Show(operationType);
                this.PopulateGridView();
            }
            


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

        private void dgvRegistration_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.txtUserId.Text = this.dgvRegistration.CurrentRow.Cells["user_id"].Value.ToString();
            this.txtName.Text = this.dgvRegistration.CurrentRow.Cells["name"].Value.ToString();
            this.txtUserName.Text = this.dgvRegistration.CurrentRow.Cells["user_name"].Value.ToString();
            this.txtPhone.Text = this.dgvRegistration.CurrentRow.Cells["phone"].Value.ToString();
            this.checkedGender = this.dgvRegistration.CurrentRow.Cells["gender"].Value.ToString();
            this.txtPassword.Text = this.dgvRegistration.CurrentRow.Cells["password"].Value.ToString();
            this.checkedUserType = this.dgvRegistration.CurrentRow.Cells["user_type"].Value.ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //string userId = this.dgvRegistration.CurrentRow.Cells["user_id"].Value.ToString();
            //string name = this.dgvRegistration.CurrentRow.Cells["name"].Value.ToString();
            //this.txtUserName.Text = this.dgvRegistration.CurrentRow.Cells["user_name"].Value.ToString();
            //string phone = this.dgvRegistration.CurrentRow.Cells["phone"].Value.ToString();
            //            this.checkedGender = this.dgvRegistration.CurrentRow.Cells["gender"].Value.ToString();
            //string password = this.dgvRegistration.CurrentRow.Cells["password"].Value.ToString();
            //this.checkedUserType = this.dgvRegistration.CurrentRow.Cells["user_type"].Value.ToString();


            string userName = this.dgvRegistration.CurrentRow.Cells["user_name"].Value.ToString();
            RegistrationRep regisrepo = new RegistrationRep();
            string operationType = regisrepo.DeleteUser(userName);
            MessageBox.Show(operationType);
            this.PopulateGridView();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //string userType = this.dgvRegistration.CurrentRow.Cells["user_type"].Value.ToString();
            RegistrationRep regisRep = new RegistrationRep();
            //instead of ds, repository layer method is accessed, passing the text field
            this.dgvRegistration.DataSource = regisRep.SearchUserType(this.txtSearchUserType.Text).Tables[0];
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            AdminPanel ap = new AdminPanel();
            ap.Visible = true;
        }

        private void txtPhone_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
