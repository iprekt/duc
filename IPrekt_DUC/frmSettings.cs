using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace IPrekt_DUC
{
    public partial class frmSettings : Form
    {
        public frmSettings()
        {
            InitializeComponent();
        }

        private void trackBarRefreshRate_Scroll(object sender, EventArgs e)
        {
            lblRefreshRate.Text = trackBarRefreshRate.Value + " min";
        }

        private void frmSettings_Load(object sender, EventArgs e)
        {
            txtServicesList.Text = Settings.get("Setting_ipServiceList", "");
            trackBarRefreshRate.Value = Settings.get("Setting_refreshRate", 5);
            checkBoxUseProxy.Checked = Settings.get("Setting_useProxy", false);
        }


        private void cmdSave_Click(object sender, EventArgs e)
        {
            Settings.set("Setting_ipServiceList", txtServicesList.Text);
            Settings.set("Setting_useProxy", checkBoxUseProxy.Checked);
            Settings.set("Setting_refreshRate", trackBarRefreshRate.Value);

            System.Media.SystemSounds.Beep.Play();
            this.Close();
        }

        private void cmdCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void trackBarRefreshRate_ValueChanged(object sender, EventArgs e)
        {
            lblRefreshRate.Text = trackBarRefreshRate.Value + " min";
        }
    }
}
