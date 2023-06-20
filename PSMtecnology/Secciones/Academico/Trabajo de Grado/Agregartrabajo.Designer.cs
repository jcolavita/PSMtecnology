using System.Windows.Forms;

namespace TrabajoDeGrado.Secciones.Estudiantes_y_Profesores.Estudiantes
{
    partial class Agregartrabajo
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
            this.btnacta = new System.Windows.Forms.Button();
            this.idlabel = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.Label();
            this.Btnagregar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel = new System.Windows.Forms.Panel();
            this.label19 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.cbintento = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.subpanel = new System.Windows.Forms.Panel();
            this.lblfechaproyecto = new System.Windows.Forms.Label();
            this.cbfechaproyecto = new System.Windows.Forms.CheckBox();
            this.label13 = new System.Windows.Forms.Label();
            this.cbfechaservicio = new System.Windows.Forms.CheckBox();
            this.lblfechaservicio = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cbeje = new System.Windows.Forms.ComboBox();
            this.label20 = new System.Windows.Forms.Label();
            this.cbtutor = new System.Windows.Forms.ComboBox();
            this.cblinea = new System.Windows.Forms.ComboBox();
            this.tutoracademico = new System.Windows.Forms.Label();
            this.tbsector = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.tbempresa = new System.Windows.Forms.TextBox();
            this.cbjurado3 = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.cbjurado2 = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.cbjurado1 = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.dtfecha = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.tbseccion = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cbperiodo = new System.Windows.Forms.ComboBox();
            this.tbtitulo = new System.Windows.Forms.RichTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbescuela = new System.Windows.Forms.ComboBox();
            this.btnlimpiar = new System.Windows.Forms.Button();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.tbprimernombre = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Tbsegundonombre = new System.Windows.Forms.TextBox();
            this.Tbprimerapellido = new System.Windows.Forms.TextBox();
            this.Tbsegundoapellido = new System.Windows.Forms.TextBox();
            this.tbcedula = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblcabecera = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.cbestatus = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel.SuspendLayout();
            this.subpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnacta);
            this.panel1.Controls.Add(this.idlabel);
            this.panel1.Controls.Add(this.ID);
            this.panel1.Controls.Add(this.Btnagregar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 582);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(535, 63);
            this.panel1.TabIndex = 0;
            // 
            // btnacta
            // 
            this.btnacta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(24)))), ((int)(((byte)(67)))));
            this.btnacta.FlatAppearance.BorderSize = 0;
            this.btnacta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnacta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btnacta.ForeColor = System.Drawing.Color.White;
            this.btnacta.Location = new System.Drawing.Point(306, 16);
            this.btnacta.Name = "btnacta";
            this.btnacta.Size = new System.Drawing.Size(103, 35);
            this.btnacta.TabIndex = 69;
            this.btnacta.Text = "Generar Acta";
            this.btnacta.UseVisualStyleBackColor = false;
            this.btnacta.Visible = false;
            this.btnacta.Click += new System.EventHandler(this.btnacta_Click);
            // 
            // idlabel
            // 
            this.idlabel.AutoSize = true;
            this.idlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.idlabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(24)))), ((int)(((byte)(67)))));
            this.idlabel.Location = new System.Drawing.Point(15, 25);
            this.idlabel.Name = "idlabel";
            this.idlabel.Size = new System.Drawing.Size(35, 24);
            this.idlabel.TabIndex = 42;
            this.idlabel.Text = "ID:";
            this.idlabel.Visible = false;
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.ID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(24)))), ((int)(((byte)(67)))));
            this.ID.Location = new System.Drawing.Point(50, 25);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(52, 24);
            this.ID.TabIndex = 41;
            this.ID.Text = "ID:id";
            this.ID.Visible = false;
            // 
            // Btnagregar
            // 
            this.Btnagregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(24)))), ((int)(((byte)(67)))));
            this.Btnagregar.Enabled = false;
            this.Btnagregar.FlatAppearance.BorderSize = 0;
            this.Btnagregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btnagregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.Btnagregar.ForeColor = System.Drawing.Color.White;
            this.Btnagregar.Location = new System.Drawing.Point(415, 14);
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
            this.panel2.Controls.Add(this.panel);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.cbescuela);
            this.panel2.Controls.Add(this.btnlimpiar);
            this.panel2.Controls.Add(this.btnbuscar);
            this.panel2.Controls.Add(this.tbprimernombre);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.Tbsegundonombre);
            this.panel2.Controls.Add(this.Tbprimerapellido);
            this.panel2.Controls.Add(this.Tbsegundoapellido);
            this.panel2.Controls.Add(this.tbcedula);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.lblcabecera);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(535, 582);
            this.panel2.TabIndex = 1;
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.White;
            this.panel.Controls.Add(this.label21);
            this.panel.Controls.Add(this.label19);
            this.panel.Controls.Add(this.cbestatus);
            this.panel.Controls.Add(this.label17);
            this.panel.Controls.Add(this.label18);
            this.panel.Controls.Add(this.cbintento);
            this.panel.Controls.Add(this.label1);
            this.panel.Controls.Add(this.subpanel);
            this.panel.Controls.Add(this.cbeje);
            this.panel.Controls.Add(this.label20);
            this.panel.Controls.Add(this.cbtutor);
            this.panel.Controls.Add(this.cblinea);
            this.panel.Controls.Add(this.tutoracademico);
            this.panel.Controls.Add(this.tbsector);
            this.panel.Controls.Add(this.label16);
            this.panel.Controls.Add(this.tbempresa);
            this.panel.Controls.Add(this.cbjurado3);
            this.panel.Controls.Add(this.label15);
            this.panel.Controls.Add(this.cbjurado2);
            this.panel.Controls.Add(this.label14);
            this.panel.Controls.Add(this.cbjurado1);
            this.panel.Controls.Add(this.label12);
            this.panel.Controls.Add(this.dtfecha);
            this.panel.Controls.Add(this.label11);
            this.panel.Controls.Add(this.tbseccion);
            this.panel.Controls.Add(this.label10);
            this.panel.Controls.Add(this.cbperiodo);
            this.panel.Controls.Add(this.tbtitulo);
            this.panel.Controls.Add(this.label9);
            this.panel.Enabled = false;
            this.panel.Location = new System.Drawing.Point(14, 203);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(510, 378);
            this.panel.TabIndex = 40;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label19.Location = new System.Drawing.Point(275, 188);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(46, 16);
            this.label19.TabIndex = 80;
            this.label19.Text = "Sector";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label17.Location = new System.Drawing.Point(316, 137);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(46, 16);
            this.label17.TabIndex = 63;
            this.label17.Text = "Intento";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label18.Location = new System.Drawing.Point(273, 234);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(62, 16);
            this.label18.TabIndex = 79;
            this.label18.Text = "Empresa";
            // 
            // cbintento
            // 
            this.cbintento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbintento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.cbintento.FormattingEnabled = true;
            this.cbintento.Items.AddRange(new object[] {
            "1º",
            "2º",
            "3º",
            "4º",
            "5º",
            "6º",
            "7º",
            "8º",
            "9º",
            "10º",
            "11º",
            "12º",
            "13º",
            "14º",
            "15º",
            "16º",
            "17º",
            "18º",
            "19º",
            "20º"});
            this.cbintento.Location = new System.Drawing.Point(317, 153);
            this.cbintento.Name = "cbintento";
            this.cbintento.Size = new System.Drawing.Size(55, 24);
            this.cbintento.TabIndex = 62;
            this.cbintento.TextChanged += new System.EventHandler(this.citutor_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label1.Location = new System.Drawing.Point(274, 329);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 16);
            this.label1.TabIndex = 78;
            this.label1.Text = "Eje Tematico";
            // 
            // subpanel
            // 
            this.subpanel.Controls.Add(this.lblfechaproyecto);
            this.subpanel.Controls.Add(this.cbfechaproyecto);
            this.subpanel.Controls.Add(this.label13);
            this.subpanel.Controls.Add(this.cbfechaservicio);
            this.subpanel.Controls.Add(this.lblfechaservicio);
            this.subpanel.Controls.Add(this.label8);
            this.subpanel.Location = new System.Drawing.Point(1, 0);
            this.subpanel.Name = "subpanel";
            this.subpanel.Size = new System.Drawing.Size(509, 53);
            this.subpanel.TabIndex = 61;
            // 
            // lblfechaproyecto
            // 
            this.lblfechaproyecto.AutoSize = true;
            this.lblfechaproyecto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lblfechaproyecto.Location = new System.Drawing.Point(196, 31);
            this.lblfechaproyecto.Name = "lblfechaproyecto";
            this.lblfechaproyecto.Size = new System.Drawing.Size(10, 16);
            this.lblfechaproyecto.TabIndex = 58;
            this.lblfechaproyecto.Text = ".";
            // 
            // cbfechaproyecto
            // 
            this.cbfechaproyecto.AutoSize = true;
            this.cbfechaproyecto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.cbfechaproyecto.Location = new System.Drawing.Point(243, 30);
            this.cbfechaproyecto.Name = "cbfechaproyecto";
            this.cbfechaproyecto.Size = new System.Drawing.Size(260, 20);
            this.cbfechaproyecto.TabIndex = 45;
            this.cbfechaproyecto.Text = "Ha cursado proyecto de investigacion?";
            this.cbfechaproyecto.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label13.Location = new System.Drawing.Point(25, 31);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(165, 16);
            this.label13.TabIndex = 44;
            this.label13.Text = "Proyecto de Investigacion:";
            // 
            // cbfechaservicio
            // 
            this.cbfechaservicio.AutoSize = true;
            this.cbfechaservicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.cbfechaservicio.Location = new System.Drawing.Point(278, 5);
            this.cbfechaservicio.Name = "cbfechaservicio";
            this.cbfechaservicio.Size = new System.Drawing.Size(225, 20);
            this.cbfechaservicio.TabIndex = 43;
            this.cbfechaservicio.Text = "Ha cursado servicio comunitario?";
            this.cbfechaservicio.UseVisualStyleBackColor = true;
            // 
            // lblfechaservicio
            // 
            this.lblfechaservicio.AutoSize = true;
            this.lblfechaservicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lblfechaservicio.Location = new System.Drawing.Point(164, 9);
            this.lblfechaservicio.Name = "lblfechaservicio";
            this.lblfechaservicio.Size = new System.Drawing.Size(10, 16);
            this.lblfechaservicio.TabIndex = 42;
            this.lblfechaservicio.Text = ".";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label8.Location = new System.Drawing.Point(25, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(133, 16);
            this.label8.TabIndex = 41;
            this.label8.Text = "Servicio Comunitario:";
            // 
            // cbeje
            // 
            this.cbeje.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbeje.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.cbeje.FormattingEnabled = true;
            this.cbeje.Location = new System.Drawing.Point(274, 346);
            this.cbeje.Name = "cbeje";
            this.cbeje.Size = new System.Drawing.Size(211, 24);
            this.cbeje.TabIndex = 77;
            this.cbeje.TextChanged += new System.EventHandler(this.cblinea_TextChanged);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label20.Location = new System.Drawing.Point(274, 282);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(141, 16);
            this.label20.TabIndex = 76;
            this.label20.Text = "Linea de investigacion";
            this.label20.Click += new System.EventHandler(this.label20_Click);
            // 
            // cbtutor
            // 
            this.cbtutor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbtutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.cbtutor.FormattingEnabled = true;
            this.cbtutor.Location = new System.Drawing.Point(25, 346);
            this.cbtutor.Name = "cbtutor";
            this.cbtutor.Size = new System.Drawing.Size(211, 24);
            this.cbtutor.TabIndex = 60;
            this.cbtutor.TextChanged += new System.EventHandler(this.citutor_TextChanged);
            // 
            // cblinea
            // 
            this.cblinea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cblinea.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.cblinea.FormattingEnabled = true;
            this.cblinea.Location = new System.Drawing.Point(274, 298);
            this.cblinea.Name = "cblinea";
            this.cblinea.Size = new System.Drawing.Size(211, 24);
            this.cblinea.TabIndex = 75;
            this.cblinea.SelectedIndexChanged += new System.EventHandler(this.cblinea_SelectedIndexChanged);
            this.cblinea.TextChanged += new System.EventHandler(this.cblinea_TextChanged);
            // 
            // tutoracademico
            // 
            this.tutoracademico.AutoSize = true;
            this.tutoracademico.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.tutoracademico.Location = new System.Drawing.Point(26, 329);
            this.tutoracademico.Name = "tutoracademico";
            this.tutoracademico.Size = new System.Drawing.Size(110, 16);
            this.tutoracademico.TabIndex = 59;
            this.tutoracademico.Text = "Tutor Academico";
            // 
            // tbsector
            // 
            this.tbsector.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.tbsector.Location = new System.Drawing.Point(275, 205);
            this.tbsector.MaxLength = 10;
            this.tbsector.Name = "tbsector";
            this.tbsector.Size = new System.Drawing.Size(211, 22);
            this.tbsector.TabIndex = 74;
            this.tbsector.TextChanged += new System.EventHandler(this.tbsector_TextChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label16.Location = new System.Drawing.Point(25, 282);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(124, 16);
            this.label16.TabIndex = 57;
            this.label16.Text = "Jurado Evaluador 3";
            // 
            // tbempresa
            // 
            this.tbempresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.tbempresa.Location = new System.Drawing.Point(275, 250);
            this.tbempresa.MaxLength = 10;
            this.tbempresa.Name = "tbempresa";
            this.tbempresa.Size = new System.Drawing.Size(211, 22);
            this.tbempresa.TabIndex = 73;
            this.tbempresa.TextChanged += new System.EventHandler(this.tbsector_TextChanged);
            // 
            // cbjurado3
            // 
            this.cbjurado3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbjurado3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.cbjurado3.FormattingEnabled = true;
            this.cbjurado3.Location = new System.Drawing.Point(26, 298);
            this.cbjurado3.Name = "cbjurado3";
            this.cbjurado3.Size = new System.Drawing.Size(211, 24);
            this.cbjurado3.TabIndex = 56;
            this.cbjurado3.TextChanged += new System.EventHandler(this.citutor_TextChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label15.Location = new System.Drawing.Point(26, 234);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(124, 16);
            this.label15.TabIndex = 55;
            this.label15.Text = "Jurado Evaluador 2";
            // 
            // cbjurado2
            // 
            this.cbjurado2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbjurado2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.cbjurado2.FormattingEnabled = true;
            this.cbjurado2.Location = new System.Drawing.Point(26, 250);
            this.cbjurado2.Name = "cbjurado2";
            this.cbjurado2.Size = new System.Drawing.Size(211, 24);
            this.cbjurado2.TabIndex = 54;
            this.cbjurado2.TextChanged += new System.EventHandler(this.citutor_TextChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label14.Location = new System.Drawing.Point(25, 186);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(124, 16);
            this.label14.TabIndex = 53;
            this.label14.Text = "Jurado Evaluador 1";
            // 
            // cbjurado1
            // 
            this.cbjurado1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbjurado1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.cbjurado1.FormattingEnabled = true;
            this.cbjurado1.Location = new System.Drawing.Point(26, 203);
            this.cbjurado1.Name = "cbjurado1";
            this.cbjurado1.Size = new System.Drawing.Size(211, 24);
            this.cbjurado1.TabIndex = 52;
            this.cbjurado1.TextChanged += new System.EventHandler(this.citutor_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label12.Location = new System.Drawing.Point(189, 136);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(58, 16);
            this.label12.TabIndex = 51;
            this.label12.Text = "Defensa";
            // 
            // dtfecha
            // 
            this.dtfecha.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.dtfecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.dtfecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtfecha.Location = new System.Drawing.Point(188, 155);
            this.dtfecha.Name = "dtfecha";
            this.dtfecha.Size = new System.Drawing.Size(125, 22);
            this.dtfecha.TabIndex = 50;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label11.Location = new System.Drawing.Point(131, 137);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(56, 16);
            this.label11.TabIndex = 49;
            this.label11.Text = "Seccion";
            // 
            // tbseccion
            // 
            this.tbseccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.tbseccion.Location = new System.Drawing.Point(134, 155);
            this.tbseccion.MaxLength = 2;
            this.tbseccion.Name = "tbseccion";
            this.tbseccion.Size = new System.Drawing.Size(49, 22);
            this.tbseccion.TabIndex = 48;
            this.tbseccion.TextChanged += new System.EventHandler(this.tbseccion_TextChanged);
            this.tbseccion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbprimernombre_KeyPress_1);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label10.Location = new System.Drawing.Point(25, 137);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 16);
            this.label10.TabIndex = 47;
            this.label10.Text = "Periodo";
            // 
            // cbperiodo
            // 
            this.cbperiodo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbperiodo.Enabled = false;
            this.cbperiodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.cbperiodo.FormattingEnabled = true;
            this.cbperiodo.Location = new System.Drawing.Point(26, 153);
            this.cbperiodo.Name = "cbperiodo";
            this.cbperiodo.Size = new System.Drawing.Size(103, 24);
            this.cbperiodo.TabIndex = 46;
            this.cbperiodo.TextChanged += new System.EventHandler(this.citutor_TextChanged);
            // 
            // tbtitulo
            // 
            this.tbtitulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbtitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.tbtitulo.Location = new System.Drawing.Point(26, 75);
            this.tbtitulo.MaxLength = 150;
            this.tbtitulo.Name = "tbtitulo";
            this.tbtitulo.Size = new System.Drawing.Size(461, 51);
            this.tbtitulo.TabIndex = 45;
            this.tbtitulo.Text = "";
            this.tbtitulo.TextChanged += new System.EventHandler(this.tbtitulo_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label9.Location = new System.Drawing.Point(26, 59);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 16);
            this.label9.TabIndex = 44;
            this.label9.Text = "Titulo";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label7.Location = new System.Drawing.Point(353, 161);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 16);
            this.label7.TabIndex = 39;
            this.label7.Text = "Escuela";
            // 
            // cbescuela
            // 
            this.cbescuela.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbescuela.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.cbescuela.FormattingEnabled = true;
            this.cbescuela.Items.AddRange(new object[] {
            "ARQUITECTURA (41)",
            "INGENIERÍA CIVIL (42)",
            "INGENIERÍA ELÉCTRICA (43)",
            "INGENIERÍA ELECTRÓNICA (44)",
            "INGENIERÍA INDUSTRIAL (45)",
            "INGENIERÍA DE MTTO. MECÁNICO (46)",
            "INGENIERÍA DE SISTEMAS (47)"});
            this.cbescuela.Location = new System.Drawing.Point(353, 178);
            this.cbescuela.Name = "cbescuela";
            this.cbescuela.Size = new System.Drawing.Size(165, 24);
            this.cbescuela.TabIndex = 38;
            this.cbescuela.SelectedIndexChanged += new System.EventHandler(this.cbescuela_SelectedIndexChanged);
            this.cbescuela.TextChanged += new System.EventHandler(this.citutor_TextChanged);
            // 
            // btnlimpiar
            // 
            this.btnlimpiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnlimpiar.FlatAppearance.BorderSize = 0;
            this.btnlimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnlimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btnlimpiar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(24)))), ((int)(((byte)(67)))));
            this.btnlimpiar.Location = new System.Drawing.Point(214, 65);
            this.btnlimpiar.Name = "btnlimpiar";
            this.btnlimpiar.Size = new System.Drawing.Size(66, 38);
            this.btnlimpiar.TabIndex = 37;
            this.btnlimpiar.Text = "Limpiar";
            this.btnlimpiar.UseVisualStyleBackColor = true;
            this.btnlimpiar.Click += new System.EventHandler(this.btnlimpiar_Click);
            // 
            // btnbuscar
            // 
            this.btnbuscar.FlatAppearance.BorderSize = 0;
            this.btnbuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnbuscar.Image = global::PSMtecnology.Properties.Resources.lupa;
            this.btnbuscar.Location = new System.Drawing.Point(186, 74);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(21, 21);
            this.btnbuscar.TabIndex = 36;
            this.btnbuscar.UseVisualStyleBackColor = true;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // tbprimernombre
            // 
            this.tbprimernombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.tbprimernombre.Location = new System.Drawing.Point(14, 126);
            this.tbprimernombre.MaxLength = 10;
            this.tbprimernombre.Name = "tbprimernombre";
            this.tbprimernombre.Size = new System.Drawing.Size(165, 22);
            this.tbprimernombre.TabIndex = 35;
            this.tbprimernombre.TextChanged += new System.EventHandler(this.tbprimernombre_TextChanged);
            this.tbprimernombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbprimernombre_KeyPress_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label5.Location = new System.Drawing.Point(14, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 16);
            this.label5.TabIndex = 34;
            this.label5.Text = "Primer Apellido";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label4.Location = new System.Drawing.Point(183, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 16);
            this.label4.TabIndex = 33;
            this.label4.Text = "Segundo Apellido";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label3.Location = new System.Drawing.Point(183, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 16);
            this.label3.TabIndex = 32;
            this.label3.Text = "Segundo Nombre";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label6.Location = new System.Drawing.Point(14, 109);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 16);
            this.label6.TabIndex = 31;
            this.label6.Text = "Primer Nombre";
            // 
            // Tbsegundonombre
            // 
            this.Tbsegundonombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.Tbsegundonombre.Location = new System.Drawing.Point(183, 126);
            this.Tbsegundonombre.MaxLength = 15;
            this.Tbsegundonombre.Name = "Tbsegundonombre";
            this.Tbsegundonombre.Size = new System.Drawing.Size(165, 22);
            this.Tbsegundonombre.TabIndex = 30;
            this.Tbsegundonombre.TextChanged += new System.EventHandler(this.Tbsegundonombre_TextChanged);
            this.Tbsegundonombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbprimernombre_KeyPress_1);
            // 
            // Tbprimerapellido
            // 
            this.Tbprimerapellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.Tbprimerapellido.Location = new System.Drawing.Point(14, 178);
            this.Tbprimerapellido.MaxLength = 10;
            this.Tbprimerapellido.Name = "Tbprimerapellido";
            this.Tbprimerapellido.Size = new System.Drawing.Size(165, 22);
            this.Tbprimerapellido.TabIndex = 29;
            this.Tbprimerapellido.TextChanged += new System.EventHandler(this.Tbprimerapellido_TextChanged);
            this.Tbprimerapellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbprimernombre_KeyPress_1);
            // 
            // Tbsegundoapellido
            // 
            this.Tbsegundoapellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.Tbsegundoapellido.Location = new System.Drawing.Point(183, 178);
            this.Tbsegundoapellido.MaxLength = 15;
            this.Tbsegundoapellido.Name = "Tbsegundoapellido";
            this.Tbsegundoapellido.Size = new System.Drawing.Size(165, 22);
            this.Tbsegundoapellido.TabIndex = 28;
            this.Tbsegundoapellido.TextChanged += new System.EventHandler(this.Tbsegundoapellido_TextChanged);
            this.Tbsegundoapellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbprimernombre_KeyPress_1);
            // 
            // tbcedula
            // 
            this.tbcedula.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.tbcedula.Location = new System.Drawing.Point(14, 74);
            this.tbcedula.MaxLength = 8;
            this.tbcedula.Name = "tbcedula";
            this.tbcedula.Size = new System.Drawing.Size(165, 22);
            this.tbcedula.TabIndex = 22;
            this.tbcedula.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbcedula_KeyPress_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label2.Location = new System.Drawing.Point(14, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 16);
            this.label2.TabIndex = 21;
            this.label2.Text = "Cedula del Estudiante";
            // 
            // lblcabecera
            // 
            this.lblcabecera.AutoSize = true;
            this.lblcabecera.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblcabecera.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(24)))), ((int)(((byte)(67)))));
            this.lblcabecera.Location = new System.Drawing.Point(10, 8);
            this.lblcabecera.Name = "lblcabecera";
            this.lblcabecera.Size = new System.Drawing.Size(255, 24);
            this.lblcabecera.TabIndex = 8;
            this.lblcabecera.Text = "Agregar Trabajo de Grado";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label21.Location = new System.Drawing.Point(375, 136);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(51, 16);
            this.label21.TabIndex = 76;
            this.label21.Text = "Estatus";
            // 
            // cbestatus
            // 
            this.cbestatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbestatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.cbestatus.FormattingEnabled = true;
            this.cbestatus.Items.AddRange(new object[] {
            "N/D",
            "REPROBADO",
            "DIFERIDO"});
            this.cbestatus.Location = new System.Drawing.Point(378, 153);
            this.cbestatus.Name = "cbestatus";
            this.cbestatus.Size = new System.Drawing.Size(98, 24);
            this.cbestatus.TabIndex = 75;
            // 
            // Agregartrabajo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 645);
            this.ControlBox = false;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(535, 645);
            this.MinimumSize = new System.Drawing.Size(535, 645);
            this.Name = "Agregartrabajo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.subpanel.ResumeLayout(false);
            this.subpanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label6;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label16;
        private ComboBox cbjurado3;
        private Label label15;
        private ComboBox cbjurado2;
        private Label label14;
        private ComboBox cbjurado1;
        private Label label12;
        private DateTimePicker dtfecha;
        private Label label11;
        private TextBox tbseccion;
        private Label label10;
        public RichTextBox tbtitulo;
        public Panel panel;
        public Button btnlimpiar;
        public Button btnbuscar;
        private ComboBox cbtutor;
        private Label tutoracademico;
        private Label label13;
        public Label ID;
        public TextBox tbcedula;
        public Panel panel2;
        public TextBox tbprimernombre;
        public TextBox Tbsegundonombre;
        public TextBox Tbprimerapellido;
        public TextBox Tbsegundoapellido;
        public ComboBox cbescuela;
        public Panel subpanel;
        private Label label17;
        public CheckBox cbfechaservicio;
        public CheckBox cbfechaproyecto;
        public Button Btnagregar;
        public Label lblcabecera;
        public Label lblfechaservicio;
        public Label lblfechaproyecto;
        public ComboBox cbintento;
        public Label idlabel;
        private Label label19;
        private Label label18;
        private Label label1;
        private ComboBox cbeje;
        private Label label20;
        private ComboBox cblinea;
        public TextBox tbsector;
        public TextBox tbempresa;
        public ComboBox cbperiodo;
        public Button btnacta;
        private Label label21;
        public ComboBox cbestatus;
    }
}