using semesterarbeit.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace semesterarbeit.View
{


    public partial class Login : Form
    {
        string us1 = "Admin";
        string pw1 = "asdf1234";

        public Login()
        {
            InitializeComponent();

        }

        private void CmdLogin_Click(object sender, EventArgs e)
        {
            if(TxtUsername.Text.Equals(us1) && TxtPassword.Text.Equals(pw1))
            {
                Dashboard cm1 = new Dashboard(us1);
                this.Hide();
                cm1.Show();
            }
            else
            {
                MessageBox.Show("Please enter correct Username or Password");
            }

            

        }
    }
}
