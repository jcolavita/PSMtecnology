using System.Windows.Forms;

namespace TrabajoDeGrado.Secciones.Estudiantes_y_Profesores.Estudiantes
{
    partial class Agregarlibro        
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.tbcantidad = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbeditorial = new System.Windows.Forms.TextBox();
            this.cbmateria = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
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
            this.panel1.Location = new System.Drawing.Point(0, 270);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(383, 63);
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
            this.btnagregar.Location = new System.Drawing.Point(270, 18);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(103, 35);
            this.btnagregar.TabIndex = 1;
            this.btnagregar.Tag = "";
            this.btnagregar.Text = "Agregar";
            this.btnagregar.UseVisualStyleBackColor = false;
            this.btnagregar.Click += new System.EventHandler(this.Btnagregar_Click_1);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.comboBox1);
            this.panel2.Controls.Add(this.tbcantidad);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.tbeditorial);
            this.panel2.Controls.Add(this.cbmateria);
            this.panel2.Controls.Add(this.label10);
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
            this.panel2.Size = new System.Drawing.Size(383, 270);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "ESCUELAS",
            "ARQUITECTURA",
            "ELECTRONICA",
            "ELECTRICA",
            "CIVIL",
            "INDUSTRIAL",
            "MANTENIMIENTO MECANICO",
            "SISTEMAS"});
            this.comboBox1.Location = new System.Drawing.Point(10, 43);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(157, 24);
            this.comboBox1.TabIndex = 39;
            this.comboBox1.Text = "escuela";
            this.comboBox1.Visible = false;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // tbcantidad
            // 
            this.tbcantidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tbcantidad.FormattingEnabled = true;
            this.tbcantidad.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20"});
            this.tbcantidad.Location = new System.Drawing.Point(309, 85);
            this.tbcantidad.Name = "tbcantidad";
            this.tbcantidad.Size = new System.Drawing.Size(53, 24);
            this.tbcantidad.TabIndex = 37;
            this.tbcantidad.TextChanged += new System.EventHandler(this.tbcantidad_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label1.Location = new System.Drawing.Point(10, 198);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 36;
            this.label1.Text = "Editorial";
            // 
            // tbeditorial
            // 
            this.tbeditorial.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.tbeditorial.Location = new System.Drawing.Point(10, 214);
            this.tbeditorial.MaxLength = 30;
            this.tbeditorial.Name = "tbeditorial";
            this.tbeditorial.Size = new System.Drawing.Size(352, 22);
            this.tbeditorial.TabIndex = 35;
            this.tbeditorial.TextChanged += new System.EventHandler(this.tbcantidad_TextChanged);
            // 
            // cbmateria
            // 
            this.cbmateria.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.cbmateria.FormattingEnabled = true;
            this.cbmateria.Location = new System.Drawing.Point(148, 86);
            this.cbmateria.Name = "cbmateria";
            this.cbmateria.Size = new System.Drawing.Size(157, 24);
            this.cbmateria.TabIndex = 34;
            this.cbmateria.Text = "MATERIA";
            this.cbmateria.SelectedIndexChanged += new System.EventHandler(this.cbmateria_SelectedIndexChanged);
            this.cbmateria.TextChanged += new System.EventHandler(this.tbcantidad_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label10.Location = new System.Drawing.Point(309, 68);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 16);
            this.label10.TabIndex = 31;
            this.label10.Text = "Cantidad";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label8.Location = new System.Drawing.Point(10, 70);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 16);
            this.label8.TabIndex = 29;
            this.label8.Text = "Cota";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label5.Location = new System.Drawing.Point(10, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 16);
            this.label5.TabIndex = 26;
            this.label5.Text = "Titulo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label4.Location = new System.Drawing.Point(10, 155);
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
            this.Btncerrar.Location = new System.Drawing.Point(360, 3);
            this.Btncerrar.Name = "Btncerrar";
            this.Btncerrar.Size = new System.Drawing.Size(21, 21);
            this.Btncerrar.TabIndex = 20;
            this.Btncerrar.UseVisualStyleBackColor = true;
            this.Btncerrar.Click += new System.EventHandler(this.Btncerrar_Click);
            // 
            // tbcota
            // 
            this.tbcota.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.tbcota.Location = new System.Drawing.Point(10, 86);
            this.tbcota.MaxLength = 10;
            this.tbcota.Name = "tbcota";
            this.tbcota.ReadOnly = true;
            this.tbcota.Size = new System.Drawing.Size(132, 22);
            this.tbcota.TabIndex = 16;
            this.tbcota.TextChanged += new System.EventHandler(this.tbcantidad_TextChanged);
            // 
            // tbtitulo
            // 
            this.tbtitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.tbtitulo.Location = new System.Drawing.Point(10, 127);
            this.tbtitulo.MaxLength = 100;
            this.tbtitulo.Name = "tbtitulo";
            this.tbtitulo.Size = new System.Drawing.Size(352, 22);
            this.tbtitulo.TabIndex = 11;
            this.tbtitulo.TextChanged += new System.EventHandler(this.tbcantidad_TextChanged);
            // 
            // tbautor
            // 
            this.tbautor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.tbautor.Location = new System.Drawing.Point(10, 171);
            this.tbautor.MaxLength = 30;
            this.tbautor.Name = "tbautor";
            this.tbautor.Size = new System.Drawing.Size(352, 22);
            this.tbautor.TabIndex = 9;
            this.tbautor.TextChanged += new System.EventHandler(this.tbcantidad_TextChanged);
            // 
            // lblcabecera
            // 
            this.lblcabecera.AutoSize = true;
            this.lblcabecera.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblcabecera.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(24)))), ((int)(((byte)(67)))));
            this.lblcabecera.Location = new System.Drawing.Point(10, 8);
            this.lblcabecera.Name = "lblcabecera";
            this.lblcabecera.Size = new System.Drawing.Size(138, 24);
            this.lblcabecera.TabIndex = 8;
            this.lblcabecera.Text = "Agregar Libro";
            // 
            // Agregarlibro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 333);
            this.ControlBox = false;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Agregarlibro";
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
        private Label label10;
        private Label label8;
        private Label label5;
        private Label label4;
        public Label lblcabecera;
        public Button btnagregar;
        private Label label1;
        private TextBox tbeditorial;
        private ComboBox tbcantidad;
        public TextBox tbcota;
        public ComboBox cbmateria;
        public ComboBox comboBox1;
    }
}