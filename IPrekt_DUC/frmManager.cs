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
    public partial class frmManager : Form
    {
        private frmMain _frmMain = null;
        private bool _change = false;

        public frmManager(frmMain frmMain)
        {
            _frmMain = frmMain;
            InitializeComponent();
        }

        private void addressList_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != System.Windows.Forms.MouseButtons.Left) return;
            if (addressList.SelectedIndex == -1) return;

            string name = (string)addressList.SelectedItem;

            menuRemove.Text = "Remove ("+name+")";
            menuRemove.Tag = name;
            contextMenuStrip.Show(Cursor.Position);
        }

        private void frmManager_Load(object sender, EventArgs e)
        {
            refreshList();
        }

        private void refreshList()
        {
            addressList.Items.Clear();
            foreach (KeyValuePair<string, string> entry in AddressList.getList())
            {
                addressList.Items.Add(entry.Key);
            }
        }

        private string getTxtAddress() { return txtAddress.Text + txtDomain.Text; }
        private string getTxtPassword() { return txtPassword.Text; }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                this.Enabled = false;
                Application.DoEvents();

                try
                {
                    if (!AddressList.add(getTxtAddress(), getTxtPassword()))
                        MessageBox.Show("Address or password are incorrect.\r\nPlease check your logins and try again.");
                    else
                    {
                        _change = true;

                        txtAddress.Text = "";
                        txtPassword.Text = "";
                        System.Media.SystemSounds.Beep.Play();
                    }
                }
                catch (Exception ex) { MessageBox.Show("There was an error.\r\n" + ex.Message); }

                refreshList();
            }
            finally
            {
                this.Enabled = true;
            }
        }

        private void menuRemove_Click(object sender, EventArgs e)
        {
            string address = menuRemove.Tag.ToString();

            if (MessageBox.Show("Are you sure you want to remove (" + address + ") ? ", "Confirmation", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.No)
                return;

            if (AddressList.remove(address))
                refreshList();
        }

        private void menuRemoveAll_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to remove all addresses ? ", "Confirmation", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.No)
                return;

            AddressList.removeAll();
            refreshList();
        }

        private void txtAddress_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
                btnAdd_Click(null, null);
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnAdd_Click(null, null);
        }

        private void frmManager_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (_change)
            {
                if (_frmMain != null)
                    if (_frmMain._updater != null)
                        _frmMain._updater.updateAllAddresses();
            }
        }
    }
}
