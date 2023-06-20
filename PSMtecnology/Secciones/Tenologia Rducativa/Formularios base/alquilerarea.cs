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
    public partial class alquilerarea : Form
    {


        #region VARIABLES

        
        Funciones_Generales generales = new Funciones_Generales();
        Funciones_BD BD = new Funciones_BD();
        paginacion paginacion = new paginacion();

        string sql = "SELECT area.id AS ID, area.horainicio AS DIA, area.catedras AS CATEDRAS, area.secciones AS SECCIONES, " +
            " area.proposito AS PROPOSITO, area.fechasolicitud AS SOLICITUD, area.escuela AS ESCUELA, CONCAT(prof.primernombre,' ', prof.segundonombre) AS DOCENTE " + 
            " FROM alquilerarea area INNER JOIN usuarios prof ON area.cedulaprofesor = prof.usuario ORDER BY ID DESC "; //consulta sql para rellenar el grid
        public string usuario;
        public string tipo,permisos ="";

        #endregion

        public alquilerarea() 
        { 
            InitializeComponent();

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
            paginacion.cargardatos(ds, lbltotal, lblpaginamaxima, lblpagnaactual, grid, btnanterior, btnsiguiente);
            BD.conexion.Close();

            if (permisos.Contains("1,"))
            {
                generales.btneditar(grid);
            }
            
        }

        public void ejecutar()
        {
            rellenargrid(sql);
        }

        #region BOTONES
        private void Btncerrar_Click(object sender, EventArgs e) { this.Close(); }

        //limpia el textboxt de la busqueda y carga el grid por defecto
       
       
        private void Btnagregar_Click(object sender, EventArgs e) 
        { 
            reservararea formulario = new reservararea();

            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is reservararea);

            if (frm != null)
            {
                //si la instancia existe la pongo en primer plano
                frm.Close();
            }

            formulario.Show();
            formulario.tbusuario.Text = usuario;
            formulario.docente();
        }

        // realiza una busqueda segun los datos ingresados 
        
        #endregion

        #region EVENTOS

        //funcion para la accion del boton en el grid
        private void gridestudiantes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            reservararea area = new reservararea();

            if (grid.Columns[e.ColumnIndex].HeaderText == "EDITAR" && e.RowIndex > -1)
            {
                Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is reservararea);

                if (frm != null)
                {
                    //si la instancia existe la pongo en primer plano
                    frm.Close();
                }

                area.Show();

                area.id.Visible = true;
                area.id.Text = grid.CurrentRow.Cells["ID"].Value.ToString();
                //modificar.tbcorrelativo.Text = grid.CurrentRow.Cells["CORRELATIVO"].Value.ToString();
                area.lblcabecera.Text = "Modificar";
                area.btnreservar.Text = "Actualizar";
                area.btnfinalizar.Visible = true;
                area.autorrelleno();
                area.usuario = usuario;
            }


        }

        #endregion

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
            frmreportealquiler reporte = new frmreportealquiler();
            reporte.Show();
        }
    }
}




