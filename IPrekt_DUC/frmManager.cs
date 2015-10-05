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
        public frmManager()
        {
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                this.Enabled = false;
                Application.DoEvents();

                if (!AddressList.add(txtAddress.Text, txtPassword.Text))
                    MessageBox.Show("Unable to connect, or address and password are incorrect.\r\nPlease check your settings and try again.");
                else
                {
                    txtAddress.Text = "";
                    txtPassword.Text = "";
                    System.Media.SystemSounds.Beep.Play();
                }

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
    }
}
