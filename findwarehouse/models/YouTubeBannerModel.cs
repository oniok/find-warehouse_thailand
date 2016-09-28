using findwarehouse.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace findwarehouse.models
{
    public class YouTubeBannerModel :IModel
    {
        public YouTubeBannerModel() { }
        public String Code { set; get; } // Industiral Code
        public String customerCode { set; get; } // Province Code
        public String YtUri { set; get; } // Name English
        public String ActiveDate { set; get; } // Name Thai
        public String InActiveDate { set; get; } // Name Japan


        /** Data Entity Class **/
        public static class ENTITY
        {
            public const String Code = "YTAD_CODE";
            public const String customerCode = "CUSTOMER_CODE";
            public const String YtUri = "YOUTUBE_URL";
            public const String ActiveDate = "ACTIVE_DATE";
            public const String InActiveDate = "INACTIVE_DATE";
           
        }

        /* Get Data as DataSource */
        public static BindingSource getYouTubeBannerAll()
        {
            Connector connector = Connector.getInstance();// connect database object
            BindingSource bindDatasource = new BindingSource();
            //this may has some error when use stroed procedure please use direct query instread
            bindDatasource.DataSource = connector.GetData(connector.CreateCommand("ssc_warehouse_get_YouTubeBanner_random_one"));//get data from database
            connector.CloseDatabase(); // close database after commit
            return bindDatasource;//return data grid data
        }

        /* Insert Data 
         * @Param IndustrialModel as model
         * @return Result as bool
         */
        public static bool insertYouTubeBanner(YouTubeBannerModel model)
        {

            Connector connector = Connector.getInstance(); // connect database object
            Dictionary<String, Object> parameter = new Dictionary<string, object>(); //new parameter object
            parameter.Add("customerCode", (Object)model.customerCode); // add parameter province
            parameter.Add("YtUri", (Object)model.YtUri); // add parameter name english 
            parameter.Add("ActiveDate", (Object)model.ActiveDate); // add parameter name Thai
            parameter.Add("InActiveDate", (Object)model.InActiveDate); // add paramter name japan
   
            if (connector.InsertUpdateData(connector.CreateCommand("ssc_warehouse_add_youtube_banner", parameter))) //excecute insert command
                return true; // return true when execute command succes.
            connector.CloseDatabase();// close database after commit.
            return false; // return false when cannot execute command.
        }

        public static bool updateYouTubeBanner(YouTubeBannerModel model)
        {

            Connector connector = Connector.getInstance(); // connect database object
            Dictionary<String, Object> parameter = new Dictionary<string, object>(); //new parameter object
            parameter.Add("Code", (Object)model.Code);
            parameter.Add("customerCode", (Object)model.customerCode); // add parameter province
            parameter.Add("YtUri", (Object)model.YtUri); // add parameter name english 
            parameter.Add("ActiveDate", (Object)model.ActiveDate); // add parameter name Thai
            parameter.Add("InActiveDate", (Object)model.InActiveDate); // add paramter name japan
          
            if (connector.InsertUpdateData(connector.CreateCommand("ssc_warehouse_update_youtube_banner", parameter))) //excecute insert command
                return true; // return true when execute command succes.
            connector.CloseDatabase();// close database after commit.
            return false; // return false when cannot execute command.
        }
    }
}
