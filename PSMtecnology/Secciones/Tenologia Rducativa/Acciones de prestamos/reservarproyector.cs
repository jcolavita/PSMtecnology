using Microsoft.VisualBasic;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using TrabajoDeGrado.Generales;
using TrabajoDeGrado.Modulos;

namespace TrabajoDeGrado.Secciones.Estudiantes_y_Profesores.Estudiantes
{
    public partial class reservarproyector : Form
    {
        Funciones_Generales generales = new Funciones_Generales();
        Funciones_BD BD = new Funciones_BD();
        public string idproyector;
        mensajecorrecto emergente = new mensajecorrecto();

        public string usuario;
        public reservarproyector() { InitializeComponent(); }

        public void comprobartextbox(){
            var vr = !string.IsNullOrEmpty(tbmateria.Text) &&
                !string.IsNullOrEmpty(tbaula.Text);
            btnagregar.Enabled = vr;
        }

        #region BOTONES
        private void Btnagregar_Click_1(object sender, EventArgs e)
        {

            BD.abrirconexion();
            mensajeinformacion informacion = new mensajeinformacion();

            String prestamoactivo = "SELECT * FROM reservaproyector WHERE cedulausuario = '" + tbcedula.Text + "'";
            SqlCommand comando2 = new SqlCommand(prestamoactivo, BD.conexion);
            SqlDataReader lector2 = comando2.ExecuteReader();
            if (lector2.Read())
            {
                informacion.Show();
                informacion.lblalerta.Text="Usted Ya posee un prestamo activo";
                lector2.Close();
                return;
            }
            lector2.Close();

            SqlCommand comando = new SqlCommand("SELECT * FROM reservaproyector WHERE" +
                " (salida BETWEEN '" + dthora.Value + "' AND '" + dtdevolucion.Value + "') OR " +
                " (devolucion BETWEEN '" + dthora.Value + "' AND '" + dtdevolucion.Value + "') AND idproyector = '"+idproyector+"'", BD.conexion);
            SqlDataReader lector = comando.ExecuteReader();
            if (lector.Read())
            {
                emergente.Show();
                emergente.lblalerta.Text = "El proyectores ya se encuentran reservador en las horas solicitadas, por favor seleccione otro";
                lector.Close();
            }
            else
            { 
                    string sql = "INSERT INTO reservaproyector (cedulausuario, idproyector, salida, devolucion,materia,aula,estado) values " +
                                " ('" + System.Convert.ToString(tbcedula.Text) + "'," +
                                " '" + System.Convert.ToString(idproyector) + "'," +
                                " '" + System.Convert.ToString(dthora.Value) + "'," +
                                " '" + System.Convert.ToString(dtdevolucion.Value) + "'," +
                                " '" + System.Convert.ToString(tbmateria.Text) + "'," +
                                " '" + System.Convert.ToString(tbaula.Text) + "'," +
                                " '" + System.Convert.ToString("PENDIENTE") + "')";

                    BD.agregar(sql, "La reservacion se ha creado satisfactoriamente", true,usuario, "PROYECTOR", "RESERVACION", tbcedula.Text, true,this);
                lector.Close();


            }

            this.Close();
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
            SqlCommand comando = new SqlCommand("SELECT * FROM usuarios WHERE usuario = '" + tbcedula.Text + "'", BD.conexion);
            SqlDataReader lector;
            lector = comando.ExecuteReader();
            if (lector.Read())
            {
                tbnombre.Text = lector["primernombre"].ToString()+" "+ lector["primerapellido"].ToString();

            }

        }




        #endregion

        private void dtsalida_ValueChanged(object sender, EventArgs e)
        {
            dthora.Value = dtfecha.Value.Date;
            dthora.Enabled = true; 
            dtdevolucion.Value = dtfecha.Value.Date;
            dtdevolucion.Enabled = true;
        }

        private void dtdevolucion_ValueChanged(object sender, EventArgs e)
        {
            comprobartextbox();
        }
    }
}

