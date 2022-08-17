using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp_CarDatabaseManagement
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region MenuItems
        private void viewInventoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            grpDisplay.Visible = true;
        }

        private void closeInventoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            grpDisplay.Visible = false;
        }

        private void makeChangesToInventoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            grpCRUD.Visible = true;
        }

        private void closeInventoryToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            grpCRUD.Visible = false;
        }

        private void openAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            grpCRUD.Visible = true;
            grpDisplay.Visible = true;
        }

        private void closeAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            grpCRUD.Visible = false;
            grpDisplay.Visible = false;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion    

    }
}
