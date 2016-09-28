using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using findwarehouse.controller;

namespace findwarehouse.views.Master.Industrial
{
    public partial class AddEditIndustrial : Form
    {
       private models.IndustrialModel model;

        /* New Form with no selected Mode */
        public AddEditIndustrial()
        {
            InitializeComponent();
        }

        /* New Form with selected Mode */
        public AddEditIndustrial(models.IndustrialModel model)
        {
            this.model = model; // Assign Mode into this form
            InitializeComponent();
        }
        private void AddEditIndustrial_Load(object sender, EventArgs e)
        {
            IndustrialController.SetProvinceBox(cbProvince);   //set province data into combobox
          
            if(model != null) //check model has data?
            {
                /* set Model into data */
                cbProvince.SelectedValue = model.Province; //set selected value province.
                txtNameEnglish.Text = model.NameEn; //set name english.
                txtNameThai.Text = model.NameTh; //set name thai.
                txtNameJapan.Text = model.NameJp; //set name japan.
                txtSearchName.Text = model.SearchKey; //set search name.
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (model == null) // add Industrial mode
            {
                model = new models.IndustrialModel(); //new model to assign data
                model.Province = cbProvince.SelectedValue.ToString(); // set province id
                model.NameEn = txtNameEnglish.Text.Trim(); //set english name
                model.NameTh = txtNameThai.Text.Trim(); // set thai name
                model.NameJp = txtNameJapan.Text.Trim(); // set japan name
                model.SearchKey = txtSearchName.Text.Trim(); // set search name
                IndustrialController.InsertData(model); // call update method
                
            }
            else // update (edit) Industrial mode
            {
                model.Province = cbProvince.SelectedValue.ToString(); // set province id
                model.NameEn = txtNameEnglish.Text.Trim(); //set english name
                model.NameTh = txtNameThai.Text.Trim(); // set thai name
                model.NameJp = txtNameJapan.Text.Trim(); // set japan name
                model.SearchKey = txtSearchName.Text.Trim(); // set search name
                IndustrialController.UpdateData(model);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();//close form
        }
    }
}
