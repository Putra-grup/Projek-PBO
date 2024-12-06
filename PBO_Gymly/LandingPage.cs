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
    public partial class LandingPage : Form
    {
        public LandingPage()
        {
            InitializeComponent();
        }

        private void buttonAdmin_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Masuk sebagai Admin.");
            LoginAdmin loginAdmin = new LoginAdmin();
            loginAdmin.Show();
            this.Hide();
        }

        private void Button_Customer_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Masuk sebagai Customer.");
            Autentikasi autentikasi = new Autentikasi();
            autentikasi .Show();
            this.Hide();
        }
    }
    
}
