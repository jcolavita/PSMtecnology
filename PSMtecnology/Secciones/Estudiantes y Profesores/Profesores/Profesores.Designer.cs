using System.Windows.Forms;

namespace TrabajoDeGrado.Secciones.Estudiantes_y_Profesores
{
    partial class Profesores
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnsiguiente = new System.Windows.Forms.Button();
            this.btnanterior = new System.Windows.Forms.Button();
            this.lblpaginamaxima = new System.Windows.Forms.Label();
            this.lblpagnaactual = new System.Windows.Forms.Label();
            this.lbltotal = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnreporte = new System.Windows.Forms.Button();
            this.panelcomunes = new System.Windows.Forms.Panel();
            this.comun47 = new System.Windows.Forms.CheckBox();
            this.comun44 = new System.Windows.Forms.CheckBox();
            this.comun45 = new System.Windows.Forms.CheckBox();
            this.comun42 = new System.Windows.Forms.CheckBox();
            this.comun46 = new System.Windows.Forms.CheckBox();
            this.comun43 = new System.Windows.Forms.CheckBox();
            this.comun41 = new System.Windows.Forms.CheckBox();
            this.Cbescuela = new System.Windows.Forms.ComboBox();
            this.CBprofesion = new System.Windows.Forms.ComboBox();
            this.Btnlimpiar = new System.Windows.Forms.Button();
            this.Btnbuscarprofesor = new System.Windows.Forms.Button();
            this.tbbuscarprofesores = new System.Windows.Forms.TextBox();
            this.Btnagregarprofesor = new System.Windows.Forms.Button();
            this.Btnbuscar = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Btncerrar = new System.Windows.Forms.Button();
            this.Btnagregar = new System.Windows.Forms.Button();
            this.lblprofesres = new System.Windows.Forms.Label();
            this.gridprofesores = new System.Windows.Forms.DataGridView();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelcomunes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridprofesores)).BeginInit();
            this.SuspendLayout();
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
            this.panel2.Size = new System.Drawing.Size(849, 46);
            this.panel2.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(738, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(11, 15);
            this.label1.TabIndex = 25;
            this.label1.Text = "/";
            // 
            // btnsiguiente
            // 
            this.btnsiguiente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnsiguiente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnsiguiente.FlatAppearance.BorderSize = 0;
            this.btnsiguiente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsiguiente.Image = global::PSMtecnology.Properties.Resources.flecha_derecha;
            this.btnsiguiente.Location = new System.Drawing.Point(819, 15);
            this.btnsiguiente.Name = "btnsiguiente";
            this.btnsiguiente.Size = new System.Drawing.Size(21, 18);
            this.btnsiguiente.TabIndex = 24;
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
            this.btnanterior.Location = new System.Drawing.Point(650, 12);
            this.btnanterior.Name = "btnanterior";
            this.btnanterior.Size = new System.Drawing.Size(21, 21);
            this.btnanterior.TabIndex = 23;
            this.btnanterior.UseVisualStyleBackColor = true;
            this.btnanterior.Click += new System.EventHandler(this.btnanterior_Click);
            // 
            // lblpaginamaxima
            // 
            this.lblpaginamaxima.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblpaginamaxima.AutoSize = true;
            this.lblpaginamaxima.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblpaginamaxima.ForeColor = System.Drawing.Color.White;
            this.lblpaginamaxima.Location = new System.Drawing.Point(776, 15);
            this.lblpaginamaxima.Name = "lblpaginamaxima";
            this.lblpaginamaxima.Size = new System.Drawing.Size(15, 15);
            this.lblpaginamaxima.TabIndex = 22;
            this.lblpaginamaxima.Text = "1";
            // 
            // lblpagnaactual
            // 
            this.lblpagnaactual.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblpagnaactual.AutoSize = true;
            this.lblpagnaactual.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblpagnaactual.ForeColor = System.Drawing.Color.White;
            this.lblpagnaactual.Location = new System.Drawing.Point(698, 15);
            this.lblpagnaactual.Name = "lblpagnaactual";
            this.lblpagnaactual.Size = new System.Drawing.Size(15, 15);
            this.lblpagnaactual.TabIndex = 21;
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
            this.lbltotal.TabIndex = 20;
            this.lbltotal.Text = "Total:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnreporte);
            this.panel1.Controls.Add(this.panelcomunes);
            this.panel1.Controls.Add(this.Cbescuela);
            this.panel1.Controls.Add(this.CBprofesion);
            this.panel1.Controls.Add(this.Btnlimpiar);
            this.panel1.Controls.Add(this.Btnbuscarprofesor);
            this.panel1.Controls.Add(this.tbbuscarprofesores);
            this.panel1.Controls.Add(this.Btnagregarprofesor);
            this.panel1.Controls.Add(this.Btnbuscar);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.Btncerrar);
            this.panel1.Controls.Add(this.Btnagregar);
            this.panel1.Controls.Add(this.lblprofesres);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(849, 102);
            this.panel1.TabIndex = 3;
            // 
            // btnreporte
            // 
            this.btnreporte.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnreporte.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(87)))), ((int)(((byte)(198)))));
            this.btnreporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnreporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btnreporte.ForeColor = System.Drawing.Color.White;
            this.btnreporte.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnreporte.Location = new System.Drawing.Point(508, 17);
            this.btnreporte.Name = "btnreporte";
            this.btnreporte.Size = new System.Drawing.Size(98, 35);
            this.btnreporte.TabIndex = 38;
            this.btnreporte.Text = "Reporte";
            this.btnreporte.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnreporte.UseVisualStyleBackColor = false;
            this.btnreporte.Click += new System.EventHandler(this.btnreporte_Click);
            // 
            // panelcomunes
            // 
            this.panelcomunes.Controls.Add(this.comun47);
            this.panelcomunes.Controls.Add(this.comun44);
            this.panelcomunes.Controls.Add(this.comun45);
            this.panelcomunes.Controls.Add(this.comun42);
            this.panelcomunes.Controls.Add(this.comun46);
            this.panelcomunes.Controls.Add(this.comun43);
            this.panelcomunes.Controls.Add(this.comun41);
            this.panelcomunes.Location = new System.Drawing.Point(323, 62);
            this.panelcomunes.Name = "panelcomunes";
            this.panelcomunes.Size = new System.Drawing.Size(288, 35);
            this.panelcomunes.TabIndex = 21;
            this.panelcomunes.Visible = false;
            // 
            // comun47
            // 
            this.comun47.AutoSize = true;
            this.comun47.Location = new System.Drawing.Point(247, 9);
            this.comun47.Name = "comun47";
            this.comun47.Size = new System.Drawing.Size(38, 17);
            this.comun47.TabIndex = 6;
            this.comun47.Text = "47";
            this.comun47.UseVisualStyleBackColor = true;
            this.comun47.CheckedChanged += new System.EventHandler(this.comun41_CheckedChanged);
            // 
            // comun44
            // 
            this.comun44.AutoSize = true;
            this.comun44.Location = new System.Drawing.Point(125, 10);
            this.comun44.Name = "comun44";
            this.comun44.Size = new System.Drawing.Size(38, 17);
            this.comun44.TabIndex = 5;
            this.comun44.Text = "44";
            this.comun44.UseVisualStyleBackColor = true;
            this.comun44.CheckedChanged += new System.EventHandler(this.comun41_CheckedChanged);
            // 
            // comun45
            // 
            this.comun45.AutoSize = true;
            this.comun45.Location = new System.Drawing.Point(166, 10);
            this.comun45.Name = "comun45";
            this.comun45.Size = new System.Drawing.Size(38, 17);
            this.comun45.TabIndex = 2;
            this.comun45.Text = "45";
            this.comun45.UseVisualStyleBackColor = true;
            this.comun45.CheckedChanged += new System.EventHandler(this.comun41_CheckedChanged);
            // 
            // comun42
            // 
            this.comun42.AutoSize = true;
            this.comun42.Location = new System.Drawing.Point(43, 10);
            this.comun42.Name = "comun42";
            this.comun42.Size = new System.Drawing.Size(38, 17);
            this.comun42.TabIndex = 4;
            this.comun42.Text = "42";
            this.comun42.UseVisualStyleBackColor = true;
            this.comun42.CheckedChanged += new System.EventHandler(this.comun41_CheckedChanged);
            // 
            // comun46
            // 
            this.comun46.AutoSize = true;
            this.comun46.Location = new System.Drawing.Point(207, 10);
            this.comun46.Name = "comun46";
            this.comun46.Size = new System.Drawing.Size(38, 17);
            this.comun46.TabIndex = 3;
            this.comun46.Text = "46";
            this.comun46.UseVisualStyleBackColor = true;
            this.comun46.CheckedChanged += new System.EventHandler(this.comun41_CheckedChanged);
            // 
            // comun43
            // 
            this.comun43.AutoSize = true;
            this.comun43.Location = new System.Drawing.Point(84, 10);
            this.comun43.Name = "comun43";
            this.comun43.Size = new System.Drawing.Size(38, 17);
            this.comun43.TabIndex = 1;
            this.comun43.Text = "43";
            this.comun43.UseVisualStyleBackColor = true;
            this.comun43.CheckedChanged += new System.EventHandler(this.comun41_CheckedChanged);
            // 
            // comun41
            // 
            this.comun41.AutoSize = true;
            this.comun41.Location = new System.Drawing.Point(3, 10);
            this.comun41.Name = "comun41";
            this.comun41.Size = new System.Drawing.Size(38, 17);
            this.comun41.TabIndex = 0;
            this.comun41.Text = "41";
            this.comun41.UseVisualStyleBackColor = true;
            this.comun41.CheckedChanged += new System.EventHandler(this.comun41_CheckedChanged);
            // 
            // Cbescuela
            // 
            this.Cbescuela.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.Cbescuela.FormattingEnabled = true;
            this.Cbescuela.Items.AddRange(new object[] {
            "ESCUELA",
            "COMUN",
            "ARQUITECTURA (41)",
            "INGENIERÍA CIVIL (42)",
            "INGENIERÍA ELÉCTRICA (43)",
            "INGENIERÍA ELECTRÓNICA (44)",
            "INGENIERÍA INDUSTRIAL (45)",
            "INGENIERÍA DE MTTO. MECÁNICO (46)",
            "INGENIERÍA DE SISTEMAS (47)"});
            this.Cbescuela.Location = new System.Drawing.Point(149, 67);
            this.Cbescuela.Name = "Cbescuela";
            this.Cbescuela.Size = new System.Drawing.Size(175, 24);
            this.Cbescuela.TabIndex = 13;
            this.Cbescuela.Text = "ESCUELA";
            this.Cbescuela.SelectedIndexChanged += new System.EventHandler(this.CBsexo_SelectedIndexChanged);
            // 
            // CBprofesion
            // 
            this.CBprofesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.CBprofesion.FormattingEnabled = true;
            this.CBprofesion.Items.AddRange(new object[] {
            "PROFESION",
            "ARQUITECTO/A",
            "INGENIERO/A",
            "LICENCIADO/A",
            "ABOGADO/A",
            "PROFESOR/A"});
            this.CBprofesion.Location = new System.Drawing.Point(22, 66);
            this.CBprofesion.Name = "CBprofesion";
            this.CBprofesion.Size = new System.Drawing.Size(122, 24);
            this.CBprofesion.TabIndex = 12;
            this.CBprofesion.Text = "PROFESION";
            this.CBprofesion.SelectedIndexChanged += new System.EventHandler(this.CBsexo_SelectedIndexChanged);
            // 
            // Btnlimpiar
            // 
            this.Btnlimpiar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btnlimpiar.Enabled = false;
            this.Btnlimpiar.FlatAppearance.BorderSize = 0;
            this.Btnlimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btnlimpiar.Image = global::PSMtecnology.Properties.Resources.cerrar;
            this.Btnlimpiar.Location = new System.Drawing.Point(794, 62);
            this.Btnlimpiar.Name = "Btnlimpiar";
            this.Btnlimpiar.Size = new System.Drawing.Size(26, 26);
            this.Btnlimpiar.TabIndex = 11;
            this.Btnlimpiar.UseVisualStyleBackColor = true;
            this.Btnlimpiar.Click += new System.EventHandler(this.Btnlimpiar_Click);
            // 
            // Btnbuscarprofesor
            // 
            this.Btnbuscarprofesor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btnbuscarprofesor.FlatAppearance.BorderSize = 0;
            this.Btnbuscarprofesor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btnbuscarprofesor.Image = global::PSMtecnology.Properties.Resources.lupa;
            this.Btnbuscarprofesor.Location = new System.Drawing.Point(763, 62);
            this.Btnbuscarprofesor.Name = "Btnbuscarprofesor";
            this.Btnbuscarprofesor.Size = new System.Drawing.Size(26, 26);
            this.Btnbuscarprofesor.TabIndex = 10;
            this.Btnbuscarprofesor.UseVisualStyleBackColor = true;
            this.Btnbuscarprofesor.Click += new System.EventHandler(this.Btnbuscarprofesor_Click);
            // 
            // tbbuscarprofesores
            // 
            this.tbbuscarprofesores.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbbuscarprofesores.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.tbbuscarprofesores.Location = new System.Drawing.Point(612, 68);
            this.tbbuscarprofesores.Name = "tbbuscarprofesores";
            this.tbbuscarprofesores.Size = new System.Drawing.Size(146, 22);
            this.tbbuscarprofesores.TabIndex = 9;
            this.tbbuscarprofesores.TextChanged += new System.EventHandler(this.tbbuscarprofesores_TextChanged);
            // 
            // Btnagregarprofesor
            // 
            this.Btnagregarprofesor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btnagregarprofesor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(24)))), ((int)(((byte)(67)))));
            this.Btnagregarprofesor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btnagregarprofesor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.Btnagregarprofesor.ForeColor = System.Drawing.Color.White;
            this.Btnagregarprofesor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btnagregarprofesor.Location = new System.Drawing.Point(612, 10);
            this.Btnagregarprofesor.Name = "Btnagregarprofesor";
            this.Btnagregarprofesor.Size = new System.Drawing.Size(207, 41);
            this.Btnagregarprofesor.TabIndex = 8;
            this.Btnagregarprofesor.Text = "Agregar Nuevo Profesor";
            this.Btnagregarprofesor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btnagregarprofesor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btnagregarprofesor.UseVisualStyleBackColor = false;
            this.Btnagregarprofesor.Click += new System.EventHandler(this.Btnagregarprofesor_Click);
            // 
            // Btnbuscar
            // 
            this.Btnbuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btnbuscar.FlatAppearance.BorderSize = 0;
            this.Btnbuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btnbuscar.Location = new System.Drawing.Point(1466, 62);
            this.Btnbuscar.Name = "Btnbuscar";
            this.Btnbuscar.Size = new System.Drawing.Size(26, 26);
            this.Btnbuscar.TabIndex = 7;
            this.Btnbuscar.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(1313, 66);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(146, 20);
            this.textBox1.TabIndex = 6;
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
            this.Btnagregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(63)))), ((int)(((byte)(192)))));
            this.Btnagregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btnagregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.Btnagregar.ForeColor = System.Drawing.Color.White;
            this.Btnagregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btnagregar.Location = new System.Drawing.Point(1313, 10);
            this.Btnagregar.Name = "Btnagregar";
            this.Btnagregar.Size = new System.Drawing.Size(178, 41);
            this.Btnagregar.TabIndex = 4;
            this.Btnagregar.Text = "Agregar Nuevo Estuidiante";
            this.Btnagregar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btnagregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btnagregar.UseVisualStyleBackColor = false;
            // 
            // lblprofesres
            // 
            this.lblprofesres.AutoSize = true;
            this.lblprofesres.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblprofesres.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(24)))), ((int)(((byte)(67)))));
            this.lblprofesres.Location = new System.Drawing.Point(77, 17);
            this.lblprofesres.Name = "lblprofesres";
            this.lblprofesres.Size = new System.Drawing.Size(110, 24);
            this.lblprofesres.TabIndex = 3;
            this.lblprofesres.Text = "Profesores";
            // 
            // gridprofesores
            // 
            this.gridprofesores.AccessibleDescription = "";
            this.gridprofesores.AccessibleName = "";
            this.gridprofesores.AllowUserToAddRows = false;
            this.gridprofesores.AllowUserToDeleteRows = false;
            this.gridprofesores.AllowUserToResizeColumns = false;
            this.gridprofesores.AllowUserToResizeRows = false;
            this.gridprofesores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridprofesores.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.gridprofesores.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridprofesores.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridprofesores.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridprofesores.ColumnHeadersHeight = 50;
            this.gridprofesores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(226)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridprofesores.DefaultCellStyle = dataGridViewCellStyle2;
            this.gridprofesores.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridprofesores.EnableHeadersVisualStyles = false;
            this.gridprofesores.GridColor = System.Drawing.Color.LightGray;
            this.gridprofesores.Location = new System.Drawing.Point(0, 102);
            this.gridprofesores.Name = "gridprofesores";
            this.gridprofesores.ReadOnly = true;
            this.gridprofesores.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(10);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridprofesores.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.gridprofesores.RowHeadersVisible = false;
            this.gridprofesores.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(10);
            this.gridprofesores.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.gridprofesores.RowTemplate.Height = 48;
            this.gridprofesores.Size = new System.Drawing.Size(849, 503);
            this.gridprofesores.TabIndex = 32;
            this.gridprofesores.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridprofesores_CellContentClick);
            // 
            // Profesores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 651);
            this.Controls.Add(this.gridprofesores);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Profesores";
            this.Text = "Profesores";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelcomunes.ResumeLayout(false);
            this.panelcomunes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridprofesores)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Panel panel2;
        private Panel panel1;
        private Button Btnbuscar;
        private TextBox textBox1;
        private Button Btncerrar;
        private Button Btnagregar;
        private Label lblprofesres;
        private Button Btnbuscarprofesor;
        private TextBox tbbuscarprofesores;
        private Button Btnagregarprofesor;
        public DataGridView gridprofesores;
        private Button Btnlimpiar;
        private ComboBox Cbescuela;
        private ComboBox CBprofesion;
        private Panel panelcomunes;
        private CheckBox comun47;
        private CheckBox comun44;
        private CheckBox comun45;
        private CheckBox comun42;
        private CheckBox comun46;
        private CheckBox comun43;
        private CheckBox comun41;
        private Label label1;
        private Button btnsiguiente;
        private Button btnanterior;
        private Label lblpaginamaxima;
        private Label lblpagnaactual;
        private Label lbltotal;
        private Button btnreporte;
    }
}