using System.Windows.Forms;

namespace TrabajoDeGrado.Secciones.Estudiantes_y_Profesores.Estudiantes
{
    partial class agregarusuarios
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
            this.btnrestablecer = new System.Windows.Forms.Button();
            this.Btnagregar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.Tbcorreo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbcodigo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Tbtelefono = new System.Windows.Forms.TextBox();
            this.cbapertura = new System.Windows.Forms.CheckBox();
            this.cbadmin = new System.Windows.Forms.CheckBox();
            this.cbregistrar = new System.Windows.Forms.CheckBox();
            this.cbretrasos = new System.Windows.Forms.CheckBox();
            this.cbprestamos = new System.Windows.Forms.CheckBox();
            this.cbactas = new System.Windows.Forms.CheckBox();
            this.cbeditar = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbtipo = new System.Windows.Forms.ComboBox();
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
            this.Btncerrar = new System.Windows.Forms.Button();
            this.lblcabecera = new System.Windows.Forms.Label();
            this.lblestado = new System.Windows.Forms.Label();
            this.cbestado = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnrestablecer);
            this.panel1.Controls.Add(this.Btnagregar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 365);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(390, 63);
            this.panel1.TabIndex = 0;
            // 
            // btnrestablecer
            // 
            this.btnrestablecer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnrestablecer.BackColor = System.Drawing.Color.Transparent;
            this.btnrestablecer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnrestablecer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btnrestablecer.ForeColor = System.Drawing.Color.Black;
            this.btnrestablecer.Location = new System.Drawing.Point(97, 18);
            this.btnrestablecer.Name = "btnrestablecer";
            this.btnrestablecer.Size = new System.Drawing.Size(173, 35);
            this.btnrestablecer.TabIndex = 2;
            this.btnrestablecer.Text = "Restablecer contraseña";
            this.btnrestablecer.UseVisualStyleBackColor = false;
            this.btnrestablecer.Visible = false;
            this.btnrestablecer.Click += new System.EventHandler(this.btnrestablecer_Click);
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
            this.Btnagregar.Location = new System.Drawing.Point(276, 18);
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
            this.panel2.Controls.Add(this.lblestado);
            this.panel2.Controls.Add(this.cbestado);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.Tbcorreo);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.tbcodigo);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.Tbtelefono);
            this.panel2.Controls.Add(this.cbapertura);
            this.panel2.Controls.Add(this.cbadmin);
            this.panel2.Controls.Add(this.cbregistrar);
            this.panel2.Controls.Add(this.cbretrasos);
            this.panel2.Controls.Add(this.cbprestamos);
            this.panel2.Controls.Add(this.cbactas);
            this.panel2.Controls.Add(this.cbeditar);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.cbtipo);
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
            this.panel2.Controls.Add(this.Btncerrar);
            this.panel2.Controls.Add(this.lblcabecera);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(390, 365);
            this.panel2.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label10.Location = new System.Drawing.Point(198, 189);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(113, 16);
            this.label10.TabIndex = 60;
            this.label10.Text = "Correo (Opcional)";
            // 
            // Tbcorreo
            // 
            this.Tbcorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.Tbcorreo.Location = new System.Drawing.Point(198, 206);
            this.Tbcorreo.MaxLength = 25;
            this.Tbcorreo.Name = "Tbcorreo";
            this.Tbcorreo.Size = new System.Drawing.Size(176, 22);
            this.Tbcorreo.TabIndex = 59;
            this.Tbcorreo.TextChanged += new System.EventHandler(this.Tbcorreo_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label1.Location = new System.Drawing.Point(7, 189);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 16);
            this.label1.TabIndex = 58;
            this.label1.Text = "Codigo";
            // 
            // tbcodigo
            // 
            this.tbcodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.tbcodigo.Location = new System.Drawing.Point(10, 206);
            this.tbcodigo.MaxLength = 4;
            this.tbcodigo.Name = "tbcodigo";
            this.tbcodigo.Size = new System.Drawing.Size(44, 22);
            this.tbcodigo.TabIndex = 57;
            this.tbcodigo.TextChanged += new System.EventHandler(this.Tbtelefono_TextChanged_1);
            this.tbcodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbcodigo_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label8.Location = new System.Drawing.Point(59, 189);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(131, 16);
            this.label8.TabIndex = 56;
            this.label8.Text = "Numero de Telefono";
            // 
            // Tbtelefono
            // 
            this.Tbtelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.Tbtelefono.Location = new System.Drawing.Point(59, 206);
            this.Tbtelefono.MaxLength = 7;
            this.Tbtelefono.Name = "Tbtelefono";
            this.Tbtelefono.Size = new System.Drawing.Size(127, 22);
            this.Tbtelefono.TabIndex = 55;
            this.Tbtelefono.TextChanged += new System.EventHandler(this.Tbtelefono_TextChanged_1);
            // 
            // cbapertura
            // 
            this.cbapertura.AutoSize = true;
            this.cbapertura.Enabled = false;
            this.cbapertura.Location = new System.Drawing.Point(9, 336);
            this.cbapertura.Name = "cbapertura";
            this.cbapertura.Size = new System.Drawing.Size(113, 17);
            this.cbapertura.TabIndex = 46;
            this.cbapertura.Text = "Aperturar Periodos";
            this.cbapertura.UseVisualStyleBackColor = true;
            // 
            // cbadmin
            // 
            this.cbadmin.AutoSize = true;
            this.cbadmin.Enabled = false;
            this.cbadmin.Location = new System.Drawing.Point(223, 293);
            this.cbadmin.Name = "cbadmin";
            this.cbadmin.Size = new System.Drawing.Size(155, 17);
            this.cbadmin.TabIndex = 45;
            this.cbadmin.Text = "Funciones de administrador";
            this.cbadmin.UseVisualStyleBackColor = true;
            this.cbadmin.CheckedChanged += new System.EventHandler(this.cbadmin_CheckedChanged);
            // 
            // cbregistrar
            // 
            this.cbregistrar.AutoSize = true;
            this.cbregistrar.Enabled = false;
            this.cbregistrar.Location = new System.Drawing.Point(109, 291);
            this.cbregistrar.Name = "cbregistrar";
            this.cbregistrar.Size = new System.Drawing.Size(68, 17);
            this.cbregistrar.TabIndex = 44;
            this.cbregistrar.Text = "Registrar";
            this.cbregistrar.UseVisualStyleBackColor = true;
            // 
            // cbretrasos
            // 
            this.cbretrasos.AutoSize = true;
            this.cbretrasos.Enabled = false;
            this.cbretrasos.Location = new System.Drawing.Point(109, 314);
            this.cbretrasos.Name = "cbretrasos";
            this.cbretrasos.Size = new System.Drawing.Size(108, 17);
            this.cbretrasos.TabIndex = 43;
            this.cbretrasos.Text = "Procesar retrasos";
            this.cbretrasos.UseVisualStyleBackColor = true;
            // 
            // cbprestamos
            // 
            this.cbprestamos.AutoSize = true;
            this.cbprestamos.Enabled = false;
            this.cbprestamos.Location = new System.Drawing.Point(223, 314);
            this.cbprestamos.Name = "cbprestamos";
            this.cbprestamos.Size = new System.Drawing.Size(120, 17);
            this.cbprestamos.TabIndex = 42;
            this.cbprestamos.Text = "Procesar Prestamos";
            this.cbprestamos.UseVisualStyleBackColor = true;
            // 
            // cbactas
            // 
            this.cbactas.AutoSize = true;
            this.cbactas.Enabled = false;
            this.cbactas.Location = new System.Drawing.Point(9, 314);
            this.cbactas.Name = "cbactas";
            this.cbactas.Size = new System.Drawing.Size(94, 17);
            this.cbactas.TabIndex = 41;
            this.cbactas.Text = "Generar Actas";
            this.cbactas.UseVisualStyleBackColor = true;
            this.cbactas.CheckedChanged += new System.EventHandler(this.cbactas_CheckedChanged);
            // 
            // cbeditar
            // 
            this.cbeditar.AutoSize = true;
            this.cbeditar.Enabled = false;
            this.cbeditar.Location = new System.Drawing.Point(10, 293);
            this.cbeditar.Name = "cbeditar";
            this.cbeditar.Size = new System.Drawing.Size(53, 17);
            this.cbeditar.TabIndex = 40;
            this.cbeditar.Text = "Editar";
            this.cbeditar.UseVisualStyleBackColor = true;
            this.cbeditar.CheckedChanged += new System.EventHandler(this.cbeditar_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label7.Location = new System.Drawing.Point(195, 40);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 16);
            this.label7.TabIndex = 39;
            this.label7.Text = "Labor";
            // 
            // cbtipo
            // 
            this.cbtipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbtipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.cbtipo.FormattingEnabled = true;
            this.cbtipo.Items.AddRange(new object[] {
            "DOCENTE",
            "ESTUDIANTE",
            "INVESTIGACIONES",
            "SERVICIO COMUNITARIO",
            "TECNOLOGIA EDUCATIVA",
            "DEPARTAMENTOS MULTIPLES"});
            this.cbtipo.Location = new System.Drawing.Point(198, 59);
            this.cbtipo.Name = "cbtipo";
            this.cbtipo.Size = new System.Drawing.Size(176, 24);
            this.cbtipo.TabIndex = 38;
            this.cbtipo.SelectedIndexChanged += new System.EventHandler(this.cbtipo_SelectedIndexChanged);
            this.cbtipo.TextChanged += new System.EventHandler(this.cbtipo_TextChanged);
            // 
            // tbprimernombre
            // 
            this.tbprimernombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.tbprimernombre.Location = new System.Drawing.Point(10, 108);
            this.tbprimernombre.MaxLength = 10;
            this.tbprimernombre.Name = "tbprimernombre";
            this.tbprimernombre.Size = new System.Drawing.Size(176, 22);
            this.tbprimernombre.TabIndex = 35;
            this.tbprimernombre.TextChanged += new System.EventHandler(this.cbtipo_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label5.Location = new System.Drawing.Point(12, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 16);
            this.label5.TabIndex = 34;
            this.label5.Text = "Primer Apellido";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label4.Location = new System.Drawing.Point(198, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(180, 16);
            this.label4.TabIndex = 33;
            this.label4.Text = "Segundo Apellido (Opcional)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label3.Location = new System.Drawing.Point(195, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(179, 16);
            this.label3.TabIndex = 32;
            this.label3.Text = "Segundo Nombre (Opcional)";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label6.Location = new System.Drawing.Point(10, 92);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 16);
            this.label6.TabIndex = 31;
            this.label6.Text = "Primer Nombre";
            // 
            // Tbsegundonombre
            // 
            this.Tbsegundonombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.Tbsegundonombre.Location = new System.Drawing.Point(198, 108);
            this.Tbsegundonombre.MaxLength = 15;
            this.Tbsegundonombre.Name = "Tbsegundonombre";
            this.Tbsegundonombre.Size = new System.Drawing.Size(176, 22);
            this.Tbsegundonombre.TabIndex = 30;
            this.Tbsegundonombre.TextChanged += new System.EventHandler(this.cbtipo_TextChanged);
            // 
            // Tbprimerapellido
            // 
            this.Tbprimerapellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.Tbprimerapellido.Location = new System.Drawing.Point(10, 160);
            this.Tbprimerapellido.MaxLength = 10;
            this.Tbprimerapellido.Name = "Tbprimerapellido";
            this.Tbprimerapellido.Size = new System.Drawing.Size(176, 22);
            this.Tbprimerapellido.TabIndex = 29;
            this.Tbprimerapellido.TextChanged += new System.EventHandler(this.cbtipo_TextChanged);
            // 
            // Tbsegundoapellido
            // 
            this.Tbsegundoapellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.Tbsegundoapellido.Location = new System.Drawing.Point(198, 160);
            this.Tbsegundoapellido.MaxLength = 15;
            this.Tbsegundoapellido.Name = "Tbsegundoapellido";
            this.Tbsegundoapellido.Size = new System.Drawing.Size(176, 22);
            this.Tbsegundoapellido.TabIndex = 28;
            this.Tbsegundoapellido.TextChanged += new System.EventHandler(this.cbtipo_TextChanged);
            // 
            // tbcedula
            // 
            this.tbcedula.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.tbcedula.Location = new System.Drawing.Point(10, 59);
            this.tbcedula.MaxLength = 8;
            this.tbcedula.Name = "tbcedula";
            this.tbcedula.Size = new System.Drawing.Size(176, 22);
            this.tbcedula.TabIndex = 22;
            this.tbcedula.TextChanged += new System.EventHandler(this.cbtipo_TextChanged);
            this.tbcedula.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbcedula_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label2.Location = new System.Drawing.Point(10, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 16);
            this.label2.TabIndex = 21;
            this.label2.Text = "Cedula";
            // 
            // Btncerrar
            // 
            this.Btncerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btncerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btncerrar.FlatAppearance.BorderSize = 0;
            this.Btncerrar.Image = global::PSMtecnology.Properties.Resources.cerrar;
            this.Btncerrar.Location = new System.Drawing.Point(357, 12);
            this.Btncerrar.Name = "Btncerrar";
            this.Btncerrar.Size = new System.Drawing.Size(21, 21);
            this.Btncerrar.TabIndex = 20;
            this.Btncerrar.UseVisualStyleBackColor = true;
            this.Btncerrar.Click += new System.EventHandler(this.Btncerrar_Click);
            // 
            // lblcabecera
            // 
            this.lblcabecera.AutoSize = true;
            this.lblcabecera.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblcabecera.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(24)))), ((int)(((byte)(67)))));
            this.lblcabecera.Location = new System.Drawing.Point(10, 8);
            this.lblcabecera.Name = "lblcabecera";
            this.lblcabecera.Size = new System.Drawing.Size(162, 24);
            this.lblcabecera.TabIndex = 8;
            this.lblcabecera.Text = "Agregar Usuario";
            // 
            // lblestado
            // 
            this.lblestado.AutoSize = true;
            this.lblestado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lblestado.Location = new System.Drawing.Point(10, 236);
            this.lblestado.Name = "lblestado";
            this.lblestado.Size = new System.Drawing.Size(50, 16);
            this.lblestado.TabIndex = 62;
            this.lblestado.Text = "Estado";
            this.lblestado.Visible = false;
            // 
            // cbestado
            // 
            this.cbestado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbestado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.cbestado.FormattingEnabled = true;
            this.cbestado.Items.AddRange(new object[] {
            "ACTIVO",
            "INACTIVO"});
            this.cbestado.Location = new System.Drawing.Point(9, 255);
            this.cbestado.Name = "cbestado";
            this.cbestado.Size = new System.Drawing.Size(177, 24);
            this.cbestado.TabIndex = 61;
            this.cbestado.Visible = false;
            // 
            // agregarusuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 428);
            this.ControlBox = false;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "agregarusuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Button Btncerrar;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label6;
        private Label label7;
        public TextBox tbcedula;
        public Panel panel2;
        public TextBox tbprimernombre;
        public TextBox Tbsegundonombre;
        public TextBox Tbprimerapellido;
        public TextBox Tbsegundoapellido;
        public ComboBox cbtipo;
        public Button Btnagregar;
        public Label lblcabecera;
        public Button btnrestablecer;
        private CheckBox cbadmin;
        private CheckBox cbregistrar;
        private CheckBox cbretrasos;
        private CheckBox cbprestamos;
        private CheckBox cbactas;
        private CheckBox cbeditar;
        private CheckBox cbapertura;
        private Label label10;
        private TextBox Tbcorreo;
        private Label label1;
        private TextBox tbcodigo;
        private Label label8;
        private TextBox Tbtelefono;
        public ComboBox cbestado;
        public Label lblestado;
    }
}