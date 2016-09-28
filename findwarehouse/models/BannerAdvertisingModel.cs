using findwarehouse.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace findwarehouse.models
{
     public class BannerAdvertisingModel :IModel
    {
        public BannerAdvertisingModel() { }
        public String Code { set; get; } // Industiral Code
        public String cusCode { set; get; } // Province Code
        public String banImg { set; get; } // Name English
        public String activeDate { set; get; } // Name Thai
        public String inActiveDate { set; get; } // Name Japan
        public Int16 Sequence { set; get; } // Sequence Number 


        /** Data Entity Class **/
        public static class ENTITY
        {
            public const String Code = "ADMEMBER_CODE";
            public const String cusCode = "CUSTOMER_CODE";
            public const String banImg = "BANNER_IMG";
            public const String activeDate = "ACTIVE_DATE";
            public const String inActiveDate = "INACTIVE_DATE";
            public const String Sequence = "SEQUENCE";
          
        }

        /* Get Data as DataSource */
        public static BindingSource getBannerAdvertising()
        {
            Connector connector = Connector.getInstance();// connect database object
            BindingSource bindDatasource = new BindingSource();
            //this may has some error when use stroed procedure please use direct query instread
            bindDatasource.DataSource = connector.GetData(connector.CreateCommand("ssc_warehouse_get_left_banner_all"));//get data from database
            connector.CloseDatabase(); // close database after commit
            return bindDatasource;//return data grid data
        }

        public static bool insertBannerAdvertising(BannerAdvertisingModel model)
        {
            Connector connector = Connector.getInstance(); // connect database object
            Dictionary<String, Object> parameter = new Dictionary<string, object>(); //new parameter object
            parameter.Add("cusCode", (Object)model.cusCode); // add parameter province
            parameter.Add("banImg", (Object)model.banImg); // add parameter name english 
            parameter.Add("activeDate", (Object)model.activeDate); // add parameter name Thai
            parameter.Add("inActiveDate", (Object)model.inActiveDate); // add paramter name japan
           
            if (connector.InsertUpdateData(connector.CreateCommand("ssc_warehouse_add_left_banner", parameter))) //excecute insert command
                return true; // return true when execute command succes.
            connector.CloseDatabase();// close database after commit.
            return false; // return false when cannot execute command.
        }

        public static bool updateBannerAdvertising(BannerAdvertisingModel model)
        {
            Connector connector = Connector.getInstance(); // connect database object
            Dictionary<String, Object> parameter = new Dictionary<string, object>(); //new parameter object
            parameter.Add("recId", (Object)model.Code);
            parameter.Add("cusCode", (Object)model.cusCode); // add parameter province
            parameter.Add("banImg", (Object)model.banImg); // add parameter name english 
            parameter.Add("SEQUENCE", (Object)model.Sequence); // add parameter name english 
            parameter.Add("activeDate", (Object)model.activeDate); // add parameter name Thai
            parameter.Add("inActiveDate", (Object)model.inActiveDate); // add paramter name japan
           
            if (connector.InsertUpdateData(connector.CreateCommand("ssc_warehouse_update_left_banner", parameter))) //excecute insert command
                return true; // return true when execute command succes.
            connector.CloseDatabase();// close database after commit.
            return false; // return false when cannot execute command.
        }
    }
}
