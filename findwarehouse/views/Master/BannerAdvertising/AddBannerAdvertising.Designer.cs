namespace findwarehouse.views.Master.BannerAdvertising
{
    partial class AddBannerAdvertising
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddBannerAdvertising));
            this.groupBanner = new System.Windows.Forms.GroupBox();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.lbBannerCode = new System.Windows.Forms.Label();
            this.dateInactiveDate = new System.Windows.Forms.DateTimePicker();
            this.dateActiveDate = new System.Windows.Forms.DateTimePicker();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.BannerImage = new System.Windows.Forms.PictureBox();
            this.comboCusCode = new System.Windows.Forms.ComboBox();
            this.lbInactive = new System.Windows.Forms.Label();
            this.lbActiveDate = new System.Windows.Forms.Label();
            this.lbImage = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.imageBrowse = new System.Windows.Forms.OpenFileDialog();
            this.groupBanner.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BannerImage)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBanner
            // 
            this.groupBanner.Controls.Add(this.txtCode);
            this.groupBanner.Controls.Add(this.lbBannerCode);
            this.groupBanner.Controls.Add(this.dateInactiveDate);
            this.groupBanner.Controls.Add(this.dateActiveDate);
            this.groupBanner.Controls.Add(this.btnBrowse);
            this.groupBanner.Controls.Add(this.BannerImage);
            this.groupBanner.Controls.Add(this.comboCusCode);
            this.groupBanner.Controls.Add(this.lbInactive);
            this.groupBanner.Controls.Add(this.lbActiveDate);
            this.groupBanner.Controls.Add(this.lbImage);
            this.groupBanner.Controls.Add(this.label1);
            this.groupBanner.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBanner.Location = new System.Drawing.Point(22, 12);
            this.groupBanner.Name = "groupBanner";
            this.groupBanner.Size = new System.Drawing.Size(543, 429);
            this.groupBanner.TabIndex = 0;
            this.groupBanner.TabStop = false;
            this.groupBanner.Text = "Banner Advertising";
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(165, 47);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(250, 32);
            this.txtCode.TabIndex = 14;
            // 
            // lbBannerCode
            // 
            this.lbBannerCode.AutoSize = true;
            this.lbBannerCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBannerCode.Location = new System.Drawing.Point(6, 47);
            this.lbBannerCode.Name = "lbBannerCode";
            this.lbBannerCode.Size = new System.Drawing.Size(122, 24);
            this.lbBannerCode.TabIndex = 13;
            this.lbBannerCode.Text = "Banner Code";
            // 
            // dateInactiveDate
            // 
            this.dateInactiveDate.CustomFormat = "yyyy-MM-dd";
            this.dateInactiveDate.Font = new System.Drawing.Font("BrowalliaUPC", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateInactiveDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateInactiveDate.Location = new System.Drawing.Point(165, 354);
            this.dateInactiveDate.Name = "dateInactiveDate";
            this.dateInactiveDate.Size = new System.Drawing.Size(250, 34);
            this.dateInactiveDate.TabIndex = 12;
            // 
            // dateActiveDate
            // 
            this.dateActiveDate.CustomFormat = "yyyy-MM-dd";
            this.dateActiveDate.Font = new System.Drawing.Font("BrowalliaUPC", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateActiveDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateActiveDate.Location = new System.Drawing.Point(165, 299);
            this.dateActiveDate.Name = "dateActiveDate";
            this.dateActiveDate.Size = new System.Drawing.Size(250, 34);
            this.dateActiveDate.TabIndex = 11;
            // 
            // btnBrowse
            // 
            this.btnBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBrowse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowse.Location = new System.Drawing.Point(298, 240);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(75, 34);
            this.btnBrowse.TabIndex = 10;
            this.btnBrowse.Text = "browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // BannerImage
            // 
            this.BannerImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BannerImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BannerImage.Image = ((System.Drawing.Image)(resources.GetObject("BannerImage.Image")));
            this.BannerImage.Location = new System.Drawing.Point(165, 160);
            this.BannerImage.Name = "BannerImage";
            this.BannerImage.Size = new System.Drawing.Size(127, 114);
            this.BannerImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BannerImage.TabIndex = 9;
            this.BannerImage.TabStop = false;
            // 
            // comboCusCode
            // 
            this.comboCusCode.FormattingEnabled = true;
            this.comboCusCode.Location = new System.Drawing.Point(165, 103);
            this.comboCusCode.Name = "comboCusCode";
            this.comboCusCode.Size = new System.Drawing.Size(250, 33);
            this.comboCusCode.TabIndex = 8;
            // 
            // lbInactive
            // 
            this.lbInactive.AutoSize = true;
            this.lbInactive.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbInactive.Location = new System.Drawing.Point(6, 361);
            this.lbInactive.Name = "lbInactive";
            this.lbInactive.Size = new System.Drawing.Size(116, 24);
            this.lbInactive.TabIndex = 3;
            this.lbInactive.Text = "Inactive Date";
            // 
            // lbActiveDate
            // 
            this.lbActiveDate.AutoSize = true;
            this.lbActiveDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbActiveDate.Location = new System.Drawing.Point(6, 296);
            this.lbActiveDate.Name = "lbActiveDate";
            this.lbActiveDate.Size = new System.Drawing.Size(104, 24);
            this.lbActiveDate.TabIndex = 2;
            this.lbActiveDate.Text = "Active Date";
            // 
            // lbImage
            // 
            this.lbImage.AutoSize = true;
            this.lbImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbImage.Location = new System.Drawing.Point(6, 160);
            this.lbImage.Name = "lbImage";
            this.lbImage.Size = new System.Drawing.Size(128, 24);
            this.lbImage.TabIndex = 1;
            this.lbImage.Text = "Banner Image";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer Code";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(175, 447);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(113, 36);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(312, 447);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(113, 36);
            this.btnEdit.TabIndex = 2;
            this.btnEdit.Text = "Cancel";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // imageBrowse
            // 
            this.imageBrowse.FileName = "imageBrowse";
            this.imageBrowse.FileOk += new System.ComponentModel.CancelEventHandler(this.imageBrowse_FileOk);
            // 
            // AddBannerAdvertising
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 498);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.groupBanner);
            this.Name = "AddBannerAdvertising";
            this.Text = "AddBannerAdvertising";
            this.Load += new System.EventHandler(this.AddBannerAdvertising_Load);
            this.groupBanner.ResumeLayout(false);
            this.groupBanner.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BannerImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBanner;
        private System.Windows.Forms.Label lbInactive;
        private System.Windows.Forms.Label lbActiveDate;
        private System.Windows.Forms.Label lbImage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.ComboBox comboCusCode;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.PictureBox BannerImage;
        private System.Windows.Forms.OpenFileDialog imageBrowse;
        private System.Windows.Forms.DateTimePicker dateInactiveDate;
        private System.Windows.Forms.DateTimePicker dateActiveDate;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.Label lbBannerCode;
    }
}