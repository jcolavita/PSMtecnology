using PSMtecnology.Generales.reportes;
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
    public partial class gestionarusuarios : Form
    {
        public gestionarusuarios() { InitializeComponent(); BD.abrirconexion(); rellenargrid(sql); }
        
        //rellenar grid, se utiliza tanto al cargar la pagina como con el boton de buscar
        public void rellenargrid(string sql)
        {
            grid.Columns.Clear();
            SqlDataAdapter da = new SqlDataAdapter(sql, BD.conexion);
            System.Data.DataTable ds = new System.Data.DataTable();
            da.Fill(ds);
            grid.DataSource = ds;
            generales.btneditar(grid);

            BD.conexion.Close();

            paginacion.cargardatos(ds, lbltotal, lblpaginamaxima, lblpagnaactual, grid, btnanterior, btnsiguiente);


        }

        #region VARIABLES
        Funciones_BD BD = new Funciones_BD(); //referencia al modulo comunes para poder acceder a sus funciones
        Funciones_Generales generales = new Funciones_Generales();
        paginacion paginacion = new paginacion();
        public string usuario;

         string sql = "SELECT usuario AS USUARIO, CONCAT (primernombre ,' ',segundonombre,' ',primerapellido,' ',segundoapellido ) AS NOMBRE, departamento AS DEPARTAMENTO FROM usuarios";
        #endregion

        #region BOTONES

        private void Btncerrar_Click(object sender, EventArgs e) { this.Close(); }

        //limpia el textboxt de la busqueda y carga el grid por defecto
        private void Btnlimpiar_Click(object sender, EventArgs e) 
        { 
            rellenargrid(sql); 
            Btnlimpiar.Enabled = false;
            tbbusqueda.Text = "";
        } 
        private void Btnagregarprofesor_Click(object sender, EventArgs e) 
        { 
            agregarusuarios  formulario = new agregarusuarios();
            
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is agregarusuarios);
            if (frm != null)
            {
                //si la instancia existe la pongo en primer plano
                frm.Close();
            }
            formulario.Show();
            formulario.tbcedula.Text = tbbusqueda.Text;
            generales.eliminarletras(formulario.tbcedula);
            formulario.usuario = usuario;
            formulario.combobox();
        }

        // realiza una busqueda segun los datos ingresados
        private void Btnbuscarprofesor_Click(object sender, EventArgs e)
        {
            string sqlbusqueda = "SELECT usuario AS USUARIO, CONCAT (primernombre ,' ',segundonombre,' ',primerapellido,' ',segundoapellido) AS NOMBRE, tipo AS TIPO FROM usuarios" +
                " WHERE usuario LIKE '%" + tbbusqueda.Text + "%' OR nombre LIKE'%" + tbbusqueda.Text + "%'" +
                " OR apellido LIKE '%" + tbbusqueda.Text + "%'";
            rellenargrid(sqlbusqueda);
            Btnlimpiar.Enabled = true;

        }
        #endregion

        #region EVENTOS DE OBJETOS

        //funcion del boton del grid para abrir el formulario de edicion
        private void Gridprofesores_CellContentClick(object sender, DataGridViewCellEventArgs e) 
        {
            agregarusuarios   modificar = new agregarusuarios();
            if (grid.Columns[e.ColumnIndex].HeaderText == "EDITAR" && e.RowIndex > -1)
            {
                Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is agregarusuarios);
                if (frm != null)
                {
                    //si la instancia existe la pongo en primer plano
                    frm.Close ();
                    
                }

                modificar.Show();
                modificar.tbcedula.Text = grid.CurrentRow.Cells["USUARIO"].Value.ToString();
                string consultaestudiante = "SELECT * FROM usuarios WHERE usuario = '" + modificar.tbcedula.Text + "'";

                modificar.rellenarcampos();
                modificar.Btnagregar.Text = "Actualizar";
                modificar.lblcabecera.Text = "Modificar Usuario";
                modificar.tbcedula.Enabled = false;
                modificar.btnrestablecer.Visible = true;
                modificar.usuario = usuario;
                modificar.lblestado.Visible = true;
                modificar.cbestado.Visible = true;
            }
        }

       //filtros para el grid
       



        #endregion

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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnreporte_Click(object sender, EventArgs e)
        {
            frmreporteusuario reporte = new frmreporteusuario();
            reporte.Show();
        }
    }
}

