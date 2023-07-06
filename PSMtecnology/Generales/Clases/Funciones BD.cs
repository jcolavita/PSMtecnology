using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Services.Description;
using System.Windows.Forms;
using TrabajoDeGrado.Modulos;
using TrabajoDeGrado.Secciones.Academico.Pasantias;
using TrabajoDeGrado.Secciones.Estudiantes_y_Profesores;
using TrabajoDeGrado.Secciones.Login;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Button = System.Windows.Forms.Button;
using ComboBox = System.Windows.Forms.ComboBox;
using TextBox = System.Windows.Forms.TextBox;

namespace TrabajoDeGrado.Generales
{
    internal class Funciones_BD // Script para almacenar funciones relacionadas a la base de datos
    {
        public SqlConnection conexion = new SqlConnection();
        private byte[] rustica;
        private string resumen;
        mensajecorrecto emergente = new mensajecorrecto();
        mensajeinformacion informacion = new mensajeinformacion();
        

        public byte[] Rustica { get => rustica; set => rustica = value; }
        public string Resumen { get => resumen; set => resumen = value; }


        public void abrirconexion()//abre la conexion, llamado siempre al inicio de cada proceso relacionado a la base de datos,
                                   //importante cerrar la conexion al finalizar la funcion
        {
            conexion = new SqlConnection("server=(local);database=PSMsistem;integrated security=true");
            conexion.Open();
        } 

        public void eliminar(string sql, bool confirmacion, string mensaje, Form formulario) //elimina un registro, unicamente utilizado en el procedimiento de aceptar prestamos
                                         //para pasar de la tabla pendientes a prestamos
        {
            abrirconexion();
            SqlCommand command = new SqlCommand(sql, conexion);

            try
            {
                command.ExecuteNonQuery();
                if (confirmacion == true)
                {
                    emergente.Show();
                    emergente.lblalerta.Text = mensaje;
                    emergente.formulario = formulario;
                }
                conexion.Close();
            }

            catch (Exception)
            {
                MessageBox.Show("Error al eliminar el registro");
                conexion.Close();
            }
        }

        public void agregar(string sql, string mensaje,bool confirmacion, string usuario,string tabla, string accion,string idafectado, bool auditar, Form formulario) //crea un registro nuevo en la base de datos 
        {
            abrirconexion();

            SqlCommand command = new SqlCommand(sql, conexion);
            
            string sqlauditoria = "INSERT INTO auditoria (usuario, fecha, accion, tablaafectada, idafectado) values " +
                " ('" + System.Convert.ToString(usuario) + "'," +
                " '" + System.Convert.ToString(DateTime.Today.Date) + "'," +
                " '" + System.Convert.ToString(accion) + "'," +
                " '" + System.Convert.ToString(tabla) + "'," +
                " '" + System.Convert.ToString(idafectado) + "')";

            SqlCommand command2 = new SqlCommand(sqlauditoria, conexion);

            //try
            //{
                command.ExecuteNonQuery();

                if (confirmacion == true)
                {
                    emergente.Show();
                    emergente.lblalerta.Text = mensaje;
                    emergente.formulario = formulario;
                }

                paneldeformularios panel = (paneldeformularios)Application.OpenForms["paneldeformularios"];
                if (Application.OpenForms.OfType<paneldeformularios>().Any())
                {
                    panel.Close();
                }


                command2.ExecuteNonQuery();

                conexion.Close();
            //}
            //catch (Exception)
            //{
            //    informacion.Show();
            //    informacion.lblalerta.Text = "La cedula ya se encuentra registrada";
            //    conexion.Close();
            //}
        }

