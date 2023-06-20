using System;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Windows.Forms;
using TrabajoDeGrado.Generales;
using TrabajoDeGrado.Modulos;

namespace TrabajoDeGrado.Secciones.Estudiantes_y_Profesores.Estudiantes
{
    public partial class prestamospendientes : Form
    {


        #region VARIABLES

        
        Funciones_Generales generales = new Funciones_Generales();
        Funciones_BD BD = new Funciones_BD();
        paginacion paginacion = new paginacion() ;
        
        public string usuario;

        #endregion

        public prestamospendientes() { InitializeComponent();  } 

        //rellenar grid, se utiliza tanto al cargar la pagina como con el boton de buscar

        public void rellenargrid(string sql)
        {
            BD.abrirconexion();
            grid.Columns.Clear();
            SqlDataAdapter da = new SqlDataAdapter(sql, BD.conexion);
            System.Data.DataTable ds = new System.Data.DataTable();
            da.Fill(ds);
            grid.DataSource = ds;
            generales.btncomfirmar(grid);
            //grid.Columns[5].Width = 80;


            BD.conexion.Close();
        }

        #region BOTONES
        private void Btncerrar_Click(object sender, EventArgs e) { this.Close(); }

        //limpia el textboxt de la busqueda y carga el grid por defecto
        private void Btnlimpiar_Click(object sender, EventArgs e)
        {
            grid.Columns.Clear();
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
           
        }

        #endregion

        #region EVENTOS

        //funcion para la accion del boton en el grid
        private void gridestudiantes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (cbtipo.SelectedIndex == 1)
            {
                confirmarprestamo confirmar = new confirmarprestamo();

                if (grid.Columns[e.ColumnIndex].HeaderText == "CONFIRMAR" && e.RowIndex > -1)
                {
                    Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is confirmarprestamo);

                    if (frm != null)
                    {
                        //si la instancia existe la pongo en primer plano
                        frm.Close();
                    }

                    confirmar.Show();
                    confirmar.id.Text =  grid.CurrentRow.Cells["ID"].Value.ToString();
                    confirmar.tbcodigo.Text = grid.CurrentRow.Cells["LIBRO"].Value.ToString();
                    confirmar.autorrelleno();
                    confirmar.usuario = usuario;

                }
            }
            else
            {
                entregarproyector entregar = new entregarproyector();

                if (grid.Columns[e.ColumnIndex].HeaderText == "CONFIRMAR" && e.RowIndex > -1)
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

            if (cbtipo.SelectedIndex == 1)
            {
                string sql = "SELECT p.id AS ID, p.idproducto AS LIBRO, " +
            "CONCAT (u.primernombre,' ',u.segundonombre,' ',u.primerapellido,' ', u.segundoapellido) AS USUARIO " +
            "FROM prestamoslibros p INNER JOIN usuarios u ON p.cedulausuario= u.usuario WHERE p.estado LIKE 'PENDIENTE' ";
                rellenargrid(sql);
            }
            else if (cbtipo.SelectedIndex == 2)
            {
                string sql = "SELECT r.id AS ID,r.cedulausuario AS CEDULA, CONCAT (u.primernombre,' ',u.primerapellido) AS USUARIO, " +
                    "r.idproyector AS PROYECTOR,  r.salida AS DIA,  r.materia AS MATERIA, r.aula AS AULA " +
                    "FROM  reservaproyector r INNER JOIN  usuarios u ON r.cedulausuario = u.usuario WHERE r.estado LIKE 'PENDIENTE'";
                rellenargrid(sql);
            }
            

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




