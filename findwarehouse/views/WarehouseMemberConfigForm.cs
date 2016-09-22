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
    public partial class WarehouseMemberConfigForm : Form
    {

        public WarehouseMemberConfigForm()
        {
            InitializeComponent();
        }

        private void WarehouseMemberConfigForm_Load(object sender, EventArgs e)
        {
            dataGridWarehouseMemberConfig.AutoGenerateColumns = true;
            WarehouseMemberConfigController.GetData(dataGridWarehouseMemberConfig);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {    
            bsWarehouseMemberConfig.DataSource = dataGridWarehouseMemberConfig.DataSource;
            //if not specify value in search field, remove all filter
            if (tbSearch.Text.Trim() == string.Empty)
            {
                bsWarehouseMemberConfig.RemoveFilter();
            }
            //do filter at warehouse member name in all languages
            else
            {
                string strSearch = tbSearch.Text.Trim();
                string rowFilter = string.Format("[{0}] LIKE '*{1}*'", "Name", strSearch);
                bsWarehouseMemberConfig.Filter = rowFilter;
            }
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
