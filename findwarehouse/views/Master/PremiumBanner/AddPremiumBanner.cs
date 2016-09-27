using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using findwarehouse.controller;

namespace findwarehouse.views.Master.PremiumBanner
{
    public partial class AddPremiumBanner : Form
    {
        private models.PremiumBannerModel model;

        /* New Form with no selected Mode */
        public AddPremiumBanner()
        {
            InitializeComponent();
        }

        /* New Form with selected Mode */
        public AddPremiumBanner(models.PremiumBannerModel model)
        {
            this.model = model; // Assign Mode into this form
            InitializeComponent();
            this.comboMemCode.Enabled = false;
            this.comboMemCode.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        private void AddPremiumBanner_Load(object sender, EventArgs e)
        {
            PremiumBannerController.SetInitialComboBox(comboMemCode);   //set province data into combobox

            if (model != null) //check model has data?
            {
                /* set Model into data */
                comboMemCode.SelectedValue = model.memberCode;  // set member code
                imgPreview.ImageLocation = Properties.Settings.Default.ImagePath + model.adImg; // Show selected image in Picture Box
                txtBannerURL.Text = model.adPath; // set banner url address
                dtpActivedate.Value = Convert.ToDateTime(model.activeDate);//set active date
                dtpInactiveDate.Value = Convert.ToDateTime(model.InActiveDate);// set inactive date
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();//close form
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (model == null) // add Industrial mode
            {
                model = new models.PremiumBannerModel(); //new model to assign data
                model.memberCode = comboMemCode.Text;// set province id
                model.adImg = imgBrowse.FileName != "imgBrowse" ? imgBrowse.SafeFileName : ""; //set file name
                model.adPath = txtBannerURL.Text.Trim(); // set thai name
                model.activeDate = dtpActivedate.Value.ToString("yyyy-MM-dd");//set active date
                model.InActiveDate = dtpActivedate.Value.ToString("yyyy-MM-dd"); // set inactive date
                PremiumBannerController.InsertData(model); // call update method
                model = null;
            }
            else // update (edit) Industrial mode
            {
                model.memberCode = comboMemCode.SelectedValue.ToString(); // set province id
                model.adImg = imgBrowse.FileName != "imgBrowse" ? imgBrowse.SafeFileName : model.adImg; //set file name
                model.adPath = txtBannerURL.Text.Trim(); // set thai name
                model.activeDate = dtpActivedate.Value.ToString("yyyy-MM-dd");//set active date
                model.InActiveDate = dtpActivedate.Value.ToString("yyyy-MM-dd"); // set inactive date
                PremiumBannerController.UpdateData(model);
            }
            if (imgBrowse.FileName != "imgBrowse") // Check if picture has selected
            {
                // Copy file to image folder in this project
                //System.IO.File.Copy(imgBrowse.FileName, Properties.Settings.Default.ImagePath + imgBrowse.SafeFileName, true);
                System.IO.File.Copy(imgBrowse.FileName, "D:\\SSC\\Find WareHouse Thailand_wasan\\findwarehouse\\findwarehouse\\Images\\" + imgBrowse.SafeFileName, true);
            }
        }

        // Button Browse click
        private void btnBrowse_Click(object sender, EventArgs e)
        {
            imgBrowse.ShowDialog();// show windows dialog for find picture
        }

        // This method will work when image file has selected
        private void imgBrowse_FileOk(object sender, CancelEventArgs e)
        {
            imgPreview.ImageLocation = imgBrowse.FileName; // Show selected image in Picture Box
        }
    }
}
