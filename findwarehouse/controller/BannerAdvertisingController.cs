using findwarehouse.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace findwarehouse.controller
{
    class BannerAdvertisingController
    {
        public static void GetData(DataGridView dataGridBannerAdvertising)
        {
            //set model to data gridviews
            dataGridBannerAdvertising.DataSource = models.BannerAdvertisingModel.getBannerAdvertising();
        }

        public static void InsertData(models.BannerAdvertisingModel model)
        {
            //show message box when cannot insert data
            MessageBox.Show((models.BannerAdvertisingModel.insertBannerAdvertising(model)) ? "Insert Success" :
                "Insert Failed, Please Check parameter or something");

        }

        public static void UpdateData(models.BannerAdvertisingModel model)
        {
            //show message box when cannot insert data
            MessageBox.Show((models.BannerAdvertisingModel.updateBannerAdvertising(model)) ? "Insert Success" :
                "Insert Failed, Please Check parameter or something");
        }

        public static void CallAddEditForm(Form AddBannerAdvertising)
        {
            AddBannerAdvertising.ShowDialog();// show dialog.
        }

        public static void SetCustomerBox(ComboBox comboCusCode)
        {
            comboCusCode.DataSource = CustomerAdvertisingModel.getCustomerList(); // create datasource into combobox
            comboCusCode.DisplayMember = CustomerAdvertisingModel.ENTITY.NameEn; // set for display what to show.
            comboCusCode.ValueMember = CustomerAdvertisingModel.ENTITY.cusCode; // set for value member when selected.
        }
    }
}
