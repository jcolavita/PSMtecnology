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
    public partial class Serviciocomunitario : Form
    {
        #region VARIABLES
        Funciones_Generales generales = new Funciones_Generales(); //referencia al modulo comunes para poder acceder a sus funciones
        Funciones_BD BD = new Funciones_BD();
        public string usuario;

        public string sql = "SELECT sc.id AS ID,sc.ciestudiantes AS ESTUDIANTES, sc.nombrecomunidad AS COMUNIDAD, sc.titulo AS TITULO," +
            "CONCAT (p.año,'-',p.semestre)AS PERIODO FROM servcomunitario sc INNER JOIN periodo p ON sc.periodo=p.id";
        //consulta sql para rellenar el grid
        #endregion

        public Serviciocomunitario()
        {
            InitializeComponent(); BD.abrirconexion();
            rellenargrid(sql);
            BD.periodosql(cbperiodo);
        }

        public void rellenargrid(string sql)//rellenar grid, se utiliza tanto al cargar la pagina como con el boton de buscar

        {

            gridcomunitario.Columns.Clear();
            SqlDataAdapter da = new SqlDataAdapter(sql, BD.conexion);
            System.Data.DataTable ds = new System.Data.DataTable();
            da.Fill(ds);
            gridcomunitario.DataSource = ds;
            generales.btneditar(gridcomunitario);

            BD.conexion.Close();
        }

        #region BOTONES
        private void Btncerrar_Click(object sender, EventArgs e) { this.Close(); }
        private void Btnlimpiar_Click(object sender, EventArgs e) { rellenargrid(sql); Btnlimpiar.Enabled = false; } //limpia el textboxt de la busqueda y carga el grid por defecto
        private void Btnagregarprofesor_Click(object sender, EventArgs e)
        {
            paneldeformularios panel = new paneldeformularios();
            Agregarcomunitario formulario = new Agregarcomunitario();
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is paneldeformularios);

            if (frm != null)
            {
                //si la instancia existe la pongo en primer plano
                frm.Close();
            }
            panel.Show();
            panel.Size = new Size(506, 546);
            panel.MinimumSize = new Size(506, 546);
            panel.MaximumSize = new Size(506, 546);
            panel.btngeneral.Visible = false;
            panel.btnrustica.Visible = false;
            panel.formulario(formulario);
            formulario.usuario = usuario;
        }
        private void Btnbuscarprofesor_Click(object sender, EventArgs e)// realiza una busqueda segun los datos ingresados
        {
            string sqlbusqueda = "SELECT sc.id AS ID,sc.ciestudiantes AS ESTUDIANTES, sc.nombrecomunidad AS COMUNIDAD, sc.titulo AS TITULO," +
            "CONCAT (p.año,'-',p.semestre)AS PERIODO FROM servcomunitario sc INNER JOIN periodo p ON sc.periodo=p.id WHERE sc.ciestudiantes LIKE '%" + tbbusqueda.Text + "%' OR sc.titulo LIKE '%" + tbbusqueda.Text + "%'";
            rellenargrid(sqlbusqueda);
            Btnlimpiar.Enabled = true;
        }
        #endregion

        #region EVENTOS DE OBJETOS
        private void gridprofesores_CellContentClick(object sender, DataGridViewCellEventArgs e) //funcion del boton del grid para abrir el formulario de edicion
        {
            paneldeformularios panel = new paneldeformularios();
            Agregarcomunitario modificar = new Agregarcomunitario();
            if (gridcomunitario.Columns[e.ColumnIndex].HeaderText == "EDITAR" && e.RowIndex > -1)
            {

                Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is paneldeformularios);
                if (frm != null)
                {
                    //si la instancia existe la pongo en primer plano
                    frm.Close();

                }
                panel.Show();
                panel.formulario(modificar);
                panel.Size = new Size(506, 546);
                panel.tamaño = new Size(506, 546);
                panel.MinimumSize = new Size(506, 546);
                panel.MaximumSize = new Size(506, 546);
                panel.idgeneral = gridcomunitario.CurrentRow.Cells["ID"].Value.ToString();
                panel.autor = gridcomunitario.CurrentRow.Cells["ESTUDIANTES"].Value.ToString();
                panel.titulo = gridcomunitario.CurrentRow.Cells["TITULO"].Value.ToString();
                panel.periodo = gridcomunitario.CurrentRow.Cells["PERIODO"].Value.ToString();
                panel.tabla = " servcomunitario ";

                modificar.ID.Visible = true;
                modificar.LBLID.Visible = true;
                modificar.ID.Text = gridcomunitario.CurrentRow.Cells["ID"].Value.ToString();
                modificar.autorrelleno();
                modificar.cbperiodo.Enabled = true;


                //modificar.rellenarcampos();
                modificar.Btnagregar.Text = "Actualizar";
                modificar.lblcabecera.Text = "Modificar Pasantia";
                modificar.usuario = usuario;
            }

            #endregion


        }

        private void cbperiodo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sql = "";
            string consultabase = "SELECT sc.id AS ID,sc.ciestudiantes AS ESTUDIANTES, sc.nombrecomunidad AS COMUNIDAD, sc.titulo AS TITULO," +
            "CONCAT (p.año,'-',p.semestre)AS PERIODO FROM servcomunitario sc INNER JOIN periodo p ON sc.periodo=p.id ";
            string periodo = " WHERE (CONCAT (peri.año,'-',peri.semestre)  LIKE'" + cbperiodo.Text + "')";

            if (cbperiodo.SelectedIndex > 0 )
            {
                sql = consultabase + periodo;
            }
            else if(cbperiodo.SelectedIndex == 0)
            {
                sql = consultabase;
            }
            rellenargrid(sql);
        }
    }
}

