namespace findwarehouse.views
{
    partial class CategoryBannerConfigForm
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
            this.dataGridCategoryBannerConfig = new System.Windows.Forms.DataGridView();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.bsCategoryBannerConfig = new System.Windows.Forms.BindingSource(this.components);
            this.lbProfileName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCategoryBannerConfig)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCategoryBannerConfig)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridCategoryBannerConfig
            // 
            this.dataGridCategoryBannerConfig.AllowUserToAddRows = false;
            this.dataGridCategoryBannerConfig.AllowUserToDeleteRows = false;
            this.dataGridCategoryBannerConfig.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridCategoryBannerConfig.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridCategoryBannerConfig.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridCategoryBannerConfig.Location = new System.Drawing.Point(0, 54);
            this.dataGridCategoryBannerConfig.MultiSelect = false;
            this.dataGridCategoryBannerConfig.Name = "dataGridCategoryBannerConfig";
            this.dataGridCategoryBannerConfig.ReadOnly = true;
            this.dataGridCategoryBannerConfig.RowHeadersVisible = false;
            this.dataGridCategoryBannerConfig.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridCategoryBannerConfig.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridCategoryBannerConfig.Size = new System.Drawing.Size(978, 460);
            this.dataGridCategoryBannerConfig.TabIndex = 0;
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
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(401, 12);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(80, 27);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
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
            // CategoryBannerConfigForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 514);
            this.Controls.Add(this.lbProfileName);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.dataGridCategoryBannerConfig);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CategoryBannerConfigForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BannerAdvertisingConfigForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.CategoryBannerConfigForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCategoryBannerConfig)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCategoryBannerConfig)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridCategoryBannerConfig;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.BindingSource bsCategoryBannerConfig;
        private System.Windows.Forms.Label lbProfileName;
    }
}