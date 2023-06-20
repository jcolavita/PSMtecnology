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
    public partial class frmreportepi : Form
    {
        public string escuela,estatus;
        public int periodo;
        public frmreportepi()
        {
            InitializeComponent();
        }

        private void frmreportepi_Load(object sender, EventArgs e)
        {
            this.piTableAdapter.Fill(this.dSTG.pi, periodo, escuela,estatus);
            this.reportViewer1.RefreshReport();
        }
    }
}