        public void actualizar(string sql, string mensaje, bool actestudiante,string usuario,string tabla,string idafectado,bool auditar, Form formulario) //actualiza un registro existente
        {
            abrirconexion();
            SqlCommand command = new SqlCommand(sql, conexion);
            string auditoria= "INSERT INTO auditoria (usuario, fecha, accion, tablaafectada, idafectado) values " +
                " ('" + System.Convert.ToString(usuario) + "'," +
                " '" + System.Convert.ToString(DateTime.Today.Date) + "'," +
                " '" + System.Convert.ToString("MODIFICACION") + "'," +
                " '" + System.Convert.ToString(tabla) + "'," +
                " '" + System.Convert.ToString(idafectado) + "')"; 

            SqlCommand command2 = new SqlCommand(auditoria, conexion);


            try
            {
                command.ExecuteNonQuery();
                if (actestudiante == true)
                {
                    emergente.Show();
                    emergente.lblalerta.Text = mensaje;
                    emergente.formulario = formulario;
                }


                if (auditar==true)
                {
                    command2.ExecuteNonQuery();

                }

                conexion.Close();

            }

            catch (Exception)
            {
                MessageBox.Show("Error al registrar");
                conexion.Close();
            }
        }

        public void agregardocumento(string tabla, string id) //utilizado para cargar documentos en la base de datos
        {
            abrirconexion();
            SqlCommand comando = new SqlCommand("UPDATE " + tabla + " SET rustica = @rustica, resumen= @resumen WHERE ID='" + id + "'", conexion);
            comando.CommandType = CommandType.Text;
            comando.Parameters.AddWithValue("@rustica", Rustica);
            comando.Parameters.AddWithValue("@resumen", Resumen);

            try
            {
                comando.ExecuteNonQuery();
                emergente.Show();
                emergente.lblalerta.Text = "Rustica agregada correctamente";
                conexion.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Error al registrar");
                conexion.Close();
            }

        }


        ///////////////////////////////////// SEGMENTO CON FUNCIONES DE AUTO RELLENO///////////////////////////////////////////////////////////

        public void comboconsql(ComboBox a, ComboBox b, ComboBox c, ComboBox d) //Rellena combobox con datos de la tabla de profesores
        {
            abrirconexion();
            string consulta = "SELECT prof.ciprofesor, CONCAT(users.primernombre, ' ', users.primerapellido) as combinacion " +
                "FROM profesores prof INNER JOIN usuarios users ON prof.ciprofesor = users.usuario";
            SqlDataAdapter adapter = new SqlDataAdapter(consulta, conexion);
            DataTable dt = new DataTable();
            DataTable dt1 = new DataTable();
            DataTable dt2 = new DataTable();
            DataTable dt3 = new DataTable();

            adapter.Fill(dt);
            adapter.Fill(dt1);
            adapter.Fill(dt2);
            adapter.Fill(dt3);

            a.DataSource = dt;
            b.DataSource = dt1;
            c.DataSource = dt2;
            d.DataSource = dt3;

            a.DisplayMember = "combinacion";
            a.ValueMember = "ciprofesor";
            b.DisplayMember = "combinacion";
            b.ValueMember = "ciprofesor";
            c.DisplayMember = "combinacion";
            c.ValueMember = "ciprofesor";
            d.DisplayMember = "combinacion";
            d.ValueMember = "ciprofesor";
        }
        public void periodosql(ComboBox a) //Rellena combobox con datos de los periodos
        {
            abrirconexion();
            string consulta = "SELECT id, CONCAT(año, '-', semestre) as periodo FROM periodo ORDER BY año DESC";
            SqlDataAdapter adapter = new SqlDataAdapter(consulta, conexion);
            DataTable dt = new DataTable();

            adapter.Fill(dt);

            a.DataSource = dt;

            a.DisplayMember = "periodo";
            a.ValueMember = "id";

        }

        public void accion(ComboBox a) //Rellena combobox con datos de los periodos
        {
            abrirconexion();
            string consulta = "SELECT DISTINCT accion FROM auditoria";
            SqlDataAdapter adapter = new SqlDataAdapter(consulta, conexion);
            DataTable dt = new DataTable();

            adapter.Fill(dt);

            a.DataSource = dt;

            a.DisplayMember = "accion";

        }

