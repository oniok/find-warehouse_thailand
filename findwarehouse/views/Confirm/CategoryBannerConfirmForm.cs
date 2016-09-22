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
    public partial class CategoryBannerConfirmForm : Form
    {

        public CategoryBannerConfirmForm()
        {
            InitializeComponent();
        }

        private void CategoryBannerConfirmForm_Load(object sender, EventArgs e)
        {
            dataGridCategoryBannerConfirm.AutoGenerateColumns = true;
            CategoryBannerConfirmController.GetData(dataGridCategoryBannerConfirm);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //binding data for filter
            bsCategoryBannerConfirm.DataSource = dataGridCategoryBannerConfirm.DataSource;
            //if not specify value in search field, remove all filter
            if (tbSearch.Text.Trim() == string.Empty)
            {
                bsCategoryBannerConfirm.RemoveFilter();
            }
            //do filter at Profile Name
            else
            {
                string strSearch = tbSearch.Text.Trim();
                string rowFilter = string.Format("[{0}] LIKE '*{3}*' OR [{1}] LIKE '*{3}*' OR [{2}] LIKE '*{3}*'", "Profile English", "Profile Thai", "Profile Japan", strSearch);
                bsCategoryBannerConfirm.Filter = rowFilter;
            }
        }
    }
}
