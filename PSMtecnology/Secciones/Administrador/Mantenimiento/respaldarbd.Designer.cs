using System.Windows.Forms;

namespace TrabajoDeGrado.Secciones.Estudiantes_y_Profesores.Estudiantes
{
    partial class respaldarbd
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
            this.btnrestaurar = new System.Windows.Forms.Button();
            this.btnrespaldar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tbrutarestauracion = new System.Windows.Forms.TextBox();
            this.btnruta2 = new System.Windows.Forms.Button();
            this.tbruta = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Btncerrar = new System.Windows.Forms.Button();
            this.lblcabecera = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnrestaurar
            // 
            this.btnrestaurar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(24)))), ((int)(((byte)(67)))));
            this.btnrestaurar.Enabled = false;
            this.btnrestaurar.FlatAppearance.BorderSize = 0;
            this.btnrestaurar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnrestaurar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btnrestaurar.ForeColor = System.Drawing.Color.White;
            this.btnrestaurar.Location = new System.Drawing.Point(21, 196);
            this.btnrestaurar.Name = "btnrestaurar";
            this.btnrestaurar.Size = new System.Drawing.Size(213, 39);
            this.btnrestaurar.TabIndex = 2;
            this.btnrestaurar.Text = "Restaurar Copia de seguridad";
            this.btnrestaurar.UseVisualStyleBackColor = false;
            this.btnrestaurar.Click += new System.EventHandler(this.tbrestaurar_Click);
            // 
            // btnrespaldar
            // 
            this.btnrespaldar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(24)))), ((int)(((byte)(67)))));
            this.btnrespaldar.Enabled = false;
            this.btnrespaldar.FlatAppearance.BorderSize = 0;
            this.btnrespaldar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnrespaldar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btnrespaldar.ForeColor = System.Drawing.Color.White;
            this.btnrespaldar.Location = new System.Drawing.Point(21, 104);
            this.btnrespaldar.Name = "btnrespaldar";
            this.btnrespaldar.Size = new System.Drawing.Size(131, 28);
            this.btnrespaldar.TabIndex = 1;
            this.btnrespaldar.Text = "Crear respaldo";
            this.btnrespaldar.UseVisualStyleBackColor = false;
            this.btnrespaldar.Click += new System.EventHandler(this.Btnagregar_Click_1);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.btnrestaurar);
            this.panel2.Controls.Add(this.tbrutarestauracion);
            this.panel2.Controls.Add(this.btnrespaldar);
            this.panel2.Controls.Add(this.btnruta2);
            this.panel2.Controls.Add(this.tbruta);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.Btncerrar);
            this.panel2.Controls.Add(this.lblcabecera);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(424, 248);
            this.panel2.TabIndex = 1;
            // 
            // tbrutarestauracion
            // 
            this.tbrutarestauracion.Location = new System.Drawing.Point(21, 168);
            this.tbrutarestauracion.Name = "tbrutarestauracion";
            this.tbrutarestauracion.ReadOnly = true;
            this.tbrutarestauracion.Size = new System.Drawing.Size(355, 22);
            this.tbrutarestauracion.TabIndex = 24;
            this.tbrutarestauracion.TextChanged += new System.EventHandler(this.tbrutarestauracion_TextChanged);
            // 
            // btnruta2
            // 
            this.btnruta2.BackColor = System.Drawing.Color.Transparent;
            this.btnruta2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnruta2.FlatAppearance.BorderSize = 0;
            this.btnruta2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnruta2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btnruta2.ForeColor = System.Drawing.Color.White;
            this.btnruta2.Image = global::PSMtecnology.Properties.Resources.lupa;
            this.btnruta2.Location = new System.Drawing.Point(382, 146);
            this.btnruta2.Name = "btnruta2";
            this.btnruta2.Size = new System.Drawing.Size(21, 21);
            this.btnruta2.TabIndex = 23;
            this.btnruta2.UseVisualStyleBackColor = false;
            this.btnruta2.Click += new System.EventHandler(this.btnruta2_Click);
            // 
            // tbruta
            // 
            this.tbruta.Location = new System.Drawing.Point(21, 76);
            this.tbruta.Name = "tbruta";
            this.tbruta.ReadOnly = true;
            this.tbruta.Size = new System.Drawing.Size(355, 22);
            this.tbruta.TabIndex = 22;
            this.tbruta.TextChanged += new System.EventHandler(this.TBRUTA_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = global::PSMtecnology.Properties.Resources.lupa;
            this.button1.Location = new System.Drawing.Point(382, 76);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(21, 21);
            this.button1.TabIndex = 2;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Btncerrar
            // 
            this.Btncerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btncerrar.FlatAppearance.BorderSize = 0;
            this.Btncerrar.Image = global::PSMtecnology.Properties.Resources.cerrar;
            this.Btncerrar.Location = new System.Drawing.Point(391, 11);
            this.Btncerrar.Name = "Btncerrar";
            this.Btncerrar.Size = new System.Drawing.Size(21, 22);
            this.Btncerrar.TabIndex = 20;
            this.Btncerrar.UseVisualStyleBackColor = true;
            this.Btncerrar.Click += new System.EventHandler(this.Btncerrar_Click);
            // 
            // lblcabecera
            // 
            this.lblcabecera.AutoSize = true;
            this.lblcabecera.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblcabecera.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(24)))), ((int)(((byte)(67)))));
            this.lblcabecera.Location = new System.Drawing.Point(10, 8);
            this.lblcabecera.Name = "lblcabecera";
            this.lblcabecera.Size = new System.Drawing.Size(302, 24);
            this.lblcabecera.TabIndex = 8;
            this.lblcabecera.Text = "Restauracion de Base de Datos";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label2.Location = new System.Drawing.Point(18, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(267, 16);
            this.label2.TabIndex = 25;
            this.label2.Text = "Selecciones la ruta del respaldo a restaurar";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label1.Location = new System.Drawing.Point(18, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(312, 16);
            this.label1.TabIndex = 26;
            this.label1.Text = "Seleccione la ruta dode desea guardar el respaldo";
            // 
            // respaldarbd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 248);
            this.ControlBox = false;
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "respaldarbd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Panel panel2;
        private Button Btncerrar;
        public Label lblcabecera;
        public Button btnrespaldar;
        public Button button1;
        private OpenFileDialog openFileDialog1;
        private SaveFileDialog saveFileDialog1;
        private TextBox tbruta;
        public Button btnrestaurar;
        private TextBox tbrutarestauracion;
        public Button btnruta2;
        private Label label1;
        private Label label2;
    }
}