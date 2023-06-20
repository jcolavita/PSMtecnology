using PSMtecnology.Generales.reportes;
using System;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Windows.Forms;
using TrabajoDeGrado.Generales;
using TrabajoDeGrado.Modulos;

namespace TrabajoDeGrado.Secciones.Estudiantes_y_Profesores.Estudiantes
{
    public partial class prestamos : Form
    {


        #region VARIABLES

        
        Funciones_BD BD= new Funciones_BD();
        Funciones_Generales generales = new Funciones_Generales();
        mensajeinformacion alerta = new mensajeinformacion();

        public string usuario;

        #endregion

        public prestamos() { InitializeComponent();} 

        //rellenar grid, se utiliza tanto al cargar la pagina como con el boton de buscar

        public void rellenargrid(string sql)
        {
            BD.abrirconexion();
            grid.Columns.Clear();
            SqlDataAdapter da = new SqlDataAdapter(sql, BD.conexion);
            System.Data.DataTable ds = new System.Data.DataTable();
            da.Fill(ds);
            grid.DataSource = ds;
            generales.btndevolver(grid);
            //grid.Columns[4].Width = 80;


            BD.conexion.Close();
        }

        #region BOTONES
        private void Btncerrar_Click(object sender, EventArgs e) { this.Close(); }

        //limpia el textboxt de la busqueda y carga el grid por defecto
        private void Btnlimpiar_Click(object sender, EventArgs e)
        {
            if (cbtipo.SelectedIndex == 0)
            {
                grid.Columns.Clear();
            }
            else if (cbtipo.SelectedIndex == 1)
            {
                string sql = "SELECT p.id AS ID, p.idproducto AS LIBRO, p.cota AS COTA," +
            "CONCAT (u.primernombre,' ',u.segundonombre,' ',u.primerapellido,' ', u.segundoapellido) AS USUARIO " +
            "FROM prestamoslibros p INNER JOIN usuarios u ON p.cedulausuario= u.usuario WHERE p.estado = 'ACTIVO' ";
                rellenargrid(sql);
                grid.Columns[1].Visible = false;

            }
            else if (cbtipo.SelectedIndex == 2)
            {
                string sql = "SELECT r.id AS ID,r.cedulausuario AS CEDULA, CONCAT (u.primernombre,' ',u.primerapellido) AS USUARIO, " +
                    "r.idproyector AS PROYECTOR,  r.salida AS DIA, r.materia AS MATERIA, r.aula AS AULA " +
                    "FROM  reservaproyector r INNER JOIN  usuarios u ON r.cedulausuario = u.usuario WHERE r.estado = 'ACTIVO'";
                rellenargrid(sql);
            }
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
        }

        // realiza una busqueda segun los datos ingresados 
        private void Btnbuscar_Click(object sender, EventArgs e)
        {
            if (cbtipo.SelectedIndex == 0)
            {
                grid.Columns.Clear();
            }
            else if (cbtipo.SelectedIndex == 1)
            {
                string sql = "SELECT p.id AS ID, p.idproducto AS LIBRO, p.cota AS COTA," +
            "CONCAT (u.primernombre,' ',u.segundonombre,' ',u.primerapellido,' ', u.segundoapellido) AS USUARIO " +
            "FROM prestamoslibros p INNER JOIN usuarios u ON p.cedulausuario= u.usuario WHERE p.estado = 'ACTIVO'" +
            " AND u.primernombre LIKE  '"+tbbuscarestudiante.Text+"'" +" OR u.segundonombre LIKE  '" + tbbuscarestudiante.Text+ "' " +
            " OR u.primerapellido LIKE  '" + tbbuscarestudiante.Text+ "'" +" OR u.segundoapellido LIKE  '" + tbbuscarestudiante.Text+ "' " +
            " OR p.cedulausuario LIKE'" + tbbuscarestudiante.Text+"'";
                rellenargrid(sql);
                grid.Columns[1].Visible = false;

            }
            else if (cbtipo.SelectedIndex == 2)
            {
                string sql = " SELECT r.id AS ID,r.cedulausuario AS CEDULA, CONCAT (u.primernombre,' ',u.primerapellido) AS USUARIO, " +
                    " r.idproyector AS PROYECTOR,  r.salida AS DIA, r.materia AS MATERIA, r.aula AS AULA " +
                    " FROM  reservaproyector r INNER JOIN  usuarios u ON r.cedulausuario = u.usuario WHERE r.estado = 'ACTIVO' " +
                    " AND u.primernombre LIKE  '"+tbbuscarestudiante.Text+"'" +" OR u.segundonombre LIKE  '" + tbbuscarestudiante.Text+ "' " + 
                    " OR u.primerapellido LIKE  '" + tbbuscarestudiante.Text+ "'" +" OR u.segundoapellido LIKE  '" + tbbuscarestudiante.Text+ "' " +
                    " OR r.cedulausuario LIKE'" + tbbuscarestudiante.Text+"'";
                rellenargrid(sql);
            }

            Btnlimpiar.Enabled = true;
        }

