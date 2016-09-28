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
using findwarehouse.views.Master.BannerAdvertising;

namespace findwarehouse.views.Master.BannerAdvertising
{
    public partial class BannerAdvertisingForm : Form
    {
        public BannerAdvertisingForm()
        {
            InitializeComponent();
        }

        BannerAdvertisingModel selectBannerAdvertising; // when selected item input data into this

        private void dataGridBannerAdvertising_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridBannerAdvertising_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            selectBannerAdvertising = new BannerAdvertisingModel();
            setBannerAdvertisingModel(dataGridBannerAdvertising.SelectedRows[0]);
            if(e.ColumnIndex == 0 && e.RowIndex >= 0)
            {
                BannerAdvertisingController.CallAddEditForm(new AddBannerAdvertising(selectBannerAdvertising));
            }
            
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (selectBannerAdvertising != null)
                BannerAdvertisingController.CallAddEditForm(new AddBannerAdvertising(selectBannerAdvertising)); // call form as edit data form.
            ReloadDataGridView();
        }

        private void btnAddForm_Click(object sender, EventArgs e)
        {
            BannerAdvertisingController.CallAddEditForm(new AddBannerAdvertising()); // call form as add data form.
            ReloadDataGridView();
        }

        private void BannerAdvertisingForm_Load(object sender, EventArgs e)
        {
            SetEditColumnIntoDataGrid();// Insert Edeit column into datagridview
            dataGridBannerAdvertising.AutoGenerateColumns = true; // create gridview as auto generate columns.
            BannerAdvertisingController.GetData(dataGridBannerAdvertising); // call data industrial into grid.
            dataGridBannerAdvertising.SelectedRows[0].Selected = true;
            dataGridBannerAdvertising.AutoResizeColumns();//Auto resize columns
        }

        // Method for setup premiumbannermodel value
        private void setBannerAdvertisingModel(DataGridViewRow selectedRows)
        {
            selectBannerAdvertising.Code = selectedRows.Cells[1].Value.ToString(); // set province id
            selectBannerAdvertising.cusCode = selectedRows.Cells[2].Value.ToString(); //set file name
            selectBannerAdvertising.banImg = selectedRows.Cells[3].Value.ToString(); // set thai name
            selectBannerAdvertising.Sequence = Int16.Parse(selectedRows.Cells[4].Value.ToString()); //set active date
            selectBannerAdvertising.activeDate = selectedRows.Cells[5].Value.ToString(); // set inactive date
            selectBannerAdvertising.inActiveDate = selectedRows.Cells[6].Value.ToString(); // set inactive date

        }

        // Set Edit Column to Data Grid
        private void SetEditColumnIntoDataGrid()
        {
            // Set Column properties
            DataGridViewButtonColumn editColumn = new DataGridViewButtonColumn();
            editColumn.Frozen = true;
            editColumn.HeaderText = "";
            editColumn.Name = "Edit";
            editColumn.Text = "Edit";
            editColumn.ReadOnly = true;
            editColumn.Resizable = DataGridViewTriState.False;
            editColumn.Width = 30;
            editColumn.UseColumnTextForButtonValue = true;
            // Add editColumn into datagridview
            dataGridBannerAdvertising.Columns.Add(editColumn);
        }

        // Reload data When Add/Edit form was closed
        public void ReloadDataGridView()
        {
            BannerAdvertisingController.GetData(dataGridBannerAdvertising); // call data industrial into grid.
        }
    }
}
