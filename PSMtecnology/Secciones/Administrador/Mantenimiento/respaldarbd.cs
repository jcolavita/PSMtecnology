using Microsoft.VisualBasic;
using System;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Net.Http.Headers;
using System.Windows.Forms;
using System.Windows.Forms.Design;
using TrabajoDeGrado.Generales;
using TrabajoDeGrado.Modulos;

namespace TrabajoDeGrado.Secciones.Estudiantes_y_Profesores.Estudiantes
{
    public partial class respaldarbd : Form
    {
        Funciones_Generales generales = new Funciones_Generales();
        Funciones_BD BD = new Funciones_BD();
        OpenFileDialog ruta = new OpenFileDialog();
        mensajeinformacion informacion = new mensajeinformacion();
        public respaldarbd() { InitializeComponent(); }

        public void comprobartbrespaldo()
        {
            var vr = !string.IsNullOrEmpty(tbruta.Text);
            btnrespaldar.Enabled = vr;  
        }

        public void comprobartbrestauracion()
        {
            var vr = !string.IsNullOrEmpty(tbrutarestauracion.Text);
            btnrestaurar.Enabled = vr;
        }

        private void Btnagregar_Click_1(object sender, EventArgs e)
        {
            BD.abrirconexion();
            mensajecorrecto emergente = new mensajecorrecto();
                        
            String sql = "BACKUP DATABASE [PSMsistem] TO  DISK = N'"+tbruta.Text+ "' WITH NOFORMAT, NOINIT," +
                         "  NAME = N'PSMsistem-Completa Base de datos Copia de seguridad', SKIP, NOREWIND, NOUNLOAD,  STATS = 10";
            SqlCommand comando = new SqlCommand(sql, BD.conexion);
            try
            {
                comando.ExecuteNonQuery();
                emergente.Show();
                emergente.lblalerta.Text = "El respaldo de la base de datos se ha generado correctamente";

                this.Close();
                BD.conexion.Close();

            }
            catch (Exception)
            {
                informacion.Show();
                informacion.lblalerta.Text = "Error al crear el respaldo de la bse de daatos, verifique la ruta seleccionada.";
                this.Close();
                BD.conexion.Close();
            }
        }

        private void Btncerrar_Click(object sender, EventArgs e) { this.Close(); }

        private void button1_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "SQL Backup files |*.bak";
            saveFileDialog1.FileName= "PSMsistem-"+DateTime.Today.Day+"-" +DateTime.Today.Month+"-"
                +DateTime.Today.Year+"-"+DateTime.Now.Hour+"HH-"+DateTime.Now.Minute+"MM-"+DateTime.Now.Second+"SS .bak";

            if (saveFileDialog1.ShowDialog()==  DialogResult.OK)
            {
                tbruta.Text=saveFileDialog1.FileName;
                tbrutarestauracion.Text = "";

            }

        }

        private void tbrestaurar_Click(object sender, EventArgs e)
        {

            BD.abrirconexion();
            mensajecorrecto emergente = new mensajecorrecto();

            String sql = "ALTER DATABASE [PSMsistem] SET SINGLE_USER WITH ROLLBACK IMMEDIATE;" +
                        " USE master;" +
                        " RESTORE DATABASE [PSMsistem] FROM DISK = '" + tbrutarestauracion.Text + "' WITH REPLACE;" +
                        " ALTER DATABASE PSMsistem SET MULTI_USER;";

            SqlCommand comando = new SqlCommand(sql, BD.conexion);
            try
            {
                comando.ExecuteNonQuery();
                emergente.Show();
                emergente.lblalerta.Text = "La base de datos se ha restaurado correctamente.";

                this.Close();
                BD.conexion.Close();

            }
            catch (Exception)
            {
                informacion.Show();
                informacion.lblalerta.Text = "Error al recuperar la base de datos, verifique la ruta seleccionada.";

                this.Close();
                BD.conexion.Close();
            }
        }

        private void TBRUTA_TextChanged(object sender, EventArgs e)
        {
            comprobartbrespaldo();
        }

        private void btnruta2_Click(object sender, EventArgs e)
        {
            
            saveFileDialog1.Filter = "SQL Backup files |*.bak";
            
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                tbruta.Text = "";
                tbrutarestauracion.Text = saveFileDialog1.FileName;
            }
        }

        private void tbrutarestauracion_TextChanged(object sender, EventArgs e)
        {
            comprobartbrestauracion();
        }
    }
}