        public void usuarios(ComboBox  b)
        {
            abrirconexion();
            string consulta = "SELECT DISTINCT au.usuario AS id, CONCAT(au.usuario, '-', users.primernombre,' ',users.segundoapellido)AS USUARIO " +
                " FROM auditoria au INNER JOIN usuarios users ON au.usuario=users.usuario";
            SqlDataAdapter adapter = new SqlDataAdapter(consulta, conexion);
            DataTable dt = new DataTable();

            adapter.Fill(dt);

            b.DataSource = dt;

            b.DisplayMember = "USUARIO";
            b.ValueMember = "id";

        }


        public void materias(ComboBox b)
        {
            abrirconexion();
            string consulta = "SELECT DISTINCT Materia FROM INVENTARIO$";
            SqlDataAdapter adapter = new SqlDataAdapter(consulta, conexion);
            DataTable dt = new DataTable();

            adapter.Fill(dt);

            b.DataSource = dt;

            b.DisplayMember = "Materia";
        }





        public void rellenarestudiante(TextBox tbcedula, string consultaestudiante, TextBox primernombre, TextBox segundonombre,
                                        TextBox primerapellido, TextBox segundoapellido, Panel panel, 
                                        Button buscar, Button limpiar, TextBox cedula, ComboBox cbescuela,
                                        string escuela, ComboBox intento)
        //Obtiene la informacion del estudiante y la plasma en la pantalla de registro de cualquier procedimiento academico
        {
            abrirconexion();

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

                    if (lector.Read())
                    {
                        primerapellido.Text = lector["primerapellido"].ToString();
                        segundoapellido.Text = lector["segundoapellido"].ToString();
                        primernombre.Text = lector["primernombre"].ToString();
                        segundonombre.Text = lector["segundonombre"].ToString();

                        lector.Close();
                    }

                    panel.Enabled = true;
                    buscar.Enabled = false;
                    cedula.Enabled = false;
                    intento.SelectedIndex = 0;
                    limpiar.Enabled = true;
                   
                }
                else
                {

                    informacion.Show();
                    informacion.lblalerta.Text = "El estudiante no se encuentra registrado, por favor verifica la cedula ingresada.";
                    lector2.Close();
                    return;
                    panel.Enabled = false;
                }

            }

