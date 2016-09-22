using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace findwarehouse.controller
{
    class CategoryBannerConfigController
    {
        public static void GetData(DataGridView gridViewCategoryBannerConfig)
        {
            //set model to data gridviews
            gridViewCategoryBannerConfig.DataSource = models.CategoryBannerConfigModel.getCategoryBannerConfigAll();
        }
    }
}
