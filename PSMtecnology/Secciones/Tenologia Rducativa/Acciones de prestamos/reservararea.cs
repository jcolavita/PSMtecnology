using Microsoft.VisualBasic;
using System;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;
using TrabajoDeGrado.Generales;
using TrabajoDeGrado.Modulos;

namespace TrabajoDeGrado.Secciones.Estudiantes_y_Profesores.Estudiantes
{
    public partial class reservararea : Form
    {
        Funciones_Generales generales = new Funciones_Generales();
        Funciones_BD BD = new Funciones_BD();

        public string usuario;
        public reservararea() { InitializeComponent();  }


        #region BOTONES
        private void Btnagregar_Click_1(object sender, EventArgs e)
        {
            if (btnreservar.Text=="Actualizar")
            {
               string sql= "UPDATE alquilerarea  SET horainicio ='" + dthorainicio.Value+ "', horafinalizacion='" + dthorafinal.Value + "'," +
                             " requerimientos ='" + requerimientos() + "',catedras ='" + tbcatedras.Text+ "', " +
                             "secciones='" + tbsecciones.Text+ "', proposito ='" + tbproposito.Text+ "', " +
                             "escuela='" + Cbescuela.Text + "'" +
                             "  WHERE ID='" + id.Text + "'";

                string mensaje = "Los datos de la reservacion han sido modificados.";


                BD.actualizar(sql, mensaje, true, usuario, "RESERVACION DE AREA", id.Text, true, this);

                areapersonal frm1 = (areapersonal)Application.OpenForms["areapersonal"];
                if (Application.OpenForms.OfType<areapersonal>().Any())
                {
                    frm1.cbtipo.SelectedIndex=-1;
                }

                alquilerarea frm = (alquilerarea)Application.OpenForms["alquilerarea"];
                if (Application.OpenForms.OfType<alquilerarea>().Any())
                {
                    frm.rellenargrid("SELECT area.id AS ID, area.horainicio AS DIA, area.catedras AS CATEDRAS, area.secciones AS SECCIONES, " +
                " area.proposito AS PROPOSITO, area.fechasolicitud AS SOLICITUD, area.escuela AS ESCUELA, CONCAT(prof.primernombre,' ', prof.segundonombre) AS DOCENTE " +
                " FROM alquilerarea area INNER JOIN usuarios prof ON area.cedulaprofesor = prof.usuario ORDER BY ID DESC ");
                }

            }
            else
            {
                string sql = "INSERT INTO alquilerarea (horainicio, horafinalizacion, requerimientos, catedras," +
                                    "secciones,proposito, fechasolicitud, escuela, cedulaprofesor) values " +
                                            " ('" + System.Convert.ToString(dthorainicio.Value) + "'," +
                                            " '" + System.Convert.ToString(dthorafinal.Value) + "'," +
                                            " '" + System.Convert.ToString(requerimientos()) + "'," +
                                            " '" + System.Convert.ToString(tbcatedras.Text) + "'," +
                                            " '" + System.Convert.ToString(tbsecciones.Text) + "'," +
                                            " '" + System.Convert.ToString(tbproposito.Text) + "'," +
                                            " '" + System.Convert.ToString(DateTime.Now) + "'," +
                                            " '" + System.Convert.ToString(Cbescuela.Text) + "'," +
                                            " '" + System.Convert.ToString(tbusuario.Text) + "')"; 


                BD.agregar(sql, "La reservacion se ha realizado correctamente", true,  tbusuario.Text, "AREA",  "RESERVACION", tbusuario.Text, true, this);


                alquilerarea frm = (alquilerarea)Application.OpenForms["alquilerarea"];
                if (Application.OpenForms.OfType<alquilerarea>().Any())
                {
                    frm.rellenargrid("SELECT area.id AS ID, area.horainicio AS DIA, area.catedras AS CATEDRAS, area.secciones AS SECCIONES, " +
                " area.proposito AS PROPOSITO, area.fechasolicitud AS SOLICITUD, area.escuela AS ESCUELA, CONCAT(prof.primernombre,' ', prof.segundonombre) AS DOCENTE " +
                " FROM alquilerarea area INNER JOIN usuarios prof ON area.cedulaprofesor = prof.usuario ORDER BY ID DESC ");
                }
            }
                

        }

        private void Btncerrar_Click(object sender, EventArgs e) { this.Close(); }
        #endregion


        #region FUNCION DE MODIFICACION

