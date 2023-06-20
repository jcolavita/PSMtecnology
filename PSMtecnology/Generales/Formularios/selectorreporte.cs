using PSMtecnology.Generales.reportes;
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

namespace TrabajoDeGrado.Generales
{
    public partial class selectorreporte : Form
    {
        Funciones_BD bd = new Funciones_BD();
        public string formulario;

        public selectorreporte()
        {
            InitializeComponent();
            bd.periodosql(cbperiodo);
        }

        private void btniniciar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnreporte_Click(object sender, EventArgs e)
        {

            switch (formulario)
            {
                case "trabajogrado":
                    frmreportetg reportetg = new frmreportetg();
                    reportetg.periodo = Int32.Parse(cbperiodo.SelectedValue.ToString());
                    reportetg.escuela = CBescuela.Text;
                    reportetg.Show();
                    break;
                case "proyectoinvestigacion":
                    frmreportepi frmreportepi= new frmreportepi();
                    frmreportepi.periodo= Int32.Parse(cbperiodo.SelectedValue.ToString());
                    frmreportepi.escuela = CBescuela.Text;
                    frmreportepi.estatus = cbestatus.Text;
                    frmreportepi.Show();
                    break;
                case "pasantias":
                    frmreportepasantias frmreportepasantias = new frmreportepasantias();
                    frmreportepasantias.periodo = Int32.Parse(cbperiodo.SelectedValue.ToString());
                    frmreportepasantias.escuela = CBescuela.Text;
                    frmreportepasantias.Show();
                    break;
                case "tria":
                    frmreportetria frmreportetria= new frmreportetria();
                    frmreportetria.periodo = Int32.Parse(cbperiodo.SelectedValue.ToString());
                    frmreportetria.escuela = CBescuela.Text;
                    frmreportetria.Show();
                    break;
            }
            this.Close();

        }

        private void CBescuela_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CBescuela.SelectedIndex==0)
            {
                cbperiodo.Enabled = true;
                bd.periodosql(cbperiodo);
                cbestatus.Enabled=true;
                bd.abrirconexion();
                string consulta = "SELECT DISTINCT estatus" +
                    " FROM " + formulario + "";

                    SqlDataAdapter adapter = new SqlDataAdapter(consulta, bd.conexion);
                    DataTable dt = new DataTable();

                    adapter.Fill(dt);

                    cbestatus.DataSource = dt;
                    cbestatus.DisplayMember = "estatus";
               
            }
            else
            {
                rellenarperiodo();

            }
        }

        private void rellenarperiodo()
        {
            bd.abrirconexion();
            string consulta = "SELECT DISTINCT fm.periodo, CONCAT(peri.año,'-',peri.semestre) AS PPERI, estu.escuela" +
                " FROM "+formulario+" fm INNER JOIN periodo peri ON peri.id = fm.periodo" +
                " INNER JOIN estudiantes estu ON fm.ciestudiante = estu.ciestudiante " +
                " WHERE estu.escuela LIKE '"+CBescuela.Text+"'";

            SqlCommand cmnd = new SqlCommand(consulta,bd.conexion);
            SqlDataReader lector1 = cmnd.ExecuteReader();

            if (lector1.Read())
            {
                cbestatus.Enabled = true;
                cbperiodo.Enabled = true;
                lector1.Close();
                SqlDataAdapter adapter = new SqlDataAdapter(consulta, bd.conexion);
                DataTable dt = new DataTable();

                adapter.Fill(dt);

                cbperiodo.DataSource = dt;

                cbperiodo.DisplayMember = "PPERI";
                cbperiodo.ValueMember = "fm.periodo";
                rellenarestatus();
                
            }
            else
            {
                cbestatus.Enabled = false;
                cbperiodo.Enabled = false;
                lector1.Close();
            }
        }
        private void rellenarestatus()
        {
            bd.abrirconexion();
            string consulta = "SELECT DISTINCT estu.escuela, fm.estatus" +
                " FROM " + formulario + " fm " +
                " INNER JOIN estudiantes estu ON fm.ciestudiante = estu.ciestudiante " +
                " WHERE estu.escuela LIKE '" + CBescuela.Text + "'";

            SqlCommand cmnd = new SqlCommand(consulta, bd.conexion);
            SqlDataReader lector1 = cmnd.ExecuteReader();

            if (lector1.Read())
            {
                cbestatus.Enabled = true;
                cbperiodo.Enabled = true;
                lector1.Close();
                SqlDataAdapter adapter = new SqlDataAdapter(consulta, bd.conexion);
                DataTable dt = new DataTable();

                adapter.Fill(dt);

                cbestatus.DataSource = dt;

                cbestatus.DisplayMember = "estatus";
            }
            else
            {
                cbestatus.Enabled = false;
                lector1.Close();
            }
        }


    }
}
