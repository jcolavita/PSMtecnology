using System;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Windows.Forms;
using TrabajoDeGrado.Generales;
using TrabajoDeGrado.Modulos;

namespace TrabajoDeGrado.Secciones.Estudiantes_y_Profesores.Estudiantes
{
    public partial class areapersonal : Form
    {


        #region VARIABLES
  
        Funciones_BD BD= new Funciones_BD();
        Funciones_Generales generales = new Funciones_Generales();
        public string usuario;

        #endregion

        public areapersonal() { InitializeComponent();  } 

        //rellenar grid, se utiliza tanto al cargar la pagina como con el boton de buscar

        public void rellenargrid(string sql)
        {

            BD.abrirconexion();
            grid.Columns.Clear();
            SqlDataAdapter da = new SqlDataAdapter(sql, BD.conexion);
            System.Data.DataTable ds = new System.Data.DataTable();
            da.Fill(ds);
            grid.DataSource = ds;
            generales.btneditar(grid);

            BD.conexion.Close();
        }

        private void Btncerrar_Click(object sender, EventArgs e) { this.Close(); }


        //funcion para la accion del boton en el grid
        private void gridestudiantes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (cbtipo.SelectedIndex == 1)
            {
                entregarproyector ver = new entregarproyector();

                if (grid.Columns[e.ColumnIndex].HeaderText == "EDITAR" && e.RowIndex > -1)
                {
                    Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is entregarproyector);

                    if (frm != null)
                    {
                        //si la instancia existe la pongo en primer plano
                        frm.Close();
                    }
                    string estado = grid.CurrentRow.Cells["ESTADO"].Value.ToString();

                    ver.Show();
                    if (estado == "ACTIVO")
                    {
                        ver.anular.Visible = false;
                        ver.lblcabecera.Text = "Prestamo de Proyector";

                    }
                    ver.ID.Text = grid.CurrentRow.Cells["ID"].Value.ToString();
                    ver.tbcedula.Text = usuario;
                    ver.btnentregar.Visible = false;
                    ver.tbnombre.Visible = false;
                    ver.lblnombre.Visible = false;
                    ver.lblcabecera.Text = "Reserva de Proyector";



                    ver.autorrelleno();
                }
            }

            if (cbtipo.SelectedIndex == 0)
            {
                confirmarprestamo ver = new confirmarprestamo();

                if (grid.Columns[e.ColumnIndex].HeaderText == "EDITAR" && e.RowIndex > -1)
                {
                    Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is confirmarprestamo);

                    if (frm != null)
                    {
                        //si la instancia existe la pongo en primer plano
                        frm.Close();
                    }
                    string estado = grid.CurrentRow.Cells["ESTADO"].Value.ToString();

                    ver.Show();
                    if (estado == "ACTIVO")
                    {
                        ver.btncancelar.Visible = false;
                        ver.lblcabecera.Text = "Prestamo Activo";
                    }
                    else
                    {
                        ver.lblcabecera.Text = "Solicitud de Prestamo";

                    }
                    ver.id.Text = grid.CurrentRow.Cells["ID"].Value.ToString();
                    ver.tbcodigo.Text = grid.CurrentRow.Cells["LIBRO"].Value.ToString();

                    ver.tbcedula.Text = usuario;
                    ver.btnagregar.Visible = false;

                    ver.autorrelleno();
                }
            }
            if (cbtipo.SelectedIndex == 2)
            {
                reservararea ver = new reservararea();

                if (grid.Columns[e.ColumnIndex].HeaderText == "EDITAR" && e.RowIndex > -1)
                {
                    Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is reservararea);

                    if (frm != null)
                    {
                        //si la instancia existe la pongo en primer plano
                        frm.Close();
                    }

                    ver.Show();

                    ver.id.Text = grid.CurrentRow.Cells["ID"].Value.ToString();

                    ver.tbusuario.Text = usuario;
                    ver.btnreservar.Text = "Actualizar";
                    ver.btnfinalizar.Visible = true;
                    ver.lblcabecera.Text = "Reservacion de Area";

                    ver.autorrelleno();
                }
            }
            if (cbtipo.SelectedIndex == 3)
            {
                procesarretraso ver = new procesarretraso();

                if (grid.Columns[e.ColumnIndex].HeaderText == "EDITAR" && e.RowIndex > -1)
                {
                    Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is procesarretraso);

                    if (frm != null)
                    {
                        //si la instancia existe la pongo en primer plano
                        frm.Close();
                    }

                    ver.Show();

                    ver.id.Text = grid.CurrentRow.Cells["ID"].Value.ToString();
                    ver.autorrelleno();
                    ver.btnagregar.Visible = false;
                    ver.tbnumero.ReadOnly = true;
                    ver.lblcabecera.Text = "Retraso de Entrega";
                }

            }
        }

        private void cbtipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sql ="";


            if (cbtipo.SelectedIndex == -1)
            {
                grid.Columns.Clear();
                return;
            }
            
            else if (cbtipo.SelectedIndex==0)
            {
               
                sql = "SELECT id AS ID,idproducto AS LIBRO, salida AS SALIDA, entrada AS DEVOLUCION, estado AS ESTADO FROM prestamoslibros WHERE cedulausuario ='" + usuario + "' ";

            }
            else if (cbtipo.SelectedIndex == 1)
            {
                sql = "SELECT id AS ID, salida AS SALIDA, devolucion AS DEVOLUCION,materia AS NATERIA,  estado AS ESTADO FROM reservaproyector WHERE cedulausuario ='" + usuario + "' ";

            }
            else if (cbtipo.SelectedIndex == 2)
            {
                sql = "SELECT id AS ID, horainicio AS DIA, catedras AS CATEDRAS, secciones AS SECCIONES,  escuela AS ESCUELA FROM alquilerarea WHERE cedulaprofesor ='" + usuario + "' ";

            }
            else if (cbtipo.SelectedIndex == 3)
            {
                sql = "SELECT id AS ID, idproducto AS PRODUCTO, entregaestipulada AS FECHAESTIPULADA, fechadeentrega AS FECHAENTREGA,  motivo AS MOTIVO, estado AS ESTADO FROM retrasos WHERE cedulausuario ='" + usuario + "' ";

            }
            rellenargrid(sql);

        }

    }
}




