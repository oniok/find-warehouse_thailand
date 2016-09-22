using findwarehouse.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace findwarehouse.models
{
    /** WarehouseMember Model **/
    class WarehouseMemberConfirmModel : IModel
    {
        /* Get Data as DataSource */
        public static BindingSource getWarehouseMemberConfirmAll()
        {
            Connector connector = Connector.getInstance();// connect database object
            BindingSource bindDatasource = new BindingSource();
            bindDatasource.DataSource = connector.GetData(connector.CreateCommand("get_AllWarehouseMember"));//get data from database
            return bindDatasource;//return data grid data
        }

    }
}
