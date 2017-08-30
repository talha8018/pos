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
    public partial class Dashboard : Form
    {
        private bool m_isExiting;
        public Dashboard()
        {
            InitializeComponent();
        }

        private void Dashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!m_isExiting)
            {
                //Yes or no message box to exit the application
                DialogResult Response;
                Response = MessageBox.Show("Are you sure you want to Exit?", "Exit", MessageBoxButtons.YesNo);
                if (Response == DialogResult.Yes)
                {
                    m_isExiting = true;
                    Application.Exit();
                }
                else
                {
                    e.Cancel = true;
                }
            }
        }

        private void addUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Users user = new Users();
            user.MdiParent = this;
            user.Dock = DockStyle.Fill;
            user.Show();
        }        
    }
}
