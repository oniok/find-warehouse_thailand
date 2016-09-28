using findwarehouse.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace findwarehouse.controller
{
    class PremiumBannerController
    {
        public static void GetData(DataGridView gridViewPremiumBanner)
        {
            //set model to data gridviews
            gridViewPremiumBanner.DataSource = models.PremiumBannerModel.getPremiumBannerAll();
        }
        public static void InsertData(models.PremiumBannerModel model)
        {
            //show message box when cannot insert data
            
            MessageBox.Show((models.PremiumBannerModel.insertPremiumBanner(model)) ? "Insert Success" :
                "Insert Failed, Please Check parameter or something");

        }
        public static void UpdateData(models.PremiumBannerModel model)
        {
            //show message box when cannot insert data
            MessageBox.Show((models.PremiumBannerModel.updatePremiumBanner(model)) ? "Update Success" :
                "Update Failed, Please Check parameter or something");
        }
        /** Call Add or Edit Industrial Form **/
        public static void CallAddEditForm(Form PremiumBannerAddEditForm)
        {
            PremiumBannerAddEditForm.ShowDialog();// show dialog.
        }
        /** set province data member into combobox **/
        public static void SetInitialComboBox(ComboBox objComboBox)
        {
            objComboBox.DataSource = PremiumBannerModel.getPremiumBannerAll(); // create datasource into combobox
            objComboBox.DisplayMember = PremiumBannerModel.ENTITY.memberCode; // set for display what to show.
            objComboBox.ValueMember = PremiumBannerModel.ENTITY.memberCode; // set for value member when selected.
        }
    }
}
