using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrabajoDeGrado.Generales;
using TrabajoDeGrado.Modulos;

namespace TrabajoDeGrado.Secciones.Academico.Pasantias
{
    public partial class rusticas : Form
    {


        Funciones_BD BD = new Funciones_BD();
        OpenFileDialog archivo = new OpenFileDialog();
        public string tabla;


        public void Comprobartextbox()
        {
            var vr = !string.IsNullOrEmpty(tbruta.Text) &&
                     !string.IsNullOrEmpty(tbresumen.Text);
                     
            Btnagregar.Enabled = vr;

        }

        public rusticas()
        {
            InitializeComponent();
            BD.periodosql(cbperiodo);
        }

        private void btnbuscardocumento_Click(object sender, EventArgs e)
        {
            archivo.InitialDirectory = "C:";
            archivo.Filter = " Pdf Files|*.pdf";
            archivo.FilterIndex = 1;

            if (archivo.ShowDialog() == DialogResult.OK) {
                tbruta.Text = archivo.FileName;
            }
        }

        private void Btnagregar_Click(object sender, EventArgs e)
        {
            byte[] a;
            Stream mystream = archivo.OpenFile();
            MemoryStream obj= new MemoryStream();
            mystream.CopyTo(obj);
            a = obj.ToArray();

            BD.Rustica=a;
            BD.Resumen = tbresumen.Text;
            BD.agregardocumento(tabla,ID.Text );

        }

        public void resumen()
        {
            BD.abrirconexion();
            SqlCommand comando = new SqlCommand("SELECT * FROM "+ tabla+" WHERE ID = '"+ ID.Text +"'", BD.conexion);
            SqlDataReader lector = comando.ExecuteReader();

            if (lector.Read())
            {
                tbresumen.Text = lector["resumen"].ToString();
                
                lector.Close();
            }
        }

        public void autor()
        {
            BD.abrirconexion();
            SqlCommand comando = new SqlCommand("SELECT * FROM " + tabla + " WHERE ID = '" + ID.Text + "'", BD.conexion);
            SqlDataReader lector = comando.ExecuteReader();

            if (lector.Read())
            {
                tbnombre.Text= lector["ciestudiante"].ToString();

                lector.Close();
            }

            SqlCommand comando2 = new SqlCommand("SELECT * FROM estudiantes WHERE cedula = '" + tbnombre.Text + "'", BD.conexion);
            SqlDataReader lector2 = comando2.ExecuteReader();

            if (lector2.Read())
            {
                tbnombre.Text = lector2["primernombre"].ToString()+" "+
                    lector2["segundonombre"].ToString()+" "+
                    lector2["primerapellido"].ToString()+" "+
                    lector2["segundoapellido"].ToString();

                lector2.Close();
            }

        }
        private void tbresumen_TextChanged(object sender, EventArgs e)
        {
            tbresumen.Text = tbresumen.Text.ToUpper();
            tbresumen.Select(tbresumen.Text.Length, 0);
            Comprobartextbox();
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            tbruta.Text = "";
        }
    }
}
