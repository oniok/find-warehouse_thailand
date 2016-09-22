using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace findwarehouse.controller
{
    class WarehouseInfoConfigController
    {
        public static void GetData(DataGridView gridViewWarehouseInfoConfig)
        {
            //set model to data gridviews
            gridViewWarehouseInfoConfig.DataSource = models.WarehouseInfoConfigModel.getWarehouseInfoConfigAll();
        }
    }
}
