using System.Windows.Forms;

namespace TrabajoDeGrado.Secciones.Administrador.Gestionar_usuarios
{
    partial class configurarclave
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
            this.lblcontraseña = new System.Windows.Forms.Label();
            this.tbcontrasenaactual = new System.Windows.Forms.TextBox();
            this.cbpregunta = new System.Windows.Forms.ComboBox();
            this.lblerror = new System.Windows.Forms.Label();
            this.lblerror2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbcodigo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Tbtelefono = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.Tbcorreo = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.usuario);
            this.panel1.Controls.Add(this.btnconfirmar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 308);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(411, 63);
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
            this.btnconfirmar.Location = new System.Drawing.Point(296, 16);
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
            this.Btncerrar.Location = new System.Drawing.Point(378, 11);
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
            this.lblcabecera.Size = new System.Drawing.Size(272, 24);
            this.lblcabecera.TabIndex = 21;
            this.lblcabecera.Text = "Configuracion de Seguridad";
            // 
            // tbrespuesta
            // 
            this.tbrespuesta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.tbrespuesta.Location = new System.Drawing.Point(10, 101);
            this.tbrespuesta.MaxLength = 15;
            this.tbrespuesta.Name = "tbrespuesta";
            this.tbrespuesta.Size = new System.Drawing.Size(389, 22);
            this.tbrespuesta.TabIndex = 41;
            this.tbrespuesta.TextChanged += new System.EventHandler(this.tbcontrasenaactual_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label5.Location = new System.Drawing.Point(10, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 16);
            this.label5.TabIndex = 40;
            this.label5.Text = "Nueva Contaraseña";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label6.Location = new System.Drawing.Point(10, 84);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 16);
            this.label6.TabIndex = 39;
            this.label6.Text = "Respuesta secreta";
            // 
            // tbnuevacontrasena
            // 
            this.tbnuevacontrasena.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.tbnuevacontrasena.Location = new System.Drawing.Point(10, 210);
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
            this.label1.Location = new System.Drawing.Point(276, 191);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 16);
            this.label1.TabIndex = 43;
            this.label1.Text = "Repetir Contraseña";
            // 
            // tbcontrasena2
            // 
            this.tbcontrasena2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.tbcontrasena2.Location = new System.Drawing.Point(270, 210);
            this.tbcontrasena2.MaxLength = 15;
            this.tbcontrasena2.Name = "tbcontrasena2";
            this.tbcontrasena2.PasswordChar = '*';
            this.tbcontrasena2.Size = new System.Drawing.Size(129, 22);
            this.tbcontrasena2.TabIndex = 42;
            this.tbcontrasena2.TextChanged += new System.EventHandler(this.tbcontrasenaactual_TextChanged);
            // 
            // lblcontraseña
            // 
            this.lblcontraseña.AutoSize = true;
            this.lblcontraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lblcontraseña.Location = new System.Drawing.Point(83, 276);
            this.lblcontraseña.Name = "lblcontraseña";
            this.lblcontraseña.Size = new System.Drawing.Size(181, 16);
            this.lblcontraseña.TabIndex = 45;
            this.lblcontraseña.Text = "Ingrese su contraseña actual ";
            // 
            // tbcontrasenaactual
            // 
            this.tbcontrasenaactual.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.tbcontrasenaactual.Location = new System.Drawing.Point(270, 273);
            this.tbcontrasenaactual.MaxLength = 15;
            this.tbcontrasenaactual.Name = "tbcontrasenaactual";
            this.tbcontrasenaactual.PasswordChar = '*';
            this.tbcontrasenaactual.Size = new System.Drawing.Size(129, 22);
            this.tbcontrasenaactual.TabIndex = 44;
            this.tbcontrasenaactual.TextChanged += new System.EventHandler(this.tbcontrasenaactual_TextChanged);
            // 
            // cbpregunta
            // 
            this.cbpregunta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
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
            this.cbpregunta.Location = new System.Drawing.Point(10, 58);
            this.cbpregunta.Name = "cbpregunta";
            this.cbpregunta.Size = new System.Drawing.Size(389, 24);
            this.cbpregunta.TabIndex = 46;
            this.cbpregunta.TextChanged += new System.EventHandler(this.tbcontrasenaactual_TextChanged);
            // 
            // lblerror
            // 
            this.lblerror.AutoSize = true;
            this.lblerror.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblerror.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblerror.Location = new System.Drawing.Point(165, 170);
            this.lblerror.Name = "lblerror";
            this.lblerror.Size = new System.Drawing.Size(234, 15);
            this.lblerror.TabIndex = 47;
            this.lblerror.Text = "Las contraseñas ingresadas no coinsiden";
            this.lblerror.Visible = false;
            // 
            // lblerror2
            // 
            this.lblerror2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblerror2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblerror2.Location = new System.Drawing.Point(7, 235);
            this.lblerror2.Name = "lblerror2";
            this.lblerror2.Size = new System.Drawing.Size(392, 34);
            this.lblerror2.TabIndex = 48;
            this.lblerror2.Text = "La cotraseña debe tener al menos 8 caracteres e incluir un numero, una mayuscula " +
    "y un caracter especial";
            this.lblerror2.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label3.Location = new System.Drawing.Point(10, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 16);
            this.label3.TabIndex = 52;
            this.label3.Text = "Codigo";
            // 
            // tbcodigo
            // 
            this.tbcodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.tbcodigo.Location = new System.Drawing.Point(10, 145);
            this.tbcodigo.MaxLength = 4;
            this.tbcodigo.Name = "tbcodigo";
            this.tbcodigo.Size = new System.Drawing.Size(57, 22);
            this.tbcodigo.TabIndex = 51;
            this.tbcodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbcodigo_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label4.Location = new System.Drawing.Point(72, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 16);
            this.label4.TabIndex = 50;
            this.label4.Text = "Numero de Telefono";
            // 
            // Tbtelefono
            // 
            this.Tbtelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.Tbtelefono.Location = new System.Drawing.Point(73, 145);
            this.Tbtelefono.MaxLength = 7;
            this.Tbtelefono.Name = "Tbtelefono";
            this.Tbtelefono.Size = new System.Drawing.Size(111, 22);
            this.Tbtelefono.TabIndex = 49;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label10.Location = new System.Drawing.Point(209, 127);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(113, 16);
            this.label10.TabIndex = 54;
            this.label10.Text = "Correo (Opcional)";
            // 
            // Tbcorreo
            // 
            this.Tbcorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.Tbcorreo.Location = new System.Drawing.Point(206, 145);
            this.Tbcorreo.MaxLength = 25;
            this.Tbcorreo.Name = "Tbcorreo";
            this.Tbcorreo.Size = new System.Drawing.Size(193, 22);
            this.Tbcorreo.TabIndex = 53;
            this.Tbcorreo.TextChanged += new System.EventHandler(this.Tbcorreo_TextChanged);
            // 
            // configurarclave
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(411, 371);
            this.ControlBox = false;
            this.Controls.Add(this.label10);
            this.Controls.Add(this.Tbcorreo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbcodigo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Tbtelefono);
            this.Controls.Add(this.lblerror2);
            this.Controls.Add(this.lblerror);
            this.Controls.Add(this.cbpregunta);
            this.Controls.Add(this.lblcontraseña);
            this.Controls.Add(this.tbcontrasenaactual);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MinimumSize = new System.Drawing.Size(16, 39);
            this.Name = "configurarclave";
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
        public TextBox tbcontrasenaactual;
        private ComboBox cbpregunta;
        public Label usuario;
        private Label lblerror;
        private Label lblerror2;
        public Label lblcontraseña;
        private Label label3;
        private Label label4;
        private Label label10;
        public TextBox tbcodigo;
        public TextBox Tbtelefono;
        public TextBox Tbcorreo;
    }
}