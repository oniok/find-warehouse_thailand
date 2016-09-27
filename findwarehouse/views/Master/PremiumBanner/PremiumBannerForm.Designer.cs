namespace findwarehouse.views.Master.PremiumBanner
{
    partial class PremiumBannerForm
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
            this.dataGridPremiumBanner = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPremiumBanner)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddForm
            // 
            this.btnAddForm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddForm.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnAddForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddForm.ForeColor = System.Drawing.Color.White;
            this.btnAddForm.Location = new System.Drawing.Point(831, 11);
            this.btnAddForm.Name = "btnAddForm";
            this.btnAddForm.Size = new System.Drawing.Size(127, 27);
            this.btnAddForm.TabIndex = 4;
            this.btnAddForm.Text = "Add Banner";
            this.btnAddForm.UseVisualStyleBackColor = false;
            this.btnAddForm.Click += new System.EventHandler(this.btnAddForm_Click);
            // 
            // dataGridPremiumBanner
            // 
            this.dataGridPremiumBanner.AllowUserToAddRows = false;
            this.dataGridPremiumBanner.AllowUserToDeleteRows = false;
            this.dataGridPremiumBanner.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridPremiumBanner.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridPremiumBanner.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridPremiumBanner.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridPremiumBanner.Location = new System.Drawing.Point(4, 44);
            this.dataGridPremiumBanner.MultiSelect = false;
            this.dataGridPremiumBanner.Name = "dataGridPremiumBanner";
            this.dataGridPremiumBanner.ReadOnly = true;
            this.dataGridPremiumBanner.RowHeadersVisible = false;
            this.dataGridPremiumBanner.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridPremiumBanner.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridPremiumBanner.Size = new System.Drawing.Size(954, 453);
            this.dataGridPremiumBanner.TabIndex = 3;
            this.dataGridPremiumBanner.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridPremiumBanner_CellClick);
            // 
            // PremiumBannerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 501);
            this.Controls.Add(this.btnAddForm);
            this.Controls.Add(this.dataGridPremiumBanner);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PremiumBannerForm";
            this.Text = "PremiumBannerForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.PremiumBannerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPremiumBanner)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnAddForm;
        private System.Windows.Forms.DataGridView dataGridPremiumBanner;
        private System.Windows.Forms.DataGridViewButtonColumn Edit;
    }
}