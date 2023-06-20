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
    public partial class frmauditoria : Form
    {
        public string accion;
        public frmauditoria()
        {
            InitializeComponent();
        }

        private void frmauditoria_Load(object sender, EventArgs e)
        {
            this.auditoriaTableAdapter.Fill(this.dSTG.auditoria,accion);

            this.reportViewer1.RefreshReport();
        }
    }
}