        public void docente()
        {
            string sql = "SELECT * FROM usuarios WHERE usuario = '"+tbusuario.Text+"'";

            BD.abrirconexion();
            SqlCommand comando = new SqlCommand(sql, BD.conexion);
            SqlDataReader lector;
            lector = comando.ExecuteReader();
            if (lector.Read())
            {
                tbnombre.Text = lector["primernombre"].ToString()+" "+lector["primerapellido"].ToString() ;
            }


        }


        public string requerimientos()
        {
            string proyector ="", computador = "", microfono = "", sonido = "", difusion = "", requerimientos = "";

            if (cbproyector.Checked==true)
            {
                proyector = "1;";
            }
            if (cbproyector.Checked == true)
            {
                computador = "2;";
            }
            if (cbmicrofono.Checked == true)
            {
                microfono = "3;";
            }
            if (cbsonido.Checked == true)
            {
                sonido = "4;";
            }
            if (cbdifusion.Checked == true)
            {
                difusion = "5;";
            }
            return requerimientos = proyector + computador + microfono + sonido + difusion + requerimientos;
        }


        #endregion

        private void dtfecha_ValueChanged(object sender, EventArgs e)
        {
            dthorainicio.Value = dtfecha.Value.Date;
            dthorainicio.Enabled = true;
            dthorafinal.Value = dtfecha.Value.Date;
            dthorafinal.Enabled = true;
        }

        public void autorrelleno()
        {
            string sql = "SELECT * FROM alquilerarea WHERE id = '" + id.Text + "'";
            string requerimientos;

            BD.abrirconexion();
            SqlCommand comando = new SqlCommand(sql, BD.conexion);
            SqlDataReader lector;
            lector = comando.ExecuteReader();
            if (lector.Read())
            {
                dthorainicio.Text = lector["horainicio"].ToString();
                dthorafinal.Text = lector["horafinalizacion"].ToString();
                requerimientos = lector["requerimientos"].ToString();
                tbcatedras.Text = lector["catedras"].ToString();
                tbsecciones.Text = lector["secciones"].ToString();
                tbproposito.Text = lector["proposito"].ToString();
                Cbescuela.Text = lector["escuela"].ToString();
                tbusuario.Text = lector["cedulaprofesor"].ToString();

                docente();
                rellenarCB(requerimientos);
                lector.Close();
            }
        }


        public void rellenarCB(string requerimientos)
        {
            if (requerimientos.Contains("1;"))
            {
                cbproyector.Checked = true;
            }
            if (requerimientos.Contains("2;"))
            {
                cbpc.Checked = true;
            }
            if (requerimientos.Contains("3;"))
            {
                cbmicrofono.Checked = true;
            }
            if (requerimientos.Contains("4;"))
            {
                cbsonido.Checked = true;
            }
            if (requerimientos.Contains("5;"))
            {
                cbdifusion.Checked = true;
            }

        }

        private void btnfinalizar_Click(object sender, EventArgs e)
        {
            string sql = "DELETE FROM alquilerarea WHERE id='" + id.Text + "'";

            BD.eliminar(sql, false, "", this);
            mensajeinformacion informacion = new mensajeinformacion();
            informacion.Show();
            informacion.lblalerta.Text = "La reservacion ha sido cerrada.";

            areapersonal frm1 = (areapersonal)Application.OpenForms["areapersonal"];
            if (Application.OpenForms.OfType<areapersonal>().Any())
            {
                frm1.cbtipo.SelectedIndex = -1;
            }

            alquilerarea frm = (alquilerarea)Application.OpenForms["alquilerarea"];
            if (Application.OpenForms.OfType<alquilerarea>().Any())
            {
                frm.rellenargrid("SELECT area.id AS ID, area.horainicio AS DIA, area.catedras AS CATEDRAS, area.secciones AS SECCIONES, " +
            " area.proposito AS PROPOSITO, area.fechasolicitud AS SOLICITUD, area.escuela AS ESCUELA, CONCAT(prof.primernombre,' ', prof.segundonombre) AS DOCENTE " +
            " FROM alquilerarea area INNER JOIN usuarios prof ON area.cedulaprofesor = prof.usuario ORDER BY ID DESC ");
            }

            this.Close();
        }

        private void cbsonido_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void tbproposito_TextChanged(object sender, EventArgs e)
        {
            tbsecciones.CharacterCasing = CharacterCasing.Upper;
            tbcatedras.CharacterCasing = CharacterCasing.Upper;
            tbproposito.Text = tbproposito.Text.ToUpper();
            tbproposito.Select(tbproposito.Text.Length, 0);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblfechaactual_Click(object sender, EventArgs e)
        {

        }

        private void dthorafinal_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}

