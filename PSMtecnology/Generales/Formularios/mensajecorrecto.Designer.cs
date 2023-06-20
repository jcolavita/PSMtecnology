using System.Windows.Forms;

namespace TrabajoDeGrado.Generales
{
    partial class mensajecorrecto
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
            this.lblalerta = new System.Windows.Forms.Label();
            this.btniniciar = new System.Windows.Forms.Button();
            this.imagen = new System.Windows.Forms.PictureBox();
            this.btncerrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imagen)).BeginInit();
            this.SuspendLayout();
            // 
            // lblalerta
            // 
            this.lblalerta.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblalerta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblalerta.Location = new System.Drawing.Point(109, 37);
            this.lblalerta.Name = "lblalerta";
            this.lblalerta.Size = new System.Drawing.Size(201, 47);
            this.lblalerta.TabIndex = 14;
            this.lblalerta.Text = "El usuario ha sido registrado \r\ncorrectamente asdasda sdasdasd asd";
            this.lblalerta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btniniciar
            // 
            this.btniniciar.FlatAppearance.BorderSize = 0;
            this.btniniciar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btniniciar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btniniciar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(24)))), ((int)(((byte)(67)))));
            this.btniniciar.Location = new System.Drawing.Point(233, 89);
            this.btniniciar.Name = "btniniciar";
            this.btniniciar.Size = new System.Drawing.Size(73, 27);
            this.btniniciar.TabIndex = 13;
            this.btniniciar.Text = "Aceptar";
            this.btniniciar.UseVisualStyleBackColor = true;
            this.btniniciar.Click += new System.EventHandler(this.btniniciar_Click);
            // 
            // imagen
            // 
            this.imagen.BackColor = System.Drawing.Color.Transparent;
            this.imagen.BackgroundImage = global::PSMtecnology.Properties.Resources.correcto;
            this.imagen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imagen.Location = new System.Drawing.Point(9, 16);
            this.imagen.Name = "imagen";
            this.imagen.Size = new System.Drawing.Size(94, 95);
            this.imagen.TabIndex = 12;
            this.imagen.TabStop = false;
            // 
            // btncerrar
            // 
            this.btncerrar.BackColor = System.Drawing.Color.White;
            this.btncerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btncerrar.FlatAppearance.BorderSize = 0;
            this.btncerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncerrar.Image = global::PSMtecnology.Properties.Resources.cerrar;
            this.btncerrar.Location = new System.Drawing.Point(289, 10);
            this.btncerrar.Name = "btncerrar";
            this.btncerrar.Size = new System.Drawing.Size(21, 21);
            this.btncerrar.TabIndex = 11;
            this.btncerrar.UseVisualStyleBackColor = false;
            this.btncerrar.Click += new System.EventHandler(this.btncerrar_Click);
            // 
            // mensajecorrecto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(320, 124);
            this.ControlBox = false;
            this.Controls.Add(this.lblalerta);
            this.Controls.Add(this.btniniciar);
            this.Controls.Add(this.imagen);
            this.Controls.Add(this.btncerrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximumSize = new System.Drawing.Size(322, 126);
            this.MinimumSize = new System.Drawing.Size(322, 126);
            this.Name = "mensajecorrecto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.imagen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public Label lblalerta;
        private Button btniniciar;
        private Button btncerrar;
        public PictureBox imagen;
    }
}