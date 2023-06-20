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
    public partial class frmreportealquiler : Form
    {
        public frmreportealquiler()
        {
            InitializeComponent();
        }

        private void frmreportealquiler_Load(object sender, EventArgs e)
        {
            this.alquilerareaTableAdapter.Fill(this.dSTG.alquilerarea);

            this.reportViewer1.RefreshReport();
        }
    }
}
