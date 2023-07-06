using Microsoft.VisualBasic;
using System;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Windows.Forms;
using TrabajoDeGrado.Generales;
using TrabajoDeGrado.Generales.Clases;
using TrabajoDeGrado.Modulos;
using Word = Microsoft.Office.Interop.Word;
using Microsoft.VisualBasic.Devices;
using PSMtecnology.Generales.Clases;
using TrabajoDeGrado.Secciones.Academico.Pasantias;
using Microsoft.Office.Interop.Word;
using System.Runtime.InteropServices;
using System.IO;
using DocumentFormat.OpenXml.Wordprocessing;
using DocumentFormat.OpenXml.Drawing.Charts;
using DocumentFormat.OpenXml.Office2010.Excel;
using DocumentFormat.OpenXml.Spreadsheet;
using System.Collections.Concurrent;
using System.Globalization;

namespace TrabajoDeGrado.Secciones.Estudiantes_y_Profesores.Estudiantes
{
    public partial class Agregartrabajo : Form
    {
        Funciones_Generales generales = new Funciones_Generales();
        Funciones_BD BD = new Funciones_BD();
        lineasdeinvestigacion lineas = new lineasdeinvestigacion();
        public string usuario="";
        Computer pc = new Computer();
        genero_y_profesiones genprof = new genero_y_profesiones();

        Pagina_Pincipal.Pagina_principal principal = new Pagina_Pincipal.Pagina_principal();

        public Agregartrabajo() { 
            InitializeComponent(); 
            BD.comboconsql(cbjurado1, cbjurado2, cbjurado3,cbtutor);
            BD.periodosql(cbperiodo);
        }

        public void comprobartextbox(){
            bool aprobado = true;
            if (cbestatus.Text == "REPROBADO")
            {
                aprobado = false;
            }

            var vr = !string.IsNullOrEmpty(tbcedula.Text) &&
                     !string.IsNullOrEmpty(tbtitulo.Text) &&
                     !string.IsNullOrEmpty(tbseccion.Text) &&
                     !string.IsNullOrEmpty(cbperiodo.Text) &&
                     !string.IsNullOrEmpty(cbintento.Text) &&
                     !string.IsNullOrEmpty(cblinea.Text) &&
                     !string.IsNullOrEmpty(cbeje.Text) &&
                     cbfechaservicio.Checked &&
                     cbfechaproyecto .Checked;
            Btnagregar.Enabled = vr;

            var BTNACTA = aprobado;
            btnacta.Enabled = BTNACTA;

        }

