using System.Windows.Forms;

namespace TrabajoDeGrado.Secciones.Login
{
    partial class login
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
            this.btniniciar = new System.Windows.Forms.Button();
            this.tbusuario = new System.Windows.Forms.TextBox();
            this.tbclave = new System.Windows.Forms.TextBox();
            this.lblerror = new System.Windows.Forms.Label();
            this.btnrecuperar = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btncerrar
            // 
            this.btncerrar.BackColor = System.Drawing.Color.White;
            this.btncerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btncerrar.FlatAppearance.BorderSize = 0;
            this.btncerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncerrar.Image = global::PSMtecnology.Properties.Resources.cerrar;
            this.btncerrar.Location = new System.Drawing.Point(251, 10);
            this.btncerrar.Name = "btncerrar";
            this.btncerrar.Size = new System.Drawing.Size(21, 21);
            this.btncerrar.TabIndex = 2;
            this.btncerrar.UseVisualStyleBackColor = false;
            this.btncerrar.Click += new System.EventHandler(this.btncerrar_Click);
            // 
            // btniniciar
            // 
            this.btniniciar.Enabled = false;
            this.btniniciar.FlatAppearance.BorderSize = 0;
            this.btniniciar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btniniciar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btniniciar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(24)))), ((int)(((byte)(67)))));
            this.btniniciar.Location = new System.Drawing.Point(199, 276);
            this.btniniciar.Name = "btniniciar";
            this.btniniciar.Size = new System.Drawing.Size(73, 27);
            this.btniniciar.TabIndex = 5;
            this.btniniciar.Text = "Iniciar";
            this.btniniciar.UseVisualStyleBackColor = true;
            this.btniniciar.Click += new System.EventHandler(this.btniniciar_Click);
            // 
            // tbusuario
            // 
            this.tbusuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.tbusuario.Location = new System.Drawing.Point(47, 138);
            this.tbusuario.MaxLength = 8;
            this.tbusuario.Name = "tbusuario";
            this.tbusuario.Size = new System.Drawing.Size(189, 22);
            this.tbusuario.TabIndex = 6;
            this.tbusuario.Click += new System.EventHandler(this.tbusuario_Click_1);
            this.tbusuario.TextChanged += new System.EventHandler(this.tbusuario_TextChanged);
            this.tbusuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbusuario_KeyPress);
            this.tbusuario.Leave += new System.EventHandler(this.tbusuario_Leave);
            // 
            // tbclave
            // 
            this.tbclave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.tbclave.Location = new System.Drawing.Point(47, 178);
            this.tbclave.MaxLength = 15;
            this.tbclave.Name = "tbclave";
            this.tbclave.Size = new System.Drawing.Size(189, 22);
            this.tbclave.TabIndex = 7;
            this.tbclave.Click += new System.EventHandler(this.tbclave_Click);
            this.tbclave.TextChanged += new System.EventHandler(this.tbclave_TextChanged);
            this.tbclave.Leave += new System.EventHandler(this.tbclave_Leave);
            // 
            // lblerror
            // 
            this.lblerror.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(24)))), ((int)(((byte)(67)))));
            this.lblerror.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblerror.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblerror.ForeColor = System.Drawing.Color.Red;
            this.lblerror.Location = new System.Drawing.Point(12, 269);
            this.lblerror.Name = "lblerror";
            this.lblerror.Size = new System.Drawing.Size(148, 50);
            this.lblerror.TabIndex = 10;
            this.lblerror.Text = "Ha introducido su clave incorrectamente (1/3)";
            this.lblerror.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblerror.Visible = false;
            // 
            // btnrecuperar
            // 
            this.btnrecuperar.Enabled = false;
            this.btnrecuperar.FlatAppearance.BorderSize = 0;
            this.btnrecuperar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnrecuperar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnrecuperar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(24)))), ((int)(((byte)(67)))));
            this.btnrecuperar.Location = new System.Drawing.Point(47, 202);
            this.btnrecuperar.Name = "btnrecuperar";
            this.btnrecuperar.Size = new System.Drawing.Size(147, 19);
            this.btnrecuperar.TabIndex = 11;
            this.btnrecuperar.Text = "Recuperar contraseña";
            this.btnrecuperar.UseVisualStyleBackColor = true;
            this.btnrecuperar.Click += new System.EventHandler(this.btnrecuperar_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.BackgroundImage = global::PSMtecnology.Properties.Resources.footer;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(-3, 241);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(302, 103);
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::PSMtecnology.Properties.Resources.logologin;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(93, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(94, 95);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(282, 328);
            this.ControlBox = false;
            this.Controls.Add(this.btnrecuperar);
            this.Controls.Add(this.lblerror);
            this.Controls.Add(this.tbclave);
            this.Controls.Add(this.tbusuario);
            this.Controls.Add(this.btniniciar);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btncerrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximumSize = new System.Drawing.Size(284, 330);
            this.MinimumSize = new System.Drawing.Size(284, 330);
            this.Name = "login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button btncerrar;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Button btniniciar;
        private TextBox tbusuario;
        private TextBox tbclave;
        private Label lblerror;
        private Button btnrecuperar;
    }
}