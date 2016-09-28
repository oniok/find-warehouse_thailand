namespace findwarehouse.views.Master.RightBanner
{
    partial class RightBannerForm
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
            this.dataGridRightBanner = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRightBanner)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddForm
            // 
            this.btnAddForm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddForm.Location = new System.Drawing.Point(798, 6);
            this.btnAddForm.Name = "btnAddForm";
            this.btnAddForm.Size = new System.Drawing.Size(127, 25);
            this.btnAddForm.TabIndex = 7;
            this.btnAddForm.Text = "Add Right Banner";
            this.btnAddForm.UseVisualStyleBackColor = true;
            this.btnAddForm.Click += new System.EventHandler(this.btnAddForm_Click);
            // 
            // dataGridRightBanner
            // 
            this.dataGridRightBanner.AllowUserToAddRows = false;
            this.dataGridRightBanner.AllowUserToDeleteRows = false;
            this.dataGridRightBanner.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridRightBanner.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridRightBanner.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridRightBanner.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridRightBanner.Location = new System.Drawing.Point(2, 41);
            this.dataGridRightBanner.MultiSelect = false;
            this.dataGridRightBanner.Name = "dataGridRightBanner";
            this.dataGridRightBanner.ReadOnly = true;
            this.dataGridRightBanner.RowHeadersVisible = false;
            this.dataGridRightBanner.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridRightBanner.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridRightBanner.Size = new System.Drawing.Size(934, 428);
            this.dataGridRightBanner.TabIndex = 6;
            this.dataGridRightBanner.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridRightBanner_CellClick);
            // 
            // RightBannerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 472);
            this.Controls.Add(this.btnAddForm);
            this.Controls.Add(this.dataGridRightBanner);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RightBannerForm";
            this.Text = "RightBannerForm";
            this.Load += new System.EventHandler(this.RightBannerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRightBanner)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnAddForm;
        private System.Windows.Forms.DataGridView dataGridRightBanner;
    }
}