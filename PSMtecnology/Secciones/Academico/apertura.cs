using Microsoft.VisualBasic;
using System;
using System.Data.SqlClient;
using System.Globalization;
using System.Windows.Forms;
using TrabajoDeGrado.Generales;
using TrabajoDeGrado.Modulos;
using TrabajoDeGrado.Secciones.Pagina_Pincipal;

namespace TrabajoDeGrado.Secciones.Estudiantes_y_Profesores.Estudiantes
{
    public partial class apertura : Form
    {
        Funciones_Generales generales = new Funciones_Generales();
        Funciones_BD BD = new Funciones_BD();
        public string usuario;
        public apertura() { InitializeComponent(); }

        
        #region BOTONES
        private void Btnagregar_Click_1(object sender, EventArgs e)
        {
            mensajeinformacion emergente = new mensajeinformacion();
            BD.abrirconexion();

            SqlCommand comando = new SqlCommand("SELECT * FROM periodo WHERE año = '" + tbaño.Text + "' AND semestre = '"+tbsemestre.Text+"'", BD.conexion);
            SqlDataReader lector = comando.ExecuteReader(); ;

            if (lector.Read())
            {
                emergente.Show();
                emergente.lblalerta.Text = "El periodo academico ya se encuentra aperturado";
                lector.Close();

            }
            else
            {
                string sql = "INSERT INTO periodo (año, semestre) values " +
                            " ('" + System.Convert.ToString(tbaño.Text) + "'," +
                            " '" + System.Convert.ToString(tbsemestre.Text) + "')";

                string mensaje = "El periodo ha sido aperturado correctamente";

                BD.agregar(sql, mensaje,true, usuario,"PERIODO","APERTURACION", tbaño.Text + tbsemestre.Text, true,this);
                this.Close();

              
            }


        }

        private void Btncerrar_Click(object sender, EventArgs e) { this.Close(); }
        #endregion

        public void fecha()
        {
            int semestre;
            tbaño.Text=DateTime.Now.Year.ToString();

            if (DateTime.Now.Month <= 7  )
            {
                semestre = 2;
            }
            else
            {
                semestre=1;
            }
            tbsemestre.Text = semestre.ToString();
        }
    }
}

