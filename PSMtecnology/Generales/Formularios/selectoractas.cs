using DocumentFormat.OpenXml.Office2010.Excel;
using GroupDocs.Merger;
using PSMtecnology.Generales.Clases;
using PSMtecnology.Generales.reportes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrabajoDeGrado.Modulos;

namespace TrabajoDeGrado.Generales
{
    public partial class selectoractas : Form
    {
        Funciones_BD BD = new Funciones_BD();
        public string formulario;
        Funciones_Generales comun = new Funciones_Generales();
        genero_y_profesiones genprof = new genero_y_profesiones();
        public string tabla = "";


        public selectoractas()
        {
            InitializeComponent();
            BD.periodosql(cbperiodo);
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
            BD.abrirconexion();
            saveFileDialog1.Filter = "Word |*.docx";
            string ARCHIVO = "";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                ARCHIVO = saveFileDialog1.FileName;
            }
            string sql = "SELECT T.ciestudiante, T.id FROM " + tabla + " T INNER JOIN estudiantes est " +
                "ON T.ciestudiante = est.ciestudiante WHERE periodo = '" + cbperiodo.SelectedValue + "' AND est.escuela like '" + CBescuela.Text + "'";
            SqlCommand comando = new SqlCommand(sql, BD.conexion);
            SqlDataReader lector = comando.ExecuteReader();
            List<string> lista = new List<string>();
            List<string> listaid = new List<string>();



            while (lector.Read())
            {
                lista.Add(lector["ciestudiante"].ToString());
                listaid.Add(lector["id"].ToString());

            }
            lector.Close();


