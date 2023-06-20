using System.Windows.Forms;

namespace TrabajoDeGrado.Secciones.Estudiantes_y_Profesores.Estudiantes
{
    partial class entregarproyector
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
            this.btnanular = new System.Windows.Forms.Panel();
            this.ID = new System.Windows.Forms.Label();
            this.anular = new System.Windows.Forms.Button();
            this.btnentregar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tbidproyector = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dthora = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.tbaula = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtdevolucion = new System.Windows.Forms.DateTimePicker();
            this.dtfecha = new System.Windows.Forms.DateTimePicker();
            this.Cedula = new System.Windows.Forms.Label();
            this.lblnombre = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Btncerrar = new System.Windows.Forms.Button();
            this.tbcedula = new System.Windows.Forms.TextBox();
            this.tbnombre = new System.Windows.Forms.TextBox();
            this.tbmateria = new System.Windows.Forms.TextBox();
            this.lblcabecera = new System.Windows.Forms.Label();
            this.btnanular.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnanular
            // 
            this.btnanular.Controls.Add(this.ID);
            this.btnanular.Controls.Add(this.anular);
            this.btnanular.Controls.Add(this.btnentregar);
            this.btnanular.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnanular.Location = new System.Drawing.Point(0, 243);
            this.btnanular.Name = "btnanular";
            this.btnanular.Size = new System.Drawing.Size(399, 63);
            this.btnanular.TabIndex = 0;
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.ID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(24)))), ((int)(((byte)(67)))));
            this.ID.Location = new System.Drawing.Point(10, 24);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(90, 24);
            this.ID.TabIndex = 45;
            this.ID.Text = "Entregar";
            this.ID.Visible = false;
            // 
            // anular
            // 
            this.anular.BackColor = System.Drawing.Color.Transparent;
            this.anular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.anular.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.anular.ForeColor = System.Drawing.Color.Black;
            this.anular.Location = new System.Drawing.Point(193, 27);
            this.anular.Name = "anular";
            this.anular.Size = new System.Drawing.Size(86, 24);
            this.anular.TabIndex = 2;
            this.anular.Text = "Anular";
            this.anular.UseVisualStyleBackColor = false;
            this.anular.Click += new System.EventHandler(this.anular_Click);
            // 
            // btnentregar
            // 
            this.btnentregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(24)))), ((int)(((byte)(67)))));
            this.btnentregar.FlatAppearance.BorderSize = 0;
            this.btnentregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnentregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btnentregar.ForeColor = System.Drawing.Color.White;
            this.btnentregar.Location = new System.Drawing.Point(284, 16);
            this.btnentregar.Name = "btnentregar";
            this.btnentregar.Size = new System.Drawing.Size(103, 35);
            this.btnentregar.TabIndex = 1;
            this.btnentregar.Text = "Entregar";
            this.btnentregar.UseVisualStyleBackColor = false;
            this.btnentregar.Click += new System.EventHandler(this.Btnagregar_Click_1);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.tbidproyector);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.dthora);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.tbaula);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.dtdevolucion);
            this.panel2.Controls.Add(this.dtfecha);
            this.panel2.Controls.Add(this.Cedula);
            this.panel2.Controls.Add(this.lblnombre);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.Btncerrar);
            this.panel2.Controls.Add(this.tbcedula);
            this.panel2.Controls.Add(this.tbnombre);
            this.panel2.Controls.Add(this.tbmateria);
            this.panel2.Controls.Add(this.lblcabecera);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(399, 243);
            this.panel2.TabIndex = 1;
            // 
            // tbidproyector
            // 
            this.tbidproyector.Enabled = false;
            this.tbidproyector.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.tbidproyector.Location = new System.Drawing.Point(279, 109);
            this.tbidproyector.MaxLength = 20;
            this.tbidproyector.Name = "tbidproyector";
            this.tbidproyector.Size = new System.Drawing.Size(68, 22);
            this.tbidproyector.TabIndex = 45;
            this.tbidproyector.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label1.Location = new System.Drawing.Point(10, 183);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 16);
            this.label1.TabIndex = 44;
            this.label1.Text = "Hora de Reserva (24H)";
            // 
            // dthora
            // 
            this.dthora.Enabled = false;
            this.dthora.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dthora.Location = new System.Drawing.Point(10, 202);
            this.dthora.Name = "dthora";
            this.dthora.Size = new System.Drawing.Size(107, 22);
            this.dthora.TabIndex = 43;
            this.dthora.Value = new System.DateTime(2023, 6, 1, 0, 0, 0, 0);
            this.dthora.ValueChanged += new System.EventHandler(this.dtdevolucion_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label5.Location = new System.Drawing.Point(230, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 16);
            this.label5.TabIndex = 42;
            this.label5.Text = "Aula";
            // 
            // tbaula
            // 
            this.tbaula.Enabled = false;
            this.tbaula.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.tbaula.Location = new System.Drawing.Point(230, 109);
            this.tbaula.MaxLength = 5;
            this.tbaula.Name = "tbaula";
            this.tbaula.Size = new System.Drawing.Size(45, 22);
            this.tbaula.TabIndex = 41;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label3.Location = new System.Drawing.Point(162, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(176, 16);
            this.label3.TabIndex = 40;
            this.label3.Text = "Hora de la Devolucion (24H)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label2.Location = new System.Drawing.Point(10, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 16);
            this.label2.TabIndex = 39;
            this.label2.Text = "Dia de Reserva";
            // 
            // dtdevolucion
            // 
            this.dtdevolucion.Enabled = false;
            this.dtdevolucion.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtdevolucion.Location = new System.Drawing.Point(165, 202);
            this.dtdevolucion.Name = "dtdevolucion";
            this.dtdevolucion.Size = new System.Drawing.Size(107, 22);
            this.dtdevolucion.TabIndex = 38;
            this.dtdevolucion.Value = new System.DateTime(2023, 6, 1, 0, 0, 0, 0);
            this.dtdevolucion.ValueChanged += new System.EventHandler(this.dtdevolucion_ValueChanged);
            // 
            // dtfecha
            // 
            this.dtfecha.Enabled = false;
            this.dtfecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtfecha.Location = new System.Drawing.Point(10, 155);
            this.dtfecha.Name = "dtfecha";
            this.dtfecha.Size = new System.Drawing.Size(107, 22);
            this.dtfecha.TabIndex = 37;
            this.dtfecha.ValueChanged += new System.EventHandler(this.dtsalida_ValueChanged);
            // 
            // Cedula
            // 
            this.Cedula.AutoSize = true;
            this.Cedula.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.Cedula.Location = new System.Drawing.Point(10, 40);
            this.Cedula.Name = "Cedula";
            this.Cedula.Size = new System.Drawing.Size(50, 16);
            this.Cedula.TabIndex = 29;
            this.Cedula.Text = "Cedula";
            // 
            // lblnombre
            // 
            this.lblnombre.AutoSize = true;
            this.lblnombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lblnombre.Location = new System.Drawing.Point(122, 41);
            this.lblnombre.Name = "lblnombre";
            this.lblnombre.Size = new System.Drawing.Size(132, 16);
            this.lblnombre.TabIndex = 26;
            this.lblnombre.Text = "Nombre del Docente";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label4.Location = new System.Drawing.Point(10, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 16);
            this.label4.TabIndex = 25;
            this.label4.Text = "Materia";
            // 
            // Btncerrar
            // 
            this.Btncerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btncerrar.FlatAppearance.BorderSize = 0;
            this.Btncerrar.Location = new System.Drawing.Point(366, 12);
            this.Btncerrar.Name = "Btncerrar";
            this.Btncerrar.Size = new System.Drawing.Size(21, 21);
            this.Btncerrar.TabIndex = 20;
            this.Btncerrar.UseVisualStyleBackColor = true;
            this.Btncerrar.Click += new System.EventHandler(this.Btncerrar_Click);
            // 
            // tbcedula
            // 
            this.tbcedula.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.tbcedula.Location = new System.Drawing.Point(10, 59);
            this.tbcedula.MaxLength = 10;
            this.tbcedula.Name = "tbcedula";
            this.tbcedula.ReadOnly = true;
            this.tbcedula.Size = new System.Drawing.Size(107, 22);
            this.tbcedula.TabIndex = 16;
            this.tbcedula.TextChanged += new System.EventHandler(this.tbeditorial_TextChanged);
            // 
            // tbnombre
            // 
            this.tbnombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.tbnombre.Location = new System.Drawing.Point(122, 59);
            this.tbnombre.MaxLength = 30;
            this.tbnombre.Name = "tbnombre";
            this.tbnombre.ReadOnly = true;
            this.tbnombre.Size = new System.Drawing.Size(226, 22);
            this.tbnombre.TabIndex = 11;
            this.tbnombre.TextChanged += new System.EventHandler(this.tbeditorial_TextChanged);
            // 
            // tbmateria
            // 
            this.tbmateria.Enabled = false;
            this.tbmateria.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.tbmateria.Location = new System.Drawing.Point(10, 109);
            this.tbmateria.MaxLength = 20;
            this.tbmateria.Name = "tbmateria";
            this.tbmateria.Size = new System.Drawing.Size(215, 22);
            this.tbmateria.TabIndex = 9;
            this.tbmateria.TextChanged += new System.EventHandler(this.tbeditorial_TextChanged);
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
            this.lblcabecera.Text = "Entregar";
            // 
            // entregarproyector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 306);
            this.ControlBox = false;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnanular);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "entregarproyector";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.btnanular.ResumeLayout(false);
            this.btnanular.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel btnanular;
        private Panel panel2;
        private Button Btncerrar;
        private TextBox tbmateria;
        private Label Cedula;
        private Label label4;
        public TextBox tbcedula;
        public Label lblcabecera;
        public Button btnentregar;
        private Label label3;
        private Label label2;
        private DateTimePicker dtdevolucion;
        private DateTimePicker dtfecha;
        private Label label5;
        private TextBox tbaula;
        private Label label1;
        private DateTimePicker dthora;
        public Button anular;
        public Label ID;
        public TextBox tbnombre;
        private TextBox tbidproyector;
        public Label lblnombre;
    }
}