        #region BOTONES
        
        
        private void Btnagregar_Click(object sender, EventArgs e)
        {
            string estudiantenombre = "UPDATE usuarios  SET primernombre ='" + tbprimernombre.Text + "', segundonombre='" + Tbsegundonombre.Text + "'," +
                    " primerapellido ='" + Tbprimerapellido.Text + "',segundoapellido ='" + Tbsegundoapellido.Text + "'" +
                    " WHERE usuario='" + tbcedula.Text + "'";
            BD.actualizar(estudiantenombre, "",  false, "", "", "", false, this);

            string estudiante = "UPDATE estudiantes  SET escuela='" + cbescuela.Text + "'" +
                    "  WHERE ciestudiante='" + tbcedula.Text + "'";
            BD.actualizar(estudiante, "",  false, "", "", "", false, this);

            if (ID.Visible == true)
           {
            string sql = "UPDATE trabajogrado  SET periodo ='" + cbperiodo.SelectedValue + "', seccion='" + tbseccion.Text + "', " +
                         "fechadefensa ='" + dtfecha.Text + "',titulo ='" + tbtitulo.Text + "', " +
                         "cijurado1='" + cbjurado1.SelectedValue + "', cijurado2 ='" + cbjurado2.SelectedValue + "', " +
                         "cijurado3='" + cbjurado3.SelectedValue + "', citutor ='" + cbtutor.SelectedValue + "',intento ='" + cbintento.SelectedIndex + "', " +
                         "sector ='"+ tbsector.Text+"', empresa = '" + tbempresa.Text +"', linea ='"+ cblinea.Text +"', eje = '"+cbeje.Text+"', estatus ='"+cbestatus.Text+"' " +
                         "WHERE ID='" + ID.Text + "'";
            string mensaje = "El proyecto ha sido modificado correctamente";

                BD.actualizar(sql, mensaje,  true, usuario, "TRABAJO DE GRADO", ID.Text, true, this);
            this.Close();

            }
            else
            {
            string sql = "INSERT INTO trabajogrado (ciestudiante, cijurado1, cijurado2, cijurado3,titulo, citutor, fechadefensa, periodo, seccion, intento, sector, empresa, linea, eje  ) values " +
                         " ('" + System.Convert.ToString(tbcedula.Text) + "'," +
                         " '" + System.Convert.ToString(cbjurado1.SelectedValue) + "'," +
                         " '" + System.Convert.ToString(cbjurado2.SelectedValue) + "'," +
                         " '" + System.Convert.ToString(cbjurado3.SelectedValue) + "'," +
                         " '" + System.Convert.ToString(tbtitulo.Text) + "'," +
                         " '" + System.Convert.ToString(cbtutor.SelectedValue) + "'," +
                         " '" + System.Convert.ToString(dtfecha.Text) + "'," +
                         " '" + System.Convert.ToString(cbperiodo.SelectedValue) + "'," +
                         " '" + System.Convert.ToString(tbseccion.Text) + "'," +
                         " '" + System.Convert.ToString(cbintento.SelectedIndex) + "',"+
                         " '" + System.Convert.ToString(tbsector.Text) + "', " +
                         " '" + System.Convert.ToString(tbempresa.Text) + "', " +
                         " '" + System.Convert.ToString(cblinea.Text) + "', " +
                         " '" + System.Convert.ToString(cbeje.Text) + "')";

                string mensaje = "El proyecto ha sido registrado correctamente";

                BD.agregar(sql, mensaje,true, usuario, "TRABAJO DE GRADO", "CREACION", tbcedula.Text, true,this);


            }



            Trabajogrado frm = (Trabajogrado)System.Windows.Forms. Application.OpenForms["Trabajogrado"];
            if (System.Windows.Forms.Application.OpenForms.OfType<Trabajogrado>().Any())
            {
                frm.rellenargrid("SELECT tg.ID, tg.ciestudiante AS CEDULA, tg.titulo AS TITULO, " +
            "CONCAT (users.primernombre,' ',users.segundonombre,' ',users.primerapellido,' ', users.segundoapellido) AS ESTUDIANTE," +
            "CONCAT (peri.año,'-',peri.semestre) AS PERIODO, tg.fechadefensa AS DEFENSA, est.escuela AS ESCUELA " +
            "FROM trabajogrado tg " +
            "INNER JOIN estudiantes est ON est.ciestudiante = tg.ciestudiante " +
            "INNER JOIN usuarios users ON est.ciestudiante = users.usuario " +
            "INNER JOIN periodo peri ON peri.id = tg.periodo");
            }

        }
        
        private void btnbuscar_Click(object sender, EventArgs e)
            {
            BD.abrirconexion();

                string consulta = "SELECT ciestudiante, titulo,intento FROM trabajogrado WHERE ciestudiante='" + tbcedula.Text + "' ORDER BY intento DESC";
                string consultaestudiante = "SELECT * FROM usuarios WHERE usuario = '" + tbcedula.Text + "'";
                string seleccionarescuela = "SELECT escuela FROM estudiantes WHERE ciestudiante = '" + tbcedula.Text + "'";


            BD.rellenarestudiante(tbcedula, consultaestudiante, tbprimernombre, Tbsegundonombre, Tbprimerapellido, Tbsegundoapellido,
                    panel, btnbuscar, btnlimpiar, tbcedula,cbescuela , seleccionarescuela,cbintento);

            BD.periodoproyectoyservicio(lblfechaproyecto, lblfechaservicio, tbcedula, cbfechaservicio, cbfechaproyecto,tbtitulo);
            BD.comprobarregistro(consulta, tbtitulo, Btnagregar, btnbuscar, btnlimpiar, panel, cbintento, cbperiodo,cbescuela,"trabajogrado");

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
                cbfechaservicio.Checked = false;
                tbseccion.Text = "";
                tbcedula.Enabled = true;
                panel.Enabled = false;   

                btnbuscar.Enabled = true;
                btnlimpiar.Enabled = false;
            }

        #endregion


        #region EVENTOS DE OBJETOS
        
        private void tbcedula_KeyPress_1(object sender, KeyPressEventArgs e) { generales.validarnumeros(e); }
        
        private void tbprimernombre_KeyPress_1(object sender, KeyPressEventArgs e) { generales.validarletras(e); }
        
        
        #endregion

        #region FUNCION DE MODIFICACION 
        
