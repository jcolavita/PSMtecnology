using DocumentFormat.OpenXml.Spreadsheet;
using PSMtecnology.Generales.reportes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrabajoDeGrado.Generales;
using TrabajoDeGrado.Modulos;
using TrabajoDeGrado.Secciones.Academico.Pasantias;
using TrabajoDeGrado.Secciones.Estudiantes_y_Profesores.Estudiantes;

namespace TrabajoDeGrado.Secciones.Estudiantes_y_Profesores
{
    public partial class auditoria : Form
    {
        string sql = "SELECT au.id AS ID, CONCAT (users.primernombre,' ', users.primerapellido,' '," +
                " au.accion,' EL ', au.tablaafectada,' ', au.idafectado) AS AUDITORIA, au.fecha AS FECHA FROM" +
                " auditoria au INNER JOIN usuarios users ON au.usuario = users.usuario ";
        public auditoria() 
        { 
            InitializeComponent();
            rellenargrid(sql);
            BD.accion(cbaccion);
            BD.usuarios(cbusuario);
        }
        private void tbbusqueda_TextChanged(object sender, EventArgs e) //convierte el texto ingresado a mayusculas
        {
            tbbusqueda.Text = tbbusqueda.Text.ToUpper();
            tbbusqueda.Select(tbbusqueda.Text.Length, 0);
        }


        Funciones_BD BD = new Funciones_BD(); //referencia a la clase de funciones de base de datos 
        Funciones_Generales generales = new Funciones_Generales(); //referencia a la clase de funciones generales
        paginacion paginacion = new paginacion();
        public string permisos = "";
        


        public void rellenargrid(string sql)//rellenar grid, se utiliza tanto al cargar la pagina como con el boton de buscar

        {
            BD.abrirconexion();
            grid.Columns.Clear();
            SqlDataAdapter da = new SqlDataAdapter(sql, BD.conexion);
            System.Data.DataTable ds = new System.Data.DataTable();
            da.Fill(ds);
            grid.DataSource = ds;
            BD.conexion.Close();
            grid.Columns[0].Width = 90;
            grid.Columns[1].Width = 85;

            paginacion.cargardatos(ds, lbltotal, lblpaginamaxima, lblpagnaactual, grid, btnanterior, btnsiguiente);

        }


        #region BOTONES

        private void Btncerrar_Click(object sender, EventArgs e) { this.Close(); }

        private void Btnlimpiar_Click(object sender, EventArgs e) //limpia el textboxt de la busqueda y carga el grid por defecto

        {
            string sql = "SELECT au.id AS ID, CONCAT (users.primernombre,' ', users.primerapellido,' '," +
                " '    ', au.accion,' EL ', au.tablaafectada,' ', au.idafectado) AS AUDITORIA, au.fecha AS FECHA FROM" +
                " auditoria au INNER JOIN usuarios users ON au.usuario = users.usuario WHERE accion LIKE '" + cbaccion.Text + "' AND fecha LIKE '%" + desde.Value.Day + "' AND fecha LIKE '%" + desde.Value.Month + "%'";

            rellenargrid(sql); 
            Btnlimpiar.Enabled = false;
            tbbusqueda.Text = "";
        } 
        
        private void Btnagregarprofesor_Click(object sender, EventArgs e)//Boton para agregar un nuevo registro 
        {
            paneldeformularios panel = new paneldeformularios();
            Agregarpasantias agregar = new Agregarpasantias();
            
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is paneldeformularios);
            if (frm != null)
            {
                //si la instancia existe la cierra para abrirla nuevamente delante de todo
                frm.Close();
            }
            panel.Show();
            panel.formulario(agregar );
            agregar.tbcedula.Text = tbbusqueda.Text;
            generales.eliminarletras(agregar.tbcedula);
            panel.Size = new Size(640, 850);
            panel.MinimumSize = new Size(640, 850);
            panel.MaximumSize = new Size(640, 850);
            panel.btngeneral.Visible = false;
            panel.btnrustica.Visible = false;

        }

        private void Btnbuscarprofesor_Click(object sender, EventArgs e)  // realiza una busqueda segun los datos ingresados

