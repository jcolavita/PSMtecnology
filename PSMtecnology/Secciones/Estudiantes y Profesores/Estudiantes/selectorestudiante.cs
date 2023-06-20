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
    public partial class selectorestudiante : Form
    {
        Funciones_BD bd = new Funciones_BD();
        public string formulario;

        public selectorestudiante()
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
                    frmreporteestudiante frmreporteestudiante= new frmreporteestudiante();
            frmreporteestudiante.escuela = CBescuela.Text;
            frmreporteestudiante.sexo = CBsexo.Text;

            frmreporteestudiante.Show();
                    
            this.Close();

        }
    }
}
