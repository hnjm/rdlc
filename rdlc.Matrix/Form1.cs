﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ReportsApplication3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'NorthwindDataSet.vReportProducts' table. You can move, or remove it, as needed.
            this.vReportProductsTableAdapter.Fill(this.NorthwindDataSet.vReportProducts);
            this.reportViewer1.RefreshReport();
        }
    }
}