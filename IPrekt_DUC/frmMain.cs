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

        public Updater _updater = new Updater();

        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            Notify.init(this);
            AddressList.init();
            reloadList();

            if (AddressList.getList().Count < 1)
            {
                this.Show(); Application.DoEvents(); Thread.Sleep(200);
                menuItem6_Click(null, null);
            }

            _updater.start();
        }

        private void notifyIcon_DoubleClick(object sender, EventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            notifyIcon.ShowBalloonTip(500, "We're here !", "Monitoring your IP change.", ToolTipIcon.None);
            
            this.WindowState = FormWindowState.Minimized; Application.DoEvents();
            this.Hide();
            e.Cancel = true;
        }

        private void menuItemAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("IPrekt DUC v0.1 | http://www.iprekt.com", "About");
        }

        private void menuItemQuit_Click(object sender, EventArgs e)
        {
            end();
        }

        private void menuItem6_Click(object sender, EventArgs e)
        {
            frmManager frm = new frmManager(this);
            frm.ShowDialog(this);
            reloadList();
        }

        private void menuItemCreate_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.iprekt.com");
        }
        private void menuItemHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show( String.Join("\r\n", new string[]
            {
                "Help :",
                "",
                "After you have created your new DDNS address at http://www.iprekt.com",
                "",
                "Open the address manager (or Control+M) and input your name and password then click the 'add' button and close the window.",
                "",
                "You may need to change your 'update frequency' in the settings if you wish. Everything else is done automatically for you.",
                "",
                "If you face any issues please contact us at : http://www.iprekt.com/?p=feedback"
            
            }));
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

        private void menuItemSettings_Click(object sender, EventArgs e)
        {
            frmSettings frm = new frmSettings();
            frm.ShowDialog(this);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            menuItemQuit_Click(null, null);
        }

        private void notifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show(); Application.DoEvents(); // Fixes some odd bug in windows 7.
            this.Show();

            this.WindowState = FormWindowState.Normal;
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            notifyIcon_MouseDoubleClick(null, null);
        }

        private void notifyIcon_BalloonTipClicked(object sender, EventArgs e)
        {
            notifyIcon_MouseDoubleClick(null, null);
        }


        public NotifyIcon getNotifyIcon() { return notifyIcon; }

        private void menuItemRefreshNow_Click(object sender, EventArgs e)
        {
            if (_updater != null)
            {
                System.Media.SystemSounds.Beep.Play();
                _updater.updateAllAddresses();
            }
        }

        private void end()
        {
            notifyIcon.Visible = false; Application.DoEvents();
            Environment.Exit(0);
        }

    }
}
