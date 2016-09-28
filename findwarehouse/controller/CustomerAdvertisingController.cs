using findwarehouse.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace findwarehouse.controller
{
    class CustomerAdvertisingController
    {
        public static void GetData(DataGridView dataGridCustomerAdvertising)
        {
            //set model to data gridviews
            dataGridCustomerAdvertising.DataSource = models.CustomerAdvertisingModel.getCustomerAdvertising();
        }
        public static void InsertData(models.CustomerAdvertisingModel model)
        {
            //show message box when cannot insert data
            MessageBox.Show((models.CustomerAdvertisingModel.InsertCustomerAdvertising(model)) ? "Insert Success" :
                "Insert Failed, Please Check parameter or something");
        }

        public static void UpdateData(models.CustomerAdvertisingModel model)
        {
            //show message box when cannot insert data
            MessageBox.Show((models.CustomerAdvertisingModel.updateCustomerAdvertising(model)) ? "Insert Success" :
                "Insert Failed, Please Check parameter or something");
        }
        /** Call Add or Edit Industrial Form **/
        public static void CallAddEditForm(Form CustomerAdvertising)
        {
            CustomerAdvertising.ShowDialog();// show dialog.
        }

    }
}
