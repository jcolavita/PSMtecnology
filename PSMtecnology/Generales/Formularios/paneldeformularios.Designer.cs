using System.Windows.Forms;

namespace TrabajoDeGrado.Modulos
{
    partial class paneldeformularios
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.Btncerrar = new System.Windows.Forms.Button();
            this.btnrustica = new System.Windows.Forms.Button();
            this.btngeneral = new System.Windows.Forms.Button();
            this.Panel_formularios = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(24)))), ((int)(((byte)(67)))));
            this.panel1.Controls.Add(this.Btncerrar);
            this.panel1.Controls.Add(this.btnrustica);
            this.panel1.Controls.Add(this.btngeneral);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(486, 43);
            this.panel1.TabIndex = 0;
            // 
            // Btncerrar
            // 
            this.Btncerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btncerrar.BackColor = System.Drawing.Color.White;
            this.Btncerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btncerrar.FlatAppearance.BorderSize = 0;
            this.Btncerrar.Image = global::PSMtecnology.Properties.Resources.cerrar;
            this.Btncerrar.Location = new System.Drawing.Point(463, 3);
            this.Btncerrar.Name = "Btncerrar";
            this.Btncerrar.Size = new System.Drawing.Size(21, 21);
            this.Btncerrar.TabIndex = 21;
            this.Btncerrar.UseVisualStyleBackColor = false;
            this.Btncerrar.Click += new System.EventHandler(this.Btncerrar_Click);
            // 
            // btnrustica
            // 
            this.btnrustica.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnrustica.FlatAppearance.BorderSize = 0;
            this.btnrustica.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnrustica.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnrustica.ForeColor = System.Drawing.Color.White;
            this.btnrustica.Location = new System.Drawing.Point(272, -1);
            this.btnrustica.Name = "btnrustica";
            this.btnrustica.Size = new System.Drawing.Size(214, 43);
            this.btnrustica.TabIndex = 1;
            this.btnrustica.Text = "Rustica";
            this.btnrustica.UseVisualStyleBackColor = true;
            this.btnrustica.Click += new System.EventHandler(this.btnrustica_Click);
            // 
            // btngeneral
            // 
            this.btngeneral.FlatAppearance.BorderSize = 0;
            this.btngeneral.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btngeneral.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btngeneral.ForeColor = System.Drawing.Color.White;
            this.btngeneral.Location = new System.Drawing.Point(0, -1);
            this.btngeneral.Name = "btngeneral";
            this.btngeneral.Size = new System.Drawing.Size(214, 43);
            this.btngeneral.TabIndex = 0;
            this.btngeneral.Text = "General";
            this.btngeneral.UseVisualStyleBackColor = true;
            this.btngeneral.Click += new System.EventHandler(this.btngeneral_Click);
            // 
            // Panel_formularios
            // 
            this.Panel_formularios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel_formularios.Location = new System.Drawing.Point(0, 43);
            this.Panel_formularios.Name = "Panel_formularios";
            this.Panel_formularios.Size = new System.Drawing.Size(486, 636);
            this.Panel_formularios.TabIndex = 1;
            // 
            // paneldeformularios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 679);
            this.ControlBox = false;
            this.Controls.Add(this.Panel_formularios);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximumSize = new System.Drawing.Size(551, 791);
            this.Name = "paneldeformularios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Panel Panel_formularios;
        private Button Btncerrar;
        public Button btngeneral;
        public Button btnrustica;
    }
}