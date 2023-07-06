using DocumentFormat.OpenXml.Wordprocessing;
using Microsoft.Office.Interop.Word;
using Microsoft.VisualBasic;
using PSMtecnology.Generales.Clases;
using System;
using System.Data.SqlClient;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Windows.Forms;
using TrabajoDeGrado.Generales;
using TrabajoDeGrado.Modulos;
using Word = Microsoft.Office.Interop.Word;


namespace TrabajoDeGrado.Secciones.Estudiantes_y_Profesores.Estudiantes
{
    public partial class Agregarpasantias : Form
    {
        Object Omising = System.Reflection.Missing.Value;
        Microsoft.Office.Interop.Word.Application Words = new Microsoft.Office.Interop.Word.Application();
        Microsoft.Office.Interop.Word.Document worddoc = new Microsoft.Office.Interop.Word.Document();
        genero_y_profesiones genprof = new genero_y_profesiones();

        


        public Agregarpasantias() 
        { 
            InitializeComponent(); 
            BD.comboconsql(cbjurado1, cbjurado2, cbjurado2, cbjurado2);
            BD.periodosql(cbperiodo);
        }

        public void Comprobartextbox()
        {
            bool aprobado = true;
            if (cbestatus.Text == "REPROBADO")
            {
                aprobado = false;
            }

            var vr = !string.IsNullOrEmpty(tbcedula.Text) &&
                     !string.IsNullOrEmpty(tbtitulo.Text) &&
                     !string.IsNullOrEmpty(tbinstitucion.Text) &&
                     !string.IsNullOrEmpty(tbdepartamento.Text) &&
                     !string.IsNullOrEmpty(cbjurado1.Text) &&
                     !string.IsNullOrEmpty(cbjurado2.Text) &&
                     !string.IsNullOrEmpty(cbperiodo.Text) &&
                     !string.IsNullOrEmpty(cbintento.Text) &&
                     !string.IsNullOrEmpty(cbsemestre.Text) &&
                     !string.IsNullOrEmpty(cbcalsificacion.Text) &&
                     cbfechaservicio.Checked &&
                     cbfechaproyecto.Checked;
            Btnagregar.Enabled = vr;

            var BTNACTA = aprobado;
            btnacta.Enabled = BTNACTA;
        }

        Funciones_BD BD = new Funciones_BD();
        Funciones_Generales generales = new Funciones_Generales();
        Pagina_Pincipal.Pagina_principal principal = new Pagina_Pincipal.Pagina_principal();
        public string usuario;

        #region BOTONES
                
        private void Btnagregar_Click(object sender, EventArgs e)
        {
            bool acreditacion = false;
            string estudiantenombre = "UPDATE usuarios  SET primernombre ='" + tbprimernombre.Text + "', segundonombre='" + Tbsegundonombre.Text + "'," +
                    " primerapellido ='" + Tbprimerapellido.Text + "',segundoapellido ='" + Tbsegundoapellido.Text + "', estatus = '"+cbestatus.Text+"'" +
                    " WHERE usuario='" + tbcedula.Text + "'";
            BD.actualizar(estudiantenombre, "", false,"","","",false,this);
            
            string estudiante = "UPDATE estudiantes  SET escuela='" + cbescuela.Text + "'" +
                    "  WHERE ciestudiante='" + tbcedula.Text + "'";
            BD.actualizar(estudiante, "", false, "", "", "", false, this);

            if (ID.Visible == true)
           {
                string sql = "UPDATE pasantias  SET titulo ='" + tbtitulo .Text + "', institucion='" + tbinstitucion .Text + "'," +
                             " periodo ='" + cbperiodo .SelectedValue + "',semestre ='" + cbsemestre.SelectedIndex + "', " +
                             "intento='" + cbintento.SelectedIndex + "', clasificacion ='" + cbcalsificacion .SelectedIndex + "', " +
                             "departamento='" + tbdepartamento .Text + "', cijurado1 ='" + cbjurado1 .SelectedValue + "',cijurado2 ='" + cbjurado2 .SelectedValue + "'" +
                             ",acreditacion='"+ acreditacion+ "', fechaacreditacion = '" + fechaacreditacion.Text  +"'" +
                             "  WHERE ID='" + ID.Text + "'";
                string mensaje = "La Pasantia ha sido modificada correctamente";

                BD.actualizar(sql, mensaje, true, usuario, "PASANTIAS", ID.Text, true, this);
                generales.cerrarpanel();
            }
            else
            {
                string sql = "INSERT INTO pasantias (ciestudiante, titulo, institucion, periodo, semestre, intento, clasificacion, " +
                    "departamento, cijurado1, cijurado2, acreditacion, fechaacreditacion) values " +
                             " ('" + System.Convert.ToString(tbcedula.Text) + "'," +
                             " '" + System.Convert.ToString(tbtitulo .Text) + "'," +
                             " '" + System.Convert.ToString(tbinstitucion.Text) + "'," +
                             " '" + System.Convert.ToString(cbperiodo.SelectedValue ) + "'," +
                             " '" + System.Convert.ToString(cbsemestre.SelectedIndex) + "'," +
                             " '" + System.Convert.ToString(cbintento.SelectedIndex) + "'," +
                             " '" + System.Convert.ToString(cbcalsificacion.SelectedIndex) + "'," +
                             " '" + System.Convert.ToString(tbdepartamento.Text) + "'," +
                             " '" + System.Convert.ToString(cbjurado1 .SelectedValue ) + "'," +
                             " '" + System.Convert.ToString(cbjurado2 .SelectedValue ) + "'," +
                             " '" + System.Convert.ToString(acreditacion) + "'," +
                             " '" + System.Convert.ToString(fechaacreditacion.Value = DateTime.Today) + "')";

                string mensaje = "El proyecto ha sido registrado correctamente";

                BD.agregar(sql, mensaje, true, usuario,"PASANTIAS","CREACION",tbcedula.Text,true,this);

            }

            Pasantias frm = (Pasantias)System.Windows.Forms.Application.OpenForms["Pasantias"];
            if (System.Windows.Forms.Application.OpenForms.OfType<Pasantias>().Any())
            {
                frm.rellenargrid("SELECT p.ID, p.ciestudiante AS CEDULA, p.titulo AS TITULO, " +
            "CONCAT (users.primernombre,' ',users.segundonombre,' ',users.primerapellido,' ', users.segundoapellido) AS ESTUDIANTE," +
            "CONCAT (peri.año,'-',peri.semestre) AS PERIODO, est.escuela AS ESCUELA " +
            "FROM pasantias p " +
            "INNER JOIN estudiantes est ON est.ciestudiante = p.ciestudiante " +
            "INNER JOIN usuarios users ON est.ciestudiante = users.usuario " +
            "INNER JOIN periodo peri ON peri.id = p.periodo");
            }

        }
        
