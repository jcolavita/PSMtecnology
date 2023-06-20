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
    public partial class frmreporteusuario : Form
    {
        public frmreporteusuario()
        {
            InitializeComponent();
        }

        private void frmreporteusuario_Load(object sender, EventArgs e)
        {
            this.usuariosTableAdapter.Fill(this.dSTG.usuarios);

            this.reportViewer1.RefreshReport();
        }
    }
}
