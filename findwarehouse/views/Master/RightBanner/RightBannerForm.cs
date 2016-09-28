using findwarehouse.Database;
using findwarehouse.models;
using findwarehouse.controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using findwarehouse.views.Master.RightBanner;

namespace findwarehouse.views.Master.RightBanner
{
    public partial class RightBannerForm : Form
    {
        RightBannerModel selectRightbanner; // when selected item input data into this

        public RightBannerForm()
        {
            InitializeComponent();
        }

        private void RightBannerForm_Load(object sender, EventArgs e)
        {
            SetEditColumnIntoDataGrid();// Insert Edeit column into datagridview
            dataGridRightBanner.AutoGenerateColumns = true; // create gridview as auto generate columns.
            RightBannerController.GetData(dataGridRightBanner); // call data industrial into grid.
            dataGridRightBanner.SelectedRows[0].Selected = true;
            dataGridRightBanner.AutoResizeColumns();//Auto resize columns
        }

        private void btnAddForm_Click(object sender, EventArgs e)
        {
            RightBannerController.CallAddEditForm(new AddRightBanner()); // call form as add data form.
            ReloadDataGridView(); // Reload data in datagridview
        }

        private void dataGridRightBanner_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectRightbanner = new RightBannerModel();

            setRightModelModel(dataGridRightBanner.SelectedRows[0]);
            if (e.ColumnIndex == 0 && e.RowIndex >= 0)
            {
                RightBannerController.CallAddEditForm(new AddRightBanner(selectRightbanner)); // call form as edit data form.
                ReloadDataGridView(); // Reload data in datagridview
            }
        }

        // Method for setup premiumbannermodel value
        private void setRightModelModel(DataGridViewRow selectedRows)
        {
            selectRightbanner.adsMember = selectedRows.Cells[1].Value.ToString(); // set province id
            selectRightbanner.cateId = selectedRows.Cells[2].Value.ToString(); //set file name
            selectRightbanner.ProfileEn = selectedRows.Cells[3].Value.ToString(); // set thai name
            selectRightbanner.ProfileTh = selectedRows.Cells[4].Value.ToString(); //set active date
            selectRightbanner.ProfileJp = selectedRows.Cells[5].Value.ToString(); // set inactive date
            selectRightbanner.CompanyEn = selectedRows.Cells[6].Value.ToString(); //set active date
            selectRightbanner.CompanyTh = selectedRows.Cells[7].Value.ToString(); // set inactive date
            selectRightbanner.CompanyJp = selectedRows.Cells[8].Value.ToString(); // set province id
            selectRightbanner.ContactEn = selectedRows.Cells[9].Value.ToString(); //set file name
            selectRightbanner.ContactTh = selectedRows.Cells[10].Value.ToString(); // set thai name
            selectRightbanner.ContactJp = selectedRows.Cells[11].Value.ToString(); //set active date
            selectRightbanner.Uri = selectedRows.Cells[12].Value.ToString(); // set inactive date
            selectRightbanner.ActiveDate = selectedRows.Cells[13].Value.ToString(); // set inactive date
            selectRightbanner.InActiveDate = selectedRows.Cells[14].Value.ToString(); // set inactive date
            selectRightbanner.Sequence = Int16.Parse(selectedRows.Cells[15].Value.ToString()); //set active date

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
            dataGridRightBanner.Columns.Add(editColumn);
        }

        // Reload data When Add/Edit form was closed
        public void ReloadDataGridView()
        {
            RightBannerController.GetData(dataGridRightBanner); // call data industrial into grid.
        }
    }
}
