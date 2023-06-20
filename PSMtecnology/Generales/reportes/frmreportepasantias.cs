﻿using DocumentFormat.OpenXml.Drawing.Charts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PSMtecnology.Generales.reportes
{
    public partial class frmreportepasantias : Form
    {
        public string escuela,estatus;
        public int periodo;
        public frmreportepasantias()
        {
            InitializeComponent();
        }

        private void frmreportepasantias_Load(object sender, EventArgs e)
        {
            this.pasantiasTableAdapter.Fill(this.dSTG.pasantias, periodo, escuela,estatus);
            this.reportViewer1.RefreshReport();
        }
    }
}
