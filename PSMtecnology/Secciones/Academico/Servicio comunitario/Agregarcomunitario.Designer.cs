using System.Windows.Forms;

namespace TrabajoDeGrado.Secciones.Estudiantes_y_Profesores.Estudiantes
{
    partial class Agregarcomunitario
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
            this.ID = new System.Windows.Forms.Label();
            this.LBLID = new System.Windows.Forms.Label();
            this.Btnagregar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btneliminar = new System.Windows.Forms.Button();
            this.cbexoneracion = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tbcomunidad = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.titulo = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lbestudiantes = new System.Windows.Forms.ListBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbperiodo = new System.Windows.Forms.ComboBox();
            this.Tbcedula = new System.Windows.Forms.TextBox();
            this.lblcabecera = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ID);
            this.panel1.Controls.Add(this.LBLID);
            this.panel1.Controls.Add(this.Btnagregar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 416);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(506, 87);
            this.panel1.TabIndex = 0;
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.ID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(24)))), ((int)(((byte)(67)))));
            this.ID.Location = new System.Drawing.Point(69, 33);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(52, 24);
            this.ID.TabIndex = 35;
            this.ID.Text = "ID:id";
            this.ID.Visible = false;
            // 
            // LBLID
            // 
            this.LBLID.AutoSize = true;
            this.LBLID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.LBLID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(24)))), ((int)(((byte)(67)))));
            this.LBLID.Location = new System.Drawing.Point(34, 33);
            this.LBLID.Name = "LBLID";
            this.LBLID.Size = new System.Drawing.Size(35, 24);
            this.LBLID.TabIndex = 34;
            this.LBLID.Text = "ID:";
            this.LBLID.Visible = false;
            // 
            // Btnagregar
            // 
            this.Btnagregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(24)))), ((int)(((byte)(67)))));
            this.Btnagregar.FlatAppearance.BorderSize = 0;
            this.Btnagregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btnagregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.Btnagregar.ForeColor = System.Drawing.Color.White;
            this.Btnagregar.Location = new System.Drawing.Point(370, 27);
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
            this.panel2.Controls.Add(this.btneliminar);
            this.panel2.Controls.Add(this.cbexoneracion);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.tbcomunidad);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.titulo);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.lbestudiantes);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.cbperiodo);
            this.panel2.Controls.Add(this.Tbcedula);
            this.panel2.Controls.Add(this.lblcabecera);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(506, 416);
            this.panel2.TabIndex = 1;
            // 
            // btneliminar
            // 
            this.btneliminar.BackColor = System.Drawing.Color.Transparent;
            this.btneliminar.FlatAppearance.BorderSize = 0;
            this.btneliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btneliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btneliminar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btneliminar.Location = new System.Drawing.Point(384, 179);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(69, 23);
            this.btneliminar.TabIndex = 41;
            this.btneliminar.Text = "Eliminar";
            this.btneliminar.UseVisualStyleBackColor = false;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // cbexoneracion
            // 
            this.cbexoneracion.AutoSize = true;
            this.cbexoneracion.Enabled = false;
            this.cbexoneracion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.cbexoneracion.Location = new System.Drawing.Point(53, 144);
            this.cbexoneracion.Name = "cbexoneracion";
            this.cbexoneracion.Size = new System.Drawing.Size(158, 20);
            this.cbexoneracion.TabIndex = 40;
            this.cbexoneracion.Text = "Estudiante Exonerado";
            this.cbexoneracion.UseVisualStyleBackColor = true;
            this.cbexoneracion.CheckedChanged += new System.EventHandler(this.cbexoneracion_CheckedChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(24)))), ((int)(((byte)(67)))));
            this.button1.Location = new System.Drawing.Point(193, 79);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(65, 31);
            this.button1.TabIndex = 38;
            this.button1.Text = "Agregar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbcomunidad
            // 
            this.tbcomunidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbcomunidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.tbcomunidad.Location = new System.Drawing.Point(54, 327);
            this.tbcomunidad.Name = "tbcomunidad";
            this.tbcomunidad.Size = new System.Drawing.Size(399, 53);
            this.tbcomunidad.TabIndex = 36;
            this.tbcomunidad.Text = "";
            this.tbcomunidad.TextChanged += new System.EventHandler(this.cbperiodo_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label4.Location = new System.Drawing.Point(54, 226);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 16);
            this.label4.TabIndex = 35;
            this.label4.Text = "Titulo";
            // 
            // titulo
            // 
            this.titulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.titulo.Location = new System.Drawing.Point(54, 243);
            this.titulo.Name = "titulo";
            this.titulo.Size = new System.Drawing.Size(399, 53);
            this.titulo.TabIndex = 34;
            this.titulo.Text = "";
            this.titulo.TextChanged += new System.EventHandler(this.cbperiodo_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label3.Location = new System.Drawing.Point(293, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 16);
            this.label3.TabIndex = 33;
            this.label3.Text = "Miembros (MAX 12)";
            // 
            // lbestudiantes
            // 
            this.lbestudiantes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lbestudiantes.FormattingEnabled = true;
            this.lbestudiantes.ItemHeight = 16;
            this.lbestudiantes.Location = new System.Drawing.Point(293, 89);
            this.lbestudiantes.Name = "lbestudiantes";
            this.lbestudiantes.Size = new System.Drawing.Size(160, 84);
            this.lbestudiantes.TabIndex = 32;
            this.lbestudiantes.SelectedIndexChanged += new System.EventHandler(this.lbestudiantes_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label10.Location = new System.Drawing.Point(54, 310);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(161, 16);
            this.label10.TabIndex = 31;
            this.label10.Text = "Nombre de la Comunidad";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label5.Location = new System.Drawing.Point(54, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 16);
            this.label5.TabIndex = 26;
            this.label5.Text = "Periodo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label2.Location = new System.Drawing.Point(54, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 16);
            this.label2.TabIndex = 23;
            this.label2.Text = "Cedula del Estudiante";
            // 
            // cbperiodo
            // 
            this.cbperiodo.DropDownHeight = 115;
            this.cbperiodo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbperiodo.Enabled = false;
            this.cbperiodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.cbperiodo.FormattingEnabled = true;
            this.cbperiodo.IntegralHeight = false;
            this.cbperiodo.Location = new System.Drawing.Point(54, 191);
            this.cbperiodo.Name = "cbperiodo";
            this.cbperiodo.Size = new System.Drawing.Size(135, 24);
            this.cbperiodo.TabIndex = 18;
            this.cbperiodo.SelectedValueChanged += new System.EventHandler(this.Cbsexo_SelectedValueChanged);
            this.cbperiodo.TextChanged += new System.EventHandler(this.cbperiodo_TextChanged);
            // 
            // Tbcedula
            // 
            this.Tbcedula.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.Tbcedula.Location = new System.Drawing.Point(54, 88);
            this.Tbcedula.Name = "Tbcedula";
            this.Tbcedula.Size = new System.Drawing.Size(133, 22);
            this.Tbcedula.TabIndex = 16;
            this.Tbcedula.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Tbcedula_KeyPress);
            // 
            // lblcabecera
            // 
            this.lblcabecera.AutoSize = true;
            this.lblcabecera.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblcabecera.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(24)))), ((int)(((byte)(67)))));
            this.lblcabecera.Location = new System.Drawing.Point(34, 22);
            this.lblcabecera.Name = "lblcabecera";
            this.lblcabecera.Size = new System.Drawing.Size(402, 24);
            this.lblcabecera.TabIndex = 8;
            this.lblcabecera.Text = "Agregar Proyecto de Servicio Comunitario";
            // 
            // Agregarcomunitario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 503);
            this.ControlBox = false;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(506, 503);
            this.MinimumSize = new System.Drawing.Size(506, 503);
            this.Name = "Agregarcomunitario";
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
        private TextBox Tbcedula;
        private Label label10;
        private Label label5;
        private Label label2;
        private Button button1;
        private RichTextBox tbcomunidad;
        private Label label4;
        private RichTextBox titulo;
        private Label label3;
        private ListBox lbestudiantes;
        private CheckBox cbexoneracion;
        private Button btneliminar;
        public Label ID;
        public Label LBLID;
        public ComboBox cbperiodo;
        public Button Btnagregar;
        public Label lblcabecera;
    }
}