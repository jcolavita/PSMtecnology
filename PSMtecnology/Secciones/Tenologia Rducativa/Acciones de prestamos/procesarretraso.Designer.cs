using System.Windows.Forms;

namespace TrabajoDeGrado.Secciones.Estudiantes_y_Profesores.Estudiantes
{
    partial class procesarretraso
        
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
            this.id = new System.Windows.Forms.Label();
            this.btnagregar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.tbestado = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TBNOMBRE = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtestipulada = new System.Windows.Forms.DateTimePicker();
            this.dtentrega = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.tbmotivo = new System.Windows.Forms.TextBox();
            this.lblnumero = new System.Windows.Forms.Label();
            this.tbnumero = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Btncerrar = new System.Windows.Forms.Button();
            this.tbtitulo = new System.Windows.Forms.TextBox();
            this.lblcabecera = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.id);
            this.panel1.Controls.Add(this.btnagregar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 209);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(413, 63);
            this.panel1.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(24)))), ((int)(((byte)(67)))));
            this.label8.Location = new System.Drawing.Point(10, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 24);
            this.label8.TabIndex = 48;
            this.label8.Text = "Retraso #:";
            // 
            // id
            // 
            this.id.AutoSize = true;
            this.id.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.id.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(24)))), ((int)(((byte)(67)))));
            this.id.Location = new System.Drawing.Point(120, 24);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(54, 24);
            this.id.TabIndex = 47;
            this.id.Text = "8888";
            // 
            // btnagregar
            // 
            this.btnagregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(24)))), ((int)(((byte)(67)))));
            this.btnagregar.Enabled = false;
            this.btnagregar.FlatAppearance.BorderSize = 0;
            this.btnagregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnagregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btnagregar.ForeColor = System.Drawing.Color.White;
            this.btnagregar.Location = new System.Drawing.Point(298, 20);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(103, 35);
            this.btnagregar.TabIndex = 1;
            this.btnagregar.Tag = "";
            this.btnagregar.Text = "Procesar";
            this.btnagregar.UseVisualStyleBackColor = false;
            this.btnagregar.Click += new System.EventHandler(this.Btnagregar_Click_1);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.radioButton2);
            this.panel2.Controls.Add(this.radioButton1);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.tbestado);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.TBNOMBRE);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.dtestipulada);
            this.panel2.Controls.Add(this.dtentrega);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.tbmotivo);
            this.panel2.Controls.Add(this.lblnumero);
            this.panel2.Controls.Add(this.tbnumero);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.Btncerrar);
            this.panel2.Controls.Add(this.tbtitulo);
            this.panel2.Controls.Add(this.lblcabecera);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(413, 209);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label9.Location = new System.Drawing.Point(10, 169);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 16);
            this.label9.TabIndex = 51;
            this.label9.Text = "Multa";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(51, 185);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(43, 20);
            this.radioButton2.TabIndex = 50;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "No";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(15, 185);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(37, 20);
            this.radioButton1.TabIndex = 49;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Si";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label7.Location = new System.Drawing.Point(231, 127);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 16);
            this.label7.TabIndex = 48;
            this.label7.Text = "Estado";
            // 
            // tbestado
            // 
            this.tbestado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.tbestado.Location = new System.Drawing.Point(231, 143);
            this.tbestado.Name = "tbestado";
            this.tbestado.ReadOnly = true;
            this.tbestado.Size = new System.Drawing.Size(150, 22);
            this.tbestado.TabIndex = 47;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label6.Location = new System.Drawing.Point(187, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(135, 16);
            this.label6.TabIndex = 46;
            this.label6.Text = "Fecha de Devolucion";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label4.Location = new System.Drawing.Point(10, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 16);
            this.label4.TabIndex = 45;
            this.label4.Text = "Nombre";
            // 
            // TBNOMBRE
            // 
            this.TBNOMBRE.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.TBNOMBRE.Location = new System.Drawing.Point(10, 57);
            this.TBNOMBRE.MaxLength = 30;
            this.TBNOMBRE.Name = "TBNOMBRE";
            this.TBNOMBRE.ReadOnly = true;
            this.TBNOMBRE.Size = new System.Drawing.Size(172, 22);
            this.TBNOMBRE.TabIndex = 44;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label3.Location = new System.Drawing.Point(204, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 16);
            this.label3.TabIndex = 43;
            this.label3.Text = "Fecha estipulada";
            // 
            // dtestipulada
            // 
            this.dtestipulada.Enabled = false;
            this.dtestipulada.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtestipulada.Location = new System.Drawing.Point(328, 47);
            this.dtestipulada.Name = "dtestipulada";
            this.dtestipulada.Size = new System.Drawing.Size(77, 22);
            this.dtestipulada.TabIndex = 42;
            // 
            // dtentrega
            // 
            this.dtentrega.Enabled = false;
            this.dtentrega.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtentrega.Location = new System.Drawing.Point(328, 71);
            this.dtentrega.Name = "dtentrega";
            this.dtentrega.Size = new System.Drawing.Size(77, 22);
            this.dtentrega.TabIndex = 41;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label2.Location = new System.Drawing.Point(10, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 16);
            this.label2.TabIndex = 40;
            this.label2.Text = "Motivo de Retraso";
            // 
            // tbmotivo
            // 
            this.tbmotivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.tbmotivo.Location = new System.Drawing.Point(10, 143);
            this.tbmotivo.Name = "tbmotivo";
            this.tbmotivo.ReadOnly = true;
            this.tbmotivo.Size = new System.Drawing.Size(217, 22);
            this.tbmotivo.TabIndex = 39;
            // 
            // lblnumero
            // 
            this.lblnumero.AutoSize = true;
            this.lblnumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lblnumero.Location = new System.Drawing.Point(120, 168);
            this.lblnumero.Name = "lblnumero";
            this.lblnumero.Size = new System.Drawing.Size(122, 16);
            this.lblnumero.TabIndex = 36;
            this.lblnumero.Text = "Numero de Factura";
            this.lblnumero.Visible = false;
            // 
            // tbnumero
            // 
            this.tbnumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.tbnumero.Location = new System.Drawing.Point(120, 184);
            this.tbnumero.Name = "tbnumero";
            this.tbnumero.Size = new System.Drawing.Size(129, 22);
            this.tbnumero.TabIndex = 35;
            this.tbnumero.Visible = false;
            this.tbnumero.TextChanged += new System.EventHandler(this.tbcantidad_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label5.Location = new System.Drawing.Point(7, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 16);
            this.label5.TabIndex = 26;
            this.label5.Text = "Titulo";
            // 
            // Btncerrar
            // 
            this.Btncerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btncerrar.FlatAppearance.BorderSize = 0;
            this.Btncerrar.Image = global::PSMtecnology.Properties.Resources.cerrar;
            this.Btncerrar.Location = new System.Drawing.Point(380, 8);
            this.Btncerrar.Name = "Btncerrar";
            this.Btncerrar.Size = new System.Drawing.Size(21, 21);
            this.Btncerrar.TabIndex = 20;
            this.Btncerrar.UseVisualStyleBackColor = true;
            this.Btncerrar.Click += new System.EventHandler(this.Btncerrar_Click);
            // 
            // tbtitulo
            // 
            this.tbtitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.tbtitulo.Location = new System.Drawing.Point(10, 102);
            this.tbtitulo.MaxLength = 30;
            this.tbtitulo.Name = "tbtitulo";
            this.tbtitulo.ReadOnly = true;
            this.tbtitulo.Size = new System.Drawing.Size(371, 22);
            this.tbtitulo.TabIndex = 11;
            this.tbtitulo.TextChanged += new System.EventHandler(this.tbcantidad_TextChanged);
            // 
            // lblcabecera
            // 
            this.lblcabecera.AutoSize = true;
            this.lblcabecera.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblcabecera.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(24)))), ((int)(((byte)(67)))));
            this.lblcabecera.Location = new System.Drawing.Point(10, 8);
            this.lblcabecera.Name = "lblcabecera";
            this.lblcabecera.Size = new System.Drawing.Size(170, 24);
            this.lblcabecera.TabIndex = 8;
            this.lblcabecera.Text = "Procesar Retraso";
            // 
            // procesarretraso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 272);
            this.ControlBox = false;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MaximumSize = new System.Drawing.Size(538, 288);
            this.Name = "procesarretraso";
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
        private Label label5;
        public Label lblcabecera;
        public Button btnagregar;
        private Label lblnumero;
        private Label label6;
        private Label label4;
        private Label label3;
        private DateTimePicker dtestipulada;
        private DateTimePicker dtentrega;
        private Label label2;
        private TextBox tbmotivo;
        public Label id;
        public TextBox TBNOMBRE;
        public TextBox tbnumero;
        private Label label7;
        private TextBox tbestado;
        public Label label8;
        private Label label9;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
    }
}