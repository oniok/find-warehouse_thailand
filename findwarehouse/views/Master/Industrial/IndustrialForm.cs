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
            dataGridIndustrial.AutoGenerateColumns = true; // create gridview as auto generate columns.
            IndustrialController.GetData(dataGridIndustrial); // call data industrial into grid.
            dataGridIndustrial.Rows[0].Selected = true;
        }

        private void btnAddForm_Click(object sender, EventArgs e)
        {
            IndustrialController.CallAddEditForm(new AddEditIndustrial()); // call form as add data form.
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if(selectedIndustrial != null)
                IndustrialController.CallAddEditForm(new AddEditIndustrial(selectedIndustrial)); // call form as edit data form.
        }

        private void dataGridIndustrial_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedIndustrial = new IndustrialModel();
            foreach (DataGridViewRow rows in dataGridIndustrial.SelectedRows)
            {
                selectedIndustrial.Code = rows.Cells[0].Value.ToString(); //get code cell
                selectedIndustrial.Province = rows.Cells[1].Value.ToString();//get province cell
                selectedIndustrial.NameEn = rows.Cells[2].Value.ToString(); //get name eng cell
                selectedIndustrial.NameTh = rows.Cells[3].Value.ToString(); //get name thai cell
                selectedIndustrial.NameJp = rows.Cells[4].Value.ToString(); //get name jp cell
                selectedIndustrial.Sequence = Int16.Parse(rows.Cells[5].Value.ToString()); //get sequence number
                selectedIndustrial.SearchKey = rows.Cells[6].Value.ToString(); //get search key cell
            }
        }
    }
}
