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
    public partial class frmreportetria : Form
    {
        public string escuela,estatus;
        public int periodo;
        public frmreportetria()
        {
            InitializeComponent();
        }

        private void frmreportetria_Load(object sender, EventArgs e)
        {
            this.triaTableAdapter.Fill(this.dSTG.Tria, periodo,escuela,estatus);
            this.reportViewer1.RefreshReport();
        }
    }
}
