using System.Windows.Forms;

namespace TrabajoDeGrado.Generales
{
    partial class selectorestudiante
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
            this.btncerrar = new System.Windows.Forms.Button();
            this.btnreporte = new System.Windows.Forms.Button();
            this.CBescuela = new System.Windows.Forms.ComboBox();
            this.CBsexo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblcabecera = new System.Windows.Forms.Label();
            this.SuspendLayout();
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
            // btnreporte
            // 
            this.btnreporte.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnreporte.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(24)))), ((int)(((byte)(67)))));
            this.btnreporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnreporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btnreporte.ForeColor = System.Drawing.Color.White;
            this.btnreporte.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnreporte.Location = new System.Drawing.Point(208, 121);
            this.btnreporte.Name = "btnreporte";
            this.btnreporte.Size = new System.Drawing.Size(158, 35);
            this.btnreporte.TabIndex = 39;
            this.btnreporte.Text = "Generar Reporte";
            this.btnreporte.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnreporte.UseVisualStyleBackColor = false;
            this.btnreporte.Click += new System.EventHandler(this.btnreporte_Click);
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
            this.CBescuela.Location = new System.Drawing.Point(191, 82);
            this.CBescuela.Name = "CBescuela";
            this.CBescuela.Size = new System.Drawing.Size(175, 24);
            this.CBescuela.TabIndex = 41;
            this.CBescuela.Text = "ESCUELA";
            // 
            // CBsexo
            // 
            this.CBsexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.CBsexo.FormattingEnabled = true;
            this.CBsexo.Items.AddRange(new object[] {
            "SEXO",
            "MASCULINO",
            "FEMENINO"});
            this.CBsexo.Location = new System.Drawing.Point(12, 82);
            this.CBsexo.Name = "CBsexo";
            this.CBsexo.Size = new System.Drawing.Size(122, 24);
            this.CBsexo.TabIndex = 40;
            this.CBsexo.Text = "SEXO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label2.Location = new System.Drawing.Point(12, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(271, 16);
            this.label2.TabIndex = 43;
            this.label2.Text = "Seleccione el Filtro Para Generar el Reporte";
            // 
            // lblcabecera
            // 
            this.lblcabecera.AutoSize = true;
            this.lblcabecera.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblcabecera.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(24)))), ((int)(((byte)(67)))));
            this.lblcabecera.Location = new System.Drawing.Point(21, 9);
            this.lblcabecera.Name = "lblcabecera";
            this.lblcabecera.Size = new System.Drawing.Size(84, 24);
            this.lblcabecera.TabIndex = 42;
            this.lblcabecera.Text = "Reporte";
            // 
            // selectorestudiante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(378, 168);
            this.ControlBox = false;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblcabecera);
            this.Controls.Add(this.CBescuela);
            this.Controls.Add(this.CBsexo);
            this.Controls.Add(this.btnreporte);
            this.Controls.Add(this.btncerrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MinimumSize = new System.Drawing.Size(322, 126);
            this.Name = "selectorestudiante";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button btncerrar;
        private Button btnreporte;
        private ComboBox CBescuela;
        private ComboBox CBsexo;
        private Label label2;
        public Label lblcabecera;
    }
}