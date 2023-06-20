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
    public partial class Profesores : Form
    {
        #region VARIABLES

        //referencia al modulo comunes para poder acceder a sus funciones
        Funciones_Generales generales = new Funciones_Generales();
        Funciones_BD BD = new Funciones_BD();
        public string permisos;
        public string usuario;
        paginacion paginacion= new paginacion();
        //consulta sql para rellenar el grid
        public string sql = "SELECT CONCAT(prof.tipodocumento,prof.ciprofesor )AS CEDULA ," +
            "CONCAT( users.primernombre,' ', users.segundonombre,' ', users.primerapellido,' ',users.segundoapellido) AS NOMBRE," +
            " CONCAT( users.codigotlf,' ', users.telefono)AS TELEFONO, prof.escuela AS ESCUELA, prof.profesion AS PROFESION,prof.especialidad AS ESPECIALIDAD " +
            "FROM profesores prof INNER JOIN usuarios users ON prof.ciprofesor = users.usuario";
        
        #endregion

        public Profesores(){InitializeComponent(); BD.abrirconexion(); }

        //rellenar grid, se utiliza tanto al cargar la pagina como con el boton de buscar
        public void rellenargrid(string sql)

        {
            gridprofesores.Columns.Clear();
            SqlDataAdapter da = new SqlDataAdapter(sql, BD.conexion);
            System.Data.DataTable ds = new System.Data.DataTable();
            da.Fill(ds);
            gridprofesores.DataSource = ds;
            BD.conexion.Close();

            if (permisos.Contains("1"))
            {
                generales.btneditar(gridprofesores);
            }
            if (!permisos.Contains("2"))
            {
                Btnagregarprofesor.Visible = false;
            }

            paginacion.cargardatos(ds, lbltotal, lblpaginamaxima, lblpagnaactual, gridprofesores, btnanterior, btnsiguiente);


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
            Btnlimpiar.Enabled=false;
            tbbuscarprofesores.Text = "";
        } 
        
        private void Btnagregarprofesor_Click(object sender, EventArgs e) 
        { 
            Agregarprofesor formulario = new Agregarprofesor();

            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Agregarprofesor);

            if (frm != null)
            {
                //si la instancia existe la pongo en primer plano
                frm.Close();
            }
            formulario.Show();
            formulario.Tbcedula.Text = tbbuscarprofesores.Text;
            generales.eliminarletras(formulario.Tbcedula);
            formulario.Cbprofesion.Text = CBprofesion.Text;
            formulario.Cbescuela.Text = Cbescuela.Text;
            formulario.usuario = usuario;
            if (comun41.Checked==true)
            {
                formulario.comun41.Checked = true;
            }
            if (comun42.Checked == true)
            {
                formulario.comun42.Checked = true;
            }
            if (comun43.Checked == true)
            {
                formulario.comun43.Checked = true;
            }
            if (comun44.Checked == true)
            {
                formulario.comun44.Checked = true;
            }
            if (comun45.Checked == true)
            {
                formulario.comun45.Checked = true;
            }
            if (comun46.Checked == true)
            {
                formulario.comun46.Checked = true;
            }
            if (comun47.Checked == true)
            {
                formulario.comun47.Checked = true;
            }


        }
        
        // realiza una busqueda segun los datos ingresados
        private void Btnbuscarprofesor_Click(object sender, EventArgs e)
        {
            string sqlbusqueda = "SELECT CONCAT(prof.tipodocumento,prof.ciprofesor )AS CEDULA ," +
            "CONCAT( users.primernombre,' ', users.segundonombre,' ', users.primerapellido,' ',users.segundoapellido) AS NOMBRE," +
            " CONCAT( users.codigotlf,' ', users.telefono)AS TELEFONO, prof.escuela AS ESCUELA, prof.profesion AS PROFESION,prof.especialidad AS ESPECIALIDAD " +
            "FROM profesores prof INNER JOIN usuarios users ON prof.ciprofesor = users.usuario" +
            "WHERE prof.ciprofesor LIKE '%" + tbbuscarprofesores.Text + "%' OR users.primernombre LIKE '%" + tbbuscarprofesores.Text + "%' OR users.primerapellido LIKE '%" + tbbuscarprofesores.Text + "%' ";
            rellenargrid(sqlbusqueda); 
            Btnlimpiar.Enabled=true ;

        }
        #endregion

        #region EVENTOS DE OBJETOS
        
        //funcion del boton del grid para abrir el formulario de edicion
        private void gridprofesores_CellContentClick(object sender, DataGridViewCellEventArgs e) 
        {
            Agregarprofesor  modificar = new Agregarprofesor();
            if (gridprofesores.Columns[e.ColumnIndex].HeaderText == "EDITAR" && e.RowIndex > -1)
            {


                Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Agregarprofesor);

                if (frm != null)
                {
                    //si la instancia existe la pongo en primer plano
                    frm.Close();
                    
                }

                //sino existe la instancia se crea una nueva
                modificar.Show();
                generales.eliminarnaiconalidad(gridprofesores, modificar.Tbcedula);
                modificar.autorrelleno();
                modificar.Tbcedula.Enabled = false;
                modificar.lblcabecera.Text = "Modificar Profesor";
                modificar.Btnagregar.Text = "Actualizar";
                modificar.usuario = usuario;
            }
        }

        //filtros para el grid
        public void CBsexo_SelectedIndexChanged(object sender, EventArgs e)
        {
            filtro();
        }

        #endregion

        private void tbbuscarprofesores_TextChanged(object sender, EventArgs e)
        {
            tbbuscarprofesores.CharacterCasing = CharacterCasing.Upper;
        }

        public void filtro()
        {
            string sql = "";
            string consultabase = "SELECT CONCAT(prof.tipodocumento,prof.ciprofesor )AS CEDULA ," +
            "CONCAT( users.primernombre,' ', users.segundonombre,' ', users.primerapellido,' ',users.segundoapellido) AS NOMBRE," +
            " CONCAT( users.codigotlf,' ', users.telefono)AS TELEFONO, prof.escuela AS ESCUELA, prof.profesion AS PROFESION,prof.especialidad AS ESPECIALIDAD " +
            "FROM profesores prof INNER JOIN usuarios users ON prof.ciprofesor = users.usuario";
            string escuela = " WHERE (prof.escuela like'" + generales.comunes(1, Cbescuela, comun41, comun42, comun43, comun44, comun45, comun46, comun47) + "')";
            string profesion = " WHERE (profesion='" + CBprofesion.Text + "')";


            if (Cbescuela.SelectedIndex > 0 && CBprofesion.SelectedIndex == 0)
            {
                sql = consultabase + escuela;
            }
            else if (CBprofesion.SelectedIndex > 0 && Cbescuela.SelectedIndex == 0)
            {
                sql = consultabase + profesion;
            }
            else if (CBprofesion.SelectedIndex > 0 && Cbescuela.SelectedIndex > 0)
            {
                profesion = "AND(prof.profesion = '" + CBprofesion.Text + "')";
                sql = consultabase + escuela + profesion;
            }
            else if (CBprofesion.SelectedIndex == 0 && Cbescuela.SelectedIndex == 0)
            {
                sql = consultabase;
            }
            rellenargrid(sql);

            if (Cbescuela.SelectedIndex == 1)
            {
                panelcomunes.Visible = true;
            }
            else
            {
                panelcomunes.Visible = false;
                comun41.Checked = false;
                comun42.Checked = false;
                comun43.Checked = false;
                comun44.Checked = false;
                comun45.Checked = false;
                comun46.Checked = false;
                comun47.Checked = false;
            }
        }

        private void comun41_CheckedChanged(object sender, EventArgs e)
        {
            filtro();
        }


        private void btnanterior_Click(object sender, EventArgs e)
        {
            paginacion.anterior(gridprofesores, lblpagnaactual, btnanterior, btnsiguiente);

        }

        private void btnsiguiente_Click(object sender, EventArgs e)
        {
            paginacion.siguiente(gridprofesores, lblpagnaactual, btnanterior, btnsiguiente);

        }

        private void btnreporte_Click(object sender, EventArgs e)
        {
            selectorprofesor selectorprofesor = new selectorprofesor();
            selectorprofesor.Show();
        }
    }
}

