namespace findwarehouse.views.Master.Industrial
{
    partial class AddEditIndustrial
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
            this.cbProvince = new System.Windows.Forms.ComboBox();
            this.txtNameEnglish = new System.Windows.Forms.TextBox();
            this.txtNameThai = new System.Windows.Forms.TextBox();
            this.txtNameJapan = new System.Windows.Forms.TextBox();
            this.txtSearchName = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbProvince
            // 
            this.cbProvince.BackColor = System.Drawing.Color.White;
            this.cbProvince.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProvince.FormattingEnabled = true;
            this.cbProvince.Location = new System.Drawing.Point(127, 12);
            this.cbProvince.Name = "cbProvince";
            this.cbProvince.Size = new System.Drawing.Size(121, 21);
            this.cbProvince.TabIndex = 0;
            // 
            // txtNameEnglish
            // 
            this.txtNameEnglish.Location = new System.Drawing.Point(127, 40);
            this.txtNameEnglish.Name = "txtNameEnglish";
            this.txtNameEnglish.Size = new System.Drawing.Size(121, 20);
            this.txtNameEnglish.TabIndex = 1;
            // 
            // txtNameThai
            // 
            this.txtNameThai.Location = new System.Drawing.Point(127, 67);
            this.txtNameThai.Name = "txtNameThai";
            this.txtNameThai.Size = new System.Drawing.Size(121, 20);
            this.txtNameThai.TabIndex = 2;
            // 
            // txtNameJapan
            // 
            this.txtNameJapan.Location = new System.Drawing.Point(127, 93);
            this.txtNameJapan.Name = "txtNameJapan";
            this.txtNameJapan.Size = new System.Drawing.Size(121, 20);
            this.txtNameJapan.TabIndex = 2;
            // 
            // txtSearchName
            // 
            this.txtSearchName.Location = new System.Drawing.Point(127, 120);
            this.txtSearchName.Name = "txtSearchName";
            this.txtSearchName.Size = new System.Drawing.Size(121, 20);
            this.txtSearchName.TabIndex = 3;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSubmit.Location = new System.Drawing.Point(297, 165);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 4;
            this.btnSubmit.Text = "&Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Location = new System.Drawing.Point(216, 165);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "&Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // AddEditIndustrial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 200);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtSearchName);
            this.Controls.Add(this.txtNameJapan);
            this.Controls.Add(this.txtNameThai);
            this.Controls.Add(this.txtNameEnglish);
            this.Controls.Add(this.cbProvince);
            this.Name = "AddEditIndustrial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddEditIndustrial";
            this.Load += new System.EventHandler(this.AddEditIndustrial_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbProvince;
        private System.Windows.Forms.TextBox txtNameEnglish;
        private System.Windows.Forms.TextBox txtNameThai;
        private System.Windows.Forms.TextBox txtNameJapan;
        private System.Windows.Forms.TextBox txtSearchName;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnClose;
    }
}