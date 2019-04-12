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
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }

        private void button_login_Click(object sender, EventArgs e)
        {
            SignUpLayer signUpLayer = new SignUpLayer();
            //string user_id, string name, string phone, string gender, string passsword, string user_type
            signUpLayer.RegisterUser("Emp-010", "Hassan", "01899393893", "MALE", "12345", "Cashier");
        }
    }
}
