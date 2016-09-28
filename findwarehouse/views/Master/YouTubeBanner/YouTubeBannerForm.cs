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
namespace findwarehouse.views.Master.YouTubeBanner
{
    public partial class YouTubeBannerForm : Form
    {
        YouTubeBannerModel selectYoutubelink; // when selected item input data into this
        public YouTubeBannerForm()
        {
            InitializeComponent();
        }

        private void YouTubeBannerForm_Load(object sender, EventArgs e)
        {
            SetEditColumnIntoDataGrid();// Insert Edeit column into datagridview
            dataGridYoutubelink.AutoGenerateColumns = true; // create gridview as auto generate columns.
            YouTubeBannerController.GetData(dataGridYoutubelink); // call data industrial into grid.
            dataGridYoutubelink.SelectedRows[0].Selected = true;
            dataGridYoutubelink.AutoResizeColumns();//Auto resize columns
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (selectYoutubelink != null)
                YouTubeBannerController.CallAddEditForm(new AddYouTubeBanner(selectYoutubelink)); // call form as edit data form.
        }

        private void btnAddForm_Click(object sender, EventArgs e)
        {
            YouTubeBannerController.CallAddEditForm(new AddYouTubeBanner()); // call form as add data form.
            ReloadDataGridView();
        }

        private void dataGridYoutubelink_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            selectYoutubelink = new YouTubeBannerModel();
            setYoutubeBannerModel(dataGridYoutubelink.SelectedRows[0]);
            if (e.ColumnIndex == 0 && e.RowIndex >= 0)
            {
                YouTubeBannerController.CallAddEditForm(new AddYouTubeBanner(selectYoutubelink)); // call form as edit data form.
                ReloadDataGridView(); // Reload data in datagridview
            }

        }

        // Method for setup premiumbannermodel value
        private void setYoutubeBannerModel(DataGridViewRow selectedRows)
        {
            selectYoutubelink.Code = selectedRows.Cells[1].Value.ToString(); // set province id
            selectYoutubelink.customerCode = selectedRows.Cells[2].Value.ToString(); //set file name
            selectYoutubelink.YtUri = selectedRows.Cells[3].Value.ToString(); // set thai name
            selectYoutubelink.ActiveDate = selectedRows.Cells[4].Value.ToString(); //set active date
            selectYoutubelink.InActiveDate = selectedRows.Cells[5].Value.ToString(); // set inactive date

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
            dataGridYoutubelink.Columns.Add(editColumn);
        }


        // Reload data When Add/Edit form was closed
        public void ReloadDataGridView()
        {
            YouTubeBannerController.GetData(dataGridYoutubelink); // call data industrial into grid.
        }
    }
}
