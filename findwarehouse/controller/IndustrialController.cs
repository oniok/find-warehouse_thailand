using findwarehouse.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace findwarehouse.controller
{
    class IndustrialController
    {
        public static void GetData(DataGridView gridViewIndustrial)
        {
            //set model to data gridviews
            gridViewIndustrial.DataSource = models.IndustrialModel.getIndustrialAll();
        }
        public static void InsertData(models.IndustrialModel model)
        {
            //show message box when cannot insert data
            MessageBox.Show((models.IndustrialModel.insertIndustrial(model)) ? "Insert Success" : 
                "Insert Failed, Please Check parameter or something");
            
        }
        public static void UpdateData(models.IndustrialModel model)
        {
            //show message box when cannot insert data
            MessageBox.Show((models.IndustrialModel.updateIndustrial(model)) ? "Insert Success" :
                "Insert Failed, Please Check parameter or something");
        }
        /** Call Add or Edit Industrial Form **/
        public static void CallAddEditForm(Form IndustrialAddEditForm)
        {
            IndustrialAddEditForm.ShowDialog();// show dialog.
        }
        /** set province data member into combobox **/
        public static void SetProvinceBox(ComboBox comboProvince)
        {
            comboProvince.DataSource = ProvinceModel.getProvinceList(); // create datasource into combobox
            comboProvince.DisplayMember = ProvinceModel.ENTITY.NAME_ENG; // set for display what to show.
            comboProvince.ValueMember = ProvinceModel.ENTITY.CODE; // set for value member when selected.
        }
    }
}
