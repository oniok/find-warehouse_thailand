using findwarehouse.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
namespace findwarehouse.models
{
    public class WarehousememberModel :IModel
    {
        public WarehousememberModel() { }
        public String Code { set; get; } // Industiral Code
        public String flag { set; get; } // flag Code
        public String countryCode { set; get; } // Country Code
        public String nameEn { set; get; } // Name English
        public String addr { set; get; } // Address
        public String tel { set; get; } // Tel
        public String  mob { set; get; } // Mobile 
        public String contactName { set; get; } // Contact
        public String email { set; get; } // Email
        public String url { set; get; } // URL
        public String regDate { set; get; } // Register Date
        public String expireDate { set; get; } // Expire Date
        public String updDate { set; get; } // Update Date
        public String searchKey { set; get; } // Search Key



        public static class ENTITY
        {
            public const String Code = "MEMBER_CODE";
            public const String flag = "PREMIUM_FLG";
            public const String countryCode = "COUNTRY_CODE";
            public const String nameEn = "NAME_ENG";
            public const String addr = "ADDRESS_ENG";
            public const String tel = "TEL";
            public const String mob = "MOBILE";
            public const String contactName = "CONTACTPERSON_NAME";
            public const String email = "EMAIL";
            public const String url = "URL";
            public const String regDate = "REGISTRATION_DATE";
            public const String expireDate = "EXPIRE_DATE";
            public const String updDate = "UPDATEEXPIRE_DATE";
            public const String searchKey = "Search_keyword";
            
        }

        /* Get Data as DataSource */
        public static BindingSource getWherehouseMember()
        {
            Connector connector = Connector.getInstance();// connect database object
            BindingSource bindDatasource = new BindingSource();
            //this may has some error when use stroed procedure please use direct query instread
            bindDatasource.DataSource = connector.GetData(connector.CreateCommand("ssc_warehouse_get_warehousemember_all"));//get data from database
            return bindDatasource;//return data grid data
        }

        /* Insert Data 
         * @Param WherehouseMember as model
         * @return Result as bool
         */
        public static bool InsertWherehousMember(WarehousememberModel model)
        {
            Connector connector = Connector.getInstance(); // connect database object
            Dictionary<String, Object> parameter = new Dictionary<string, object>(); //new parameter object
            parameter.Add("flag", (Object)model.flag); // add parameter flag
            parameter.Add("countryCode", (Object)model.countryCode); // add parameter Country Code
            parameter.Add("nameEn", (Object)model.nameEn); // add parameter name English
            parameter.Add("addr", (Object)model.addr); // add paramter Address
            parameter.Add("tel", (Object)model.tel); // add parameter Tel
            parameter.Add("mob", (Object)model.mob); // add parameter Mobile
            parameter.Add("contactName", (Object)model.contactName); // add parameter Contract Name
            parameter.Add("email", (Object)model.email); // add parameter Email
            parameter.Add("url", (Object)model.url); // add paramter URL
            parameter.Add("regDate", (Object)model.regDate); // add parameter Register Date
            parameter.Add("expireDate", (Object)model.expireDate); // add paramter Expire Date
            parameter.Add("updDate", (Object)model.updDate); // add paramter Update Date
            parameter.Add("searchKey", (Object)model.searchKey); // add parameter search key
            if (connector.InsertUpdateData(connector.CreateCommand("ssc_warehouse_add_warehousemember", parameter))) //excecute insert command
                return true; // return true when execute command succes.
            return false; // return false when cannot execute command.
        }

        public static bool updateWarehousemember(WarehousememberModel model)
        {
            Connector connector = Connector.getInstance(); // connect database object
            Dictionary<String, Object> parameter = new Dictionary<string, object>(); //new parameter object
            parameter.Add("Code", (Object)model.Code);
            parameter.Add("flag", (Object)model.flag); // add parameter province
            parameter.Add("countryCode", (Object)model.countryCode); // add parameter name english 
            parameter.Add("nameEn", (Object)model.nameEn); // add parameter name Thai
            parameter.Add("addr", (Object)model.addr); // add paramter name japan
            parameter.Add("tel", (Object)model.tel); // add parameter search key
            parameter.Add("mob", (Object)model.mob);
            parameter.Add("contactName", (Object)model.contactName); // add parameter province
            parameter.Add("email", (Object)model.email); // add parameter name english 
            parameter.Add("url", (Object)model.url); // add parameter name Thai
            parameter.Add("regDate", model.regDate.ToString()); // add paramter name japan
            parameter.Add("expireDate", (Object)model.expireDate); // add parameter search key
            parameter.Add("updDate",(Object)model.updDate); // add parameter name Thai
            parameter.Add("searchKey", (Object)model.searchKey); // add paramter name japan
           
            if (connector.InsertUpdateData(connector.CreateCommand("ssc_warehouse_update_warehousemember", parameter))) //excecute insert command
                return true; // return true when execute command succes.
            connector.CloseDatabase();// close database after commit.
            return false; // return false when cannot execute command.
        }
    }
}
