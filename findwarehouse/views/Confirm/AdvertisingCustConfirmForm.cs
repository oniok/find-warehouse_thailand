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
    public partial class AdvertisingCustConfirmForm : Form
    {

        public AdvertisingCustConfirmForm()
        {
            InitializeComponent();
        }

        private void AdvertisingCustConfirmForm_Load(object sender, EventArgs e)
        {
            dataGridAdvertisingCustConfirm.AutoGenerateColumns = true;
            AdvertisingCustConfirmController.GetData(dataGridAdvertisingCustConfirm);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //binding data for filter
            bsAdvertisingCustConfirm.DataSource = dataGridAdvertisingCustConfirm.DataSource;
            //if not specify value in search field, remove all filter
            if (tbSearch.Text.Trim() == string.Empty)
            {
                bsAdvertisingCustConfirm.RemoveFilter();
            }
            //do filter at Customer Name
            else
            {
                string strSearch = tbSearch.Text.Trim();
                string rowFilter = string.Format("[{0}] LIKE '*{1}*'", "Name", strSearch);
                bsAdvertisingCustConfirm.Filter = rowFilter;
            }
        }
    }
}
