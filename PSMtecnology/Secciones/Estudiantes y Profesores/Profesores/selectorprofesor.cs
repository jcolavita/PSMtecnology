using PSMtecnology.Generales.reportes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabajoDeGrado.Generales
{
    public partial class selectorprofesor : Form
    {
        Funciones_BD bd = new Funciones_BD();
        public string formulario;

        public selectorprofesor()
        {
            InitializeComponent();
        }

        private void btniniciar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnreporte_Click(object sender, EventArgs e)
        {
                    frmreporteprofesores reporte = new frmreporteprofesores();
            reporte.profesion = cbprofesion.Text;
            reporte.escuela = cbescuela.Text;
            reporte.sexo = cbsexo.Text;
            reporte.Show();
                   
            this.Close();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
