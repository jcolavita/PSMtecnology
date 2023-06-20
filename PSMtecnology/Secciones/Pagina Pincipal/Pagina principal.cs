using DocumentFormat.OpenXml.Office.CustomUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrabajoDeGrado.Modulos;
using TrabajoDeGrado.Secciones.Administrador.Gestionar_usuarios;
using TrabajoDeGrado.Secciones.Estudiantes_y_Profesores;
using TrabajoDeGrado.Secciones.Estudiantes_y_Profesores.Estudiantes;
using TrabajoDeGrado.Secciones.Login;
using Button = System.Windows.Forms.Button;

namespace TrabajoDeGrado.Secciones.Pagina_Pincipal
{
    public partial class Pagina_principal : Form
    {
        public Form currentForm = new Form(); // variable utilizada para determinar si ya hay un formulario hijo abierto
        Funciones_Generales comun = new Funciones_Generales();
        public Button referencia;
        public Button referencia2;
        public string permisos;

        public Pagina_principal(){InitializeComponent(); usuarios();}


////////////////////////////////////////////FUNCIONES//////////////////////////////////////////////////////////////////////////////////////////////

        public void abrirformularios(Form formulariohijo) {  // funcion destinada a abrir los formularios como hijos del formulario principal
            if (currentForm != null) { currentForm.Close(); }
            currentForm = formulariohijo;
            formulariohijo.TopLevel = false;
            formulariohijo.Dock = DockStyle.Fill;
            formulariohijo.FormBorderStyle = FormBorderStyle.SizableToolWindow;
            formulariohijo.Text = "";
            formulariohijo.ControlBox = false;
            Panel_formularios .Controls.Add(formulariohijo);
            Panel_formularios .Tag = formulariohijo;
            formulariohijo.BringToFront();
            formulariohijo.Show();
        }

        private void Pagina_principal_FormClosed(object sender, FormClosedEventArgs e) { Application.Exit(); }

////////////////////////////////////////////BOTONES//////////////////////////////////////////////////////////////////////////////////////////////

        #region PANEL LATERAL

        private void Btnestudiantes_Click(object sender, EventArgs e) { 
            Estudiantes estudiantes = new Estudiantes();
            abrirformularios( estudiantes);
            referencia = comun.resaltarboton(Btnestudiantes, referencia);
            estudiantes.usuario = lblusuario.Text;
            estudiantes.permisos = permisos;
            estudiantes.ejecutar();
        }
        private void Btnprofesores_Click(object sender, EventArgs e) {
            Profesores profesores = new Profesores();
            abrirformularios(profesores);
            referencia = comun.resaltarboton(Btnprofesores, referencia);
            profesores.usuario=lblusuario.Text;
            profesores.permisos = permisos;
            profesores.ejecutar();
        }
        private void Btncomunitario_Click(object sender, EventArgs e) {
            Serviciocomunitario serviciocomunitario = new Serviciocomunitario();
            abrirformularios(serviciocomunitario);
            referencia = comun.resaltarboton(Btncomunitario, referencia);
            serviciocomunitario.usuario = lblusuario.Text;
        }
        private void btnproyecto_Click(object sender, EventArgs e)
        {
            proyectoinvestigacion proyectoinvestigacion = new proyectoinvestigacion();
            abrirformularios( proyectoinvestigacion);
            referencia = comun.resaltarboton(btnproyecto, referencia);
            proyectoinvestigacion.permisos=permisos;
            proyectoinvestigacion.ejecutar();
            proyectoinvestigacion.usuario=lblusuario.Text;
        }
        private void trabajogrado_Click(object sender, EventArgs e)
        {
            Trabajogrado trabajogrado = new Trabajogrado();
            abrirformularios(trabajogrado);
            referencia = comun.resaltarboton(btntrabajogrado, referencia);
            trabajogrado.permisos=permisos;
            trabajogrado.ejecutar();
            trabajogrado.usuario = lblusuario.Text;
        }
        private void btntria_Click(object sender, EventArgs e)
        {
            Recuperacion recuperacion = new Recuperacion();
            abrirformularios(recuperacion);
            referencia = comun.resaltarboton(btntria, referencia);
            recuperacion.permisos = permisos;
            recuperacion.ejecutar();
            recuperacion.usuario = lblusuario.Text;
        }
        private void btnpasantias_Click_1(object sender, EventArgs e)
        {
            Pasantias pasantias = new Pasantias();
            abrirformularios(pasantias);
            referencia = comun.resaltarboton(btnpasantias, referencia);
            pasantias.permisos = permisos;
            pasantias.ejecutar();
            pasantias.usuario = lblusuario.Text;
        }
        private void btngestion_Click(object sender, EventArgs e)
        {
            gestionarusuarios gestionarusuarios = new gestionarusuarios();
            abrirformularios(gestionarusuarios);
            referencia = comun.resaltarboton(btngestion, referencia);
            gestionarusuarios.usuario = lblusuario.Text; 
            
        }
        private void btnproyectos_Click(object sender, EventArgs e)
        {
            abrirformularios(new Proyectos());
            referencia = comun.resaltarboton(btnproyectosbiblioteca, referencia);
        }
        private void btnlibros_Click(object sender, EventArgs e)
        {
            Libros libros = new Libros();
            abrirformularios(libros);
            libros.permisos = permisos;
            libros.ejecutar();
            referencia = comun.resaltarboton(btnlibros, referencia);
            libros.usuario = lblusuario.Text;           
        }
        private void btnprestamospendientes_Click(object sender, EventArgs e)
        {
            abrirformularios(new prestamospendientes());
            referencia = comun.resaltarboton(btnprestamospendientes, referencia);
        }
        private void btnprestamos_Click(object sender, EventArgs e)
        {
            prestamos prestamos = new prestamos();
            abrirformularios(prestamos);
            referencia = comun.resaltarboton(btnprestamos, referencia);
            prestamos.usuario = lblusuario.Text;

        }
        private void btnproyectores_Click(object sender, EventArgs e)
        {
            proyectores proyectores = new proyectores();
            abrirformularios(proyectores);
            referencia = comun.resaltarboton(btnproyectores, referencia);
            proyectores.usuario = lblusuario.Text;
            proyectores.permisos = permisos;
            proyectores.ejecutar();
        }
        private void btnsalir_Click(object sender, EventArgs e)
        {
            login login = new login();

            login.Show();
            this.Hide();
            login.limpiar();
        }
        private void btnretrasos_Click(object sender, EventArgs e)
        {
            abrirformularios(new retrasos());
            referencia = comun.resaltarboton(btnretrasos, referencia);
        }
        private void btnapertura_Click(object sender, EventArgs e)
        {
            apertura apertura = new apertura();
            referencia = comun.resaltarboton(btnapertura, referencia);
            apertura.Show();
            apertura.fecha();
            apertura.usuario = lblusuario.Text;
        }

