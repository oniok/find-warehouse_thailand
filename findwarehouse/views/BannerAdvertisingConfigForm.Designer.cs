namespace findwarehouse.views
{
    partial class BannerAdvertisingConfigForm
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
            this.dataGridBannerAdvertisingConfig = new System.Windows.Forms.DataGridView();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.bsBannerAdvertisingConfig = new System.Windows.Forms.BindingSource(this.components);
            this.lbBannerCode = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridBannerAdvertisingConfig)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsBannerAdvertisingConfig)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridBannerAdvertisingConfig
            // 
            this.dataGridBannerAdvertisingConfig.AllowUserToAddRows = false;
            this.dataGridBannerAdvertisingConfig.AllowUserToDeleteRows = false;
            this.dataGridBannerAdvertisingConfig.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridBannerAdvertisingConfig.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridBannerAdvertisingConfig.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridBannerAdvertisingConfig.Location = new System.Drawing.Point(0, 53);
            this.dataGridBannerAdvertisingConfig.MultiSelect = false;
            this.dataGridBannerAdvertisingConfig.Name = "dataGridBannerAdvertisingConfig";
            this.dataGridBannerAdvertisingConfig.ReadOnly = true;
            this.dataGridBannerAdvertisingConfig.RowHeadersVisible = false;
            this.dataGridBannerAdvertisingConfig.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridBannerAdvertisingConfig.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridBannerAdvertisingConfig.Size = new System.Drawing.Size(978, 461);
            this.dataGridBannerAdvertisingConfig.TabIndex = 0;
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
            // BannerAdvertisingConfigForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 514);
            this.Controls.Add(this.lbBannerCode);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.dataGridBannerAdvertisingConfig);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BannerAdvertisingConfigForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BannerAdvertisingConfigForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.BannerAdvertisingConfigForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridBannerAdvertisingConfig)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsBannerAdvertisingConfig)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridBannerAdvertisingConfig;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.BindingSource bsBannerAdvertisingConfig;
        private System.Windows.Forms.Label lbBannerCode;
    }
}