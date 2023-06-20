using PSMtecnology.Generales.Clases;
using PSMtecnology.Generales.reportes;
using System;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;
using TrabajoDeGrado.Generales;
using TrabajoDeGrado.Modulos;
using TrabajoDeGrado.Secciones.Pagina_Pincipal;

namespace TrabajoDeGrado.Secciones.Estudiantes_y_Profesores.Estudiantes
{
    public partial class Libros : Form
    {


        #region VARIABLES

        
        Funciones_Generales generales = new Funciones_Generales();
        Funciones_BD BD = new Funciones_BD();
        mensajeinformacion alerta = new mensajeinformacion();
        public string permisos="";

        string sql = "SELECT cota AS COTA, titulo AS TITULO," +
                "Autor AS AUTOR, Editorial AS EDITORIAL, Existencia AS CANT , Materia AS MATERIA FROM INVENTARIO$" +
                " WHERE existencia >= '1'"; //consulta sql para rellenar el grid
        public string usuario;
        public string tipo;
        

        #endregion

        public void ejecutar()
        {
            rellenargrid(sql);
            CBEXISTENCIAS.SelectedIndex = 0;

        }

        public Libros() 
        { 
            InitializeComponent();
            BD.materias(cbmateria);

        } 

        //rellenar grid, se utiliza tanto al cargar la pagina como con el boton de buscar

        public void rellenargrid(string sql)
        {
            BD.abrirconexion();
            grid.Columns.Clear();
            SqlDataAdapter da = new SqlDataAdapter(sql, BD.conexion);
            System.Data.DataTable ds = new System.Data.DataTable();
            da.Fill(ds);
            grid.DataSource = ds;
            generales.btnsolicitar(grid);
            BD.conexion.Close();

            if (permisos.Contains("1,"))
            {
                generales.btneditar(grid);
            }
            if (permisos.Contains("2,"))
            {
                Btnagregar.Visible = true;
            }
        }

        #region BOTONES
        private void Btncerrar_Click(object sender, EventArgs e) { this.Close(); }

        //limpia el textboxt de la busqueda y carga el grid por defecto
        private void Btnlimpiar_Click(object sender, EventArgs e)
        { 
            CBEXISTENCIAS.SelectedIndex= 0;
            cbmateria.SelectedIndex = 0;
            Btnlimpiar.Enabled = false;
            tbbuscarestudiante.Text = "";
        }
       
        private void Btnagregar_Click(object sender, EventArgs e) 
        { 
            Agregarlibro formulario = new Agregarlibro();

            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Agregarlibro);

            if (frm != null)
            {
                //si la instancia existe la pongo en primer plano
                frm.Close();
            }

            formulario.Show();
            formulario.usuario = usuario;
        }

        // realiza una busqueda segun los datos ingresados 
        private void Btnbuscar_Click(object sender, EventArgs e)
        {
            if (cbmateria.SelectedIndex==0)
            {
                string sqlbusqueda = "SELECT cota AS COTA, titulo AS TITULO," +
                "Autor AS AUTOR, Editorial AS EDITORIAL, Existencia AS CANT , Materia AS MATERIA FROM INVENTARIO$" +
                " WHERE existencia >= '1' AND titulo LIKE '%" + tbbuscarestudiante.Text + "%'" +
                " OR COTA LIKE '%" + tbbuscarestudiante.Text + "%' OR autor LIKE '%" + tbbuscarestudiante.Text + "%'";
                rellenargrid(sqlbusqueda);
            }
            else
            {
                string sqlbusqueda = "SELECT cota AS COTA, titulo AS TITULO," +
                "Autor AS AUTOR, Editorial AS EDITORIAL, Existencia AS CANT , Materia AS MATERIA FROM INVENTARIO$" +
                " WHERE materia LIKE '" + cbmateria.Text + "'  AND existencia >= '1' AND titulo LIKE '%" + tbbuscarestudiante.Text + "%'" +
                " OR COTA LIKE '%" + tbbuscarestudiante.Text + "%' OR autor LIKE '%" + tbbuscarestudiante.Text + "%'";
                rellenargrid(sqlbusqueda);
            }
            
            Btnlimpiar.Enabled = true;
        }

        #endregion

        #region EVENTOS

        //funcion para la accion del boton en el grid
        private void gridestudiantes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Agregarlibro modificar = new Agregarlibro();
            Solicitarlibro solicitar = new Solicitarlibro();


            if (grid.Columns[e.ColumnIndex].HeaderText == "EDITAR" && e.RowIndex > -1)
            {
                Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Agregarlibro);

