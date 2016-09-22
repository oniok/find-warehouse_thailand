using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace findwarehouse.controller
{
    class WarehouseInfoConfirmController
    {
        public static void GetData(DataGridView gridViewWarehouseInfoConfirm)
        {
            //set model to data gridviews
            gridViewWarehouseInfoConfirm.DataSource = models.WarehouseInfoConfirmModel.getWarehouseInfoConfirmAll();
        }
    }
}
