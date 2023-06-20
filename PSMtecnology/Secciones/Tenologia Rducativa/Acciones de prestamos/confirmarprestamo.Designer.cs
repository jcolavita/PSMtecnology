using System.Windows.Forms;

namespace TrabajoDeGrado.Secciones.Estudiantes_y_Profesores.Estudiantes
{
    partial class confirmarprestamo
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
            this.label5 = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.Label();
            this.btncancelar = new System.Windows.Forms.Button();
            this.btnagregar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.tbcota = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbcedula = new System.Windows.Forms.TextBox();
            this.lblfechaestipulada = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtdevolucion = new System.Windows.Forms.DateTimePicker();
            this.dtsalida = new System.Windows.Forms.DateTimePicker();
            this.lbltitulo = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Btncerrar = new System.Windows.Forms.Button();
            this.tbcodigo = new System.Windows.Forms.TextBox();
            this.tbtitulo = new System.Windows.Forms.TextBox();
            this.tbsolicitante = new System.Windows.Forms.TextBox();
            this.lblcabecera = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.id);
            this.panel1.Controls.Add(this.btncancelar);
            this.panel1.Controls.Add(this.btnagregar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 219);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(410, 63);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(24)))), ((int)(((byte)(67)))));
            this.label5.Location = new System.Drawing.Point(10, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 24);
            this.label5.TabIndex = 42;
            this.label5.Text = "Solicitud #:";
            // 
            // id
            // 
            this.id.AutoSize = true;
            this.id.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.id.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(24)))), ((int)(((byte)(67)))));
            this.id.Location = new System.Drawing.Point(129, 27);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(54, 24);
            this.id.TabIndex = 41;
            this.id.Text = "8888";
            // 
            // btncancelar
            // 
            this.btncancelar.BackColor = System.Drawing.Color.Transparent;
            this.btncancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btncancelar.ForeColor = System.Drawing.Color.Black;
            this.btncancelar.Location = new System.Drawing.Point(208, 22);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(78, 29);
            this.btncancelar.TabIndex = 2;
            this.btncancelar.Text = "Anular";
            this.btncancelar.UseVisualStyleBackColor = false;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // btnagregar
            // 
            this.btnagregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(24)))), ((int)(((byte)(67)))));
            this.btnagregar.FlatAppearance.BorderSize = 0;
            this.btnagregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnagregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btnagregar.ForeColor = System.Drawing.Color.White;
            this.btnagregar.Location = new System.Drawing.Point(295, 16);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(103, 35);
            this.btnagregar.TabIndex = 1;
            this.btnagregar.Text = "Aprobar";
            this.btnagregar.UseVisualStyleBackColor = false;
            this.btnagregar.Click += new System.EventHandler(this.Btnagregar_Click_1);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.tbcota);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.tbcedula);
            this.panel2.Controls.Add(this.lblfechaestipulada);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.dtdevolucion);
            this.panel2.Controls.Add(this.dtsalida);
            this.panel2.Controls.Add(this.lbltitulo);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.Btncerrar);
            this.panel2.Controls.Add(this.tbcodigo);
            this.panel2.Controls.Add(this.tbtitulo);
            this.panel2.Controls.Add(this.tbsolicitante);
            this.panel2.Controls.Add(this.lblcabecera);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(410, 219);
            this.panel2.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label3.Location = new System.Drawing.Point(171, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 16);
            this.label3.TabIndex = 44;
            this.label3.Text = "Cota";
            // 
            // tbcota
            // 
            this.tbcota.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.tbcota.Location = new System.Drawing.Point(171, 55);
            this.tbcota.MaxLength = 10;
            this.tbcota.Name = "tbcota";
            this.tbcota.ReadOnly = true;
            this.tbcota.Size = new System.Drawing.Size(133, 22);
            this.tbcota.TabIndex = 43;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label1.Location = new System.Drawing.Point(10, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 16);
            this.label1.TabIndex = 42;
            this.label1.Text = "Cedula";
            // 
            // tbcedula
            // 
            this.tbcedula.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.tbcedula.Location = new System.Drawing.Point(10, 55);
            this.tbcedula.MaxLength = 10;
            this.tbcedula.Name = "tbcedula";
            this.tbcedula.ReadOnly = true;
            this.tbcedula.Size = new System.Drawing.Size(133, 22);
            this.tbcedula.TabIndex = 41;
            // 
            // lblfechaestipulada
            // 
            this.lblfechaestipulada.AutoSize = true;
            this.lblfechaestipulada.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lblfechaestipulada.Location = new System.Drawing.Point(133, 167);
            this.lblfechaestipulada.Name = "lblfechaestipulada";
            this.lblfechaestipulada.Size = new System.Drawing.Size(135, 16);
            this.lblfechaestipulada.TabIndex = 40;
            this.lblfechaestipulada.Text = "Fecha de Devolucion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label2.Location = new System.Drawing.Point(10, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 16);
            this.label2.TabIndex = 39;
            this.label2.Text = "Fecha de Salida";
            // 
            // dtdevolucion
            // 
            this.dtdevolucion.Enabled = false;
            this.dtdevolucion.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtdevolucion.Location = new System.Drawing.Point(133, 184);
            this.dtdevolucion.Name = "dtdevolucion";
            this.dtdevolucion.Size = new System.Drawing.Size(135, 22);
            this.dtdevolucion.TabIndex = 38;
            this.dtdevolucion.Value = new System.DateTime(2023, 6, 1, 0, 0, 0, 0);
            // 
            // dtsalida
            // 
            this.dtsalida.Enabled = false;
            this.dtsalida.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtsalida.Location = new System.Drawing.Point(10, 184);
            this.dtsalida.Name = "dtsalida";
            this.dtsalida.Size = new System.Drawing.Size(106, 22);
            this.dtsalida.TabIndex = 37;
            // 
            // lbltitulo
            // 
            this.lbltitulo.AutoSize = true;
            this.lbltitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lbltitulo.Location = new System.Drawing.Point(10, 78);
            this.lbltitulo.Name = "lbltitulo";
            this.lbltitulo.Size = new System.Drawing.Size(40, 16);
            this.lbltitulo.TabIndex = 26;
            this.lbltitulo.Text = "Titulo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label4.Location = new System.Drawing.Point(10, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 16);
            this.label4.TabIndex = 25;
            this.label4.Text = "Solicitante";
            // 
            // Btncerrar
            // 
            this.Btncerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btncerrar.FlatAppearance.BorderSize = 0;
            this.Btncerrar.Image = global::PSMtecnology.Properties.Resources.cerrar;
            this.Btncerrar.Location = new System.Drawing.Point(377, 12);
            this.Btncerrar.Name = "Btncerrar";
            this.Btncerrar.Size = new System.Drawing.Size(21, 21);
            this.Btncerrar.TabIndex = 20;
            this.Btncerrar.UseVisualStyleBackColor = true;
            this.Btncerrar.Click += new System.EventHandler(this.Btncerrar_Click);
            // 
            // tbcodigo
            // 
            this.tbcodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.tbcodigo.Location = new System.Drawing.Point(310, 55);
            this.tbcodigo.MaxLength = 10;
            this.tbcodigo.Name = "tbcodigo";
            this.tbcodigo.ReadOnly = true;
            this.tbcodigo.Size = new System.Drawing.Size(88, 22);
            this.tbcodigo.TabIndex = 16;
            this.tbcodigo.Visible = false;
            // 
            // tbtitulo
            // 
            this.tbtitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.tbtitulo.Location = new System.Drawing.Point(10, 95);
            this.tbtitulo.MaxLength = 30;
            this.tbtitulo.Name = "tbtitulo";
            this.tbtitulo.ReadOnly = true;
            this.tbtitulo.Size = new System.Drawing.Size(388, 22);
            this.tbtitulo.TabIndex = 11;
            // 
            // tbsolicitante
            // 
            this.tbsolicitante.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.tbsolicitante.Location = new System.Drawing.Point(10, 139);
            this.tbsolicitante.MaxLength = 20;
            this.tbsolicitante.Name = "tbsolicitante";
            this.tbsolicitante.ReadOnly = true;
            this.tbsolicitante.Size = new System.Drawing.Size(388, 22);
            this.tbsolicitante.TabIndex = 9;
            // 
            // lblcabecera
            // 
            this.lblcabecera.AutoSize = true;
            this.lblcabecera.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblcabecera.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(24)))), ((int)(((byte)(67)))));
            this.lblcabecera.Location = new System.Drawing.Point(10, 8);
            this.lblcabecera.Name = "lblcabecera";
            this.lblcabecera.Size = new System.Drawing.Size(90, 24);
            this.lblcabecera.TabIndex = 8;
            this.lblcabecera.Text = "Solicitud";
            // 
            // confirmarprestamo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 282);
            this.ControlBox = false;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MaximumSize = new System.Drawing.Size(538, 869);
            this.Name = "confirmarprestamo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Button Btncerrar;
        private TextBox tbtitulo;
        private TextBox tbsolicitante;
        private Label lbltitulo;
        private Label label4;
        public TextBox tbcodigo;
        public Label lblcabecera;
        public Button btnagregar;
        private Label label2;
        private DateTimePicker dtdevolucion;
        private DateTimePicker dtsalida;
        public Label id;
        public Button btncancelar;
        public Label lblfechaestipulada;
        private Label label1;
        public TextBox tbcedula;
        private Label label3;
        public TextBox tbcota;
        public Label label5;
    }
}