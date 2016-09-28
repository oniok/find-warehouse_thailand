using findwarehouse.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace findwarehouse.models
{
    public class RightBannerModel
    {
        public RightBannerModel() { }
        public String adsMember { set; get; } // Industiral Code
        public String cateId { set; get; } // Province Code
        public String ProfileEn { set; get; } // Name English
        public String ProfileTh { set; get; } // Name Thai
        public String ProfileJp { set; get; } // Name Japan
        public String CompanyEn { set; get; } // Industiral Code
        public String CompanyTh { set; get; } // Province Code
        public String CompanyJp { set; get; } // Name English
        public String ContactEn { set; get; } // Name Thai
        public String ContactTh { set; get; } // Name Japan
        public String ContactJp { set; get; } // Province Code
        public String Uri { set; get; } // Name English
        public String ActiveDate { set; get; } // Name Thai
        public String InActiveDate { set; get; } // Name Japan
        public Int16 Sequence { set; get; } // Sequence Number 


        /** Data Entity Class **/
        public static class ENTITY
        {
            public const String adsMember = "ADMEMBER_CODE";
            public const String cateId = "CATEGORY";
            public const String ProfileEn = "PROFILE_ENG";
            public const String ProfileTh = "PROFILE_THA";
            public const String ProfileJp = "PROFILE_JPN";
            public const String CompanyEn = "COMPANYNAME_ENG";
            public const String CompanyTh = "COMPANYNAME_THA";
            public const String CompanyJp = "COMPANYNAME_JPY";
            public const String ContactEn = "CONTACTNAME_ENG";
            public const String ContactTh = "CONTACTNAME_THA";
            public const String ContactJp = "CONTACTNAME_JPY";
            public const String Uri = "URL";
            public const String ActiveDate = "ACTIVE_DATE";
            public const String InActiveDate = "INACTIVE_DATE";
            public const String Sequence = "SEQUENCE";

        }

        /* Get Data as DataSource */
        public static BindingSource getRightBanner()
        {
            Connector connector = Connector.getInstance();// connect database object
            BindingSource bindDatasource = new BindingSource();
            //this may has some error when use stroed procedure please use direct query instread
            bindDatasource.DataSource = connector.GetData(connector.CreateCommand("ssc_warehouse_get_right_banner_all"));//get data from database
            connector.CloseDatabase(); // close database after commit
            return bindDatasource;//return data grid data
        }


        public static bool insertRightBanner(RightBannerModel model)
        {
            Connector connector = Connector.getInstance(); // connect database object
            Dictionary<String, Object> parameter = new Dictionary<string, object>(); //new parameter object
            parameter.Add("adsMember", (Object)model.adsMember); // add parameter name english 
            parameter.Add("cateId", (Object)model.cateId); // add parameter province
            parameter.Add("ProfileEn", (Object)model.ProfileEn); // add parameter name english 
            parameter.Add("ProfileTh", (Object)model.ProfileTh); // add parameter name Thai
            parameter.Add("ProfileJp", (Object)model.ProfileJp); // add paramter name japan
            parameter.Add("CompanyEn", (Object)model.CompanyEn); // add parameter province
            parameter.Add("CompanyTh", (Object)model.CompanyTh); // add parameter name english 
            parameter.Add("CompanyJp", (Object)model.CompanyJp); // add parameter name Thai
            parameter.Add("ContactEn", (Object)model.ContactEn); // add paramter name japan
            parameter.Add("ContactTh", (Object)model.ContactTh); // add parameter province
            parameter.Add("ContactJp", (Object)model.ContactJp); // add parameter name english 
            parameter.Add("Uri", (Object)model.Uri); // add parameter name Thai
            parameter.Add("ActiveDate", (Object)model.ActiveDate); // add paramter name japan
            parameter.Add("InActiveDate", (Object)model.InActiveDate); // add parameter province
           

            if (connector.InsertUpdateData(connector.CreateCommand("ssc_warehouse_add_right_banner", parameter))) //excecute insert command
                return true; // return true when execute command succes.
            connector.CloseDatabase();// close database after commit.
            return false; // return false when cannot execute command.
        }

        public static bool updateRightBanner(RightBannerModel model)
        {
            Connector connector = Connector.getInstance(); // connect database object
            Dictionary<String, Object> parameter = new Dictionary<string, object>(); //new parameter object
            parameter.Add("adsMember", (Object)model.adsMember); // add parameter name english 
            parameter.Add("cateId", (Object)model.cateId); // add parameter province
            parameter.Add("ProfileEn", (Object)model.ProfileEn); // add parameter name english 
            parameter.Add("ProfileTh", (Object)model.ProfileTh); // add parameter name Thai
            parameter.Add("ProfileJp", (Object)model.ProfileJp); // add paramter name japan
            parameter.Add("CompanyEn", (Object)model.CompanyEn); // add parameter province
            parameter.Add("CompanyTh", (Object)model.CompanyTh); // add parameter name english 
            parameter.Add("CompanyJp", (Object)model.CompanyJp); // add parameter name Thai
            parameter.Add("ContactEn", (Object)model.ContactEn); // add paramter name japan
            parameter.Add("ContactTh", (Object)model.ContactTh); // add parameter province
            parameter.Add("ContactJp", (Object)model.ContactJp); // add parameter name english 
            parameter.Add("Uri", (Object)model.Uri); // add parameter name Thai
            parameter.Add("ActiveDate", (Object)model.ActiveDate); // add paramter name japan
            parameter.Add("InActiveDate", (Object)model.InActiveDate); // add parameter province
            parameter.Add("SEQUENCE", (Object)model.Sequence); // add parameter province

            if (connector.InsertUpdateData(connector.CreateCommand("ssc_warehouse_update_right_banner", parameter))) //excecute insert command
                return true; // return true when execute command succes.
            connector.CloseDatabase();// close database after commit.
            return false; // return false when cannot execute command.
        }
    }

}
