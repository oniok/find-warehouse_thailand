namespace findwarehouse.views
{
    partial class IndustrialForm
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
            this.dataGridIndustrial = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridIndustrial)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridIndustrial
            // 
            this.dataGridIndustrial.AllowUserToAddRows = false;
            this.dataGridIndustrial.AllowUserToDeleteRows = false;
            this.dataGridIndustrial.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridIndustrial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridIndustrial.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridIndustrial.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridIndustrial.Location = new System.Drawing.Point(0, 0);
            this.dataGridIndustrial.MultiSelect = false;
            this.dataGridIndustrial.Name = "dataGridIndustrial";
            this.dataGridIndustrial.ReadOnly = true;
            this.dataGridIndustrial.RowHeadersVisible = false;
            this.dataGridIndustrial.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridIndustrial.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridIndustrial.Size = new System.Drawing.Size(978, 514);
            this.dataGridIndustrial.TabIndex = 0;
            // 
            // IndustrialForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 514);
            this.Controls.Add(this.dataGridIndustrial);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "IndustrialForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IndustrialForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.IndustrialForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridIndustrial)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridIndustrial;
    }
}