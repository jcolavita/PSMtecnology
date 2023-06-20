using DocumentFormat.OpenXml.Bibliography;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
//using System.Windows.Forms;
using System.Windows.Forms;
using TrabajoDeGrado.Generales;
using TrabajoDeGrado.Modulos;
using TrabajoDeGrado.Secciones.Academico.Pasantias;
using TrabajoDeGrado.Secciones.Estudiantes_y_Profesores.Estudiantes;

namespace TrabajoDeGrado.Secciones.Estudiantes_y_Profesores
{
    public partial class Pasantias : Form
    {
        public Pasantias() 
        { 
            InitializeComponent(); 
            BD.periodosql(cbperiodo);
        }
        private void tbbusqueda_TextChanged(object sender, EventArgs e) //convierte el texto ingresado a mayusculas
        {
            tbbusqueda.Text = tbbusqueda.Text.ToUpper();
            tbbusqueda.Select(tbbusqueda.Text.Length, 0);
        }


        Funciones_BD BD = new Funciones_BD(); //referencia a la clase de funciones de base de datos 
        Funciones_Generales generales = new Funciones_Generales(); //referencia a la clase de funciones generales
        paginacion paginacion = new paginacion();
        public string permisos = "";
        public string usuario;

        string sql = " SELECT p.ID, p.ciestudiante AS CEDULA, " +
            " CONCAT (users.primernombre,' ',users.segundonombre,' ',users.primerapellido,' ', users.segundoapellido) AS ESTUDIANTE," +
            " p.titulo AS TITULO, CONCAT (peri.año,'-',peri.semestre) AS PERIODO, est.escuela AS ESCUELA " +
            " FROM pasantias p " +
            " INNER JOIN estudiantes est ON est.ciestudiante = p.ciestudiante " +
            " INNER JOIN usuarios users ON est.ciestudiante = users.usuario " +
            " INNER JOIN periodo peri ON peri.id = p.periodo";

            
        
        public void rellenargrid(string sql)//rellenar grid, se utiliza tanto al cargar la pagina como con el boton de buscar

        {
            BD.abrirconexion();
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

        #region BOTONES

        private void Btncerrar_Click(object sender, EventArgs e) { this.Close(); }

        private void Btnlimpiar_Click(object sender, EventArgs e) //limpia el textboxt de la busqueda y carga el grid por defecto

        {
            rellenargrid(sql); 
            Btnlimpiar.Enabled = false;
            tbbusqueda.Text = "";
        } 
        
        private void Btnagregarprofesor_Click(object sender, EventArgs e)//Boton para agregar un nuevo registro 
        {
            paneldeformularios panel = new paneldeformularios();
            Agregarpasantias agregar = new Agregarpasantias();
            
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is paneldeformularios);
            if (frm != null)
            {
                //si la instancia existe la cierra para abrirla nuevamente delante de todo
                frm.Close();
            }
            panel.Show();
            panel.formulario(agregar );
            agregar.tbcedula.Text = tbbusqueda.Text;
            generales.eliminarletras(agregar.tbcedula);
            panel.Size = new Size(535, 722);
            panel.MinimumSize = new Size(535, 722);
            panel.MaximumSize = new Size(535, 722);
            panel.btngeneral.Visible = false;
            panel.btnrustica.Visible = false;
            agregar.usuario = usuario;


        }

        private void Btnbuscarprofesor_Click(object sender, EventArgs e)  // realiza una busqueda segun los datos ingresados

        {
            string sqlbusqueda = "SELECT p.ID, p.ciestudiante AS CEDULA, " +
            " CONCAT (users.primernombre,' ',users.segundonombre,' ',users.primerapellido,' ', users.segundoapellido) AS ESTUDIANTE," +
            " p.titulo AS TITULO, CONCAT (peri.año,'-',peri.semestre) AS PERIODO, est.escuela AS ESCUELA " +
            " FROM pasantias p " +
            " INNER JOIN estudiantes est ON est.ciestudiante = p.ciestudiante " +
            " INNER JOIN usuarios users ON est.ciestudiante = users.usuario " +
            " INNER JOIN periodo peri ON peri.id = p.periodo" +
                " WHERE p.ciestudiante LIKE '%" + tbbusqueda.Text + "%' OR p.titulo LIKE '%" + tbbusqueda.Text + "%'" +
                " OR users.primerapellido LIKE '%" + tbbusqueda.Text + "%' OR users.primernombre LIKE '%" + tbbusqueda.Text + "%' " +
                " OR users.segundonombre LIKE '%" + tbbusqueda.Text + "%' OR users.segundoapellido LIKE '%" + tbbusqueda.Text + "%'";
            rellenargrid(sqlbusqueda);
            Btnlimpiar.Enabled = true;

        }
        
