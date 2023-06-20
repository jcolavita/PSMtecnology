using System.Windows.Forms;

namespace TrabajoDeGrado.Secciones.Estudiantes_y_Profesores.Estudiantes
{
    partial class devolver
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
            this.id = new System.Windows.Forms.Label();
            this.btnagregar = new System.Windows.Forms.Button();
            this.Devolucion = new System.Windows.Forms.Label();
            this.tbsolicitante = new System.Windows.Forms.TextBox();
            this.tbtitulo = new System.Windows.Forms.TextBox();
            this.tbcota = new System.Windows.Forms.TextBox();
            this.Btncerrar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lbltitulo = new System.Windows.Forms.Label();
            this.dtsalida = new System.Windows.Forms.DateTimePicker();
            this.dtdevolucion = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.lblfechaestipulada = new System.Windows.Forms.Label();
            this.dtfechaactual = new System.Windows.Forms.DateTimePicker();
            this.lblfechaactual = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblcota = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbmotivo = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbusuario = new System.Windows.Forms.TextBox();
            this.idlibro = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.id);
            this.panel1.Controls.Add(this.btnagregar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 292);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(479, 63);
            this.panel1.TabIndex = 0;
            // 
            // id
            // 
            this.id.AutoSize = true;
            this.id.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.id.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(24)))), ((int)(((byte)(67)))));
            this.id.Location = new System.Drawing.Point(10, 18);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(29, 24);
            this.id.TabIndex = 41;
            this.id.Text = "ID";
            this.id.Visible = false;
            // 
            // btnagregar
            // 
            this.btnagregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(24)))), ((int)(((byte)(67)))));
            this.btnagregar.FlatAppearance.BorderSize = 0;
            this.btnagregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnagregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btnagregar.ForeColor = System.Drawing.Color.White;
            this.btnagregar.Location = new System.Drawing.Point(362, 18);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(103, 35);
            this.btnagregar.TabIndex = 1;
            this.btnagregar.Text = "Devolver";
            this.btnagregar.UseVisualStyleBackColor = false;
            this.btnagregar.Click += new System.EventHandler(this.Btnagregar_Click_1);
            // 
            // Devolucion
            // 
            this.Devolucion.AutoSize = true;
            this.Devolucion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.Devolucion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(24)))), ((int)(((byte)(67)))));
            this.Devolucion.Location = new System.Drawing.Point(10, 8);
            this.Devolucion.Name = "Devolucion";
            this.Devolucion.Size = new System.Drawing.Size(115, 24);
            this.Devolucion.TabIndex = 8;
            this.Devolucion.Text = "Devolucion";
            // 
            // tbsolicitante
            // 
            this.tbsolicitante.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.tbsolicitante.Location = new System.Drawing.Point(10, 143);
            this.tbsolicitante.MaxLength = 20;
            this.tbsolicitante.Name = "tbsolicitante";
            this.tbsolicitante.ReadOnly = true;
            this.tbsolicitante.Size = new System.Drawing.Size(455, 22);
            this.tbsolicitante.TabIndex = 9;
            // 
            // tbtitulo
            // 
            this.tbtitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.tbtitulo.Location = new System.Drawing.Point(10, 102);
            this.tbtitulo.MaxLength = 30;
            this.tbtitulo.Name = "tbtitulo";
            this.tbtitulo.ReadOnly = true;
            this.tbtitulo.Size = new System.Drawing.Size(455, 22);
            this.tbtitulo.TabIndex = 11;
            this.tbtitulo.TextChanged += new System.EventHandler(this.tbtitulo_TextChanged);
            // 
            // tbcota
            // 
            this.tbcota.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.tbcota.Location = new System.Drawing.Point(109, 56);
            this.tbcota.MaxLength = 10;
            this.tbcota.Name = "tbcota";
            this.tbcota.ReadOnly = true;
            this.tbcota.Size = new System.Drawing.Size(133, 22);
            this.tbcota.TabIndex = 16;
            this.tbcota.Visible = false;
            // 
            // Btncerrar
            // 
            this.Btncerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btncerrar.FlatAppearance.BorderSize = 0;
            this.Btncerrar.Image = global::PSMtecnology.Properties.Resources.cerrar;
            this.Btncerrar.Location = new System.Drawing.Point(448, 8);
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
            this.label4.Location = new System.Drawing.Point(10, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 16);
            this.label4.TabIndex = 25;
            this.label4.Text = "Solicitante";
            // 
            // lbltitulo
            // 
            this.lbltitulo.AutoSize = true;
            this.lbltitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lbltitulo.Location = new System.Drawing.Point(10, 80);
            this.lbltitulo.Name = "lbltitulo";
            this.lbltitulo.Size = new System.Drawing.Size(40, 16);
            this.lbltitulo.TabIndex = 26;
            this.lbltitulo.Text = "Titulo";
            // 
            // dtsalida
            // 
            this.dtsalida.Enabled = false;
            this.dtsalida.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtsalida.Location = new System.Drawing.Point(10, 189);
            this.dtsalida.Name = "dtsalida";
            this.dtsalida.Size = new System.Drawing.Size(91, 22);
            this.dtsalida.TabIndex = 37;
            // 
            // dtdevolucion
            // 
            this.dtdevolucion.Enabled = false;
            this.dtdevolucion.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtdevolucion.Location = new System.Drawing.Point(122, 189);
            this.dtdevolucion.Name = "dtdevolucion";
            this.dtdevolucion.Size = new System.Drawing.Size(116, 22);
            this.dtdevolucion.TabIndex = 38;
            this.dtdevolucion.Value = new System.DateTime(2023, 6, 1, 0, 0, 0, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label2.Location = new System.Drawing.Point(10, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 16);
            this.label2.TabIndex = 39;
            this.label2.Text = "Fecha de Salida";
            // 
            // lblfechaestipulada
            // 
            this.lblfechaestipulada.AutoSize = true;
            this.lblfechaestipulada.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lblfechaestipulada.Location = new System.Drawing.Point(122, 173);
            this.lblfechaestipulada.Name = "lblfechaestipulada";
            this.lblfechaestipulada.Size = new System.Drawing.Size(111, 16);
            this.lblfechaestipulada.TabIndex = 40;
            this.lblfechaestipulada.Text = "Fecha Extipulada";
            // 
            // dtfechaactual
            // 
            this.dtfechaactual.CalendarTitleBackColor = System.Drawing.SystemColors.ControlText;
            this.dtfechaactual.CalendarTitleForeColor = System.Drawing.Color.Red;
            this.dtfechaactual.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtfechaactual.Location = new System.Drawing.Point(254, 189);
            this.dtfechaactual.Name = "dtfechaactual";
            this.dtfechaactual.Size = new System.Drawing.Size(116, 22);
            this.dtfechaactual.TabIndex = 41;
            this.dtfechaactual.Value = new System.DateTime(2023, 6, 1, 0, 0, 0, 0);
            // 
            // lblfechaactual
            // 
            this.lblfechaactual.AutoSize = true;
            this.lblfechaactual.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lblfechaactual.ForeColor = System.Drawing.Color.Black;
            this.lblfechaactual.Location = new System.Drawing.Point(254, 173);
            this.lblfechaactual.Name = "lblfechaactual";
            this.lblfechaactual.Size = new System.Drawing.Size(85, 16);
            this.lblfechaactual.TabIndex = 42;
            this.lblfechaactual.Text = "Fecha Actual";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.idlibro);
            this.panel2.Controls.Add(this.lblcota);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.tbmotivo);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.tbusuario);
            this.panel2.Controls.Add(this.lblfechaactual);
            this.panel2.Controls.Add(this.dtfechaactual);
            this.panel2.Controls.Add(this.lblfechaestipulada);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.dtdevolucion);
            this.panel2.Controls.Add(this.dtsalida);
            this.panel2.Controls.Add(this.lbltitulo);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.Btncerrar);
            this.panel2.Controls.Add(this.tbcota);
            this.panel2.Controls.Add(this.tbtitulo);
            this.panel2.Controls.Add(this.tbsolicitante);
            this.panel2.Controls.Add(this.Devolucion);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(479, 292);
            this.panel2.TabIndex = 1;
            // 
            // lblcota
            // 
            this.lblcota.AutoSize = true;
            this.lblcota.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lblcota.Location = new System.Drawing.Point(108, 40);
            this.lblcota.Name = "lblcota";
            this.lblcota.Size = new System.Drawing.Size(35, 16);
            this.lblcota.TabIndex = 49;
            this.lblcota.Text = "Cota";
            this.lblcota.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label5.Location = new System.Drawing.Point(10, 218);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 16);
            this.label5.TabIndex = 48;
            this.label5.Text = "Motivo de Retraso";
            // 
            // tbmotivo
            // 
            this.tbmotivo.Location = new System.Drawing.Point(10, 234);
            this.tbmotivo.Name = "tbmotivo";
            this.tbmotivo.Size = new System.Drawing.Size(455, 36);
            this.tbmotivo.TabIndex = 47;
            this.tbmotivo.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label1.Location = new System.Drawing.Point(10, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 16);
            this.label1.TabIndex = 44;
            this.label1.Text = "Cedula";
            // 
            // tbusuario
            // 
            this.tbusuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.tbusuario.Location = new System.Drawing.Point(10, 56);
            this.tbusuario.MaxLength = 10;
            this.tbusuario.Name = "tbusuario";
            this.tbusuario.ReadOnly = true;
            this.tbusuario.Size = new System.Drawing.Size(92, 22);
            this.tbusuario.TabIndex = 43;
            // 
            // idlibro
            // 
            this.idlibro.AutoSize = true;
            this.idlibro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.idlibro.Location = new System.Drawing.Point(269, 56);
            this.idlibro.Name = "idlibro";
            this.idlibro.Size = new System.Drawing.Size(44, 16);
            this.idlibro.TabIndex = 50;
            this.idlibro.Text = "idlibro";
            this.idlibro.Visible = false;
            // 
            // devolver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 355);
            this.ControlBox = false;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MaximumSize = new System.Drawing.Size(538, 869);
            this.Name = "devolver";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        public Button btnagregar;
        public Label id;
        public Label Devolucion;
        private TextBox tbsolicitante;
        private TextBox tbtitulo;
        public TextBox tbcota;
        private Button Btncerrar;
        private Label label4;
        private Label lbltitulo;
        private DateTimePicker dtsalida;
        private DateTimePicker dtdevolucion;
        private Label label2;
        public Label lblfechaestipulada;
        public DateTimePicker dtfechaactual;
        public Label lblfechaactual;
        private Panel panel2;
        private Label label1;
        public TextBox tbusuario;
        private RichTextBox tbmotivo;
        private Label label5;
        public Label lblcota;
        public Label idlibro;
    }
}