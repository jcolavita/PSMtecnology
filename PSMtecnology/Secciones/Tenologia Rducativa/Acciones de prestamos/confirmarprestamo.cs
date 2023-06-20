using Microsoft.VisualBasic;
using System;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;
using TrabajoDeGrado.Generales;
using TrabajoDeGrado.Modulos;

namespace TrabajoDeGrado.Secciones.Estudiantes_y_Profesores.Estudiantes
{
    public partial class confirmarprestamo : Form
    {
        Funciones_Generales generales = new Funciones_Generales();
        Funciones_BD BD = new Funciones_BD();

        public string usuario;
        public confirmarprestamo() { InitializeComponent(); }


        #region BOTONES
        private void Btnagregar_Click_1(object sender, EventArgs e)
        {
            string sql = "UPDATE prestamoslibros SET estado = 'ACTIVO' WHERE id = '" + id.Text + "'";


            string mensaje = "El prestamo se ha realizado exitosamentem el libro debera ser devuelto el dia: " + DateTime.Today.AddDays(3) + "";

            BD.actualizar(sql, mensaje,true, "", "", "", false, this);

            prestamospendientes frm = (prestamospendientes)Application.OpenForms["prestamospendientes"];
            if (Application.OpenForms.OfType<prestamospendientes>().Any())
            {
                frm.rellenargrid("SELECT p.id AS ID, p.idproducto AS PRODUCTO, " +
            "CONCAT (u.primernombre,' ',u.segundonombre,' ',u.primerapellido,' ', u.segundoapellido) AS USUARIO " +
            "FROM prestamoslibros p INNER JOIN usuarios u ON p.cedulausuario= u.usuario WHERE p.ESTADO = 'PENDIENTE' ");
            }
        }

        private void Btncerrar_Click(object sender, EventArgs e) { this.Close(); }
        #endregion


        #region FUNCION DE MODIFICACION

        public void autorrelleno()
        {
            BD.abrirconexion();

            
                SqlCommand comando = new SqlCommand("SELECT * FROM libros WHERE id = '" + tbcodigo.Text + "'", BD.conexion);
                SqlDataReader lector;
                lector = comando.ExecuteReader();
                if (lector.Read())
                {
                    tbtitulo.Text = lector["titulo"].ToString();
                    tbcota.Text = lector["cota"].ToString() + lector["correlativo"].ToString();
                    lector.Close();

                }
                else{lector.Close();}
            
            
            


            SqlCommand comando2 = new SqlCommand("SELECT p.id AS ID, p.idproducto AS PRODUCTO, cedulausuario AS USUARIO, " +
            "CONCAT (u.primernombre,' ',u.segundonombre,' ',u.primerapellido,' ', u.segundoapellido) AS NOMBRE, p.salida AS SALIDA, p.entrada AS ENTRADA " +
            "FROM prestamoslibros p INNER JOIN usuarios u ON p.cedulausuario= u.usuario WHERE id = '" + id.Text + "'", BD.conexion);
            SqlDataReader lector2;
            lector2 = comando2.ExecuteReader();
            if (lector2.Read())
            {
                tbsolicitante.Text = lector2["NOMBRE"].ToString();
                dtsalida.Text = lector2["SALIDA"].ToString();
                dtdevolucion .Text = lector2["ENTRADA"].ToString();
                tbcedula.Text = lector2["USUARIO"].ToString();
                lector2.Close();
            }

            BD.conexion.Close();

        }


        #endregion

        private void btncancelar_Click(object sender, EventArgs e)
        {
            string restar = "DELETE FROM prestamoslibros WHERE id ='" + id.Text + "'";
            string SUMAR = "UPDATE libros  SET existencias = existencias +1 WHERE id= '" + tbcodigo.Text + "'";

            BD.eliminar(restar,false,"",this);
            BD.actualizar(SUMAR, "La solicitud de prestamo se ha cancelado", true, "", "", "", false, this);

            areapersonal frm1 = (areapersonal)Application.OpenForms["areapersonal"];
            if (Application.OpenForms.OfType<areapersonal>().Any())
            {
                frm1.cbtipo.SelectedIndex = -1;
            }

            prestamospendientes frm = (prestamospendientes)Application.OpenForms["prestamospendientes"];
            if (Application.OpenForms.OfType<prestamospendientes>().Any())
            {
                frm.rellenargrid("SELECT p.id AS ID, p.idproducto AS PRODUCTO, " +
            "CONCAT (u.primernombre,' ',u.segundonombre,' ',u.primerapellido,' ', u.segundoapellido) AS USUARIO " +
            "FROM prestamoslibros p INNER JOIN usuarios u ON p.cedulausuario= u.usuario WHERE p.estado = 'PENDIENTE' ");
            }
            this.Close();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

