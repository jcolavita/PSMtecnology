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
using TrabajoDeGrado.Secciones.Academico.Pasantias;
using TrabajoDeGrado.Secciones.Estudiantes_y_Profesores.Estudiantes;

namespace TrabajoDeGrado.Secciones.Estudiantes_y_Profesores
{
    public partial class Proyectos : Form
    {
        #region VARIABLES

        Funciones_Generales comun = new Funciones_Generales(); //referencia al modulo comunes para poder acceder a sus funciones
        Funciones_BD BD = new Funciones_BD();
        paginacion paginacion = new paginacion();

        #endregion

        #region BOTONES

        public Proyectos() { InitializeComponent(); BD.abrirconexion(); }
        
                
        //rellenar grid, se utiliza tanto al cargar la pagina como con el boton de buscar
        public void rellenargrid(string sql)
        { 
            grid.Columns.Clear();
            SqlDataAdapter da = new SqlDataAdapter(sql, BD.conexion);
            System.Data.DataTable ds = new System.Data.DataTable();
            da.Fill(ds);
            grid.DataSource = ds;
            comun.btneditar(grid);

            BD.conexion.Close();
            paginacion.cargardatos(ds, lbltotal, lblpaginamaxima, lblpagnaactual, grid, btnanterior, btnsiguiente);

        }



        private void Btncerrar_Click(object sender, EventArgs e) { this.Close(); }

        //limpia el textboxt de la busqueda y carga el grid por defecto
        private void Btnlimpiar_Click(object sender, EventArgs e) 
        {
            grid.Columns.Clear();
            Btnlimpiar.Enabled = false;
            tbbusqueda.Text = "";
        } 

        // realiza una busqueda segun los datos ingresados
        private void Btnbuscarprofesor_Click(object sender, EventArgs e)
        {
            if (cbtabla.SelectedIndex == 0)
            {
                string sql = " SELECT sc.id AS ID,sc.ciestudiantes AS ESTUDIANTES, sc.nombrecomunidad AS COMUNIDAD, sc.titulo AS TITULO," +
                            " CONCAT (p.año,'-',p.semestre)AS PERIODO FROM servcomunitario sc INNER JOIN periodo p ON sc.periodo=p.id " +
                            " WHERE sc.ciestudiantes LIKE '%" + tbbusqueda.Text + "%' OR sc.titulo  LIKE '%" + tbbusqueda.Text + "%'" +
                            " rustica IS NOT NULL AND p.año >= '" + (DateTime.Today.Year - 5) + "'";

                rellenargrid(sql);
            }
            else if (cbtabla.SelectedIndex > 0)
            {
                string tablas = "";

                tablas = BD.seleccionartabla(cbtabla, tablas);


                string sqlbusqueda = "SELECT proyecto.id, proyecto.titulo AS TITULO, " +
                    " proyecto.periodo AS PERIODO, est.escuela AS ESCUELA " +
                    " FROM " + tablas + " proyecto INNER JOIN estudiantes est ON proyecto.ciestudiante = est.ciestudiante " +
                    " WHERE proyecto.ciestudiante LIKE '%" + tbbusqueda.Text + "%' OR proyecto.titulo LIKE '%" + tbbusqueda.Text + "%' " +
                    " AND rustica IS NOT NULL";

                rellenargrid(sqlbusqueda);
                Btnlimpiar.Enabled = true;
            }        

        }
        #endregion

        #region EVENTOS DE OBJETOS

        //funcion del boton del grid para abrir el formulario de edicion
        private void Gridprofesores_CellContentClick(object sender, DataGridViewCellEventArgs e) 
        {
            rusticas mostrar = new rusticas();
            paneldeformularios panel = new paneldeformularios();

            if (grid.Columns[e.ColumnIndex].HeaderText == "ACCIONES" && e.RowIndex > -1)
            {


                Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is paneldeformularios);

                if (frm != null)
                {
                    //si la instancia existe la pongo en primer plano
                    frm.Close();
                    
                }

            
                panel.Show();
                panel.formulario(mostrar);
                panel.Size = new Size(640, 640);
                panel.tamaño= new Size(640, 770);
                panel.MinimumSize = new Size(640, 640);
                panel.MaximumSize = new Size(640, 640);
                panel.btngeneral.Visible = false;
                panel.btnrustica.Visible = false;

                mostrar.tbruta.Visible = false;
                mostrar.Ruta.Visible = false;
                mostrar.btnlimpiar.Visible = false;
                mostrar.btnbuscardocumento.Visible = false;
                mostrar.Btnagregar.Visible = false;
                mostrar.cbperiodo.Enabled = false;
                mostrar.ID.Text = grid.CurrentRow.Cells["ID"].Value.ToString();
                mostrar.tbtitulo.Text = grid.CurrentRow.Cells["TITULO"].Value.ToString();
                mostrar.cbperiodo.Text = grid.CurrentRow.Cells["PERIODO"].Value.ToString();
                mostrar.tabla = BD.seleccionartabla(cbtabla, mostrar.tabla);
                mostrar.autor();
                mostrar.resumen();
          
            }
        }

        //filtros para el grid

        public void aplicarfiltros()
        {
            string tablas = "";
            string escuela = "";

            tablas = BD.seleccionartabla(cbtabla, tablas);
            escuela = BD.seleccionarescuela(CBescuela, escuela);

            string sql = "SELECT proyecto.ID,  proyecto.titulo AS TITULO, " +
            "CONCAT (peri.año,'-',peri.semestre) AS PERIODO,  est.escuela AS ESCUELA " +
            "FROM " + tablas + " proyecto INNER JOIN estudiantes est ON proyecto.ciestudiante = est.ciestudiante " +
            "INNER JOIN periodo peri ON proyecto.periodo= peri.id" +
            " WHERE rustica IS NOT NULL" + escuela + " AND peri.año >= '"+ (DateTime.Today.Year - 5 )+"'";

            rellenargrid(sql);
        }

        public void filtrocomunitario()
        {

            string sql = "SELECT sc.id AS ID,sc.ciestudiantes AS ESTUDIANTES, sc.nombrecomunidad AS COMUNIDAD, sc.titulo AS TITULO," +
            "CONCAT (p.año,'-',p.semestre)AS PERIODO FROM servcomunitario sc INNER JOIN periodo p ON sc.periodo=p.id " +
            "WHERE rustica IS NOT NULL AND p.año >= '" + (DateTime.Today.Year - 5) + "'";

            rellenargrid(sql);
        }

        #endregion

        private void CBescuela_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cbtabla.SelectedIndex<=0 )
            {
                filtrocomunitario();
                CBescuela.Visible = false;

            }
            else if (cbtabla.SelectedIndex > 0)
            {
                CBescuela.Visible = true;
                aplicarfiltros();
            }

            
        }

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

    }
}

