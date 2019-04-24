using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Admin
{
    public partial class AdminPanel : Form
    {
        public AdminPanel()
        {
            InitializeComponent();
        }

        private void btnuser_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Registration regis = new Registration();
            regis.Visible = true;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            WFAMenu wfaMenu = new WFAMenu();
            wfaMenu.Visible = true;
        }
    }
}
