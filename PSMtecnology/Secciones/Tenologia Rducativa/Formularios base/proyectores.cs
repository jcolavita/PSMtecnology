using PSMtecnology.Generales.reportes;
using System;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;
using TrabajoDeGrado.Generales;
using TrabajoDeGrado.Modulos;

namespace TrabajoDeGrado.Secciones.Estudiantes_y_Profesores.Estudiantes
{
    public partial class proyectores : Form
    {


        #region VARIABLES

        
        Funciones_Generales generales = new Funciones_Generales();
        Funciones_BD BD = new Funciones_BD();
        public string permisos;
        paginacion paginacion = new paginacion();

        string sql = "SELECT id AS ID, marca AS MARCA," +
                "modelo AS MODELO, existencias AS CANT FROM proyectores" +
                " WHERE existencias >= '1'"; //consulta sql para rellenar el grid
        public string usuario;

        #endregion

        public proyectores() { InitializeComponent();  } 

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
            grid.Columns[4].Width = 50;
            
                if (permisos.Contains("1,"))
                {
                    generales.btneditar(grid);
                }
                if (!permisos.Contains("2,"))
                {
                    Btnagregar.Visible = false;
                }
            
            

            BD.conexion.Close();
            paginacion.cargardatos(ds, lbltotal, lblpaginamaxima, lblpagnaactual, grid, btnanterior, btnsiguiente);

        }

        public void ejecutar()
        {
            rellenargrid(sql);
        }

        #region BOTONES
        private void Btncerrar_Click(object sender, EventArgs e) { this.Close(); }
       
        private void Btnagregar_Click(object sender, EventArgs e) 
        { 
            agregarproyector  agregar = new agregarproyector();

            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is agregarproyector);

            if (frm != null)
            {
                //si la instancia existe la pongo en primer plano
                frm.Close();
            }

            agregar.Show();
            agregar.usuario = usuario;
        }
     
        #endregion

        #region EVENTOS

        //funcion para la accion del boton en el grid
        private void gridestudiantes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            reservarproyector modificar = new reservarproyector();


            if (grid.Columns[e.ColumnIndex].HeaderText == "SOLICITAR" && e.RowIndex > -1)
            {
                Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is reservarproyector);

                if (frm != null)
                {
                    //si la instancia existe la pongo en primer plano
                    frm.Close();
                }
                modificar.Show();
                modificar.tbcedula.Text = usuario;
                modificar.autorrelleno();
                modificar.idproyector = grid.CurrentRow.Cells["ID"].Value.ToString();
                modificar.usuario = usuario;



            }

        }

        #endregion

        
        private void btnanterior_Click(object sender, EventArgs e)
        {
            paginacion.anterior(grid, lblpagnaactual, btnanterior, btnsiguiente);

        }

        private void btnsiguiente_Click(object sender, EventArgs e)
        {
            paginacion.anterior(grid, lblpagnaactual, btnanterior, btnsiguiente);

        }

        private void btnreporte_Click(object sender, EventArgs e)
        {
            frmreporteproyector reporte = new frmreporteproyector();
            reporte.Show();
        }
    }

}





