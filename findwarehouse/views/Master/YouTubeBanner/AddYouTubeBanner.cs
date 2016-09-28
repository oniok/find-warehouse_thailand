using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using findwarehouse.controller;

namespace findwarehouse.views.Master.YouTubeBanner
{
    public partial class AddYouTubeBanner : Form
    {
        public AddYouTubeBanner()
        {
            InitializeComponent();
        }

        private models.YouTubeBannerModel model;

        public AddYouTubeBanner(models.YouTubeBannerModel model)
        {
            this.model = model; // Assign Mode into this form
            InitializeComponent();
        }

        private void AddYouTubeBanner_Load(object sender, EventArgs e)
        {
            YouTubeBannerController.SetCustomerBox(comboCuscode);   //set province data into combobox

            if (model != null) //check model has data?
            {
                /* set Model into data */
                comboCuscode.SelectedValue = model.customerCode; //set selected value province.
                txtYlink.Text = model.YtUri; //set name english.
                txtActive.Text = model.ActiveDate; //set name thai.
                txtInactive.Text = model.InActiveDate; //set name japan.
            }
         }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (model == null) // add Industrial mode
            {
                model = new models.YouTubeBannerModel(); //new model to assign data
                model.customerCode = comboCuscode.SelectedValue.ToString(); // set province id
                model.YtUri = txtYlink.Text.Trim(); //set english name
                model.ActiveDate = txtActive.Text.Trim(); // set thai name
                model.InActiveDate = txtInactive.Text.Trim(); // set japan name
                
                YouTubeBannerController.InsertData(model); // call update method

            }
            else // update (edit) Industrial mode
            {
                model.customerCode = comboCuscode.SelectedValue.ToString(); // set province id
                model.YtUri = txtYlink.Text.Trim(); //set english name
                model.ActiveDate = txtActive.Text.Trim(); // set thai name
                model.InActiveDate = txtInactive.Text.Trim(); // set japan name
               
                YouTubeBannerController.UpdateData(model);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
