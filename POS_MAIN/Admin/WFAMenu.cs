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
    public partial class WFAMenu : Form
    {
        private string checkCategory;
        public WFAMenu()
        {
            InitializeComponent();
            this.PopulateGridView();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            MenuInfo menuinfo = new MenuInfo(this.txtName.Text, float.Parse(this.txtUnitPrice.Text), checkCategory);
            MenuRepo menurepo = new MenuRepo();
            string operationType = menurepo.AddMenu(menuinfo);
            MessageBox.Show(operationType);
            this.PopulateGridView();

           //Console.WriteLine(this.txtName.Text);
           //Console.WriteLine(this.txtUnitPrice.Text);
           //Console.WriteLine(this.checkCategory);
        }

        private void rbBreakfast_CheckedChanged(object sender, EventArgs e)
        {
            checkCategory = "Breakfast";
        }

        private void rbSetMeals_CheckedChanged(object sender, EventArgs e)
        {
            checkCategory = "Set Meals";
        }

        private void rbSandwich_CheckedChanged(object sender, EventArgs e)
        {
            checkCategory = "Sandwich";
        }

        private void rbBurger_CheckedChanged(object sender, EventArgs e)
        {
            checkCategory = "Burger";
        }

        private void rbPizza_CheckedChanged(object sender, EventArgs e)
        {
            checkCategory = "Pizza";
        }

        private void rbStarter_CheckedChanged(object sender, EventArgs e)
        {
            checkCategory = "Starter";
        }

        private void rbCoffee_CheckedChanged(object sender, EventArgs e)
        {
            checkCategory = "Coffee";
        }

        private void rbDrinks_CheckedChanged(object sender, EventArgs e)
        {
            checkCategory = "Drinks";
        }

        private void rbDessert_CheckedChanged(object sender, EventArgs e)
        {
            checkCategory = "Dessert";
        }

        private void pnlMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PopulateGridView()
        {
            MenuRepo menurepo = new MenuRepo();

            this.dgvMenu.AutoGenerateColumns = false;
            this.dgvMenu.DataSource = menurepo.GetMenu().Tables[0];
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            this.PopulateGridView();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string id = this.dgvMenu.CurrentRow.Cells[0].Value.ToString();
            MenuRepo menuRepo = new MenuRepo();
            string operationType = menuRepo.DeleteMenu(id);
            MessageBox.Show(operationType);
            this.PopulateGridView();
        }

        private void dgvMenu_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.txtMenuId.Text = this.dgvMenu.CurrentRow.Cells[0].Value.ToString();
            this.txtName.Text = this.dgvMenu.CurrentRow.Cells[1].Value.ToString();
            this.txtUnitPrice.Text = this.dgvMenu.CurrentRow.Cells[2].Value.ToString();
            this.checkCategory = this.dgvMenu.CurrentRow.Cells[3].Value.ToString();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            MenuRepo menuRepo = new MenuRepo();
            this.dgvMenu.DataSource = menuRepo.SearchMenuName(this.txtSearchMenuName.Text).Tables[0];
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            AdminPanel ap = new AdminPanel();
            ap.Visible = true;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
