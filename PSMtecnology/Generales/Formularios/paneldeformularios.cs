using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrabajoDeGrado.Secciones.Academico.Pasantias;

namespace TrabajoDeGrado.Modulos
{
    public partial class paneldeformularios : Form
    {

        rusticas formuladiorustica = new rusticas();
        public string idgeneral;
        public string tabla;
        public string autor;
        public string titulo;
        public string periodo;
        public Size tamaño;

        public Form formulariogeneral;
        public Funciones_Generales comun = new Funciones_Generales();

        public paneldeformularios()
        {
            InitializeComponent();
        }

        public Form currentForm = new Form(); // variable utilizada para determinar si ya hay un formulario hijo abierto

        public void formulario(Form formulariohijo)
        {
            currentForm = formulariohijo;
            formulariohijo.TopLevel = false;
            formulariohijo.Dock = DockStyle.Fill;
            formulariohijo.FormBorderStyle = FormBorderStyle.None;
            Panel_formularios.Controls.Add(formulariohijo);
            Panel_formularios.Tag = formulariohijo;
            formulariohijo.BringToFront();
            formulariohijo.Show();
        }

        private void Btncerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btngeneral_Click(object sender, EventArgs e)
        {
            currentForm.Hide();
            this.Size = tamaño;


        }

        private void btnrustica_Click(object sender, EventArgs e)
        {
            formulario(formuladiorustica);
            formuladiorustica.ID.Text = idgeneral;
            formuladiorustica.tabla = tabla;
            formuladiorustica.tbtitulo.Text = titulo;
            formuladiorustica.tbnombre.Text = autor;
            formuladiorustica.cbperiodo.Text= periodo;
            formuladiorustica.resumen();
            this.Size = new Size(640, 640);
            
        }
    }
}
