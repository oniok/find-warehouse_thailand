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
using findwarehouse.views.Master.WarehouseMember;

namespace findwarehouse.views
{
    public partial class WarehouseMemberForm : Form
    {
        public WarehouseMemberForm()
        {
            InitializeComponent();
        }

        WarehousememberModel selectedWarehousemember;

        private void btnAddForm_Click(object sender, EventArgs e)
        {
             WarehouseMemberController.CallAddEditForm(new AddWarehouseMemberForm());
            ReloadDataGridView();
        }

        private void WarehouseMemberForm_Load(object sender, EventArgs e)
        {
            SetEditColumnIntoDataGrid();// Insert Edeit column into datagridview
            dataGridWarehouseMember.AutoGenerateColumns = true; // create gridview as auto generate columns.
            WarehouseMemberController.GetData(dataGridWarehouseMember); // call data industrial into grid.
            dataGridWarehouseMember.SelectedRows[0].Selected = true;
            dataGridWarehouseMember.AutoResizeColumns();//Auto resize columns

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
          

            if (selectedWarehousemember != null)
                WarehouseMemberController.CallAddEditForm(new AddWarehouseMemberForm(selectedWarehousemember));
        }

        private void dataGridWarehouseMember_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedWarehousemember = new WarehousememberModel();
            setWarehouseMemberModel(dataGridWarehouseMember.SelectedRows[0]);
            if (e.ColumnIndex == 0 && e.RowIndex >= 0)
            {
                WarehouseMemberController.CallAddEditForm(new AddWarehouseMemberForm(selectedWarehousemember)); // call form as edit data form.
                ReloadDataGridView(); // Reload data in datagridview
            }

        }

        // Method for setup premiumbannermodel value
        private void setWarehouseMemberModel(DataGridViewRow selectedRows)
        {
            selectedWarehousemember.Code = selectedRows.Cells[1].Value.ToString(); // set province id
            selectedWarehousemember.flag = selectedRows.Cells[2].Value.ToString(); //set file name
            selectedWarehousemember.countryCode = selectedRows.Cells[3].Value.ToString(); // set thai name
            selectedWarehousemember.nameEn = selectedRows.Cells[4].Value.ToString(); //set active date
            selectedWarehousemember.addr = selectedRows.Cells[5].Value.ToString(); // set inactive date
            selectedWarehousemember.tel = selectedRows.Cells[6].Value.ToString(); // set province id
            selectedWarehousemember.mob = selectedRows.Cells[7].Value.ToString(); //set file name
            selectedWarehousemember.contactName = selectedRows.Cells[8].Value.ToString(); // set thai name
            selectedWarehousemember.email = selectedRows.Cells[9].Value.ToString(); //set active date
            selectedWarehousemember.url = selectedRows.Cells[10].Value.ToString(); // set inactive date
            selectedWarehousemember.regDate = selectedRows.Cells[11].Value.ToString(); // set province id
            selectedWarehousemember.expireDate = selectedRows.Cells[12].Value.ToString(); //set file name
            selectedWarehousemember.updDate = selectedRows.Cells[13].Value.ToString(); // set thai name
            selectedWarehousemember.searchKey = selectedRows.Cells[14].Value.ToString(); //set active date

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
            dataGridWarehouseMember.Columns.Add(editColumn);
        }

        // Reload data When Add/Edit form was closed
        public void ReloadDataGridView()
        {
            WarehouseMemberController.GetData(dataGridWarehouseMember); // call data industrial into grid.
        }
    }
}
