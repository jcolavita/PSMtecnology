using DocumentFormat.OpenXml.Bibliography;
using DocumentFormat.OpenXml.Wordprocessing;
using Microsoft.VisualBasic;
using PSMtecnology.Generales.Clases;
using System;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Windows.Forms;
using TrabajoDeGrado.Generales;
using TrabajoDeGrado.Modulos;
using Word = Microsoft.Office.Interop.Word;


namespace TrabajoDeGrado.Secciones.Estudiantes_y_Profesores.Estudiantes
{
    public partial class agregartria : Form
    {
        Funciones_Generales generales = new Funciones_Generales();
        Funciones_BD BD = new Funciones_BD();
        public string usuario;
        genero_y_profesiones genprof = new genero_y_profesiones();

        Pagina_Pincipal.Pagina_principal principal = new Pagina_Pincipal.Pagina_principal();

        public agregartria() { 
            InitializeComponent(); 
            BD.comboconsql(cbjurado1, cbjurado2,cbjefe,cbtutor);
            BD.periodosql(cbperiodo);
        }

        public void Comprobartextbox(){
            bool aprobado = true;
            if (cbestatus.Text=="REPROBADO")
            {
                aprobado=false;
            }

            var vr = !string.IsNullOrEmpty(tbcedula.Text) &&
                     !string.IsNullOrEmpty(tbtitulo.Text) &&
                     !string.IsNullOrEmpty(cbjurado1 .Text) &&
                     !string.IsNullOrEmpty(cbjurado2 .Text) &&
                     !string.IsNullOrEmpty(cbperiodo.Text) &&
                     cbfechaservicio.Checked &&
                     cbfechaproyecto.Checked;
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
            BD.actualizar(estudiantenombre, "", false, "", "", "", false, this);

            string estudiante = "UPDATE estudiantes  SET escuela='" + cbescuela.Text + "'" +
                    "  WHERE ciestudiante='" + tbcedula.Text + "'";
            BD.actualizar(estudiante, "", false, "", "", "", false, this);

            if (ID.Visible == true)
           {

                string sql = "UPDATE tria  SET titulo ='" + tbtitulo.Text + "', " +
                             "periodo ='" + cbperiodo.SelectedValue + "', fechadefensa ='" + dtdefensa.Text+"', " +
                             "intento='" + cbintento.SelectedIndex + "', " +
                             "cijurado1 ='" + cbjurado1.SelectedValue + "',cijurado2 ='" + cbjurado2.SelectedValue + "', " +
                             "cijefe ='"+ cbjefe.SelectedValue + "',citutor ='"+ cbtutor.SelectedValue +"', estatus='"+cbestatus.Text+"' "+
                             "WHERE ID ='" + ID.Text + "'";
                string mensaje = "El proyecto de recuperacion ha sido modificado correctamente";

                BD.actualizar(sql, mensaje, true, usuario, "TRABAJO DE RECUPERACION DE INDICE",ID.Text, true, this);
                this.Close();

            }
            else
            {
                string sql = "INSERT INTO tria (ciestudiante, titulo, periodo, fechadefensa, cijurado1, cijurado2, " +
                    "cijefe, citutor, intento) values " +
                             " ('" + System.Convert.ToString(tbcedula.Text) + "'," +
                             " '" + System.Convert.ToString(tbtitulo.Text) + "'," +
                             " '" + System.Convert.ToString(cbperiodo.SelectedValue) + "'," +
                             " '" + System.Convert.ToString(dtdefensa.Text) + "'," +
                             " '" + System.Convert.ToString(cbjurado1.SelectedValue) + "'," +
                             " '" + System.Convert.ToString(cbjurado2.SelectedValue) + "'," +
                             " '" + System.Convert.ToString(cbjefe.SelectedValue) + "'," +
                             " '" + System.Convert.ToString(cbtutor.SelectedValue) + "'," +
                             " '" + System.Convert.ToString(cbintento.SelectedIndex) + "')"; 


                string mensaje = "El proyecto ha sido registrado correctamente";

                BD.agregar(sql, mensaje, true, usuario, "TRABAJO DE RECUPERACION DE INDICE", "CREACION", tbcedula.Text, true, this);

            }

            Recuperacion frm = (Recuperacion)Application.OpenForms["Recuperacion"];
            if (Application.OpenForms.OfType<Recuperacion>().Any())
            {
                frm.rellenargrid("SELECT tria.ID, tria.ciestudiante AS CEDULA, tria.titulo AS TITULO, " +
            "CONCAT (users.primernombre,' ',users.segundonombre,' ',users.primerapellido,' ', users.segundoapellido) AS ESTUDIANTE," +
            "CONCAT (peri.año,'-',peri.semestre) AS PERIODO, tria.fechadefensa AS DEFENSA, est.escuela AS ESCUELA " +
            "FROM tria tria " +
            "INNER JOIN estudiantes est ON est.ciestudiante = tria.ciestudiante " +
            "INNER JOIN usuarios users ON est.ciestudiante = users.usuario " +
            "INNER JOIN periodo peri ON peri.id = tria.periodo");
            }

        }

