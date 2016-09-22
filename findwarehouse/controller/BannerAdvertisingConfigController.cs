using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace findwarehouse.controller
{
    class BannerAdvertisingConfigController
    {
        public static void GetData(DataGridView gridViewBannerAdvertisingConfig)
        {
            //set model to data gridviews
            gridViewBannerAdvertisingConfig.DataSource = models.BannerAdvertisingConfigModel.getBannerAdvertisingConfigAll();
        }
    }
}
