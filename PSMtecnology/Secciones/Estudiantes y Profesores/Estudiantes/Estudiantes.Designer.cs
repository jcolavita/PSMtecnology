using System.Windows.Forms;

namespace TrabajoDeGrado.Secciones.Estudiantes_y_Profesores.Estudiantes
{
    partial class Estudiantes
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.CBescuela = new System.Windows.Forms.ComboBox();
            this.CBsexo = new System.Windows.Forms.ComboBox();
            this.Btnlimpiar = new System.Windows.Forms.Button();
            this.Btnbuscar = new System.Windows.Forms.Button();
            this.tbbuscarestudiante = new System.Windows.Forms.TextBox();
            this.Btncerrar = new System.Windows.Forms.Button();
            this.Btnagregar = new System.Windows.Forms.Button();
            this.lblestudiantes = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnsiguiente = new System.Windows.Forms.Button();
            this.btnanterior = new System.Windows.Forms.Button();
            this.lblpaginamaxima = new System.Windows.Forms.Label();
            this.lblpagnaactual = new System.Windows.Forms.Label();
            this.lbltotal = new System.Windows.Forms.Label();
            this.gridestudiantes = new System.Windows.Forms.DataGridView();
            this.btnreporte = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridestudiantes)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnreporte);
            this.panel1.Controls.Add(this.CBescuela);
            this.panel1.Controls.Add(this.CBsexo);
            this.panel1.Controls.Add(this.Btnlimpiar);
            this.panel1.Controls.Add(this.Btnbuscar);
            this.panel1.Controls.Add(this.tbbuscarestudiante);
            this.panel1.Controls.Add(this.Btncerrar);
            this.panel1.Controls.Add(this.Btnagregar);
            this.panel1.Controls.Add(this.lblestudiantes);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(843, 102);
            this.panel1.TabIndex = 0;
            // 
            // CBescuela
            // 
            this.CBescuela.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.CBescuela.FormattingEnabled = true;
            this.CBescuela.Items.AddRange(new object[] {
            "ESCUELA",
            "ARQUITECTURA (41)",
            "INGENIERÍA CIVIL (42)",
            "INGENIERÍA ELÉCTRICA (43)",
            "INGENIERÍA ELECTRÓNICA (44)",
            "INGENIERÍA INDUSTRIAL (45)",
            "INGENIERÍA DE MTTO. MECÁNICO (46)",
            "INGENIERÍA DE SISTEMAS (47)"});
            this.CBescuela.Location = new System.Drawing.Point(149, 66);
            this.CBescuela.Name = "CBescuela";
            this.CBescuela.Size = new System.Drawing.Size(175, 24);
            this.CBescuela.TabIndex = 10;
            this.CBescuela.Text = "ESCUELA";
            this.CBescuela.SelectedIndexChanged += new System.EventHandler(this.CBescuela_SelectedIndexChanged);
            // 
            // CBsexo
            // 
            this.CBsexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.CBsexo.FormattingEnabled = true;
            this.CBsexo.Items.AddRange(new object[] {
            "SEXO",
            "MASCULINO",
            "FEMENINO"});
            this.CBsexo.Location = new System.Drawing.Point(22, 66);
            this.CBsexo.Name = "CBsexo";
            this.CBsexo.Size = new System.Drawing.Size(122, 24);
            this.CBsexo.TabIndex = 9;
            this.CBsexo.Text = "SEXO";
            this.CBsexo.SelectedIndexChanged += new System.EventHandler(this.CBescuela_SelectedIndexChanged);
            // 
            // Btnlimpiar
            // 
            this.Btnlimpiar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btnlimpiar.Enabled = false;
            this.Btnlimpiar.FlatAppearance.BorderSize = 0;
            this.Btnlimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btnlimpiar.Image = global::PSMtecnology.Properties.Resources.cerrar;
            this.Btnlimpiar.Location = new System.Drawing.Point(787, 62);
            this.Btnlimpiar.Name = "Btnlimpiar";
            this.Btnlimpiar.Size = new System.Drawing.Size(26, 26);
            this.Btnlimpiar.TabIndex = 8;
            this.Btnlimpiar.UseVisualStyleBackColor = true;
            this.Btnlimpiar.Click += new System.EventHandler(this.Btnlimpiar_Click);
            // 
            // Btnbuscar
            // 
            this.Btnbuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btnbuscar.FlatAppearance.BorderSize = 0;
            this.Btnbuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btnbuscar.Image = global::PSMtecnology.Properties.Resources.lupa;
            this.Btnbuscar.Location = new System.Drawing.Point(757, 62);
            this.Btnbuscar.Name = "Btnbuscar";
            this.Btnbuscar.Size = new System.Drawing.Size(26, 26);
            this.Btnbuscar.TabIndex = 7;
            this.Btnbuscar.UseVisualStyleBackColor = true;
            this.Btnbuscar.Click += new System.EventHandler(this.Btnbuscar_Click);
            // 
            // tbbuscarestudiante
            // 
            this.tbbuscarestudiante.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbbuscarestudiante.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.tbbuscarestudiante.Location = new System.Drawing.Point(606, 66);
            this.tbbuscarestudiante.Name = "tbbuscarestudiante";
            this.tbbuscarestudiante.Size = new System.Drawing.Size(146, 22);
            this.tbbuscarestudiante.TabIndex = 6;
            this.tbbuscarestudiante.TextChanged += new System.EventHandler(this.tbbuscarestudiante_TextChanged);
            // 
            // Btncerrar
            // 
            this.Btncerrar.FlatAppearance.BorderSize = 0;
            this.Btncerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btncerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.Btncerrar.ForeColor = System.Drawing.Color.Gray;
            this.Btncerrar.Location = new System.Drawing.Point(10, 18);
            this.Btncerrar.Name = "Btncerrar";
            this.Btncerrar.Size = new System.Drawing.Size(64, 25);
            this.Btncerrar.TabIndex = 5;
            this.Btncerrar.Text = "Cerrar";
            this.Btncerrar.UseVisualStyleBackColor = true;
            this.Btncerrar.Click += new System.EventHandler(this.Btncerrar_Click);
            // 
            // Btnagregar
            // 
            this.Btnagregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btnagregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(24)))), ((int)(((byte)(67)))));
            this.Btnagregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btnagregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.Btnagregar.ForeColor = System.Drawing.Color.White;
            this.Btnagregar.Image = global::PSMtecnology.Properties.Resources.usuario_agregar;
            this.Btnagregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btnagregar.Location = new System.Drawing.Point(606, 10);
            this.Btnagregar.Name = "Btnagregar";
            this.Btnagregar.Size = new System.Drawing.Size(207, 41);
            this.Btnagregar.TabIndex = 4;
            this.Btnagregar.Text = "Agregar Nuevo Estuidiante";
            this.Btnagregar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btnagregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btnagregar.UseVisualStyleBackColor = false;
            this.Btnagregar.Click += new System.EventHandler(this.Btnagregar_Click);
            // 
            // lblestudiantes
            // 
            this.lblestudiantes.AutoSize = true;
            this.lblestudiantes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblestudiantes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(24)))), ((int)(((byte)(67)))));
            this.lblestudiantes.Location = new System.Drawing.Point(77, 17);
            this.lblestudiantes.Name = "lblestudiantes";
            this.lblestudiantes.Size = new System.Drawing.Size(118, 24);
            this.lblestudiantes.TabIndex = 3;
            this.lblestudiantes.Text = "Estudiantes";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(24)))), ((int)(((byte)(67)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.btnsiguiente);
            this.panel2.Controls.Add(this.btnanterior);
            this.panel2.Controls.Add(this.lblpaginamaxima);
            this.panel2.Controls.Add(this.lblpagnaactual);
            this.panel2.Controls.Add(this.lbltotal);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 605);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(843, 46);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(732, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(11, 15);
            this.label1.TabIndex = 19;
            this.label1.Text = "/";
            // 
            // btnsiguiente
            // 
            this.btnsiguiente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnsiguiente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnsiguiente.FlatAppearance.BorderSize = 0;
            this.btnsiguiente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsiguiente.Image = global::PSMtecnology.Properties.Resources.flecha_derecha;
            this.btnsiguiente.Location = new System.Drawing.Point(813, 15);
            this.btnsiguiente.Name = "btnsiguiente";
            this.btnsiguiente.Size = new System.Drawing.Size(21, 18);
            this.btnsiguiente.TabIndex = 18;
            this.btnsiguiente.UseVisualStyleBackColor = true;
            this.btnsiguiente.Click += new System.EventHandler(this.btnsiguiente_Click);
            // 
            // btnanterior
            // 
            this.btnanterior.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnanterior.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnanterior.FlatAppearance.BorderSize = 0;
            this.btnanterior.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnanterior.Image = global::PSMtecnology.Properties.Resources.flecha_izquierda;
            this.btnanterior.Location = new System.Drawing.Point(644, 12);
            this.btnanterior.Name = "btnanterior";
            this.btnanterior.Size = new System.Drawing.Size(21, 21);
            this.btnanterior.TabIndex = 17;
            this.btnanterior.UseVisualStyleBackColor = true;
            this.btnanterior.Click += new System.EventHandler(this.btnanterior_Click);
            // 
            // lblpaginamaxima
            // 
            this.lblpaginamaxima.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblpaginamaxima.AutoSize = true;
            this.lblpaginamaxima.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblpaginamaxima.ForeColor = System.Drawing.Color.White;
            this.lblpaginamaxima.Location = new System.Drawing.Point(770, 15);
            this.lblpaginamaxima.Name = "lblpaginamaxima";
            this.lblpaginamaxima.Size = new System.Drawing.Size(15, 15);
            this.lblpaginamaxima.TabIndex = 16;
            this.lblpaginamaxima.Text = "1";
            // 
            // lblpagnaactual
            // 
            this.lblpagnaactual.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblpagnaactual.AutoSize = true;
            this.lblpagnaactual.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblpagnaactual.ForeColor = System.Drawing.Color.White;
            this.lblpagnaactual.Location = new System.Drawing.Point(692, 15);
            this.lblpagnaactual.Name = "lblpagnaactual";
            this.lblpagnaactual.Size = new System.Drawing.Size(15, 15);
            this.lblpagnaactual.TabIndex = 15;
            this.lblpagnaactual.Text = "1";
            // 
            // lbltotal
            // 
            this.lbltotal.AutoSize = true;
            this.lbltotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.lbltotal.ForeColor = System.Drawing.Color.White;
            this.lbltotal.Location = new System.Drawing.Point(11, 14);
            this.lbltotal.Name = "lbltotal";
            this.lbltotal.Size = new System.Drawing.Size(51, 18);
            this.lbltotal.TabIndex = 14;
            this.lbltotal.Text = "Total:";
            // 
            // gridestudiantes
            // 
            this.gridestudiantes.AccessibleDescription = "";
            this.gridestudiantes.AccessibleName = "";
            this.gridestudiantes.AllowUserToAddRows = false;
            this.gridestudiantes.AllowUserToDeleteRows = false;
            this.gridestudiantes.AllowUserToResizeColumns = false;
            this.gridestudiantes.AllowUserToResizeRows = false;
            this.gridestudiantes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridestudiantes.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.gridestudiantes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridestudiantes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridestudiantes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridestudiantes.ColumnHeadersHeight = 50;
            this.gridestudiantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(226)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridestudiantes.DefaultCellStyle = dataGridViewCellStyle2;
            this.gridestudiantes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridestudiantes.EnableHeadersVisualStyles = false;
            this.gridestudiantes.GridColor = System.Drawing.Color.LightGray;
            this.gridestudiantes.Location = new System.Drawing.Point(0, 102);
            this.gridestudiantes.Name = "gridestudiantes";
            this.gridestudiantes.ReadOnly = true;
            this.gridestudiantes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(10);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridestudiantes.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.gridestudiantes.RowHeadersVisible = false;
            this.gridestudiantes.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(10);
            this.gridestudiantes.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.gridestudiantes.RowTemplate.Height = 48;
            this.gridestudiantes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.gridestudiantes.Size = new System.Drawing.Size(843, 503);
            this.gridestudiantes.TabIndex = 31;
            this.gridestudiantes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridestudiantes_CellContentClick);
            // 
            // btnreporte
            // 
            this.btnreporte.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnreporte.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(87)))), ((int)(((byte)(198)))));
            this.btnreporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnreporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btnreporte.ForeColor = System.Drawing.Color.White;
            this.btnreporte.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnreporte.Location = new System.Drawing.Point(502, 13);
            this.btnreporte.Name = "btnreporte";
            this.btnreporte.Size = new System.Drawing.Size(98, 35);
            this.btnreporte.TabIndex = 39;
            this.btnreporte.Text = "Reporte";
            this.btnreporte.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnreporte.UseVisualStyleBackColor = false;
            this.btnreporte.Click += new System.EventHandler(this.btnreporte_Click);
            // 
            // Estudiantes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 651);
            this.Controls.Add(this.gridestudiantes);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Estudiantes";
            this.Text = "Estudiantes";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridestudiantes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Button Btncerrar;
        private Button Btnagregar;
        private Button Btnbuscar;
        public DataGridView gridestudiantes;
        public Label lblestudiantes;
        public TextBox tbbuscarestudiante;
        private Button Btnlimpiar;
        private ComboBox CBescuela;
        private ComboBox CBsexo;
        private Label label1;
        private Button btnsiguiente;
        private Button btnanterior;
        private Label lblpaginamaxima;
        private Label lblpagnaactual;
        private Label lbltotal;
        private Button btnreporte;
    }
}