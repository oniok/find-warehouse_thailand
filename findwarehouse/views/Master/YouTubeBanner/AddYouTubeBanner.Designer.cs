namespace findwarehouse.views.Master.YouTubeBanner
{
    partial class AddYouTubeBanner
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
            this.comboCuscode = new System.Windows.Forms.ComboBox();
            this.txtInactive = new System.Windows.Forms.TextBox();
            this.txtActive = new System.Windows.Forms.TextBox();
            this.txtYlink = new System.Windows.Forms.TextBox();
            this.lbInactiveDate = new System.Windows.Forms.Label();
            this.lbActiveDate = new System.Windows.Forms.Label();
            this.lbYoutubeURL = new System.Windows.Forms.Label();
            this.lbCuscode = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboCuscode);
            this.groupBox1.Controls.Add(this.txtInactive);
            this.groupBox1.Controls.Add(this.txtActive);
            this.groupBox1.Controls.Add(this.txtYlink);
            this.groupBox1.Controls.Add(this.lbInactiveDate);
            this.groupBox1.Controls.Add(this.lbActiveDate);
            this.groupBox1.Controls.Add(this.lbYoutubeURL);
            this.groupBox1.Controls.Add(this.lbCuscode);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(482, 324);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Youtube Banner";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // comboCuscode
            // 
            this.comboCuscode.FormattingEnabled = true;
            this.comboCuscode.Location = new System.Drawing.Point(182, 58);
            this.comboCuscode.Name = "comboCuscode";
            this.comboCuscode.Size = new System.Drawing.Size(242, 33);
            this.comboCuscode.TabIndex = 7;
            // 
            // txtInactive
            // 
            this.txtInactive.Location = new System.Drawing.Point(182, 260);
            this.txtInactive.Name = "txtInactive";
            this.txtInactive.Size = new System.Drawing.Size(242, 32);
            this.txtInactive.TabIndex = 6;
            // 
            // txtActive
            // 
            this.txtActive.Location = new System.Drawing.Point(182, 192);
            this.txtActive.Name = "txtActive";
            this.txtActive.Size = new System.Drawing.Size(242, 32);
            this.txtActive.TabIndex = 5;
            // 
            // txtYlink
            // 
            this.txtYlink.Location = new System.Drawing.Point(182, 124);
            this.txtYlink.Name = "txtYlink";
            this.txtYlink.Size = new System.Drawing.Size(242, 32);
            this.txtYlink.TabIndex = 4;
            // 
            // lbInactiveDate
            // 
            this.lbInactiveDate.AutoSize = true;
            this.lbInactiveDate.Location = new System.Drawing.Point(7, 260);
            this.lbInactiveDate.Name = "lbInactiveDate";
            this.lbInactiveDate.Size = new System.Drawing.Size(139, 26);
            this.lbInactiveDate.TabIndex = 3;
            this.lbInactiveDate.Text = "Inactive Date";
            // 
            // lbActiveDate
            // 
            this.lbActiveDate.AutoSize = true;
            this.lbActiveDate.Location = new System.Drawing.Point(7, 190);
            this.lbActiveDate.Name = "lbActiveDate";
            this.lbActiveDate.Size = new System.Drawing.Size(124, 26);
            this.lbActiveDate.TabIndex = 2;
            this.lbActiveDate.Text = "Active Date";
            // 
            // lbYoutubeURL
            // 
            this.lbYoutubeURL.AutoSize = true;
            this.lbYoutubeURL.Location = new System.Drawing.Point(7, 124);
            this.lbYoutubeURL.Name = "lbYoutubeURL";
            this.lbYoutubeURL.Size = new System.Drawing.Size(144, 26);
            this.lbYoutubeURL.TabIndex = 1;
            this.lbYoutubeURL.Text = "Youtube URL";
            // 
            // lbCuscode
            // 
            this.lbCuscode.AutoSize = true;
            this.lbCuscode.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCuscode.Location = new System.Drawing.Point(7, 58);
            this.lbCuscode.Name = "lbCuscode";
            this.lbCuscode.Size = new System.Drawing.Size(142, 24);
            this.lbCuscode.TabIndex = 0;
            this.lbCuscode.Text = "Customer Code";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(141, 352);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(115, 40);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(262, 352);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(115, 40);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // AddYouTubeBanner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 414);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddYouTubeBanner";
            this.Text = "AddYouTubeBanner";
            this.Load += new System.EventHandler(this.AddYouTubeBanner_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboCuscode;
        private System.Windows.Forms.TextBox txtInactive;
        private System.Windows.Forms.TextBox txtActive;
        private System.Windows.Forms.TextBox txtYlink;
        private System.Windows.Forms.Label lbInactiveDate;
        private System.Windows.Forms.Label lbActiveDate;
        private System.Windows.Forms.Label lbYoutubeURL;
        private System.Windows.Forms.Label lbCuscode;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}