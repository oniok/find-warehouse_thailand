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
using findwarehouse.views.Master.Industrial;

namespace findwarehouse.views.Master.WarehouseImage
{
    public partial class WarehouseImageForm : Form
    {
        WarehouseImageModel selectedImage; // when selected item input data into this
        public WarehouseImageForm()
        {
            InitializeComponent();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            
            if (selectedImage != null)
                WarehouseImageController.CallAddEditForm(new AddWarehouseImage(selectedImage)); // call form as edit data form.
            ReloadDataGridView();
        }

        private void btnAddForm_Click(object sender, EventArgs e)
        {
                WarehouseImageController.CallAddEditForm(new AddWarehouseImage()); // call form as add data form.
                    ReloadDataGridView();
                
        }

        private void dataGridWarehouseImage_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridWarehouseImage_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedImage = new WarehouseImageModel();
            setWarehouseImageModel(dataGridWarehouseImage.SelectedRows[0]);
            if(e.ColumnIndex == 0 && e.RowIndex >= 0)
            {
                WarehouseImageController.CallAddEditForm(new AddWarehouseImage(selectedImage)); // call form as edit data form.
                ReloadDataGridView(); // Reloadndata in datagridview
            }
           
        }

        private void WarehouseImageForm_Load(object sender, EventArgs e)
        {
            
            SetEditColumnIntoDataGrid();// Insert Edeit column into datagridview
            dataGridWarehouseImage.AutoGenerateColumns = true; // create gridview as auto generate columns.
            WarehouseImageController.GetData(dataGridWarehouseImage); // call data industrial into grid.
            //dataGridWarehouseImage.SelectedRows[0].Selected = true;
            dataGridWarehouseImage.AutoResizeColumns();//Auto resize columns
        }

        // Reload data When Add/Edit form was closed
        public void ReloadDataGridView()
        {
            WarehouseImageController.GetData(dataGridWarehouseImage); // call data industrial into grid.
        }

        // Set Edit Column to Data Grid
        private void SetEditColumnIntoDataGrid()
        {
            // Set Column properties
            DataGridViewButtonColumn editColumn1 = new DataGridViewButtonColumn();
            editColumn1.Frozen = true;
            editColumn1.HeaderText = "";
            editColumn1.Name = "Edit";
            editColumn1.Text = "Edit";
            editColumn1.ReadOnly = true;
            editColumn1.Resizable = DataGridViewTriState.False;
            editColumn1.Width = 30;
            editColumn1.UseColumnTextForButtonValue = true;
            // Add editColumn into datagridview
            dataGridWarehouseImage.Columns.Add(editColumn1);
        }

        // Method for setup WarehouseImagemodel value
        private void setWarehouseImageModel(DataGridViewRow selectedRows)
        {
            selectedImage.Code = selectedRows.Cells[1].Value.ToString(); // set province id
            selectedImage.manageNo = selectedRows.Cells[2].Value.ToString(); //set file name
            selectedImage.img01 = selectedRows.Cells[3].Value.ToString(); // set thai name
            selectedImage.img02 = selectedRows.Cells[4].Value.ToString(); //set active date
            selectedImage.img03 = selectedRows.Cells[5].Value.ToString(); // set inactive date
            selectedImage.img04 = selectedRows.Cells[6].Value.ToString(); //set active date
            selectedImage.img05 = selectedRows.Cells[7].Value.ToString(); // set inactive date

        }

    }
}
