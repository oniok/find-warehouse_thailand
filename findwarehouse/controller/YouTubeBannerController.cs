using findwarehouse.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace findwarehouse.controller
{
    class YouTubeBannerController
    {
        public static void GetData(DataGridView dataGridYoutubelink)
        {
            //set model to data gridviews
            dataGridYoutubelink.DataSource = models.YouTubeBannerModel.getYouTubeBannerAll();
        }

        public static void InsertData(models.YouTubeBannerModel model)
        {
            //show message box when cannot insert data
            MessageBox.Show((models.YouTubeBannerModel.insertYouTubeBanner(model)) ? "Insert Success" :
                "Insert Failed, Please Check parameter or something");

        }
        public static void UpdateData(models.YouTubeBannerModel model)
        {
            //show message box when cannot insert data
            MessageBox.Show((models.YouTubeBannerModel.updateYouTubeBanner(model)) ? "Insert Success" :
                "Insert Failed, Please Check parameter or something");
        }
        /** Call Add or Edit Industrial Form **/
        public static void CallAddEditForm(Form AddYouTubeBanner)
        {
            AddYouTubeBanner.ShowDialog();// show dialog.
        }

        public static void SetCustomerBox(ComboBox comboCuscode)
        {
            comboCuscode.DataSource = CustomerAdvertisingModel.getCustomerList(); // create datasource into combobox
            comboCuscode.DisplayMember = CustomerAdvertisingModel.ENTITY.NameEn; // set for display what to show.
            comboCuscode.ValueMember = CustomerAdvertisingModel.ENTITY.cusCode; // set for value member when selected.
        }
    }
}
