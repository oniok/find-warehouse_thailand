using findwarehouse.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace findwarehouse.models
{
    /** Industrial Model **/
    class CategoryBannerConfigModel : IModel
    {
        public String MEMBER_CODE { set; get; }
        public String MEMBER_TYPE { set; get; }
        public String PREMIUM_FLG { set; get; }
        public String COUNTRY_CODE { set; get; }
        public String NAME_ENG { set; get; }
        public String ADDRESS_ENG { set; get; }
        public String TEL { set; get; }
        public String MOBILE { set; get; }
        public String CONTACTPERSON_NAME { set; get; }
        public String EMAIL { set; get; }
        public DateTime REGISTRATION_DATE { set; get; }
        public DateTime UPDATEEXPIRE_DATE { set; get; }

        public static class ENTITY
        {
            public const String MEMBER_CODE = "MEMBER_CODE";
            public const String MEMBER_TYPE = "MEMBER_TYPE";
            public const String PREMIUM_FLG = "PREMIUM_FLG";
            public const String COUNTRY_CODE = "COUNTRY_CODE";
            public const String NAME_ENG = "NAME_ENG";
            public const String ADDRESS_ENG = "ADDRESS_ENG";
            public const String TEL = "TEL";
            public const String MOBILE = "MOBILE";
            public const String CONTACTPERSON_NAME = "CONTACTPERSON_NAME";
            public const String EMAIL = "EMAIL";
            public const String REGISTRATION_DATE = "REGISTRATION_DATE";
            public const String UPDATEEXPIRE_DATE = "UPDATEEXPIRE_DATE";
        }

        /* Get Data as DataSource */
        public static BindingSource getCategoryBannerConfigAll()
        {
            Connector connector = Connector.getInstance();// connect database object
            BindingSource bindDatasource = new BindingSource();
            bindDatasource.DataSource = connector.GetData(connector.CreateCommand("get_AllCategoryBanner"));//get data from database
            return bindDatasource;//return data grid data
        }

    }
}
