using findwarehouse.controller;
using findwarehouse.Database;
using findwarehouse.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace findwarehouse.views
{
    public partial class WarehouseInfoConfirmForm : Form
    {

        public WarehouseInfoConfirmForm()
        {
            InitializeComponent();
        }

        private void WarehouseInfoConfirmForm_Load(object sender, EventArgs e)
        {
            dataGridWarehouseInfoConfirm.AutoGenerateColumns = true;
            WarehouseInfoConfirmController.GetData(dataGridWarehouseInfoConfirm);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //binding data for filter
            bsWarehouseInfoConfirm.DataSource = dataGridWarehouseInfoConfirm.DataSource;
            //if not specify value in search field, remove all filter
            if (tbSearch.Text.Trim() == string.Empty)
            {
                bsWarehouseInfoConfirm.RemoveFilter();
            }
            //do filter at warehouse name in all languages
            else
            {
                string strSearch = tbSearch.Text.Trim();
                string rowFilter = string.Format("[{0}] LIKE '*{3}*' OR [{1}] LIKE '*{3}*' OR [{2}] LIKE '*{3}*'", "Name English", "Name Thai", "Name Japan", strSearch);
                bsWarehouseInfoConfirm.Filter = rowFilter;
            }
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
