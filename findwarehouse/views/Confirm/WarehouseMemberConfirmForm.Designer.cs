namespace findwarehouse.views
{
    partial class WarehouseMemberConfirmForm
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
            this.dataGridWarehouseMemberConfirm = new System.Windows.Forms.DataGridView();
            this.btnSearch = new System.Windows.Forms.Button();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.bsWarehouseMemberConfirm = new System.Windows.Forms.BindingSource(this.components);
            this.lbMemberName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridWarehouseMemberConfirm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsWarehouseMemberConfirm)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridWarehouseMemberConfirm
            // 
            this.dataGridWarehouseMemberConfirm.AllowUserToAddRows = false;
            this.dataGridWarehouseMemberConfirm.AllowUserToDeleteRows = false;
            this.dataGridWarehouseMemberConfirm.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridWarehouseMemberConfirm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridWarehouseMemberConfirm.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridWarehouseMemberConfirm.Location = new System.Drawing.Point(0, 54);
            this.dataGridWarehouseMemberConfirm.MultiSelect = false;
            this.dataGridWarehouseMemberConfirm.Name = "dataGridWarehouseMemberConfirm";
            this.dataGridWarehouseMemberConfirm.ReadOnly = true;
            this.dataGridWarehouseMemberConfirm.RowHeadersVisible = false;
            this.dataGridWarehouseMemberConfirm.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridWarehouseMemberConfirm.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridWarehouseMemberConfirm.Size = new System.Drawing.Size(978, 459);
            this.dataGridWarehouseMemberConfirm.TabIndex = 0;
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
            // WarehouseMemberConfirmForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 514);
            this.Controls.Add(this.lbMemberName);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.dataGridWarehouseMemberConfirm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "WarehouseMemberConfirmForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WarehouseMemberConfirmForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.WarehouseMemberConfirmForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridWarehouseMemberConfirm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsWarehouseMemberConfirm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridWarehouseMemberConfirm;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.BindingSource bsWarehouseMemberConfirm;
        private System.Windows.Forms.Label lbMemberName;
    }
}