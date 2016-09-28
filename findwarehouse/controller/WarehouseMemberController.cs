using findwarehouse.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace findwarehouse.controller
{
    class WarehouseMemberController
    {
        public static void GetData(DataGridView dataGridWherehouseMember)
        {
            //set model to data gridviews
            dataGridWherehouseMember.DataSource = models.WarehousememberModel.getWherehouseMember();
        }
        public static void InsertData(models.WarehousememberModel model)
        {
            //show message box when cannot insert data
            MessageBox.Show((models.WarehousememberModel.InsertWherehousMember(model)) ? "Insert Success" :
                "Insert Failed, Please Check parameter or something");
        }

        public static void UpdateData(models.WarehousememberModel model)
        {
            //show message box when cannot insert data
            MessageBox.Show((models.WarehousememberModel.updateWarehousemember(model)) ? "Insert Success" :
                "Insert Failed, Please Check parameter or something");
        }
        /** Call Add or Edit Industrial Form **/
        public static void CallAddEditForm(Form WarehouseMemberForm)
        {
            WarehouseMemberForm.ShowDialog();// show dialog.
        }
       
    }
}