        #endregion

        #region EVENTOS

        //funcion para la accion del boton en el grid
        private void gridestudiantes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (cbtipo.SelectedIndex == 1)
            {
                devolver devolver = new devolver();


                if (grid.Columns[e.ColumnIndex].HeaderText == "DEVOLVER" && e.RowIndex > -1)
                {
                    Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is devolver);

                    if (frm != null)
                    {
                        //si la instancia existe la pongo en primer plano
                        frm.Close();
                    }

                    devolver.Show();
                    devolver.id.Text = grid.CurrentRow.Cells["ID"].Value.ToString();
                    devolver.id.Visible = true;
                    devolver.tbcota.Text = grid.CurrentRow.Cells["COTA"].Value.ToString();
                    devolver.idlibro.Text= grid.CurrentRow.Cells["LIBRO"].Value.ToString();
                    devolver.tbcota.Visible = true;
                    devolver.lblcota.Visible = true;
                    devolver.usuario = usuario;

                    devolver.autorrelleno();

                }
            }
            else
            {
                entregarproyector entregar = new entregarproyector();

                if (grid.Columns[e.ColumnIndex].HeaderText == "DEVOLVER" && e.RowIndex > -1)
                {
                    Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is entregarproyector);

                    if (frm != null)
                    {
                        //si la instancia existe la pongo en primer plano
                        frm.Close();
                    }

                    entregar.Show();
                    entregar.ID.Text = grid.CurrentRow.Cells["ID"].Value.ToString();
                    entregar.tbcedula.Text = grid.CurrentRow.Cells["CEDULA"].Value.ToString();
                    entregar.tbnombre.Text = grid.CurrentRow.Cells["USUARIO"].Value.ToString();
                    entregar.anular.Visible = false;
                    entregar.btnentregar.Text = "Devolver";
                    entregar.usuario = usuario;

                    entregar.autorrelleno();
                }

            }

        }


        #endregion

        private void tbbuscarestudiante_TextChanged(object sender, EventArgs e)
        {
            tbbuscarestudiante.CharacterCasing = CharacterCasing.Upper;
        }

        private void cbtipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            ejecutarsql();
     
        }

        public void ejecutarsql()
        {
            if (cbtipo.SelectedIndex == 0)
            {
                grid.Columns.Clear();
            }
            else if (cbtipo.SelectedIndex == 1)
            {
                string sql = "SELECT p.id AS ID, p.idproducto AS LIBRO, p.cota AS COTA," +
            "CONCAT (u.primernombre,' ',u.segundonombre,' ',u.primerapellido,' ', u.segundoapellido) AS USUARIO " +
            "FROM prestamoslibros p INNER JOIN usuarios u ON p.cedulausuario= u.usuario WHERE p.estado = 'ACTIVO' ";
                rellenargrid(sql);
                grid.Columns[1].Visible = false;
            }
            else if (cbtipo.SelectedIndex == 2)
            {
                string sql = "SELECT r.id AS ID,r.cedulausuario AS CEDULA, CONCAT (u.primernombre,' ',u.primerapellido) AS USUARIO, " +
                    "r.idproyector AS PROYECTOR,  r.salida AS DIA, r.materia AS MATERIA, r.aula AS AULA " +
                    "FROM  reservaproyector r INNER JOIN  usuarios u ON r.cedulausuario = u.usuario WHERE r.estado = 'ACTIVO'";
                rellenargrid(sql);
            }
        }

        private void btnreporte_Click(object sender, EventArgs e)
        {
            if (cbtipo.SelectedIndex==0)
            {
                alerta.Show();
                alerta.lblalerta.Text = "Selecciones un filtro para generar el reporte";
                return;
            }
            else if (cbtipo.SelectedIndex==1)
            {
                frmprestamolibro reporte = new frmprestamolibro();
                reporte.Show();
            }
            else if (cbtipo.SelectedIndex == 2)
            {
                frmprestamoproyector reporte = new frmprestamoproyector();
                reporte.Show();
            }
        }
    }
}




