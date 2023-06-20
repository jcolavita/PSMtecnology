using Microsoft.VisualBasic;
using System;
using System.Data.SqlClient;
using System.Linq;
using System.Net.NetworkInformation;
using System.Windows.Forms;
using TrabajoDeGrado.Generales;
using TrabajoDeGrado.Modulos;

namespace TrabajoDeGrado.Secciones.Estudiantes_y_Profesores.Estudiantes
{
    public partial class Solicitarlibro : Form
    {
        Funciones_Generales generales = new Funciones_Generales();
        Funciones_BD BD = new Funciones_BD();
        

        public string usuario;
        public Solicitarlibro() { InitializeComponent(); }

        public void comprobartextbox(){
            var vr = !string.IsNullOrEmpty(tbcota.Text) &&
                !string.IsNullOrEmpty(tbtitulo.Text) &&
                !string.IsNullOrEmpty(tbautor.Text) &&
                !string.IsNullOrEmpty(tbeditorial.Text) &&
                !string.IsNullOrEmpty(cbmateria.Text);
            btnagregar.Enabled = vr;
        }

        #region BOTONES
        private void Btnagregar_Click_1(object sender, EventArgs e)
        {
            mensajeinformacion informacion = new mensajeinformacion();

            BD.abrirconexion();
            String solvencia = "SELECT * FROM retrasos WHERE cedulausuario = '" + usuario + "' AND estado ='SIN PROCESAR'";
            SqlCommand comando = new SqlCommand(solvencia, BD.conexion);
            SqlDataReader lector = comando.ExecuteReader();

            if (lector.Read())
            {
                informacion.Show();
                informacion.lblalerta.Text = "Usted posee una falta por retraso, " +
                    "por favor acuda con la jefa de pasantias para solventar su situacion";
                lector.Close();

                return;
            }
            lector.Close();

            String prestamopendiente = "SELECT * FROM prestamoslibros WHERE cedulausuario = '" + usuario + "' AND estado = 'PENDIENTE'";
            SqlCommand comando3 = new SqlCommand(prestamopendiente, BD.conexion);
            SqlDataReader lector3 = comando3.ExecuteReader();
            if (lector3.Read())
            {
                informacion.Show();
                informacion.lblalerta.Text = "Usted Ya posee una solicitud abierta";
                lector3.Close();

                return;

            }
            lector3.Close();

            String prestamoactivo = "SELECT * FROM prestamoslibros WHERE cedulausuario = '" + usuario + "'";
            SqlCommand comando2 = new SqlCommand(prestamoactivo, BD.conexion);
            SqlDataReader lector2 = comando2.ExecuteReader();
            if (lector2.Read())
            {
                informacion.Show();
                informacion.lblalerta.Text = "Usted ya posee un prestamo activo";
                lector2.Close();

                return;

            }
            lector2.Close();

            


            {
                string sql = "INSERT INTO prestamoslibros (idproducto, salida, entrada, cedulausuario, estado, cota) values " +
                            " ('" + System.Convert.ToString(lblid.Text) + "'," +
                            " '" + System.Convert.ToString(dtsalida.Text) + "'," +
                            " '" + System.Convert.ToString(dtdevolucion.Text) + "'," +
                            " '" + System.Convert.ToString(usuario) + "', "+
                            " '" + System.Convert.ToString("PENDIENTE") + "', " +
                            "'" + System.Convert.ToString(tbcota.Text) + "')" ;
                
                string restar = "UPDATE libros  SET existencias = existencias -1 WHERE id= '"+lblid.Text+"'";
                BD.actualizar(restar, "", false, "", "", "", false, this);
                string mensaje = "La solicitud ha sido realziada exitosamente";

                BD.agregar(sql, mensaje, true, usuario, "LIBRO", "SOLICITUD", tbcota.Text , true,this);



            }
            Libros frm = (Libros)Application.OpenForms["Libros"];
            if (Application.OpenForms.OfType<Libros>().Any())
            {
                frm.rellenargrid("SELECT CONCAT(cota, correlativo) AS COTA, titulo AS TITULO, " +
                "autor AS AUTOR, editorial AS EDITORIAL, existencias AS CANT , materia AS MATERIA FROM libros" +
                " WHERE existencias >= '1'");
            }
        }

        private void Btncerrar_Click(object sender, EventArgs e) { this.Close(); }
        #endregion

        #region EVENTOS DE OBJETOS
        private void tbeditorial_TextChanged(object sender, EventArgs e) { comprobartextbox(); }


        #endregion


        #region FUNCION DE MODIFICACION

        public void autorrelleno()
        {
            BD.abrirconexion();
            SqlCommand comando = new SqlCommand("SELECT * FROM libros WHERE CONCAT (cota,correlativo) = '" + tbcota.Text + "'", BD.conexion);
            SqlDataReader lector;
            lector = comando.ExecuteReader();
            if (lector.Read())
            {
                tbtitulo.Text = lector["titulo"].ToString();
                tbautor.Text = lector["autor"].ToString();
                tbeditorial.Text = lector["editorial"].ToString();
                cbmateria.Text = lector["materia"].ToString();
                lblid.Text = lector["id"].ToString();

            }
            BD.conexion.Close();
            dtsalida.Value = DateTime.Today;
            dtdevolucion.Value = dtsalida.Value.AddDays(3);
            if (dtdevolucion.Value.DayOfWeek ==DayOfWeek.Saturday )
            {
                dtdevolucion.Value = dtdevolucion.Value.AddDays(2);

            }else if(dtdevolucion.Value.DayOfWeek == DayOfWeek.Sunday)
            {
                dtdevolucion.Value = dtdevolucion.Value.AddDays(1);

            }
        }



        #endregion

        
    }
}

