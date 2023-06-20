using DocumentFormat.OpenXml.Wordprocessing;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrabajoDeGrado.Generales;
using TrabajoDeGrado.Modulos;
using TrabajoDeGrado.Secciones.Estudiantes_y_Profesores.Estudiantes;


namespace TrabajoDeGrado.Secciones.Estudiantes_y_Profesores
{
    public partial class Trabajogrado : Form
    {
        public Trabajogrado() 
        { 
            InitializeComponent(); 
            BD.abrirconexion(); 
            BD.periodosql( cbperiodo);
        }
        
        //rellenar grid, se utiliza tanto al cargar la pagina como con el boton de buscar
        public void rellenargrid(string sql)
        {
            grid.Columns.Clear();
            SqlDataAdapter da = new SqlDataAdapter(sql, BD.conexion);
            System.Data.DataTable ds = new System.Data.DataTable();
            da.Fill(ds);
            grid.DataSource = ds;
            BD.conexion.Close();
            if (permisos.Contains("1"))
            {
                generales.btneditar(grid);
            }
            if (!permisos.Contains("2"))
            {
                Btnagregarproyecto.Visible = false;
            }
            paginacion.cargardatos(ds, lbltotal, lblpaginamaxima, lblpagnaactual, grid, btnanterior, btnsiguiente);
        }

        public void ejecutar()
        {
            rellenargrid(sql);
        }

        #region VARIABLES
        Funciones_Generales generales = new Funciones_Generales(); //referencia al modulo comunes para poder acceder a sus funciones
        Funciones_BD BD = new Funciones_BD();
        public string permisos;
        paginacion paginacion = new paginacion();
        public string usuario;

         string sql = "SELECT tg.ID, tg.ciestudiante AS CEDULA, tg.titulo AS TITULO, " +
            "CONCAT (users.primernombre,' ',users.segundonombre,' ',users.primerapellido,' ', users.segundoapellido) AS ESTUDIANTE," +
            "CONCAT (peri.año,'-',peri.semestre) AS PERIODO, tg.fechadefensa AS DEFENSA, est.escuela AS ESCUELA " +
            "FROM trabajogrado tg " +
            "INNER JOIN estudiantes est ON est.ciestudiante = tg.ciestudiante " +
            "INNER JOIN usuarios users ON est.ciestudiante = users.usuario " +
            "INNER JOIN periodo peri ON peri.id = tg.periodo ";

         
        #endregion

        #region BOTONES

        private void Btncerrar_Click(object sender, EventArgs e) { this.Close(); }

        //limpia el textboxt de la busqueda y carga el grid por defecto
        private void Btnlimpiar_Click(object sender, EventArgs e) 
        { 
            rellenargrid(sql); 
            Btnlimpiar.Enabled = false;
            tbbusqueda.Text = "";
        } 
        private void Btnagregarprofesor_Click(object sender, EventArgs e) 
        {
            paneldeformularios panel = new paneldeformularios();

            Agregartrabajo agregar = new Agregartrabajo ();
            
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is paneldeformularios);
            if (frm != null)
            {
                //si la instancia existe la pongo en primer plano
                frm.Close();
            }
            panel.Show();
            panel.formulario(agregar);
            agregar.tbcedula.Text = tbbusqueda.Text;
            generales.eliminarletras(agregar.tbcedula);
            panel.Size = new Size(535, 688);
            panel.MinimumSize = new Size(535, 688);
            panel.MaximumSize = new Size(535, 688);
            panel.btngeneral.Visible = false;
            panel.btnrustica.Visible = false;
            agregar.usuario = usuario;
        }

        // realiza una busqueda segun los datos ingresados
        private void Btnbuscarprofesor_Click(object sender, EventArgs e)
        {
            string sqlbusqueda = "SELECT tg.ID, tg.ciestudiante AS CEDULA, tg.titulo AS TITULO, " +
            "CONCAT (users.primernombre,' ',users.segundonombre,' ',users.primerapellido,' ', users.segundoapellido) AS ESTUDIANTE," +
            "CONCAT (peri.año,'-',peri.semestre) AS PERIODO, tg.fechadefensa AS DEFENSA, est.escuela AS ESCUELA " +
            "FROM trabajogrado tg " +
            "INNER JOIN estudiantes est ON est.ciestudiante = tg.ciestudiante " +
            "INNER JOIN usuarios users ON est.ciestudiante = users.usuario " +
            "INNER JOIN periodo peri ON peri.id = tg.periodo "+
            " WHERE tg.ciestudiante LIKE '%" + tbbusqueda.Text + "%' OR tg.titulo LIKE '%" + tbbusqueda.Text + "%'" +
                " OR users.primerapellido LIKE '%" + tbbusqueda.Text + "%' OR users.primernombre LIKE '%" + tbbusqueda.Text + "%' " +
                " OR users.segundonombre LIKE '%" + tbbusqueda.Text + "%' OR users.segundoapellido LIKE '%" + tbbusqueda.Text + "%'";
            rellenargrid(sqlbusqueda);
            Btnlimpiar.Enabled = true;

        }
        #endregion

        #region EVENTOS DE OBJETOS

