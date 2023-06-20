using PSMtecnology.Generales.reportes;
using System;
using System.Data.SqlClient;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Windows.Forms;
using TrabajoDeGrado.Generales;
using TrabajoDeGrado.Modulos;

namespace TrabajoDeGrado.Secciones.Estudiantes_y_Profesores.Estudiantes
{
    public partial class Estudiantes : Form
    {
        #region VARIABLES
        Funciones_Generales generales = new Funciones_Generales();
        Funciones_BD BD = new Funciones_BD();
        paginacion paginacion = new paginacion();
        public string permisos;
        public string usuario;

        public string sql = "SELECT CONCAT(est.tipo,est.ciestudiante )AS CEDULA ,CONCAT(users.primernombre,' ',users.segundonombre,' ',users.primerapellido,' ',users.segundoapellido) AS ESTUDIANTE," +
            " CONCAT(users.codigotlf,'-',users.telefono)AS TELEFONO , est.escuela AS ESCUELA " +
            " FROM estudiantes est INNER JOIN usuarios users ON est.ciestudiante = users.usuario "; //consulta sql para rellenar el grid
        #endregion

        public Estudiantes() { InitializeComponent();  }

        
        //rellenar grid, se utiliza tanto al cargar la pagina como con el boton de buscar
        public void rellenargrid(string sql)
        {
            BD.abrirconexion();
            gridestudiantes.Columns.Clear();
            SqlDataAdapter da = new SqlDataAdapter(sql, BD.conexion);
            System.Data.DataTable ds = new System.Data.DataTable();
            da.Fill(ds);
            gridestudiantes.DataSource = ds;
            BD.conexion.Close();
            if (permisos.Contains("1"))
            {
                generales.btneditar(gridestudiantes);
            }
            if (!permisos.Contains("2"))
            {
                Btnagregar.Visible = false;
            }

            paginacion.cargardatos(ds, lbltotal, lblpaginamaxima, lblpagnaactual, gridestudiantes, btnanterior, btnsiguiente);


        }

        public void ejecutar()
        {
            rellenargrid(sql);
        }

        #region BOTONES
        private void Btncerrar_Click(object sender, EventArgs e) { this.Close(); }

        //limpia el textboxt de la busqueda y carga el grid por defecto
        private void Btnlimpiar_Click(object sender, EventArgs e)
        { 
            rellenargrid(sql);
            Btnlimpiar.Enabled = false;
            tbbuscarestudiante.Text = "";
        }
       
        private void Btnagregar_Click(object sender, EventArgs e) 
        { 
            Agregarestudiante formulario = new Agregarestudiante();

            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Agregarestudiante);

            if (frm != null)
            {
                //si la instancia existe la pongo en primer plano
                frm.Close();
            }

            formulario.Show();
            formulario.Tbcedula.Text = tbbuscarestudiante.Text;
            generales.eliminarletras(formulario.Tbcedula);
            formulario.Cbescuela.Text = CBescuela.Text;
            formulario.Cbsexo.Text = CBsexo.Text;
            formulario.usuario = usuario;
        }

        // realiza una busqueda segun los datos ingresados 
        private void Btnbuscar_Click(object sender, EventArgs e)
        {
            string sqlbusqueda = "SELECT CONCAT(est.tipo,est.ciestudiante )AS CEDULA ,CONCAT(users.primernombre,' ',users.segundonombre,' ',users.primerapellido,' ',users.segundoapellido) AS ESTUDIANTE," +
            " CONCAT(users.codigotlf,'-',users.telefono)AS TELEFONO , est.escuela AS ESCUELA " +
            " FROM estudiantes est INNER JOIN usuarios users ON est.ciestudiante = users.usuario  " +
            " WHERE est.ciestudiante LIKE '%" + tbbuscarestudiante.Text + "%' OR users.primernombre LIKE '%" + tbbuscarestudiante.Text + "%' OR users.primerapellido LIKE '%" + tbbuscarestudiante.Text + "%' ";
            rellenargrid(sqlbusqueda);
            Btnlimpiar.Enabled = true;
        }

        #endregion

        #region EVENTOS

        //funcion para la accion del boton en el grid
        private void gridestudiantes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Agregarestudiante modificar = new Agregarestudiante();

            if (gridestudiantes.Columns[e.ColumnIndex].HeaderText == "EDITAR" && e.RowIndex > -1)
            {
                Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Agregarestudiante);

                if (frm != null)
                {
                    //si la instancia existe la pongo en primer plano
                    frm.Close();
                }

                modificar.Show();
                generales.eliminarnaiconalidad(gridestudiantes, modificar.Tbcedula);
                modificar.autorrelleno();
                modificar.Tbcedula.Enabled = false;
                modificar.lblcabecera.Text = "Modificar Estudiante";
                modificar.Btnagregar.Text = "Actualizar";
                modificar.usuario = usuario;
            }
        }

        //filtro para el grid
        private void CBescuela_SelectedIndexChanged(object sender, EventArgs e)
        {
            string consutabase = "SELECT CONCAT(est.tipo,est.ciestudiante )AS CEDULA ,CONCAT(users.primernombre,' ',users.segundonombre,' ',users.primerapellido,' ',users.segundoapellido) AS ESTUDIANTE," +
            " CONCAT(users.codigotlf,'-',users.telefono)AS TELEFONO , est.escuela AS ESCUELA " +
            " FROM estudiantes est INNER JOIN usuarios users ON est.ciestudiante = users.usuario ";
            string escuela = "WHERE (est.escuela = '" + CBescuela.Text + "')";
            string sexo = "WHERE (est.sexo = '" + CBsexo.Text + "')";
            string sql = "";

            if (CBescuela.SelectedIndex > 0 && CBsexo.SelectedIndex == 0)
            {
                sql = consutabase + escuela;
            }
            else if (CBsexo.SelectedIndex > 0 && CBescuela.SelectedIndex == 0)
            {
                sql = consutabase + sexo;
            }
            else if (CBsexo.SelectedIndex > 0 && CBescuela.SelectedIndex > 0)
            {
                sexo = " AND (est.sexo = '" + CBsexo.Text + "')";
                sql = consutabase + escuela + sexo;
            }
            else if (CBsexo.SelectedIndex == 0 && CBescuela.SelectedIndex == 0)
            {
                sql = consutabase;
            }
            rellenargrid(sql);

        }
        #endregion

        private void tbbuscarestudiante_TextChanged(object sender, EventArgs e)
        {
            tbbuscarestudiante.CharacterCasing = CharacterCasing.Upper;
        }

        private void btnanterior_Click(object sender, EventArgs e)
        {
            paginacion.anterior(gridestudiantes, lblpagnaactual, btnanterior, btnsiguiente);

        }

        private void btnsiguiente_Click(object sender, EventArgs e)
        {
            paginacion.siguiente(gridestudiantes, lblpagnaactual, btnanterior, btnsiguiente);

        }

        private void btnreporte_Click(object sender, EventArgs e)
        {
            selectorestudiante selectorestudiante = new selectorestudiante();
            selectorestudiante.Show();
        }
    }
}




