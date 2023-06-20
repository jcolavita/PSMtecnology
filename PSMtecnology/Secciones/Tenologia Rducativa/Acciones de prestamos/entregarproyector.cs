using Microsoft.VisualBasic;
using System;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;
using TrabajoDeGrado.Generales;
using TrabajoDeGrado.Modulos;

namespace TrabajoDeGrado.Secciones.Estudiantes_y_Profesores.Estudiantes
{
    public partial class entregarproyector : Form
    {
        Funciones_Generales generales = new Funciones_Generales();
        Funciones_BD BD = new Funciones_BD();
        public string idproyector;
        mensajecorrecto emergente = new mensajecorrecto();

        public string usuario;
        public entregarproyector() { InitializeComponent(); }

        public void comprobartextbox(){
            var vr = !string.IsNullOrEmpty(tbmateria.Text) &&
                !string.IsNullOrEmpty(tbaula.Text);
            btnentregar.Enabled = vr;
        }

        #region BOTONES
        private void Btnagregar_Click_1(object sender, EventArgs e)
        {

            if (btnentregar.Text=="Devolver")
            {
                string sql = "DELETE  FROM reservaproyector WHERE id = '" + ID.Text + "'";

                BD.eliminar(sql,true, "El proyector ha sido entregado",this);

                prestamos frm = (prestamos)Application.OpenForms["prestamos"];
                

                if (Application.OpenForms.OfType<prestamos>().Any())
                {
                    frm.rellenargrid("SELECT r.id AS ID,r.cedulausuario AS CEDULA, CONCAT (u.primernombre,' ',u.primerapellido) AS USUARIO, " +
                        "r.idproyector AS PROYECTOR,  r.salida AS DIA,  r.materia AS MATERIA, r.aula AS AULA " +
                        "FROM  reservaproyector r INNER JOIN  usuarios u ON r.cedulausuario = u.usuario WHERE r.estado = 'PENDIENTE'");
                }

            }
            else
            {
                BD.abrirconexion();

                string sql = "UPDATE reservaproyector SET estado = 'ACTIVO' WHERE id = '" + ID.Text + "'";

                string mensaje = "El proyector debe ser entregado el dia: " + dtdevolucion.Value + ".";

                BD.actualizar(sql, mensaje, true, "", "", "", false, this);
                prestamospendientes frm = (prestamospendientes)Application.OpenForms["prestamospendientes"];
                if (Application.OpenForms.OfType<prestamospendientes>().Any())
                {
                    frm.rellenargrid("SELECT r.id AS ID,r.cedulausuario AS CEDULA, CONCAT (u.primernombre,' ',u.primerapellido) AS USUARIO, " +
                    "r.idproyector AS PROYECTOR,  r.salida AS DIA,r.materia AS MATERIA, r.aula AS AULA " +
                    "FROM  reservaproyector r INNER JOIN  usuarios u ON r.cedulausuario = u.usuario WHERE r.estado = 'PENDIENTE'");
                }
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
            SqlCommand comando = new SqlCommand("SELECT * FROM reservaproyector WHERE id = '" + ID.Text + "'", BD.conexion);
            SqlDataReader lector;
            lector = comando.ExecuteReader();
            if (lector.Read())
            {
                tbmateria.Text = lector["materia"].ToString();
                tbaula.Text = lector["aula"].ToString();
                dthora.Text= lector["salida"].ToString();
                dtdevolucion.Text = lector["devolucion"].ToString();
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

        private void anular_Click(object sender, EventArgs e)
        {
            mensajeinformacion informacion = new mensajeinformacion();
            string sql = "DELETE  FROM reservaproyector WHERE id = '" + ID.Text + "'";

            BD.eliminar(sql,false,"",this);
            informacion.Show();
            informacion.lblalerta.Text = "La solicitud ha sido anulada";

            areapersonal frm1 = (areapersonal)Application.OpenForms["areapersonal"];
            if (Application.OpenForms.OfType<areapersonal>().Any())
            {
                frm1.cbtipo.SelectedIndex = -1;
            }

            prestamospendientes frm = (prestamospendientes)Application.OpenForms["prestamospendientes"];
            if (Application.OpenForms.OfType<prestamospendientes>().Any())
            {
                frm.rellenargrid("SELECT r.id AS ID,r.cedulausuario AS CEDULA, CONCAT (u.primernombre,' ',u.primerapellido) AS USUARIO, " +
                    "r.idproyector AS PROYECTOR,  r.salida AS SALIDA, r.devolucion AS DEVOLUCION, r.materia AS MATERIA, r.aula AS AULA " +
                    "FROM  reservaproyector r INNER JOIN  usuarios u ON r.cedulausuario = u.usuario WHERE r.estado = 'ACTIVO'");
            }


        }
    }
}

