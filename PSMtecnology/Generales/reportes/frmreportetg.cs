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
    public partial class frmreportetg : Form
    {
        public string escuela="",estatus;
        public int periodo;
        public frmreportetg()
        {
            InitializeComponent();
        }

        private void frmreportetg_Load(object sender, EventArgs e)
        {

            this.trabajogradoTableAdapter.Fill(this.dSTG.trabajogrado, escuela, periodo,estatus);
            this.reportViewer1.RefreshReport();
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

       
        
    }
}