                if (frm != null)
                {
                    //si la instancia existe la pongo en primer plano
                    frm.Close();
                }

                modificar.Show();
                modificar.tbcota.Text= grid.CurrentRow.Cells["COTA"].Value.ToString();
                //modificar.tbcorrelativo.Text = grid.CurrentRow.Cells["CORRELATIVO"].Value.ToString();

                modificar.autorrelleno();
                //modificar.tbcorrelativo.Text = grid.CurrentRow.Cells["CORRELATIVO"].Value.ToString();
                modificar.cbmateria.Enabled = false;
                modificar.lblcabecera.Text = "Modificar Libro";
                modificar.btnagregar.Text = "Actualizar";
                modificar.usuario = usuario;
            }
            else if (grid.Columns[e.ColumnIndex].HeaderText == "SOLICITAR" && e.RowIndex > -1)
            {
                Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Solicitarlibro);

                if (frm != null)
                {
                    //si la instancia existe la pongo en primer plano
                    frm.Close();
                }

                solicitar.Show();
                solicitar.tbcota.Text = grid.CurrentRow.Cells["COTA"].Value.ToString();
                solicitar.autorrelleno();
                solicitar.usuario = usuario;

            }
        }

        //filtro para el grid
        private void CBescuela_SelectedIndexChanged(object sender, EventArgs e)
        {
            string consutabase = "SELECT cota AS COTA, titulo AS TITULO," +
                "Autor AS AUTOR, Editorial AS EDITORIAL, Existencia AS CANT , Materia AS MATERIA FROM INVENTARIO$ ";
            string materia = "WHERE materia LIKE '" + cbmateria.Text + "' ";
            string existencias = " AND existencia >= '1' ";
            string sql = "";

            if (cbmateria.SelectedIndex > -1 && CBEXISTENCIAS.SelectedIndex == 0)
            {
                sql = consutabase + materia + existencias;
            }
            else if (cbmateria.SelectedIndex == -1 && CBEXISTENCIAS.SelectedIndex > 0)
            {
                if (CBEXISTENCIAS.SelectedIndex == 1)
                {
                    sql = " SELECT cota AS COTA, titulo AS TITULO," +
                "Autor AS AUTOR, Editorial AS EDITORIAL, Existencia AS CANT , Materia AS MATERIA FROM INVENTARIO$" +
                    " WHERE existencia >= '0'";
                }
                else
                {
                    sql = " SELECT cota AS COTA, titulo AS TITULO," +
                        "Autor AS AUTOR, Editorial AS EDITORIAL, Existencia AS CANT , Materia AS MATERIA FROM INVENTARIO$" +
                    " WHERE existencia >= '1'";
                }
            }
            else if (cbmateria.SelectedIndex > -1 && CBEXISTENCIAS.SelectedIndex > 0)
            {

                existencias=" AND existencia >= '0'";

                sql = consutabase + materia+existencias;
            }
            else
            {
                existencias=" WHERE existencia >= '1'";
                sql = consutabase + existencias;
            }
            rellenargrid(sql);

        }

        #endregion

        private void tbbuscarestudiante_TextChanged(object sender, EventArgs e)
        {
            tbbuscarestudiante.CharacterCasing = CharacterCasing.Upper;
        }

        
        private void CBEXISTENCIAS_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CBEXISTENCIAS.SelectedIndex==1)
            {
                rellenargrid("SELECT cota AS COTA, titulo AS TITULO," +
                "Autor AS AUTOR, Editorial AS EDITORIAL, Existencia AS CANT , Materia AS MATERIA FROM INVENTARIO$" +
                " WHERE existencia >= '0'");
            }
            else
            {
                rellenargrid("SELECT cota AS COTA, titulo AS TITULO," +
                "Autor AS AUTOR, Editorial AS EDITORIAL, Existencia AS CANT , Materia AS MATERIA FROM INVENTARIO$" +
                " WHERE existencia >= '1'");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            materia materia = new materia();
            materia.materiasadeaf(comboBox1, cbmateria);
            cbmateria.Enabled = true;
        }

        private void btnreporte_Click(object sender, EventArgs e)
        {
            if (cbmateria.Text=="")
            {
                alerta.Show();
                alerta.lblalerta.Text="Debe seleccionar una materia para generar el reporte.";
                return;
            }
            frmlibros frmlibros = new frmlibros();
            frmlibros.materias = cbmateria.Text;
            frmlibros.Show();
        }
    }
}




