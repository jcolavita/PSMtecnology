using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrabajoDeGrado.Generales;
using TrabajoDeGrado.Modulos;

namespace TrabajoDeGrado.Secciones.Academico.Pasantias
{
    public partial class solvencias : Form
    {
        Funciones_BD BD = new Funciones_BD();

        public solvencias()
        {
            InitializeComponent();
        }

        public void consultar()
        {
            BD.abrirconexion();
            SqlCommand cmndsc = new SqlCommand("SELECT rustica FROM servcomunitario WHERE ciestudiantes LIKE '%" + tbcedula.Text + "%' AND rustica IS NOT NULL", BD.conexion);
            SqlCommand cmndp = new SqlCommand("SELECT rustica FROM pasantias WHERE ciestudiante = '" + tbcedula.Text + "' AND rustica IS NOT NULL", BD.conexion);
            SqlCommand cmndpi = new SqlCommand("SELECT rustica FROM proyectoinvestigacion WHERE ciestudiante = '" + tbcedula.Text + "' AND rustica IS NOT NULL", BD.conexion);
            SqlCommand cmndtg = new SqlCommand("SELECT rustica FROM trabajogrado WHERE ciestudiante = '" + tbcedula.Text + "' AND rustica IS NOT NULL", BD.conexion);

            SqlDataReader lectorsc = cmndsc.ExecuteReader();
            if (lectorsc.Read())
            {
                estatussc.Text = "ENTREGADO";
                lectorsc.Close();
            }
            lectorsc.Close();

            SqlDataReader lectorp = cmndp.ExecuteReader();
            if (lectorp.Read())
            {
                estatusp.Text = "ENTREGADO";
                lectorp.Close();
            }
            lectorp.Close();

            SqlDataReader lectorpi = cmndpi.ExecuteReader();
            if (lectorpi.Read())
            {
                estatuspi.Text = "ENTREGADO";
                lectorpi.Close();
            }
            lectorpi.Close();

            SqlDataReader lectortg = cmndtg.ExecuteReader();
            if (lectortg.Read())
            {
                estatustg.Text = "ENTREGADO";
                lectortg.Close();
            }
            lectortg.Close();


        }

        private void Btncerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