        private void btnbuscar_Click(object sender, EventArgs e)
            {
                BD.abrirconexion();

                string consulta = "SELECT ciestudiante, titulo,intento FROM pasantias WHERE ciestudiante='" + tbcedula.Text + "' ORDER BY intento DESC";
                string consultaestudiante = "SELECT * FROM usuarios WHERE usuario = '" + tbcedula.Text + "'";
                string seleccionarescuela = "SELECT escuela FROM estudiantes WHERE ciestudiante = '" + tbcedula.Text + "'";

                BD.rellenarestudiante(tbcedula, consultaestudiante, tbprimernombre, Tbsegundonombre, Tbprimerapellido, Tbsegundoapellido,
                    panel, btnbuscar, btnlimpiar, tbcedula,cbescuela,seleccionarescuela,cbintento );
            BD.periodoproyectoyservicio(lblfechaproyecto, lblfechaservicio, tbcedula, cbfechaservicio, cbfechaproyecto, tbtitulo);
            tbtitulo.Text = "";
            BD.comprobarregistro (consulta, tbtitulo, Btnagregar, btnbuscar, btnlimpiar, panel,cbintento,cbperiodo,cbescuela,"pasantias");

            }

        private void btnlimpiar_Click(object sender, EventArgs e)
            {
            tbcedula.Text = "";
            tbprimernombre.Text = "";
            Tbprimerapellido.Text = "";
            Tbsegundonombre.Text = "";
            Tbsegundoapellido.Text = "";
            cbescuela.SelectedIndex = -1;
            tbtitulo.Text = "";
            tbinstitucion.Text = "";
            cbperiodo.SelectedIndex  = -1;
            cbsemestre.SelectedIndex = -1;
            cbintento.SelectedIndex = -1;
            cbcalsificacion.SelectedIndex = -1;
            tbdepartamento.Text = "";
            cbacreditacion .Checked = false;
            cbfechaservicio.Checked = false;
            cbfechaproyecto.Checked = false;
            tbcedula.Enabled = true;
            panel.Enabled = false;   

            btnbuscar.Enabled = true;
            btnlimpiar.Enabled = false;
            }

        #endregion

        #region EVENTOS DE OBJETOS
        
        private void tbcedula_KeyPress_1(object sender, KeyPressEventArgs e) { generales.validarnumeros(e); }
        private void tbtitulo_TextChanged(object sender, EventArgs e) { Comprobartextbox(); }
        private void cbacreditacion_CheckedChanged(object sender, EventArgs e)
        {
            if (cbacreditacion.Checked == true) { fechaacreditacion.Visible = true; }
            else { fechaacreditacion.Visible = false; }

        }

        private void tbprimernombre_TextChanged(object sender, EventArgs e)
        {
            tbprimernombre.Text = tbprimernombre.Text.ToUpper();
            tbprimernombre.Select(tbprimernombre.Text.Length, 0);
            Comprobartextbox();
        }