        private void Btncerrar_Click(object sender, EventArgs e) { this.Close(); }
        
        private void btnbuscar_Click(object sender, EventArgs e)
            {
            BD.abrirconexion();

                string consulta = "SELECT ciestudiante, titulo,intento FROM tria WHERE ciestudiante='" + tbcedula.Text + "' ORDER BY intento DESC";
                string consultaestudiante = "SELECT * FROM usuarios WHERE usuario = '" + tbcedula.Text + "'";
                string seleccionarescuela = "SELECT escuela FROM estudiantes WHERE ciestudiante = '" + tbcedula.Text + "'";

            BD.rellenarestudiante(tbcedula, consultaestudiante, tbprimernombre, Tbsegundonombre, Tbprimerapellido, Tbsegundoapellido,
                    panel, btnbuscar, btnlimpiar, tbcedula,cbescuela, seleccionarescuela,cbintento);

            BD.periodoproyectoyservicio(lblfechaproyecto, lblfechaservicio, tbcedula, cbfechaservicio, cbfechaproyecto, tbtitulo);
            tbtitulo.Text = "";
            BD.comprobarregistro(consulta, tbtitulo, Btnagregar, btnbuscar, btnlimpiar, panel, cbintento, cbperiodo,cbescuela,"tria");

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
            cbfechaproyecto.Checked = false;
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

            SqlCommand comando = new SqlCommand("SELECT * FROM tria WHERE ID = '" + ID.Text + "'", BD.conexion);
            SqlDataReader lector = comando.ExecuteReader(); ;


            if (lector.Read())
            {
                tbtitulo.Text = lector["titulo"].ToString();
                cbperiodo.SelectedValue =  lector["periodo"].ToString();
                cbjurado1.SelectedValue = Int32.Parse(lector["cijurado1"].ToString());
                cbjurado2.SelectedValue = Int32.Parse(lector["cijurado2"].ToString());
                cbjefe.SelectedValue = Int32.Parse(lector["cijefe"].ToString());
                cbtutor.SelectedValue = Int32.Parse(lector["citutor"].ToString());
                cbintento.SelectedIndex = Int32.Parse(lector["intento"].ToString());
                cbestatus.Text = lector["estatus"].ToString();

                if (cbestatus.Text=="REPROBADO")
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
            Comprobartextbox();
        }

        private void Tbsegundonombre_TextChanged(object sender, EventArgs e)
        {
            Tbsegundonombre.CharacterCasing = CharacterCasing.Upper;
            Comprobartextbox();
        }

        private void Tbprimerapellido_TextChanged(object sender, EventArgs e)
        {
            Tbprimerapellido.CharacterCasing=CharacterCasing.Upper;
            Comprobartextbox();
        }

        private void Tbsegundoapellido_TextChanged(object sender, EventArgs e)
        {
            Tbsegundoapellido.CharacterCasing = CharacterCasing.Upper;
            Comprobartextbox();
        }

        private void tbtitulo_TextChanged(object sender, EventArgs e)
        {
            tbtitulo.Text = tbtitulo.Text.ToUpper();
            tbtitulo.Select(tbtitulo.Text.Length, 0);
            Comprobartextbox();

        }

        private void cbtutor_TextChanged(object sender, EventArgs e)
        {
            Comprobartextbox();
        }

        private void btnacta_Click(object sender, EventArgs e)
        {
            object objmiss = System.Reflection.Missing.Value;
            Word.Application objword = new Word.Application();

            string template = Application.StartupPath + @"\templates\tria-template.docx";
            object parametro = template;
            object nombre = "nombre", cedula = "ciestudiante", jurado1top = "jurado1top", jurado2top = "jurado2top",
               jurado1 = "jurado1", jurado2 = "jurado2", titulo = "titulo", tutor = "tutor", citutor = "citutor", 
               cijurado1 = "cijurado1", cijurado2 = "cijurado2", jefe="jefe", dia = "dia", mes = "mes", año = "ano",especialidad = "especialidad";
            Word.Document objdoc = objword.Documents.Open(parametro, objmiss);
            Word.Range nom = objdoc.Bookmarks.get_Item(ref nombre).Range;
            Word.Range ci = objdoc.Bookmarks.get_Item(ref cedula).Range;
            Word.Range jurtop = objdoc.Bookmarks.get_Item(ref jurado1top).Range;
            Word.Range cijur1 = objdoc.Bookmarks.get_Item(ref cijurado1).Range;
            Word.Range jurtop2 = objdoc.Bookmarks.get_Item(ref jurado2top).Range;
            Word.Range cijur2 = objdoc.Bookmarks.get_Item(ref cijurado2).Range;
            Word.Range tut = objdoc.Bookmarks.get_Item(ref tutor).Range;
            Word.Range citut = objdoc.Bookmarks.get_Item(ref citutor).Range;
            Word.Range jurado1bot = objdoc.Bookmarks.get_Item(ref jurado1).Range;
            Word.Range jurado2bot = objdoc.Bookmarks.get_Item(ref jurado2).Range;
            Word.Range tit = objdoc.Bookmarks.get_Item(ref titulo).Range;
            Word.Range jef = objdoc.Bookmarks.get_Item(ref jefe).Range;
            Word.Range day = objdoc.Bookmarks.get_Item(ref dia).Range;
            Word.Range month = objdoc.Bookmarks.get_Item(ref mes).Range;
            Word.Range year = objdoc.Bookmarks.get_Item(ref año).Range;
            Word.Range espe = objdoc.Bookmarks.get_Item(ref especialidad).Range;


            nom.Text = generales.cambia( tbprimernombre.Text + " " + Tbsegundonombre.Text + " " + Tbprimerapellido.Text + " " + Tbsegundoapellido.Text);
            ci.Text = tbcedula.Text;
            jurtop.Text = genprof.profesion(Int32.Parse(cbjurado1.SelectedValue.ToString())) + " " + generales.cambia(cbjurado1.Text);
            jurtop2.Text = genprof.profesion(Int32.Parse(cbjurado2.SelectedValue.ToString())) + " " + generales.cambia(cbjurado2.Text);
            tut.Text = genprof.profesion(Int32.Parse(cbtutor.SelectedValue.ToString())) + " " + generales.cambia(cbtutor.Text);
            cijur1.Text = cbjurado1.SelectedValue.ToString();
            cijur2.Text = cbjurado2.SelectedValue.ToString();
            citut.Text = cbtutor.SelectedValue.ToString();
            tit.Text = generales .cambia(tbtitulo.Text);
            jurado1bot.Text = genprof.profesion(Int32.Parse(cbjurado1.SelectedValue.ToString())) + " " + generales.cambia(cbjurado1.Text);
            jurado2bot.Text = genprof.profesion(Int32.Parse(cbjurado2.SelectedValue.ToString())) + " " + generales.cambia(cbjurado2.Text);
            jef.Text =genprof.profesion(Int32.Parse(cbjefe.SelectedValue.ToString())) +" "+generales.cambia( cbjefe.Text);
            day.Text = DateTime.Today.Day.ToString();
            month.Text = DateTime.Today.Month.ToString();
            year.Text = DateTime.Today.Year.ToString();
            espe.Text = genprof.escuela(Int32.Parse(tbcedula.Text));

            objword.Visible = true;
        }

        private void cbestatus_TextChanged(object sender, EventArgs e)
        {
            Comprobartextbox();
        }
    }
}

