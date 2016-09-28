using findwarehouse.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace findwarehouse.controller
{
    class RightBannerController
    {
        public static void GetData(DataGridView dataGridRightBanner)
        {
            //set model to data gridviews
            dataGridRightBanner.DataSource = models.RightBannerModel.getRightBanner();
        }

        public static void InsertData(models.RightBannerModel model)
        {
            //show message box when cannot insert data
            MessageBox.Show((models.RightBannerModel.insertRightBanner(model)) ? "Insert Success" :
                "Insert Failed, Please Check parameter or something");
        }

        public static void UpdateData(models.RightBannerModel model)
        {
            //show message box when cannot insert data
            MessageBox.Show((models.RightBannerModel.updateRightBanner(model)) ? "Insert Success" :
                "Insert Failed, Please Check parameter or something");
        }

        /** Call Add or Edit Industrial Form **/
        public static void CallAddEditForm(Form AddRightBanner)
        {
            AddRightBanner.ShowDialog();// show dialog.
        }

        public static void SetCustomerBox(ComboBox comboCusAdd)
        {
            comboCusAdd.DataSource = CustomerAdvertisingModel.getCustomerList(); // create datasource into combobox
            comboCusAdd.DisplayMember = CustomerAdvertisingModel.ENTITY.NameEn; // set for display what to show.
            comboCusAdd.ValueMember = CustomerAdvertisingModel.ENTITY.cusCode; // set for value member when selected.
        }

        public static void SetcomboCategoryBox(ComboBox comboCategory)
        {
            comboCategory.DataSource = categorytype.getTypeList(); // create datasource into combobox
            comboCategory.DisplayMember = categorytype.ENTITY.NAME_EN; // set for display what to show.
            comboCategory.ValueMember = categorytype.ENTITY.ID; // set for value member when selected.
        }
    }
}
