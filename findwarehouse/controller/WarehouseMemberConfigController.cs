using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace findwarehouse.controller
{
    class WarehouseMemberConfigController
    {
        public static void GetData(DataGridView gridViewWarehouseMemberConfig)
        {
            //set model to data gridviews
            gridViewWarehouseMemberConfig.DataSource = models.WarehouseMemberConfigModel.getWarehouseMemberConfigAll();
        }
    }
}
