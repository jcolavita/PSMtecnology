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
    public partial class frmreporteproyector : Form
    {
        public frmreporteproyector()
        {
            InitializeComponent();
        }

        private void frmreporteproyector_Load(object sender, EventArgs e)
        {
            this.proyectoresTableAdapter.Fill(this.dSTG.proyectores);

            this.reportViewer1.RefreshReport();
        }
    }
}
