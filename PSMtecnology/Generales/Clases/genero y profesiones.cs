using DocumentFormat.OpenXml.Drawing;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrabajoDeGrado.Generales;

namespace PSMtecnology.Generales.Clases
{
    internal class genero_y_profesiones
    {
        Funciones_BD bd = new Funciones_BD();

        public string profesion(int cedula)
        {
            bd.abrirconexion();
            string abreviatura = "";

            try
            {
                SqlCommand comando = new SqlCommand("SELECT * FROM profesores WHERE ciprofesor = '" + cedula + "'", bd.conexion);
                SqlDataReader lector = comando.ExecuteReader();

                if (lector.Read())
                {
                    string sexo = lector["sexo"].ToString();
                    string profesion = lector["profesion"].ToString();

                    switch (profesion)
                    {
                        case "LICENCIADO/A":

                            if (sexo == "MASCULINO")
                            {
                                 abreviatura = "Lcdo.";
                            }
                            else
                            {
                                abreviatura = "Lcda.";
                            }
                            break;

                        case "PROFESOR/A":
                            abreviatura = "Prof.";
                            break;
                        case "INGENIERO":
                            abreviatura = "Ing.";
                            break;
                        case "ARQUITECTO":
                            abreviatura = "Arq.";
                            break;
                        case "ABOGADO":
                            abreviatura = "Abg.";
                            break;
                    }
                }
            }
            catch
            {

            }
            return abreviatura;
        } 

        public string mensionescuela(int cedula)
        {
           bd.abrirconexion();
           string mension = "";

            try
            {
                SqlCommand comando = new SqlCommand("SELECT * FROM estudiantes WHERE ciestudiante = '" + cedula + "'", bd.conexion);
                SqlDataReader lector = comando.ExecuteReader();

                if (lector.Read())
                {
                    string escuela = lector["escuela"].ToString();

                    switch (escuela)
                    {
                        case "ARQUITECTURA (41)":
                            mension = "Arquitecto";
                            break;
                        case "INGENIERÍA CIVIL (42)":
                            mension = "Ingeniero Civil";
                            break;
                        case "INGENIERÍA ELÉCTRICA (43)":
                            mension = "Ingeniero Electricista";
                            break;
                        case "INGENIERÍA ELECTRÓNICA (44)":
                            mension = "Ingeniero Electronico";
                            break;
                        case "INGENIERÍA INDUSTRIAL (45)":
                            mension = "Ingeniero Industrial";
                            break;
                        case "INGENIERÍA DE MTTO.MECÁNICO (46)":
                            mension = "Ingeniero en Mantenimiento Mecánico";
                            break;
                        case "INGENIERÍA DE SISTEMAS (47)":
                            mension = "Ingeniero de Sistemas";
                            break;
                    }
                }
            }
            catch{}
            return mension;
        }

        public string escuela(int cedula)
        {
            bd.abrirconexion();
            string devuelta = "";

            try
            {
                SqlCommand comando = new SqlCommand("SELECT * FROM estudiantes WHERE ciestudiante = '" + cedula + "'", bd.conexion);
                SqlDataReader lector = comando.ExecuteReader();

                if (lector.Read())
                {
                    string escuela = lector["escuela"].ToString();

                    switch (escuela)
                    {
                        case "ARQUITECTURA (41)":
                            devuelta = "Arquitectura";
                            break;
                        case "INGENIERÍA CIVIL (42)":
                            devuelta = "Ingeniería Civil";
                            break;
                        case "INGENIERÍA ELÉCTRICA (43)":
                            devuelta = "Ingeniería Eléctrica";
                            break;
                        case "INGENIERÍA ELECTRÓNICA (44)":
                            devuelta = "Ingeniería Electrónica";
                            break;
                        case "INGENIERÍA INDUSTRIAL (45)":
                            devuelta = "Ingeniería Industrial";
                            break;
                        case "INGENIERÍA DE MTTO.MECÁNICO (46)":
                            devuelta = "Ingeniería de Mantenimiento Mecánico";
                            break;
                        case "INGENIERÍA DE SISTEMAS (47)":
                            devuelta = "Ingeniería de Sistemas";
                            break;
                    }
                }
            }
            catch { }
            return devuelta;
        }

        public string ciudadano(int cedula)
        {
            string resultado = "";
            bd.abrirconexion();

            try
            {
                SqlCommand comando = new SqlCommand("SELECT * FROM estudiantes WHERE ciestudiante = '" + cedula + "'", bd.conexion);
                SqlDataReader lector = comando.ExecuteReader();

                if (lector.Read())
                {
                    string escuela = lector["sexo"].ToString();

                    switch (escuela)
                    {
                        case "MASCULINO":
                            resultado= "el ciudadano";
                            break;
                        case "FEMENINO":
                            resultado = "la ciudadana";
                            break;

                    }
                }
            }
            catch { }

            return resultado;
        }



    }
}
