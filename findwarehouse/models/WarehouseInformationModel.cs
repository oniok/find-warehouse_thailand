using findwarehouse.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace findwarehouse.models
{
    public class WarehouseInformationModel
    {

        public WarehouseInformationModel() { }
        public String memberCode { set; get; } // Industiral Code
        public String manageno { set; get; } // Industiral Code
        public String provinceCode { set; get; } // flag Code
        public String industrialCode { set; get; } // Country Code
        public String usageType { set; get; } // Name English
        public String lat { set; get; } // Address
        public String lng { set; get; } // Tel
        public String catGl { set; get; } // Mobile 
        public String catBon { set; get; } // Contact
        public String catExp { set; get; } // Email
        public String catFrz { set; get; } // URL
        public String catRefri { set; get; } // Register Date
        public String catHeav { set; get; } // Industiral Code
        public String catX { set; get; } // Industiral Code
        public String nameEn { set; get; } // flag Code
        public String nameTh { set; get; } // Country Code
        public String nameJp { set; get; } // Name English
        public String addr { set; get; } // Address
        public String tel { set; get; } // Tel
        public String contactEn { set; get; } // Mobile 
        public String contactTh { set; get; } // Contact
        public String contactJp { set; get; } // Email
        public String desEn { set; get; } // URL
        public String desTh { set; get; } // Register Date
        public String desJp { set; get; } // Mobile 
        public String regDate { set; get; } // Contact
        public String activeDate { set; get; } // Email
        public String InActiveDate { set; get; } // URL
        public Int16 SEQ { set; get; } // URL


        public static class ENTITY
        {
            public const String memberCode = "MEMBER_CODE";
            public const String manageno = "MANAGE_NO";
            public const String provinceCode = "PROVINCE_CODE";
            public const String industrialCode = "INDUSTRIAL_CODE";
            public const String usageType = "USAGE_TYPE";
            public const String lat = "LOCATION_LAT";
            public const String lng = "LOCATION_LNG";
            public const String catGl = "CAT_GENERAL";
            public const String catBon = "CAT_BONDED";
            public const String catExp = "CAT_EXPLOSIVES";
            public const String catFrz = "CAT_FREEZE";
            public const String catRefri = "CAT_REFRIGERATION";
            public const String catHeav = "CAT_HEAVEIS";
            public const String catX = "CAT_XXX";
            public const String nameEn = "WAREHOUSENAME_ENG";
            public const String nameTh = "WAREHOUSENAME_THA";
            public const String nameJp = "WAREHOUSENAME_JPN";
            public const String addr = "WAREHOUSE_ADDRESS";
            public const String tel = "CONTACT_TEL";
            public const String contactEn = "CONTACTNAME_ENG";
            public const String contactTh = "CONTACTNAME_THA";
            public const String contactJp = "CONTACTNAME_JPN";
            public const String desEn = "DESCRIPTION_ENG";
            public const String desTh = "DESCRIPTION_THA";
            public const String desJp = "	DESCRIPTION_JPY";
            public const String regDate = "REGISTER_DATE";
            public const String activeDate = "ACTIVE_DATE";
            public const String InActiveDate = "INACTIVE_DATE";
            public const String SEQ = "SEQUENCE";

        }


        /* Get Data as DataSource */
        public static BindingSource getWarehouseInformation()
        {
            Connector connector = Connector.getInstance();// connect database object
            BindingSource bindDatasource = new BindingSource();
            //this may has some error when use stroed procedure please use direct query instread
            bindDatasource.DataSource = connector.GetData(connector.CreateCommand("ssc_warehouse_get_warehouseinformation_all"));//get data from database
            connector.CloseDatabase(); // close database after commit
            return bindDatasource;//return data grid data
        }


        /* Insert Data 
        * @Param IndustrialModel as model
        * @return Result as bool
        */
        public static bool insertWarehouseInformation(WarehouseInformationModel model)
        {
            Connector connector = Connector.getInstance(); // connect database object
            Dictionary<String, Object> parameter = new Dictionary<string, object>(); //new parameter object
            parameter.Add("memberCode", (Object)model.memberCode); // add parameter province
            parameter.Add("provinceCode", (Object)model.provinceCode); // add parameter name english 
            parameter.Add("industrialCode", (Object)model.industrialCode); // add parameter name Thai
            parameter.Add("usageType", (Object)model.usageType); // add paramter name japan
            parameter.Add("lat", (Object)model.lat); // add parameter search key
            parameter.Add("lng", (Object)model.lng); // add parameter province
            parameter.Add("catGl", (Object)model.catGl); // add parameter name english 
            parameter.Add("catBon", (Object)model.catBon); // add parameter name Thai
            parameter.Add("catExp", (Object)model.catExp); // add paramter name japan
            parameter.Add("catFrz", (Object)model.catFrz); // add parameter search key
            parameter.Add("catRefri", (Object)model.catRefri); // add parameter province
            parameter.Add("catHeav", (Object)model.catHeav); // add parameter name english 
            parameter.Add("catX", (Object)model.catX); // add parameter name Thai
            parameter.Add("nameEn", (Object)model.nameEn); // add paramter name japan
            parameter.Add("nameTh", (Object)model.nameTh); // add parameter search key
            parameter.Add("nameJp", (Object)model.nameJp); // add parameter province
            parameter.Add("addr", (Object)model.addr); // add parameter name english 
            parameter.Add("tel", (Object)model.tel); // add parameter name Thai
            parameter.Add("contactEn", (Object)model.contactEn); // add paramter name japan
            parameter.Add("contactTh", (Object)model.contactTh); // add parameter search key
            parameter.Add("contactJp", (Object)model.contactJp); // add paramter name japan
            parameter.Add("desEn", (Object)model.desEn); // add parameter search key
            parameter.Add("desTh", (Object)model.desTh); // add parameter province
            parameter.Add("desJp", (Object)model.desJp); // add parameter name english 
            parameter.Add("regDate", (Object)model.regDate); // add parameter name Thai
            parameter.Add("activeDate", (Object)model.activeDate); // add paramter name japan
            parameter.Add("InActiveDate", (Object)model.InActiveDate); // add parameter search key
            if (connector.InsertUpdateData(connector.CreateCommand("ssc_warehouse_add_warehouseinformation", parameter))) //excecute insert command
                return true; // return true when execute command succes.
            connector.CloseDatabase();// close database after commit.
            return false; // return false when cannot execute command.
        }

        public static bool updateWarehouseInformation(WarehouseInformationModel model)
        {
            Connector connector = Connector.getInstance(); // connect database object
            Dictionary<String, Object> parameter = new Dictionary<string, object>(); //new parameter object
            parameter.Add("memberCode", (Object)model.memberCode); // add parameter province
            parameter.Add("manageno", (Object)model.manageno); // add parameter province
            parameter.Add("provinceCode", (Object)model.provinceCode); // add parameter name english 
            parameter.Add("industrialCode", (Object)model.industrialCode); // add parameter name Thai
            parameter.Add("usageType", (Object)model.usageType); // add paramter name japan
            parameter.Add("lat", (Object)model.lat); // add parameter search key
            parameter.Add("lng", (Object)model.lng); // add parameter province
            parameter.Add("catGl", (Object)model.catGl); // add parameter name english 
            parameter.Add("catBon", (Object)model.catBon); // add parameter name Thai
            parameter.Add("catExp", (Object)model.catExp); // add paramter name japan
            parameter.Add("catFrz", (Object)model.catFrz); // add parameter search key
            parameter.Add("catRefri", (Object)model.catRefri); // add parameter province
            parameter.Add("catHeav", (Object)model.catHeav); // add parameter name english 
            parameter.Add("catX", (Object)model.catX); // add parameter name Thai
            parameter.Add("nameEn", (Object)model.nameEn); // add paramter name japan
            parameter.Add("nameTh", (Object)model.nameTh); // add parameter search key
            parameter.Add("nameJp", (Object)model.nameJp); // add parameter province
            parameter.Add("addr", (Object)model.addr); // add parameter name english 
            parameter.Add("tel", (Object)model.tel); // add parameter name Thai
            parameter.Add("contactEn", (Object)model.contactEn); // add paramter name japan
            parameter.Add("contactTh", (Object)model.contactTh); // add parameter search key
            parameter.Add("contactJp", (Object)model.contactJp); // add paramter name japan
            parameter.Add("desEn", (Object)model.desEn); // add parameter search key
            parameter.Add("desTh", (Object)model.desTh); // add parameter province
            parameter.Add("desJp", (Object)model.desJp); // add parameter name english 
            parameter.Add("regDate", (Object)model.regDate); // add parameter name Thai
            parameter.Add("activeDate", (Object)model.activeDate); // add paramter name japan
            parameter.Add("InActiveDate", (Object)model.InActiveDate); // add parameter search key
            parameter.Add("SEQ", (Object)model.SEQ); // add parameter search key
            if (connector.InsertUpdateData(connector.CreateCommand("ssc_warehouse_update_warehouseinformation", parameter))) //excecute insert command
                return true; // return true when execute command succes.
            connector.CloseDatabase();// close database after commit.
            return false; // return false when cannot execute command.
        }

        public static System.Data.DataTable getManagecodeInformationList()
        {
            Connector connector = Connector.getInstance();// connect database object
            return connector.GetData(connector.CreateCommand("ssc_warehouse_get_warehouseinformation_all"));//get data from database
        }
    }
}