        #endregion

        #region EVENTOS DEL GRID

        private void Gridprofesores_CellContentClick(object sender, DataGridViewCellEventArgs e)//funcion del boton del grid para abrir el formulario de edicion

        {
            paneldeformularios   panel = new paneldeformularios();
            Agregarpasantias modificar = new Agregarpasantias();
            if (grid.Columns[e.ColumnIndex].HeaderText == "EDITAR" && e.RowIndex > -1)
            {

                Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is paneldeformularios);
                if (frm != null)
                {
                    //si la instancia existe la pongo en primer plano
                    frm.Close();

                }
                panel.Show();
                panel.formulario(modificar);
                panel.Size = new Size(535, 722);
                panel.tamaño = new Size(640, 722);
                panel.MinimumSize = new Size (535, 537);
                panel.MaximumSize = new Size(535, 722);
                panel.idgeneral= grid.CurrentRow.Cells["ID"].Value.ToString();
                panel.autor = grid.CurrentRow.Cells["ESTUDIANTE"].Value.ToString();
                panel.titulo = grid.CurrentRow.Cells["TITULO"].Value.ToString();
                panel.periodo = grid.CurrentRow.Cells["PERIODO"].Value.ToString();
                panel.tabla = " pasantias ";

                modificar.ID.Visible = true;
                modificar.idlabel.Visible = true;
                modificar.ID.Text = grid.CurrentRow.Cells["ID"].Value.ToString();
                modificar.tbcedula.Text = grid.CurrentRow.Cells["CEDULA"].Value.ToString();
                string consultaestudiante = "SELECT * FROM usuarios WHERE usuario = '" + modificar.tbcedula.Text + "'";
                string seleccionarescuela = "SELECT * FROM estudiantes WHERE ciestudiante = '" + modificar.tbcedula.Text + "'";
                modificar.cbperiodo.Enabled = true;
                modificar.btnacta.Visible = true;


                BD.rellenarestudiante(modificar.tbcedula, consultaestudiante, modificar.tbprimernombre, modificar.Tbsegundonombre, modificar.Tbprimerapellido, modificar.Tbsegundoapellido,
                modificar.panel, modificar.btnbuscar, modificar.btnlimpiar, modificar.tbcedula, modificar.cbescuela, seleccionarescuela, modificar.cbintento);
                modificar.rellenarcampos();
                modificar.subpanel.Enabled = false;
                modificar.cbfechaproyecto.Checked = true;
                modificar.cbfechaservicio.Checked = true;
                modificar.btnbuscar.Visible = false;
                modificar.btnlimpiar.Visible = false;
                modificar.Btnagregar.Text = "Actualizar";
                modificar.lblcabecera.Text = "Modificar Pasantia";
                modificar.tbcedula.Enabled = false;
                modificar.cbintento.Enabled = false;
                modificar.usuario = usuario;

            }
        }

        private void CBescuela_SelectedIndexChanged(object sender, EventArgs e) //filtros para el grid

        {
            string sql = "";
            string consultabase = "SELECT p.ID, p.ciestudiante AS CEDULA, " +
            " CONCAT (users.primernombre,' ',users.segundonombre,' ',users.primerapellido,' ', users.segundoapellido) AS ESTUDIANTE," +
            " p.titulo AS TITULO, CONCAT (peri.año,'-',peri.semestre) AS PERIODO, est.escuela AS ESCUELA " +
            " FROM pasantias p " +
            " INNER JOIN estudiantes est ON est.ciestudiante = p.ciestudiante " +
            " INNER JOIN usuarios users ON est.ciestudiante = users.usuario " +
            " INNER JOIN periodo peri ON peri.id = p.periodo";
            string escuela = " WHERE (est.escuela='" + CBescuela.Text + "')";
            string periodo = " WHERE (CONCAT (peri.año,'-',peri.semestre)  LIKE'" + cbperiodo.Text + "')";

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
                periodo = " AND (CONCAT (peri.año,'-',peri.semestre)  LIKE '" + cbperiodo.Text + "')";
                sql = consultabase + escuela + periodo;
            }
            else if (cbperiodo.SelectedIndex == -1 && CBescuela.SelectedIndex == 0)
            {
                sql = consultabase;
            }

            rellenargrid(sql);

        }

        #endregion
        
        private void lblpaginamaxima_Click(object sender, EventArgs e)
        {

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
            selectorreporte.formulario = "pasantias";
            selectorreporte.Show();
        }

        private void cbestatus_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

