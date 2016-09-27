using findwarehouse.controller;
using findwarehouse.Database;
using findwarehouse.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//using findwarehouse.views.Master.PremiumBanner;

namespace findwarehouse.views.Master.PremiumBanner
{
    public partial class PremiumBannerForm : Form
    {
        PremiumBannerModel selectedPremiumBanner; // when selected item input data into this

        public PremiumBannerForm()
        {
            InitializeComponent();
        }

        private void PremiumBannerForm_Load(object sender, EventArgs e)
        {
            SetEditColumnIntoDataGrid();// Insert Edeit column into datagridview
            dataGridPremiumBanner.AutoGenerateColumns = true; // create gridview as auto generate columns.
            PremiumBannerController.GetData(dataGridPremiumBanner); // call data industrial into grid.
            //dataGridPremiumBanner.SelectedRows[0].Selected = true;
            dataGridPremiumBanner.AutoResizeColumns();//Auto resize columns
        }

        private void btnAddForm_Click(object sender, EventArgs e)
        {
            PremiumBannerController.CallAddEditForm(new AddPremiumBanner()); // call form as add data form.
            ReloadDataGridView(); // Reload data in datagridview
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (selectedPremiumBanner != null)
                PremiumBannerController.CallAddEditForm(new AddPremiumBanner(selectedPremiumBanner)); // call form as edit data form.
            ReloadDataGridView(); // Reload data in datagridview
        }

        private void dataGridPremiumBanner_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedPremiumBanner = new PremiumBannerModel();
            setPremiumBannerModel(dataGridPremiumBanner.SelectedRows[0]);
            if (e.ColumnIndex == 0 && e.RowIndex >= 0)
            {
                PremiumBannerController.CallAddEditForm(new AddPremiumBanner(selectedPremiumBanner)); // call form as edit data form.
                ReloadDataGridView(); // Reload data in datagridview
            }
        }

        // Method for setup premiumbannermodel value
        private void setPremiumBannerModel(DataGridViewRow selectedRows)
        {
            selectedPremiumBanner.memberCode = selectedRows.Cells[1].Value.ToString(); // set province id
            selectedPremiumBanner.adImg = selectedRows.Cells[2].Value.ToString(); //set file name
            selectedPremiumBanner.adPath = selectedRows.Cells[3].Value.ToString(); // set thai name
            selectedPremiumBanner.activeDate = selectedRows.Cells[4].Value.ToString(); //set active date
            selectedPremiumBanner.InActiveDate = selectedRows.Cells[5].Value.ToString(); // set inactive date

        }

        // Set Edit Column to Data Grid
        private void SetEditColumnIntoDataGrid()
        {
            // Set Column properties
            DataGridViewButtonColumn editColumn = new DataGridViewButtonColumn();


            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;

            editColumn.DefaultCellStyle = dataGridViewCellStyle1;
            editColumn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;

            editColumn.HeaderText = "";
            editColumn.Name = "Edit";
            editColumn.Text = "Edit";
            editColumn.ReadOnly = true;
            editColumn.Resizable = DataGridViewTriState.False;
            editColumn.Width = 30;
            editColumn.UseColumnTextForButtonValue = true;
            // Add editColumn into datagridview
            dataGridPremiumBanner.Columns.Add(editColumn);
        }

        // Reload data When Add/Edit form was closed
        public void ReloadDataGridView()
        {
            PremiumBannerController.GetData(dataGridPremiumBanner); // call data industrial into grid.
        }
        
    }
}
