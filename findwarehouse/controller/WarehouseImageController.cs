using findwarehouse.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace findwarehouse.controller
{
    public class WarehouseImageController
    {
        public static void GetData(DataGridView dataGridWarehouseImage)
        {
            //set model to data gridviews
            dataGridWarehouseImage.DataSource = models.WarehouseImageModel.getWarehouseImageAll();
        }

        public static void InsertData(models.WarehouseImageModel model)
        {
            //show message box when cannot insert data
            MessageBox.Show((models.WarehouseImageModel.insertWarehouseImage(model)) ? "Insert Success" :
                "Insert Failed, Please Check parameter or something");

        }
        public static void UpdateData(models.WarehouseImageModel model)
        {
            //show message box when cannot insert data
            MessageBox.Show((models.WarehouseImageModel.updateWarehouseImage(model)) ? "Insert Success" :
                "Insert Failed, Please Check parameter or something");
        }

        /** Call Add or Edit Industrial Form **/
        public static void CallAddEditForm(Form AddWarehouseImage)
        {
            AddWarehouseImage.Show();// show dialog.
        }

        /** set province data member into combobox **/
        public static void SetMomberCode(ComboBox comboMemberCode)
        {
            comboMemberCode.DataSource = WarehouseInformationModel.getManagecodeInformationList(); // create datasource into combobox
            comboMemberCode.DisplayMember = WarehouseInformationModel.ENTITY.memberCode; // set for display what to show.
            comboMemberCode.ValueMember = WarehouseInformationModel.ENTITY.memberCode; // set for value member when selected.
        }

        public static void setMangeNo(ComboBox comboMenageNo)
        {
            comboMenageNo.DataSource = WarehouseInformationModel.getManagecodeInformationList(); // create datasource into combobox
            comboMenageNo.DisplayMember = WarehouseInformationModel.ENTITY.manageno; // set for display what to show.
            comboMenageNo.ValueMember = WarehouseInformationModel.ENTITY.memberCode; // set for value member when selected.
        }
    }
}
