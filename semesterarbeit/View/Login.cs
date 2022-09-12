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
        string us1 = "admin";
        string pw1 = "asdf1234";

        string us2 = "user";
        string pw2 = "asdf1234";

        public Login()
        {
            InitializeComponent();

        }

        private void CmdLogin_Click(object sender, EventArgs e)
        {

           

            if(TxtUsername.Text.ToLower().Equals(us1) && TxtPassword.Text.ToLower().Equals(pw1))
            {
                Dashboard cm1 = new Dashboard(us1);
                this.Hide();
                cm1.Show();
            }
            else if (TxtUsername.Text.ToLower().Equals(us2) && TxtPassword.Text.ToLower().Equals(pw2))
            {
                Dashboard cm1 = new Dashboard(us2);
                this.Hide();
                cm1.Show();
            }
            else
            {
                MessageBox.Show("Username or Password is incorrect!");
            }

            

        }
    }
}
