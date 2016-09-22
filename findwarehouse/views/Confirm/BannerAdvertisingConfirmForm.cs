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
    public partial class BannerAdvertisingConfirmForm : Form
    {

        public BannerAdvertisingConfirmForm()
        {
            InitializeComponent();
        }

        private void BannerAdvertisingConfirmForm_Load(object sender, EventArgs e)
        {
            dataGridBannerAdvertisingConfirm.AutoGenerateColumns = true;
            BannerAdvertisingConfirmController.GetData(dataGridBannerAdvertisingConfirm);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //binding data for filter
            bsBannerAdvertisingConfirm.DataSource = dataGridBannerAdvertisingConfirm.DataSource;
            //if not specify value in search field, remove all filter
            if (tbSearch.Text.Trim() == string.Empty)
            {
                bsBannerAdvertisingConfirm.RemoveFilter();
            }
            //do filter at Banner code
            else
            {
                string strSearch = tbSearch.Text.Trim();
                string rowFilter = string.Format("[{0}] LIKE '*{1}*'", "AdMember Code", strSearch);
                bsBannerAdvertisingConfirm.Filter = rowFilter;
            }
        }
    }
}
