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
        public Dashboard()
        {
            InitializeComponent();
        }

        private void Dashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            var result = MessageBox.Show("are you sure?", "caption",
                              MessageBoxButtons.YesNo,
                              MessageBoxIcon.Question);

            e.Cancel = (result == DialogResult.No);
            if(result== DialogResult.Yes)
            {
                Environment.Exit(0);
            }
        }
    }
}
