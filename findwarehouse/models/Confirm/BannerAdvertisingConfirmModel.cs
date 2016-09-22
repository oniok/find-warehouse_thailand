using findwarehouse.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace findwarehouse.models
{
    /** BannerAdvertisingConfirm Model **/
    class BannerAdvertisingConfirmModel : IModel
    {
        /* Get Data as DataSource */
        public static BindingSource getBannerAdvertisingConfirmAll()
        {
            Connector connector = Connector.getInstance();// connect database object
            BindingSource bindDatasource = new BindingSource();
            bindDatasource.DataSource = connector.GetData(connector.CreateCommand("get_AllBannerAdvertising"));//get data from database
            return bindDatasource;//return data grid data
        }

    }
}
