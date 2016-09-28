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
using findwarehouse.views.Master.WarehouseInformation;
namespace findwarehouse.views.Master.WarehouseInformation
{
    public partial class WarehouseInformationForm : Form
    {
        public WarehouseInformationForm()
        {
            InitializeComponent();
        }
        // when selected item input data into this
        WarehouseInformationModel SelectWarehouseInfomation;

        //call form warehouseInfomation
        private void btnAddForm_Click(object sender, EventArgs e)
        {
            WarehouseInformationController.CallAddEditForm(new AddWarehouseInformation());  // call form as add data form.
            ReloadDataGridView();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (SelectWarehouseInfomation != null)
                WarehouseInformationController.CallAddEditForm(new AddWarehouseInformation(SelectWarehouseInfomation)); // call form as edit data form.
        }

        private void WarehouseInformationForm_Load(object sender, EventArgs e)
        {

            SetEditColumnIntoDataGrid();// Insert Edeit column into datagridview
            dataGridWarehouseInfomation.AutoGenerateColumns = true; // create gridview as auto generate columns.
            WarehouseInformationController.GetData(dataGridWarehouseInfomation); // call data industrial into grid.
            dataGridWarehouseInfomation.SelectedRows[0].Selected = true;
            dataGridWarehouseInfomation.AutoResizeColumns();//Auto resize columns
        }

        private void dataGridWarehouseInfomation_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SelectWarehouseInfomation = new WarehouseInformationModel();


            setWarehouseInformationModel(dataGridWarehouseInfomation.SelectedRows[0]);
            if (e.ColumnIndex == 0 && e.RowIndex >= 0)
            {
                WarehouseInformationController.CallAddEditForm(new AddWarehouseInformation(SelectWarehouseInfomation)); // call form as edit data form.
                ReloadDataGridView(); // Reload data in datagridview
            }

        }


        // Method for setup Warehouse Information value
        private void setWarehouseInformationModel(DataGridViewRow selectedRows)
        {
            SelectWarehouseInfomation.memberCode = selectedRows.Cells[1].Value.ToString(); // set province id
            SelectWarehouseInfomation.manageno = selectedRows.Cells[2].Value.ToString(); //set file name
            SelectWarehouseInfomation.provinceCode = selectedRows.Cells[3].Value.ToString(); // set thai name
            SelectWarehouseInfomation.industrialCode = selectedRows.Cells[4].Value.ToString(); //set active date
            SelectWarehouseInfomation.usageType = selectedRows.Cells[5].Value.ToString(); // set inactive date
            SelectWarehouseInfomation.lat = selectedRows.Cells[6].Value.ToString(); // set province id
            SelectWarehouseInfomation.lng = selectedRows.Cells[7].Value.ToString(); //set file name
            SelectWarehouseInfomation.catGl = selectedRows.Cells[8].Value.ToString(); // set thai name
            SelectWarehouseInfomation.catBon = selectedRows.Cells[9].Value.ToString(); //set active date
            SelectWarehouseInfomation.catExp = selectedRows.Cells[10].Value.ToString(); // set inactive date
            SelectWarehouseInfomation.catFrz = selectedRows.Cells[11].Value.ToString(); // set province id
            SelectWarehouseInfomation.catRefri = selectedRows.Cells[12].Value.ToString(); //set file name
            SelectWarehouseInfomation.catHeav = selectedRows.Cells[13].Value.ToString(); // set thai name
            SelectWarehouseInfomation.catX = selectedRows.Cells[14].Value.ToString(); //set active date
            SelectWarehouseInfomation.nameEn = selectedRows.Cells[15].Value.ToString(); // set inactive date
            SelectWarehouseInfomation.nameTh = selectedRows.Cells[16].Value.ToString(); // set province id
            SelectWarehouseInfomation.nameJp = selectedRows.Cells[17].Value.ToString(); //set file name
            SelectWarehouseInfomation.addr = selectedRows.Cells[18].Value.ToString(); // set thai name
            SelectWarehouseInfomation.tel = selectedRows.Cells[19].Value.ToString(); //set active date
            SelectWarehouseInfomation.contactEn = selectedRows.Cells[20].Value.ToString(); // set inactive date
            SelectWarehouseInfomation.contactTh = selectedRows.Cells[21].Value.ToString(); //set active date
            SelectWarehouseInfomation.contactJp = selectedRows.Cells[22].Value.ToString(); // set inactive date
            SelectWarehouseInfomation.desEn = selectedRows.Cells[23].Value.ToString(); // set province id
            SelectWarehouseInfomation.desTh = selectedRows.Cells[24].Value.ToString(); //set file name
            SelectWarehouseInfomation.desJp = selectedRows.Cells[25].Value.ToString(); // set thai name
            SelectWarehouseInfomation.regDate = selectedRows.Cells[26].Value.ToString(); //set active date
            SelectWarehouseInfomation.activeDate = selectedRows.Cells[27].Value.ToString(); // set inactive date
            SelectWarehouseInfomation.InActiveDate = selectedRows.Cells[28].Value.ToString(); //set active date
            SelectWarehouseInfomation.SEQ = Int16.Parse(selectedRows.Cells[29].Value.ToString()); // set inactive date

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
            dataGridWarehouseInfomation.Columns.Add(editColumn);
        }

        // Reload data When Add/Edit form was closed
        public void ReloadDataGridView()
        {
            WarehouseInformationController.GetData(dataGridWarehouseInfomation); // call data industrial into grid.
        }
    }
}
