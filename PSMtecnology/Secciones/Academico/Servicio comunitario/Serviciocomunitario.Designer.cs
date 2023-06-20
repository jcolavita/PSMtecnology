using System.Windows.Forms;

namespace TrabajoDeGrado.Secciones.Estudiantes_y_Profesores
{
    partial class Serviciocomunitario
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
            this.lbltotal = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbperiodo = new System.Windows.Forms.ComboBox();
            this.Btnlimpiar = new System.Windows.Forms.Button();
            this.Btnbusqueda = new System.Windows.Forms.Button();
            this.tbbusqueda = new System.Windows.Forms.TextBox();
            this.Btnagregarprofesor = new System.Windows.Forms.Button();
            this.Btnbuscar = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Btncerrar = new System.Windows.Forms.Button();
            this.Btnagregar = new System.Windows.Forms.Button();
            this.lblprofesres = new System.Windows.Forms.Label();
            this.gridcomunitario = new System.Windows.Forms.DataGridView();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridcomunitario)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(24)))), ((int)(((byte)(67)))));
            this.panel2.Controls.Add(this.lbltotal);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 605);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(843, 46);
            this.panel2.TabIndex = 4;
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
            this.panel1.Controls.Add(this.cbperiodo);
            this.panel1.Controls.Add(this.Btnlimpiar);
            this.panel1.Controls.Add(this.Btnbusqueda);
            this.panel1.Controls.Add(this.tbbusqueda);
            this.panel1.Controls.Add(this.Btnagregarprofesor);
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
            // cbperiodo
            // 
            this.cbperiodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.cbperiodo.FormattingEnabled = true;
            this.cbperiodo.Items.AddRange(new object[] {
            "PERIODO"});
            this.cbperiodo.Location = new System.Drawing.Point(10, 65);
            this.cbperiodo.Name = "cbperiodo";
            this.cbperiodo.Size = new System.Drawing.Size(109, 24);
            this.cbperiodo.TabIndex = 37;
            this.cbperiodo.Text = "PERIODO";
            this.cbperiodo.SelectedIndexChanged += new System.EventHandler(this.cbperiodo_SelectedIndexChanged);
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
            this.tbbusqueda.Location = new System.Drawing.Point(606, 68);
            this.tbbusqueda.Name = "tbbusqueda";
            this.tbbusqueda.Size = new System.Drawing.Size(146, 20);
            this.tbbusqueda.TabIndex = 9;
            // 
            // Btnagregarprofesor
            // 
            this.Btnagregarprofesor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btnagregarprofesor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(24)))), ((int)(((byte)(67)))));
            this.Btnagregarprofesor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btnagregarprofesor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.Btnagregarprofesor.ForeColor = System.Drawing.Color.White;
            this.Btnagregarprofesor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btnagregarprofesor.Location = new System.Drawing.Point(606, 10);
            this.Btnagregarprofesor.Name = "Btnagregarprofesor";
            this.Btnagregarprofesor.Size = new System.Drawing.Size(207, 41);
            this.Btnagregarprofesor.TabIndex = 8;
            this.Btnagregarprofesor.Text = "Registrar Proyecto";
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
            this.lblprofesres.Size = new System.Drawing.Size(203, 24);
            this.lblprofesres.TabIndex = 3;
            this.lblprofesres.Text = "Servicio Comunitario";
            // 
            // gridcomunitario
            // 
            this.gridcomunitario.AccessibleDescription = "";
            this.gridcomunitario.AccessibleName = "";
            this.gridcomunitario.AllowUserToAddRows = false;
            this.gridcomunitario.AllowUserToDeleteRows = false;
            this.gridcomunitario.AllowUserToResizeColumns = false;
            this.gridcomunitario.AllowUserToResizeRows = false;
            this.gridcomunitario.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridcomunitario.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.gridcomunitario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridcomunitario.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridcomunitario.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridcomunitario.ColumnHeadersHeight = 50;
            this.gridcomunitario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(226)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridcomunitario.DefaultCellStyle = dataGridViewCellStyle2;
            this.gridcomunitario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridcomunitario.EnableHeadersVisualStyles = false;
            this.gridcomunitario.GridColor = System.Drawing.Color.LightGray;
            this.gridcomunitario.Location = new System.Drawing.Point(0, 102);
            this.gridcomunitario.Name = "gridcomunitario";
            this.gridcomunitario.ReadOnly = true;
            this.gridcomunitario.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(10);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridcomunitario.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.gridcomunitario.RowHeadersVisible = false;
            this.gridcomunitario.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(10);
            this.gridcomunitario.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.gridcomunitario.RowTemplate.Height = 48;
            this.gridcomunitario.Size = new System.Drawing.Size(843, 503);
            this.gridcomunitario.TabIndex = 32;
            this.gridcomunitario.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridprofesores_CellContentClick);
            // 
            // Serviciocomunitario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 651);
            this.Controls.Add(this.gridcomunitario);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Serviciocomunitario";
            this.Text = "Profesores";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridcomunitario)).EndInit();
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
        private Button Btnagregarprofesor;
        public DataGridView gridcomunitario;
        private Button Btnlimpiar;
        private ComboBox cbperiodo;
    }
}