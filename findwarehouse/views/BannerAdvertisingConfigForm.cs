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
    public partial class BannerAdvertisingConfigForm : Form
    {

        public BannerAdvertisingConfigForm()
        {
            InitializeComponent();
        }

        private void BannerAdvertisingConfigForm_Load(object sender, EventArgs e)
        {
            dataGridBannerAdvertisingConfig.AutoGenerateColumns = true;
            BannerAdvertisingConfigController.GetData(dataGridBannerAdvertisingConfig);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //binding data for filter
            bsBannerAdvertisingConfig.DataSource = dataGridBannerAdvertisingConfig.DataSource;
            //if not specify value in search field, remove all filter
            if (tbSearch.Text.Trim() == string.Empty)
            {
                bsBannerAdvertisingConfig.RemoveFilter();
            }
            //do filter at Banner code
            else
            {
                string strSearch = tbSearch.Text.Trim();
                string rowFilter = string.Format("[{0}] LIKE '*{1}*'", "Banner Code", strSearch);
                bsBannerAdvertisingConfig.Filter = rowFilter;
            }
        }
    }
}
