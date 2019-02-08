using MasterFinananceUI.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MasterFinananceUI
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void mnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void accountsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAccount frm = new frmAccount();
            frm.TopLevel = false;
            frm.AutoScroll = true;
            frm.FormBorderStyle = FormBorderStyle.None;
            this.pnlMain.Controls.Clear();
            this.pnlMain.Controls.Add(frm);
            frm.Show();
        }

        private void locationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLocations frm = new frmLocations();
            frm.TopLevel = false;
            frm.AutoScroll = true;
            frm.FormBorderStyle = FormBorderStyle.None;
            this.pnlMain.Controls.Clear();
            this.pnlMain.Controls.Add(frm);
            frm.Show();

        }

        private void connectionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConfiguration frm = new frmConfiguration();
            frm.TopLevel = false;
            frm.AutoScroll = true;
            frm.FormBorderStyle = FormBorderStyle.None;
            this.pnlMain.Controls.Clear();
            this.pnlMain.Controls.Add(frm);
            frm.Show();
        }
    }
}
