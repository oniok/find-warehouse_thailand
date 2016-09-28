using findwarehouse.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace findwarehouse.models 
{
    public class CustomerAdvertisingModel :IModel
    {
        public CustomerAdvertisingModel() { }
        public String cusCode { set; get; } // Industiral Code
        public String contryCode { set; get; } // Industiral Code
        public String NameEn { set; get; } // flag Code
        public String AddressEn { set; get; } // Country Code
        public String tel { set; get; } // Name English
        public String mob { set; get; } // Address
        public String contactEn { set; get; } // Tel
        public String mail { set; get; } // Mobile 
        public String url { set; get; } // Contact
        public String regDate { set; get; } // Email
        public String expireDate { set; get; } // URL
        public String upExpireDate { set; get; } // Register Date
       



        public static class ENTITY
        {
            public const String cusCode = "ADMEMBER_CODE";
            public const String contryCode = "COUNTRY_CODE";
            public const String NameEn = "NAME_ENG";
            public const String AddressEn = "ADDRESS_ENG";
            public const String tel = "TEL";
            public const String mob = "MOBILE";
            public const String contactEn = "CONTACTNAME_EN";
            public const String mail = "EMAIL";
            public const String url = "MEMBER_URL";
            public const String regDate = "REGISTER_DATE";
            public const String expireDate = "EXPIRE_DATE";
            public const String upExpireDate = "UPDATEEXPIRE_DATE";

        }

        /* Get Data as DataSource */
        public static BindingSource getCustomerAdvertising()
        {
            Connector connector = Connector.getInstance();// connect database object
            BindingSource bindDatasource = new BindingSource();
            //this may has some error when use stroed procedure please use direct query instread
            bindDatasource.DataSource = connector.GetData(connector.CreateCommand("ssc_warehouse_get_customer_advertising_all"));//get data from database
            return bindDatasource;//return data grid data
        }

        /* Insert Data 
         * @Param CustomerAdvertising as model
         * @return Result as bool
         */
        public static bool InsertCustomerAdvertising(CustomerAdvertisingModel model)
        {
            Connector connector = Connector.getInstance(); // connect database object
            Dictionary<String, Object> parameter = new Dictionary<string, object>(); //new parameter object
            //parameter.Add("cusCode", (Object)model.cusCode);
            parameter.Add("contryCode", (Object)model.contryCode); // add parameter Country Code
            parameter.Add("NameEn", (Object)model.NameEn); // add parameter name English
            parameter.Add("AddressEn", (Object)model.AddressEn); // add paramter Address
            parameter.Add("tel", (Object)model.tel); // add parameter Tel
            parameter.Add("mob", (Object)model.mob); // add parameter Mobile
            parameter.Add("contactEn", (Object)model.contactEn); // add parameter Contract Name
            parameter.Add("mail", (Object)model.mail); // add parameter Email
            parameter.Add("url", (Object)model.url); // add paramter URL
            parameter.Add("regDate", (Object)model.regDate); // add parameter Register Date
            parameter.Add("expireDate", (Object)model.expireDate); // add paramter Expire Date
            parameter.Add("upExpireDate", (Object)model.upExpireDate); // add paramter Update Date
          
            if (connector.InsertUpdateData(connector.CreateCommand("ssc_warehouse_add_customer_advertising", parameter))) //excecute insert command
                return true; // return true when execute command succes.
            return false; // return false when cannot execute command.
        }

        public static bool updateCustomerAdvertising(CustomerAdvertisingModel model)
        {
            Connector connector = Connector.getInstance(); // connect database object
            Dictionary<String, Object> parameter = new Dictionary<string, object>(); //new parameter object
            parameter.Add("cusCode", (Object)model.cusCode);
            parameter.Add("contryCode", (Object)model.contryCode); // add parameter province
            parameter.Add("NameEn", (Object)model.NameEn); // add parameter name english 
            parameter.Add("AddressEn", (Object)model.AddressEn); // add parameter name Thai
            parameter.Add("tel", (Object)model.tel); // add paramter name japan
            parameter.Add("mob", (Object)model.mob); // add parameter search key
            parameter.Add("contactEn", (Object)model.contactEn);
            parameter.Add("mail", (Object)model.mail); // add parameter province
            parameter.Add("url", (Object)model.url); // add parameter name english 
            parameter.Add("regDate", (Object)model.regDate); // add parameter name Thai
            parameter.Add("expireDate", (Object)model.regDate.ToString()); // add paramter name japan
            parameter.Add("upExpireDate", (Object)model.expireDate); // add parameter search key
          
         

            if (connector.InsertUpdateData(connector.CreateCommand("ssc_warehouse_update_customer_advertising", parameter))) //excecute insert command
                return true; // return true when execute command succes.
            connector.CloseDatabase();// close database after commit.
            return false; // return false when cannot execute command.
        }

        public static System.Data.DataTable getCustomerList()
        {
            Connector connector = Connector.getInstance();// connect database object
            return connector.GetData(connector.CreateCommand("ssc_warehouse_get_customer_advertising_all"));//get data from database
        }
    }
}
