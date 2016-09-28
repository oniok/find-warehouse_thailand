namespace findwarehouse.views.Master.BannerAdvertising
{
    partial class BannerAdvertisingForm
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
            this.btnAddForm = new System.Windows.Forms.Button();
            this.dataGridBannerAdvertising = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridBannerAdvertising)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddForm
            // 
            this.btnAddForm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddForm.Location = new System.Drawing.Point(824, 12);
            this.btnAddForm.Name = "btnAddForm";
            this.btnAddForm.Size = new System.Drawing.Size(126, 31);
            this.btnAddForm.TabIndex = 4;
            this.btnAddForm.Text = "Add Banner";
            this.btnAddForm.UseVisualStyleBackColor = true;
            this.btnAddForm.Click += new System.EventHandler(this.btnAddForm_Click);
            // 
            // dataGridBannerAdvertising
            // 
            this.dataGridBannerAdvertising.AllowUserToAddRows = false;
            this.dataGridBannerAdvertising.AllowUserToDeleteRows = false;
            this.dataGridBannerAdvertising.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridBannerAdvertising.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridBannerAdvertising.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridBannerAdvertising.Location = new System.Drawing.Point(4, 51);
            this.dataGridBannerAdvertising.MultiSelect = false;
            this.dataGridBannerAdvertising.Name = "dataGridBannerAdvertising";
            this.dataGridBannerAdvertising.ReadOnly = true;
            this.dataGridBannerAdvertising.RowHeadersVisible = false;
            this.dataGridBannerAdvertising.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridBannerAdvertising.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridBannerAdvertising.Size = new System.Drawing.Size(954, 442);
            this.dataGridBannerAdvertising.TabIndex = 3;
            this.dataGridBannerAdvertising.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridBannerAdvertising_CellClick);
            this.dataGridBannerAdvertising.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridBannerAdvertising_CellContentClick);
            // 
            // BannerAdvertisingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 505);
            this.Controls.Add(this.btnAddForm);
            this.Controls.Add(this.dataGridBannerAdvertising);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BannerAdvertisingForm";
            this.Text = "BannerAdvertisingForm";
            this.Load += new System.EventHandler(this.BannerAdvertisingForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridBannerAdvertising)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnAddForm;
        private System.Windows.Forms.DataGridView dataGridBannerAdvertising;
    }
}