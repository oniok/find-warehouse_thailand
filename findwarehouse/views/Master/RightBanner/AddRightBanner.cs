using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using findwarehouse.controller;

namespace findwarehouse.views.Master.RightBanner
{
    public partial class AddRightBanner : Form
    {
        private models.RightBannerModel model;

        /* New Form with no selected Mode */
        public AddRightBanner()
        {
            InitializeComponent();
        }
        /* New Form with selected Mode */
        public AddRightBanner(models.RightBannerModel model)
        {
            this.model = model; // Assign Mode into this form
            InitializeComponent();
        }

        private void AddRightBanner_Load(object sender, EventArgs e)
        {
            RightBannerController.SetCustomerBox(comboCusAdd);   //set province data into combobox
            RightBannerController.SetcomboCategoryBox(comboCategory);

            if (model != null) //check model has data?
            {
                /* set Model into data */
                comboCusAdd.SelectedValue = model.adsMember; //set selected value province.
                comboCategory.SelectedValue = model.cateId; //set name english.
                txtProfileEng.Text = model.ProfileEn; //set name thai.
                txtProfileThai.Text = model.ProfileTh; //set name japan.
                txtProfileJP.Text = model.ProfileJp; //set search name.
                txtCompanyEng.Text = model.CompanyEn; //set name thai.
                txtCompanyThai.Text = model.CompanyTh; //set name japan.
                txtCompanyJP.Text = model.CompanyJp; //set search name.
                txtConEng.Text = model.ContactEn; //set name thai.
                txtConThai.Text = model.ContactTh; //set name japan.
                txtConJapan.Text = model.ContactJp; //set search name.
                txtURL.Text = model.Uri; //set name thai.
                dateActiveDAte.Text = model.ActiveDate; //set name japan.
                dateInactiveDate.Text = model.InActiveDate; //set search name
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (model == null) // add Industrial mode
            {
                model = new models.RightBannerModel(); //new model to assign data
                model.adsMember = comboCusAdd.SelectedValue.ToString(); // set province id
                model.cateId    = comboCategory.SelectedValue.ToString();//set english name
                model.ProfileEn = txtProfileEng.Text.Trim(); // set thai name
                model.ProfileTh = txtProfileThai.Text.Trim(); // set japan name
                model.ProfileJp = txtProfileJP.Text.Trim(); // set search name
                model.CompanyEn = txtCompanyEng.Text.Trim(); // set province id
                model.CompanyTh = txtCompanyThai.Text.Trim(); //set english name
                model.CompanyJp = txtCompanyJP.Text.Trim(); // set thai name
                model.ContactEn = txtConEng.Text.Trim(); // set japan name
                model.ContactTh = txtConThai.Text.Trim(); // set search name
                model.ContactJp = txtConJapan.Text.Trim(); // set japan name
                model.Uri       = txtURL.Text.Trim(); // set search name
                model.ActiveDate   = dateActiveDAte.Text.Trim(); // set japan name
                model.InActiveDate = dateInactiveDate.Text.Trim(); // set search name
                RightBannerController.InsertData(model); // call update method

            }
            else // update (edit) Industrial mode
            {
                model = new models.RightBannerModel(); //new model to assign data
                model.adsMember = comboCusAdd.SelectedValue.ToString(); // set province id
                model.cateId = comboCategory.SelectedValue.ToString();//set english name
                model.ProfileEn = txtProfileEng.Text.Trim(); // set thai name
                model.ProfileTh = txtProfileThai.Text.Trim(); // set japan name
                model.ProfileJp = txtProfileJP.Text.Trim(); // set search name
                model.CompanyEn = txtCompanyEng.Text.Trim(); // set province id
                model.CompanyTh = txtCompanyThai.Text.Trim(); //set english name
                model.CompanyJp = txtCompanyJP.Text.Trim(); // set thai name
                model.ContactEn = txtConEng.Text.Trim(); // set japan name
                model.ContactTh = txtConThai.Text.Trim(); // set search name
                model.ContactJp = txtConJapan.Text.Trim(); // set japan name
                model.Uri = txtURL.Text.Trim(); // set search name
                model.ActiveDate = dateActiveDAte.Text.Trim(); // set japan name
                model.InActiveDate = dateInactiveDate.Text.Trim(); // set search name
                RightBannerController.UpdateData(model);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
