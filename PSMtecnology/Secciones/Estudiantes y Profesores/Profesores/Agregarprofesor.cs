using Microsoft.VisualBasic;
using System;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;
using TrabajoDeGrado.Generales;
using TrabajoDeGrado.Modulos;

namespace TrabajoDeGrado.Secciones.Estudiantes_y_Profesores.Estudiantes
{
    public partial class Agregarprofesor : Form
    {
        Funciones_Generales generales = new Funciones_Generales();
        Funciones_BD BD = new Funciones_BD();
        public string usuario;

        Pagina_Pincipal.Pagina_principal principal = new Pagina_Pincipal.Pagina_principal();
        public Agregarprofesor() { InitializeComponent(); }

        public void comprobartextbox(){
            if (tbcodigo.Text.Length < 4)
            {
                Btnagregar.Enabled = false;
                return;
            }
            if (Tbtelefono.Text.Length < 7)
            {
                Btnagregar.Enabled = false;
                return;
            }
            if (Tbcedula.Text.Length < 8)
            {
                Btnagregar.Enabled = false;
                return;
            }

            var vr = !string.IsNullOrEmpty(Tbcedula.Text) &&
                !string.IsNullOrEmpty(Tbprimernombre.Text) &&
                !string.IsNullOrEmpty(Tbprimerapellido.Text) &&
                !string.IsNullOrEmpty(Cbtipo.Text) &&
                !string.IsNullOrEmpty(Cbescuela.Text) &&
                !string.IsNullOrEmpty(Cbsexo.Text)&&
                !string.IsNullOrEmpty(tbcodigo.Text) &&
                !string.IsNullOrEmpty(Tbtelefono.Text) &&
                !string.IsNullOrEmpty(Cbprofesion .Text);
            Btnagregar.Enabled = vr;
        }

        #region BOTONES
        private void Btnagregar_Click(object sender, EventArgs e)
        {
            if (Btnagregar.Text == "Actualizar")
            {
                string sql = "UPDATE profesores  tipodocumento ='" + Cbtipo.Text + "'," +
                    " profesion ='" + Cbprofesion.Text + "', especialidad='" + Tbespecialidad.Text + "', sexo='" + Cbsexo.Text + "', " +
                    "escuela='" + generales.comunes(0,Cbescuela, comun41, comun42, comun43, comun44, comun45, comun46, comun47) + "'," +
                    "correo ='" + Tbcorreo.Text + "' WHERE ciprofesor='" + Tbcedula.Text + "'";
                
                string sql2 = "UPDATE usuarios  SET primernombre ='" + Tbprimernombre.Text + "', segundonombre='" + Tbsegundonombre.Text + "'," +
                         " primerapellido ='" + Tbprimerapellido.Text + "',segundoapellido ='" + Tbsegundonombre.Text + "'," +
                         " telefono='" + Tbtelefono.Text + "', codigotlf ='"+tbcodigo.Text+"', correo='" + Tbcorreo.Text+"'" +
                         " WHERE usuario='" + Tbcedula.Text + "'";

                string mensaje = "El Docente ha sido modificado correctamente";

                BD.actualizar(sql, mensaje,  true, "", "", "", false, this);
                BD.actualizar(sql2, mensaje, false, usuario, "USUARIO-DOCENTE", Tbcedula.Text, true, this);

            }
            else
            {
                string sql = "INSERT INTO profesores (ciprofesor,  tipodocumento, sexo, escuela,profesion,especialidad) values " +
                    " ('" + System.Convert.ToString(Tbcedula.Text) + "'," +
                    " '" + System.Convert.ToString(Cbtipo.Text) + "'," +
                    " '" + System.Convert.ToString(Cbsexo.Text) + "'," +
                    " '" + System.Convert.ToString(generales.comunes(0, Cbescuela, comun41, comun42, comun43, comun44, comun45, comun46, comun47)) + "'," +
                    " '" + System.Convert.ToString(Cbprofesion.Text) + "'," +
                    " '" + System.Convert.ToString(Tbespecialidad.Text) + "')";

                string mensaje = "El docente ha sido registrado correctamente";
                
                string cedula = Tbcedula.Text.Substring(0, 4);
                string clave = "psm" + cedula;

                string sql2 = "INSERT INTO usuarios (usuario,clave, departamento, primernombre, segundonombre, primerapellido,segundoapellido, intento,codigotlf, telefono, correo ) values " +
                            " ('" + System.Convert.ToString(Tbcedula.Text) + "'," +
                            " '" + System.Convert.ToString(clave) + "'," +
                            " '" + System.Convert.ToString("DOCENTE") + "'," +
                            " '" + System.Convert.ToString(Tbprimernombre.Text) + "'," +
                            " '" + System.Convert.ToString(Tbsegundonombre.Text) + "'," +
                            " '" + System.Convert.ToString(Tbprimerapellido.Text) + "'," +
                            " '" + System.Convert.ToString(Tbsegundoapellido.Text) + "'," +
                            " '" + System.Convert.ToString("0") + "'," +
                            " '" + System.Convert.ToString(tbcodigo.Text) + "'," +
                            " '" + System.Convert.ToString(Tbtelefono.Text) + "'," +
                            " '" + System.Convert.ToString(Tbcorreo.Text) + "')";




                string mensaje2 = "La clave de ingreso es: " + clave;

                BD.agregar(sql2, mensaje2,true, usuario, "PROFESOR",  "CREACION", Tbcedula.Text, true,this);
                BD.agregar(sql, mensaje,true, usuario, "USUARIO", "CREACION", Tbcedula.Text, true, this);

            }
            Profesores frm = (Profesores)Application.OpenForms["Profesores"];
            if (Application.OpenForms.OfType<Profesores>().Any())
            {
                frm.rellenargrid("SELECT CONCAT(prof.tipodocumento,prof.ciprofesor )AS CEDULA ," +
            "CONCAT( users.primernombre,' ', users.segundonombre,' ', users.primerapellido,' ',users.segundoapellido) AS NOMBRE," +
            " CONCAT( users.codigotlf,' ', users.telefono)AS TELEFONO, prof.escuela AS ESCUELA, prof.profesion AS PROFESION,prof.especialidad AS ESPECIALIDAD " +
            "FROM profesores prof INNER JOIN usuarios users ON prof.ciprofesor = users.usuario");
            }
        }
        private void Btncerrar_Click(object sender, EventArgs e) { this.Close(); }
        #endregion

