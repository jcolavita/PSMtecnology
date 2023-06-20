using DocumentFormat.OpenXml.Office2010.Excel;
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
    public partial class retrasos : Form
    {


        #region VARIABLES

        
        Funciones_BD BD= new Funciones_BD();
        Funciones_Generales generales = new Funciones_Generales();
        paginacion paginacion = new paginacion();

        public string usuario;

        #endregion

        public retrasos() { 
            InitializeComponent();
            cbtipo.SelectedIndex = 0;
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
            generales.btneditar (grid);
            grid.Columns[6].Width = 50;
            grid.Columns[1].Visible = false;



            BD.conexion.Close();
            paginacion.cargardatos(ds, lbltotal, lblpaginamaxima, lblpagnaactual, grid, btnanterior, btnsiguiente);

        }

        #region BOTONES
        private void Btncerrar_Click(object sender, EventArgs e) { this.Close(); }

        //limpia el textboxt de la busqueda y carga el grid por defecto
        private void Btnlimpiar_Click(object sender, EventArgs e)
        {
            seleccionarsql();
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
                string sql = " SELECT R.id AS ID, R.idproducto AS PRODUCTO,R.cota AS COTA, R.entregaestipulada AS FECHA, R.fechadeentrega AS ENTREGA, " +
                            " CONCAT (u.primernombre,' ',u.segundonombre,' ',u.primerapellido,' ', u.segundoapellido) AS USUARIO " +
                            " FROM retrasos R INNER JOIN usuarios u ON R.cedulausuario= u.usuario WHERE R.estado LIKE 'SIN PROCESAR' AND  u.primernombre LIKE  '" + tbbuscarestudiante.Text+"'" +
                            " OR u.segundonombre LIKE  '" + tbbuscarestudiante.Text+ "' OR u.primerapellido LIKE  '" + tbbuscarestudiante.Text+ "'" +
                            " OR u.segundoapellido LIKE  '" + tbbuscarestudiante.Text+ "' OR R.cedulausuario LIKE '"+tbbuscarestudiante.Text+"'";
                rellenargrid(sql);
            }
            else if (cbtipo.SelectedIndex == 1)
            {
                string sql = "SELECT R.id AS ID, R.idproducto AS PRODUCTO,R.cota AS COTA, R.entregaestipulada AS FECHA, R.fechadeentrega AS ENTREGA, " +
                            "CONCAT (u.primernombre,' ',u.segundonombre,' ',u.primerapellido,' ', u.segundoapellido) AS USUARIO " +
                            "FROM retrasos R INNER JOIN usuarios u ON R.cedulausuario= u.usuario WHERE R.estado = 'PROCESADO' AND u.primernombre LIKE  '"+tbbuscarestudiante.Text+"'" +
                            " OR u.segundonombre LIKE  '" + tbbuscarestudiante.Text+ "' OR u.primerapellido LIKE  '" + tbbuscarestudiante.Text+ "'" +
                            " OR u.segundoapellido LIKE  '" + tbbuscarestudiante.Text+ "' OR R.cedulausuario LIKE '"+tbbuscarestudiante.Text+"'";
                rellenargrid(sql);
            }
            Btnlimpiar.Enabled = true;
        }

        #endregion

        #region EVENTOS

        //funcion para la accion del boton en el grid
        private void gridestudiantes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
                procesarretraso procesar = new procesarretraso();


                if (grid.Columns[e.ColumnIndex].HeaderText == "EDITAR" && e.RowIndex > -1)
                {
                    Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is procesarretraso);

                    if (frm != null)
                    {
                        //si la instancia existe la pongo en primer plano
                        frm.Close();
                    }
                procesar.Show();
                procesar.id.Text = grid.CurrentRow.Cells["ID"].Value.ToString();
                procesar.TBNOMBRE.Text = grid.CurrentRow.Cells["USUARIO"].Value.ToString() ;
                procesar.autorrelleno();
                
            }

        }

        //filtro para el grid


        #endregion

        private void tbbuscarestudiante_TextChanged(object sender, EventArgs e)
        {
            tbbuscarestudiante.CharacterCasing = CharacterCasing.Upper;
        }

        private void cbtipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            seleccionarsql();
        }

        private void btnanterior_Click(object sender, EventArgs e)
        {
            paginacion.anterior(grid, lblpagnaactual, btnanterior, btnsiguiente);

        }

        private void btnsiguiente_Click(object sender, EventArgs e)
        {
            paginacion.siguiente(grid, lblpagnaactual, btnanterior, btnsiguiente);

        }

        public void seleccionarsql()
        {
            if (cbtipo.SelectedIndex == 0)
            {
                string sql = " SELECT R.id AS ID, R.idproducto AS PRODUCTO,R.cota AS COTA, R.entregaestipulada AS FECHA, R.fechadeentrega AS ENTREGA, " +
                            " CONCAT (u.primernombre,' ',u.segundonombre,' ',u.primerapellido,' ', u.segundoapellido) AS USUARIO " +
                            " FROM retrasos R INNER JOIN usuarios u ON R.cedulausuario= u.usuario WHERE R.estado LIKE 'SIN PROCESAR'";
                rellenargrid(sql);
            }
            else if (cbtipo.SelectedIndex == 1)
            {
                string sql = "SELECT R.id AS ID, R.idproducto AS PRODUCTO,R.cota AS COTA, R.entregaestipulada AS FECHA, R.fechadeentrega AS ENTREGA, " +
                            "CONCAT (u.primernombre,' ',u.segundonombre,' ',u.primerapellido,' ', u.segundoapellido) AS USUARIO " +
                            "FROM retrasos R INNER JOIN usuarios u ON R.cedulausuario= u.usuario WHERE R.estado = 'PROCESADO'";
                rellenargrid(sql);
            }

        }

        private void btnreporte_Click(object sender, EventArgs e)
        {
            frmretrasos frmretrasos = new frmretrasos();
            frmretrasos.estado = cbtipo.Text;

            frmretrasos.Show();


        }
    }
}




