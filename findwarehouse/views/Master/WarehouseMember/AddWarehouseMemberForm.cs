using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using findwarehouse.controller;
namespace findwarehouse.views.Master.WarehouseMember
{
    public partial class AddWarehouseMemberForm : Form
    {
        public AddWarehouseMemberForm()
        {
            InitializeComponent();
        }
        private models.WarehousememberModel Model;
        public AddWarehouseMemberForm(models.WarehousememberModel Model)
        {
            this.Model = Model;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (Model == null) // add Industrial mode
            {
                Model = new models.WarehousememberModel(); //new model to assign data
                Model.flag = txtFlag.Text.Trim(); // set province id
                Model.countryCode = txtContryCode.Text.Trim(); //set english name
                Model.nameEn = txtNameEng.Text.Trim(); // set thai name
                Model.addr = txtAddress.Text.Trim(); // set japan name
                Model.tel = txtTel.Text.Trim(); // set search name
                Model.mob = txtMobile.Text.Trim(); // set province id
                Model.contactName = txtContract.Text.Trim(); //set english name
                Model.email = txtEmail.Text.Trim(); // set thai name
                Model.url = txtURL.Text.Trim(); // set japan name
                Model.regDate = dtpRegisterDate.Text.Trim(); // set search name
                Model.expireDate = dtpExpireDate.Text.Trim(); // set thai name
                Model.updDate = dtpUpdateDate.Text.Trim(); // set japan name
                Model.searchKey = txtSearch.Text.Trim(); // set search name
                WarehouseMemberController.InsertData(Model);

            }
            else // update (edit) Industrial mode
            {
                Model.flag = txtFlag.Text.Trim(); // set province id
                Model.countryCode = txtContryCode.Text.Trim(); //set english name
                Model.nameEn = txtNameEng.Text.Trim(); // set thai name
                Model.addr = txtAddress.Text.Trim(); // set japan name
                Model.tel = txtTel.Text.Trim(); // set search name
                Model.mob = txtMobile.Text.Trim(); // set province id
                Model.contactName = txtContract.Text.Trim(); //set english name
                Model.email = txtEmail.Text.Trim(); // set thai name
                Model.url = txtURL.Text.Trim(); // set japan name
                Model.regDate = dtpRegisterDate.Text.Trim(); // set search name
                Model.expireDate = dtpExpireDate.Text.Trim(); // set thai name
                Model.updDate = dtpUpdateDate.Text.Trim(); // set japan name
                Model.searchKey = txtSearch.Text.Trim(); // set search name
                WarehouseMemberController.UpdateData(Model);
            }
        }

        private void AddWarehouseMemberForm_Load(object sender, EventArgs e)
        {



            if (Model != null) //check model has data?
            {
                /* set Model into data */
                txtFlag.Text = Model.flag; //set selected value province.
                txtContryCode.Text = Model.countryCode; //set name english.
                txtNameEng.Text = Model.nameEn; //set name thai.
                txtAddress.Text = Model.addr; //set name japan.
                txtTel.Text = Model.tel; //set search name.
                txtMobile.Text = Model.mob; //set selected value province.
                txtContract.Text = Model.contactName; //set name english.
                txtEmail.Text = Model.email; //set name thai.
                txtURL.Text = Model.url; //set name japan.
                dtpRegisterDate.Text = Model.regDate; //set search name.
                dtpExpireDate.Text = Model.expireDate; //set name thai.
                dtpUpdateDate.Text = Model.updDate; //set name japan.
                txtSearch.Text = Model.searchKey; //set search name.
            }

           
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
