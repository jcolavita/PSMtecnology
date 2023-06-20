using Microsoft.VisualBasic;
using PSMtecnology.Generales.Clases;
using System;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;
using TrabajoDeGrado.Generales;
using TrabajoDeGrado.Modulos;

namespace TrabajoDeGrado.Secciones.Estudiantes_y_Profesores.Estudiantes
{
    public partial class Agregarlibro : Form
    {
        Funciones_Generales generales = new Funciones_Generales();
        Funciones_BD BD = new Funciones_BD();
        public string usuario;
        public Agregarlibro() { 
            InitializeComponent();
            BD.materias(cbmateria);
        }

        public void comprobartextbox(){
            var vr = !string.IsNullOrEmpty(tbcota.Text) &&
                !string.IsNullOrEmpty(tbtitulo.Text) &&
                !string.IsNullOrEmpty(tbautor.Text) &&
                !string.IsNullOrEmpty(tbeditorial.Text) &&
                !string.IsNullOrEmpty(cbmateria.Text) &&
                !string.IsNullOrEmpty(tbcantidad.Text);
            btnagregar.Enabled = vr;
        }

        #region BOTONES
        private void Btnagregar_Click_1(object sender, EventArgs e)
        {
            bool mostrarmensaje = true;

            if (btnagregar.Text == "Actualizar")
            {
                string sql = "UPDATE INVENTARIO$  SET Titulo ='" + tbtitulo.Text + "', Autor='" + tbautor.Text + "'," +
                            " Editorial ='" + tbeditorial.Text + "',existencia ='" + tbcantidad.Text + "', " +
                            " Materia='" + cbmateria.Text + "' WHERE cota LIKE '"+tbcota.Text+"'";

                string mensaje = "El Libro ha sido modificado correctamente";
                BD.actualizar(sql, mensaje, mostrarmensaje, usuario, "LIBRO", tbcota.Text , true, this);


            }
            else
            {
                string sql = "INSERT INTO INVENTARIO$ (cota, Titulo, Autor, Editorial,existencia,Materia) values " +
                            " ('" + System.Convert.ToString(tbcota.Text) + "'," +
                            " '" + System.Convert.ToString(tbtitulo.Text) + "'," +
                            " '" + System.Convert.ToString(tbautor.Text) + "'," +
                            " '" + System.Convert.ToString(tbeditorial.Text) + "'," +
                            " '" + System.Convert.ToString(tbcantidad.Text) + "'," +
                            " '" + System.Convert.ToString(cbmateria.Text) + "'";

                string mensaje = "El Libro ha sido registrado exitosamente";

                string COTA = tbcota.Text;

                BD.agregar(sql, mensaje,true,  usuario, "LIBRO", "CREACION", COTA, true, this);
                
            }
            Libros frm = (Libros)Application.OpenForms["Libros"];
            if (Application.OpenForms.OfType<Libros>().Any())
            {
                frm.rellenargrid("SSELECT cota AS COTA, titulo AS TITULO," +
                "Autor AS AUTOR, Editorial AS EDITORIAL, Existencia AS CANT , Materia AS MATERIA FROM INVENTARIO$" +
                " WHERE existencia >= '1'");
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
            SqlCommand comando = new SqlCommand("SELECT * FROM INVENTARIO$ WHERE cota LIKE '" + tbcota.Text + "'", BD.conexion);
            SqlDataReader lector;
            lector = comando.ExecuteReader();
            if (lector.Read())
            {
                tbtitulo.Text = lector["Titulo"].ToString();
                tbautor.Text = lector["Autor"].ToString();
                tbeditorial.Text = lector["Editorial"].ToString();
                tbcantidad.Text = lector["existencia"].ToString();
                cbmateria.Text = lector["Materia"].ToString();
                tbcota.Text = lector["cota"].ToString();
                lector.Close();

            }
            BD.conexion.Close();
        }




        #endregion

        private void tbcantidad_TextChanged(object sender, EventArgs e)
        {
            comprobartextbox();
            tbcota.CharacterCasing = CharacterCasing.Upper;
            tbtitulo.CharacterCasing = CharacterCasing.Upper;
            tbautor.CharacterCasing = CharacterCasing.Upper;
            tbeditorial.CharacterCasing = CharacterCasing.Upper;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cbmateria_SelectedIndexChanged(object sender, EventArgs e)
        {
            BD.abrirconexion();
            SqlCommand comando = new SqlCommand("SELECT * FROM libros WHERE materia = '" + cbmateria.Text + "'", BD.conexion);
            SqlDataReader lector;
            lector = comando.ExecuteReader();
            if (lector.Read())
            {
                tbcota.Text = lector["cota"].ToString();
                int correlativo = Int32.Parse(lector["correlativo"].ToString()) + 1;
                tbcota.ReadOnly = true;

                lector.Close();

            }
            else
            {
                tbcota.ReadOnly = false;
                lector.Close();
            }
            BD.conexion.Close();
        }

        private void tbcorrelativo_KeyPress(object sender, KeyPressEventArgs e)
        {
            generales.validarnumeros(e);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            materia materia = new materia();
            materia.materiasadeaf(comboBox1, cbmateria);
            cbmateria.Enabled = true;
        }
    }
}

