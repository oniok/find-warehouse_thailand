namespace findwarehouse.views
{
    partial class BannerAdvertisingConfirmForm
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
            this.components = new System.ComponentModel.Container();
            this.dataGridBannerAdvertisingConfirm = new System.Windows.Forms.DataGridView();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.bsBannerAdvertisingConfirm = new System.Windows.Forms.BindingSource(this.components);
            this.lbBannerCode = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridBannerAdvertisingConfirm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsBannerAdvertisingConfirm)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridBannerAdvertisingConfirm
            // 
            this.dataGridBannerAdvertisingConfirm.AllowUserToAddRows = false;
            this.dataGridBannerAdvertisingConfirm.AllowUserToDeleteRows = false;
            this.dataGridBannerAdvertisingConfirm.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridBannerAdvertisingConfirm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridBannerAdvertisingConfirm.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridBannerAdvertisingConfirm.Location = new System.Drawing.Point(0, 53);
            this.dataGridBannerAdvertisingConfirm.MultiSelect = false;
            this.dataGridBannerAdvertisingConfirm.Name = "dataGridBannerAdvertisingConfirm";
            this.dataGridBannerAdvertisingConfirm.ReadOnly = true;
            this.dataGridBannerAdvertisingConfirm.RowHeadersVisible = false;
            this.dataGridBannerAdvertisingConfirm.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridBannerAdvertisingConfirm.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridBannerAdvertisingConfirm.Size = new System.Drawing.Size(978, 461);
            this.dataGridBannerAdvertisingConfirm.TabIndex = 0;
            // 
            // tbSearch
            // 
            this.tbSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSearch.Location = new System.Drawing.Point(121, 12);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(271, 26);
            this.tbSearch.TabIndex = 4;
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(407, 11);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(80, 27);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lbBannerCode
            // 
            this.lbBannerCode.AutoSize = true;
            this.lbBannerCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBannerCode.Location = new System.Drawing.Point(12, 16);
            this.lbBannerCode.Name = "lbBannerCode";
            this.lbBannerCode.Size = new System.Drawing.Size(95, 18);
            this.lbBannerCode.TabIndex = 6;
            this.lbBannerCode.Text = "Banner Code";
            // 
            // BannerAdvertisingConfirmForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 514);
            this.Controls.Add(this.lbBannerCode);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.dataGridBannerAdvertisingConfirm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BannerAdvertisingConfirmForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BannerAdvertisingConfirmForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.BannerAdvertisingConfirmForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridBannerAdvertisingConfirm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsBannerAdvertisingConfirm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridBannerAdvertisingConfirm;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.BindingSource bsBannerAdvertisingConfirm;
        private System.Windows.Forms.Label lbBannerCode;
    }
}