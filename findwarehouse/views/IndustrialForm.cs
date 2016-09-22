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
    public partial class IndustrialForm : Form
    {

        public IndustrialForm()
        {
            InitializeComponent();
        }

        private void IndustrialForm_Load(object sender, EventArgs e)
        {
            dataGridIndustrial.AutoGenerateColumns = true;
            IndustrialController.GetData(dataGridIndustrial);
        }


    }
}
