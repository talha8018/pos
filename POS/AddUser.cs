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
    public partial class AddUser : Form
    {
        public AddUser()
        {
            InitializeComponent();
        }

        private void AddUser_Load(object sender, EventArgs e)
        {

        }

        private void btn_add_user_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txt_name.Text) && !String.IsNullOrEmpty(txt_username.Text) && !String.IsNullOrEmpty(txt_password.Text) && !String.IsNullOrEmpty(txt_cpassword.Text) && !String.IsNullOrEmpty(combo_role.Text) && !String.IsNullOrEmpty(txt_phone.Text))
            {
               if(txt_password.Text==txt_cpassword.Text)
               {
                   AddUser_Model add_user = new AddUser_Model()
                   {
                       name = txt_name.Text,
                       username = txt_username.Text,
                       password = txt_password.Text,
                       phone = txt_phone.Text,
                       role = combo_role.Text,
                   };
               }
               else
               {
                   MessageBox.Show("Your password does not match with confirm password");
               }
            }
            else
            {
                MessageBox.Show("Please validate all the fields");
            }
           
        }

        private void txt_phone_Enter(object sender, EventArgs e)
        {
            this.BeginInvoke((MethodInvoker)delegate()
            {
                txt_phone.Select(0, 0);
            });
        }
    }
}
