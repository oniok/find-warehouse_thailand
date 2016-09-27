namespace findwarehouse.views
{
    partial class CategoryBannerConfirmForm
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
            this.dataGridCategoryBannerConfirm = new System.Windows.Forms.DataGridView();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.bsCategoryBannerConfirm = new System.Windows.Forms.BindingSource(this.components);
            this.lbProfileName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCategoryBannerConfirm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCategoryBannerConfirm)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridCategoryBannerConfirm
            // 
            this.dataGridCategoryBannerConfirm.AllowUserToAddRows = false;
            this.dataGridCategoryBannerConfirm.AllowUserToDeleteRows = false;
            this.dataGridCategoryBannerConfirm.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridCategoryBannerConfirm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridCategoryBannerConfirm.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridCategoryBannerConfirm.Location = new System.Drawing.Point(0, 54);
            this.dataGridCategoryBannerConfirm.MultiSelect = false;
            this.dataGridCategoryBannerConfirm.Name = "dataGridCategoryBannerConfirm";
            this.dataGridCategoryBannerConfirm.ReadOnly = true;
            this.dataGridCategoryBannerConfirm.RowHeadersVisible = false;
            this.dataGridCategoryBannerConfirm.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridCategoryBannerConfirm.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridCategoryBannerConfirm.Size = new System.Drawing.Size(978, 460);
            this.dataGridCategoryBannerConfirm.TabIndex = 0;
            // 
            // tbSearch
            // 
            this.tbSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSearch.Location = new System.Drawing.Point(115, 13);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(271, 26);
            this.tbSearch.TabIndex = 6;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(401, 12);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(80, 27);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lbProfileName
            // 
            this.lbProfileName.AutoSize = true;
            this.lbProfileName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbProfileName.Location = new System.Drawing.Point(11, 17);
            this.lbProfileName.Name = "lbProfileName";
            this.lbProfileName.Size = new System.Drawing.Size(94, 18);
            this.lbProfileName.TabIndex = 8;
            this.lbProfileName.Text = "Profile Name";
            // 
            // CategoryBannerConfirmForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 514);
            this.Controls.Add(this.lbProfileName);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.dataGridCategoryBannerConfirm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CategoryBannerConfirmForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BannerAdvertisingConfirmForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.CategoryBannerConfirmForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCategoryBannerConfirm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCategoryBannerConfirm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridCategoryBannerConfirm;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.BindingSource bsCategoryBannerConfirm;
        private System.Windows.Forms.Label lbProfileName;
    }
}