using Microsoft.VisualBasic;
using System;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;
using TrabajoDeGrado.Generales;
using TrabajoDeGrado.Modulos;

namespace TrabajoDeGrado.Secciones.Estudiantes_y_Profesores.Estudiantes
{
    public partial class agregarproyector : Form
    {
        Funciones_Generales generales = new Funciones_Generales();
        Funciones_BD BD = new Funciones_BD();
        public string usuario;
        public agregarproyector() { InitializeComponent(); }

        public void comprobartextbox(){
            var vr = !string.IsNullOrEmpty(tbmarca.Text) &&
                !string.IsNullOrEmpty(tbmodelo.Text) &&
                !string.IsNullOrEmpty(tbcantidad.Text);
            btnagregar.Enabled = vr;
        }

        #region BOTONES
        private void Btnagregar_Click_1(object sender, EventArgs e)
        {
            string mensaje = "El proyector ha sido registrado exitosamente";

            string sql = "INSERT INTO proyectores (marca, modelo, existencias) values " +
                        " ('" + System.Convert.ToString(tbmarca.Text) + "'," +
                        " '" + System.Convert.ToString(tbmodelo.Text) + "'," +
                        " '" + System.Convert.ToString(tbcantidad.Text) + "')";
            BD.agregar(sql, mensaje, true,  usuario, "CREACION", "PROYECTOR", tbmarca.Text + tbmodelo.Text, true, this);

            


            proyectores frm = (proyectores)Application.OpenForms["proyectores"];
            if (Application.OpenForms.OfType<proyectores>().Any())
            {
                frm.rellenargrid("SELECT id AS ID, marca AS MARCA," +
                    "modelo AS MODELO, existencias AS CANT FROM proyectores WHERE existencias >= '1'");
            }

        }

        private void Btncerrar_Click(object sender, EventArgs e) { this.Close(); }
        #endregion

        #region EVENTOS DE OBJETOS


        #endregion


        #region FUNCION DE MODIFICACION

        public void autorrelleno()
        {
            BD.abrirconexion();
            SqlCommand comando = new SqlCommand("SELECT * FROM libros WHERE cota = '" + tbmarca.Text + "'", BD.conexion);
            SqlDataReader lector;
            lector = comando.ExecuteReader();
            if (lector.Read())
            {
                tbmodelo.Text = lector["titulo"].ToString();
                tbcantidad.Text = lector["existencias"].ToString();

            }
            BD.conexion.Close();
        }




        #endregion

        private void tbmodelo_TextChanged(object sender, EventArgs e)
        {
            comprobartextbox();
            tbmarca.CharacterCasing = CharacterCasing.Upper;
            tbmodelo.CharacterCasing = CharacterCasing.Upper;

        }
    }
}

