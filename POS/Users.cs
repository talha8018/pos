using Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS
{
    public partial class Users : Form
    {
        public Users()
        {
            InitializeComponent();
        }

        private void btn_add_user_Click(object sender, EventArgs e)
        {
            AddUser add_user = new AddUser();
            add_user.ShowDialog();
            getAllUsers();   
        }

        private void Users_Load(object sender, EventArgs e)
        {
            getAllUsers();   
        }
        public  void getAllUsers()
        {
            string connString = ConfigurationManager.ConnectionStrings["pos"].ConnectionString;
            SqlConnection conn = new SqlConnection(connString);
            var select = "SELECT id,name,username,role,phone,created_at FROM admin WHERE secure='0'";

            var dataAdapter = new SqlDataAdapter(select, conn);
            var commandBuilder = new SqlCommandBuilder(dataAdapter);
            var ds = new DataSet();
            dataAdapter.Fill(ds);
            dgv_users.ReadOnly = true;
            dgv_users.DataSource = ds.Tables[0];
            dgv_users.Columns[0].HeaderText = "ID";
            dgv_users.Columns[1].HeaderText = "Name";
            dgv_users.Columns[2].HeaderText = "Username";
            dgv_users.Columns[3].HeaderText = "Role";
            dgv_users.Columns[4].HeaderText = "Phone #";
            dgv_users.Columns[5].HeaderText = "Date Creation";
        }

        private void btn_user_delete_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dgv_users.Rows[dgv_users.CurrentRow.Index].Cells[0].Value);
            DialogResult dialogResult = MessageBox.Show("Are you sure to delete this user?", "Delete", MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                AddUser_Bus.deleteUser(id);
                getAllUsers();
            }           
        }

        private void btn_editUser_Click(object sender, EventArgs e)
        {
            MessageBox.Show(dgv_users.SelectedRows[0].Cells[1].Value.ToString());
            /*EditUser edit_user = new EditUser();
            edit_user.ShowDialog();
            getAllUsers();   */
        }
    }
}
