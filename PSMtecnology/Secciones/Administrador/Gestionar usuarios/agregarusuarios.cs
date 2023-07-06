using Microsoft.VisualBasic;
using System;
using System.Data.SqlClient;
using System.Linq;
using System.Security.AccessControl;
using System.Security.Cryptography;
using System.Windows.Forms;
using TrabajoDeGrado.Generales;
using TrabajoDeGrado.Modulos;

namespace TrabajoDeGrado.Secciones.Estudiantes_y_Profesores.Estudiantes
{
    public partial class agregarusuarios : Form
    {
        Funciones_Generales generales = new Funciones_Generales();
        Funciones_BD BD = new Funciones_BD();
        public string usuario;

        Pagina_Pincipal.Pagina_principal principal = new Pagina_Pincipal.Pagina_principal();

        public agregarusuarios() { InitializeComponent();}


        public void Comprobartextbox(){

            if (tbcedula.Text.Length<7)
            {
                Btnagregar.Enabled = false;
                return;
            }

                var vr = !string.IsNullOrEmpty(tbcedula.Text) &&
                !string.IsNullOrEmpty(tbprimernombre.Text) &&
                !string.IsNullOrEmpty(Tbprimerapellido.Text) &&
                !string.IsNullOrEmpty(Tbprimerapellido.Text) &&
                !string.IsNullOrEmpty(tbcodigo.Text) &&
                !string.IsNullOrEmpty(Tbtelefono.Text)&&
                !string.IsNullOrWhiteSpace(cbtipo.Text);
            Btnagregar.Enabled = vr;
        }

        #region BOTONES
        
        
        private void Btnagregar_Click(object sender, EventArgs e)
        {
            bool mostrarmensaje = true;

            if (Btnagregar.Text=="Actualizar")
            {
                string sql = "UPDATE usuarios  SET codigotlf ='"+tbcodigo.Text+"',telefono ='"+Tbtelefono.Text+"', correo ='"+Tbcorreo.Text+"', " +
                    " primernombre ='" + tbprimernombre .Text.Trim() + "', segundonombre='" + Tbsegundonombre.Text.Trim() + "'," +
                    " primerapellido ='" + Tbprimerapellido.Text.Trim() + "',segundoapellido ='" + Tbsegundoapellido .Text.Trim() + "'," +
                    " departamento = '"+ cbtipo.Text + "', permisos = '"+ permisologia() +"', estado ='"+cbestado.Text+"' WHERE usuario='" + tbcedula.Text + "'";

                string mensaje = "El usuario ha sido modificado correctamente";
                BD.actualizar(sql, mensaje, mostrarmensaje, usuario, "USUARIO", tbcedula.Text, true, this);
                this.Close();

            }
            else
            {
                string cedula = tbcedula.Text.Substring(0, 4);
                string clave = "psm" + cedula;

                string sql = "INSERT INTO usuarios(usuario,clave, primernombre,segundonombre,primerapellido,segundoapellido," +
                "departamento,intento, codigotlf, telefono, correo,estado,permisos) VALUES(" +
                "'" + System.Convert.ToString(tbcedula.Text.Trim()) + "'," +
                "'" + System.Convert.ToString(clave) + "'," +
                " '" + System.Convert.ToString(tbprimernombre.Text.Trim()) + "'," +
                " '" + System.Convert.ToString(Tbsegundonombre.Text.Trim()) + "'," +
                " '" + System.Convert.ToString(Tbprimerapellido.Text.Trim()) + "'," +
                " '" + System.Convert.ToString(Tbsegundoapellido.Text.Trim()) + "'," +
                " '" + System.Convert.ToString(cbtipo.Text.Trim()) + "'," +
                " '" + System.Convert.ToString("0") + "'," +
                " '" + System.Convert.ToString(tbcodigo.Text) + "'," +
                " '" + System.Convert.ToString(Tbtelefono.Text) + "'," +
                " '" + System.Convert.ToString(Tbcorreo.Text) + "'," +
                " '" + System.Convert.ToString("ACTIVO") + "'," +
                " '" + System.Convert.ToString(permisologia()) + "')";
                BD.agregar(sql, "Usuario registrado satisfactoriamentem, su clave por defecto es: "+ clave, true, usuario, "USUARIO", "CREACION", tbcedula.Text, true,this);
            }

            gestionarusuarios frm = (gestionarusuarios)Application.OpenForms["gestionarusuarios"];
            if (Application.OpenForms.OfType<gestionarusuarios>().Any())
            {
                frm.rellenargrid("SELECT usuario AS USUARIO, CONCAT (primernombre ,' ',segundonombre,' ',primerapellido,' ',segundoapellido ) AS NOMBRE, departamento AS DEPARTAMENTO FROM usuarios");
            }

        }

