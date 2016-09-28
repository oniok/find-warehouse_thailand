using findwarehouse.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace findwarehouse.controller
{
    class WarehouseInformationController
    {

        public static void GetData(DataGridView dataGridWarehouseInfomation)
        {
            //set model to data gridviews
            dataGridWarehouseInfomation.DataSource = models.WarehouseInformationModel.getWarehouseInformation();
        }
        public static void InsertData(models.WarehouseInformationModel model)
        {
            //show message box when cannot insert data
            MessageBox.Show((models.WarehouseInformationModel.insertWarehouseInformation(model)) ? "Insert Success" :
                "Insert Failed, Please Check parameter or something");
        }

        public static void UpdateData(models.WarehouseInformationModel model)
        {
            //show message box when cannot insert data
            MessageBox.Show((models.WarehouseInformationModel.updateWarehouseInformation(model)) ? "Insert Success" :
                "Insert Failed, Please Check parameter or something");
        }
        /** Call Add or Edit Industrial Form **/
        public static void CallAddEditForm(Form WarehouseInformation)
        {
            WarehouseInformation.Show();// show dialog.
        }
        /** set province data member into combobox **/
        public static void SetProvinceBox(ComboBox comboProvince)
        {
            comboProvince.DataSource = ProvinceModel.getProvinceList(); // create datasource into combobox
            comboProvince.DisplayMember = ProvinceModel.ENTITY.NAME_ENG; // set for display what to show.
            comboProvince.ValueMember = ProvinceModel.ENTITY.CODE; // set for value member when selected.
        }
        /** set WarehouseMember(Member Code) data member into combobox **/
        public static void SetcomboCuscode(ComboBox comboMemberCode)
        {
            //comboMemberCode.DataSource = MembercodeModel.getMemberList(); // create datasource into combobox
            //comboMemberCode.DisplayMember = MembercodeModel.ENTITY.nameEn; // set for display what to show.
            //comboMemberCode.ValueMember = MembercodeModel.ENTITY.Code; // set for value member when selected.
        }
        /** set Industrial  data member into combobox **/
        public static void SetcomboIndustrial(ComboBox comboIndustrial)
        {
            comboIndustrial.DataSource = IndustrialModel.getIndustrialList(); // create datasource into combobox
            comboIndustrial.DisplayMember = IndustrialModel.ENTITY.NAME_EN; // set for display what to show.
            comboIndustrial.ValueMember = IndustrialModel.ENTITY.CODE; // set for value member when selected.
        }
        /** set Industrial  data member into combobox **/
        public static void SetcomboUsage(ComboBox comboUsage)
        {
            comboUsage.DataSource = WarehouseUsageTypeModel.getUsagetypeCodelList(); // create datasource into combobox
            comboUsage.DisplayMember = WarehouseUsageTypeModel.ENTITY.NameEng; // set for display what to show.
            comboUsage.ValueMember = WarehouseUsageTypeModel.ENTITY.UsagetypeCode; // set for value member when selected.
        }
    }
}
