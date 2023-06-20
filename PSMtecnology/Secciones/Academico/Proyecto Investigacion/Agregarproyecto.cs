using Microsoft.VisualBasic;
using PSMTecnology.Generales.Clases;
using System;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Windows.Forms;
using TrabajoDeGrado.Generales;
using TrabajoDeGrado.Generales.Clases;
using TrabajoDeGrado.Modulos;
using Word = Microsoft.Office.Interop.Word;


namespace TrabajoDeGrado.Secciones.Estudiantes_y_Profesores.Estudiantes
{
    public partial class agregarproyecto : Form
    {
        public agregarproyecto() 
        { 
            InitializeComponent(); 
            BD.comboconsql(cbtutor, cbjurado1, cbjurado2, cbjurado2);
            BD.periodosql(cbperiodo);
        }

        public void comprobartextbox()
        {
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
                     !string.IsNullOrEmpty(cbeje.Text) &&
                     !string.IsNullOrEmpty(cblinea.Text) &&
                     cbfechaservicio.Checked;
            Btnagregar.Enabled = vr;

            var BTNACTA = aprobado;
            btnacta.Enabled = BTNACTA;
        }

        Funciones_BD BD = new Funciones_BD();
        Funciones_Generales generales = new Funciones_Generales();
        Pagina_Pincipal.Pagina_principal principal = new Pagina_Pincipal.Pagina_principal();
        rutas ruta = new rutas();
        lineasdeinvestigacion linea = new lineasdeinvestigacion();
        public string usuario;

