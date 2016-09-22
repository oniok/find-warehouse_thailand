using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace findwarehouse.controller
{
    class BannerAdvertisingConfirmController
    {
        public static void GetData(DataGridView gridViewBannerAdvertisingConfirm)
        {
            //set model to data gridviews
            gridViewBannerAdvertisingConfirm.DataSource = models.BannerAdvertisingConfirmModel.getBannerAdvertisingConfirmAll();
        }
    }
}
