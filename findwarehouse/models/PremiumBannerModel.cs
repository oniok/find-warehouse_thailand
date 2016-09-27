using findwarehouse.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace findwarehouse.models
{
    /** PremiumBanner Model **/
    public class PremiumBannerModel :IModel
    {
        public PremiumBannerModel() { }
        public String memberCode { set; get; } // Industiral Code
        public String adImg { set; get; } // Province Code
        public String adPath { set; get; } // Name English
        public String activeDate { set; get; } // Name Thai
        public String InActiveDate { set; get; } // Name Japan
        public Int16 Sequence { set; get; } // Sequence Number 

        /** Data Entity Class **/
        public static class ENTITY
        {
            public const String memberCode = "MEMBER_CODE";
            public const String adImg = "AD_IMG";
            public const String adPath = "URL";
            public const String activeDate = "ACTIVE_DATE";
            public const String InActiveDate = "INACTIVE_DATE";
            public const String Sequence = "SEQUENCE";
           
        }

        /* Get Data as DataSource */
        public static BindingSource getPremiumBannerAll()
        {
            Connector connector = Connector.getInstance();// connect database object
            BindingSource bindDatasource = new BindingSource();
            //this may has some error when use stroed procedure please use direct query instread
            bindDatasource.DataSource = connector.GetData(connector.CreateCommand("ssc_warehouse_get_premium_banner_all"));//get data from database
            connector.CloseDatabase(); // close database after commit
            return bindDatasource;//return data grid data
        }


        /* Insert Data 
        * @Param PremiumBannerModel as model
        * @return Result as bool
        */
        public static bool insertPremiumBanner(PremiumBannerModel model)
        {
            Connector connector = Connector.getInstance(); // connect database object
            Dictionary<String, Object> parameter = new Dictionary<string, object>(); //new parameter object
            parameter.Add("memberCode", (Object)model.memberCode); // add parameter province
            parameter.Add("adImg", (Object)model.adImg); // add parameter name english 
            parameter.Add("adPath", (Object)model.adPath); // add parameter name Thai
            parameter.Add("activeDate", (Object)model.activeDate); // add paramter name japan
            parameter.Add("InActiveDate", (Object)model.InActiveDate); // add parameter search key
            if (connector.InsertUpdateData(connector.CreateCommand("ssc_warehouse_add_premium_banner", parameter))) //excecute insert command
                return true; // return true when execute command succes.
            connector.CloseDatabase();// close database after commit.
            return false; // return false when cannot execute command.
        }


        public static bool updatePremiumBanner(PremiumBannerModel model)
        {
            Connector connector = Connector.getInstance(); // connect database object
            Dictionary<String, Object> parameter = new Dictionary<string, object>(); //new parameter object
            parameter.Add("memberCode", (Object)model.memberCode);
            parameter.Add("adImg", (Object)model.adImg); // add parameter province
            parameter.Add("adPath", (Object)model.adPath); // add parameter name english 
            parameter.Add("activeDate", (Object)model.activeDate); // add parameter name Thai
            parameter.Add("InActiveDate", (Object)model.InActiveDate); // add paramter name japan
            if (connector.InsertUpdateData(connector.CreateCommand("ssc_warehouse_update_premium_banner", parameter))) //excecute insert command
                return true; // return true when execute command succes.
            connector.CloseDatabase();// close database after commit.
            return false; // return false when cannot execute command.
        }


    }
}
