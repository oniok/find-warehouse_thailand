using findwarehouse.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace findwarehouse.models
{
    public class WarehouseImageModel :IModel
    {
        public WarehouseImageModel() { }
        public String Code { set; get; } // Industiral Code
        public String manageNo { set; get; } // Province Code
        public String img01 { set; get; } // Name English
        public String img02 { set; get; } // Name Thai
        public String img03 { set; get; } // Name Japan
        public String img04 { set; get; } // Sequence Number 
        public String img05 { set; get; } // Search Key

        /** Data Entity Class **/
        public static class ENTITY
        {
            public const String Code = "MEMBER_CODE";
            public const String manageNo = "MANAGE_NO";
            public const String img01 = "IMG_1";
            public const String img02 = "IMG_2";
            public const String img03 = "IMG_3";
            public const String img04 = "IMG_4";
            public const String img05 = "IMG_5";
        }

        /* Get Data as DataSource */
        public static BindingSource getWarehouseImageAll()
        {
            Connector connector = Connector.getInstance();// connect database object
            BindingSource bindDatasource = new BindingSource();
            //this may has some error when use stroed procedure please use direct query instread
            bindDatasource.DataSource = connector.GetData(connector.CreateCommand("ssc_warehouse_get_warehouseimage_all"));//get data from database
            connector.CloseDatabase(); // close database after commit
            return bindDatasource;//return data grid data
        }

        /* Insert Data 
       * @Param IndustrialModel as model
       * @return Result as bool
       */
        public static bool insertWarehouseImage(WarehouseImageModel model)
        {
            Connector connector = Connector.getInstance(); // connect database object
            Dictionary<String, Object> parameter = new Dictionary<string, object>(); //new parameter object
            parameter.Add("memberCode", (Object)model.Code); // add parameter Member Code from Warehouse Information
            parameter.Add("manageNo", (Object)model.manageNo);//add parameter Manage No. from Warehouse Infomation.
            parameter.Add("img01", (Object)model.img01); // add parameter Image1 warehouseImage
            parameter.Add("img02", (Object)model.img02); // add parameter Image2 warehouseImage
            parameter.Add("img03", (Object)model.img03); // add paramter  Image3 warehouseImage
            parameter.Add("img04", (Object)model.img04); // add parameter Image4 warehouseImage
            parameter.Add("img05", (Object)model.img05); // add parameter Image5 warehouseImage
            if (connector.InsertUpdateData(connector.CreateCommand("ssc_warehouse_add_warehouseimage", parameter))) //excecute insert command
                return true; // return true when execute command succes.
            connector.CloseDatabase();// close database after commit.
            return false; // return false when cannot execute command.
        }

        public static bool updateWarehouseImage(WarehouseImageModel model)
        {
            Connector connector = Connector.getInstance(); // connect database object
            Dictionary<String, Object> parameter = new Dictionary<string, object>(); //new parameter object
            parameter.Add("Code", (Object)model.Code); // add parameter Member Code from Warehouse Information
            parameter.Add("manageNo", (Object)model.manageNo);//add parameter Manage No. from Warehouse Infomation.
            parameter.Add("img01", (Object)model.img01); // add parameter Image1 warehouseImage
            parameter.Add("img02", (Object)model.img02); // add parameter Image2 warehouseImage
            parameter.Add("img03", (Object)model.img03); // add paramter  Image3 warehouseImage
            parameter.Add("img04", (Object)model.img04); // add parameter Image4 warehouseImage
            parameter.Add("img05", (Object)model.img05); // add parameter Image5 warehouseImage
            if (connector.InsertUpdateData(connector.CreateCommand("ssc_warehouse_update_warehouseimage", parameter))) //excecute insert command
                return true; // return true when execute command succes.
            connector.CloseDatabase();// close database after commit.
            return false; // return false when cannot execute command.
        }
    }
}
