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
    public partial class CategoryBannerConfigForm : Form
    {

        public CategoryBannerConfigForm()
        {
            InitializeComponent();
        }

        private void CategoryBannerConfigForm_Load(object sender, EventArgs e)
        {
            dataGridCategoryBannerConfig.AutoGenerateColumns = true;
            CategoryBannerConfigController.GetData(dataGridCategoryBannerConfig);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //binding data for filter
            bsCategoryBannerConfig.DataSource = dataGridCategoryBannerConfig.DataSource;
            //if not specify value in search field, remove all filter
            if (tbSearch.Text.Trim() == string.Empty)
            {
                bsCategoryBannerConfig.RemoveFilter();
            }
            //do filter at Profile Name
            else
            {
                string strSearch = tbSearch.Text.Trim();
                string rowFilter = string.Format("[{0}] LIKE '*{3}*' OR [{1}] LIKE '*{3}*' OR [{2}] LIKE '*{3}*'", "PROFILE ENG", "PROFILE THA", "PROFILE JPN", strSearch);
                bsCategoryBannerConfig.Filter = rowFilter;
            }
        }
    }
}
