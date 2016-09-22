namespace findwarehouse.views
{
    partial class WarehouseInfoConfirmForm
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
            this.dataGridWarehouseInfoConfirm = new System.Windows.Forms.DataGridView();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.bsWarehouseInfoConfirm = new System.Windows.Forms.BindingSource(this.components);
            this.lbWarehouseName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridWarehouseInfoConfirm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsWarehouseInfoConfirm)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridWarehouseInfoConfirm
            // 
            this.dataGridWarehouseInfoConfirm.AllowUserToAddRows = false;
            this.dataGridWarehouseInfoConfirm.AllowUserToDeleteRows = false;
            this.dataGridWarehouseInfoConfirm.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridWarehouseInfoConfirm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridWarehouseInfoConfirm.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridWarehouseInfoConfirm.Location = new System.Drawing.Point(0, 54);
            this.dataGridWarehouseInfoConfirm.MultiSelect = false;
            this.dataGridWarehouseInfoConfirm.Name = "dataGridWarehouseInfoConfirm";
            this.dataGridWarehouseInfoConfirm.ReadOnly = true;
            this.dataGridWarehouseInfoConfirm.RowHeadersVisible = false;
            this.dataGridWarehouseInfoConfirm.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridWarehouseInfoConfirm.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridWarehouseInfoConfirm.Size = new System.Drawing.Size(978, 460);
            this.dataGridWarehouseInfoConfirm.TabIndex = 0;
            // 
            // tbSearch
            // 
            this.tbSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSearch.Location = new System.Drawing.Point(154, 12);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(271, 26);
            this.tbSearch.TabIndex = 4;
            this.tbSearch.TextChanged += new System.EventHandler(this.tbSearch_TextChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(440, 11);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(80, 27);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lbWarehouseName
            // 
            this.lbWarehouseName.AutoSize = true;
            this.lbWarehouseName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWarehouseName.Location = new System.Drawing.Point(13, 16);
            this.lbWarehouseName.Name = "lbWarehouseName";
            this.lbWarehouseName.Size = new System.Drawing.Size(129, 18);
            this.lbWarehouseName.TabIndex = 5;
            this.lbWarehouseName.Text = "Warehouse Name";
            // 
            // WarehouseInfoConfirmForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 514);
            this.Controls.Add(this.lbWarehouseName);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.dataGridWarehouseInfoConfirm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "WarehouseInfoConfirmForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WarehouseInfoConfirmForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.WarehouseInfoConfirmForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridWarehouseInfoConfirm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsWarehouseInfoConfirm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridWarehouseInfoConfirm;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.BindingSource bsWarehouseInfoConfirm;
        private System.Windows.Forms.Label lbWarehouseName;
    }
}