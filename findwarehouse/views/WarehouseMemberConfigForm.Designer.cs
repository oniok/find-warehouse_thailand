namespace findwarehouse.views
{
    partial class WarehouseMemberConfigForm
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
            this.dataGridWarehouseMemberConfig = new System.Windows.Forms.DataGridView();
            this.btnSearch = new System.Windows.Forms.Button();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.bsWarehouseMemberConfig = new System.Windows.Forms.BindingSource(this.components);
            this.lbMemberName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridWarehouseMemberConfig)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsWarehouseMemberConfig)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridWarehouseMemberConfig
            // 
            this.dataGridWarehouseMemberConfig.AllowUserToAddRows = false;
            this.dataGridWarehouseMemberConfig.AllowUserToDeleteRows = false;
            this.dataGridWarehouseMemberConfig.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridWarehouseMemberConfig.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridWarehouseMemberConfig.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridWarehouseMemberConfig.Location = new System.Drawing.Point(0, 54);
            this.dataGridWarehouseMemberConfig.MultiSelect = false;
            this.dataGridWarehouseMemberConfig.Name = "dataGridWarehouseMemberConfig";
            this.dataGridWarehouseMemberConfig.ReadOnly = true;
            this.dataGridWarehouseMemberConfig.RowHeadersVisible = false;
            this.dataGridWarehouseMemberConfig.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridWarehouseMemberConfig.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridWarehouseMemberConfig.Size = new System.Drawing.Size(978, 459);
            this.dataGridWarehouseMemberConfig.TabIndex = 0;
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(416, 10);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(80, 27);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // tbSearch
            // 
            this.tbSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSearch.Location = new System.Drawing.Point(130, 11);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(271, 26);
            this.tbSearch.TabIndex = 2;
            this.tbSearch.TextChanged += new System.EventHandler(this.tbSearch_TextChanged);
            // 
            // lbMemberName
            // 
            this.lbMemberName.AutoSize = true;
            this.lbMemberName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMemberName.Location = new System.Drawing.Point(12, 15);
            this.lbMemberName.Name = "lbMemberName";
            this.lbMemberName.Size = new System.Drawing.Size(107, 18);
            this.lbMemberName.TabIndex = 3;
            this.lbMemberName.Text = "Member Name";
            // 
            // WarehouseMemberConfigForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 514);
            this.Controls.Add(this.lbMemberName);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.dataGridWarehouseMemberConfig);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "WarehouseMemberConfigForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WarehouseMemberConfigForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.WarehouseMemberConfigForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridWarehouseMemberConfig)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsWarehouseMemberConfig)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridWarehouseMemberConfig;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.BindingSource bsWarehouseMemberConfig;
        private System.Windows.Forms.Label lbMemberName;
    }
}