using System.Windows.Forms;

namespace TrabajoDeGrado.Secciones.Academico.Pasantias
{
    partial class rusticas
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
            this.tbtitulo = new System.Windows.Forms.RichTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbnombre = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cbperiodo = new System.Windows.Forms.ComboBox();
            this.tbresumen = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnbuscardocumento = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.Label();
            this.Btnagregar = new System.Windows.Forms.Button();
            this.tbruta = new System.Windows.Forms.TextBox();
            this.Ruta = new System.Windows.Forms.Label();
            this.btnlimpiar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbtitulo
            // 
            this.tbtitulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbtitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.tbtitulo.Location = new System.Drawing.Point(10, 86);
            this.tbtitulo.MaxLength = 120;
            this.tbtitulo.Name = "tbtitulo";
            this.tbtitulo.ReadOnly = true;
            this.tbtitulo.Size = new System.Drawing.Size(515, 51);
            this.tbtitulo.TabIndex = 47;
            this.tbtitulo.Text = "";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label9.Location = new System.Drawing.Point(10, 69);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 16);
            this.label9.TabIndex = 46;
            this.label9.Text = "Titulo";
            // 
            // tbnombre
            // 
            this.tbnombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.tbnombre.Location = new System.Drawing.Point(10, 37);
            this.tbnombre.MaxLength = 10;
            this.tbnombre.Name = "tbnombre";
            this.tbnombre.ReadOnly = true;
            this.tbnombre.Size = new System.Drawing.Size(407, 22);
            this.tbnombre.TabIndex = 49;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label6.Location = new System.Drawing.Point(10, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 16);
            this.label6.TabIndex = 48;
            this.label6.Text = "Autor";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label10.Location = new System.Drawing.Point(421, 21);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 16);
            this.label10.TabIndex = 51;
            this.label10.Text = "Periodo";
            // 
            // cbperiodo
            // 
            this.cbperiodo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbperiodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.cbperiodo.FormattingEnabled = true;
            this.cbperiodo.Location = new System.Drawing.Point(422, 37);
            this.cbperiodo.Name = "cbperiodo";
            this.cbperiodo.Size = new System.Drawing.Size(103, 24);
            this.cbperiodo.TabIndex = 50;
            // 
            // tbresumen
            // 
            this.tbresumen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbresumen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.tbresumen.Location = new System.Drawing.Point(10, 164);
            this.tbresumen.MaxLength = 0;
            this.tbresumen.Name = "tbresumen";
            this.tbresumen.Size = new System.Drawing.Size(515, 225);
            this.tbresumen.TabIndex = 53;
            this.tbresumen.Text = "";
            this.tbresumen.TextChanged += new System.EventHandler(this.tbresumen_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label1.Location = new System.Drawing.Point(10, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 16);
            this.label1.TabIndex = 52;
            this.label1.Text = "Resumen";
            // 
            // btnbuscardocumento
            // 
            this.btnbuscardocumento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(64)))));
            this.btnbuscardocumento.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnbuscardocumento.FlatAppearance.BorderSize = 0;
            this.btnbuscardocumento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnbuscardocumento.Image = global::PSMtecnology.Properties.Resources.agregar_archivo;
            this.btnbuscardocumento.Location = new System.Drawing.Point(368, 404);
            this.btnbuscardocumento.Name = "btnbuscardocumento";
            this.btnbuscardocumento.Size = new System.Drawing.Size(25, 26);
            this.btnbuscardocumento.TabIndex = 56;
            this.btnbuscardocumento.UseVisualStyleBackColor = false;
            this.btnbuscardocumento.Click += new System.EventHandler(this.btnbuscardocumento_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.ID);
            this.panel1.Controls.Add(this.Btnagregar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 431);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(535, 63);
            this.panel1.TabIndex = 57;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(24)))), ((int)(((byte)(67)))));
            this.label2.Location = new System.Drawing.Point(10, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 24);
            this.label2.TabIndex = 42;
            this.label2.Text = "ID:";
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.ID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(24)))), ((int)(((byte)(67)))));
            this.ID.Location = new System.Drawing.Point(45, 24);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(52, 24);
            this.ID.TabIndex = 41;
            this.ID.Text = "ID:id";
            // 
            // Btnagregar
            // 
            this.Btnagregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(63)))), ((int)(((byte)(192)))));
            this.Btnagregar.Enabled = false;
            this.Btnagregar.FlatAppearance.BorderSize = 0;
            this.Btnagregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btnagregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.Btnagregar.ForeColor = System.Drawing.Color.White;
            this.Btnagregar.Location = new System.Drawing.Point(416, 18);
            this.Btnagregar.Name = "Btnagregar";
            this.Btnagregar.Size = new System.Drawing.Size(103, 35);
            this.Btnagregar.TabIndex = 1;
            this.Btnagregar.Text = "Agregar";
            this.Btnagregar.UseVisualStyleBackColor = false;
            this.Btnagregar.Click += new System.EventHandler(this.Btnagregar_Click);
            // 
            // tbruta
            // 
            this.tbruta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.tbruta.Location = new System.Drawing.Point(10, 407);
            this.tbruta.MaxLength = 10;
            this.tbruta.Name = "tbruta";
            this.tbruta.ReadOnly = true;
            this.tbruta.Size = new System.Drawing.Size(353, 22);
            this.tbruta.TabIndex = 59;
            this.tbruta.TextChanged += new System.EventHandler(this.tbresumen_TextChanged);
            // 
            // Ruta
            // 
            this.Ruta.AutoSize = true;
            this.Ruta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.Ruta.Location = new System.Drawing.Point(10, 391);
            this.Ruta.Name = "Ruta";
            this.Ruta.Size = new System.Drawing.Size(143, 16);
            this.Ruta.TabIndex = 58;
            this.Ruta.Text = "Archivo (Formato PDF)";
            // 
            // btnlimpiar
            // 
            this.btnlimpiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnlimpiar.FlatAppearance.BorderSize = 0;
            this.btnlimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnlimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btnlimpiar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(24)))), ((int)(((byte)(67)))));
            this.btnlimpiar.Location = new System.Drawing.Point(398, 407);
            this.btnlimpiar.Name = "btnlimpiar";
            this.btnlimpiar.Size = new System.Drawing.Size(60, 21);
            this.btnlimpiar.TabIndex = 60;
            this.btnlimpiar.Text = "Limpiar";
            this.btnlimpiar.UseVisualStyleBackColor = true;
            this.btnlimpiar.Click += new System.EventHandler(this.btnlimpiar_Click);
            // 
            // rusticas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(535, 494);
            this.Controls.Add(this.btnlimpiar);
            this.Controls.Add(this.tbruta);
            this.Controls.Add(this.Ruta);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnbuscardocumento);
            this.Controls.Add(this.tbresumen);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cbperiodo);
            this.Controls.Add(this.tbnombre);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbtitulo);
            this.Controls.Add(this.label9);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "rusticas";
            this.Text = "rustica";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public RichTextBox tbtitulo;
        private Label label9;
        public TextBox tbnombre;
        private Label label6;
        private Label label10;
        public RichTextBox tbresumen;
        private Label label1;
        private Panel panel1;
        public Label ID;
        public Button Btnagregar;
        public TextBox tbruta;
        public ComboBox cbperiodo;
        public Button btnlimpiar;
        public Button btnbuscardocumento;
        public Label Ruta;
        public Label label2;
    }
}