        #region EVENTOS DE OBJETOS
        private void Tbcedula_KeyPress(object sender, KeyPressEventArgs e) { generales.validarnumeros(e);  }
        private void Tbprimernombre_KeyPress(object sender, KeyPressEventArgs e) { generales.validarletras(e); }
        private void Cbprofesion_SelectedIndexChanged(object sender, EventArgs e) { comprobartextbox(); }
        private void Cbsexo_SelectedValueChanged(object sender, EventArgs e) { comprobartextbox(); }

        #endregion

        #region FUNCION DE MODIFICACION
        public void autorrelleno()
        {
            BD.abrirconexion();
            SqlCommand comando = new SqlCommand("SELECT prof.tipodocumento, prof.sexo, users.primernombre, users.segundonombre, users.primerapellido, users.segundoapellido," +            
                " users.telefono ,users.codigotlf, prof.escuela , prof.profesion ,prof.especialidad ,users.correo " +
                "FROM profesores prof INNER JOIN usuarios users ON prof.ciprofesor = users.usuario WHERE prof.ciprofesor = '" + Tbcedula.Text + "'", BD.conexion);
            SqlDataReader lector;
            lector = comando.ExecuteReader();
            if (lector.Read())
            {
                Tbprimernombre.Text = lector["primernombre"].ToString();
                Tbsegundonombre.Text = lector["segundonombre"].ToString();
                Tbprimerapellido.Text = lector["primerapellido"].ToString();
                Tbsegundoapellido.Text = lector["segundoapellido"].ToString();
                Tbtelefono.Text = lector["telefono"].ToString();
                Cbtipo.Text = lector["tipodocumento"].ToString();
                Cbsexo.Text = lector["sexo"].ToString();
                Cbescuela.Text = lector["escuela"].ToString();
                Tbcorreo.Text = lector["correo"].ToString();
                Cbprofesion.Text = lector["profesion"].ToString();
                Tbespecialidad.Text = lector["especialidad"].ToString();
                Tbtelefono.Text = lector["telefono"].ToString();
                tbcodigo.Text = lector["codigotlf"].ToString();
                Tbcorreo.Text = lector["correo"].ToString();
                string comun = lector["escuela"].ToString();
                lector.Close();
                generales.autorrellenocomun(comun, comun41, comun42, comun43, comun44, comun45, comun46, comun47,Cbescuela);
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

        private void Cbescuela_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Cbescuela.SelectedIndex==0)
            {
                panelcomunes.Visible = true;
            }
            else
            {
                panelcomunes.Visible = false;
                comun41.Checked = false;
                comun42.Checked = false;
                comun43.Checked = false;
                comun44.Checked = false;
                comun45.Checked = false;
                comun46.Checked = false;
                comun47.Checked = false;

            }
        }

        private void tbcodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            generales.validarnumeros(e);
        }
    }
}

