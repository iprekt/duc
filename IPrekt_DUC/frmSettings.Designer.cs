namespace IPrekt_DUC
{
    partial class frmSettings
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSettings));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBoxUseProxy = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtServicesList = new System.Windows.Forms.TextBox();
            this.cmdSave = new System.Windows.Forms.Button();
            this.cmdCancel = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblRefreshRate = new System.Windows.Forms.Label();
            this.trackBarRefreshRate = new System.Windows.Forms.TrackBar();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.checkNotifyUpdateSuccess = new System.Windows.Forms.CheckBox();
            this.checkNotifyUpdateFail = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRefreshRate)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBoxUseProxy);
            this.groupBox1.Location = new System.Drawing.Point(324, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(179, 79);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Network";
            // 
            // checkBoxUseProxy
            // 
            this.checkBoxUseProxy.AutoSize = true;
            this.checkBoxUseProxy.Location = new System.Drawing.Point(19, 34);
            this.checkBoxUseProxy.Name = "checkBoxUseProxy";
            this.checkBoxUseProxy.Size = new System.Drawing.Size(147, 17);
            this.checkBoxUseProxy.TabIndex = 0;
            this.checkBoxUseProxy.Text = "Use system proxy settings";
            this.checkBoxUseProxy.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtServicesList);
            this.groupBox2.Location = new System.Drawing.Point(12, 97);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(246, 138);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Public IP services (URL | IP Regex)";
            // 
            // txtServicesList
            // 
            this.txtServicesList.Location = new System.Drawing.Point(16, 28);
            this.txtServicesList.Multiline = true;
            this.txtServicesList.Name = "txtServicesList";
            this.txtServicesList.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtServicesList.Size = new System.Drawing.Size(211, 94);
            this.txtServicesList.TabIndex = 0;
            // 
            // cmdSave
            // 
            this.cmdSave.Location = new System.Drawing.Point(430, 246);
            this.cmdSave.Name = "cmdSave";
            this.cmdSave.Size = new System.Drawing.Size(73, 27);
            this.cmdSave.TabIndex = 2;
            this.cmdSave.Text = "Save";
            this.cmdSave.UseVisualStyleBackColor = true;
            this.cmdSave.Click += new System.EventHandler(this.cmdSave_Click);
            // 
            // cmdCancel
            // 
            this.cmdCancel.Location = new System.Drawing.Point(349, 246);
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.Size = new System.Drawing.Size(75, 27);
            this.cmdCancel.TabIndex = 3;
            this.cmdCancel.Text = "Cancel";
            this.cmdCancel.UseVisualStyleBackColor = true;
            this.cmdCancel.Click += new System.EventHandler(this.cmdCancel_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblRefreshRate);
            this.groupBox3.Controls.Add(this.trackBarRefreshRate);
            this.groupBox3.Location = new System.Drawing.Point(12, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(306, 79);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Refresh rate";
            // 
            // lblRefreshRate
            // 
            this.lblRefreshRate.AutoSize = true;
            this.lblRefreshRate.Location = new System.Drawing.Point(13, 34);
            this.lblRefreshRate.Name = "lblRefreshRate";
            this.lblRefreshRate.Size = new System.Drawing.Size(32, 13);
            this.lblRefreshRate.TabIndex = 1;
            this.lblRefreshRate.Text = "5 min";
            // 
            // trackBarRefreshRate
            // 
            this.trackBarRefreshRate.Location = new System.Drawing.Point(52, 28);
            this.trackBarRefreshRate.Maximum = 60;
            this.trackBarRefreshRate.Minimum = 1;
            this.trackBarRefreshRate.Name = "trackBarRefreshRate";
            this.trackBarRefreshRate.Size = new System.Drawing.Size(248, 45);
            this.trackBarRefreshRate.TabIndex = 0;
            this.trackBarRefreshRate.Value = 5;
            this.trackBarRefreshRate.Scroll += new System.EventHandler(this.trackBarRefreshRate_Scroll);
            this.trackBarRefreshRate.ValueChanged += new System.EventHandler(this.trackBarRefreshRate_ValueChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.checkNotifyUpdateFail);
            this.groupBox4.Controls.Add(this.checkNotifyUpdateSuccess);
            this.groupBox4.Location = new System.Drawing.Point(264, 97);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(239, 138);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Notifications";
            // 
            // checkNotifyUpdateSuccess
            // 
            this.checkNotifyUpdateSuccess.AutoSize = true;
            this.checkNotifyUpdateSuccess.Location = new System.Drawing.Point(17, 54);
            this.checkNotifyUpdateSuccess.Name = "checkNotifyUpdateSuccess";
            this.checkNotifyUpdateSuccess.Size = new System.Drawing.Size(209, 17);
            this.checkNotifyUpdateSuccess.TabIndex = 0;
            this.checkNotifyUpdateSuccess.Text = "Notify me when an address is updated.";
            this.checkNotifyUpdateSuccess.UseVisualStyleBackColor = true;
            // 
            // checkNotifyUpdateFail
            // 
            this.checkNotifyUpdateFail.AutoSize = true;
            this.checkNotifyUpdateFail.Location = new System.Drawing.Point(17, 77);
            this.checkNotifyUpdateFail.Name = "checkNotifyUpdateFail";
            this.checkNotifyUpdateFail.Size = new System.Drawing.Size(174, 17);
            this.checkNotifyUpdateFail.TabIndex = 1;
            this.checkNotifyUpdateFail.Text = "Notify me when an update fails.";
            this.checkNotifyUpdateFail.UseVisualStyleBackColor = true;
            // 
            // frmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 285);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.cmdCancel);
            this.Controls.Add(this.cmdSave);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmSettings";
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.frmSettings_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRefreshRate)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBoxUseProxy;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtServicesList;
        private System.Windows.Forms.Button cmdSave;
        private System.Windows.Forms.Button cmdCancel;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TrackBar trackBarRefreshRate;
        private System.Windows.Forms.Label lblRefreshRate;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckBox checkNotifyUpdateSuccess;
        private System.Windows.Forms.CheckBox checkNotifyUpdateFail;
    }
}