        private void btnalquiler_Click(object sender, EventArgs e)
        {
            alquilerarea area = new alquilerarea();
            area.permisos = permisos;

            abrirformularios(area);
            referencia = comun.resaltarboton(btnalquiler, referencia);
            area.usuario = lblusuario.Text;
            area.ejecutar();

        }

        private void btnrespaldo_Click(object sender, EventArgs e)
        {
            respaldarbd respaldo = new respaldarbd();
            respaldo.Show();
            referencia = comun.resaltarboton(btnrespaldo, referencia);
        }

        #endregion

        #region BOTONES SUPERIORES

        private void btnacademico_Click(object sender, EventArgs e)
        {
            Panel_admin.Visible = false;
            Panel_Academico.Visible = true;
            paneltecnologia.Visible = false;
            Panel_Academico.Location = new Point(0, 100);
            referencia2 = comun.resaltarboton(btnacademico, referencia2);
            lblmodulo.Text = "Academico";
            currentForm.Close();
            subpanel();

        }
        private void btntecnologia_Click(object sender, EventArgs e)
        {
            Panel_Academico.Visible = false;
            Panel_admin.Visible = false;
            paneltecnologia.Visible = true;
            paneltecnologia.Location = new Point(0, 100);
            referencia2 = comun.resaltarboton(btntecnologia, referencia2);
            lblmodulo.Text = "Tecnologia Educativa";
            currentForm.Close();
            subpanel();
        }
        private void btnadmin_Click(object sender, EventArgs e)
        {
            Panel_Academico.Visible = false;
            Panel_admin.Visible = true;
            paneltecnologia.Visible = false;
            Panel_admin.Location = new Point(0, 100);
            referencia2 = comun.resaltarboton(btnadmin, referencia2);
            lblmodulo.Text = "Administrador";
            currentForm.Close();
            subpanel();

        }
        private void btnpersonal_Click(object sender, EventArgs e)

