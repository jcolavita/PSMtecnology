using System.Windows.Forms;

namespace TrabajoDeGrado.Secciones.Estudiantes_y_Profesores.Estudiantes
{
    partial class Solicitarlibro
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
            this.btnagregar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblid = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtdevolucion = new System.Windows.Forms.DateTimePicker();
            this.dtsalida = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.tbeditorial = new System.Windows.Forms.TextBox();
            this.cbmateria = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Btncerrar = new System.Windows.Forms.Button();
            this.tbcota = new System.Windows.Forms.TextBox();
            this.tbtitulo = new System.Windows.Forms.TextBox();
            this.tbautor = new System.Windows.Forms.TextBox();
            this.lblcabecera = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnagregar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 274);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(417, 63);
            this.panel1.TabIndex = 0;
            // 
            // btnagregar
            // 
            this.btnagregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(24)))), ((int)(((byte)(67)))));
            this.btnagregar.Enabled = false;
            this.btnagregar.FlatAppearance.BorderSize = 0;
            this.btnagregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnagregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btnagregar.ForeColor = System.Drawing.Color.White;
            this.btnagregar.Location = new System.Drawing.Point(294, 18);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(103, 35);
            this.btnagregar.TabIndex = 1;
            this.btnagregar.Text = "Solicitar";
            this.btnagregar.UseVisualStyleBackColor = false;
            this.btnagregar.Click += new System.EventHandler(this.Btnagregar_Click_1);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.lblid);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.dtdevolucion);
            this.panel2.Controls.Add(this.dtsalida);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.tbeditorial);
            this.panel2.Controls.Add(this.cbmateria);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.Btncerrar);
            this.panel2.Controls.Add(this.tbcota);
            this.panel2.Controls.Add(this.tbtitulo);
            this.panel2.Controls.Add(this.tbautor);
            this.panel2.Controls.Add(this.lblcabecera);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(417, 274);
            this.panel2.TabIndex = 1;
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Location = new System.Drawing.Point(152, 58);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(44, 16);
            this.lblid.TabIndex = 41;
            this.lblid.Text = "label6";
            this.lblid.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label3.Location = new System.Drawing.Point(120, 219);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 16);
            this.label3.TabIndex = 40;
            this.label3.Text = "Fecha de Devolucion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label2.Location = new System.Drawing.Point(10, 219);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 16);
            this.label2.TabIndex = 39;
            this.label2.Text = "Fecha de Salida";
            // 
            // dtdevolucion
            // 
            this.dtdevolucion.Enabled = false;
            this.dtdevolucion.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtdevolucion.Location = new System.Drawing.Point(120, 236);
            this.dtdevolucion.Name = "dtdevolucion";
            this.dtdevolucion.Size = new System.Drawing.Size(116, 22);
            this.dtdevolucion.TabIndex = 38;
            this.dtdevolucion.Value = new System.DateTime(2023, 6, 1, 0, 0, 0, 0);
            // 
            // dtsalida
            // 
            this.dtsalida.Enabled = false;
            this.dtsalida.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtsalida.Location = new System.Drawing.Point(10, 236);
            this.dtsalida.Name = "dtsalida";
            this.dtsalida.Size = new System.Drawing.Size(91, 22);
            this.dtsalida.TabIndex = 37;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label1.Location = new System.Drawing.Point(10, 173);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 36;
            this.label1.Text = "Editorial";
            // 
            // tbeditorial
            // 
            this.tbeditorial.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.tbeditorial.Location = new System.Drawing.Point(10, 189);
            this.tbeditorial.Name = "tbeditorial";
            this.tbeditorial.ReadOnly = true;
            this.tbeditorial.Size = new System.Drawing.Size(226, 22);
            this.tbeditorial.TabIndex = 35;
            this.tbeditorial.TextChanged += new System.EventHandler(this.tbeditorial_TextChanged);
            // 
            // cbmateria
            // 
            this.cbmateria.Enabled = false;
            this.cbmateria.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.cbmateria.FormattingEnabled = true;
            this.cbmateria.Items.AddRange(new object[] {
            "METODOLOGIA",
            "PROYECTOS",
            "INVESTIGACION DE OPERACIONES",
            "MODELOS ESTOCÁSTICO",
            "QUATTRO PRO",
            "ROBOTICA",
            "INTELIGENCIA ARTIFICIAL",
            "INFORMATICA",
            "PROGRAMACIÓN",
            "MICROSOFT",
            "LOTUS",
            "ACCESS",
            "DISEÑOS",
            "SIMULACIÓN Y CONTROL",
            "TELEINFORMATICA",
            "VISUAL BASIC",
            "VENTURA",
            "ALGORITMOS",
            "PASCAL",
            "NETWARE",
            "ADOBE",
            "UNIX",
            "SISTEMA OPERATIVOS",
            "WINDOWS",
            "DATOS",
            "COPILADORES",
            "AUTOCAD",
            "SISTEMA DE INFORMACIÓN",
            "TEORIA DE SISTEMA",
            "ANALISIS Y DISEÑO",
            "AUDITORIA",
            "INTRODUCCIÓN A LA COMPUTACIÓN",
            "REDES",
            "INTERNET",
            "GUIA DE BIBLIOTECA",
            "BASES DE DATOS",
            "CA-TEXTOR",
            "SISTEMA DIGITALES",
            "ARQUITECTURA DEL COMPUTADOR",
            "ENCICLOPEDIA DE INFORMATICA",
            "FILOSOFIA",
            "PSICOLOGÍA",
            "COMPORTAMIENTO ORGANIZACIONES",
            "AUTOESTIMA",
            "MOTIVACIÓN",
            "LIDERAZGO",
            "ETICA",
            "SOCIOLOGÍA",
            "COMUNICACIÓN",
            "ESTADISTICA",
            "ECONOMIA",
            "DERECHO",
            "CODIGOS CIVIL, COMERCIO Y ELECTRICO NACIONAL",
            "EDUCACIÓN EN VENEZUELA",
            "DINÁMICA",
            "TÉCNICA DE ESTUDIO",
            "SIMÓN BOLÍVAR",
            "VALORES HUMANO",
            "PENSUM",
            "LENGUAJE Y COMUNICACIÓN",
            "CUENTOS Y RELATOS",
            "DICCIONARIO",
            "INGLES",
            "ORTOGRAFÍA",
            "REDACCIÓN",
            "ANALISIS NUMERICO",
            "DICCIONARIO DE MATEMÁTICA\t",
            "FORMULAS TÉCNICAS",
            "MATEMÁTICA FINANCIERA",
            "MATEMÁTICA DISCRETA",
            "MATEMÁTICAS",
            "MATEMÁTICA FINITAS",
            "MATEMÁTICA Y LOGICA",
            "ALGEBRA",
            "ALGEBRA Y TRIGONOMETRIA",
            "ALGEBRA LINEAL",
            "CALCULO",
            "CALCULO INTEGRALES",
            "GEOMETRIA ANALITICA",
            "GEOMETRIA DESCRIPTIVA",
            "SERIES DE FOURIER",
            "ECUACIONES DIFERENCIALES",
            "TRANSFORMADAS DE LA PLACE",
            "MATRICES",
            "PROBABILIDAD",
            "TOPOGRAFIA",
            "FISICA",
            "ELECTRICIDAD",
            "ELECTROMAGNETISMO",
            "ELECTRONICA",
            "EXPERIMENTOS\t",
            "ESTATICAS",
            "MECANICAS DE FLUIDOS",
            "MAQUINAS",
            "TRANASFERENCIA DE CALOR",
            "CUIRCUITOS",
            "CONDUCTORES",
            "FIBRA OPTICA",
            "QUIMICA",
            "MANUAL DE LABORATORIO",
            "ANALISIS DE INSTRUMENTACION",
            "GEOLOGIA",
            "ECOLOGIA",
            "DIBUJO INDUSTRIAL",
            "DIBUJO DE INGENIERIA",
            "DIBUJO TECNICO",
            "NORMAS VENEZOLANAS",
            "NORMAS INDUSTRIALES",
            "INGENIERIA ECONOMICA",
            "INGENIERIA CIVIL",
            "INGENIERIA INDUSTRIAL",
            "INGENIERIA MECANICA\t",
            "INGENIERIA DE MATERIALES",
            "INGENIERIA ELECTRICA",
            "INGENIERIA ELECTRONICA",
            "HISTORIA DE LA INGENIERIA",
            "NGENIERIA QUIMICA",
            "MECANICA DE SOLIDOS ",
            "MECANICA DE ESTATICA",
            "MECANICA DE VECTORIAL",
            "MECANICA DINAMICA\t",
            "MECANICA DE FLUIDOS",
            "MECANICA DE MATERIALES",
            "MECANICA DE SUELOS",
            "RESISTENCIA DE MATERIALES",
            "CONCRETO",
            "HORMIGÓN",
            "ERGONOMIA",
            "HERRAMIENTAS MECÁNICA",
            "BOMBAS",
            "REVELADORES",
            "LINEAS ELECTRICAS",
            "INSTALACIONES ELECTRICA",
            "SISTEMA DE CONTROL",
            "ANALISIS DE SEÑALES Y SISTEMA",
            "AMPLIFICADORES",
            "SISTEMA DE COMUNICACIONES",
            "TERMODINAMICA",
            "MOTORES",
            "ESTRUCTURA DE ACERO",
            "REFRIGERACIÓN",
            "TECNOLOGÍA DE LOS MATERIALES",
            "ESTUDIO DE TRABAJO",
            "INGENIERIA DE METODOS",
            "VALVULAS",
            "SOLDADURA",
            "INGENIERIA CIMENTACIONES",
            "SISMO",
            "ENCOFRADOS",
            "ESTRUCTURA METALICAS",
            "MAMPOSTERIA",
            "MANUAL DE VIDRIO",
            "DISEÑO DE TUNELES",
            "PUENTES",
            "GEOLOGIA",
            "CARRETERAS",
            "PAVIMENTOS",
            "ABASTECIMIENTO DE AGUA",
            "ACUEDUCTO Y CLOACAS",
            "DE HIDRAULICAS",
            "ROBOTICA INDUSTRIAL\t",
            "ENCICLOPEDIA CONTABILIDAD",
            "CONTABILIDAD",
            "FINANZAS",
            "ADMINISTRACION",
            "ADMINISTRACIÓN FINANCIERA",
            "ADMINISTRACIÓN DE LA PRODUCCIÓN\t",
            "ADMINISTRACION PARA INGENIERO",
            "ORGANIZACIÓN\t",
            "RECURSOS HUMANO",
            "TOMA DE DECISIONES",
            "AUDITORIA",
            "EMPRESA",
            "GERENCIA",
            "SEGURIDAD INDUSTRIAL",
            "PLANES DE EMERGENCIA",
            "EMPOWERMENT",
            "GERENCIA UNIVERSITARIA",
            "CALIDAD TOTAL",
            "REINGENIERIA",
            "JUSTIN TIME",
            "VENTAS\t",
            "ISO",
            "PARADIGMAS\t",
            "MERCADOTECNIA",
            "BENCHMARKING",
            "MERCADEO",
            "MARKETING",
            "FRANQUICIAS",
            "PUBLICIDAD",
            "METALURGIA",
            "MANUFACTURA",
            "EDIFICIOS",
            "NCICLOPEDIA DE CONSTRUCCIÓN",
            "CONSTRUCCIÓN",
            "PERFILES ANGULARES",
            "AGUAS\t",
            "SUELOS ",
            "COCINAS",
            "ARQUITECTURA\t",
            "ENCILOPEDIA DE ARQUITECTURA",
            "ESTRUCTURAS PARA ARQUITECTO no esta ",
            "ENCICLOPEDIA INDUSTRIAL",
            "DEPORTE",
            "ANTROPOMETRIA",
            "ARTE",
            "URBANISMO",
            "\"CARTILLA DE URBANISMO, PÚBLICO Y CONSTRUCCIÓN DE MADERA\"",
            "URBANIZACIÓN",
            "SUB-DESARROLLO",
            "CIUDADES",
            "CERCAS Y VELLADOS",
            "CASAS",
            "MUTACIONES",
            "CLIMA",
            "CROSS",
            "DISEÑO DE TEORIA Y FUNDAMENTOS",
            "DISEÑO DE ARQUITECTURA",
            "COLOMBIANA",
            "LIBROS DE CROQUIS",
            "JOSEPH II SERT",
            "ALDO ROSSI",
            "MIES VAN DER ROHE",
            "LIBRONDENOTTO WAGNER",
            "ENTREPISO",
            "LUIS BARRAGAN",
            "ALVAR AALTO",
            "TADAO ANDO",
            "LBOTTA MARIO\t",
            "BOFIA RICARDO",
            "SANTIAGO CALATRAVA",
            "FERNANDO CASTILLO",
            "ESCALA",
            "ANTONI GAUDI",
            "ARNE JACOBSEN",
            "LOUIS KAHN",
            "LE CORBUSIER",
            "MAQUETAS DE ARQUITECTURA",
            "EL MANUAL DE DIBUJO",
            "DIBUJO TÉCNICO ARQUITECTONICO",
            "DIBIJO INDUSTRIAL",
            "DIBIJO DE EXPRESIÓN",
            "FOTOGRAFÍA",
            "PROYECTO Y SEGURIDAD PARA HOSPITALES",
            "DECORACIONES\t",
            "PERIODO HISPANICO",
            "REVESTIMIENTOS",
            "ESCALERA Y TORNEADO",
            "ANALISIS DE FORMA",
            "BARROCO",
            "WALTER GRUPIUS",
            "PISCINA",
            "COMEDORES Y RESTAURANTES\t",
            "COORDINACIÓN MODULAR",
            "MUSICA",
            "MUSEOS",
            "HISTORIA SOCIAL",
            "GUION",
            "CULTURA",
            "GUIA DE VENEZUELA",
            "GEOGRAFÍA"});
            this.cbmateria.Location = new System.Drawing.Point(241, 146);
            this.cbmateria.Name = "cbmateria";
            this.cbmateria.Size = new System.Drawing.Size(157, 24);
            this.cbmateria.TabIndex = 34;
            this.cbmateria.Text = "MATERIA";
            this.cbmateria.TextChanged += new System.EventHandler(this.tbeditorial_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label8.Location = new System.Drawing.Point(10, 42);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 16);
            this.label8.TabIndex = 29;
            this.label8.Text = "Cota";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label5.Location = new System.Drawing.Point(7, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 16);
            this.label5.TabIndex = 26;
            this.label5.Text = "Titulo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label4.Location = new System.Drawing.Point(10, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 16);
            this.label4.TabIndex = 25;
            this.label4.Text = "Autor";
            // 
            // Btncerrar
            // 
            this.Btncerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btncerrar.FlatAppearance.BorderSize = 0;
            this.Btncerrar.Image = global::PSMtecnology.Properties.Resources.cerrar;
            this.Btncerrar.Location = new System.Drawing.Point(384, 11);
            this.Btncerrar.Name = "Btncerrar";
            this.Btncerrar.Size = new System.Drawing.Size(21, 21);
            this.Btncerrar.TabIndex = 20;
            this.Btncerrar.UseVisualStyleBackColor = true;
            this.Btncerrar.Click += new System.EventHandler(this.Btncerrar_Click);
            // 
            // tbcota
            // 
            this.tbcota.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.tbcota.Location = new System.Drawing.Point(10, 58);
            this.tbcota.MaxLength = 10;
            this.tbcota.Name = "tbcota";
            this.tbcota.ReadOnly = true;
            this.tbcota.Size = new System.Drawing.Size(118, 22);
            this.tbcota.TabIndex = 16;
            this.tbcota.TextChanged += new System.EventHandler(this.tbeditorial_TextChanged);
            // 
            // tbtitulo
            // 
            this.tbtitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.tbtitulo.Location = new System.Drawing.Point(10, 102);
            this.tbtitulo.MaxLength = 30;
            this.tbtitulo.Name = "tbtitulo";
            this.tbtitulo.ReadOnly = true;
            this.tbtitulo.Size = new System.Drawing.Size(387, 22);
            this.tbtitulo.TabIndex = 11;
            this.tbtitulo.TextChanged += new System.EventHandler(this.tbeditorial_TextChanged);
            // 
            // tbautor
            // 
            this.tbautor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.tbautor.Location = new System.Drawing.Point(10, 146);
            this.tbautor.MaxLength = 20;
            this.tbautor.Name = "tbautor";
            this.tbautor.ReadOnly = true;
            this.tbautor.Size = new System.Drawing.Size(226, 22);
            this.tbautor.TabIndex = 9;
            this.tbautor.TextChanged += new System.EventHandler(this.tbeditorial_TextChanged);
            // 
            // lblcabecera
            // 
            this.lblcabecera.AutoSize = true;
            this.lblcabecera.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblcabecera.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(24)))), ((int)(((byte)(67)))));
            this.lblcabecera.Location = new System.Drawing.Point(10, 8);
            this.lblcabecera.Name = "lblcabecera";
            this.lblcabecera.Size = new System.Drawing.Size(137, 24);
            this.lblcabecera.TabIndex = 8;
            this.lblcabecera.Text = "Solicitar Libro";
            // 
            // Solicitarlibro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 337);
            this.ControlBox = false;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MaximumSize = new System.Drawing.Size(538, 869);
            this.Name = "Solicitarlibro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Button Btncerrar;
        private TextBox tbtitulo;
        private TextBox tbautor;
        private Label label8;
        private Label label5;
        private Label label4;
        public TextBox tbcota;
        public Label lblcabecera;
        public Button btnagregar;
        private Label label1;
        private TextBox tbeditorial;
        private ComboBox cbmateria;
        private Label label3;
        private Label label2;
        private DateTimePicker dtdevolucion;
        private DateTimePicker dtsalida;
        private Label lblid;
    }
}