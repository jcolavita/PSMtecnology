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
//using TrabajoDeGrado.Properties;

namespace TrabajoDeGrado.Secciones.Administrador.Gestionar_usuarios
{
    public partial class configurarclave : Form
    {
        Funciones_BD BD = new Funciones_BD();
        mensajecorrecto mensaje = new mensajecorrecto();
        Funciones_Generales generales = new Funciones_Generales();


        public configurarclave(){InitializeComponent(); }
        public void Comprobartextbox()
        {
            if (tbnuevacontrasena.Text.Length>0)
            {
                if (!robustez(tbnuevacontrasena.Text))
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

            var vr = !string.IsNullOrEmpty(tbcontrasenaactual.Text) &&
            !string.IsNullOrEmpty(cbpregunta.Text) &&
            !string.IsNullOrEmpty(tbrespuesta.Text) &&
            !string.IsNullOrEmpty(tbcontrasenaactual.Text);
            btnconfirmar.Enabled = vr;
        }

        private void Btncerrar_Click(object sender, EventArgs e){this.Close();}

        private void tbcontrasenaactual_TextChanged(object sender, EventArgs e){Comprobartextbox();
            tbrespuesta.CharacterCasing = CharacterCasing.Upper;
            
            
        }


        public bool robustez(string clave)
        {
            bool mayuscula = false, simbolo = false, numero = false, minuscula = false;

            for (int i = 0; i < clave.Length; i++)
            {
                if (char.IsUpper(clave, i))
                {
                    mayuscula = true;
                }
                else if (char.IsLower(clave, i))
                {
                    minuscula = true;
                }
                else if (char.IsDigit(clave, i))
                {
                    numero = true;
                }
                else
                {
                    simbolo = true;
                }
            }
            if (mayuscula && simbolo && numero && minuscula && clave.Length > 8)
            {
                return true;
            }
            return false;
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
                tbrespuesta.Text = lector["respuesta"].ToString();
                tbcodigo.Text = lector["codigotlf"].ToString();
                Tbtelefono.Text = lector["telefono"].ToString();
                Tbcorreo.Text = lector["correo"].ToString();

            }
            BD.conexion.Close();
        }

        private void btnconfirmar_Click(object sender, EventArgs e)
        {
            bool mostrarmensaje = true;
            string nuevaclave = "";

            if (tbnuevacontrasena.Text.Length>1)
            {
                nuevaclave = " , clave = "+ tbnuevacontrasena.Text +"";
            }

            BD.abrirconexion();
            SqlCommand comando = new SqlCommand("SELECT * FROM usuarios WHERE usuario = '" + usuario.Text + "' AND clave='"+tbcontrasenaactual.Text+"'", BD.conexion);
            SqlDataReader lector;
            lector = comando.ExecuteReader();
            if (lector.Read())
            {
                string sql = "UPDATE usuarios  SET pregunta ='" + cbpregunta.Text + "', respuesta='" + tbrespuesta.Text + "' "+nuevaclave+"," +
                    " codigotlf ='"+tbcodigo.Text+"', telefono ='"+Tbtelefono.Text+"', correo = '"+Tbcorreo.Text+"' WHERE usuario='" + usuario.Text + "'";

                string mensaje = "Las configuraciones han sido modificadas con exito.";
                BD.actualizar(sql, mensaje, mostrarmensaje, usuario.Text, "CLAVE DE USUARIO", usuario.Text, true, this);
                this.Close();
                BD.conexion.Close();


            }
            else
            {
                mensaje.Show();
                mensaje.lblalerta.Text = "La contraseña ingresada es incorrecta, por favor verifiquela e intente nuevamente";
            }
            BD.conexion.Close();


            
        }

        private void Tbcorreo_TextChanged(object sender, EventArgs e)
        {
            Tbcorreo.CharacterCasing = CharacterCasing.Upper;
        }

        private void tbcodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            generales.validarnumeros(e);
        }
    }
}
