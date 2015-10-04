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

        }
    }
}
