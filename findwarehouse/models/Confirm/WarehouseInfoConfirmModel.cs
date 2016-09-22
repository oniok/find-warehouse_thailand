using findwarehouse.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace findwarehouse.models
{
    /** WarehouseInfo Model **/
    class WarehouseInfoConfirmModel : IModel
    {
        /* Get Data as DataSource */
        public static BindingSource getWarehouseInfoConfirmAll()
        {
            Connector connector = Connector.getInstance();// connect database object
            BindingSource bindDatasource = new BindingSource();
            bindDatasource.DataSource = connector.GetData(connector.CreateCommand("get_AllWarehouseInfo"));//get data from database
            return bindDatasource;//return data grid data
        }

    }
}