        {
            string sqlbusqueda ="";
            rellenargrid(sqlbusqueda);
            Btnlimpiar.Enabled = true;

        }
        
        #endregion

        #region EVENTOS DEL GRID

       
            
        

        private void CBescuela_SelectedIndexChanged(object sender, EventArgs e) //filtros para el grid

        {
            ejecutrar();
        }

        #endregion
        
        private void lblpaginamaxima_Click(object sender, EventArgs e)
        {

        }

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
            frmauditoria frmauditoria = new frmauditoria();
            frmauditoria.accion=cbaccion.Text;
            frmauditoria.Show();

        }

        private void desde_ValueChanged(object sender, EventArgs e)
        {
            ejecutrar();
        }

        private void cbacciones_CheckedChanged(object sender, EventArgs e)
        {
            ejecutrar();
        }

        public void ejecutrar()
        {
            if (cbacciones.Checked == true && cbusuarios.Checked==false)
            {
                cbaccion.Enabled = false;
                cbusuario.Enabled = true;
                string sql = "SELECT au.fecha AS FECHA,au.usuario AS CEDULA, CONCAT (users.primernombre,' ', users.primerapellido,' ',users.permisoseletra) AS USUARIO," +
                " au.accion AS ACCION, CONCAT(au.tablaafectada,' - ',au.idafectado) AS REGISTRO FROM" +
                " auditoria au INNER JOIN usuarios users ON au.usuario = users.usuario " +
                " WHERE  au.usuario = '" + cbusuario.SelectedValue + "' AND  au.fecha  BETWEEN '" + desde.Value.ToString() + "' " +
                " AND '" + hasta.Value.ToString() + "' ";
                rellenargrid(sql);

            }
            else if (cbacciones.Checked == false && cbusuarios.Checked == true)
            {
                cbaccion.Enabled = true;
                cbusuario.Enabled = false;
                string sql = "SELECT au.fecha AS FECHA,au.usuario AS CEDULA, CONCAT (users.primernombre,' ', users.primerapellido,' ',users.permisoseletra) AS USUARIO," +
                " au.accion AS ACCION, CONCAT(au.tablaafectada,' - ',au.idafectado) AS REGISTRO FROM" +
                " auditoria au INNER JOIN usuarios users ON au.usuario = users.usuario " +
                " WHERE  au.accion LIKE '" + cbaccion.Text + "' AND  au.fecha  BETWEEN '" + desde.Value.ToString() + "' " +
                " AND '" + hasta.Value.ToString() + "' ";
                rellenargrid(sql);

            }
            else if (cbacciones.Checked == true && cbusuarios.Checked == true)
            {
                cbaccion.Enabled = false;
                cbusuario.Enabled = false;
                string sql = "SELECT au.fecha AS FECHA,au.usuario AS CEDULA, CONCAT (users.primernombre,' ', users.primerapellido,' ',users.permisoseletra) AS USUARIO," +
                " au.accion AS ACCION, CONCAT(au.tablaafectada,' - ',au.idafectado) AS REGISTRO FROM" +
                " auditoria au INNER JOIN usuarios users ON au.usuario = users.usuario " +
                " WHERE au.fecha  BETWEEN '" + desde.Value.ToString() + "' " +
                " AND '" + hasta.Value.ToString() + "' ";
                rellenargrid(sql);

            }
            else if (cbacciones.Checked == false && cbusuarios.Checked == false)
            {
                cbaccion.Enabled = true;
                cbusuario.Enabled = true;
                string sql = "SELECT au.fecha AS FECHA,au.usuario AS CEDULA, CONCAT (users.primernombre,' ', users.primerapellido,' ',users.permisoseletra) AS USUARIO," +
                " au.accion AS ACCION, CONCAT(au.tablaafectada,' - ',au.idafectado) AS REGISTRO FROM" +
                " auditoria au INNER JOIN usuarios users ON au.usuario = users.usuario " +
                " WHERE au.usuario LIKE '"+ cbusuario.SelectedValue +"' AND au.accion LIKE '"+ cbaccion.Text + "' AND au.fecha  BETWEEN '" + desde.Value.ToString() + "' " +
                " AND '" + hasta.Value.ToString() + "' ";
                rellenargrid(sql);

            }
        }


    }
}

