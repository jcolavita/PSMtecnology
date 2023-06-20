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
    public partial class frmprestamolibro : Form
    {
        public frmprestamolibro()
        {
            InitializeComponent();
        }

        private void frmprestamolibro_Load(object sender, EventArgs e)
        {
            this.prestamoslibrosTableAdapter.Fill(this.dSTG.prestamoslibros);
            this.reportViewer1.RefreshReport();
        }
    }
}
