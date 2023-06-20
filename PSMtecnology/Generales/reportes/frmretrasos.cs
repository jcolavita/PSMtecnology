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
    public partial class frmretrasos : Form
    {
        public string estado;
        public frmretrasos()
        {
            InitializeComponent();
        }

        private void frmretrasos_Load(object sender, EventArgs e)
        {
            this.retrasosTableAdapter.Fill(this.dSTG.retrasos,estado);

            this.reportViewer1.RefreshReport();
        }
    }
}
