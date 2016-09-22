using findwarehouse.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace findwarehouse.models
{
    /* Model for province table */
    class ProvinceModel : IModel
    {
        public ProvinceModel() { }
        String Code { set; get; } // province code
        String NameEnglish { set; get; } // pronvice name in english   
        String NameThai { set; get; } //province name in thai
        String NameJapan { set; get; } // province name in japan
        Int32 Sequence { set; get; } //sequence number
        String SearchKey { set; get; } // province for search name

        /* Entity of database */
        public static class ENTITY
        {
            public const String CODE = "PROVINCE_CODE";
            public const String NAME_ENG = "PROVINCE_ENG";
            public const String NAME_THA = "PROVINCE_THA";
            public const String NAME_JPN = "PROVINCE_JPN";
            public const String SEQUENCE = "SEQUENCE";
            public const String SEARCH_KEY = "SEARCH_KEY";
        }

        public static System.Data.DataTable getProvinceList()
        {
            Connector connector = Connector.getInstance();// connect database object
            return connector.GetData(connector.CreateCommand("ssc_warehouse_get_province_all"));//get data from database
        }
    }
}
