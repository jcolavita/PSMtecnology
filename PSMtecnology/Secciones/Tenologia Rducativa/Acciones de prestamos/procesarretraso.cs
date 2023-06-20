using Microsoft.VisualBasic;
using System;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;
using TrabajoDeGrado.Generales;
using TrabajoDeGrado.Modulos;

namespace TrabajoDeGrado.Secciones.Estudiantes_y_Profesores.Estudiantes
{
    public partial class procesarretraso : Form
    {
        Funciones_Generales generales = new Funciones_Generales();
        Funciones_BD BD = new Funciones_BD();
        public procesarretraso() { InitializeComponent();  }

        public void comprobartextbox(){
            var vr = !string.IsNullOrEmpty(tbtitulo.Text) &&
                !string.IsNullOrEmpty(tbnumero.Text);
            btnagregar.Enabled = vr;
        }

        #region BOTONES
        private void Btnagregar_Click_1(object sender, EventArgs e)
        {

            string sql = "UPDATE retrasos  SET estado ='PROCESADO', motivo='" + tbnumero.Text + "' " +
                "WHERE id = '" + id.Text + "'";

            string mensaje = "La falta ha sido procesada correctamente";
            BD.actualizar(sql, mensaje, true, "", "", "", false, this);

            retrasos frm = (retrasos)Application.OpenForms["retrasos"];
            if (Application.OpenForms.OfType<retrasos>().Any())
            {
                frm.cbtipo.SelectedIndex=0;
                frm.grid.Columns.Clear();
            }
            this.Close();

        }

        private void Btncerrar_Click(object sender, EventArgs e) { this.Close(); }
        #endregion

        #region FUNCION DE MODIFICACION

        public void autorrelleno()
        {
            BD.abrirconexion();
            SqlCommand comando = new SqlCommand("SELECT lib.titulo AS TITULO, r.motivo AS MOTIVO, r.entregaestipulada AS ESTIPULADA," +
                "r.fechadeentrega AS ENTREGA, r.motivoproceso AS RAZON, r.estado AS ESTADO" +
                " FROM retrasos r INNER JOIN libros lib ON r.idproducto = lib.id " +
                "WHERE r.id = '" + id.Text + "'", BD.conexion);
            SqlDataReader lector;
            lector = comando.ExecuteReader();
            if (lector.Read())
            {
                tbtitulo.Text = lector["TITULO"].ToString();
                tbmotivo.Text = lector["MOTIVO"].ToString();
                dtestipulada.Text = lector["ESTIPULADA"].ToString();
                dtentrega.Text = lector["ENTREGA"].ToString();
                tbnumero.Text = lector["RAZON"].ToString();
                tbestado.Text = lector["ESTADO"].ToString();

                lector.Close();

                if (tbestado.Text =="PROCESADO")
                {
                    btnagregar.Visible = false;
                    tbnumero.ReadOnly = true;
                }



            }
            BD.conexion.Close();
        }

        #endregion

        private void tbcantidad_TextChanged(object sender, EventArgs e)
        {
            comprobartextbox();
            tbtitulo.CharacterCasing = CharacterCasing.Upper;
            tbnumero.CharacterCasing = CharacterCasing.Upper;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            tbnumero.Visible = false;
            lblnumero.Visible = false;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            tbnumero.Visible = true;
            lblnumero.Visible = true;
        }
    }
}

