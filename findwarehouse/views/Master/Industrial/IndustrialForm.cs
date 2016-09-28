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

namespace findwarehouse.views
{
    public partial class IndustrialForm : Form
    {
        IndustrialModel selectedIndustrial; // when selected item input data into this

        public IndustrialForm()
        {
            InitializeComponent();
        }

        private void IndustrialForm_Load(object sender, EventArgs e)
        {

            SetEditColumnIntoDataGrid();// Insert Edeit column into datagridview
            dataGridIndustrial.AutoGenerateColumns = true; // create gridview as auto generate columns.
            IndustrialController.GetData(dataGridIndustrial); // call data industrial into grid.
            dataGridIndustrial.SelectedRows[0].Selected = true;
            dataGridIndustrial.AutoResizeColumns();//Auto resize columns
        }

        private void btnAddForm_Click(object sender, EventArgs e)
        {
            IndustrialController.CallAddEditForm(new AddEditIndustrial()); // call form as add data form.
            ReloadDataGridView(); // Reload data in datagridview
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if(selectedIndustrial != null)
                IndustrialController.CallAddEditForm(new AddEditIndustrial(selectedIndustrial)); // call form as edit data form.
            ReloadDataGridView(); // Reload data in datagridview
        }

        private void dataGridIndustrial_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedIndustrial = new IndustrialModel();

            setIndustrialModel(dataGridIndustrial.SelectedRows[0]);
            if (e.ColumnIndex == 0 && e.RowIndex >= 0)
            {
                IndustrialController.CallAddEditForm(new AddEditIndustrial(selectedIndustrial)); // call form as edit data form.
                ReloadDataGridView(); // Reload data in datagridview
            }

        }

        private void dataGridIndustrial_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        // Method for setup premiumbannermodel value
        private void setIndustrialModel(DataGridViewRow selectedRows)
        {
            selectedIndustrial.Code = selectedRows.Cells[1].Value.ToString(); // set province id
            selectedIndustrial.Province = selectedRows.Cells[2].Value.ToString(); //set file name
            selectedIndustrial.NameEn = selectedRows.Cells[3].Value.ToString(); // set thai name
            selectedIndustrial.NameTh = selectedRows.Cells[4].Value.ToString(); //set active date
            selectedIndustrial.NameJp = selectedRows.Cells[5].Value.ToString(); // set inactive date
            selectedIndustrial.Sequence = Int16.Parse(selectedRows.Cells[6].Value.ToString()); //set active date
            selectedIndustrial.SearchKey = selectedRows.Cells[7].Value.ToString(); // set inactive date

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
            dataGridIndustrial.Columns.Add(editColumn);
        }

        // Reload data When Add/Edit form was closed
        public void ReloadDataGridView()
        {
            IndustrialController.GetData(dataGridIndustrial); // call data industrial into grid.
        }
    }
}
