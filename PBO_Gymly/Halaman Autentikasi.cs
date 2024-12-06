using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBO_Gymly
{
    public partial class Autentikasi : Form
    {
        public Autentikasi()
        {
            InitializeComponent();
        }

        private void Label_Username_Click(object sender, EventArgs e)
        {

        }

        private void Button_Customer_Click(object sender, EventArgs e)
        {
           Register register = new Register();
           register.Show();
           this.Hide();
        }

        private void Button_Login_Click(object sender, EventArgs e)
        {
            LoginCustomer loginCustomer = new LoginCustomer();
            loginCustomer.Show();
            this.Hide();
        }
    }
}
