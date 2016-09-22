namespace findwarehouse.views
{
    partial class AdvertisingCustConfirmForm
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
            this.dataGridAdvertisingCustConfirm = new System.Windows.Forms.DataGridView();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.bsAdvertisingCustConfirm = new System.Windows.Forms.BindingSource(this.components);
            this.lbCustomerName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAdvertisingCustConfirm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsAdvertisingCustConfirm)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridAdvertisingCustConfirm
            // 
            this.dataGridAdvertisingCustConfirm.AllowUserToAddRows = false;
            this.dataGridAdvertisingCustConfirm.AllowUserToDeleteRows = false;
            this.dataGridAdvertisingCustConfirm.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridAdvertisingCustConfirm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridAdvertisingCustConfirm.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridAdvertisingCustConfirm.Location = new System.Drawing.Point(0, 54);
            this.dataGridAdvertisingCustConfirm.MultiSelect = false;
            this.dataGridAdvertisingCustConfirm.Name = "dataGridAdvertisingCustConfirm";
            this.dataGridAdvertisingCustConfirm.ReadOnly = true;
            this.dataGridAdvertisingCustConfirm.RowHeadersVisible = false;
            this.dataGridAdvertisingCustConfirm.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridAdvertisingCustConfirm.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridAdvertisingCustConfirm.Size = new System.Drawing.Size(978, 457);
            this.dataGridAdvertisingCustConfirm.TabIndex = 0;
            // 
            // tbSearch
            // 
            this.tbSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSearch.Location = new System.Drawing.Point(141, 12);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(271, 26);
            this.tbSearch.TabIndex = 6;
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(427, 11);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(80, 27);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lbCustomerName
            // 
            this.lbCustomerName.AutoSize = true;
            this.lbCustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCustomerName.Location = new System.Drawing.Point(10, 16);
            this.lbCustomerName.Name = "lbCustomerName";
            this.lbCustomerName.Size = new System.Drawing.Size(118, 18);
            this.lbCustomerName.TabIndex = 7;
            this.lbCustomerName.Text = "Customer Name";
            // 
            // AdvertisingCustConfirmForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 514);
            this.Controls.Add(this.lbCustomerName);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.dataGridAdvertisingCustConfirm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdvertisingCustConfirmForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdvertisingCustConfirmForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.AdvertisingCustConfirmForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAdvertisingCustConfirm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsAdvertisingCustConfirm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridAdvertisingCustConfirm;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.BindingSource bsAdvertisingCustConfirm;
        private System.Windows.Forms.Label lbCustomerName;
    }
}