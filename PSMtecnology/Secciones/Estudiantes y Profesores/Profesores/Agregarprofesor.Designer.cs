using System.Windows.Forms;

namespace TrabajoDeGrado.Secciones.Estudiantes_y_Profesores.Estudiantes
{
    partial class Agregarprofesor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.Btnagregar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelcomunes = new System.Windows.Forms.Panel();
            this.comun47 = new System.Windows.Forms.CheckBox();
            this.comun44 = new System.Windows.Forms.CheckBox();
            this.comun45 = new System.Windows.Forms.CheckBox();
            this.comun42 = new System.Windows.Forms.CheckBox();
            this.comun46 = new System.Windows.Forms.CheckBox();
            this.comun43 = new System.Windows.Forms.CheckBox();
            this.comun41 = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbcodigo = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.Tbespecialidad = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.Cbprofesion = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Cbtipo = new System.Windows.Forms.ComboBox();
            this.Btncerrar = new System.Windows.Forms.Button();
            this.Cbsexo = new System.Windows.Forms.ComboBox();
            this.Cbescuela = new System.Windows.Forms.ComboBox();
            this.Tbcedula = new System.Windows.Forms.TextBox();
            this.Tbsegundonombre = new System.Windows.Forms.TextBox();
            this.Tbcorreo = new System.Windows.Forms.TextBox();
            this.Tbtelefono = new System.Windows.Forms.TextBox();
            this.Tbprimerapellido = new System.Windows.Forms.TextBox();
            this.Tbsegundoapellido = new System.Windows.Forms.TextBox();
            this.lblcabecera = new System.Windows.Forms.Label();
            this.Tbprimernombre = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panelcomunes.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Btnagregar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 345);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(417, 73);
            this.panel1.TabIndex = 0;
            // 
            // Btnagregar
            // 
            this.Btnagregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btnagregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(24)))), ((int)(((byte)(67)))));
            this.Btnagregar.Enabled = false;
            this.Btnagregar.FlatAppearance.BorderSize = 0;
            this.Btnagregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btnagregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.Btnagregar.ForeColor = System.Drawing.Color.White;
            this.Btnagregar.Location = new System.Drawing.Point(292, 23);
            this.Btnagregar.Name = "Btnagregar";
            this.Btnagregar.Size = new System.Drawing.Size(103, 35);
            this.Btnagregar.TabIndex = 1;
            this.Btnagregar.Text = "Agregar";
            this.Btnagregar.UseVisualStyleBackColor = false;
            this.Btnagregar.Click += new System.EventHandler(this.Btnagregar_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.panelcomunes);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.tbcodigo);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.Tbespecialidad);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.Cbprofesion);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.Cbtipo);
            this.panel2.Controls.Add(this.Btncerrar);
            this.panel2.Controls.Add(this.Cbsexo);
            this.panel2.Controls.Add(this.Cbescuela);
            this.panel2.Controls.Add(this.Tbcedula);
            this.panel2.Controls.Add(this.Tbsegundonombre);
            this.panel2.Controls.Add(this.Tbcorreo);
            this.panel2.Controls.Add(this.Tbtelefono);
            this.panel2.Controls.Add(this.Tbprimerapellido);
            this.panel2.Controls.Add(this.Tbsegundoapellido);
            this.panel2.Controls.Add(this.lblcabecera);
            this.panel2.Controls.Add(this.Tbprimernombre);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(417, 345);
            this.panel2.TabIndex = 1;
            // 
            // panelcomunes
            // 
            this.panelcomunes.Controls.Add(this.comun47);
            this.panelcomunes.Controls.Add(this.comun44);
            this.panelcomunes.Controls.Add(this.comun45);
            this.panelcomunes.Controls.Add(this.comun42);
            this.panelcomunes.Controls.Add(this.comun46);
            this.panelcomunes.Controls.Add(this.comun43);
            this.panelcomunes.Controls.Add(this.comun41);
            this.panelcomunes.Location = new System.Drawing.Point(234, 195);
            this.panelcomunes.Name = "panelcomunes";
            this.panelcomunes.Size = new System.Drawing.Size(162, 47);
            this.panelcomunes.TabIndex = 40;
            this.panelcomunes.Visible = false;
            // 
            // comun47
            // 
            this.comun47.AutoSize = true;
            this.comun47.Location = new System.Drawing.Point(97, 28);
            this.comun47.Name = "comun47";
            this.comun47.Size = new System.Drawing.Size(38, 17);
            this.comun47.TabIndex = 6;
            this.comun47.Text = "47";
            this.comun47.UseVisualStyleBackColor = true;
            // 
            // comun44
            // 
            this.comun44.AutoSize = true;
            this.comun44.Location = new System.Drawing.Point(117, 10);
            this.comun44.Name = "comun44";
            this.comun44.Size = new System.Drawing.Size(38, 17);
            this.comun44.TabIndex = 5;
            this.comun44.Text = "44";
            this.comun44.UseVisualStyleBackColor = true;
            // 
            // comun45
            // 
            this.comun45.AutoSize = true;
            this.comun45.Location = new System.Drawing.Point(21, 28);
            this.comun45.Name = "comun45";
            this.comun45.Size = new System.Drawing.Size(38, 17);
            this.comun45.TabIndex = 2;
            this.comun45.Text = "45";
            this.comun45.UseVisualStyleBackColor = true;
            // 
            // comun42
            // 
            this.comun42.AutoSize = true;
            this.comun42.Location = new System.Drawing.Point(41, 10);
            this.comun42.Name = "comun42";
            this.comun42.Size = new System.Drawing.Size(38, 17);
            this.comun42.TabIndex = 4;
            this.comun42.Text = "42";
            this.comun42.UseVisualStyleBackColor = true;
            // 
            // comun46
            // 
            this.comun46.AutoSize = true;
            this.comun46.Location = new System.Drawing.Point(59, 28);
            this.comun46.Name = "comun46";
            this.comun46.Size = new System.Drawing.Size(38, 17);
            this.comun46.TabIndex = 3;
            this.comun46.Text = "46";
            this.comun46.UseVisualStyleBackColor = true;
            // 
            // comun43
            // 
            this.comun43.AutoSize = true;
            this.comun43.Location = new System.Drawing.Point(79, 10);
            this.comun43.Name = "comun43";
            this.comun43.Size = new System.Drawing.Size(38, 17);
            this.comun43.TabIndex = 1;
            this.comun43.Text = "43";
            this.comun43.UseVisualStyleBackColor = true;
            // 
            // comun41
            // 
            this.comun41.AutoSize = true;
            this.comun41.Location = new System.Drawing.Point(3, 10);
            this.comun41.Name = "comun41";
            this.comun41.Size = new System.Drawing.Size(38, 17);
            this.comun41.TabIndex = 0;
            this.comun41.Text = "41";
            this.comun41.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label1.Location = new System.Drawing.Point(10, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 16);
            this.label1.TabIndex = 39;
            this.label1.Text = "Codigo";
            // 
            // tbcodigo
            // 
            this.tbcodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.tbcodigo.Location = new System.Drawing.Point(12, 166);
            this.tbcodigo.MaxLength = 4;
            this.tbcodigo.Name = "tbcodigo";
            this.tbcodigo.Size = new System.Drawing.Size(55, 22);
            this.tbcodigo.TabIndex = 38;
            this.tbcodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbcodigo_KeyPress);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label14.Location = new System.Drawing.Point(209, 294);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(152, 16);
            this.label14.TabIndex = 37;
            this.label14.Text = "Especialidad (Opcional)";
            // 
            // Tbespecialidad
            // 
            this.Tbespecialidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.Tbespecialidad.Location = new System.Drawing.Point(209, 310);
            this.Tbespecialidad.Name = "Tbespecialidad";
            this.Tbespecialidad.Size = new System.Drawing.Size(193, 22);
            this.Tbespecialidad.TabIndex = 36;
            this.Tbespecialidad.TextChanged += new System.EventHandler(this.Tbprimernombre_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label13.Location = new System.Drawing.Point(12, 244);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(64, 16);
            this.label13.TabIndex = 35;
            this.label13.Text = "Profesion";
            // 
            // Cbprofesion
            // 
            this.Cbprofesion.DropDownHeight = 115;
            this.Cbprofesion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cbprofesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.Cbprofesion.FormattingEnabled = true;
            this.Cbprofesion.IntegralHeight = false;
            this.Cbprofesion.Items.AddRange(new object[] {
            "ARQUITECTO/A",
            "INGENIERO/A",
            "LICENCIADO/A",
            "ABOGADO/A",
            "PROFESOR/A"});
            this.Cbprofesion.Location = new System.Drawing.Point(12, 260);
            this.Cbprofesion.Name = "Cbprofesion";
            this.Cbprofesion.Size = new System.Drawing.Size(193, 24);
            this.Cbprofesion.TabIndex = 34;
            this.Cbprofesion.SelectedIndexChanged += new System.EventHandler(this.Cbprofesion_SelectedIndexChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label12.Location = new System.Drawing.Point(12, 195);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(56, 16);
            this.label12.TabIndex = 33;
            this.label12.Text = "Escuela";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label10.Location = new System.Drawing.Point(12, 294);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(113, 16);
            this.label10.TabIndex = 31;
            this.label10.Text = "Correo (Opcional)";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label9.Location = new System.Drawing.Point(209, 244);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 16);
            this.label9.TabIndex = 30;
            this.label9.Text = "Sexo";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label8.Location = new System.Drawing.Point(268, 149);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(128, 16);
            this.label8.TabIndex = 29;
            this.label8.Text = "Cedula de Identidad";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label7.Location = new System.Drawing.Point(209, 147);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 16);
            this.label7.TabIndex = 28;
            this.label7.Text = "Tipo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label6.Location = new System.Drawing.Point(73, 149);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 16);
            this.label6.TabIndex = 27;
            this.label6.Text = "Telefono";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label5.Location = new System.Drawing.Point(12, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 16);
            this.label5.TabIndex = 26;
            this.label5.Text = "Primer Apellido";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label4.Location = new System.Drawing.Point(209, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(180, 16);
            this.label4.TabIndex = 25;
            this.label4.Text = "Segundo Apellido (Opcional)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label3.Location = new System.Drawing.Point(209, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(179, 16);
            this.label3.TabIndex = 24;
            this.label3.Text = "Segundo Nombre (Opcional)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label2.Location = new System.Drawing.Point(12, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 16);
            this.label2.TabIndex = 23;
            this.label2.Text = "Primer Nombre";
            // 
            // Cbtipo
            // 
            this.Cbtipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cbtipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.Cbtipo.FormattingEnabled = true;
            this.Cbtipo.Items.AddRange(new object[] {
            "V.",
            "E."});
            this.Cbtipo.Location = new System.Drawing.Point(209, 164);
            this.Cbtipo.Name = "Cbtipo";
            this.Cbtipo.Size = new System.Drawing.Size(55, 24);
            this.Cbtipo.TabIndex = 22;
            this.Cbtipo.SelectedValueChanged += new System.EventHandler(this.Cbsexo_SelectedValueChanged);
            // 
            // Btncerrar
            // 
            this.Btncerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btncerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btncerrar.FlatAppearance.BorderSize = 0;
            this.Btncerrar.Image = global::PSMtecnology.Properties.Resources.cerrar;
            this.Btncerrar.Location = new System.Drawing.Point(384, 12);
            this.Btncerrar.Name = "Btncerrar";
            this.Btncerrar.Size = new System.Drawing.Size(21, 21);
            this.Btncerrar.TabIndex = 20;
            this.Btncerrar.UseVisualStyleBackColor = true;
            this.Btncerrar.Click += new System.EventHandler(this.Btncerrar_Click);
            // 
            // Cbsexo
            // 
            this.Cbsexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cbsexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.Cbsexo.FormattingEnabled = true;
            this.Cbsexo.Items.AddRange(new object[] {
            "MASCULINO",
            "FEMENINO"});
            this.Cbsexo.Location = new System.Drawing.Point(209, 260);
            this.Cbsexo.Name = "Cbsexo";
            this.Cbsexo.Size = new System.Drawing.Size(193, 24);
            this.Cbsexo.TabIndex = 19;
            this.Cbsexo.SelectedValueChanged += new System.EventHandler(this.Cbsexo_SelectedValueChanged);
            // 
            // Cbescuela
            // 
            this.Cbescuela.DropDownHeight = 115;
            this.Cbescuela.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cbescuela.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.Cbescuela.FormattingEnabled = true;
            this.Cbescuela.IntegralHeight = false;
            this.Cbescuela.Items.AddRange(new object[] {
            "COMUN",
            "ARQUITECTURA (41)",
            "INGENIERÍA CIVIL (42)",
            "INGENIERÍA ELÉCTRICA (43)",
            "INGENIERÍA ELECTRÓNICA (44)",
            "INGENIERÍA INDUSTRIAL (45)",
            "INGENIERÍA DE MTTO. MECÁNICO (46)",
            "INGENIERÍA DE SISTEMAS (47)"});
            this.Cbescuela.Location = new System.Drawing.Point(12, 211);
            this.Cbescuela.Name = "Cbescuela";
            this.Cbescuela.Size = new System.Drawing.Size(193, 24);
            this.Cbescuela.TabIndex = 18;
            this.Cbescuela.SelectedIndexChanged += new System.EventHandler(this.Cbescuela_SelectedIndexChanged);
            this.Cbescuela.SelectedValueChanged += new System.EventHandler(this.Cbsexo_SelectedValueChanged);
            // 
            // Tbcedula
            // 
            this.Tbcedula.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.Tbcedula.Location = new System.Drawing.Point(268, 166);
            this.Tbcedula.MaxLength = 9;
            this.Tbcedula.Name = "Tbcedula";
            this.Tbcedula.Size = new System.Drawing.Size(133, 22);
            this.Tbcedula.TabIndex = 16;
            this.Tbcedula.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Tbcedula_KeyPress);
            // 
            // Tbsegundonombre
            // 
            this.Tbsegundonombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.Tbsegundonombre.Location = new System.Drawing.Point(209, 75);
            this.Tbsegundonombre.Name = "Tbsegundonombre";
            this.Tbsegundonombre.Size = new System.Drawing.Size(193, 22);
            this.Tbsegundonombre.TabIndex = 15;
            this.Tbsegundonombre.TextChanged += new System.EventHandler(this.Tbprimernombre_TextChanged);
            this.Tbsegundonombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Tbprimernombre_KeyPress);
            // 
            // Tbcorreo
            // 
            this.Tbcorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.Tbcorreo.Location = new System.Drawing.Point(12, 310);
            this.Tbcorreo.MaxLength = 25;
            this.Tbcorreo.Name = "Tbcorreo";
            this.Tbcorreo.Size = new System.Drawing.Size(193, 22);
            this.Tbcorreo.TabIndex = 14;
            this.Tbcorreo.TextChanged += new System.EventHandler(this.Tbprimernombre_TextChanged);
            // 
            // Tbtelefono
            // 
            this.Tbtelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.Tbtelefono.Location = new System.Drawing.Point(72, 166);
            this.Tbtelefono.MaxLength = 7;
            this.Tbtelefono.Name = "Tbtelefono";
            this.Tbtelefono.Size = new System.Drawing.Size(133, 22);
            this.Tbtelefono.TabIndex = 13;
            this.Tbtelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Tbcedula_KeyPress);
            // 
            // Tbprimerapellido
            // 
            this.Tbprimerapellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.Tbprimerapellido.Location = new System.Drawing.Point(12, 120);
            this.Tbprimerapellido.Name = "Tbprimerapellido";
            this.Tbprimerapellido.Size = new System.Drawing.Size(193, 22);
            this.Tbprimerapellido.TabIndex = 11;
            this.Tbprimerapellido.TextChanged += new System.EventHandler(this.Tbprimernombre_TextChanged);
            this.Tbprimerapellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Tbprimernombre_KeyPress);
            // 
            // Tbsegundoapellido
            // 
            this.Tbsegundoapellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.Tbsegundoapellido.Location = new System.Drawing.Point(209, 120);
            this.Tbsegundoapellido.Name = "Tbsegundoapellido";
            this.Tbsegundoapellido.Size = new System.Drawing.Size(193, 22);
            this.Tbsegundoapellido.TabIndex = 9;
            this.Tbsegundoapellido.TextChanged += new System.EventHandler(this.Tbprimernombre_TextChanged);
            this.Tbsegundoapellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Tbprimernombre_KeyPress);
            // 
            // lblcabecera
            // 
            this.lblcabecera.AutoSize = true;
            this.lblcabecera.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblcabecera.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(24)))), ((int)(((byte)(67)))));
            this.lblcabecera.Location = new System.Drawing.Point(10, 8);
            this.lblcabecera.Name = "lblcabecera";
            this.lblcabecera.Size = new System.Drawing.Size(169, 24);
            this.lblcabecera.TabIndex = 8;
            this.lblcabecera.Text = "Agregar Profesor";
            // 
            // Tbprimernombre
            // 
            this.Tbprimernombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.Tbprimernombre.Location = new System.Drawing.Point(12, 75);
            this.Tbprimernombre.Name = "Tbprimernombre";
            this.Tbprimernombre.Size = new System.Drawing.Size(193, 22);
            this.Tbprimernombre.TabIndex = 0;
            this.Tbprimernombre.TextChanged += new System.EventHandler(this.Tbprimernombre_TextChanged);
            this.Tbprimernombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Tbprimernombre_KeyPress);
            // 
            // Agregarprofesor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 418);
            this.ControlBox = false;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Agregarprofesor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panelcomunes.ResumeLayout(false);
            this.panelcomunes.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private TextBox Tbprimernombre;
        private Button Btncerrar;
        private TextBox Tbsegundonombre;
        private TextBox Tbcorreo;
        private TextBox Tbtelefono;
        private TextBox Tbprimerapellido;
        private TextBox Tbsegundoapellido;
        private ComboBox Cbtipo;
        private Label label12;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label14;
        private TextBox Tbespecialidad;
        private Label label13;
        public TextBox Tbcedula;
        public Button Btnagregar;
        public Label lblcabecera;
        private Label label1;
        private TextBox tbcodigo;
        private Panel panelcomunes;
        public ComboBox Cbsexo;
        public ComboBox Cbescuela;
        public CheckBox comun47;
        public CheckBox comun44;
        public CheckBox comun45;
        public CheckBox comun42;
        public CheckBox comun46;
        public CheckBox comun43;
        public CheckBox comun41;
        public ComboBox Cbprofesion;
    }
}