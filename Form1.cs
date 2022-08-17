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
        private void openAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            grpCRUD.Visible = true;
            grpDisplay.Visible = true;
            lblBegin.Visible = false;
        }

        private void closeAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            grpCRUD.Visible = false;
            grpDisplay.Visible = false;
            lblBegin.Visible = true;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion

        private void Form1_Load(object sender, EventArgs e)
        {
            lblSubtitle.SendToBack();
            lblTitle.SendToBack();
        }
    }
}
