using Microsoft.VisualBasic;
using System;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;
using TrabajoDeGrado.Generales;
using TrabajoDeGrado.Modulos;

namespace TrabajoDeGrado.Secciones.Estudiantes_y_Profesores.Estudiantes
{
    public partial class Agregarestudiante : Form
    {
        Funciones_Generales generales = new Funciones_Generales();
        Funciones_BD BD = new Funciones_BD();
        public string usuario;
        public Agregarestudiante() { InitializeComponent(); }

        public void comprobartextbox(){
            if (tbcodigo.Text.Length<4)
            {
                Btnagregar.Enabled = false;
                return;
            }
            if (Tbtelefono.Text.Length <7)
            {
                Btnagregar.Enabled = false;
                return;
            }
            if (Tbcedula.Text.Length<8)
            {
                Btnagregar.Enabled = false;
                return;
            }

            var vr = !string.IsNullOrEmpty(Tbcedula.Text) &&
                !string.IsNullOrEmpty(Tbprimernombre.Text) &&
                !string.IsNullOrEmpty(Tbprimerapellido.Text) &&
                !string.IsNullOrEmpty(Cbtipo.Text) &&
                !string.IsNullOrEmpty(Cbescuela.Text) &&
                !string.IsNullOrEmpty(tbcodigo .Text) &&
                !string.IsNullOrEmpty(Tbtelefono.Text) &&
                !string.IsNullOrEmpty(Cbsexo.Text);
            Btnagregar.Enabled = vr;
        }

        #region BOTONES
        private void Btnagregar_Click(object sender, EventArgs e)
        {

            if (Btnagregar.Text=="Actualizar")
            {
                string sql = "UPDATE estudiantes  SET  tipo ='" + Cbtipo.Text + "'," +
                            " sexo='" + Cbsexo.Text + "', escuela='" + Cbescuela.Text + "' WHERE ciestudiante='" + Tbcedula.Text + "'";
                
                string sql2 = "UPDATE usuarios  SET primernombre ='" + Tbprimernombre.Text + "', segundonombre='" + Tbsegundonombre.Text + "'," +
                           " primerapellido ='" + Tbprimerapellido.Text + "',segundoapellido ='" + Tbsegundoapellido.Text + "'," +
                           "telefono='" + Tbtelefono.Text + "', codigotlf = '" +tbcodigo.Text+ "', correo = '" + Tbcorreo.Text + "'" +
                           " WHERE usuario='" + Tbcedula.Text + "'";

                string mensaje = "El estudiante ha sido modificado correctamente";
                BD.actualizar(sql, mensaje,true, "", "", "", false, this);
                BD.actualizar(sql2, mensaje, false,usuario, "USUARIO/ESTUDIANTE", Tbcedula.Text, true, this);
            }
            else
            {
                string sql = "INSERT INTO estudiantes (ciestudiante, tipo,  sexo, escuela) values " +
                            " ('" + System.Convert.ToString(Tbcedula.Text) + "'," +
                            " '" + System.Convert.ToString(Cbtipo.Text) + "'," +
                            " '" + System.Convert.ToString(Cbsexo.Text) + "'," +
                            " '" + System.Convert.ToString(Cbescuela.Text) + "')";

                string mensaje = "El estudiante ha sido registrado exitosamente";

                

                string cedula = Tbcedula.Text.Substring(0, 4);
                string clave = "psm" + cedula;

                string sql2 = "INSERT INTO usuarios (usuario,clave, departamento, primernombre," +
                            " segundonombre, primerapellido,segundoapellido, intento, telefono, codigotlf, correo ) values " +
                            " ('" + System.Convert.ToString(Tbcedula.Text) + "'," +
                            " '" + System.Convert.ToString(clave) + "'," +
                            " '" + System.Convert.ToString("ESTUDIANTE") + "'," +
                            " '" + System.Convert.ToString(Tbprimernombre.Text) + "'," +
                            " '" + System.Convert.ToString(Tbsegundonombre.Text) + "'," +
                            " '" + System.Convert.ToString(Tbprimerapellido.Text) + "'," +
                            " '" + System.Convert.ToString(Tbsegundoapellido.Text) + "'," +
                            " '" + System.Convert.ToString("0") + "'," +
                            " '" + System.Convert.ToString(Tbtelefono.Text) + "'," +
                            " '" + System.Convert.ToString(tbcodigo.Text) + "'," +
                            " '" + System.Convert.ToString(Tbcorreo.Text) + "')";


                string mensaje2 = "La clave de ingreso es: " + clave;

                BD.agregar(sql2, mensaje2,true, usuario, "ESTUDIANTE",  "CREACION", Tbcedula.Text, true,this);
                BD.agregar(sql, mensaje,true,  usuario, "USUARIO",  "CREACION", Tbcedula.Text, true,this);

            }
            Estudiantes frm = (Estudiantes)Application.OpenForms["Estudiantes"];
            if (Application.OpenForms.OfType<Estudiantes>().Any())
            {
                frm.rellenargrid("SELECT CONCAT(est.tipo,est.ciestudiante )AS CEDULA ,CONCAT(users.primernombre,' ',users.segundonombre,' ',users.primerapellido,' ',users.segundoapellido) AS ESTUDIANTE," +
            " CONCAT(users.codigotlf,'-',users.telefono)AS TELEFONO , est.escuela AS ESCUELA " +
            " FROM estudiantes est INNER JOIN usuarios users ON est.ciestudiante = users.usuario ");
            }


        }
        private void Btncerrar_Click(object sender, EventArgs e) { this.Close(); }
        #endregion

