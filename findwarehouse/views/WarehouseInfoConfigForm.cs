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
    public partial class WarehouseInfoConfigForm : Form
    {

        public WarehouseInfoConfigForm()
        {
            InitializeComponent();
        }

        private void WarehouseInfoConfigForm_Load(object sender, EventArgs e)
        {
            dataGridWarehouseInfoConfig.AutoGenerateColumns = true;
            WarehouseInfoConfigController.GetData(dataGridWarehouseInfoConfig);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //binding data for filter
            bsWarehouseInfoConfig.DataSource = dataGridWarehouseInfoConfig.DataSource;
            //if not specify value in search field, remove all filter
            if (tbSearch.Text.Trim() == string.Empty)
            {
                bsWarehouseInfoConfig.RemoveFilter();
            }
            //do filter at warehouse name in all languages
            else
            {
                string strSearch = tbSearch.Text.Trim();
                string rowFilter = string.Format("[{0}] LIKE '*{3}*' OR [{1}] LIKE '*{3}*' OR [{2}] LIKE '*{3}*'", "Name English", "Name Thai", "Name Japan", strSearch);
                bsWarehouseInfoConfig.Filter = rowFilter;
            }
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