        //funcion del boton del grid para abrir el formulario de edicion
        private void Gridprofesores_CellContentClick(object sender, DataGridViewCellEventArgs e) 
        {
            paneldeformularios panel = new paneldeformularios();

            Agregartrabajo modificar = new Agregartrabajo();
            if (grid.Columns[e.ColumnIndex].HeaderText == "EDITAR" && e.RowIndex > -1)
            {
                Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Agregartrabajo);
                if (frm != null)
                {
                    //si la instancia existe la pongo en primer plano
                    frm.Close ();
                    
                }
                panel.Show();
                panel.formulario(modificar);
                panel.Size = new Size(535, 688);
                panel.tamaño = new Size(535, 688);
                panel.MinimumSize = new Size(535, 688);
                panel.MaximumSize = new Size(535, 688);
                panel.idgeneral = grid.CurrentRow.Cells["ID"].Value.ToString();
                panel.autor = grid.CurrentRow.Cells["ESTUDIANTE"].Value.ToString();
                panel.titulo = grid.CurrentRow.Cells["TITULO"].Value.ToString();
                panel.periodo = grid.CurrentRow.Cells["PERIODO"].Value.ToString();
                panel.tabla = " trabajogrado ";



                modificar.Show();
                modificar.ID.Visible = true;
                modificar.idlabel.Visible = true;
                modificar.ID.Text = grid.CurrentRow.Cells["ID"].Value.ToString();
                modificar.tbcedula.Text = grid.CurrentRow.Cells["CEDULA"].Value.ToString();
                string consultaestudiante = "SELECT * FROM usuarios WHERE usuario = '" + modificar.tbcedula.Text + "'";
                string seleccionarescuela = "SELECT * FROM estudiantes WHERE ciestudiante = '" + modificar.tbcedula.Text + "'";
                modificar.cbperiodo.Enabled = true;


                BD.rellenarestudiante(modificar.tbcedula, consultaestudiante, modificar.tbprimernombre, modificar.Tbsegundonombre, modificar.Tbprimerapellido, modificar.Tbsegundoapellido,
                modificar.panel, modificar.btnbuscar,modificar.btnlimpiar,modificar.tbcedula, modificar.cbescuela, seleccionarescuela, modificar.cbintento);
                modificar.rellenarcampos();
                modificar.subpanel.Enabled=false;
                modificar.cbfechaproyecto.Checked = true;
                modificar.cbfechaservicio.Checked = true;
                modificar.btnbuscar.Visible = false;
                modificar.btnlimpiar .Visible = false;
                modificar.Btnagregar.Text = "Actualizar";
                modificar.lblcabecera.Text = "Modificar Trabajo de Grado";
                modificar.tbcedula.Enabled = false;
                modificar.cbintento.Enabled = false;
                modificar.usuario = usuario;
                modificar.btnacta.Enabled = true;
                modificar.btnacta.Visible = true;

            }
        }

       //filtros para el grid
        private void CBescuela_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sql = "";
            string consultabase = "SELECT tg.ID, tg.ciestudiante AS CEDULA, tg.titulo AS TITULO, " +
            "CONCAT (users.primernombre,' ',users.segundonombre,' ',users.primerapellido,' ', users.segundoapellido) AS ESTUDIANTE," +
            "CONCAT (peri.año,'-',peri.semestre) AS PERIODO, tg.fechadefensa AS DEFENSA, est.escuela AS ESCUELA " +
            "FROM trabajogrado tg " +
            "INNER JOIN estudiantes est ON est.ciestudiante = tg.ciestudiante " +
            "INNER JOIN usuarios users ON est.ciestudiante = users.usuario " +
            "INNER JOIN periodo peri ON peri.id = tg.periodo ";
            string escuela = " WHERE (est.escuela='" + CBescuela.Text + "')";
            string periodo = " WHERE (CONCAT (peri.año,'-',peri.semestre) LIKE'" + cbperiodo.Text  + "')";


            if (CBescuela.SelectedIndex > 0 && cbperiodo.SelectedIndex == -1)
            {
                sql = consultabase + escuela;
            }
            else if (cbperiodo.SelectedIndex > -1 && CBescuela.SelectedIndex == 0)
            {
                sql = consultabase + periodo;
            }
            else if (cbperiodo.SelectedIndex > -1 && CBescuela.SelectedIndex > 0)
            {
                periodo = " AND (CONCAT (peri.año,'-',peri.semestre) LIKE '" + cbperiodo.Text + "')";
                sql = consultabase + escuela + periodo;
            }
            else if (cbperiodo.SelectedIndex == -1 && CBescuela.SelectedIndex == 0)
            {
                sql = consultabase;
            }

            rellenargrid(sql);

        }



        #endregion

        private void tbbusqueda_TextChanged(object sender, EventArgs e)
        {
            tbbusqueda.CharacterCasing = CharacterCasing.Upper;

        }

        private void btnanterior_Click(object sender, EventArgs e)
        {
            paginacion.anterior(grid, lblpagnaactual, btnanterior, btnsiguiente);

        }

        private void btnsiguiente_Click(object sender, EventArgs e)
        {
            paginacion.siguiente(grid, lblpagnaactual, btnanterior, btnsiguiente);

        }

        private void btnreporte_Click(object sender, EventArgs e)
        {
            selectorreporte selectorreporte = new selectorreporte();
            selectorreporte.formulario = "trabajogrado";
            selectorreporte.Show();
        }
    }
}

