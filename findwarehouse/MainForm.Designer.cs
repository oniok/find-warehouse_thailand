﻿namespace findwarehouse
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.imgBoxLogo = new System.Windows.Forms.PictureBox();
            this.lbTitle = new System.Windows.Forms.Label();
            this.groupMaster = new System.Windows.Forms.GroupBox();
            this.lbCallPremiumBanner = new System.Windows.Forms.Label();
            this.lbCallWarehouseMember = new System.Windows.Forms.Label();
            this.lbCallIndustrial = new System.Windows.Forms.Label();
            this.panelSubForm = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbCallCategoryBannerConfirm = new System.Windows.Forms.Label();
            this.lbCallBannerAdvertisingConfirm = new System.Windows.Forms.Label();
            this.lbCallAdvertisingCustConfirm = new System.Windows.Forms.Label();
            this.lbCallWarehouseInfoConfirm = new System.Windows.Forms.Label();
            this.lbCallWarehouseMemberConfirm = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imgBoxLogo)).BeginInit();
            this.groupMaster.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // imgBoxLogo
            // 
            this.imgBoxLogo.BackColor = System.Drawing.Color.White;
            this.imgBoxLogo.Image = global::findwarehouse.Properties.Resources.logo;
            this.imgBoxLogo.InitialImage = null;
            this.imgBoxLogo.Location = new System.Drawing.Point(20, -21);
            this.imgBoxLogo.Name = "imgBoxLogo";
            this.imgBoxLogo.Size = new System.Drawing.Size(220, 161);
            this.imgBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.imgBoxLogo.TabIndex = 0;
            this.imgBoxLogo.TabStop = false;
            this.imgBoxLogo.WaitOnLoad = true;
            // 
            // lbTitle
            // 
            this.lbTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lbTitle.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbTitle.Location = new System.Drawing.Point(258, 5);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(994, 100);
            this.lbTitle.TabIndex = 0;
            this.lbTitle.Text = "Find Warehouse Management";
            this.lbTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupMaster
            // 
            this.groupMaster.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupMaster.Controls.Add(this.lbCallPremiumBanner);
            this.groupMaster.Controls.Add(this.lbCallWarehouseMember);
            this.groupMaster.Controls.Add(this.lbCallIndustrial);
            this.groupMaster.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupMaster.Location = new System.Drawing.Point(3, 116);
            this.groupMaster.Name = "groupMaster";
            this.groupMaster.Size = new System.Drawing.Size(249, 316);
            this.groupMaster.TabIndex = 2;
            this.groupMaster.TabStop = false;
            this.groupMaster.Text = "Master";
            // 
            // lbCallPremiumBanner
            // 
            this.lbCallPremiumBanner.AutoSize = true;
            this.lbCallPremiumBanner.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbCallPremiumBanner.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lbCallPremiumBanner.Location = new System.Drawing.Point(23, 181);
            this.lbCallPremiumBanner.Name = "lbCallPremiumBanner";
            this.lbCallPremiumBanner.Size = new System.Drawing.Size(133, 18);
            this.lbCallPremiumBanner.TabIndex = 1;
            this.lbCallPremiumBanner.Text = "Premium Banner";
            this.lbCallPremiumBanner.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbCallPremiumBanner.Click += new System.EventHandler(this.lbCallPremiumBanner_Click);
            // 
            // lbCallWarehouseMember
            // 
            this.lbCallWarehouseMember.AutoSize = true;
            this.lbCallWarehouseMember.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbCallWarehouseMember.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lbCallWarehouseMember.Location = new System.Drawing.Point(23, 69);
            this.lbCallWarehouseMember.Name = "lbCallWarehouseMember";
            this.lbCallWarehouseMember.Size = new System.Drawing.Size(160, 18);
            this.lbCallWarehouseMember.TabIndex = 0;
            this.lbCallWarehouseMember.Text = "Warehouse Member";
            this.lbCallWarehouseMember.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbCallWarehouseMember.Click += new System.EventHandler(this.lbCallWarehouseMember_Click);
            // 
            // lbCallIndustrial
            // 
            this.lbCallIndustrial.AutoSize = true;
            this.lbCallIndustrial.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbCallIndustrial.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lbCallIndustrial.Location = new System.Drawing.Point(23, 35);
            this.lbCallIndustrial.Name = "lbCallIndustrial";
            this.lbCallIndustrial.Size = new System.Drawing.Size(76, 18);
            this.lbCallIndustrial.TabIndex = 0;
            this.lbCallIndustrial.Text = "Industrial";
            this.lbCallIndustrial.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbCallIndustrial.Click += new System.EventHandler(this.lbCallIndustrial_Click);
            // 
            // panelSubForm
            // 
            this.panelSubForm.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelSubForm.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelSubForm.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panelSubForm.Location = new System.Drawing.Point(258, 116);
            this.panelSubForm.Name = "panelSubForm";
            this.panelSubForm.Size = new System.Drawing.Size(994, 553);
            this.panelSubForm.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.lbCallCategoryBannerConfirm);
            this.groupBox1.Controls.Add(this.lbCallBannerAdvertisingConfirm);
            this.groupBox1.Controls.Add(this.lbCallAdvertisingCustConfirm);
            this.groupBox1.Controls.Add(this.lbCallWarehouseInfoConfirm);
            this.groupBox1.Controls.Add(this.lbCallWarehouseMemberConfirm);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(3, 438);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(249, 231);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Confirm. of the display period";
            // 
            // lbCallCategoryBannerConfirm
            // 
            this.lbCallCategoryBannerConfirm.AutoSize = true;
            this.lbCallCategoryBannerConfirm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbCallCategoryBannerConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lbCallCategoryBannerConfirm.Location = new System.Drawing.Point(23, 186);
            this.lbCallCategoryBannerConfirm.Name = "lbCallCategoryBannerConfirm";
            this.lbCallCategoryBannerConfirm.Size = new System.Drawing.Size(134, 18);
            this.lbCallCategoryBannerConfirm.TabIndex = 4;
            this.lbCallCategoryBannerConfirm.Text = "Category Banner";
            this.lbCallCategoryBannerConfirm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbCallCategoryBannerConfirm.Click += new System.EventHandler(this.lbCallCategoryBannerConfirm_Click);
            // 
            // lbCallBannerAdvertisingConfirm
            // 
            this.lbCallBannerAdvertisingConfirm.AutoSize = true;
            this.lbCallBannerAdvertisingConfirm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbCallBannerAdvertisingConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lbCallBannerAdvertisingConfirm.Location = new System.Drawing.Point(23, 150);
            this.lbCallBannerAdvertisingConfirm.Name = "lbCallBannerAdvertisingConfirm";
            this.lbCallBannerAdvertisingConfirm.Size = new System.Drawing.Size(148, 18);
            this.lbCallBannerAdvertisingConfirm.TabIndex = 3;
            this.lbCallBannerAdvertisingConfirm.Text = "Banner Advertising";
            this.lbCallBannerAdvertisingConfirm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbCallBannerAdvertisingConfirm.Click += new System.EventHandler(this.lbCallBannerAdvertisingConfirm_Click);
            // 
            // lbCallAdvertisingCustConfirm
            // 
            this.lbCallAdvertisingCustConfirm.AutoSize = true;
            this.lbCallAdvertisingCustConfirm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbCallAdvertisingCustConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lbCallAdvertisingCustConfirm.Location = new System.Drawing.Point(23, 112);
            this.lbCallAdvertisingCustConfirm.Name = "lbCallAdvertisingCustConfirm";
            this.lbCallAdvertisingCustConfirm.Size = new System.Drawing.Size(159, 18);
            this.lbCallAdvertisingCustConfirm.TabIndex = 2;
            this.lbCallAdvertisingCustConfirm.Text = "Advertising Custmer";
            this.lbCallAdvertisingCustConfirm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbCallAdvertisingCustConfirm.Click += new System.EventHandler(this.lbCallAdvertisingCustConfirm_Click);
            // 
            // lbCallWarehouseInfoConfirm
            // 
            this.lbCallWarehouseInfoConfirm.AutoSize = true;
            this.lbCallWarehouseInfoConfirm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbCallWarehouseInfoConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lbCallWarehouseInfoConfirm.Location = new System.Drawing.Point(23, 75);
            this.lbCallWarehouseInfoConfirm.Name = "lbCallWarehouseInfoConfirm";
            this.lbCallWarehouseInfoConfirm.Size = new System.Drawing.Size(132, 18);
            this.lbCallWarehouseInfoConfirm.TabIndex = 1;
            this.lbCallWarehouseInfoConfirm.Text = "Warehouse Info.";
            this.lbCallWarehouseInfoConfirm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbCallWarehouseInfoConfirm.Click += new System.EventHandler(this.lbCallWarehouseInfoConfirm_Click);
            // 
            // lbCallWarehouseMemberConfirm
            // 
            this.lbCallWarehouseMemberConfirm.AutoSize = true;
            this.lbCallWarehouseMemberConfirm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbCallWarehouseMemberConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lbCallWarehouseMemberConfirm.Location = new System.Drawing.Point(23, 36);
            this.lbCallWarehouseMemberConfirm.Name = "lbCallWarehouseMemberConfirm";
            this.lbCallWarehouseMemberConfirm.Size = new System.Drawing.Size(160, 18);
            this.lbCallWarehouseMemberConfirm.TabIndex = 0;
            this.lbCallWarehouseMemberConfirm.Text = "Warehouse Member";
            this.lbCallWarehouseMemberConfirm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbCallWarehouseMemberConfirm.Click += new System.EventHandler(this.lbCallWarehouseMemberConfirm_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panelSubForm);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.groupMaster);
            this.Controls.Add(this.imgBoxLogo);
            this.MinimumSize = new System.Drawing.Size(1280, 720);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Find Warehouse Management";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgBoxLogo)).EndInit();
            this.groupMaster.ResumeLayout(false);
            this.groupMaster.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox imgBoxLogo;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.GroupBox groupMaster;
        private System.Windows.Forms.Label lbCallWarehouseMember;
        private System.Windows.Forms.Label lbCallIndustrial;
        private System.Windows.Forms.Panel panelSubForm;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbCallCategoryBannerConfirm;
        private System.Windows.Forms.Label lbCallBannerAdvertisingConfirm;
        private System.Windows.Forms.Label lbCallAdvertisingCustConfirm;
        private System.Windows.Forms.Label lbCallWarehouseInfoConfirm;
        private System.Windows.Forms.Label lbCallWarehouseMemberConfirm;
        private System.Windows.Forms.Label lbCallPremiumBanner;
    }
}