        #region BOTONES
        private void Btnagregar_Click(object sender, EventArgs e)
        {
            string estudiantenombre = "UPDATE usuarios  SET primernombre ='" + tbprimernombre.Text + "', segundonombre='" + Tbsegundonombre.Text + "'," +
                    " primerapellido ='" + Tbprimerapellido.Text + "',segundoapellido ='" + Tbsegundoapellido.Text + "'" +
                    " WHERE usuario='" + tbcedula.Text + "'";
            BD.actualizar(estudiantenombre, "", false,  "", "", "", false, this);
            string estudiante = "UPDATE estudiantes  SET escuela='" + cbescuela.Text + "'" +
                    "  WHERE ciestudiante='" + tbcedula.Text + "'";
            BD.actualizar(estudiante, "", false, "", "", "", false, this);


            if (ID.Visible==true)
            {
                string sql = "UPDATE proyectoinvestigacion  SET periodo ='" + cbperiodo.SelectedValue + "', seccion='" + tbseccion.Text + "'," +
                            " fechadefensa ='" + dtfecha.Text + "',titulo ='" + tbtitulo.Text + "', " +
                            "cijurado1='" + cbjurado1.SelectedValue + "', cijurado2 ='" + cbjurado2.SelectedValue + "', " +
                            " citutor ='" + cbtutor.SelectedValue + "',intento ='" + cbintento.SelectedIndex + "', sector ='"+ tbsector.Text+"'," +
                            " empresa = '" + tbempresa.Text +"', linea ='"+ cblinea.Text +"', eje = '"+cbeje.Text+"', estatus='"+cbestatus.Text+"' " +
                            "  WHERE ID='" + ID.Text + "'";
                string mensaje = "El proyecto ha sido modificado correctamente";

                BD.actualizar(sql, mensaje, true, usuario, "PROYECTO DE INVESTIGACION", ID.Text, true, this);
                this.Close();
            }
            else
            {
                string sql = "INSERT INTO proyectoinvestigacion (ciestudiante, titulo, seccion, fechadefensa, citutor, cijurado1, cijurado2,periodo, intento,sector,empresa,linea,eje) values " +
                                " ('" + System.Convert.ToString(tbcedula.Text) + "'," +
                                " '" + System.Convert.ToString(tbtitulo.Text) + "'," +
                                " '" + System.Convert.ToString(tbseccion.Text) + "'," +
                                " '" + System.Convert.ToString(dtfecha.Text) + "'," +
                                " '" + System.Convert.ToString(cbtutor.SelectedValue) + "'," +
                                " '" + System.Convert.ToString(cbjurado1.SelectedValue) + "'," +
                                " '" + System.Convert.ToString(cbjurado2.SelectedValue) + "'," +
                                " '" + System.Convert.ToString(cbperiodo.SelectedValue) + "', " +
                                " '" + System.Convert.ToString(cbintento.SelectedIndex) + "', " +
                                " '" + System.Convert.ToString(tbsector.Text) + "', " +
                                " '" + System.Convert.ToString(tbempresa.Text) + "', " +
                                " '" + System.Convert.ToString(cblinea.Text) + "', " +
                                " '" + System.Convert.ToString(cbeje.Text) + "')";
                
                string mensaje = "El proyecto ha sido registrado correctamente";

                BD.agregar(sql, mensaje, true,usuario,"PROYECTO DE INVESTIGACION","CREACION",tbcedula.Text,true, this);

            }

            proyectoinvestigacion frm = (proyectoinvestigacion)Application.OpenForms["proyectoinvestigacion"];
            if (Application.OpenForms.OfType<proyectoinvestigacion>().Any())
            {
                frm.rellenargrid("SELECT pi.ID, pi.ciestudiante AS CEDULA, pi.titulo AS TITULO, " +
            "CONCAT (users.primernombre,' ',users.segundonombre,' ',users.primerapellido,' ', users.segundoapellido) AS ESTUDIANTE," +
            "CONCAT (peri.año,'-',peri.semestre) AS PERIODO, pi.fechadefensa AS DEFENSA, est.escuela AS ESCUELA " +
            "FROM proyectoinvestigacion pi " +
            "INNER JOIN estudiantes est ON est.ciestudiante = pi.ciestudiante " +
            "INNER JOIN usuarios users ON est.ciestudiante = users.usuario " +
            "INNER JOIN periodo peri ON peri.id = pi.periodo");
            }

        }
        private void Btncerrar_Click(object sender, EventArgs e) { this.Close(); }
        private void btnbuscar_Click(object sender, EventArgs e)
        {
            BD.abrirconexion();

            string consulta = "SELECT ciestudiante,titulo,intento FROM proyectoinvestigacion WHERE ciestudiante='" + tbcedula.Text + "'";
            string seleccionarnombre = "SELECT * FROM usuarios WHERE usuario = '" + tbcedula.Text + "'";
            string seleccionarescuela = "SELECT escuela FROM estudiantes WHERE ciestudiante = '" + tbcedula.Text + "'";



            BD.rellenarestudiante(tbcedula, seleccionarnombre, tbprimernombre, Tbsegundonombre, Tbprimerapellido, Tbsegundoapellido,
                 panel, btnbuscar, btnlimpiar,tbcedula,cbescuela, seleccionarescuela,cbintento );
            BD.comprobarregistro (consulta, tbtitulo, Btnagregar, btnbuscar, btnlimpiar, panel,cbintento,cbperiodo,cbestatus, "proyectoinvestigacion");

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


        #region FUNCION DE MODIFICACION 

        public void rellenarcampos()
        {
            BD.abrirconexion();
            SqlCommand comando = new SqlCommand("SELECT * FROM proyectoinvestigacion WHERE ID = '" + ID.Text + "'", BD.conexion);
            SqlDataReader lector = comando.ExecuteReader(); ;

            try
            {
                if (lector.Read())
                {
                    tbtitulo.Text = lector["titulo"].ToString();
                    tbseccion.Text = lector["seccion"].ToString();
                    dtfecha.Text = lector["fechadefensa"].ToString();
                    cbperiodo.SelectedValue = lector["periodo"].ToString();
                    cbintento.SelectedIndex = Int32.Parse(lector["intento"].ToString());
                    cbjurado1.SelectedValue = Int32.Parse(lector["cijurado1"].ToString());
                    cbjurado2.SelectedValue = Int32.Parse(lector["cijurado2"].ToString());
                    cbtutor.SelectedValue = Int32.Parse(lector["citutor"].ToString());
                    tbsector.Text= lector["sector"].ToString();
                    tbempresa.Text = lector["empresa"].ToString();
                    cblinea.Text = lector["linea"].ToString();
                    cbeje.Text = lector["eje"].ToString();
                    cbestatus.Text = lector["estatus"].ToString();

                    if (cbestatus.Text == "REPROBADO")
                    {
                        panel.Enabled = false;
                        Btnagregar.Enabled = false;
                    }

                    lector.Close();
                }

                BD.periodoproyectoyservicio(lblfechaservicio, lblfechaservicio, tbcedula, cbfechaservicio, cbfechaservicio,tbtitulo);

            }
            catch (Exception)
            {

                throw;
            }

            finally { lector.Close(); }

        }


        #endregion

        private void tbprimernombre_TextChanged(object sender, EventArgs e)
        {
            tbprimernombre.CharacterCasing = CharacterCasing.Upper;
            comprobartextbox();
        }

        private void tbcedula_KeyPress(object sender, KeyPressEventArgs e){generales.validarnumeros(e);}

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

        private void tbtitulo_TextChanged(object sender, EventArgs e)
        {
            tbtitulo.Text = tbtitulo.Text.ToUpper();
            tbtitulo.Select(tbtitulo.Text.Length, 0);
            comprobartextbox();
        }

        private void tbseccion_TextChanged(object sender, EventArgs e)
        {
            tbseccion.CharacterCasing = CharacterCasing.Upper;
            comprobartextbox();
        }

        private void tbseccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            generales.validarletras(e);
        }

