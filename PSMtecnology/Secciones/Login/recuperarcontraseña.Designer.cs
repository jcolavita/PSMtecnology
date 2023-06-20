using System.Windows.Forms;

namespace TrabajoDeGrado.Secciones.Administrador.Gestionar_usuarios
{
    partial class recuperarcontraseña
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
            this.usuario = new System.Windows.Forms.Label();
            this.btnconfirmar = new System.Windows.Forms.Button();
            this.Btncerrar = new System.Windows.Forms.Button();
            this.lblcabecera = new System.Windows.Forms.Label();
            this.tbrespuesta = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbnuevacontrasena = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbcontrasena2 = new System.Windows.Forms.TextBox();
            this.cbpregunta = new System.Windows.Forms.ComboBox();
            this.lblerror = new System.Windows.Forms.Label();
            this.lblerror2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.usuario);
            this.panel1.Controls.Add(this.btnconfirmar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 221);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(413, 63);
            this.panel1.TabIndex = 1;
            // 
            // usuario
            // 
            this.usuario.AutoSize = true;
            this.usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.usuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(24)))), ((int)(((byte)(67)))));
            this.usuario.Location = new System.Drawing.Point(10, 24);
            this.usuario.Name = "usuario";
            this.usuario.Size = new System.Drawing.Size(79, 24);
            this.usuario.TabIndex = 42;
            this.usuario.Text = "usuario";
            // 
            // btnconfirmar
            // 
            this.btnconfirmar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnconfirmar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(24)))), ((int)(((byte)(67)))));
            this.btnconfirmar.Enabled = false;
            this.btnconfirmar.FlatAppearance.BorderSize = 0;
            this.btnconfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnconfirmar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btnconfirmar.ForeColor = System.Drawing.Color.White;
            this.btnconfirmar.Location = new System.Drawing.Point(298, 18);
            this.btnconfirmar.Name = "btnconfirmar";
            this.btnconfirmar.Size = new System.Drawing.Size(103, 35);
            this.btnconfirmar.TabIndex = 3;
            this.btnconfirmar.Text = "Confirmar";
            this.btnconfirmar.UseVisualStyleBackColor = false;
            this.btnconfirmar.Click += new System.EventHandler(this.btnconfirmar_Click);
            // 
            // Btncerrar
            // 
            this.Btncerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btncerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btncerrar.FlatAppearance.BorderSize = 0;
            this.Btncerrar.Image = global::PSMtecnology.Properties.Resources.cerrar;
            this.Btncerrar.Location = new System.Drawing.Point(380, 12);
            this.Btncerrar.Name = "Btncerrar";
            this.Btncerrar.Size = new System.Drawing.Size(21, 21);
            this.Btncerrar.TabIndex = 22;
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
            this.lblcabecera.Size = new System.Drawing.Size(220, 24);
            this.lblcabecera.TabIndex = 21;
            this.lblcabecera.Text = "Recuperar Contraseña";
            // 
            // tbrespuesta
            // 
            this.tbrespuesta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.tbrespuesta.Location = new System.Drawing.Point(10, 106);
            this.tbrespuesta.MaxLength = 15;
            this.tbrespuesta.Name = "tbrespuesta";
            this.tbrespuesta.Size = new System.Drawing.Size(391, 22);
            this.tbrespuesta.TabIndex = 41;
            this.tbrespuesta.TextChanged += new System.EventHandler(this.tbcontrasenaactual_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label5.Location = new System.Drawing.Point(12, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 16);
            this.label5.TabIndex = 40;
            this.label5.Text = "Nueva Contaraseña";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label6.Location = new System.Drawing.Point(10, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 16);
            this.label6.TabIndex = 39;
            this.label6.Text = "Respuesta secreta";
            // 
            // tbnuevacontrasena
            // 
            this.tbnuevacontrasena.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.tbnuevacontrasena.Location = new System.Drawing.Point(10, 151);
            this.tbnuevacontrasena.MaxLength = 15;
            this.tbnuevacontrasena.Name = "tbnuevacontrasena";
            this.tbnuevacontrasena.PasswordChar = '*';
            this.tbnuevacontrasena.Size = new System.Drawing.Size(129, 22);
            this.tbnuevacontrasena.TabIndex = 38;
            this.tbnuevacontrasena.TextChanged += new System.EventHandler(this.tbcontrasenaactual_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label2.Location = new System.Drawing.Point(10, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 16);
            this.label2.TabIndex = 36;
            this.label2.Text = "Pregunta de seguridad";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label1.Location = new System.Drawing.Point(278, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 16);
            this.label1.TabIndex = 43;
            this.label1.Text = "Repetir Contraseña";
            // 
            // tbcontrasena2
            // 
            this.tbcontrasena2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.tbcontrasena2.Location = new System.Drawing.Point(252, 151);
            this.tbcontrasena2.MaxLength = 15;
            this.tbcontrasena2.Name = "tbcontrasena2";
            this.tbcontrasena2.PasswordChar = '*';
            this.tbcontrasena2.Size = new System.Drawing.Size(149, 22);
            this.tbcontrasena2.TabIndex = 42;
            this.tbcontrasena2.TextChanged += new System.EventHandler(this.tbcontrasenaactual_TextChanged);
            // 
            // cbpregunta
            // 
            this.cbpregunta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbpregunta.Enabled = false;
            this.cbpregunta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.cbpregunta.FormattingEnabled = true;
            this.cbpregunta.Items.AddRange(new object[] {
            "¿CÓMO SE LLAMABA TU MAMÁ?",
            "¿A QUÉ SECUNDARIA FUISTE?",
            "¿COMO SE LLAMA TU MASCOTA?",
            "¿EN QUE CIUDAD NACIO TU MADRE?",
            "¿CUAL ES TU SUPERHEROE FAVORITO DE LA INFANCIA?",
            "¿CUAL FUE TU PRIMER CARRO?",
            "¿EN QUE AÑO TE GRADUASTE DE BACHILLERATO?"});
            this.cbpregunta.Location = new System.Drawing.Point(10, 61);
            this.cbpregunta.Name = "cbpregunta";
            this.cbpregunta.Size = new System.Drawing.Size(391, 24);
            this.cbpregunta.TabIndex = 46;
            this.cbpregunta.TextChanged += new System.EventHandler(this.tbcontrasenaactual_TextChanged);
            // 
            // lblerror
            // 
            this.lblerror.AutoSize = true;
            this.lblerror.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblerror.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblerror.Location = new System.Drawing.Point(167, 176);
            this.lblerror.Name = "lblerror";
            this.lblerror.Size = new System.Drawing.Size(234, 15);
            this.lblerror.TabIndex = 47;
            this.lblerror.Text = "Las contraseñas ingresadas no coinsiden";
            this.lblerror.Visible = false;
            // 
            // lblerror2
            // 
            this.lblerror2.AutoSize = true;
            this.lblerror2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblerror2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblerror2.Location = new System.Drawing.Point(94, 198);
            this.lblerror2.Name = "lblerror2";
            this.lblerror2.Size = new System.Drawing.Size(307, 15);
            this.lblerror2.TabIndex = 48;
            this.lblerror2.Text = "La nueva contraseña debe tener al menos 8 caracteres";
            this.lblerror2.Visible = false;
            // 
            // recuperarcontraseña
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(413, 284);
            this.ControlBox = false;
            this.Controls.Add(this.lblerror2);
            this.Controls.Add(this.lblerror);
            this.Controls.Add(this.cbpregunta);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbcontrasena2);
            this.Controls.Add(this.tbrespuesta);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbnuevacontrasena);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Btncerrar);
            this.Controls.Add(this.lblcabecera);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximumSize = new System.Drawing.Size(415, 286);
            this.MinimumSize = new System.Drawing.Size(415, 286);
            this.Name = "recuperarcontraseña";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        public Button btnconfirmar;
        private Button Btncerrar;
        public Label lblcabecera;
        public TextBox tbrespuesta;
        private Label label5;
        private Label label6;
        public TextBox tbnuevacontrasena;
        private Label label2;
        private Label label1;
        public TextBox tbcontrasena2;
        private ComboBox cbpregunta;
        public Label usuario;
        private Label lblerror;
        private Label lblerror2;
    }
}