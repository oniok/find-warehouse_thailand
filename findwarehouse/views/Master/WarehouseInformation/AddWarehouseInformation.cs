using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using findwarehouse.controller;

namespace findwarehouse.views.Master.WarehouseInformation
{
    public partial class AddWarehouseInformation : Form
    {
        public AddWarehouseInformation()
        {
            InitializeComponent();
        }
        private models.WarehouseInformationModel model;
        /* New Form with selected Mode */
        public AddWarehouseInformation(models.WarehouseInformationModel model)
        {
            this.model = model;
            InitializeComponent();
        }
        private void comboProvince_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AddWarehouseInformation_Load(object sender, EventArgs e)
        {
            WarehouseInformationController.SetProvinceBox(comboProvince);   //set province data into combobox
            WarehouseInformationController.SetcomboCuscode(comboMemberCode);
            WarehouseInformationController.SetcomboIndustrial(comboIndustrial);
            WarehouseInformationController.SetcomboUsage(comboUsage);

            if (model != null) //check model has data?
            {
                /* set Model into data */
                //comboMemberCode.SelectedValue = model.Province; //set selected value province.
                comboMemberCode.SelectedValue = model.memberCode; //set selected value province.
                comboProvince.SelectedValue = model.provinceCode; //set selected value province.
                comboIndustrial.SelectedValue = model.industrialCode; //set selected value province.
                comboUsage.SelectedValue = model.usageType; //set selected value province.
                txtManageNo.Text = model.manageno;
                txtLocationLat.Text = model.lat; //set LocationLat.
                txtLocationLng.Text = model.lng; //set LocationLng.

                checkGeneral.Checked = (model.catGl.Equals("1"))? true : false ; //set Check General.
                checkBonded.Checked = (model.catBon.Equals("1"))? true : false; //set Bonded 
                checkEXPLOSIVES.Checked = (model.catExp.Equals("1")) ? true : false;
                checkFreeze.Checked = (model.catFrz.Equals("1")) ? true : false;
                checkPefrigeration.Checked = (model.catRefri.Equals("1")) ? true : false;
                checkHeaveis.Checked = (model.catHeav.Equals("1")) ? true : false;
                checkOther.Checked = (model.catX.Equals("1")) ? true : false;

                txtWarehousenameEng.Text = model.nameEn;
                txtWarehousenameThai.Text = model.nameTh;
                txtWarehousenameJPN.Text = model.nameJp;
                txtWarehouseAdd.Text = model.addr;
                txtPhone.Text = model.tel;
                txtContractEng.Text = model.contactEn;
                txtContractThai.Text = model.contactTh;
                txtContractJPN.Text = model.contactJp;
                txtDecriptionEnglish.Text = model.desEn;
                txtDecriptionThai.Text = model.desTh;
                txtDecriptionJPN.Text = model.desTh;
                dtpRegister.Text = model.regDate;
                dtpActivedate.Text = model.activeDate;
                dtpInActiveDate.Text = model.InActiveDate;
            }

        }

        private void checkGeneral_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            model.catGl = (checkGeneral.Checked) ? "1" : "0";
            model.catBon = (checkBonded.Checked) ? "1" : "0";
            model.catExp = (checkEXPLOSIVES.Checked) ? "1" : "0";
            model.catFrz = (checkFreeze.Checked) ? "1" : "0";
            model.catRefri = (checkPefrigeration.Checked) ? "1" : "0";
            model.catHeav = (checkHeaveis.Checked) ? "1" : "0";
            model.catX = (checkOther.Checked) ? "1" : "0";

            if (model == null) // add Industrial mode
            {
                model = new models.WarehouseInformationModel(); //new model to assign data
                model.memberCode = comboMemberCode.SelectedValue.ToString(); // set province id
                model.provinceCode = comboProvince.SelectedValue.ToString(); //set english name
                model.industrialCode = comboIndustrial.SelectedValue.ToString(); // set thai name
                model.usageType = comboUsage.SelectedValue.ToString(); // set japan name
                model.lat = txtLocationLat.Text.Trim(); // set search name
                model.lng = txtLocationLng.Text.Trim(); // set province id
                model.catGl = checkGeneral.Text; //set english name
                model.catBon = checkBonded.Text; // set thai name
                model.catExp = checkEXPLOSIVES.Text; // set japan name
                model.catFrz = checkFreeze.Text; // set search name
                model.catRefri = checkPefrigeration.Text;
                model.catHeav = checkHeaveis.Text; // set search name
                model.catX = checkOther.Text;
                model.nameEn = txtLocationLat.Text.Trim(); // set search name
                model.nameTh = txtLocationLng.Text.Trim(); // set province id
                model.nameJp = txtLocationLat.Text.Trim(); // set search name
                model.addr = txtLocationLng.Text.Trim(); // set province id
                model.tel = txtLocationLat.Text.Trim(); // set search name
                model.contactEn = txtLocationLng.Text.Trim(); // set province id
                model.contactTh = txtLocationLat.Text.Trim(); // set search name
                model.contactJp = txtLocationLng.Text.Trim(); // set province id
                model.desEn = txtLocationLat.Text.Trim(); // set search name
                model.desTh = txtLocationLng.Text.Trim(); // set province id
                model.desJp = txtLocationLat.Text.Trim(); // set search name
                model.regDate = txtLocationLng.Text.Trim(); // set province id
                model.activeDate = txtLocationLat.Text.Trim(); // set search name
                model.InActiveDate = txtLocationLng.Text.Trim(); // set province id
                WarehouseInformationController.InsertData(model); // call update method

            }
            else // update (edit) Industrial mode
            {
                model = new models.WarehouseInformationModel(); //new model to assign data
                model.memberCode = comboMemberCode.SelectedValue.ToString(); // set province id
                model.provinceCode = comboProvince.SelectedValue.ToString(); //set english name
                model.industrialCode = comboIndustrial.SelectedValue.ToString(); // set thai name
                model.usageType = comboUsage.SelectedValue.ToString(); // set japan name
                model.lat = txtLocationLat.Text.Trim(); // set search name
                model.lng = txtLocationLng.Text.Trim(); // set province id
                model.catGl = checkGeneral.Text; //set english name
                model.catBon = checkBonded.Text; // set thai name
                model.catExp = checkEXPLOSIVES.Text; // set japan name
                model.catFrz = checkFreeze.Text; // set search name
                model.catRefri = checkPefrigeration.Text;
                model.catHeav = checkHeaveis.Text; // set search name
                model.catX = checkOther.Text;
                model.nameEn = txtLocationLat.Text.Trim(); // set search name
                model.nameTh = txtLocationLng.Text.Trim(); // set province id
                model.nameJp = txtLocationLat.Text.Trim(); // set search name
                model.addr = txtLocationLng.Text.Trim(); // set province id
                model.tel = txtLocationLat.Text.Trim(); // set search name
                model.contactEn = txtLocationLng.Text.Trim(); // set province id
                model.contactTh = txtLocationLat.Text.Trim(); // set search name
                model.contactJp = txtLocationLng.Text.Trim(); // set province id
                model.desEn = txtLocationLat.Text.Trim(); // set search name
                model.desTh = txtLocationLng.Text.Trim(); // set province id
                model.desJp = txtLocationLat.Text.Trim(); // set search name
                model.regDate = txtLocationLng.Text.Trim(); // set province id
                model.activeDate = txtLocationLat.Text.Trim(); // set search name
                model.InActiveDate = txtLocationLng.Text.Trim(); // set province id
                WarehouseInformationController.UpdateData(model); // call update method
            }
           
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
