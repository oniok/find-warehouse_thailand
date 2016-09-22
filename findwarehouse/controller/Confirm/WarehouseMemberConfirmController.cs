using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace findwarehouse.controller
{
    class WarehouseMemberConfirmController
    {
        public static void GetData(DataGridView gridViewWarehouseMemberConfirm)
        {
            //set model to data gridviews
            gridViewWarehouseMemberConfirm.DataSource = models.WarehouseMemberConfirmModel.getWarehouseMemberConfirmAll();
        }
    }
}
