using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace findwarehouse.controller
{
    class AdvertisingCustConfirmController
    {
        public static void GetData(DataGridView gridViewAdvertisingCustConfirm)
        {
            //set model to data gridviews
            gridViewAdvertisingCustConfirm.DataSource = models.AdvertisingCustConfirmModel.getAdvertisingCustConfirmAll();
        }
    }
}
