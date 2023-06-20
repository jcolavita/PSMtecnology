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
    public partial class frmlibros : Form
    {
        public string materias;
        public frmlibros()
        {
            InitializeComponent();
        }

        private void frmlibros_Load(object sender, EventArgs e)
        {
            this.librosTableAdapter.Fill(this.dSTG.libros, materias);
            this.reportViewer1.RefreshReport();
        }
    }
}