        private void cbperiodo_TextChanged(object sender, EventArgs e)
        {
            comprobartextbox();
        }

        private void cbescuela_SelectedIndexChanged(object sender, EventArgs e)
        {
            linea.definirlineas(cblinea, cbescuela, cbeje);
        }

        private void tbempresa_TextChanged(object sender, EventArgs e)
        {
            tbempresa.CharacterCasing = CharacterCasing.Upper;
            tbsector.CharacterCasing = CharacterCasing.Upper;
        }

        private void btnacta_Click(object sender, EventArgs e)
        {
            object objmiss = System.Reflection.Missing.Value;
            Word.Application objword = new Word.Application();

            string template = Application.StartupPath + @"\templates\pi-template.docx";
            object parametro = template;
            object nombre = "nombre", cedula = "ciestudiante", jurado1 = "jurado1", jurado2 = "jurado2", 
                titulo = "titulo", tutor = "tutor", citutor = "citutor", cijurado1 = "cijurado1", 
                cijurado2 = "cijurado2", dia = "dia", mes = "mes", año = "ano",escuela ="escuela",seccion = "seccion",periodo = "periodo";
            Word.Document objdoc = objword.Documents.Open(parametro, objmiss);
            Word.Range nom = objdoc.Bookmarks.get_Item(ref nombre).Range;
            Word.Range ci = objdoc.Bookmarks.get_Item(ref cedula).Range;
            Word.Range cijur1 = objdoc.Bookmarks.get_Item(ref cijurado1).Range;
            Word.Range cijur2 = objdoc.Bookmarks.get_Item(ref cijurado2).Range;
            Word.Range tut = objdoc.Bookmarks.get_Item(ref tutor).Range;
            Word.Range citut = objdoc.Bookmarks.get_Item(ref citutor).Range;
            Word.Range jur1 = objdoc.Bookmarks.get_Item(ref jurado1).Range;
            Word.Range jur2 = objdoc.Bookmarks.get_Item(ref jurado2).Range;
            Word.Range tit = objdoc.Bookmarks.get_Item(ref titulo).Range;
            Word.Range day = objdoc.Bookmarks.get_Item(ref dia).Range;
            Word.Range month = objdoc.Bookmarks.get_Item(ref mes).Range;
            Word.Range year = objdoc.Bookmarks.get_Item(ref año).Range;
            Word.Range secc = objdoc.Bookmarks.get_Item(ref seccion).Range;
            Word.Range peri = objdoc.Bookmarks.get_Item(ref periodo).Range;
            Word.Range escu = objdoc.Bookmarks.get_Item(ref escuela).Range;

            nom.Text = tbprimernombre.Text + " " + Tbsegundonombre.Text + " " + Tbprimerapellido.Text + " " + Tbsegundoapellido.Text;
            ci.Text = tbcedula.Text;
            tut.Text = cbtutor.Text;
            cijur1.Text = cbjurado1.SelectedValue.ToString();
            cijur2.Text = cbjurado2.SelectedValue.ToString();
            citut.Text = cbtutor.SelectedValue.ToString();
            tit.Text = tbtitulo.Text;
            jur1.Text = cbjurado1.Text;
            jur2.Text = cbjurado2.Text;
            day.Text = DateTime.Today.Day.ToString();
            month.Text = DateTime.Today.Month.ToString();
            year.Text = DateTime.Today.Year.ToString();
            escu.Text = cbescuela.Text;
            peri.Text = cbperiodo.Text;
            secc.Text = tbseccion.Text;

            objword.Visible = true;

        }


    }
}

