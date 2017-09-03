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
                Response = MessageBox.Show("Are you sure you want to Exit?", "Exit", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
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

        private void Dashboard_Load(object sender, EventArgs e)
        {
            MdiClient ctlMDI;

            // Loop through all of the form's controls looking
            // for the control of type MdiClient.
            foreach (Control ctl in this.Controls)
            {
                try
                {
                    // Attempt to cast the control to type MdiClient.
                    ctlMDI = (MdiClient)ctl;

                    // Set the BackColor of the MdiClient control.
                    ctlMDI.BackColor = this.BackColor;
                }
                catch (InvalidCastException exc)
                {
                    // Catch and ignore the error if casting failed.
                }
            }
        }        
    }
}