        {
            areapersonal personal = new areapersonal();
            personal.usuario = lblusuario.Text;
            abrirformularios(personal);
            referencia2 = comun.resaltarboton(btnpersonal, referencia2);
            lblmodulo.Text = "Area Personal";
            //personal.rellenargrid();
            Panel_Academico.Visible = false;
            Panel_admin.Visible = false;
            paneltecnologia.Visible = false;



        }
        private void btnconfigurar_Click(object sender, EventArgs e)
        {
            configurarclave configurar = new configurarclave();

            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is configurarclave);
            if (frm != null)
            {
                //si la instancia existe la pongo en primer plano
                frm.Close();
            }
            configurar.Show();
            if (lbldepartamento.Text.Contains("ESTUDIANTE"))
            {
                configurar.tbcodigo.Enabled = false;
                configurar.Tbtelefono.Enabled = false;
                configurar.Tbcorreo.Enabled = false;
            }
            configurar.usuario.Text = lblusuario.Text;
            configurar.rellenarcampos();

        }



        #endregion

////////////////////////////////////////////PERMISOLOGIAS////////////////////////////////////////////////////////////////////////////////////////////////

        #region PERMISOS
        public void subpanel()
        {
            if (lbldepartamento.Text == "INVESTIGACIONES")
            {
                panelpasantia.Visible = false;
                panelcomunitario.Visible = false;
                subpanelinvestigaciones.Location = new Point(0, 81);

            }
            else if (lbldepartamento.Text == "TECNOLOGIA EDUCATIVA")
            {
                subpanelinvestigaciones.Visible = false;
                panelcomunitario.Visible = false;
                panelpasantia.Location = new Point(0, 81);
                if (!permisos.Contains("5,"))
                {
                    btnretrasos.Visible = false;
                }
                if (!permisos.Contains("6,"))
                {
                    btnprestamospendientes.Visible = false;
                    btnprestamos.Visible = false;
                }
                if (!permisos.Contains("5,") && !permisos.Contains("6,"))
                {
                    lblgestion.Visible = false;
                }
            }
            else if (lbldepartamento.Text == "SERVICIO COMUNITARIO")
            {
                subpanelinvestigaciones.Visible = false;
                panelpasantia.Visible = false;

            }
            else if (lbldepartamento.Text == "ESTUDIANTE" )
            {
                panelprestamos.Visible = false;
                panelproyetores_area.Visible = false;

            }
            else if ( lbldepartamento.Text == "DOCENTE")
            {
                btnprestamos.Visible = false;
                btnretrasos.Visible = false;
                btnprestamospendientes.Visible = false;
            }

        }

        public void usuarios()
        {
            if (lbldepartamento.Text == "INVESTIGACIONES")
            {
                btnadmin.Visible = false;
                btntecnologia.Visible = false;
                btnpersonal.Location = new Point(191, 59);
                if (!permisos.Contains("7"))
                {
                    btnapertura.Visible = false;
                }
            }
            else if (lbldepartamento.Text == "TECNOLOGIA EDUCATIVA")
            {
                btnadmin.Visible = false;
                btnpersonal.Location = new Point(348, 59);
                if (!permisos.Contains("7"))
                {
                    btnapertura.Visible = false;
                }

            }
            else if (lbldepartamento.Text == "SERVICIO COMUNITARIO")
            {
                btnadmin.Visible = false;
                btntecnologia.Visible = false;
                btnpersonal.Location = new Point(191, 59);
                if (!permisos.Contains("7"))
                {
                    btnapertura.Visible = false;
                }

            }
            else if (lbldepartamento.Text == "ESTUDIANTE" || lbldepartamento.Text == "DOCENTE")
            {
                btnadmin.Visible = false;
                btnacademico.Visible = false;
                btntecnologia.Location = new Point(0, 59);
                btnpersonal.Location = new Point(191, 59);
                if (!permisos.Contains("7"))
                {
                    btnapertura.Visible = false;
                }

            }
            else if (lbldepartamento.Text == "DEPARTAMENTOS MULTIPLES")
            {
                if (!permisos.Contains("3,"))
                {
                    btnadmin.Visible = false;
                    btnpersonal.Location = new Point(352, 68);
                }
                if (!permisos.Contains("7"))
                {
                    btnapertura.Visible = false;
                }
                if (!permisos.Contains("5,"))
                {
                    btnretrasos.Visible = false;
                }
                if (!permisos.Contains("6,"))
                {
                    btnprestamospendientes.Visible = false;
                    btnprestamos.Visible = false;
                }
                if (!permisos.Contains("5,") && !permisos.Contains("6,"))
                {
                    lblgestion.Visible = false;
                }

            }

        }


        #endregion

        private void button2_Click(object sender, EventArgs e)
        {
            auditoria auditoria = new auditoria();
            abrirformularios(auditoria);
            referencia = comun.resaltarboton(button2, referencia);
            ;
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
                Process.Start(@"D:\Documentos\TG\PSMtecnology\PSMtecnology\bin\Debug\Manual de usuario - PSMTecnology.pdf");

            

        }
    }
}
