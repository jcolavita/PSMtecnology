using PSMTecnology.Generales.Clases;
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
using TrabajoDeGrado.Secciones.Administrador.Gestionar_usuarios;
using TrabajoDeGrado.Secciones.Estudiantes_y_Profesores;
using TrabajoDeGrado.Secciones.Pagina_Pincipal;

namespace TrabajoDeGrado.Secciones.Login
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        public void limpiar()
        {
            lblerror.Visible = false;
            tbusuario.Text = "USUARIO";
            tbclave.Text = "CONTRASEÑA";
            tbusuario.ForeColor = Color.LightGray;
            tbclave.ForeColor = Color.LightGray;
        }

        Funciones_BD BD = new Funciones_BD();
        Funciones_Generales generales = new Funciones_Generales();
        mensajeerror error = new mensajeerror();
        mensajeinformacion alerta = new mensajeinformacion();

        public void comprobartb()
        {
            var vr = !string.IsNullOrEmpty(tbusuario.Text);
            btnrecuperar.Enabled = vr;
            btniniciar.Enabled = vr;
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btniniciar_Click(object sender, EventArgs e)
        {
            if (tbusuario.Text=="USUARIO")
            {
                return;
            }
            BD.abrirconexion();
            Pagina_principal principal = new Pagina_principal();

            SqlCommand cmndintentoexcedido = new SqlCommand("SELECT * FROM usuarios WHERE usuario = '" + tbusuario.Text + "' AND intento > '2'", BD.conexion);
            SqlCommand cmndiniciar = new SqlCommand("SELECT * FROM usuarios WHERE usuario = '" + tbusuario.Text + "' AND clave = '" + tbclave.Text + "' COLLATE SQL_Latin1_General_CP1_CS_AS AND estado LIKE 'ACTIVO'", BD.conexion);
            SqlCommand cmndclaveincorrecta = new SqlCommand("SELECT * FROM usuarios WHERE usuario = '" + tbusuario.Text + "'  AND estado = 'ACTIVO'", BD.conexion);
            SqlCommand cmndusuarioinactivo = new SqlCommand("SELECT * FROM usuarios WHERE usuario = '" + tbusuario.Text + "'  AND estado = 'INACTIVO'", BD.conexion);


            SqlDataReader lcteexcedido = cmndintentoexcedido.ExecuteReader();
            if (lcteexcedido.Read())
            {
                error.Show();
                error.lblalerta.Text = "Numero de intentos excedido, su cuenta se encuentra bloqueada, acuda con el administrador.";
                lcteexcedido.Close();
                return;
            }
            lcteexcedido.Close();

            SqlDataReader lctiniciar = cmndiniciar.ExecuteReader();
            if (lctiniciar.Read())
            {
                string restar = "UPDATE usuarios  SET intento = 0 WHERE usuario= '" + tbusuario.Text + "'";
                BD.actualizar(restar, "", false, "", "", "", false, this);

                principal.lbldepartamento.Text = lctiniciar["departamento"].ToString().Trim();
                principal.lblusuario.Text = lctiniciar["usuario"].ToString().Trim();
                principal.lblnombre.Text = lctiniciar["primernombre"].ToString().Trim() + " " + lctiniciar["primerapellido"].ToString().Trim();
                principal.permisos = lctiniciar["permisos"].ToString().Trim();
                lctiniciar.Close();
                principal.usuarios();

                principal.Show();
                this.Hide();
                return;

            }
            lctiniciar.Close();

            SqlDataReader lctclaveincorrecta = cmndclaveincorrecta.ExecuteReader();
            if (lctclaveincorrecta.Read())
            {
                string sumar = "UPDATE usuarios  SET intento = intento +1 WHERE usuario= '" + tbusuario.Text + "'";
                int intento = Int32.Parse(lctclaveincorrecta["intento"].ToString()) + 1;
                BD.actualizar(sumar, "", false, "", "", "", false, this);
                lblerror.Text = "Ha introducido su clave incorrectamente (" + intento + "/3)";
                lblerror.Visible = true;
                MessageBox.Show("La clave ingresada es incorrecta");
                lctclaveincorrecta.Close();
                return;
            }
            lctclaveincorrecta.Close();


            SqlDataReader lctusuarioinactivo = cmndusuarioinactivo.ExecuteReader();
            if (lctusuarioinactivo.Read())
            {
                alerta.Show();
                alerta.lblalerta.Text = "El usuario no se encuentra ACTIVO, para mas informacion por favor acuda con el administrador.";
                lctusuarioinactivo.Close();
            }
            else
            {
                error.Show();
                error.lblalerta.Text = "El usuario no se encuentra registrado.";
                lctusuarioinactivo.Close();
            } 
        }
        private void tbusuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            generales.validarnumeros(e);
        }

        private void btnrecuperar_Click(object sender, EventArgs e)
        {
            recuperarcontraseña recuperar = new recuperarcontraseña();
            
            BD.abrirconexion();
            SqlCommand comando = new SqlCommand("SELECT * FROM usuarios WHERE usuario = '" + tbusuario.Text + "'", BD.conexion);
            SqlDataReader lector = comando.ExecuteReader(); ;

            if (lector.Read())
            {
                recuperar.Show();
                recuperar.usuario.Text = tbusuario.Text;
                recuperar.rellenarcampos();
            }
            else
            {
                MessageBox.Show("error");
            }
        }

        private void tbusuario_TextChanged(object sender, EventArgs e)
        {
            comprobartb();
        }

        private void login_Load(object sender, EventArgs e)
        {
            limpiar();
        }



        private void tbusuario_Click_1(object sender, EventArgs e)
        {
            if (tbusuario.Text=="USUARIO")
            {
                tbusuario.Text = "";
                tbusuario.ForeColor = Color.Black;
            }

        }

        private void tbclave_Click(object sender, EventArgs e)
        {
            if (tbclave.Text== "CONTRASEÑA")
            {
                tbclave.UseSystemPasswordChar=true; 
                tbclave.Text = "";
                tbclave.ForeColor = Color.Black;
            }
        }

        private void tbusuario_Leave(object sender, EventArgs e)
        {

            if (tbusuario.Text=="")
            {
                tbusuario.Text = "USUARIO";
                tbusuario.ForeColor = Color.LightGray;
            }
        }

        private void tbclave_Leave(object sender, EventArgs e)
        {
            if (tbclave.Text=="")
            {
                tbclave.UseSystemPasswordChar = false;
                tbclave.Text = "CONTRASEÑA";
                tbclave.ForeColor = Color.LightGray;
            }
        }

        private void tbclave_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