        public void rellenarcampos()
    {
            BD.abrirconexion();
            BD.periodoproyectoyservicio(lblfechaproyecto, lblfechaservicio, tbcedula, cbfechaservicio, cbfechaproyecto, tbtitulo);

            SqlCommand comando = new SqlCommand("SELECT * FROM trabajogrado WHERE ID = '" + ID.Text + "'", BD.conexion);
            SqlDataReader lector = comando.ExecuteReader();



            if (lector.Read())
            {
                tbtitulo.Text = lector["titulo"].ToString();
                tbseccion.Text = lector["seccion"].ToString();
                dtfecha.Text = lector["fechadefensa"].ToString();
                cbperiodo .SelectedValue = lector["periodo"].ToString();
                cbintento.SelectedIndex = Int32.Parse(lector["intento"].ToString());
                cbjurado1.SelectedValue = Int32.Parse(lector["cijurado1"].ToString());
                cbjurado2.SelectedValue = Int32.Parse(lector["cijurado2"].ToString());
                cbjurado3.SelectedValue = Int32.Parse(lector["cijurado3"].ToString());
                cbtutor.SelectedValue = Int32.Parse(lector["citutor"].ToString());
                tbsector.Text= lector["sector"].ToString();
                tbempresa.Text=lector["empresa"].ToString();
                cbeje.Text= lector["eje"].ToString();
                cblinea.Text= lector["linea"].ToString();
                cbestatus.Text = lector["estatus"].ToString();

                if (cbestatus.Text == "REPROBADO")
                {
                    panel.Enabled = false;
                    Btnagregar.Enabled = false;
                }

                lector.Close();
            }


        }

        #endregion

        private void tbprimernombre_TextChanged(object sender, EventArgs e)
        {
            tbprimernombre.CharacterCasing = CharacterCasing.Upper;
            comprobartextbox();
        }

        private void Tbsegundonombre_TextChanged(object sender, EventArgs e)
        {
            Tbsegundonombre.CharacterCasing = CharacterCasing.Upper;
            comprobartextbox();
        }

        private void Tbprimerapellido_TextChanged(object sender, EventArgs e)
        {
            Tbprimerapellido.CharacterCasing = CharacterCasing.Upper;
            comprobartextbox();
        }

        private void Tbsegundoapellido_TextChanged(object sender, EventArgs e)
        {
            Tbsegundoapellido.CharacterCasing = CharacterCasing.Upper;
            comprobartextbox();
        }

        private void tbseccion_TextChanged(object sender, EventArgs e)
        {
            tbseccion.CharacterCasing=CharacterCasing.Upper;
            comprobartextbox();
        }

        private void tbtitulo_TextChanged(object sender, EventArgs e)
        {
            tbtitulo.Text = tbtitulo.Text.ToUpper();
            tbtitulo.Select(tbtitulo.Text.Length, 0);
        }

