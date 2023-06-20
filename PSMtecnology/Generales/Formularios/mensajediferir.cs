using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Services.Description;
using System.Windows.Forms;
using TrabajoDeGrado.Modulos;
using TrabajoDeGrado.Secciones.Estudiantes_y_Profesores.Estudiantes;

namespace TrabajoDeGrado.Generales
{
    public partial class mensajediferir : Form
    {
        public string  tabla;
        public int ciestudiante, periodoconsultado, periododelproyecto;
        public ComboBox cbperiodo,cbintento,cbestatus;
        public RichTextBox tbtitulo;
        public Button boton, buscar, limpiar;
        Funciones_BD BD = new Funciones_BD();
        mensajeinformacion alerta = new mensajeinformacion();


        private void btnreprobar_Click(object sender, EventArgs e)
        {
            BD.abrirconexion();

            string sql = "SELECT periodo FROM "+tabla+" WHERE ciestudiante = " + ciestudiante + "";

            SqlCommand cmnd = new SqlCommand(sql, BD.conexion);
            SqlDataReader lectorproyecto = cmnd.ExecuteReader();

            if (lectorproyecto.Read())
            {
                string sqlreprobar = "UPDATE "+tabla+" SET estatus = 'REPROBADO' WHERE ciestudiante = '"+ciestudiante+"' AND periodo ='"+ periododelproyecto+"'";
                BD.actualizar(sqlreprobar,"Se ha marcado el proyecto anterior como REPROBADO",true,"","","",false,this);
            }
        }

        public Panel panel;


        private void btncerrar_Click(object sender, EventArgs e)
        {
            panel.Enabled = false;
            limpiar.Enabled=true;
            this.Close();
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            panel.Enabled = false;
            limpiar.Enabled = true;
            this.Close();
        }


        private void btndiferir_Click(object sender, EventArgs e)
        {
            BD.abrirconexion();

            string sql = "SELECT titulo, estatus, intento, periodo FROM "+tabla+" WHERE ciestudiante = " + ciestudiante + "";
            string periodosql = "SELECT id FROM periodo ORDER BY id DESC";
            
            SqlCommand cmnd = new SqlCommand(sql, BD.conexion);
            SqlCommand cmdperiodo = new SqlCommand(periodosql, BD.conexion);

            SqlDataReader lector = cmdperiodo.ExecuteReader();
            if (lector.Read())
            {
                periodoconsultado = Int32.Parse(lector["id"].ToString());
                lector.Close();
            }
            lector.Close();

            SqlDataReader lectorproyecto = cmnd.ExecuteReader();
            if (lectorproyecto.Read())
            {
                periododelproyecto = Int32.Parse(lectorproyecto["periodo"].ToString());
                if (periodoconsultado == periododelproyecto)
                {
                    alerta.Show();
                    alerta.lblalerta.Text = "No es posible diferir un proyecto en el mismo periodo.";
                    panel.Enabled = false;
                    lectorproyecto.Close();
                }
                else
                {
                    alerta.Show();
                    alerta.lblalerta.Text = "El proyecto ha sido marcado como diferido.";
                    tbtitulo.Text = lectorproyecto["titulo"].ToString();
                    cbperiodo.SelectedValue = periodoconsultado;
                    cbintento.SelectedIndex = Int32.Parse(lectorproyecto["intento"].ToString()) + 1;
                    boton.Text = "Actualizar";
                    boton.Enabled = true;
                    cbestatus.Text = "DIFERIDO";
                    lectorproyecto.Close();

                    SqlCommand command = new SqlCommand("UPDATE "+tabla+" SET periodo ='" + periodoconsultado+ "', estatus='DIFERIDO' WHERE ciestudiante = " + ciestudiante + "", BD.conexion);
                    command.ExecuteNonQuery();
                }
                this.Close();
            }   
        }

        public mensajediferir()
        {
            InitializeComponent();
        }
        public void comprobarpasantia()
        {
            if (tabla=="pasantias")
            {
                btndiferir.Visible = false;
                btnreprobar.Location=new Point(12, 85);
            }
        }

    }
}
