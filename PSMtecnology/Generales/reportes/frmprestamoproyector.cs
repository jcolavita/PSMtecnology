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
    public partial class frmprestamoproyector : Form
    {
        public frmprestamoproyector()
        {
            InitializeComponent();
        }

        private void frmprestamoproyector_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dSTG.prestamoproyector' Puede moverla o quitarla según sea necesario.
            this.prestamoproyectorTableAdapter.Fill(this.dSTG.prestamoproyector);

            this.reportViewer1.RefreshReport();
        }
    }
}