        private void Btncerrar_Click(object sender, EventArgs e) { this.Close(); }
        
        #endregion

        #region FUNCION DE MODIFICACION 

        public void rellenarcampos()
    {
            BD.abrirconexion();
            SqlCommand comando = new SqlCommand("SELECT * FROM usuarios WHERE usuario = '" + tbcedula.Text + "'", BD.conexion);
            SqlDataReader lector = comando.ExecuteReader();
            String permisologia;


            if (lector.Read())
            {
                tbprimernombre .Text = lector["primernombre"].ToString();
                Tbsegundonombre .Text = lector["segundonombre"].ToString();
                Tbprimerapellido .Text = lector["primerapellido"].ToString();
                Tbsegundoapellido .Text = lector["segundoapellido"].ToString();
                cbtipo.Text = lector["departamento"].ToString().Trim();
                tbcodigo.Text = lector["codigotlf"].ToString().Trim();
                Tbtelefono.Text = lector["telefono"].ToString().Trim();
                Tbcorreo.Text = lector["correo"].ToString().Trim();
                cbestado.Text = lector["estado"].ToString();
                permisologia = lector["permisos"].ToString();
                lector.Close();

                if (permisologia.Contains("1,"))
                {
                    cbeditar.Checked = true;
                }
                if (permisologia.Contains("2,"))
                {
                    cbregistrar.Checked = true;
                }
                if (permisologia.Contains("3,"))
                {
                    cbadmin.Checked = true;
                }
                if (permisologia.Contains("4,"))
                {
                    cbactas.Checked = true;
                }
                if (permisologia.Contains("5,"))
                {
                    cbretrasos.Checked = true;
                }
                if (permisologia.Contains("6,"))
                {
                    cbprestamos.Checked = true;
                }
                if (permisologia.Contains("7,"))
                {
                    cbapertura.Checked = true;
                }
                if (permisologia.Contains("8,"))
                {
                    cbreportes.Checked = true;
                }

            }

        }


        #endregion

        private void btnrestablecer_Click(object sender, EventArgs e)
        {
            bool mostrarmensaje = true;

            string cedula = tbcedula.Text.Substring(0, 4);
            string clave = "psm" + cedula;

            string sql = "UPDATE usuarios SET clave = '"+ clave+ "', intento = '0' WHERE usuario='" + tbcedula.Text + "'";

            string mensaje = "La contraseña ha sido restablecida correctamente";
            BD.actualizar(sql, mensaje, mostrarmensaje, usuario, "USUARIO", tbcedula.Text,true, this);
            this.Close();

        }

        private void cbtipo_TextChanged(object sender, EventArgs e)
        {
            tbprimernombre.CharacterCasing = CharacterCasing.Upper;
            Tbsegundonombre.CharacterCasing = CharacterCasing.Upper;
            Tbprimerapellido.CharacterCasing = CharacterCasing.Upper;
            Tbsegundoapellido.CharacterCasing = CharacterCasing.Upper;
            Comprobartextbox();
        }

        private void tbcedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            generales.validarnumeros(e);
        }

