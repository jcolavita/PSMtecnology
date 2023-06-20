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


namespace TrabajoDeGrado.Secciones.Estudiantes_y_Profesores.Estudiantes
{
    public partial class Agregartrabajo : Form
    {
        Funciones_Generales generales = new Funciones_Generales();
        Funciones_BD BD = new Funciones_BD();
        lineasdeinvestigacion lineas = new lineasdeinvestigacion();
        public string usuario="";
        Computer pc = new Computer();

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



            Trabajogrado frm = (Trabajogrado)Application.OpenForms["Trabajogrado"];
            if (Application.OpenForms.OfType<Trabajogrado>().Any())
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

        private void btnacta_Click(object sender, EventArgs e)
        {
            object objmiss = System.Reflection.Missing.Value;
            Word.Application objword = new Word.Application();

                string template = Application.StartupPath + @"\templates\tg-template.docx";
                object parametro = template;
                object nombre = "nombreestudiante",cedula ="ciestudiante",escuela ="escuela",periodo ="periodo",
                dia = "dia", mes = "mes", año = "ano", jurado1 = "jurado1", jurado2 = "jurado2", jurado3 = "jurado3",
                cijurado1 = "cijurado1",cijurado2 = "cijurado2", cijurado3 = "cijurado3", titulo ="titulo",
                tutor = "tutor", citutor="citutor", jurado1bot= "jurado1bot", jurado2bot = "jurado2bot", jurado3bot = "jurado3bot",
                cijurado1bot ="cijurado1bot", cijurado2bot = "cijurado2bot", cijurado3bot = "cijurado3bot";
                Word.Document objdoc = objword.Documents.Open(parametro, objmiss);
                Word.Range nom = objdoc.Bookmarks.get_Item(ref nombre).Range;
                Word.Range ci = objdoc.Bookmarks.get_Item(ref cedula).Range;
                Word.Range esc = objdoc.Bookmarks.get_Item(ref escuela).Range;
                Word.Range peri = objdoc.Bookmarks.get_Item(ref periodo).Range;
                Word.Range day = objdoc.Bookmarks.get_Item(ref dia).Range;
                Word.Range month = objdoc.Bookmarks.get_Item(ref mes).Range;
                Word.Range year = objdoc.Bookmarks.get_Item(ref año).Range;
                Word.Range jur1 = objdoc.Bookmarks.get_Item(ref jurado1).Range;
                Word.Range jur2 = objdoc.Bookmarks.get_Item(ref jurado2).Range;
                Word.Range jur3 = objdoc.Bookmarks.get_Item(ref jurado3).Range;
                Word.Range cijur1 = objdoc.Bookmarks.get_Item(ref cijurado1).Range;
                Word.Range cijur2 = objdoc.Bookmarks.get_Item(ref cijurado2).Range;
                Word.Range cijur3 = objdoc.Bookmarks.get_Item(ref cijurado3).Range;
                Word.Range tit = objdoc.Bookmarks.get_Item(ref titulo).Range;
                Word.Range tut = objdoc.Bookmarks.get_Item(ref tutor).Range;
                Word.Range citut = objdoc.Bookmarks.get_Item(ref citutor).Range;
                Word.Range jur1bot = objdoc.Bookmarks.get_Item(ref jurado1bot).Range;
                Word.Range jur2bot = objdoc.Bookmarks.get_Item(ref jurado2bot).Range;
                Word.Range jur3bot = objdoc.Bookmarks.get_Item(ref jurado3bot).Range;
                Word.Range cijur1bot = objdoc.Bookmarks.get_Item(ref cijurado1bot).Range;
                Word.Range cijur2bot = objdoc.Bookmarks.get_Item(ref cijurado2bot).Range;
                Word.Range cijur3bot = objdoc.Bookmarks.get_Item(ref cijurado3bot).Range;



                nom.Text = tbprimernombre.Text + Tbsegundonombre.Text + Tbprimerapellido.Text + Tbsegundoapellido.Text;
                ci.Text = tbcedula.Text;
                esc.Text = cbescuela.Text;
                peri.Text = cbperiodo.Text;
                day.Text = DateTime.Today.Day.ToString();
                month.Text = DateTime.Today.Month.ToString();
                year.Text = DateTime.Today.Year.ToString();
            jur1.Text = cbjurado1.Text;
            jur2.Text = cbjurado2.Text;
            jur3.Text = cbjurado3.Text;
            cijur1.Text = cbjurado1.SelectedValue.ToString();
            cijur2.Text = cbjurado3.SelectedValue.ToString();
            cijur3.Text = cbjurado3.SelectedValue.ToString();
            tit.Text = tbtitulo.Text;
            tut.Text = cbtutor.Text;
            citut.Text = cbtutor.SelectedValue.ToString();
            jur1bot.Text = cbjurado1.Text;
            jur2bot.Text = cbjurado2.Text;
            jur3bot.Text = cbjurado3.Text;
            cijur1bot.Text = cbjurado1.SelectedValue.ToString();
            cijur2bot.Text = cbjurado3.SelectedValue.ToString();
            cijur3bot.Text = cbjurado3.SelectedValue.ToString();

                objword.Visible = true;

        }
    }
}

