using System.Windows.Forms;

namespace TrabajoDeGrado.Secciones.Estudiantes_y_Profesores.Estudiantes
{
    partial class Agregarestudiante 
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbcodigo = new System.Windows.Forms.TextBox();
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
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Btnagregar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 315);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(415, 63);
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
            this.Btnagregar.Location = new System.Drawing.Point(306, 18);
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
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.tbcodigo);
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
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(415, 315);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label1.Location = new System.Drawing.Point(12, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 16);
            this.label1.TabIndex = 35;
            this.label1.Text = "Codigo";
            // 
            // tbcodigo
            // 
            this.tbcodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.tbcodigo.Location = new System.Drawing.Point(12, 179);
            this.tbcodigo.MaxLength = 4;
            this.tbcodigo.Name = "tbcodigo";
            this.tbcodigo.Size = new System.Drawing.Size(57, 22);
            this.tbcodigo.TabIndex = 34;
            this.tbcodigo.TextChanged += new System.EventHandler(this.Tbprimernombre_TextChanged);
            this.tbcodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbcodigo_KeyPress);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label12.Location = new System.Drawing.Point(12, 266);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(56, 16);
            this.label12.TabIndex = 33;
            this.label12.Text = "Escuela";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label10.Location = new System.Drawing.Point(210, 213);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(113, 16);
            this.label10.TabIndex = 31;
            this.label10.Text = "Correo (Opcional)";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label9.Location = new System.Drawing.Point(12, 213);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 16);
            this.label9.TabIndex = 30;
            this.label9.Text = "Sexo";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label8.Location = new System.Drawing.Point(270, 162);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(128, 16);
            this.label8.TabIndex = 29;
            this.label8.Text = "Cedula de Identidad";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label7.Location = new System.Drawing.Point(210, 159);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 16);
            this.label7.TabIndex = 28;
            this.label7.Text = "Tipo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label6.Location = new System.Drawing.Point(73, 160);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 16);
            this.label6.TabIndex = 27;
            this.label6.Text = "Telefono";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label5.Location = new System.Drawing.Point(11, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 16);
            this.label5.TabIndex = 26;
            this.label5.Text = "Primer Apellido";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label4.Location = new System.Drawing.Point(210, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(180, 16);
            this.label4.TabIndex = 25;
            this.label4.Text = "Segundo Apellido (Opcional)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label3.Location = new System.Drawing.Point(210, 59);
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
            this.Cbtipo.Location = new System.Drawing.Point(210, 178);
            this.Cbtipo.Name = "Cbtipo";
            this.Cbtipo.Size = new System.Drawing.Size(55, 24);
            this.Cbtipo.TabIndex = 22;
            // 
            // Btncerrar
            // 
            this.Btncerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btncerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btncerrar.FlatAppearance.BorderSize = 0;
            this.Btncerrar.Image = global::PSMtecnology.Properties.Resources.cerrar;
            this.Btncerrar.Location = new System.Drawing.Point(385, 10);
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
            this.Cbsexo.Location = new System.Drawing.Point(12, 232);
            this.Cbsexo.Name = "Cbsexo";
            this.Cbsexo.Size = new System.Drawing.Size(173, 24);
            this.Cbsexo.TabIndex = 19;
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
            this.Cbescuela.Location = new System.Drawing.Point(12, 283);
            this.Cbescuela.Name = "Cbescuela";
            this.Cbescuela.Size = new System.Drawing.Size(173, 24);
            this.Cbescuela.TabIndex = 18;
            // 
            // Tbcedula
            // 
            this.Tbcedula.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.Tbcedula.Location = new System.Drawing.Point(270, 179);
            this.Tbcedula.MaxLength = 8;
            this.Tbcedula.Name = "Tbcedula";
            this.Tbcedula.Size = new System.Drawing.Size(133, 22);
            this.Tbcedula.TabIndex = 16;
            this.Tbcedula.TextChanged += new System.EventHandler(this.Tbprimernombre_TextChanged);
            this.Tbcedula.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Tbcedula_KeyPress);
            // 
            // Tbsegundonombre
            // 
            this.Tbsegundonombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.Tbsegundonombre.Location = new System.Drawing.Point(210, 75);
            this.Tbsegundonombre.MaxLength = 15;
            this.Tbsegundonombre.Name = "Tbsegundonombre";
            this.Tbsegundonombre.Size = new System.Drawing.Size(193, 22);
            this.Tbsegundonombre.TabIndex = 15;
            this.Tbsegundonombre.TextChanged += new System.EventHandler(this.Tbprimernombre_TextChanged);
            this.Tbsegundonombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Tbprimernombre_KeyPress);
            // 
            // Tbcorreo
            // 
            this.Tbcorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.Tbcorreo.Location = new System.Drawing.Point(210, 232);
            this.Tbcorreo.MaxLength = 25;
            this.Tbcorreo.Name = "Tbcorreo";
            this.Tbcorreo.Size = new System.Drawing.Size(193, 22);
            this.Tbcorreo.TabIndex = 14;
            this.Tbcorreo.TextChanged += new System.EventHandler(this.Tbcorreo_TextChanged);
            // 
            // Tbtelefono
            // 
            this.Tbtelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.Tbtelefono.Location = new System.Drawing.Point(74, 179);
            this.Tbtelefono.MaxLength = 7;
            this.Tbtelefono.Name = "Tbtelefono";
            this.Tbtelefono.Size = new System.Drawing.Size(111, 22);
            this.Tbtelefono.TabIndex = 13;
            this.Tbtelefono.TextChanged += new System.EventHandler(this.Tbprimernombre_TextChanged);
            this.Tbtelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Tbcedula_KeyPress);
            // 
            // Tbprimerapellido
            // 
            this.Tbprimerapellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.Tbprimerapellido.Location = new System.Drawing.Point(15, 127);
            this.Tbprimerapellido.MaxLength = 10;
            this.Tbprimerapellido.Name = "Tbprimerapellido";
            this.Tbprimerapellido.Size = new System.Drawing.Size(173, 22);
            this.Tbprimerapellido.TabIndex = 11;
            this.Tbprimerapellido.TextChanged += new System.EventHandler(this.Tbprimernombre_TextChanged);
            this.Tbprimerapellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Tbprimernombre_KeyPress);
            // 
            // Tbsegundoapellido
            // 
            this.Tbsegundoapellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.Tbsegundoapellido.Location = new System.Drawing.Point(210, 127);
            this.Tbsegundoapellido.MaxLength = 15;
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
            this.lblcabecera.Size = new System.Drawing.Size(189, 24);
            this.lblcabecera.TabIndex = 8;
            this.lblcabecera.Text = "Agregar Estudiante";
            // 
            // Tbprimernombre
            // 
            this.Tbprimernombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.Tbprimernombre.Location = new System.Drawing.Point(12, 75);
            this.Tbprimernombre.MaxLength = 10;
            this.Tbprimernombre.Name = "Tbprimernombre";
            this.Tbprimernombre.Size = new System.Drawing.Size(173, 22);
            this.Tbprimernombre.TabIndex = 0;
            this.Tbprimernombre.TextChanged += new System.EventHandler(this.Tbprimernombre_TextChanged);
            this.Tbprimernombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Tbprimernombre_KeyPress);
            // 
            // Agregarestudiante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 378);
            this.ControlBox = false;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Agregarestudiante";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
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
        public TextBox Tbcedula;
        public Label lblcabecera;
        public Button Btnagregar;
        private TextBox tbcodigo;
        private Label label1;
        public ComboBox Cbsexo;
        public ComboBox Cbescuela;
    }
}