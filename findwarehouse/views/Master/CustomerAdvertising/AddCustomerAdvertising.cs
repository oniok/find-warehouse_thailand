using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using findwarehouse.controller;
using findwarehouse.views.Master.CustomerAdvertising;

namespace findwarehouse.views.Master.CustomerAdvertising
{
    public partial class AddCustomerAdvertising : Form
    {
        public AddCustomerAdvertising()
        {
            InitializeComponent();
        }

        private models.CustomerAdvertisingModel Model;

        public AddCustomerAdvertising(models.CustomerAdvertisingModel Model)
        {
            this.Model = Model;
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            if (Model == null) // add Industrial mode
            {
                Model = new models.CustomerAdvertisingModel(); //new model to assign data
               
                Model.contryCode = txtCountry.Text.Trim(); //set english name
                Model.NameEn = txtNameEn.Text.Trim(); // set thai name
                Model.AddressEn = txtAddr.Text.Trim(); // set japan name
                Model.tel = txtPhone.Text.Trim(); // set search name
                Model.mob = txtMobile.Text.Trim(); // set province id
                Model.contactEn = txtContract.Text.Trim(); //set english name
                Model.mail = txtEmail.Text.Trim(); // set thai name
                Model.url = txtURL.Text.Trim(); // set japan name
                Model.regDate = dtpRegisterDate.Text.Trim(); // set search name
                Model.expireDate = dtpExpireDate.Text.Trim(); // set thai name
                Model.upExpireDate = dtpUpExpireDate.Text.Trim(); // set japan name
              
                CustomerAdvertisingController.InsertData(Model);

            }
            else // update (edit) Industrial mode
            {
                Model.contryCode = txtCountry.Text.Trim(); //set english name
                Model.NameEn = txtNameEn.Text.Trim(); // set thai name
                Model.AddressEn = txtAddr.Text.Trim(); // set japan name
                Model.tel = txtPhone.Text.Trim(); // set search name
                Model.mob = txtMobile.Text.Trim(); // set province id
                Model.contactEn = txtContract.Text.Trim(); //set english name
                Model.mail = txtEmail.Text.Trim(); // set thai name
                Model.url = txtURL.Text.Trim(); // set japan name
                Model.regDate = dtpRegisterDate.Text.Trim(); // set search name
                Model.expireDate = dtpExpireDate.Text.Trim(); // set thai name
                Model.upExpireDate = dtpUpExpireDate.Text.Trim(); // set japan name
                CustomerAdvertisingController.UpdateData(Model);
            }
        }

        private void AddCustomerAdvertising_Load(object sender, EventArgs e)
        {
            if (Model != null) //check model has data?
            {
                /* set Model into data */
                txtCountry.Text = Model.contryCode; //set selected value province.
                txtNameEn.Text = Model.NameEn; //set name english.
                txtAddr.Text = Model.AddressEn; //set name thai.
                txtPhone.Text = Model.tel; //set name japan.
                txtMobile.Text = Model.mob; //set search name.
                txtContract.Text = Model.contactEn; //set selected value province.
                txtEmail.Text = Model.mail; //set name english.
                txtURL.Text = Model.url; //set name thai.
                dtpRegisterDate.Text = Model.regDate; //set name japan.
                dtpExpireDate.Text = Model.expireDate; //set search name.
                dtpUpExpireDate.Text = Model.upExpireDate; //set name thai.
              
               
            }

          
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