        private void citutor_TextChanged(object sender, EventArgs e)
        {
            comprobartextbox();
        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void cblinea_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbescuela_SelectedIndexChanged(object sender, EventArgs e)
        {
            lineas.definirlineas(cblinea,cbescuela,cbeje);
        }

        private void cblinea_TextChanged(object sender, EventArgs e)
        {
            comprobartextbox();
        }

        private void tbsector_TextChanged(object sender, EventArgs e)
        {
            tbsector.CharacterCasing = CharacterCasing.Upper;
            tbempresa.CharacterCasing = CharacterCasing.Upper;
        }

        protected void btnacta_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Word |*.docx";
            string ARCHIVO = "";


            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                ARCHIVO = saveFileDialog1.FileName;

                string codificacionescuela ="";
            if (cbescuela.Text.Contains("41"))
            {
                codificacionescuela = "41";

            }
            if (cbescuela.Text.Contains("42"))
            {
                codificacionescuela = "42";

            }
            if (cbescuela.Text.Contains("43"))
            {
                codificacionescuela = "43";

            }
            if (cbescuela.Text.Contains("44"))
            {
                codificacionescuela = "44";

            }
            if (cbescuela.Text.Contains("45"))
            {
                codificacionescuela = "45";

            }
            if (cbescuela.Text.Contains("46"))
            {
                codificacionescuela = "46";

            }
            if (cbescuela.Text.Contains("47"))
            {
                codificacionescuela = "47";

            }
            
            SqlCommand cmndperiodo = new SqlCommand("SELECT año FROM periodo WHERE id ='" + cbperiodo.SelectedValue + "'", BD.conexion);
            SqlCommand cmndcorrelativo = new SqlCommand("SELECT row2 FROM(SELECT id, ROW_NUMBER() OVER(PARTITION BY tg.periodo ORDER BY CONCAT(us.primernombre, us.segundonombre, us.primerapellido, us.segundoapellido))AS row," +
                "ROW_NUMBER() OVER(PARTITION BY est.escuela ORDER BY CONCAT(us.primernombre, us.segundonombre, us.primerapellido, us.segundoapellido))AS row2 " +
                "FROM trabajogrado tg " +
                "INNER JOIN usuarios us ON tg.ciestudiante = us.usuario " +
                "INNER JOIN estudiantes est ON us.usuario = est.ciestudiante) trabajogrado WHERE id = '"+ID.Text+"'", BD.conexion);

            int correlativo = Int32.Parse( cmndcorrelativo.ExecuteScalar().ToString());
            string codificacionperiodo = cmndperiodo.ExecuteScalar().ToString();
            string sin20 = codificacionperiodo.Replace("20", "");

            int codificacion = (Int32.Parse(codificacionescuela + sin20) * 1000) + correlativo;


   
            

            File.Copy(System.Windows.Forms.Application.StartupPath + @"\templates\TG - ACTA (TEMPLATE).docx", System.Windows.Forms.Application.StartupPath + @"\temp\temp-teporal.docx",true);


            string ruta = System.Windows.Forms.Application.StartupPath + @"\temp\temp-teporal.docx";

            generales.funcion(ruta, "(correlativo)",codificacion.ToString(), ARCHIVO);
            generales.funcion(ruta, "(dia)",generales.cambia(generales.numaletras( Int32.Parse(dtfecha.Value.ToString("dd")))) , ARCHIVO);
            generales.funcion(ruta, "(mes)", generales.cambia(dtfecha.Value.ToString("MMMM")) , ARCHIVO);
            generales.funcion(ruta, "(año)", DateTime.Today.Year.ToString(), ARCHIVO);
            generales.funcion(ruta, "(nombrejurado1)", genprof.profesion(Int32.Parse(cbjurado1.SelectedValue.ToString())) + " " + generales.cambia(cbjurado1.Text), ARCHIVO);
            generales.funcion(ruta, "(cijurado1)", generales.separarmiles( cbjurado1.SelectedValue.ToString()), ARCHIVO);
            generales.funcion(ruta, "(nombrejurado2)", genprof.profesion(Int32.Parse(cbjurado2.SelectedValue.ToString())) + " " + generales.cambia(cbjurado2.Text), ARCHIVO);
            generales.funcion(ruta, "(cijurado2)", generales.separarmiles(cbjurado2.SelectedValue.ToString()), ARCHIVO);
            generales.funcion(ruta, "(nombrejurado3)", genprof.profesion(Int32.Parse(cbjurado3.SelectedValue.ToString())) + " " + generales.cambia(cbjurado3.Text), ARCHIVO);
            generales.funcion(ruta, "(cijurado3)", generales.separarmiles(cbjurado3.SelectedValue.ToString()), ARCHIVO);
            generales.funcion(ruta, "(titulo)", generales.cambia(tbtitulo.Text), ARCHIVO);
            generales.funcion(ruta, "(ciudadano)", genprof.ciudadano(Int32.Parse(tbcedula.Text)), ARCHIVO);
            generales.funcion(ruta, "(estudiante)", generales.cambia(tbprimernombre.Text + " " + Tbsegundonombre.Text + " " + Tbprimerapellido.Text + " " + Tbsegundoapellido.Text), ARCHIVO);
            generales.funcion(ruta, "(cedula)", generales.separarmiles( tbcedula.Text.ToString()), ARCHIVO);
            generales.funcion(ruta, "(carrera)", generales.cambia(genprof.escuela(Int32.Parse(tbcedula.Text)) ), ARCHIVO);
            generales.funcion(ruta, "(periodo)", cbperiodo.Text, ARCHIVO);
            generales.funcion(ruta, "(nombretutor)", genprof.profesion(Int32.Parse(cbtutor.SelectedValue.ToString())) + " " + generales.cambia(cbtutor.Text), ARCHIVO);
            generales.funcion(ruta, "(citutor)", generales.separarmiles( cbtutor.SelectedValue.ToString()), ARCHIVO);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            solvencias solvencias = new solvencias();

            solvencias.tbcedula.Text = tbcedula.Text;
            solvencias.tbnombre.Text = tbprimernombre.Text + " " + Tbsegundonombre.Text + " " + Tbprimerapellido.Text + " " + Tbsegundoapellido.Text;
            solvencias.consultar();
            solvencias.Show();

        }
    }
}

