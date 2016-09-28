namespace findwarehouse.views.Master.WarehouseInformation
{
    partial class WarehouseInformationForm
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
            this.dataGridWarehouseInfomation = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridWarehouseInfomation)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddForm
            // 
            this.btnAddForm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddForm.Location = new System.Drawing.Point(818, 8);
            this.btnAddForm.Name = "btnAddForm";
            this.btnAddForm.Size = new System.Drawing.Size(151, 25);
            this.btnAddForm.TabIndex = 7;
            this.btnAddForm.Text = "Add WarehouseInfomation";
            this.btnAddForm.UseVisualStyleBackColor = true;
            this.btnAddForm.Click += new System.EventHandler(this.btnAddForm_Click);
            // 
            // dataGridWarehouseInfomation
            // 
            this.dataGridWarehouseInfomation.AllowUserToAddRows = false;
            this.dataGridWarehouseInfomation.AllowUserToDeleteRows = false;
            this.dataGridWarehouseInfomation.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridWarehouseInfomation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridWarehouseInfomation.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridWarehouseInfomation.Location = new System.Drawing.Point(15, 39);
            this.dataGridWarehouseInfomation.MultiSelect = false;
            this.dataGridWarehouseInfomation.Name = "dataGridWarehouseInfomation";
            this.dataGridWarehouseInfomation.ReadOnly = true;
            this.dataGridWarehouseInfomation.RowHeadersVisible = false;
            this.dataGridWarehouseInfomation.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridWarehouseInfomation.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridWarehouseInfomation.Size = new System.Drawing.Size(968, 452);
            this.dataGridWarehouseInfomation.TabIndex = 6;
            this.dataGridWarehouseInfomation.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridWarehouseInfomation_CellClick);
            // 
            // WarehouseInformationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(995, 503);
            this.Controls.Add(this.btnAddForm);
            this.Controls.Add(this.dataGridWarehouseInfomation);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "WarehouseInformationForm";
            this.Text = "WarehouseInformationForm";
            this.Load += new System.EventHandler(this.WarehouseInformationForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridWarehouseInfomation)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnAddForm;
        private System.Windows.Forms.DataGridView dataGridWarehouseInfomation;
    }
}