using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using findwarehouse.controller;


namespace findwarehouse.views.Master.WarehouseImage
{
    public partial class AddWarehouseImage : Form
    {

        private models.WarehouseImageModel model;

        /* New Form with no selected Mode */
        public AddWarehouseImage()
        {
            InitializeComponent();
        }

        /* New Form with selected Mode */
        public AddWarehouseImage(models.WarehouseImageModel model)
        {
            this.model = model;
            //this.comboMenageNo.Enabled = true;
            //this.comboMemberCode.Enabled = false;
            //this.comboMenageNo.DropDownStyle = ComboBoxStyle.DropDownList;
            InitializeComponent();
            //this.comboMemberCode.Enabled = false;
        }

        private void comboMemberCode_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupWarehouseImage_Enter(object sender, EventArgs e)
        {

        }

        private void AddWarehouseImage_Load(object sender, EventArgs e)
        {
            WarehouseImageController.SetMomberCode(comboMemberCode);   //set province data into combobox
            WarehouseImageController.setMangeNo(comboMenageNo);

            if (model != null) //check model has data?
            {
                /* set Model into data */
                comboMenageNo.SelectedValue = model.manageNo; //set selected value province.
                comboMemberCode.SelectedValue = model.Code;
                //txtMember.Text = model.Code; //set name english.
                imgWarehouseImage1.ImageLocation = Properties.Settings.Default.ImagePath + model.img01; // Show selected image in Picture Box
                imgWarehouseImage2.ImageLocation = Properties.Settings.Default.ImagePath + model.img02; // Show selected image in Picture Box
                imgWarehouseImage3.ImageLocation = Properties.Settings.Default.ImagePath + model.img03; // Show selected image in Picture Box
                imgWarehouseImage4.ImageLocation = Properties.Settings.Default.ImagePath + model.img04; // Show selected image in Picture Box
                imgWarehouseImage5.ImageLocation = Properties.Settings.Default.ImagePath + model.img05; // Show selected image in Picture Box

            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            
            if (model == null) // add Industrial mode
            {
                model = new models.WarehouseImageModel(); //new model to assign data
                model.manageNo = comboMenageNo.Text.Trim(); // set province id
                model.Code = comboMemberCode.Text.Trim();
                model.img01 = imgBrowse1.FileName != "imgBrowse1" ? imgBrowse1.SafeFileName : ""; //set file name
                model.img02 = ImgBrowse2.FileName != "imgBrowse2" ? ImgBrowse2.SafeFileName : ""; //set file name
                model.img03 = ImgBrowse3.FileName != "imgBrowse3" ? ImgBrowse3.SafeFileName : ""; //set file name
                model.img04 = ImgBrowse4.FileName != "imgBrowse4" ? ImgBrowse4.SafeFileName : ""; //set file name
                model.img05 = ImgBrowse5.FileName != "imgBrowse5" ? ImgBrowse5.SafeFileName : ""; //set file name
                WarehouseImageController.InsertData(model); // call update method
                model = null;

            }
            else // update (edit) Industrial mode
            {
                model = new models.WarehouseImageModel(); //new model to assign data
                model.manageNo = comboMenageNo.Text.Trim(); // set province id
                model.Code = comboMemberCode.Text.Trim();
                model.img01 = imgBrowse1.FileName != "imgBrowse1" ? imgBrowse1.SafeFileName : ""; //set file name
                model.img02 = ImgBrowse2.FileName != "imgBrowse2" ? ImgBrowse2.SafeFileName : ""; //set file name
                model.img03 = ImgBrowse3.FileName != "imgBrowse3" ? ImgBrowse3.SafeFileName : ""; //set file name
                model.img04 = ImgBrowse4.FileName != "imgBrowse4" ? ImgBrowse4.SafeFileName : ""; //set file name
                model.img05 = ImgBrowse5.FileName != "imgBrowse5" ? ImgBrowse5.SafeFileName : ""; //set file name
                WarehouseImageController.UpdateData(model); // call update method
            }
            if (imgBrowse1.FileName != "imgBrowse1" || ImgBrowse2.FileName != "imgBrowse2" || ImgBrowse3.FileName != "imgBrowse3" || ImgBrowse4.FileName != "imgBrowse4" || ImgBrowse5.FileName != "imgBrowse5") // Check if picture has selected
            {
                // Copy file to image folder in this project
                if (imgBrowse1.FileName != null && imgBrowse1.FileName.Equals(String.Empty) )
                {
                    System.IO.File.Copy(imgBrowse1.FileName, Properties.Settings.Default.ImagePath + imgBrowse1.SafeFileName, true);
                }

                if (ImgBrowse2.FileName != null && ImgBrowse2.FileName.Equals(String.Empty))
                {
                    System.IO.File.Copy(ImgBrowse2.FileName, Properties.Settings.Default.ImagePath + ImgBrowse2.SafeFileName, true);
                }

                if (ImgBrowse3.FileName != null && ImgBrowse3.FileName.Equals(String.Empty))
                {
                    System.IO.File.Copy(ImgBrowse3.FileName, Properties.Settings.Default.ImagePath + ImgBrowse3.SafeFileName, true);
                }
                if (ImgBrowse4.FileName != null && ImgBrowse4.FileName.Equals(String.Empty))
                {
                    System.IO.File.Copy(ImgBrowse4.FileName, Properties.Settings.Default.ImagePath + ImgBrowse4.SafeFileName, true);
                }
                if (ImgBrowse4.FileName != null && ImgBrowse4.FileName.Equals(String.Empty))
                {
                    System.IO.File.Copy(ImgBrowse5.FileName, Properties.Settings.Default.ImagePath + ImgBrowse5.SafeFileName, true);
                }
                    
            }
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnbrowse1_Click(object sender, EventArgs e)
        {
            imgBrowse1.ShowDialog();// show windows dialog for find picture
        }

        private void btnBrowse2_Click(object sender, EventArgs e)
        {
            ImgBrowse2.ShowDialog();
        }

        private void btnImage3_Click(object sender, EventArgs e)
        {
            ImgBrowse3.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ImgBrowse4.ShowDialog();
        }

        private void btnImage5_Click(object sender, EventArgs e)
        {
            ImgBrowse5.ShowDialog();
        }

        private void imgBrowse1_FileOk(object sender, CancelEventArgs e)
        {
            imgWarehouseImage1.ImageLocation = imgBrowse1.FileName; // Show selected image in Picture Box
        }

        private void ImgBrowse2_FileOk(object sender, CancelEventArgs e)
        {
            imgWarehouseImage2.ImageLocation = ImgBrowse2.FileName; // Show selected image in Picture Box
        }

        private void ImgBrowse3_FileOk(object sender, CancelEventArgs e)
        {
            imgWarehouseImage3.ImageLocation = ImgBrowse3.FileName;
        }

        private void ImgBrowse4_FileOk(object sender, CancelEventArgs e)
        {
            imgWarehouseImage4.ImageLocation = ImgBrowse4.FileName;
        }

        private void ImgBrowse5_FileOk(object sender, CancelEventArgs e)
        {
            imgWarehouseImage5.ImageLocation = ImgBrowse5.FileName;
        }
    }
}
