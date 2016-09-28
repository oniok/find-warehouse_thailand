using findwarehouse.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace findwarehouse.models
{
    /** Industrial Model **/
    public class IndustrialModel : IModel
    {
        public IndustrialModel() { }
        public String Code { set; get; } // Industiral Code
        public String Province { set; get; } // Province Code
        public String NameEn { set; get; } // Name English
        public String NameTh { set; get; } // Name Thai
        public String NameJp { set; get; } // Name Japan
        public Int16  Sequence { set; get; } // Sequence Number 
        public String SearchKey { set; get; } // Search Key

        /** Data Entity Class **/
        public static class ENTITY
        {
            public const String CODE = "INDUSTRIAL_CODE";
            public const String PROVINCE = "PROVINCE_CODE";
            public const String NAME_EN = "NAME_ENG";
            public const String NAME_TH = "NAME_THA";
            public const String NAME_JP = "NAME_JPN";
            public const String SEQUENCE = "SEQUENCE";
            public const String SEARCH_KEY = "SEARCH_KEY";
        }

        /* Get Data as DataSource */
        public static BindingSource getIndustrialAll()
        {
            Connector connector = Connector.getInstance();// connect database object
            BindingSource bindDatasource = new BindingSource();
            //this may has some error when use stroed procedure please use direct query instread
            bindDatasource.DataSource = connector.GetData(connector.CreateCommand("ssc_warehouse_get_industrial_all"));//get data from database
            connector.CloseDatabase(); // close database after commit
            return bindDatasource;//return data grid data
        }

        /* Insert Data 
         * @Param IndustrialModel as model
         * @return Result as bool
         */
        public static bool insertIndustrial(IndustrialModel model)
        {
            Connector connector = Connector.getInstance(); // connect database object
            Dictionary<String, Object> parameter = new Dictionary<string, object>(); //new parameter object
            parameter.Add("provinceId", (Object)model.Province); // add parameter province
            parameter.Add("NameEn", (Object)model.NameEn); // add parameter name english 
            parameter.Add("NameTh", (Object)model.NameTh); // add parameter name Thai
            parameter.Add("NameJp", (Object)model.NameJp); // add paramter name japan
            parameter.Add("searchKey", (Object)model.SearchKey); // add parameter search key
            if (connector.InsertUpdateData(connector.CreateCommand("ssc_warehouse_add_industrial", parameter))) //excecute insert command
                return true; // return true when execute command succes.
            connector.CloseDatabase();// close database after commit.
            return false; // return false when cannot execute command.
        }
        public static bool updateIndustrial(IndustrialModel model)
        {
            Connector connector = Connector.getInstance(); // connect database object
            Dictionary<String, Object> parameter = new Dictionary<string, object>(); //new parameter object
            parameter.Add("industrialCode", (Object)model.Code);
            parameter.Add("provinceCode", (Object)model.Province); // add parameter province
            parameter.Add("nameEn", (Object)model.NameEn); // add parameter name english 
            parameter.Add("nameTh", (Object)model.NameTh); // add parameter name Thai
            parameter.Add("nameJp", (Object)model.NameJp); // add paramter name japan
            parameter.Add("searchName", (Object)model.SearchKey); // add parameter search key
            if (connector.InsertUpdateData(connector.CreateCommand("ssc_warehouse_update_industrial", parameter))) //excecute insert command
                return true; // return true when execute command succes.
            connector.CloseDatabase();// close database after commit.
            return false; // return false when cannot execute command.
        }

        public static System.Data.DataTable getIndustrialList()
        {
            Connector connector = Connector.getInstance();// connect database object
            return connector.GetData(connector.CreateCommand("ssc_warehouse_get_industrial_all"));//get data from database
        }
    }
}