        #region EVENTOS DE OBJETOS
        private void Tbcedula_KeyPress(object sender, KeyPressEventArgs e) { generales.validarnumeros(e); }
        private void Tbprimernombre_KeyPress(object sender, KeyPressEventArgs e) { generales.validarletras(e); }
        #endregion


        #region FUNCION DE MODIFICACION

        public void autorrelleno()
        {
            BD.abrirconexion();
            SqlCommand comando = new SqlCommand("SELECT est.tipo, users.primernombre,users.segundonombre,users.primerapellido,users.segundoapellido, " +
                " users.codigotlf, users.telefono, est.escuela , users.correo,  est.sexo, est.escuela " +
                " FROM estudiantes est INNER JOIN usuarios users ON est.ciestudiante = users.usuario WHERE est.ciestudiante = '" + Tbcedula.Text + "'", BD.conexion);
            SqlDataReader lector;
            lector = comando.ExecuteReader();
            if (lector.Read())
            {
                Tbprimernombre.Text = lector["primernombre"].ToString();
                Tbsegundonombre.Text = lector["segundonombre"].ToString();
                Tbprimerapellido.Text = lector["primerapellido"].ToString();
                Tbsegundoapellido.Text = lector["segundoapellido"].ToString();
                tbcodigo.Text = lector["codigotlf"].ToString();

                Tbtelefono.Text = lector["telefono"].ToString();
                Cbtipo.Text = lector["tipo"].ToString();
                Cbsexo.Text = lector["sexo"].ToString();
                Cbescuela.Text = lector["escuela"].ToString();
                Tbcorreo.Text = lector["correo"].ToString();

            }
            BD.conexion.Close();
        }

        #endregion

        private void Tbprimernombre_TextChanged(object sender, EventArgs e)
        {
            comprobartextbox();
            Tbprimernombre.CharacterCasing = CharacterCasing.Upper;
            Tbsegundonombre.CharacterCasing = CharacterCasing.Upper;
            Tbprimerapellido.CharacterCasing = CharacterCasing.Upper;
            Tbsegundoapellido.CharacterCasing = CharacterCasing.Upper;

        }

        private void Tbcorreo_TextChanged(object sender, EventArgs e)
        {
            Tbcorreo.CharacterCasing = CharacterCasing.Upper;
        }

        private void tbcodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            generales.validarnumeros(e);
        }
    }
}

