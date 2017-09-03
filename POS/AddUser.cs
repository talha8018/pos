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
    public partial class AddUser : Form
    {
        public AddUser()
        {
            InitializeComponent();
        }

        private void AddUser_Load(object sender, EventArgs e)
        {
            combo_role.SelectedIndex = 0;
        }

        private void btn_add_user_Click(object sender, EventArgs e)
        {
            
            if (String.IsNullOrEmpty(txt_name.Text))
            {
                MessageBox.Show("Name field is required");
                txt_name.Focus();
            }
            else if(String.IsNullOrEmpty(txt_username.Text))
            {
                MessageBox.Show("Username field is required");
                txt_username.Focus();
            }
            else if(String.IsNullOrEmpty(txt_password.Text))
            {
                MessageBox.Show("Password field is required");
                txt_password.Focus();
            }
            else if(String.IsNullOrEmpty(txt_cpassword.Text))
            {
                MessageBox.Show("Confirm Password field is required");
                txt_cpassword.Focus();
            }
            else if(String.IsNullOrEmpty(combo_role.Text))
            {
                MessageBox.Show("Role field is required");
                combo_role.Focus();
            }
            else if(!txt_phone.MaskCompleted)
            {
                MessageBox.Show("Phone field is required");
                txt_phone.Focus();
            }
            else
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
                   bool user_added = AddUser_Bus.addUser(add_user);
                   if(user_added)
                   {
                       ResetAllControls(this);
                       MessageBox.Show("New User added."); 
                       this.Close();
                   }
               }
               else
               {
                   MessageBox.Show("Your password does not match with confirm password");
               }
            }
           
        }

        private void txt_phone_Enter(object sender, EventArgs e)
        {
            this.BeginInvoke((MethodInvoker)delegate()
            {
                txt_phone.Select(0, 0);
            });
        }

        
        private static void ResetAllControls(Control form)
        {
            foreach (Control control in form.Controls)
            {
                if (control is TextBox)
                {
                    TextBox textBox = (TextBox)control;
                    textBox.Text = null;
                }

                if (control is ComboBox)
                {
                    ComboBox comboBox = (ComboBox)control;
                    if (comboBox.Items.Count > 0)
                        comboBox.SelectedIndex = 0;
                }

                if (control is CheckBox)
                {
                    CheckBox checkBox = (CheckBox)control;
                    checkBox.Checked = false;
                }

                if (control is ListBox)
                {
                    ListBox listBox = (ListBox)control;
                    listBox.ClearSelected();
                }
            }
        }
        

        private void combo_role_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
