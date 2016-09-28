using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using findwarehouse.controller;


namespace findwarehouse.views.Master.BannerAdvertising
{
    public partial class AddBannerAdvertising : Form
    {

        private models.BannerAdvertisingModel model;
        public AddBannerAdvertising()
        {
            InitializeComponent();
            txtCode.Enabled = false;
        }

        public AddBannerAdvertising(models.BannerAdvertisingModel model)
        {
            this.model = model; // Assign Mode into this form
            InitializeComponent();
            this.comboCusCode.Enabled = false;
        }

        private void AddBannerAdvertising_Load(object sender, EventArgs e)
        {
            BannerAdvertisingController.SetCustomerBox(comboCusCode);   //set province data into combobox

            if (model != null) //check model has data?
            {
                /* set Model into data */
                txtCode.Text = model.Code;
                comboCusCode.SelectedValue = model.cusCode; //set selected value Customer Code.
                BannerImage.ImageLocation = Properties.Settings.Default.ImagePath + model.banImg; //set ImageLocation
                dateActiveDate.Text = model.activeDate; //set Date ActiveDate
                dateInactiveDate.Text = model.inActiveDate; //set Date InActiveDate
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            if (model == null) // add Industrial mode
            {
                model = new models.BannerAdvertisingModel(); 
                model.cusCode = comboCusCode.SelectedValue.ToString(); 
                model.banImg = imageBrowse.FileName != "imgBrowse" ? imageBrowse.SafeFileName : model.banImg;
                model.activeDate = dateActiveDate.Text.Trim(); 
                model.inActiveDate = dateInactiveDate.Text.Trim(); 
                BannerAdvertisingController.InsertData(model); 

            }
            else // update (edit) Industrial mode
            {
                model = new models.BannerAdvertisingModel(); //new model to assign data
                model.cusCode = comboCusCode.SelectedValue.ToString(); // set province id
                model.Code = txtCode.Text.Trim();
                model.banImg = imageBrowse.FileName != "imgBrowse" ? imageBrowse.SafeFileName : model.banImg; 
                model.activeDate = dateActiveDate.Text.Trim(); // set thai name
                model.inActiveDate = dateInactiveDate.Text.Trim(); // set japan name
                BannerAdvertisingController.UpdateData(model);
            }
            if(imageBrowse.FileName != "imgBrowse") //check picture has selected
            {
                // Copy file to image folder in this project
                System.IO.File.Copy(imageBrowse.FileName, Properties.Settings.Default.ImagePath + imageBrowse.SafeFileName, true);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            imageBrowse.ShowDialog();
        }

        private void imageBrowse_FileOk(object sender, CancelEventArgs e)
        {
            BannerImage.ImageLocation = imageBrowse.FileName; // Show selected image in Picture Box
        }
    }
}
