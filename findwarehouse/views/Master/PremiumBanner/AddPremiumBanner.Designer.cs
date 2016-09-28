namespace findwarehouse.views.Master.PremiumBanner
{
    partial class AddPremiumBanner
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtpInactiveDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpActivedate = new System.Windows.Forms.DateTimePicker();
            this.lbActiveDate = new System.Windows.Forms.Label();
            this.lbImagePath = new System.Windows.Forms.Label();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.txtBannerURL = new System.Windows.Forms.TextBox();
            this.lbAdvertisingImage = new System.Windows.Forms.Label();
            this.lbMemcode = new System.Windows.Forms.Label();
            this.comboMemCode = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.imgBrowse = new System.Windows.Forms.OpenFileDialog();
            this.imgPreview = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgPreview)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtpInactiveDate);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dtpActivedate);
            this.groupBox1.Controls.Add(this.lbActiveDate);
            this.groupBox1.Controls.Add(this.lbImagePath);
            this.groupBox1.Controls.Add(this.btnBrowse);
            this.groupBox1.Controls.Add(this.txtBannerURL);
            this.groupBox1.Controls.Add(this.imgPreview);
            this.groupBox1.Controls.Add(this.lbAdvertisingImage);
            this.groupBox1.Controls.Add(this.lbMemcode);
            this.groupBox1.Controls.Add(this.comboMemCode);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(592, 540);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Premium Banner";
            // 
            // dtpInactiveDate
            // 
            this.dtpInactiveDate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpInactiveDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpInactiveDate.Location = new System.Drawing.Point(218, 473);
            this.dtpInactiveDate.Name = "dtpInactiveDate";
            this.dtpInactiveDate.Size = new System.Drawing.Size(218, 26);
            this.dtpInactiveDate.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(52, 471);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 24);
            this.label1.TabIndex = 9;
            this.label1.Text = "Inactive Date";
            // 
            // dtpActivedate
            // 
            this.dtpActivedate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpActivedate.CustomFormat = "";
            this.dtpActivedate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpActivedate.Location = new System.Drawing.Point(218, 421);
            this.dtpActivedate.Name = "dtpActivedate";
            this.dtpActivedate.Size = new System.Drawing.Size(218, 26);
            this.dtpActivedate.TabIndex = 8;
            // 
            // lbActiveDate
            // 
            this.lbActiveDate.AutoSize = true;
            this.lbActiveDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbActiveDate.Location = new System.Drawing.Point(52, 419);
            this.lbActiveDate.Name = "lbActiveDate";
            this.lbActiveDate.Size = new System.Drawing.Size(104, 24);
            this.lbActiveDate.TabIndex = 7;
            this.lbActiveDate.Text = "Active Date";
            // 
            // lbImagePath
            // 
            this.lbImagePath.AutoSize = true;
            this.lbImagePath.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbImagePath.Location = new System.Drawing.Point(52, 350);
            this.lbImagePath.Name = "lbImagePath";
            this.lbImagePath.Size = new System.Drawing.Size(112, 24);
            this.lbImagePath.TabIndex = 6;
            this.lbImagePath.Text = "Banner URL";
            // 
            // btnBrowse
            // 
            this.btnBrowse.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrowse.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowse.ForeColor = System.Drawing.Color.White;
            this.btnBrowse.Location = new System.Drawing.Point(426, 58);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(96, 32);
            this.btnBrowse.TabIndex = 5;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = false;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // txtBannerURL
            // 
            this.txtBannerURL.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBannerURL.Location = new System.Drawing.Point(218, 350);
            this.txtBannerURL.Name = "txtBannerURL";
            this.txtBannerURL.Size = new System.Drawing.Size(304, 29);
            this.txtBannerURL.TabIndex = 4;
            // 
            // lbAdvertisingImage
            // 
            this.lbAdvertisingImage.AutoSize = true;
            this.lbAdvertisingImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAdvertisingImage.Location = new System.Drawing.Point(51, 104);
            this.lbAdvertisingImage.Name = "lbAdvertisingImage";
            this.lbAdvertisingImage.Size = new System.Drawing.Size(160, 24);
            this.lbAdvertisingImage.TabIndex = 2;
            this.lbAdvertisingImage.Text = "Advertising Image";
            // 
            // lbMemcode
            // 
            this.lbMemcode.AutoSize = true;
            this.lbMemcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMemcode.Location = new System.Drawing.Point(50, 58);
            this.lbMemcode.Name = "lbMemcode";
            this.lbMemcode.Size = new System.Drawing.Size(132, 24);
            this.lbMemcode.TabIndex = 1;
            this.lbMemcode.Text = "Member Code";
            // 
            // comboMemCode
            // 
            this.comboMemCode.BackColor = System.Drawing.SystemColors.Window;
            this.comboMemCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboMemCode.FormattingEnabled = true;
            this.comboMemCode.Location = new System.Drawing.Point(218, 58);
            this.comboMemCode.Name = "comboMemCode";
            this.comboMemCode.Size = new System.Drawing.Size(196, 32);
            this.comboMemCode.TabIndex = 0;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.SeaGreen;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(174, 566);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(116, 53);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.DarkRed;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(332, 566);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(116, 53);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Cancel";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // imgBrowse
            // 
            this.imgBrowse.FileName = "imgBrowse";
            this.imgBrowse.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png, *.bmp) | *.jpg; *.jpeg; *.jpe; " +
    "*.jfif; *.png; *.bmp";
            this.imgBrowse.FileOk += new System.ComponentModel.CancelEventHandler(this.imgBrowse_FileOk);
            // 
            // imgPreview
            // 
            this.imgPreview.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.imgPreview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imgPreview.Image = global::findwarehouse.Properties.Resources.No_Cover;
            this.imgPreview.ImageLocation = "";
            this.imgPreview.InitialImage = null;
            this.imgPreview.Location = new System.Drawing.Point(218, 104);
            this.imgPreview.Name = "imgPreview";
            this.imgPreview.Size = new System.Drawing.Size(304, 231);
            this.imgPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgPreview.TabIndex = 3;
            this.imgPreview.TabStop = false;
            // 
            // AddPremiumBanner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 631);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "AddPremiumBanner";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AddPremiumBanner";
            this.Load += new System.EventHandler(this.AddPremiumBanner_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgPreview)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtpInactiveDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpActivedate;
        private System.Windows.Forms.Label lbActiveDate;
        private System.Windows.Forms.Label lbImagePath;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.TextBox txtBannerURL;
        private System.Windows.Forms.PictureBox imgPreview;
        private System.Windows.Forms.Label lbAdvertisingImage;
        private System.Windows.Forms.Label lbMemcode;
        private System.Windows.Forms.ComboBox comboMemCode;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.OpenFileDialog imgBrowse;
    }
}