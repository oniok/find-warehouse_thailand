using findwarehouse.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
namespace findwarehouse.models
{
    public class WarehouseUsageTypeModel :IModel
    {

        public WarehouseUsageTypeModel() { }
        public String UsagetypeCode { set; get; } // Usage Type Code
        public String NameEng { set; get; } // Province English
        public String NameThai { set; get; } // Name Thai
        public String NameJP { set; get; } // Name Japan

        public static class ENTITY
        {
            public const String UsagetypeCode = "USAGETYPE_CODE";
            public const String NameEng = "NAME_ENG";
            public const String NameThai = "NAME_THA";
            public const String NameJP = "NAME_JPN";
            
        }

        public static System.Data.DataTable getUsagetypeCodelList()
        {
            Connector connector = Connector.getInstance();// connect database object
            return connector.GetData(connector.CreateCommand("ssc_warehouse_get_warehouse_usage_type"));//get data from database
        }
    }
}
