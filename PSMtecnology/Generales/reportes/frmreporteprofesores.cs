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
    public partial class frmreporteprofesores : Form
    {
        public string escuela,especialidad,profesion,sexo;


        public frmreporteprofesores()
        {
            InitializeComponent();
        }

        private void frmreporteprofesores_Load(object sender, EventArgs e)
        {
            this.profesoresTableAdapter.Fill(this.dSTG.profesores,profesion, escuela,sexo,escuela,sexo,profesion,sexo,profesion,escuela,sexo,escuela,profesion);
            this.reportViewer1.RefreshReport();
        }
    }
}
