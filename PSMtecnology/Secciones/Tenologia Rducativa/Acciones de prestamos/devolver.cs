using Microsoft.VisualBasic;
using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using TrabajoDeGrado.Generales;
using TrabajoDeGrado.Modulos;

namespace TrabajoDeGrado.Secciones.Estudiantes_y_Profesores.Estudiantes
{
    public partial class devolver : Form
    {
        Funciones_Generales generales = new Funciones_Generales();
        Funciones_BD BD = new Funciones_BD();

        public string usuario;
        public devolver() { InitializeComponent(); }


        #region BOTONES
        private void Btnagregar_Click_1(object sender, EventArgs e)
        {
            if (dtfechaactual.Value > dtdevolucion.Value)
            {
                string sql = "INSERT INTO retrasos (cedulausuario, idproducto, entregaestipulada, fechadeentrega,estado, cota) values " +
                            " ('" + System.Convert.ToString(tbusuario.Text.Trim()) + "'," +
                            " '" + System.Convert.ToString(idlibro.Text) + "'," +
                            " '" + System.Convert.ToString(dtdevolucion.Text) + "'," +
                            " '" + System.Convert.ToString(dtfechaactual.Text) + "'," +
                            " '" + System.Convert.ToString("SIN PROCESAR") + "'," +
                            " '" + System.Convert.ToString(tbcota.Text) + "')"; 
                

                BD.agregar(sql,"El libro ha sido entregado despues de la fecha estipulada", true, usuario, "", "", tbcota.Text, false, this);
            }

            string SUMAR = "UPDATE libros  SET existencias = existencias +1 WHERE id= '" + idlibro.Text + "'";
            string borrar = "DELETE FROM prestamoslibros WHERE id ='" + id.Text + "'";


            BD.actualizar(SUMAR, "El libro ha sido entregado en el plazo correspondiente", false, "", "", "", false, this);
            BD.eliminar(borrar, false, "", this);
            this.Close();
            prestamos frm = (prestamos)Application.OpenForms["prestamos"];
            if (Application.OpenForms.OfType<prestamos>().Any())
            {
                frm.rellenargrid("SELECT p.id AS ID, p.idproducto AS LIBRO, p.cota AS COTA," +
            "CONCAT (u.primernombre,' ',u.segundonombre,' ',u.primerapellido,' ', u.segundoapellido) AS USUARIO " +
            "FROM prestamoslibros p INNER JOIN usuarios u ON p.cedulausuario= u.usuario WHERE p.estado = 'ACTIVO' ");
                frm.grid.Columns[1].Visible = false;

            }
            this.Close();

        }

        private void Btncerrar_Click(object sender, EventArgs e) { this.Close(); }
        #endregion


        #region FUNCION DE MODIFICACION

        public void autorrelleno()
        {
            BD.abrirconexion();

          
                SqlCommand comando = new SqlCommand("SELECT * FROM libros WHERE id = '" + idlibro.Text + "'", BD.conexion);
                SqlDataReader lector;
                lector = comando.ExecuteReader();
                if (lector.Read())
                {
                    tbtitulo.Text = lector["titulo"].ToString();
                    lector.Close();

                }
                else { lector.Close(); }
            

            

            SqlCommand comando2 = new SqlCommand("SELECT p.id AS ID, p.idproducto AS PRODUCTO, cedulausuario AS USUARIO, " +
            "CONCAT (u.primernombre,' ',u.segundonombre,' ',u.primerapellido,' ', u.segundoapellido) AS NOMBRE,  p.salida AS SALIDA, p.entrada AS ENTRADA " +
            "FROM prestamoslibros p INNER JOIN usuarios u ON p.cedulausuario= u.usuario WHERE id = '" + id.Text + "'", BD.conexion);
            SqlDataReader lector2;
            lector2 = comando2.ExecuteReader();
            if (lector2.Read())
            {
                tbsolicitante.Text = lector2["NOMBRE"].ToString();
                dtsalida.Text = lector2["SALIDA"].ToString();
                dtdevolucion .Text = lector2["ENTRADA"].ToString();
                tbusuario.Text = lector2["USUARIO"].ToString();

                lector2.Close();
                dtfechaactual.Value = DateTime.Today;
            }

            BD.conexion.Close();

            if (dtfechaactual.Value > dtdevolucion.Value)
            {
                lblfechaactual.ForeColor =  Color.Red;
            }

        }



        #endregion

        private void tbtitulo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

