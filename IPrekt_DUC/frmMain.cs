using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace IPrekt_DUC
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            AddressList.init();
            reloadList();

            if (AddressList.getList().Count < 1)
            {
                this.Show(); Application.DoEvents(); Thread.Sleep(200);
                menuItem6_Click(null, null);
            }
        }

        private void notifyIcon_DoubleClick(object sender, EventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            notifyIcon.ShowBalloonTip(500, "We're here !", "Monitoring your IP change.", ToolTipIcon.None);
            
            this.Hide();
            e.Cancel = true;
        }

        private void menuItemAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("IPrekt DUC v0.1 | http://www.iprekt.com", "About");
        }

        private void menuItemQuit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void menuItem6_Click(object sender, EventArgs e)
        {
            frmManager frm = new frmManager();
            frm.ShowDialog(this);
            reloadList();
        }

        private void menuItemCreate_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.iprekt.com");
        }


        private void reloadList()
        {
            activeList.Items.Clear();

            if (AddressList.getList().Count < 1)
            {
                activeList.Items.Add("Please use the menus above");
                activeList.Items.Add("to add or create an address.");
            }
            else
            {
                foreach (KeyValuePair<string, string> e in AddressList.getList())
                    activeList.Items.Add(e.Key);
            }
        }
    }
}
