using findwarehouse.controller;
using findwarehouse.views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace findwarehouse
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        /* Form load initialize */
        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        /* Industrial Label Click */
        private void lbCallIndustrial_Click(object sender, EventArgs e)
        {
            SubFormController.setForm(panelSubForm, new IndustrialForm()); // call Industrial form as new form
        }

        /* Warehoues Label Click */
        private void lbCallWarehouseMember_Click(object sender, EventArgs e)
        {
            SubFormController.setForm(panelSubForm, new WarehouseMemberForm()); // call WarehouseMember form as new form
        }

       
        /* Warehouse label Click */
        private void lbCallWarehouseMemberConfirm_Click(object sender, EventArgs e)
        {
            SubFormController.setForm(panelSubForm, new WarehouseMemberConfirmForm());  //call Warehouse Member Confirm as new form
        }

        
        private void lbCallWarehouseInfoConfirm_Click(object sender, EventArgs e)
        {
            SubFormController.setForm(panelSubForm, new WarehouseInfoConfirmForm()); 
        }

        private void lbCallAdvertisingCustConfirm_Click(object sender, EventArgs e)
        {
            SubFormController.setForm(panelSubForm, new AdvertisingCustConfirmForm());
        }

        private void lbCallBannerAdvertisingConfirm_Click(object sender, EventArgs e)
        {
            SubFormController.setForm(panelSubForm, new BannerAdvertisingConfirmForm());
        }

        private void lbCallCategoryBannerConfirm_Click(object sender, EventArgs e)
        {
            SubFormController.setForm(panelSubForm, new CategoryBannerConfirmForm());
        }
    }
}
