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
            this.btnAddForm = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridIndustrial)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridIndustrial
            // 
            this.dataGridIndustrial.AllowUserToAddRows = false;
            this.dataGridIndustrial.AllowUserToDeleteRows = false;
            this.dataGridIndustrial.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridIndustrial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridIndustrial.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridIndustrial.Location = new System.Drawing.Point(12, 41);
            this.dataGridIndustrial.MultiSelect = false;
            this.dataGridIndustrial.Name = "dataGridIndustrial";
            this.dataGridIndustrial.ReadOnly = true;
            this.dataGridIndustrial.RowHeadersVisible = false;
            this.dataGridIndustrial.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridIndustrial.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridIndustrial.Size = new System.Drawing.Size(954, 461);
            this.dataGridIndustrial.TabIndex = 0;
            this.dataGridIndustrial.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridIndustrial_CellClick);
            // 
            // btnAddForm
            // 
            this.btnAddForm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddForm.Location = new System.Drawing.Point(866, 12);
            this.btnAddForm.Name = "btnAddForm";
            this.btnAddForm.Size = new System.Drawing.Size(100, 25);
            this.btnAddForm.TabIndex = 1;
            this.btnAddForm.Text = "Add Industrial";
            this.btnAddForm.UseVisualStyleBackColor = true;
            this.btnAddForm.Click += new System.EventHandler(this.btnAddForm_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEdit.Location = new System.Drawing.Point(760, 12);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(100, 25);
            this.btnEdit.TabIndex = 2;
            this.btnEdit.Text = "Edit Industrial";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // IndustrialForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 514);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAddForm);
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
        private System.Windows.Forms.Button btnAddForm;
        private System.Windows.Forms.Button btnEdit;
    }
}