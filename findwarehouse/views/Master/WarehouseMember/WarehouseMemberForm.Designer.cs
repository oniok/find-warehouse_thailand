namespace findwarehouse.views
{
    partial class WarehouseMemberForm
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
            this.dataGridWarehouseMember = new System.Windows.Forms.DataGridView();
            this.btnAddForm = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridWarehouseMember)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridWarehouseMember
            // 
            this.dataGridWarehouseMember.AllowUserToAddRows = false;
            this.dataGridWarehouseMember.AllowUserToDeleteRows = false;
            this.dataGridWarehouseMember.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridWarehouseMember.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridWarehouseMember.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridWarehouseMember.Location = new System.Drawing.Point(12, 37);
            this.dataGridWarehouseMember.MultiSelect = false;
            this.dataGridWarehouseMember.Name = "dataGridWarehouseMember";
            this.dataGridWarehouseMember.ReadOnly = true;
            this.dataGridWarehouseMember.RowHeadersVisible = false;
            this.dataGridWarehouseMember.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridWarehouseMember.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridWarehouseMember.Size = new System.Drawing.Size(954, 451);
            this.dataGridWarehouseMember.TabIndex = 1;
            this.dataGridWarehouseMember.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridWarehouseMember_CellClick);
            // 
            // btnAddForm
            // 
            this.btnAddForm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddForm.Location = new System.Drawing.Point(790, 6);
            this.btnAddForm.Name = "btnAddForm";
            this.btnAddForm.Size = new System.Drawing.Size(149, 25);
            this.btnAddForm.TabIndex = 3;
            this.btnAddForm.Text = "Add WherehouseMember";
            this.btnAddForm.UseVisualStyleBackColor = true;
            this.btnAddForm.Click += new System.EventHandler(this.btnAddForm_Click);
            // 
            // WarehouseMemberForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(978, 514);
            this.Controls.Add(this.btnAddForm);
            this.Controls.Add(this.dataGridWarehouseMember);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "WarehouseMemberForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Warehouse Member";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.WarehouseMemberForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridWarehouseMember)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridWarehouseMember;
        private System.Windows.Forms.Button btnAddForm;
    }
}