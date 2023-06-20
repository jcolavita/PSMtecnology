using System.Windows.Forms;

namespace TrabajoDeGrado.Secciones.Estudiantes_y_Profesores.Estudiantes
{
    partial class reservararea
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
            this.label8 = new System.Windows.Forms.Label();
            this.btnfinalizar = new System.Windows.Forms.Button();
            this.id = new System.Windows.Forms.Label();
            this.btnreservar = new System.Windows.Forms.Button();
            this.lblcabecera = new System.Windows.Forms.Label();
            this.tbsecciones = new System.Windows.Forms.TextBox();
            this.tbcatedras = new System.Windows.Forms.TextBox();
            this.Btncerrar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lbltitulo = new System.Windows.Forms.Label();
            this.dtfecha = new System.Windows.Forms.DateTimePicker();
            this.dthorainicio = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.lblfechaestipulada = new System.Windows.Forms.Label();
            this.dthorafinal = new System.Windows.Forms.DateTimePicker();
            this.lblfechaactual = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.cbdifusion = new System.Windows.Forms.CheckBox();
            this.cbsonido = new System.Windows.Forms.CheckBox();
            this.cbmicrofono = new System.Windows.Forms.CheckBox();
            this.cbpc = new System.Windows.Forms.CheckBox();
            this.cbproyector = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Cbescuela = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbproposito = new System.Windows.Forms.RichTextBox();
            this.tbnombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbusuario = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.btnfinalizar);
            this.panel1.Controls.Add(this.id);
            this.panel1.Controls.Add(this.btnreservar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 287);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(507, 63);
            this.panel1.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(24)))), ((int)(((byte)(67)))));
            this.label8.Location = new System.Drawing.Point(10, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(149, 24);
            this.label8.TabIndex = 43;
            this.label8.Text = "Reservacion #:";
            this.label8.Visible = false;
            // 
            // btnfinalizar
            // 
            this.btnfinalizar.BackColor = System.Drawing.Color.Transparent;
            this.btnfinalizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnfinalizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btnfinalizar.ForeColor = System.Drawing.Color.Black;
            this.btnfinalizar.Location = new System.Drawing.Point(286, 23);
            this.btnfinalizar.Name = "btnfinalizar";
            this.btnfinalizar.Size = new System.Drawing.Size(86, 24);
            this.btnfinalizar.TabIndex = 42;
            this.btnfinalizar.Text = "Finalizar";
            this.btnfinalizar.UseVisualStyleBackColor = false;
            this.btnfinalizar.Visible = false;
            this.btnfinalizar.Click += new System.EventHandler(this.btnfinalizar_Click);
            // 
            // id
            // 
            this.id.AutoSize = true;
            this.id.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.id.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(24)))), ((int)(((byte)(67)))));
            this.id.Location = new System.Drawing.Point(143, 23);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(54, 24);
            this.id.TabIndex = 41;
            this.id.Text = "8888";
            this.id.Visible = false;
            // 
            // btnreservar
            // 
            this.btnreservar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(24)))), ((int)(((byte)(67)))));
            this.btnreservar.FlatAppearance.BorderSize = 0;
            this.btnreservar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnreservar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btnreservar.ForeColor = System.Drawing.Color.White;
            this.btnreservar.Location = new System.Drawing.Point(377, 13);
            this.btnreservar.Name = "btnreservar";
            this.btnreservar.Size = new System.Drawing.Size(103, 35);
            this.btnreservar.TabIndex = 1;
            this.btnreservar.Text = "Reservar";
            this.btnreservar.UseVisualStyleBackColor = false;
            this.btnreservar.Click += new System.EventHandler(this.Btnagregar_Click_1);
            // 
            // lblcabecera
            // 
            this.lblcabecera.AutoSize = true;
            this.lblcabecera.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblcabecera.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(24)))), ((int)(((byte)(67)))));
            this.lblcabecera.Location = new System.Drawing.Point(10, 8);
            this.lblcabecera.Name = "lblcabecera";
            this.lblcabecera.Size = new System.Drawing.Size(93, 24);
            this.lblcabecera.TabIndex = 8;
            this.lblcabecera.Text = "Reservar";
            // 
            // tbsecciones
            // 
            this.tbsecciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.tbsecciones.Location = new System.Drawing.Point(10, 136);
            this.tbsecciones.MaxLength = 20;
            this.tbsecciones.Name = "tbsecciones";
            this.tbsecciones.Size = new System.Drawing.Size(92, 22);
            this.tbsecciones.TabIndex = 9;
            this.tbsecciones.TextChanged += new System.EventHandler(this.tbproposito_TextChanged);
            // 
            // tbcatedras
            // 
            this.tbcatedras.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.tbcatedras.Location = new System.Drawing.Point(10, 95);
            this.tbcatedras.MaxLength = 50;
            this.tbcatedras.Name = "tbcatedras";
            this.tbcatedras.Size = new System.Drawing.Size(470, 22);
            this.tbcatedras.TabIndex = 11;
            this.tbcatedras.TextChanged += new System.EventHandler(this.tbproposito_TextChanged);
            // 
            // Btncerrar
            // 
            this.Btncerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btncerrar.FlatAppearance.BorderSize = 0;
            this.Btncerrar.Image = global::PSMtecnology.Properties.Resources.cerrar;
            this.Btncerrar.Location = new System.Drawing.Point(474, 11);
            this.Btncerrar.Name = "Btncerrar";
            this.Btncerrar.Size = new System.Drawing.Size(21, 21);
            this.Btncerrar.TabIndex = 20;
            this.Btncerrar.UseVisualStyleBackColor = true;
            this.Btncerrar.Click += new System.EventHandler(this.Btncerrar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label4.Location = new System.Drawing.Point(10, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 16);
            this.label4.TabIndex = 25;
            this.label4.Text = "Secciones";
            // 
            // lbltitulo
            // 
            this.lbltitulo.AutoSize = true;
            this.lbltitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lbltitulo.Location = new System.Drawing.Point(10, 78);
            this.lbltitulo.Name = "lbltitulo";
            this.lbltitulo.Size = new System.Drawing.Size(62, 16);
            this.lbltitulo.TabIndex = 26;
            this.lbltitulo.Text = "Catedras";
            // 
            // dtfecha
            // 
            this.dtfecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtfecha.Location = new System.Drawing.Point(10, 52);
            this.dtfecha.Name = "dtfecha";
            this.dtfecha.Size = new System.Drawing.Size(91, 22);
            this.dtfecha.TabIndex = 37;
            this.dtfecha.ValueChanged += new System.EventHandler(this.dtfecha_ValueChanged);
            // 
            // dthorainicio
            // 
            this.dthorainicio.Enabled = false;
            this.dthorainicio.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dthorainicio.Location = new System.Drawing.Point(113, 52);
            this.dthorainicio.Name = "dthorainicio";
            this.dthorainicio.Size = new System.Drawing.Size(116, 22);
            this.dthorainicio.TabIndex = 38;
            this.dthorainicio.Value = new System.DateTime(2023, 6, 1, 0, 0, 0, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label2.Location = new System.Drawing.Point(10, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 16);
            this.label2.TabIndex = 39;
            this.label2.Text = "Fecha";
            // 
            // lblfechaestipulada
            // 
            this.lblfechaestipulada.AutoSize = true;
            this.lblfechaestipulada.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lblfechaestipulada.Location = new System.Drawing.Point(113, 35);
            this.lblfechaestipulada.Name = "lblfechaestipulada";
            this.lblfechaestipulada.Size = new System.Drawing.Size(125, 16);
            this.lblfechaestipulada.TabIndex = 40;
            this.lblfechaestipulada.Text = "Hora de inicio (24H)";
            // 
            // dthorafinal
            // 
            this.dthorafinal.CalendarTitleBackColor = System.Drawing.SystemColors.ControlText;
            this.dthorafinal.CalendarTitleForeColor = System.Drawing.Color.Red;
            this.dthorafinal.Enabled = false;
            this.dthorafinal.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dthorafinal.Location = new System.Drawing.Point(256, 52);
            this.dthorafinal.Name = "dthorafinal";
            this.dthorafinal.Size = new System.Drawing.Size(116, 22);
            this.dthorafinal.TabIndex = 41;
            this.dthorafinal.Value = new System.DateTime(2023, 6, 1, 0, 0, 0, 0);
            this.dthorafinal.ValueChanged += new System.EventHandler(this.dthorafinal_ValueChanged);
            // 
            // lblfechaactual
            // 
            this.lblfechaactual.AutoSize = true;
            this.lblfechaactual.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lblfechaactual.ForeColor = System.Drawing.Color.Black;
            this.lblfechaactual.Location = new System.Drawing.Point(253, 33);
            this.lblfechaactual.Name = "lblfechaactual";
            this.lblfechaactual.Size = new System.Drawing.Size(146, 16);
            this.lblfechaactual.TabIndex = 42;
            this.lblfechaactual.Text = "Hora Finalizacion (24H)";
            this.lblfechaactual.Click += new System.EventHandler(this.lblfechaactual_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.cbdifusion);
            this.panel2.Controls.Add(this.cbsonido);
            this.panel2.Controls.Add(this.cbmicrofono);
            this.panel2.Controls.Add(this.cbpc);
            this.panel2.Controls.Add(this.cbproyector);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.Cbescuela);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.tbproposito);
            this.panel2.Controls.Add(this.tbnombre);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.tbusuario);
            this.panel2.Controls.Add(this.lblfechaactual);
            this.panel2.Controls.Add(this.dthorafinal);
            this.panel2.Controls.Add(this.lblfechaestipulada);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.dthorainicio);
            this.panel2.Controls.Add(this.dtfecha);
            this.panel2.Controls.Add(this.lbltitulo);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.Btncerrar);
            this.panel2.Controls.Add(this.tbcatedras);
            this.panel2.Controls.Add(this.tbsecciones);
            this.panel2.Controls.Add(this.lblcabecera);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(507, 287);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label7.Location = new System.Drawing.Point(348, 120);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 16);
            this.label7.TabIndex = 59;
            this.label7.Text = "Requerimientos";
            // 
            // cbdifusion
            // 
            this.cbdifusion.AutoSize = true;
            this.cbdifusion.Location = new System.Drawing.Point(303, 184);
            this.cbdifusion.Name = "cbdifusion";
            this.cbdifusion.Size = new System.Drawing.Size(182, 20);
            this.cbdifusion.TabIndex = 58;
            this.cbdifusion.Text = "Departamento de Difusion";
            this.cbdifusion.UseVisualStyleBackColor = true;
            // 
            // cbsonido
            // 
            this.cbsonido.AutoSize = true;
            this.cbsonido.Location = new System.Drawing.Point(394, 160);
            this.cbsonido.Name = "cbsonido";
            this.cbsonido.Size = new System.Drawing.Size(69, 20);
            this.cbsonido.TabIndex = 57;
            this.cbsonido.Text = "Sonido";
            this.cbsonido.UseVisualStyleBackColor = true;
            this.cbsonido.CheckedChanged += new System.EventHandler(this.cbsonido_CheckedChanged);
            // 
            // cbmicrofono
            // 
            this.cbmicrofono.AutoSize = true;
            this.cbmicrofono.Location = new System.Drawing.Point(303, 160);
            this.cbmicrofono.Name = "cbmicrofono";
            this.cbmicrofono.Size = new System.Drawing.Size(85, 20);
            this.cbmicrofono.TabIndex = 56;
            this.cbmicrofono.Text = "Microfono";
            this.cbmicrofono.UseVisualStyleBackColor = true;
            // 
            // cbpc
            // 
            this.cbpc.AutoSize = true;
            this.cbpc.Location = new System.Drawing.Point(393, 138);
            this.cbpc.Name = "cbpc";
            this.cbpc.Size = new System.Drawing.Size(100, 20);
            this.cbpc.TabIndex = 55;
            this.cbpc.Text = "Computador";
            this.cbpc.UseVisualStyleBackColor = true;
            // 
            // cbproyector
            // 
            this.cbproyector.AutoSize = true;
            this.cbproyector.Location = new System.Drawing.Point(303, 138);
            this.cbproyector.Name = "cbproyector";
            this.cbproyector.Size = new System.Drawing.Size(84, 20);
            this.cbproyector.TabIndex = 54;
            this.cbproyector.Text = "Proyector";
            this.cbproyector.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label3.Location = new System.Drawing.Point(116, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 16);
            this.label3.TabIndex = 53;
            this.label3.Text = "Docente";
            // 
            // Cbescuela
            // 
            this.Cbescuela.DropDownHeight = 115;
            this.Cbescuela.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cbescuela.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.Cbescuela.FormattingEnabled = true;
            this.Cbescuela.IntegralHeight = false;
            this.Cbescuela.Items.AddRange(new object[] {
            "ARQUITECTURA (41)",
            "INGENIERÍA CIVIL (42)",
            "INGENIERÍA ELÉCTRICA (43)",
            "INGENIERÍA ELECTRÓNICA (44)",
            "INGENIERÍA INDUSTRIAL (45)",
            "INGENIERÍA DE MTTO. MECÁNICO (46)",
            "INGENIERÍA DE SISTEMAS (47)"});
            this.Cbescuela.Location = new System.Drawing.Point(116, 134);
            this.Cbescuela.Name = "Cbescuela";
            this.Cbescuela.Size = new System.Drawing.Size(173, 24);
            this.Cbescuela.TabIndex = 52;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label6.Location = new System.Drawing.Point(116, 120);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 16);
            this.label6.TabIndex = 51;
            this.label6.Text = "Escuela";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label5.Location = new System.Drawing.Point(10, 211);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 16);
            this.label5.TabIndex = 48;
            this.label5.Text = "Proposito";
            // 
            // tbproposito
            // 
            this.tbproposito.Location = new System.Drawing.Point(10, 227);
            this.tbproposito.Name = "tbproposito";
            this.tbproposito.Size = new System.Drawing.Size(470, 50);
            this.tbproposito.TabIndex = 47;
            this.tbproposito.Text = "";
            this.tbproposito.TextChanged += new System.EventHandler(this.tbproposito_TextChanged);
            // 
            // tbnombre
            // 
            this.tbnombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.tbnombre.Location = new System.Drawing.Point(116, 182);
            this.tbnombre.MaxLength = 10;
            this.tbnombre.Name = "tbnombre";
            this.tbnombre.ReadOnly = true;
            this.tbnombre.Size = new System.Drawing.Size(173, 22);
            this.tbnombre.TabIndex = 45;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label1.Location = new System.Drawing.Point(10, 166);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 16);
            this.label1.TabIndex = 44;
            this.label1.Text = "Cedula";
            // 
            // tbusuario
            // 
            this.tbusuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.tbusuario.Location = new System.Drawing.Point(10, 182);
            this.tbusuario.MaxLength = 10;
            this.tbusuario.Name = "tbusuario";
            this.tbusuario.ReadOnly = true;
            this.tbusuario.Size = new System.Drawing.Size(91, 22);
            this.tbusuario.TabIndex = 43;
            // 
            // reservararea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 350);
            this.ControlBox = false;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MaximumSize = new System.Drawing.Size(538, 869);
            this.Name = "reservararea";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        public Button btnreservar;
        public Label id;
        public Label lblcabecera;
        private TextBox tbsecciones;
        private TextBox tbcatedras;
        private Button Btncerrar;
        private Label label4;
        private Label lbltitulo;
        private DateTimePicker dtfecha;
        private DateTimePicker dthorainicio;
        private Label label2;
        public Label lblfechaestipulada;
        public DateTimePicker dthorafinal;
        public Label lblfechaactual;
        private Panel panel2;
        private Label label1;
        public TextBox tbusuario;
        public TextBox tbnombre;
        private RichTextBox tbproposito;
        private Label label5;
        private Label label6;
        public ComboBox Cbescuela;
        private Label label3;
        private Label label7;
        private CheckBox cbdifusion;
        private CheckBox cbsonido;
        private CheckBox cbmicrofono;
        private CheckBox cbpc;
        private CheckBox cbproyector;
        public Button btnfinalizar;
        public Label label8;
    }
}