            if (tabla == "trabajogrado")
            {

                for (int i = 0; i < lista.Count; i++)
                {

                    

                    SqlCommand cmndperiodo = new SqlCommand("SELECT año FROM periodo WHERE id ='" + cbperiodo.SelectedValue + "'", BD.conexion);
                    SqlCommand cmndcorrelativo = new SqlCommand("SELECT row2 FROM(SELECT id, ROW_NUMBER() OVER(PARTITION BY tg.periodo ORDER BY CONCAT(us.primernombre, us.segundonombre, us.primerapellido, us.segundoapellido))AS row," +
                        "ROW_NUMBER() OVER(PARTITION BY est.escuela ORDER BY CONCAT(us.primernombre, us.segundonombre, us.primerapellido, us.segundoapellido))AS row2 " +
                        "FROM trabajogrado tg " +
                        "INNER JOIN usuarios us ON tg.ciestudiante = us.usuario " +
                        "INNER JOIN estudiantes est ON us.usuario = est.ciestudiante) trabajogrado WHERE id = '" + listaid[i] + "'", BD.conexion);

                    int correlativo = Int32.Parse(cmndcorrelativo.ExecuteScalar().ToString());
                    string codificacionperiodo = cmndperiodo.ExecuteScalar().ToString();
                    string sin20 = codificacionperiodo.Replace("20", "");

                    int codificacion = (Int32.Parse(sin20) * 1000) + correlativo;












                    string sqltabla = "select tg.titulo,tg.cijurado1,tg.cijurado2,tg.cijurado3,tg.citutor,tg.fechadefensa,tg.ciestudiante,est.escuela," +
                        "concat(us.primernombre, ' ', us.segundonombre, ' ', us.primerapellido, ' ', us.segundoapellido)AS NOMBRE, " +
                        "(SELECT CONCAT(primernombre, ' ', segundonombre, ' ', primerapellido, ' ', segundoapellido) FROM usuarios U where usuario = tg.cijurado1) AS JURADO1, " +
                        "(SELECT CONCAT(primernombre, ' ', segundonombre, ' ', primerapellido, ' ', segundoapellido) FROM usuarios U where usuario = tg.cijurado2) AS JURADO2, " +
                        "(SELECT CONCAT(primernombre, ' ', segundonombre, ' ', primerapellido, ' ', segundoapellido) FROM usuarios U where usuario = tg.cijurado3) AS JURADO3, " +
                        "(SELECT CONCAT(primernombre, ' ', segundonombre, ' ', primerapellido, ' ', segundoapellido) FROM usuarios U where usuario = tg.citutor) AS tutor " +
                        "FROM trabajogrado tg " +
                        "INNER JOIN estudiantes est ON tg.ciestudiante = est.ciestudiante " +
                        "INNER JOIN usuarios us ON est.ciestudiante = us.usuario " +
                        "where tg.ciestudiante = '" + lista[i] + "'";

                    







                    SqlCommand comando2 = new SqlCommand(sqltabla, BD.conexion);
                    SqlDataReader lector2 = comando2.ExecuteReader();

                    string rutatemp = System.Windows.Forms.Application.StartupPath + @"\temp\temp-" + lista[i] + "";

                    File.Copy(System.Windows.Forms.Application.StartupPath + @"\templates\TG - ACTA (TEMPLATE).docx", System.Windows.Forms.Application.StartupPath + @"\temp\temp-teporal.docx", true);
                    string ruta = System.Windows.Forms.Application.StartupPath + @"\temp\temp-teporal.docx";

                    if (lector2.Read())
                    {
                        string codificacionescuela = "";
                        if (lector2["escuela"].ToString().Contains("41"))
                        {
                            codificacionescuela = "41";
                        }
                        if (lector2["escuela"].ToString().Contains("42"))
                        {
                            codificacionescuela = "42";
                        }
                        if (lector2["escuela"].ToString().Contains("43"))
                        {
                            codificacionescuela = "43";
                        }
                        if (lector2["escuela"].ToString().Contains("44"))
                        {
                            codificacionescuela = "44";
                        }
                        if (lector2["escuela"].ToString().Contains("45"))
                        {
                            codificacionescuela = "45";
                        }
                        if (lector2["escuela"].ToString().Contains("46"))
                        {
                            codificacionescuela = "46";
                        }
                        if (lector2["escuela"].ToString().Contains("47"))
                        {
                            codificacionescuela = "47";
                        }






                        comun.funcion(ruta, "(correlativo)", codificacionescuela + codificacion.ToString(), rutatemp);
                        comun.funcion(ruta, "(dia)", DateTime.Today.Day.ToString(), rutatemp);
                        comun.funcion(ruta, "(mes)", DateTime.Today.Month.ToString(), rutatemp);
                        comun.funcion(ruta, "(año)", DateTime.Today.Year.ToString(), rutatemp);
                        comun.funcion(ruta, "(nombrejurado1)", genprof.profesion(Int32.Parse(lector2["cijurado1"].ToString())) + " " + comun.cambia(lector2["JURADO1"].ToString()), rutatemp);
                        comun.funcion(ruta, "(cijurado1)", lector2["cijurado1"].ToString(), rutatemp);
                        comun.funcion(ruta, "(nombrejurado2)", genprof.profesion(Int32.Parse(lector2["cijurado2"].ToString())) + " " + comun.cambia(lector2["JURADO2"].ToString()), rutatemp);
                        comun.funcion(ruta, "(cijurado2)", lector2["cijurado2"].ToString(), rutatemp);
                        comun.funcion(ruta, "(nombrejurado3)", genprof.profesion(Int32.Parse(lector2["cijurado3"].ToString())) + " " + comun.cambia(lector2["JURADO3"].ToString()), rutatemp);
                        comun.funcion(ruta, "(cijurado3)", lector2["cijurado3"].ToString(), rutatemp);
                        comun.funcion(ruta, "(titulo)", comun.cambia(lector2["titulo"].ToString()), rutatemp);
                        comun.funcion(ruta, "(ciudadano)", genprof.ciudadano(Int32.Parse(lector2["ciestudiante"].ToString())), rutatemp);
                        comun.funcion(ruta, "(estudiante)", comun.cambia(lector2["NOMBRE"].ToString()), rutatemp);
                        comun.funcion(ruta, "(cedula)", lista[i], rutatemp);
                        comun.funcion(ruta, "(carrera)", comun.cambia(genprof.escuela(Int32.Parse(lista[i]))), rutatemp);
                        comun.funcion(ruta, "(periodo)", cbperiodo.Text, rutatemp);
                        comun.funcion(ruta, "(nombretutor)", genprof.profesion(Int32.Parse(lector2["citutor"].ToString())) + " " + comun.cambia(lector2["tutor"].ToString()), rutatemp);
                        comun.funcion(ruta, "(citutor)", lector2["cijurado2"].ToString(), rutatemp);
                        lector2.Close();
                    }
                }

            }




            Merger merger = new Merger(System.Windows.Forms.Application.StartupPath + @"\temp\temp-" + lista[0] + ".docx");

            for (int i = 1; i < lista.Count; i++)
            {
                merger.Join(System.Windows.Forms.Application.StartupPath + @"\temp\temp-" + lista[i] + ".docx");

            }
            merger.Save(ARCHIVO);

            foreach (Process p in System.Diagnostics.Process.GetProcessesByName("WINWORD"))
            {
                try
                {
                    p.Kill();
                    p.WaitForExit();
                }
                catch { }
            }
            
            Process proceso = new Process();
            proceso.StartInfo.FileName = ARCHIVO;
            proceso.Start();
            this.Close();

        }
    

        private void CBescuela_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnreporte.Enabled = true;   
        }
    }
}