        private void Tbsegundonombre_TextChanged(object sender, EventArgs e)
        {
            Tbsegundonombre.Text = Tbsegundonombre.Text.ToUpper();
            Tbsegundonombre.Select(Tbsegundonombre.Text.Length, 0);
            Comprobartextbox();
        }

        private void Tbprimerapellido_TextChanged(object sender, EventArgs e)
        {
            Tbprimerapellido.Text = Tbprimerapellido.Text.ToUpper();
            Tbprimerapellido.Select(Tbprimerapellido.Text.Length, 0);
            Comprobartextbox();
        }

        private void Tbsegundoapellido_TextChanged(object sender, EventArgs e)
        {
            Tbsegundoapellido.Text = Tbsegundoapellido.Text.ToUpper();
            Tbsegundoapellido.Select(Tbsegundoapellido.Text.Length, 0);
            Comprobartextbox();
        }

        private void tbtitulo_TextChanged_1(object sender, EventArgs e)
        {
            tbtitulo.Text = tbtitulo.Text.ToUpper();
            tbtitulo.Select(tbtitulo.Text.Length, 0);
            Comprobartextbox();
        }

        private void tbinstitucion_TextChanged(object sender, EventArgs e)
        {
            tbinstitucion.Text = tbinstitucion.Text.ToUpper();
            tbinstitucion.Select(tbinstitucion.Text.Length, 0);
            Comprobartextbox();
        }

        private void tbdepartamento_TextChanged(object sender, EventArgs e)
        {
            tbdepartamento.Text = tbdepartamento.Text.ToUpper();
            tbdepartamento.Select(tbdepartamento.Text.Length, 0);
            Comprobartextbox();
        }

        private void Tbprimerapellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            generales.validarletras(e);
        }

        #endregion

        #region FUNCION DE MODIFICACION 

        public void rellenarcampos()
    {
            BD.abrirconexion();
            BD.periodoproyectoyservicio(lblfechaproyecto, lblfechaservicio, tbcedula, cbfechaservicio, cbfechaproyecto, tbtitulo);

            SqlCommand comando = new SqlCommand("SELECT * FROM pasantias WHERE ID = '" + ID.Text + "'", BD.conexion);
            SqlDataReader lector = comando.ExecuteReader(); ;


            if (lector.Read())
            {
                tbtitulo.Text = lector["titulo"].ToString();
                tbinstitucion.Text = lector["institucion"].ToString();
                tbdepartamento.Text = lector["departamento"].ToString();
                cbperiodo.SelectedValue =  lector["periodo"].ToString();
                cbintento.SelectedIndex = Int32.Parse(lector["intento"].ToString());
                cbsemestre.SelectedIndex = Int32.Parse(lector["semestre"].ToString());
                cbcalsificacion.SelectedIndex = Int32.Parse(lector["clasificacion"].ToString());
                cbjurado1.SelectedValue = Int32.Parse(lector["cijurado1"].ToString());
                cbjurado2.SelectedValue = Int32.Parse(lector["cijurado2"].ToString());
                lector.Close();
            }


        }

        #endregion

        private void btnacta_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Word |*.docx";
            string ARCHIVO = "";


            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                ARCHIVO = saveFileDialog1.FileName;

            }
            File.Copy(System.Windows.Forms.Application.StartupPath + @"\templates\PASANTIAS - ACTA ORDINARIO(TEMPLATE).docx", System.Windows.Forms.Application.StartupPath + @"\temp\temp-teporalpasantias.docx", true);


            string ruta = System.Windows.Forms.Application.StartupPath + @"\temp\temp-teporalpasantias.docx";
            generales.funcion(ruta, "(dia)", DateTime.Today.Day.ToString(), ARCHIVO);
            generales.funcion(ruta, "(mes)", DateTime.Today.Month.ToString(), ARCHIVO);
            generales.funcion(ruta, "(año)", DateTime.Today.Year.ToString(), ARCHIVO);
            generales.funcion(ruta, "(cijurado1)", cbjurado1.SelectedValue.ToString(), ARCHIVO);
            generales.funcion(ruta, "(cijurado2)", cbjurado2.SelectedValue.ToString(), ARCHIVO);
            generales.funcion(ruta,"(escuela)", generales.cambia(genprof.escuela(Int32.Parse(tbcedula.Text))), ARCHIVO);
            generales.funcion(ruta, "(estudiante)", generales.cambia(tbprimernombre.Text + " " + Tbsegundonombre.Text + " " + Tbprimerapellido.Text + " " + Tbsegundoapellido.Text), ARCHIVO);
            generales.funcion(ruta, "(ciestudiante)", tbcedula.Text, ARCHIVO);
            generales.funcion(ruta, "(periodo)", cbperiodo.Text, ARCHIVO);
            generales.funcion(ruta, "(calificacion)", cbcalsificacion.Text, ARCHIVO);

        }
    }
}

