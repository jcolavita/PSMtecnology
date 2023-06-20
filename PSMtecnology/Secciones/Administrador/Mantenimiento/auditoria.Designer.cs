using System.Windows.Forms;

namespace TrabajoDeGrado.Secciones.Estudiantes_y_Profesores
{
    partial class auditoria
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.hasta = new System.Windows.Forms.DateTimePicker();
            this.cbusuario = new System.Windows.Forms.ComboBox();
            this.btnreporte = new System.Windows.Forms.Button();
            this.desde = new System.Windows.Forms.DateTimePicker();
            this.cbaccion = new System.Windows.Forms.ComboBox();
            this.Btnlimpiar = new System.Windows.Forms.Button();
            this.Btnbusqueda = new System.Windows.Forms.Button();
            this.tbbusqueda = new System.Windows.Forms.TextBox();
            this.Btnbuscar = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Btncerrar = new System.Windows.Forms.Button();
            this.Btnagregar = new System.Windows.Forms.Button();
            this.lblprofesres = new System.Windows.Forms.Label();
            this.grid = new System.Windows.Forms.DataGridView();
            this.cbacciones = new System.Windows.Forms.CheckBox();
            this.cbusuarios = new System.Windows.Forms.CheckBox();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
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
            this.panel2.Size = new System.Drawing.Size(843, 46);
            this.panel2.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(731, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(11, 15);
            this.label1.TabIndex = 13;
            this.label1.Text = "/";
            // 
            // btnsiguiente
            // 
            this.btnsiguiente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnsiguiente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnsiguiente.Enabled = false;
            this.btnsiguiente.FlatAppearance.BorderSize = 0;
            this.btnsiguiente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsiguiente.Image = global::PSMtecnology.Properties.Resources.flecha_derecha;
            this.btnsiguiente.Location = new System.Drawing.Point(812, 16);
            this.btnsiguiente.Name = "btnsiguiente";
            this.btnsiguiente.Size = new System.Drawing.Size(21, 18);
            this.btnsiguiente.TabIndex = 12;
            this.btnsiguiente.UseVisualStyleBackColor = true;
            this.btnsiguiente.Click += new System.EventHandler(this.btnsiguiente_Click);
            // 
            // btnanterior
            // 
            this.btnanterior.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnanterior.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnanterior.Enabled = false;
            this.btnanterior.FlatAppearance.BorderSize = 0;
            this.btnanterior.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnanterior.Image = global::PSMtecnology.Properties.Resources.flecha_izquierda;
            this.btnanterior.Location = new System.Drawing.Point(643, 13);
            this.btnanterior.Name = "btnanterior";
            this.btnanterior.Size = new System.Drawing.Size(21, 21);
            this.btnanterior.TabIndex = 11;
            this.btnanterior.UseVisualStyleBackColor = true;
            this.btnanterior.Click += new System.EventHandler(this.btnanterior_Click);
            // 
            // lblpaginamaxima
            // 
            this.lblpaginamaxima.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblpaginamaxima.AutoSize = true;
            this.lblpaginamaxima.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblpaginamaxima.ForeColor = System.Drawing.Color.White;
            this.lblpaginamaxima.Location = new System.Drawing.Point(769, 16);
            this.lblpaginamaxima.Name = "lblpaginamaxima";
            this.lblpaginamaxima.Size = new System.Drawing.Size(15, 15);
            this.lblpaginamaxima.TabIndex = 10;
            this.lblpaginamaxima.Text = "1";
            this.lblpaginamaxima.Click += new System.EventHandler(this.lblpaginamaxima_Click);
            // 
            // lblpagnaactual
            // 
            this.lblpagnaactual.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblpagnaactual.AutoSize = true;
            this.lblpagnaactual.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblpagnaactual.ForeColor = System.Drawing.Color.White;
            this.lblpagnaactual.Location = new System.Drawing.Point(691, 16);
            this.lblpagnaactual.Name = "lblpagnaactual";
            this.lblpagnaactual.Size = new System.Drawing.Size(15, 15);
            this.lblpagnaactual.TabIndex = 9;
            this.lblpagnaactual.Text = "1";
            // 
            // lbltotal
            // 
            this.lbltotal.AutoSize = true;
            this.lbltotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.lbltotal.ForeColor = System.Drawing.Color.White;
            this.lbltotal.Location = new System.Drawing.Point(10, 15);
            this.lbltotal.Name = "lbltotal";
            this.lbltotal.Size = new System.Drawing.Size(51, 18);
            this.lbltotal.TabIndex = 8;
            this.lbltotal.Text = "Total:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.cbusuarios);
            this.panel1.Controls.Add(this.cbacciones);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.hasta);
            this.panel1.Controls.Add(this.cbusuario);
            this.panel1.Controls.Add(this.btnreporte);
            this.panel1.Controls.Add(this.desde);
            this.panel1.Controls.Add(this.cbaccion);
            this.panel1.Controls.Add(this.Btnlimpiar);
            this.panel1.Controls.Add(this.Btnbusqueda);
            this.panel1.Controls.Add(this.tbbusqueda);
            this.panel1.Controls.Add(this.Btnbuscar);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.Btncerrar);
            this.panel1.Controls.Add(this.Btnagregar);
            this.panel1.Controls.Add(this.lblprofesres);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(843, 102);
            this.panel1.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(455, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 15);
            this.label3.TabIndex = 42;
            this.label3.Text = "Hasta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(338, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 15);
            this.label2.TabIndex = 41;
            this.label2.Text = "Desde";
            // 
            // hasta
            // 
            this.hasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.hasta.Location = new System.Drawing.Point(458, 68);
            this.hasta.Name = "hasta";
            this.hasta.Size = new System.Drawing.Size(115, 21);
            this.hasta.TabIndex = 40;
            this.hasta.ValueChanged += new System.EventHandler(this.desde_ValueChanged);
            // 
            // cbusuario
            // 
            this.cbusuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.cbusuario.FormattingEnabled = true;
            this.cbusuario.Location = new System.Drawing.Point(202, 66);
            this.cbusuario.Name = "cbusuario";
            this.cbusuario.Size = new System.Drawing.Size(129, 24);
            this.cbusuario.TabIndex = 39;
            this.cbusuario.SelectedIndexChanged += new System.EventHandler(this.CBescuela_SelectedIndexChanged);
            // 
            // btnreporte
            // 
            this.btnreporte.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnreporte.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(87)))), ((int)(((byte)(198)))));
            this.btnreporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnreporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btnreporte.ForeColor = System.Drawing.Color.White;
            this.btnreporte.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnreporte.Location = new System.Drawing.Point(654, 18);
            this.btnreporte.Name = "btnreporte";
            this.btnreporte.Size = new System.Drawing.Size(98, 35);
            this.btnreporte.TabIndex = 38;
            this.btnreporte.Text = "Reporte";
            this.btnreporte.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnreporte.UseVisualStyleBackColor = false;
            this.btnreporte.Click += new System.EventHandler(this.btnreporte_Click);
            // 
            // desde
            // 
            this.desde.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.desde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.desde.Location = new System.Drawing.Point(337, 68);
            this.desde.Name = "desde";
            this.desde.Size = new System.Drawing.Size(115, 21);
            this.desde.TabIndex = 35;
            this.desde.ValueChanged += new System.EventHandler(this.desde_ValueChanged);
            // 
            // cbaccion
            // 
            this.cbaccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.cbaccion.FormattingEnabled = true;
            this.cbaccion.Location = new System.Drawing.Point(21, 67);
            this.cbaccion.Name = "cbaccion";
            this.cbaccion.Size = new System.Drawing.Size(175, 24);
            this.cbaccion.TabIndex = 34;
            this.cbaccion.SelectedIndexChanged += new System.EventHandler(this.CBescuela_SelectedIndexChanged);
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
            this.Btnlimpiar.TabIndex = 11;
            this.Btnlimpiar.UseVisualStyleBackColor = true;
            this.Btnlimpiar.Click += new System.EventHandler(this.Btnlimpiar_Click);
            // 
            // Btnbusqueda
            // 
            this.Btnbusqueda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btnbusqueda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btnbusqueda.FlatAppearance.BorderSize = 0;
            this.Btnbusqueda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btnbusqueda.Image = global::PSMtecnology.Properties.Resources.lupa;
            this.Btnbusqueda.Location = new System.Drawing.Point(757, 62);
            this.Btnbusqueda.Name = "Btnbusqueda";
            this.Btnbusqueda.Size = new System.Drawing.Size(26, 26);
            this.Btnbusqueda.TabIndex = 10;
            this.Btnbusqueda.UseVisualStyleBackColor = true;
            this.Btnbusqueda.Click += new System.EventHandler(this.Btnbuscarprofesor_Click);
            // 
            // tbbusqueda
            // 
            this.tbbusqueda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbbusqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.tbbusqueda.Location = new System.Drawing.Point(606, 68);
            this.tbbusqueda.MaxLength = 20;
            this.tbbusqueda.Name = "tbbusqueda";
            this.tbbusqueda.Size = new System.Drawing.Size(146, 22);
            this.tbbusqueda.TabIndex = 9;
            this.tbbusqueda.TextChanged += new System.EventHandler(this.tbbusqueda_TextChanged);
            // 
            // Btnbuscar
            // 
            this.Btnbuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btnbuscar.FlatAppearance.BorderSize = 0;
            this.Btnbuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btnbuscar.Location = new System.Drawing.Point(1460, 62);
            this.Btnbuscar.Name = "Btnbuscar";
            this.Btnbuscar.Size = new System.Drawing.Size(26, 26);
            this.Btnbuscar.TabIndex = 7;
            this.Btnbuscar.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(1307, 66);
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
            this.Btnagregar.Location = new System.Drawing.Point(1307, 10);
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
            this.lblprofesres.Size = new System.Drawing.Size(93, 24);
            this.lblprofesres.TabIndex = 3;
            this.lblprofesres.Text = "Auditoria";
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
            this.grid.Size = new System.Drawing.Size(843, 503);
            this.grid.TabIndex = 32;
            // 
            // cbacciones
            // 
            this.cbacciones.AutoSize = true;
            this.cbacciones.Location = new System.Drawing.Point(21, 48);
            this.cbacciones.Name = "cbacciones";
            this.cbacciones.Size = new System.Drawing.Size(119, 17);
            this.cbacciones.TabIndex = 43;
            this.cbacciones.Text = "Todas las Acciones";
            this.cbacciones.UseVisualStyleBackColor = true;
            this.cbacciones.CheckedChanged += new System.EventHandler(this.cbacciones_CheckedChanged);
            // 
            // cbusuarios
            // 
            this.cbusuarios.AutoSize = true;
            this.cbusuarios.Location = new System.Drawing.Point(202, 48);
            this.cbusuarios.Name = "cbusuarios";
            this.cbusuarios.Size = new System.Drawing.Size(116, 17);
            this.cbusuarios.TabIndex = 44;
            this.cbusuarios.Text = "Todos los Usuarios";
            this.cbusuarios.UseVisualStyleBackColor = true;
            this.cbusuarios.CheckedChanged += new System.EventHandler(this.cbacciones_CheckedChanged);
            // 
            // auditoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 651);
            this.ControlBox = false;
            this.Controls.Add(this.grid);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "auditoria";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Panel panel2;
        private Label lbltotal;
        private Panel panel1;
        private Button Btnbuscar;
        private TextBox textBox1;
        private Button Btncerrar;
        private Button Btnagregar;
        private Label lblprofesres;
        private Button Btnbusqueda;
        private TextBox tbbusqueda;
        public DataGridView grid;
        private Button Btnlimpiar;
        private ComboBox cbaccion;
        private Button btnsiguiente;
        private Button btnanterior;
        private Label lblpaginamaxima;
        private Label lblpagnaactual;
        private Label label1;
        private DateTimePicker desde;
        private Button btnreporte;
        private DateTimePicker hasta;
        private ComboBox cbusuario;
        private Label label3;
        private Label label2;
        private CheckBox cbusuarios;
        private CheckBox cbacciones;
    }
}