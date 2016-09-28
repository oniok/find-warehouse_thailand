using findwarehouse.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace findwarehouse.models
{
    class categorytype
    {

        public categorytype() { }
        public String ID { set; get; } // Industiral Code
        public String NAME_EN { set; get; } // Province Code
        public String NAME_TH { set; get; } // Name English
        public String NAME_JP { set; get; } // Name Thai


        /** Data Entity Class **/
        public static class ENTITY
        {
            public const String ID = "ID";
            public const String NAME_EN = "NAME_EN";
            public const String NAME_TH = "NAME_TH";
            public const String NAME_JP = "NAME_JP";
            
        }


        /* Get Data as DataSource */
        public static BindingSource getTypeAll()
        {
            Connector connector = Connector.getInstance();// connect database object
            BindingSource bindDatasource = new BindingSource();
            //this may has some error when use stroed procedure please use direct query instread
            bindDatasource.DataSource = connector.GetData(connector.CreateCommand("	ssc_warehouse_get_categorytype_all"));//get data from database
            connector.CloseDatabase(); // close database after commit
            return bindDatasource;//return data grid data
        }


        public static System.Data.DataTable getTypeList()
        {
            Connector connector = Connector.getInstance();// connect database object
            return connector.GetData(connector.CreateCommand("ssc_warehouse_get_categorytype_all"));//get data from database
        }
    }
}
