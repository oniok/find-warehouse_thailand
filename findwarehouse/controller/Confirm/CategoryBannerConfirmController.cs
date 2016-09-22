using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace findwarehouse.controller
{
    class CategoryBannerConfirmController
    {
        public static void GetData(DataGridView gridViewCategoryBannerConfirm)
        {
            //set model to data gridviews
            gridViewCategoryBannerConfirm.DataSource = models.CategoryBannerConfirmModel.getCategoryBannerConfirmAll();
        }
    }
}
