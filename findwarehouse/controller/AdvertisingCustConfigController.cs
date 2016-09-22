using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace findwarehouse.controller
{
    class AdvertisingCustConfigController
    {
        public static void GetData(DataGridView gridViewAdvertisingCustConfig)
        {
            //set model to data gridviews
            gridViewAdvertisingCustConfig.DataSource = models.AdvertisingCustConfigModel.getAdvertisingCustConfigAll();
        }
    }
}
