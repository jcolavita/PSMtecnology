using System.Windows.Forms;

namespace TrabajoDeGrado.Secciones.Estudiantes_y_Profesores.Estudiantes
{
    partial class Libros
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
            this.btnreporte = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.CBEXISTENCIAS = new System.Windows.Forms.ComboBox();
            this.cbmateria = new System.Windows.Forms.ComboBox();
            this.Btnlimpiar = new System.Windows.Forms.Button();
            this.Btnbuscar = new System.Windows.Forms.Button();
            this.tbbuscarestudiante = new System.Windows.Forms.TextBox();
            this.Btncerrar = new System.Windows.Forms.Button();
            this.Btnagregar = new System.Windows.Forms.Button();
            this.lblestudiantes = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbltotal = new System.Windows.Forms.Label();
            this.grid = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnreporte);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.CBEXISTENCIAS);
            this.panel1.Controls.Add(this.cbmateria);
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
            this.btnreporte.TabIndex = 41;
            this.btnreporte.Text = "Reporte";
            this.btnreporte.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnreporte.UseVisualStyleBackColor = false;
            this.btnreporte.Click += new System.EventHandler(this.btnreporte_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "COMUNES",
            "ARQUITECTURA",
            "ELECTRONICA",
            "ELECTRICA",
            "CIVIL",
            "INDUSTRIAL",
            "MANTENIMIENTO MECANICO",
            "SISTEMAS"});
            this.comboBox1.Location = new System.Drawing.Point(192, 19);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(157, 24);
            this.comboBox1.TabIndex = 40;
            this.comboBox1.Text = "ESCUELA";
            this.comboBox1.Visible = false;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // CBEXISTENCIAS
            // 
            this.CBEXISTENCIAS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBEXISTENCIAS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.CBEXISTENCIAS.FormattingEnabled = true;
            this.CBEXISTENCIAS.Items.AddRange(new object[] {
            "EXISTENCIAS",
            "EXISTENCIAS 0"});
            this.CBEXISTENCIAS.Location = new System.Drawing.Point(176, 72);
            this.CBEXISTENCIAS.Name = "CBEXISTENCIAS";
            this.CBEXISTENCIAS.Size = new System.Drawing.Size(120, 24);
            this.CBEXISTENCIAS.TabIndex = 10;
            this.CBEXISTENCIAS.SelectedIndexChanged += new System.EventHandler(this.CBescuela_SelectedIndexChanged);
            // 
            // cbmateria
            // 
            this.cbmateria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbmateria.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.cbmateria.FormattingEnabled = true;
            this.cbmateria.Location = new System.Drawing.Point(13, 72);
            this.cbmateria.Name = "cbmateria";
            this.cbmateria.Size = new System.Drawing.Size(157, 24);
            this.cbmateria.TabIndex = 9;
            this.cbmateria.SelectedIndexChanged += new System.EventHandler(this.CBescuela_SelectedIndexChanged);
            // 
            // Btnlimpiar
            // 
            this.Btnlimpiar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btnlimpiar.Enabled = false;
            this.Btnlimpiar.FlatAppearance.BorderSize = 0;
            this.Btnlimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btnlimpiar.Image = global::PSMtecnology.Properties.Resources.cerrar;
            this.Btnlimpiar.Location = new System.Drawing.Point(788, 62);
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
            this.Btnagregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btnagregar.Location = new System.Drawing.Point(606, 10);
            this.Btnagregar.Name = "Btnagregar";
            this.Btnagregar.Size = new System.Drawing.Size(207, 41);
            this.Btnagregar.TabIndex = 4;
            this.Btnagregar.Text = "Agregar Nuevo Libro";
            this.Btnagregar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btnagregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btnagregar.UseVisualStyleBackColor = false;
            this.Btnagregar.Visible = false;
            this.Btnagregar.Click += new System.EventHandler(this.Btnagregar_Click);
            // 
            // lblestudiantes
            // 
            this.lblestudiantes.AutoSize = true;
            this.lblestudiantes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblestudiantes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(24)))), ((int)(((byte)(67)))));
            this.lblestudiantes.Location = new System.Drawing.Point(77, 17);
            this.lblestudiantes.Name = "lblestudiantes";
            this.lblestudiantes.Size = new System.Drawing.Size(67, 24);
            this.lblestudiantes.TabIndex = 3;
            this.lblestudiantes.Text = "Libros";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.lbltotal);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 605);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(843, 46);
            this.panel2.TabIndex = 1;
            // 
            // lbltotal
            // 
            this.lbltotal.AutoSize = true;
            this.lbltotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.lbltotal.Location = new System.Drawing.Point(10, 15);
            this.lbltotal.Name = "lbltotal";
            this.lbltotal.Size = new System.Drawing.Size(51, 18);
            this.lbltotal.TabIndex = 8;
            this.lbltotal.Text = "Total:";
            // 
            // grid
            // 
            this.grid.AccessibleDescription = "";
            this.grid.AccessibleName = "";
            this.grid.AllowUserToAddRows = false;
            this.grid.AllowUserToDeleteRows = false;
            this.grid.AllowUserToResizeColumns = false;
            this.grid.AllowUserToResizeRows = false;
            this.grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grid.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.grid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grid.ColumnHeadersHeight = 50;
            this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(226)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grid.DefaultCellStyle = dataGridViewCellStyle2;
            this.grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid.EnableHeadersVisualStyles = false;
            this.grid.GridColor = System.Drawing.Color.LightGray;
            this.grid.Location = new System.Drawing.Point(0, 102);
            this.grid.Name = "grid";
            this.grid.ReadOnly = true;
            this.grid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(10);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.grid.RowHeadersVisible = false;
            this.grid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(10);
            this.grid.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.grid.RowTemplate.Height = 48;
            this.grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.grid.Size = new System.Drawing.Size(843, 503);
            this.grid.TabIndex = 31;
            this.grid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridestudiantes_CellContentClick);
            // 
            // Libros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 651);
            this.Controls.Add(this.grid);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Libros";
            this.Text = "Estudiantes";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Button Btncerrar;
        private Button Btnagregar;
        private Button Btnbuscar;
        private Label lbltotal;
        public DataGridView grid;
        public Label lblestudiantes;
        public TextBox tbbuscarestudiante;
        private Button Btnlimpiar;
        private ComboBox cbmateria;
        private ComboBox CBEXISTENCIAS;
        public ComboBox comboBox1;
        private Button btnreporte;
    }
}