        public string permisologia()
        {
            string editar = "";
            string registrar= "";
            string admin = "";
            string actas = "";
            string retrasos = "";
            string prestamos = "";
            string permisos;
            string apertura = "";
            string reportes = "";

            if (cbeditar.Checked==true)
            {
                editar = "1,";
            }
            if (cbregistrar.Checked == true)
            {
                registrar = "2,";
            }
            if (cbadmin.Checked == true)
            {
                admin = "3,";
            }
            if (cbactas.Checked == true)
            {
                actas = "4,";
            }
            if (cbretrasos.Checked == true)
            {
                retrasos = "5,";
            }
            if (cbprestamos.Checked == true)
            {
                prestamos = "6,";
            }
            if (cbprestamos.Checked == true)
            {
                apertura = "7,";
            }
            if (cbreportes.Checked == true)
            {
                reportes = "8,";
            }

            return permisos = editar + registrar + admin + actas + retrasos + prestamos + apertura + reportes;
        }

        private void cbactas_CheckedChanged(object sender, EventArgs e)
        {
            if (cbactas.Checked == true)
            {
                cbeditar.Checked = true;
            }
        }

        private void Tbcorreo_TextChanged(object sender, EventArgs e)
        {
            Tbcorreo.CharacterCasing = CharacterCasing.Upper;
        }

        private void cbadmin_CheckedChanged(object sender, EventArgs e)
        {
            int guia = 5;
            if (cbtipo.Items.Count == 4)
            {
                guia = 5 - 2;
            }

            if (cbadmin.Checked==true)
            {
                cbeditar.Checked = true;
                cbregistrar.Checked = true;
                cbactas.Checked = true;
                cbapertura.Checked = true;
                cbretrasos.Checked = true;
                cbprestamos.Checked = true;
                cbtipo.SelectedIndex = guia;
            }
            else
            {
                cbeditar.Checked = false;
                cbregistrar.Checked = false;
                cbactas.Checked = false;
                cbapertura.Checked = false;
                cbretrasos.Checked = false;
                cbprestamos.Checked = false;
            }

            
        }

        private void cbeditar_CheckedChanged(object sender, EventArgs e)
        {
            if (cbeditar.Checked==false)
            {
                cbactas.Checked = false;
            }
        }

        private void cbtipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            int guia = 0;
            if (cbtipo.Items.Count == 4)
            {
                guia = 2;
            }

            cbeditar.Checked = false;
            cbregistrar.Checked = false;
            cbactas.Checked = false;
            cbapertura.Checked = false;
            cbretrasos.Checked = false;
            cbprestamos.Checked = false;
            cbadmin.Checked = false;

            if (cbtipo.SelectedIndex==(0-guia) || cbtipo.SelectedIndex == (1-guia))
            {
                cbeditar.Enabled = false;
                cbregistrar.Enabled = false;
                cbactas.Enabled = false;
                cbapertura.Enabled = false;
                cbretrasos.Enabled = false;
                cbprestamos.Enabled = false;
                cbadmin.Enabled = false;
                cbreportes.Enabled = false;

            }
            if (cbtipo.SelectedIndex==(2 - guia) || cbtipo.SelectedIndex == (3-guia))
            {
                cbeditar.Enabled = true;
                cbregistrar.Enabled = true;
                cbactas.Enabled = true;
                cbapertura.Enabled = true;
                cbretrasos.Enabled = false;
                cbprestamos.Enabled = false;
                cbadmin.Enabled = true;
                cbreportes.Enabled = true;

            }
            if (cbtipo.SelectedIndex == (4-guia) || cbtipo.SelectedIndex == (5 - guia))
            {
                cbeditar.Enabled = true;
                cbregistrar.Enabled = true;
                cbactas.Enabled = true;
                cbapertura.Enabled = true;
                cbretrasos.Enabled = true;
                cbprestamos.Enabled = true;
                cbadmin.Enabled = true;
                cbreportes.Enabled = true;

            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        public void combobox()
        {
            string[] tipos = { "INVESTIGACIONES","SERVICIO COMUNITARIO","TECNOLOGIA EDUCATIVA","DEPARTAMENTOS MULTIPLES" };
            

            cbtipo.Items.Clear();
            cbtipo.Items.AddRange(tipos);
        }

        private void tbcodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            generales.validarnumeros(e);
        }

        private void Tbtelefono_TextChanged_1(object sender, EventArgs e)
        {
            Comprobartextbox();
        }
    }
}

