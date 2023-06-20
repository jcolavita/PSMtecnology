using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrabajoDeGrado.Modulos;
using TrabajoDeGrado.Secciones.Estudiantes_y_Profesores.Estudiantes;

namespace TrabajoDeGrado.Generales
{
    public partial class mensajecorrecto : Form
    {
        public Form formulario;

        public mensajecorrecto()
        {
            InitializeComponent();
        }

        public void cerrar(Form formularioacerrar)
        {
            this.Close();
            if (formularioacerrar!=null)
            {
                formularioacerrar.Close();

            }
        }
        
        private void btniniciar_Click(object sender, EventArgs e)
        {
            
            cerrar(formulario);
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            cerrar(formulario);
        }
    }
}
