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

namespace TrabajoDeGrado.Secciones.Administrador.Gestionar_usuarios
{
    public partial class recuperarcontraseña : Form
    {
        Funciones_Generales generales = new Funciones_Generales();
        Funciones_BD BD = new Funciones_BD();

        public recuperarcontraseña(){InitializeComponent(); }
        public void Comprobartextbox()
        {
            if (tbnuevacontrasena.Text.Length>0)
            {
                if (tbnuevacontrasena.Text.Length < 8)
                {
                    lblerror2.Visible = true;
                    btnconfirmar.Enabled = false;
                    return;
                }
                else
                {
                    lblerror2.Visible = false;

                }

            }

            if (tbnuevacontrasena.Text != tbcontrasena2.Text)
            {
                lblerror.Visible=true;
                btnconfirmar.Enabled = false;
                
                return;
            }
            lblerror.Visible=false;

            var vr = !string.IsNullOrEmpty(cbpregunta.Text) &&
            !string.IsNullOrEmpty(tbrespuesta.Text) &&
            !string.IsNullOrEmpty(tbcontrasena2.Text) &&
            !string.IsNullOrEmpty(tbnuevacontrasena.Text );
            btnconfirmar.Enabled = vr;
        }

        private void Btncerrar_Click(object sender, EventArgs e){this.Close();}

        private void tbcontrasenaactual_TextChanged(object sender, EventArgs e){Comprobartextbox();
            tbrespuesta.CharacterCasing = CharacterCasing.Upper;
        }

        public void rellenarcampos()
        {
            BD.abrirconexion();
            SqlCommand comando = new SqlCommand("SELECT * FROM usuarios WHERE usuario = '" + usuario.Text + "'", BD.conexion);
            SqlDataReader lector;
            lector = comando.ExecuteReader();
            if (lector.Read())
            {
                cbpregunta.Text = lector["pregunta"].ToString();
                lector.Close();
    
            }
            else
            {
                lector.Close();
            }
            BD.conexion.Close();
        }

        private void btnconfirmar_Click(object sender, EventArgs e)
        {
            //"UPDATE usuarios  SET pregunta ='" + cbpregunta.Text + "', respuesta='" + tbrespuesta.Text + "' " + nuevaclave + " WHERE usuario='" + usuario.Text + "'";

            bool mostrarmensaje = true;
            BD.abrirconexion();
            SqlCommand comando = new SqlCommand("SELECT * FROM usuarios WHERE usuario  LIKE '" + usuario.Text + "' AND pregunta LIKE '" + cbpregunta.Text + "' AND respuesta LIKE '" + tbrespuesta.Text + "'", BD.conexion);
            SqlDataReader lector;
            lector = comando.ExecuteReader();
            if (lector.Read())
            {
                string sql = "UPDATE usuarios  SET clave ='" + tbnuevacontrasena.Text + "' WHERE usuario='" + usuario.Text + "'";

                string mensaje = "La contraseña han sido modificadas con exito.";
                BD.actualizar(sql, mensaje, mostrarmensaje,usuario.Text, "CLAVE DE USUARIO", usuario.Text, true, this);
                this.Close();
                BD.conexion.Close(); 
                lector.Close();
            }
            else
            {
                MessageBox.Show("la respuesta de seguridad ingresada no coincide");

                lector.Close();
            }
            BD.conexion.Close();
        }
    }
}
