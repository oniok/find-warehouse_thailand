namespace findwarehouse.views.Master.CustomerAdvertising
{
    partial class CustomerAdvertising
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
            this.dataGridCustomerAdvertising = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCustomerAdvertising)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddForm
            // 
            this.btnAddForm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddForm.Location = new System.Drawing.Point(827, 7);
            this.btnAddForm.Name = "btnAddForm";
            this.btnAddForm.Size = new System.Drawing.Size(123, 25);
            this.btnAddForm.TabIndex = 4;
            this.btnAddForm.Text = "Add CustomerAdvertising";
            this.btnAddForm.UseVisualStyleBackColor = true;
            this.btnAddForm.Click += new System.EventHandler(this.btnAddForm_Click);
            // 
            // dataGridCustomerAdvertising
            // 
            this.dataGridCustomerAdvertising.AllowUserToAddRows = false;
            this.dataGridCustomerAdvertising.AllowUserToDeleteRows = false;
            this.dataGridCustomerAdvertising.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridCustomerAdvertising.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridCustomerAdvertising.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridCustomerAdvertising.Location = new System.Drawing.Point(12, 51);
            this.dataGridCustomerAdvertising.MultiSelect = false;
            this.dataGridCustomerAdvertising.Name = "dataGridCustomerAdvertising";
            this.dataGridCustomerAdvertising.ReadOnly = true;
            this.dataGridCustomerAdvertising.RowHeadersVisible = false;
            this.dataGridCustomerAdvertising.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridCustomerAdvertising.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridCustomerAdvertising.Size = new System.Drawing.Size(943, 451);
            this.dataGridCustomerAdvertising.TabIndex = 3;
            this.dataGridCustomerAdvertising.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridCustomerAdvertising_CellClick);
            // 
            // CustomerAdvertising
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 514);
            this.Controls.Add(this.btnAddForm);
            this.Controls.Add(this.dataGridCustomerAdvertising);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CustomerAdvertising";
            this.Text = "CustomerAdvertising";
            this.Load += new System.EventHandler(this.CustomerAdvertising_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCustomerAdvertising)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnAddForm;
        private System.Windows.Forms.DataGridView dataGridCustomerAdvertising;
    }
}