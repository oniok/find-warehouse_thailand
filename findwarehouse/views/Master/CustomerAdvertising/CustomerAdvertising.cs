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
using findwarehouse.views.Master.CustomerAdvertising;


namespace findwarehouse.views.Master.CustomerAdvertising
{
    public partial class CustomerAdvertising : Form
    {
        public CustomerAdvertising()
        {
            InitializeComponent();
        }

        CustomerAdvertisingModel selectCustomerAdvertising;

        private void CustomerAdvertising_Load(object sender, EventArgs e)
        {

            SetEditColumnIntoDataGrid();// Insert Edeit column into datagridview
            dataGridCustomerAdvertising.AutoGenerateColumns = true; // create gridview as auto generate columns.
            CustomerAdvertisingController.GetData(dataGridCustomerAdvertising); // call data industrial into grid.
            dataGridCustomerAdvertising.SelectedRows[0].Selected = true;
            dataGridCustomerAdvertising.AutoResizeColumns();//Auto resize columns

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

            if (selectCustomerAdvertising != null)
                CustomerAdvertisingController.CallAddEditForm(new AddCustomerAdvertising(selectCustomerAdvertising));
        }

        private void btnAddForm_Click(object sender, EventArgs e)
        {
            CustomerAdvertisingController.CallAddEditForm(new AddCustomerAdvertising());
            ReloadDataGridView();
        }

        private void dataGridCustomerAdvertising_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectCustomerAdvertising = new CustomerAdvertisingModel();
            setCustomerAdvertisingModel(dataGridCustomerAdvertising.SelectedRows[0]);
            if (e.ColumnIndex == 0 && e.RowIndex >= 0)
            {
                CustomerAdvertisingController.CallAddEditForm(new AddCustomerAdvertising(selectCustomerAdvertising)); // call form as edit data form.
                ReloadDataGridView(); // Reload data in datagridview
            }
        }

        // Method for setup premiumbannermodel value
        private void setCustomerAdvertisingModel(DataGridViewRow selectedRows)
        {
            selectCustomerAdvertising.cusCode = selectedRows.Cells[1].Value.ToString(); // set province id
            selectCustomerAdvertising.contryCode = selectedRows.Cells[2].Value.ToString(); //set file name
            selectCustomerAdvertising.NameEn = selectedRows.Cells[3].Value.ToString(); // set thai name
            selectCustomerAdvertising.AddressEn = selectedRows.Cells[4].Value.ToString(); //set active date
            selectCustomerAdvertising.tel = selectedRows.Cells[5].Value.ToString(); // set inactive date
            selectCustomerAdvertising.mob = selectedRows.Cells[6].Value.ToString(); // set province id
            selectCustomerAdvertising.contactEn = selectedRows.Cells[7].Value.ToString(); //set file name
            selectCustomerAdvertising.mail = selectedRows.Cells[8].Value.ToString(); // set thai name
            selectCustomerAdvertising.url = selectedRows.Cells[9].Value.ToString(); //set active date
            selectCustomerAdvertising.regDate = selectedRows.Cells[10].Value.ToString(); // set inactive date
            selectCustomerAdvertising.expireDate = selectedRows.Cells[11].Value.ToString(); //set active date
            selectCustomerAdvertising.upExpireDate = selectedRows.Cells[12].Value.ToString(); // set inactive date

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
            dataGridCustomerAdvertising.Columns.Add(editColumn);
        }

        // Reload data When Add/Edit form was closed
        public void ReloadDataGridView()
        {
            CustomerAdvertisingController.GetData(dataGridCustomerAdvertising); // call data industrial into grid.
        }

    }
}
