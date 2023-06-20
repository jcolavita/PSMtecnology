using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Data.SqlClient;
using System.Windows.Forms;
using TrabajoDeGrado.Generales;
using TrabajoDeGrado.Modulos;

namespace TrabajoDeGrado.Secciones.Estudiantes_y_Profesores.Estudiantes
{
    public partial class Agregarcomunitario : Form
    {
        Funciones_Generales generales = new Funciones_Generales();
        Funciones_BD BD = new Funciones_BD();
        Pagina_Pincipal.Pagina_principal principal = new Pagina_Pincipal.Pagina_principal();
        int contador = 0;
        bool problema = false;
        public string usuario = "";
        ArrayList estudiantes = new ArrayList();
        mensajeinformacion informacion = new mensajeinformacion();

        public Agregarcomunitario() { InitializeComponent(); BD.periodosql(cbperiodo); }

        public void comprobartextbox()
        {
            var vr = !string.IsNullOrEmpty(tbcomunidad.Text) &&
                !string.IsNullOrEmpty(titulo.Text) &&
                !string.IsNullOrEmpty(cbperiodo.Text) &&
                !string.IsNullOrEmpty(lbestudiantes.Text);

            Btnagregar.Enabled = vr;
        }

        private void Btnagregar_Click(object sender, EventArgs e)
        {

            BD.abrirconexion();
            string ciestudiantes = string.Join(", ", estudiantes.ToArray());
            string escuela = "";
            if (cbexoneracion.Checked == true)
            {
                lbestudiantes.SelectedIndex = 0;
                SqlCommand comando = new SqlCommand("SELECT escuela FROM estudiantes WHERE ciestudiante = '" + lbestudiantes.SelectedIndex + "'", BD.conexion);
                escuela = comando.ExecuteScalar().ToString();
            }


            if (Btnagregar.Text=="Actualizar")
            {
                string sql = "UPDATE servcomunitario SET nombrecomunidad='" + tbcomunidad.Text + "',titulo='" + titulo.Text + "', " +
                            "periodo = '" + cbperiodo.SelectedValue + "', ciestudiantes = '" + estudiantes + "', escuela = '" + escuela + "'";
                string mensaje = "El proyecto de servicio comunitario ha sido modificado correctamente.";

                BD.actualizar(sql,mensaje, true, usuario, "SERVICIO COMUNITARIO", ID.Text, true, this);

            }
            else
            {
                string sql = "INSERT INTO servcomunitario ([nombrecomunidad],[titulo],[periodo],[ciestudiantes],[escuela]) values " +
                                 "('" + System.Convert.ToString(tbcomunidad.Text) + "'," +
                                 " '" + System.Convert.ToString(titulo.Text) + "'," +
                                 " '" + System.Convert.ToString(cbperiodo.SelectedValue) + "'," +
                                 " '" + System.Convert.ToString(ciestudiantes) + "'," +
                                 " '" + System.Convert.ToString(escuela) + "')";
                string mensaje = "El proyecto de servicio comunitario ha sido creado correctamente.";
                BD.agregar(sql, mensaje, true,usuario, "SERVICIO COMUNITARIO", "CREACION", ciestudiantes, true, this);
            }
                        
            
        }

        #region EVENTOS DE OBJETOS
        private void Tbcedula_KeyPress(object sender, KeyPressEventArgs e) { generales.validarnumeros(e);  }
        private void Tbprimernombre_KeyPress(object sender, KeyPressEventArgs e) { generales.validarletras(e);  }
        private void Cbsexo_SelectedValueChanged(object sender, EventArgs e) { }


        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            BD.abrirconexion();
            string nombre="";

            if (contador ==12)
            {
                informacion.Show();
                informacion.lblalerta.Text = "No se pueden agregar mas estudiantes";
            }
            else
            {
                try
                {
                    string consulta = "SELECT ciestudiantes FROM servcomunitario WHERE ciestudiantes LIKE '%" + Tbcedula.Text + "%'";

                    SqlCommand comando = new SqlCommand(consulta, BD.conexion);
                SqlDataReader lector = comando.ExecuteReader();

                if (lector.HasRows == true)
                {

                    informacion.Show();
                    informacion.lblalerta.Text = "El estudiante ya se encuentra registrado en un proyecto";
                    lector.Close();

                }
                else
                {
                    lector.Close();

                    try
                    {
                        string consultanombre = "SELECT * FROM usuarios WHERE usuario = '" + Tbcedula.Text + "'";

                        SqlCommand comando2 = new SqlCommand(consultanombre, BD.conexion);
                        SqlDataReader lector2 = comando2.ExecuteReader();

                        if (lector2.Read())
                        {
                            nombre = lector2["primernombre"].ToString() + " " + lector2["primerapellido"].ToString(); ;
                            lector2.Close();

                            for (int i = 0; i == estudiantes.Count; i++)
                            {
                                if (estudiantes.Contains(Tbcedula.Text))
                                {
                                    problema = true;
                                    return;
                                }
                            }
                            if (problema == true)
                            {
                                informacion.Show();
                                informacion.lblalerta.Text = "El estudiante ya fue añadido";
                                problema = false;
                            }
                            else
                            {
                                estudiantes.Add(Tbcedula.Text);
                                lbestudiantes.Items.Add(nombre);
                                Tbcedula.Text = "";
                                contador = contador + 1;
                                lbestudiantes.SelectedIndex = contador-1;
                            }

                        }
                        else
                        {
                            lector2.Close();

                            informacion.Show();
                            informacion.lblalerta.Text = "La cedula ingresada no pertenece a ningun estudiante";
                        }


                    }

                    catch (Exception)
                    {

                    }
                }
            }
                catch (Exception)
            {
                informacion.Show();
                informacion.lblalerta.Text = "La cedula ingresada no pertenece a ningun estudiante";
            }

        }
            if (lbestudiantes.Items.Count>1)
            {
                cbexoneracion.Enabled = false;
                cbexoneracion.Checked = false;
            }
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            if (lbestudiantes.SelectedIndex>-1)
            {
                estudiantes.RemoveAt(lbestudiantes.SelectedIndex);
                lbestudiantes.Items.RemoveAt(lbestudiantes.SelectedIndex);

                contador = contador - 1;
            }
            if (lbestudiantes.Items.Count<=1)
            {
                cbexoneracion.Enabled = true;
            }

        
        }

        private void cbperiodo_TextChanged(object sender, EventArgs e)
        {
            comprobartextbox();
            tbcomunidad.Text = tbcomunidad.Text.ToUpper();
            tbcomunidad.Select(tbcomunidad.Text.Length, 0);
            titulo.Text = titulo.Text.ToUpper();
            titulo.Select(titulo.Text.Length, 0);

        }

        private void lbestudiantes_SelectedIndexChanged(object sender, EventArgs e)
        {
            comprobartextbox();
        }
    }
}

