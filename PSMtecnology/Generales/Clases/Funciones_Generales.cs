using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabajoDeGrado.Secciones.Pagina_Pincipal;
using System.Data.SqlClient;
using System.Security.Cryptography.X509Certificates;
using TrabajoDeGrado.Secciones.Estudiantes_y_Profesores.Estudiantes;
using System.Data;
using System.Diagnostics.CodeAnalysis;
using System.Windows.Forms;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Diagnostics;
using PSMtecnology.Properties;
using DocumentFormat.OpenXml.Packaging;
using System.IO;
using Microsoft.VisualBasic;

namespace TrabajoDeGrado.Modulos
{
    public  class Funciones_Generales
    {
        ////////////////////////////////////// VALIDACIONES ///////////////////////////////////////////////////////////
        public void validarletras(KeyPressEventArgs e) //limita los textbox a letras
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && !(char.IsSeparator(e.KeyChar))) { e.Handled = true; }
        }

        public void validarnumeros(KeyPressEventArgs e)//limita los textbox a numeros
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back)) { e.Handled = true; }
        }

        public void eliminarletras(TextBox textbox) //elimina las letras de los textbo de busqueda
                                                    //para solo mandar los numeros en caso de querer agregar
        {
            if (textbox.Text.Any(x => !char.IsNumber(x)))
            {
                textbox.Text = "";
            }
            else if (textbox.TextLength > 9)
            {
                textbox.Text = textbox.Text.Substring(0, 9);
            }
        }

        public void eliminarnaiconalidad(DataGridView grid, TextBox textbox) //elimina la nacionalidad de la cedula para utilizar su valor en una consulta 
        {
            string datos = grid.CurrentRow.Cells["CEDULA"].Value.ToString();
            string diferenciador = datos.Substring(0, 2);
            int comparacion = String.Compare(diferenciador, "V.");

            if (comparacion == 0) { textbox.Text = datos.Replace("V.", ""); }
            else { textbox.Text = datos.Replace("E.", ""); }
        }


        ////////////////////////////////////// ESTETICA ///////////////////////////////////////////////////////////

        public Button resaltarboton(Button botonA, Button botonB) //resalta el ultimo boton pulsado en la pagina principal
        {
            Color colorbase = Color.FromArgb(22, 24, 67);
            Color colorresaltado = Color.FromArgb(22, 24, 120);

            botonA.BackColor = colorresaltado;
            if (botonB != null)
            {
                botonB.BackColor = colorbase;

            }
            return botonA;
        }

        ////////////////////////////////////// GRID ///////////////////////////////////////////////////////////

        public void btneditar(DataGridView grid) //boton del grid para abrir el formulario de edicion 
        {
            DataGridViewImageColumn modificar = new DataGridViewImageColumn();
            modificar.Image = Resources.editar_lineas;
            modificar.HeaderText = "EDITAR";
            modificar.Width = 50;
            grid.Columns.Add(modificar);
        }

        public void btnsolicitar(DataGridView grid)//boton del grid para abrir el formulario de solicitud 

        {
            DataGridViewImageColumn solicitar = new DataGridViewImageColumn();
            solicitar.Image = Resources.solicitud;
            solicitar.HeaderText = "SOLICITAR";
            solicitar.Width = 50;
            grid.Columns.Add(solicitar);
        }

        public void btncomfirmar(DataGridView grid)//boton del grid para abrir el formulario de confirmacion de prestamo 
        {
            DataGridViewImageColumn solicitar = new DataGridViewImageColumn();
            solicitar.Image = Resources.check;
            solicitar.HeaderText = "CONFIRMAR";
            solicitar.Width = 50;
            grid.Columns.Add(solicitar);
        } 

        public void btndevolver(DataGridView grid) //boton del grid para abrir el formulario de devolucion

        {
            DataGridViewImageColumn solicitar = new DataGridViewImageColumn();
            solicitar.Image = Resources.devolver;
            solicitar.HeaderText = "DEVOLVER";
            solicitar.Width = 50;
            grid.Columns.Add(solicitar);
        }

        ////////////////////////////////////// OTROS ///////////////////////////////////////////////////////////

        public void cerrarpanel() //cierra el panel de formularios
        {
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is paneldeformularios);
            if (frm != null)
            {
                //si la instancia existe la cierra para abrirla nuevamente delante de todo
                frm.Close();
            }
        }

        public string comunes(int i,ComboBox Cbescuela,CheckBox comun41, CheckBox comun42, CheckBox comun43, 
            CheckBox comun44, CheckBox comun45, CheckBox comun46, CheckBox comun47)
        {
            string escuela41 = "", escuela42 = "", escuela43 = "", escuela44 = "", escuela45 = "", escuela46 = "", escuela47 = "", comun = "";

            if (Cbescuela.SelectedIndex == i)
            {
                if (comun41.Checked)
                {
                    escuela41 = "41,";
                }
                if (comun42.Checked)
                {
                    escuela42 = "42,";
                }
                if (comun43.Checked)
                {
                    escuela43 = "43,";
                }
                if (comun44.Checked)
                {
                    escuela44 = "44,";
                }
                if (comun45.Checked)
                {
                    escuela45 = "45,";
                }
                if (comun46.Checked)
                {
                    escuela46 = "46,";
                }
                if (comun47.Checked)
                {
                    escuela47 = "47,";
                }

                comun = "COMUN: " + escuela41 + escuela42 + escuela43 + escuela44 + escuela45 + escuela46 + escuela47;

            }
            else
            {
                comun = Cbescuela.Text;
            }
            return comun;


        }

        public void autorrellenocomun(string escuela, CheckBox comun41, CheckBox comun42, CheckBox comun43,
            CheckBox comun44, CheckBox comun45, CheckBox comun46, CheckBox comun47,ComboBox cbescuela)
        {
            if (escuela.Contains("41,"))
            {
                comun41.Checked=true;
                cbescuela.SelectedIndex = 0;
            }
            if (escuela.Contains("42,"))
            {
                comun42.Checked = true;
                cbescuela.SelectedIndex = 0;
            }
            if (escuela.Contains("43,"))
            {
                comun43.Checked = true;
                cbescuela.SelectedIndex = 0;
            }
            if (escuela.Contains("44,"))
            {
                comun44.Checked = true;
                cbescuela.SelectedIndex = 0;
            }
            if (escuela.Contains("45,"))
            {
                comun45.Checked = true;
                cbescuela.SelectedIndex = 0;
            }
            if (escuela.Contains("46,"))
            {
                comun46.Checked = true;
                cbescuela.SelectedIndex = 0;
            }
            if (escuela.Contains("47,"))
            {
                comun47.Checked = true;
                cbescuela.SelectedIndex = 0;
            }

        }

        public void rellenar(string documentPath, string[,] datos)
        {

            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Word |*.docx" })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    WordprocessingDocument wordDoc = WordprocessingDocument.CreateFromTemplate(documentPath, false);

                    using (wordDoc)
                    {
                        string docText;
                        string Find, Replaace;
                        int j = 0;

                        for (int i = 0; i == datos.Length; i++)
                        {
                            while (j == 0)
                            {
                                Find = datos[i, j + 1];
                                Replaace = datos[i, j];

                                docText = null;

                                StreamReader sr = new StreamReader(wordDoc.MainDocumentPart.GetStream());


                                using (sr)
                                {
                                    docText = sr.ReadToEnd();

                                }

                                Regex regextext = new Regex("\\(" + Find + "\\)");
                                docText = regextext.Replace(docText, Replaace);

                                StreamWriter sw = new StreamWriter(wordDoc.MainDocumentPart.GetStream(FileMode.Create));

                                using (sw)
                                {
                                    sw.Write(docText);
                                }
                                j = 1;
                            }
                        }
                        //WordprocessingDocument word = wordDoc.Clone(sfd.FileName);
                        //wordDoc.Close();
                        //word.Close();
                    }

                }

                if (System.IO.File.Exists(sfd.FileName) == true)
                {
                    Process.Start(sfd.FileName);
                }
                else
                {
                    MessageBox.Show("ERROR");
                }


            }
        }
    }
}

