using DocumentFormat.OpenXml.Drawing.Charts;
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
    public partial class frmreporteestudiante : Form
    {
        public string escuela, sexo;
        public frmreporteestudiante()
        {
            InitializeComponent();
        }

      

        private void frmreporteestudiante_Load(object sender, EventArgs e)
        {
            this.estudiantesTableAdapter.Fill(this.dSTG.estudiantes, escuela, sexo);

            this.reportViewer1.RefreshReport();
        }
    }
}
