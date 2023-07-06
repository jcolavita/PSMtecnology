using System.Windows.Forms;

namespace TrabajoDeGrado.Generales
{
    partial class selectoractas

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
            this.CBescuela = new System.Windows.Forms.ComboBox();
            this.btnreporte = new System.Windows.Forms.Button();
            this.lblcabecera = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbperiodo = new System.Windows.Forms.ComboBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // btncerrar
            // 
            this.btncerrar.BackColor = System.Drawing.Color.White;
            this.btncerrar.BackgroundImage = global::PSMtecnology.Properties.Resources.cerrar;
            this.btncerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btncerrar.FlatAppearance.BorderSize = 0;
            this.btncerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncerrar.Location = new System.Drawing.Point(377, 16);
            this.btncerrar.Name = "btncerrar";
            this.btncerrar.Size = new System.Drawing.Size(21, 21);
            this.btncerrar.TabIndex = 11;
            this.btncerrar.UseVisualStyleBackColor = false;
            this.btncerrar.Click += new System.EventHandler(this.btncerrar_Click);
            // 
            // CBescuela
            // 
            this.CBescuela.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.CBescuela.FormattingEnabled = true;
            this.CBescuela.Items.AddRange(new object[] {
            "ARQUITECTURA (41)",
            "INGENIERÍA CIVIL (42)",
            "INGENIERÍA ELÉCTRICA (43)",
            "INGENIERÍA ELECTRÓNICA (44)",
            "INGENIERÍA INDUSTRIAL (45)",
            "INGENIERÍA DE MTTO. MECÁNICO (46)",
            "INGENIERÍA DE SISTEMAS (47)"});
            this.CBescuela.Location = new System.Drawing.Point(12, 86);
            this.CBescuela.Name = "CBescuela";
            this.CBescuela.Size = new System.Drawing.Size(154, 24);
            this.CBescuela.TabIndex = 35;
            this.CBescuela.Text = "ESCUELA";
            this.CBescuela.SelectedIndexChanged += new System.EventHandler(this.CBescuela_SelectedIndexChanged);
            // 
            // btnreporte
            // 
            this.btnreporte.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnreporte.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(24)))), ((int)(((byte)(67)))));
            this.btnreporte.Enabled = false;
            this.btnreporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnreporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btnreporte.ForeColor = System.Drawing.Color.White;
            this.btnreporte.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnreporte.Location = new System.Drawing.Point(240, 121);
            this.btnreporte.Name = "btnreporte";
            this.btnreporte.Size = new System.Drawing.Size(158, 35);
            this.btnreporte.TabIndex = 39;
            this.btnreporte.Text = "Generar Actas";
            this.btnreporte.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnreporte.UseVisualStyleBackColor = false;
            this.btnreporte.Click += new System.EventHandler(this.btnreporte_Click);
            // 
            // lblcabecera
            // 
            this.lblcabecera.AutoSize = true;
            this.lblcabecera.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblcabecera.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(24)))), ((int)(((byte)(67)))));
            this.lblcabecera.Location = new System.Drawing.Point(18, 12);
            this.lblcabecera.Name = "lblcabecera";
            this.lblcabecera.Size = new System.Drawing.Size(143, 24);
            this.lblcabecera.TabIndex = 40;
            this.lblcabecera.Text = "Generar Actas";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label2.Location = new System.Drawing.Point(11, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(387, 42);
            this.label2.TabIndex = 41;
            this.label2.Text = "Seleccione el periodo y la escuela de la cual desea generar las actas";
            // 
            // cbperiodo
            // 
            this.cbperiodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.cbperiodo.FormattingEnabled = true;
            this.cbperiodo.Items.AddRange(new object[] {
            "",
            "DIFERIDO",
            "REPROBADO"});
            this.cbperiodo.Location = new System.Drawing.Point(289, 86);
            this.cbperiodo.Name = "cbperiodo";
            this.cbperiodo.Size = new System.Drawing.Size(109, 24);
            this.cbperiodo.TabIndex = 42;
            // 
            // selectoractas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(410, 168);
            this.ControlBox = false;
            this.Controls.Add(this.cbperiodo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblcabecera);
            this.Controls.Add(this.btnreporte);
            this.Controls.Add(this.CBescuela);
            this.Controls.Add(this.btncerrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MinimumSize = new System.Drawing.Size(322, 126);
            this.Name = "selectoractas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button btncerrar;
        private ComboBox CBescuela;
        private Button btnreporte;
        public Label lblcabecera;
        private Label label2;
        private ComboBox cbperiodo;
        private SaveFileDialog saveFileDialog1;
    }
}