            catch (Exception) { throw; }
        }

        public void periodoproyectoyservicio(Label proyecto, Label servicio, TextBox cedula, CheckBox cbservicio, CheckBox cbproyecto,RichTextBox titulo)
            //Obtiene los periodos de servicio comunitario y prouecto de investigacion del estudiante para plasmarlo en el registro

        {

            abrirconexion();
            SqlCommand comandoproyecto = new SqlCommand("SELECT pi.titulo, CONCAT (peri.año,'-',peri.semestre) AS PERIODO " +
                                                        "FROM proyectoinvestigacion pi INNER JOIN  periodo peri ON pi.periodo = peri.id " +
                                                        "WHERE ciestudiante = '" + cedula.Text + "'", conexion);
            SqlCommand comandoservicio = new SqlCommand("SELECT CONCAT (peri.año,'-',peri.semestre) AS PERIODO " +
                                                        "FROM servcomunitario serv INNER JOIN  periodo peri ON SERV.periodo = peri.id WHERE ciestudiantes LIKE '%" + cedula.Text + "%'", conexion);


            SqlDataReader lector1 = comandoproyecto.ExecuteReader(); ;


            if (lector1.Read())
            {
                proyecto.Text = lector1["PERIODO"].ToString();

                cbproyecto.Checked = true;
                titulo.Text = lector1["titulo"].ToString();
                lector1.Close();


            }
            else { lector1.Close(); }
            SqlDataReader lector2 = comandoservicio.ExecuteReader();
            if (lector2.Read())
            {
                servicio.Text = lector2["PERIODO"].ToString();
                cbservicio.Checked = true;
                lector2.Close();

            }
            else { lector2.Close(); }

        }

        public void comprobarregistro(string consultarestudiante, RichTextBox titulo,
                                        Button guardar, Button buscar, Button limpiar, 
                                        Panel panel, ComboBox intento,ComboBox cbperiodo,
                                        ComboBox estatus,string tabla) //Identifica si el estudiante ya se encuentra registrado
                                                                                  //en un proceso academico y lo notifica 
        {
            abrirconexion();
            try
            {

                SqlCommand comando = new SqlCommand(consultarestudiante, conexion);
                SqlDataReader lector = comando.ExecuteReader();

                if (lector.Read())
                {
                    mensajediferir diferir = new mensajediferir();
                    diferir.Show();
                    diferir.ciestudiante = Int32.Parse( lector["ciestudiante"].ToString());
                    diferir.cbintento = intento;
                    diferir.cbperiodo= cbperiodo;
                    diferir.tbtitulo=titulo;
                    diferir.boton=guardar;
                    diferir.cbestatus=estatus;
                    diferir.panel=panel;
                    diferir.limpiar = limpiar;
                    diferir.tabla = tabla;
                    diferir.comprobarpasantia();

                    lector.Close();
                    
                    buscar.Enabled = false;
                    limpiar.Enabled = true;

                }
                else { lector.Close(); }



            }
            catch (Exception) { throw; }

        }

        ////////////////////////////////////////OTRAS FUNCIONES RELACIONADAS A LA BASE DE DATOS//////////////////////////////////////////////////

        public string seleccionartabla(ComboBox combo, string tablaseleccionada) // selecciona la tabla en la que buscara en base al combobox
        {

            switch (combo.SelectedIndex)
            {
                case 0:
                    tablaseleccionada = "servcomunitario";
                    break;
                case 1:
                    tablaseleccionada = "proyectoinvestigacion";
                    break;
                case 2:
                    tablaseleccionada = "pasantias";
                    break;
                case 3:
                    tablaseleccionada = "trabajogrado";
                    break;
                case 4:
                    tablaseleccionada = "tria";
                    break;

            }
            return tablaseleccionada.ToString();

        }

        public string seleccionarescuela(ComboBox combo, string escuelaseleccionada) //selecciona la escuela en la que realizara la busqueda segun el combobox
        {

            switch (combo.SelectedIndex)

            {

                case 0:
                    escuelaseleccionada = " AND est.escuela = 'Arquitectura (41)'";
                    break;
                case 1:
                    escuelaseleccionada = " AND est.escuela = 'Ingeniería Civil (42)'";
                    break;
                case 2:
                    escuelaseleccionada = " AND est.escuela = 'Ingeniería Eléctrica (43)'";
                    break;
                case 3:
                    escuelaseleccionada = " AND est.escuela = 'Ingeniería Electrónica (44)'";
                    break;
                case 4:
                    escuelaseleccionada = " AND est.escuela = 'Ingeniería Industrial (45)'";
                    break;
                case 5:
                    escuelaseleccionada = " AND est.escuela = 'Ingeniería de Mtto.Mecánico (46)'";
                    break;
                case 6:
                    escuelaseleccionada = " AND est.escuela = 'Ingeniería de Sistemas (47)'";
                    break;

            }
            return escuelaseleccionada.ToString();

        }

        //public void periodosql(string sql, ComboBox Cbescuela)
        //{
        //    abrirconexion();
        //    SqlCommand comando = new SqlCommand("SELECT DISTINCT periodo FROM "+ sql, conexion);
        //    SqlDataReader lector = comando.ExecuteReader();

        //    while (lector.Read())
        //    {
        //        Cbescuela.Items.Add(lector["periodo"]);
                
        //    }
        //    lector.Close();
        //    conexion.Close();
        //}
    }
}
