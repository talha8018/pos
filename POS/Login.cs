using Business;
using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            Login_Model login = new Login_Model()
            {
                username = txt_username.Text,
                password = txt_password.Text
            };
            int is_auth = Login_Bus.authentication(login);
            if(is_auth==1)
            {
                // User Authentiacated
                this.Hide();
                Dashboard dashboard = new Dashboard();
                dashboard.Show();
            }
            else
            {
                MessageBox.Show("Invalid Credentials!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

   

        private void txt_password_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_login_Click(this, new EventArgs());
                e.Handled = e.SuppressKeyPress = true;
            }
        }

      

       
    }
}
