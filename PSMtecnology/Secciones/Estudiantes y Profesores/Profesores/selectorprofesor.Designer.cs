using System.Windows.Forms;

namespace TrabajoDeGrado.Generales
{
    partial class selectorprofesor

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
            this.cbprofesion = new System.Windows.Forms.ComboBox();
            this.cbescuela = new System.Windows.Forms.ComboBox();
            this.btnreporte = new System.Windows.Forms.Button();
            this.cbsexo = new System.Windows.Forms.ComboBox();
            this.btncerrar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblcabecera = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbprofesion
            // 
            this.cbprofesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.cbprofesion.FormattingEnabled = true;
            this.cbprofesion.Items.AddRange(new object[] {
            "PROFESION",
            "ARQUITECTO/A",
            "INGENIERO/A",
            "LICENCIADO/A",
            "ABOGADO/A",
            "PROFESOR/A"});
            this.cbprofesion.Location = new System.Drawing.Point(12, 76);
            this.cbprofesion.Name = "cbprofesion";
            this.cbprofesion.Size = new System.Drawing.Size(148, 24);
            this.cbprofesion.TabIndex = 35;
            this.cbprofesion.Text = "PROFESION";
            // 
            // cbescuela
            // 
            this.cbescuela.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.cbescuela.FormattingEnabled = true;
            this.cbescuela.Items.AddRange(new object[] {
            "ESCUELA",
            "COMUN",
            "ARQUITECTURA (41)",
            "INGENIERÍA CIVIL (42)",
            "INGENIERÍA ELÉCTRICA (43)",
            "INGENIERÍA ELECTRÓNICA (44)",
            "INGENIERÍA INDUSTRIAL (45)",
            "INGENIERÍA DE MTTO. MECÁNICO (46)",
            "INGENIERÍA DE SISTEMAS (47)"});
            this.cbescuela.Location = new System.Drawing.Point(118, 106);
            this.cbescuela.Name = "cbescuela";
            this.cbescuela.Size = new System.Drawing.Size(148, 24);
            this.cbescuela.TabIndex = 38;
            this.cbescuela.Text = "ESCUELA";
            // 
            // btnreporte
            // 
            this.btnreporte.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnreporte.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(24)))), ((int)(((byte)(67)))));
            this.btnreporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnreporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btnreporte.ForeColor = System.Drawing.Color.White;
            this.btnreporte.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnreporte.Location = new System.Drawing.Point(208, 139);
            this.btnreporte.Name = "btnreporte";
            this.btnreporte.Size = new System.Drawing.Size(158, 35);
            this.btnreporte.TabIndex = 39;
            this.btnreporte.Text = "Generar Reporte";
            this.btnreporte.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnreporte.UseVisualStyleBackColor = false;
            this.btnreporte.Click += new System.EventHandler(this.btnreporte_Click);
            // 
            // cbsexo
            // 
            this.cbsexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.cbsexo.FormattingEnabled = true;
            this.cbsexo.Items.AddRange(new object[] {
            "SEXO",
            "MASCULINO",
            "FEMENINO"});
            this.cbsexo.Location = new System.Drawing.Point(218, 76);
            this.cbsexo.Name = "cbsexo";
            this.cbsexo.Size = new System.Drawing.Size(148, 24);
            this.cbsexo.TabIndex = 40;
            this.cbsexo.Text = "SEXO";
            // 
            // btncerrar
            // 
            this.btncerrar.BackColor = System.Drawing.Color.White;
            this.btncerrar.BackgroundImage = global::PSMtecnology.Properties.Resources.cerrar;
            this.btncerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btncerrar.FlatAppearance.BorderSize = 0;
            this.btncerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncerrar.Location = new System.Drawing.Point(345, 12);
            this.btncerrar.Name = "btncerrar";
            this.btncerrar.Size = new System.Drawing.Size(21, 21);
            this.btncerrar.TabIndex = 11;
            this.btncerrar.UseVisualStyleBackColor = false;
            this.btncerrar.Click += new System.EventHandler(this.btncerrar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label2.Location = new System.Drawing.Point(9, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(271, 16);
            this.label2.TabIndex = 45;
            this.label2.Text = "Seleccione el Filtro Para Generar el Reporte";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblcabecera
            // 
            this.lblcabecera.AutoSize = true;
            this.lblcabecera.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblcabecera.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(24)))), ((int)(((byte)(67)))));
            this.lblcabecera.Location = new System.Drawing.Point(12, 12);
            this.lblcabecera.Name = "lblcabecera";
            this.lblcabecera.Size = new System.Drawing.Size(84, 24);
            this.lblcabecera.TabIndex = 44;
            this.lblcabecera.Text = "Reporte";
            // 
            // selectorprofesor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(378, 186);
            this.ControlBox = false;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblcabecera);
            this.Controls.Add(this.cbsexo);
            this.Controls.Add(this.btnreporte);
            this.Controls.Add(this.cbescuela);
            this.Controls.Add(this.cbprofesion);
            this.Controls.Add(this.btncerrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MinimumSize = new System.Drawing.Size(322, 126);
            this.Name = "selectorprofesor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button btncerrar;
        private ComboBox cbprofesion;
        private ComboBox cbescuela;
        private Button btnreporte;
        private ComboBox cbsexo;
        private Label label2;
        public Label lblcabecera;
    }
}