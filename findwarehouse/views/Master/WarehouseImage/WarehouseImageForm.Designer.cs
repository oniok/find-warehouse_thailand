namespace findwarehouse.views.Master.WarehouseImage
{
    partial class WarehouseImageForm
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
            this.dataGridWarehouseImage = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridWarehouseImage)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddForm
            // 
            this.btnAddForm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddForm.Location = new System.Drawing.Point(813, 8);
            this.btnAddForm.Name = "btnAddForm";
            this.btnAddForm.Size = new System.Drawing.Size(140, 25);
            this.btnAddForm.TabIndex = 4;
            this.btnAddForm.Text = "Add WarehouseImage";
            this.btnAddForm.UseVisualStyleBackColor = true;
            this.btnAddForm.Click += new System.EventHandler(this.btnAddForm_Click);
            // 
            // dataGridWarehouseImage
            // 
            this.dataGridWarehouseImage.AllowUserToAddRows = false;
            this.dataGridWarehouseImage.AllowUserToDeleteRows = false;
            this.dataGridWarehouseImage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridWarehouseImage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridWarehouseImage.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridWarehouseImage.Location = new System.Drawing.Point(12, 39);
            this.dataGridWarehouseImage.MultiSelect = false;
            this.dataGridWarehouseImage.Name = "dataGridWarehouseImage";
            this.dataGridWarehouseImage.ReadOnly = true;
            this.dataGridWarehouseImage.RowHeadersVisible = false;
            this.dataGridWarehouseImage.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridWarehouseImage.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridWarehouseImage.Size = new System.Drawing.Size(954, 461);
            this.dataGridWarehouseImage.TabIndex = 3;
            this.dataGridWarehouseImage.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridWarehouseImage_CellClick);
            this.dataGridWarehouseImage.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridWarehouseImage_CellContentClick);
            // 
            // WarehouseImageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 510);
            this.Controls.Add(this.btnAddForm);
            this.Controls.Add(this.dataGridWarehouseImage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "WarehouseImageForm";
            this.Text = "WarehouseImageForm";
            this.Load += new System.EventHandler(this.WarehouseImageForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridWarehouseImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnAddForm;
        private System.Windows.Forms.DataGridView dataGridWarehouseImage;
    }
}