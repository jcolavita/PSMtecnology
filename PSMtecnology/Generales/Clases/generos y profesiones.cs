using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSMtecnology.Generales.Clases
{
    internal class generos_y_profesiones
    {
        Funciones_BD BD = new Funciones_BD();


        public void profesion()
        {
            BD.abrirconexion();

            try
            {
                SqlCommand comando2 = new SqlCommand(escuela, conexion);
                SqlDataReader lector2 = comando2.ExecuteReader();

                if (lector2.Read())
                {
                    cbescuela.Text = lector2["escuela"].ToString();
                    lector2.Close();
                    SqlCommand comando = new SqlCommand(consultaestudiante, conexion);
                    SqlDataReader lector = comando.ExecuteReader();
                }


    }
}
