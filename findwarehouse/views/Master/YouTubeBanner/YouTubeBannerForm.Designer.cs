namespace findwarehouse.views.Master.YouTubeBanner
{
    partial class YouTubeBannerForm
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
            this.dataGridYoutubelink = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridYoutubelink)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddForm
            // 
            this.btnAddForm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddForm.Location = new System.Drawing.Point(782, 12);
            this.btnAddForm.Name = "btnAddForm";
            this.btnAddForm.Size = new System.Drawing.Size(149, 37);
            this.btnAddForm.TabIndex = 6;
            this.btnAddForm.Text = "Add Youtubelink";
            this.btnAddForm.UseVisualStyleBackColor = true;
            this.btnAddForm.Click += new System.EventHandler(this.btnAddForm_Click);
            // 
            // dataGridYoutubelink
            // 
            this.dataGridYoutubelink.AllowUserToAddRows = false;
            this.dataGridYoutubelink.AllowUserToDeleteRows = false;
            this.dataGridYoutubelink.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridYoutubelink.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridYoutubelink.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridYoutubelink.Location = new System.Drawing.Point(4, 55);
            this.dataGridYoutubelink.MultiSelect = false;
            this.dataGridYoutubelink.Name = "dataGridYoutubelink";
            this.dataGridYoutubelink.ReadOnly = true;
            this.dataGridYoutubelink.RowHeadersVisible = false;
            this.dataGridYoutubelink.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridYoutubelink.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridYoutubelink.Size = new System.Drawing.Size(954, 438);
            this.dataGridYoutubelink.TabIndex = 5;
            this.dataGridYoutubelink.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridYoutubelink_CellClick);
            // 
            // YouTubeBannerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 496);
            this.Controls.Add(this.btnAddForm);
            this.Controls.Add(this.dataGridYoutubelink);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "YouTubeBannerForm";
            this.Text = "YouTubeBannerForm";
            this.Load += new System.EventHandler(this.YouTubeBannerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridYoutubelink)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnAddForm;
        private System.Windows.Forms.DataGridView dataGridYoutubelink;
    }
}