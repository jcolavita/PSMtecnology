using System.Windows.Forms;

namespace TrabajoDeGrado.Generales
{
    partial class mensajediferir
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
            this.btndiferir = new System.Windows.Forms.Button();
            this.btncerrar = new System.Windows.Forms.Button();
            this.btnreprobar = new System.Windows.Forms.Button();
            this.btncancelar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblalerta
            // 
            this.lblalerta.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblalerta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblalerta.Location = new System.Drawing.Point(131, 37);
            this.lblalerta.Name = "lblalerta";
            this.lblalerta.Size = new System.Drawing.Size(296, 37);
            this.lblalerta.TabIndex = 14;
            this.lblalerta.Text = "El estudiante ingresado ya se encuentra registrado en otro proyecto, que desea ha" +
    "cer?";
            this.lblalerta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btndiferir
            // 
            this.btndiferir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(24)))), ((int)(((byte)(67)))));
            this.btndiferir.FlatAppearance.BorderSize = 0;
            this.btndiferir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndiferir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btndiferir.ForeColor = System.Drawing.Color.White;
            this.btndiferir.Location = new System.Drawing.Point(131, 86);
            this.btndiferir.Name = "btndiferir";
            this.btndiferir.Size = new System.Drawing.Size(85, 27);
            this.btndiferir.TabIndex = 13;
            this.btndiferir.Text = "Diferir";
            this.btndiferir.UseVisualStyleBackColor = false;
            this.btndiferir.Click += new System.EventHandler(this.btndiferir_Click);
            // 
            // btncerrar
            // 
            this.btncerrar.BackColor = System.Drawing.Color.White;
            this.btncerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btncerrar.FlatAppearance.BorderSize = 0;
            this.btncerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncerrar.Image = global::PSMtecnology.Properties.Resources.cerrar;
            this.btncerrar.Location = new System.Drawing.Point(408, 11);
            this.btncerrar.Name = "btncerrar";
            this.btncerrar.Size = new System.Drawing.Size(21, 21);
            this.btncerrar.TabIndex = 11;
            this.btncerrar.UseVisualStyleBackColor = false;
            this.btncerrar.Click += new System.EventHandler(this.btncerrar_Click);
            // 
            // btnreprobar
            // 
            this.btnreprobar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(24)))), ((int)(((byte)(67)))));
            this.btnreprobar.FlatAppearance.BorderSize = 0;
            this.btnreprobar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnreprobar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnreprobar.ForeColor = System.Drawing.Color.White;
            this.btnreprobar.Location = new System.Drawing.Point(236, 86);
            this.btnreprobar.Name = "btnreprobar";
            this.btnreprobar.Size = new System.Drawing.Size(85, 27);
            this.btnreprobar.TabIndex = 15;
            this.btnreprobar.Text = "Reprobar";
            this.btnreprobar.UseVisualStyleBackColor = false;
            this.btnreprobar.Click += new System.EventHandler(this.btnreprobar_Click);
            // 
            // btncancelar
            // 
            this.btncancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(24)))), ((int)(((byte)(67)))));
            this.btncancelar.FlatAppearance.BorderSize = 0;
            this.btncancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btncancelar.ForeColor = System.Drawing.Color.White;
            this.btncancelar.Location = new System.Drawing.Point(342, 86);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(85, 27);
            this.btncancelar.TabIndex = 16;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.UseVisualStyleBackColor = false;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::PSMtecnology.Properties.Resources.informacion;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(12, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // mensajediferir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(439, 124);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btnreprobar);
            this.Controls.Add(this.lblalerta);
            this.Controls.Add(this.btndiferir);
            this.Controls.Add(this.btncerrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MinimumSize = new System.Drawing.Size(322, 126);
            this.Name = "mensajediferir";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public Label lblalerta;
        private Button btndiferir;
        private Button btncerrar;
        private Button btnreprobar;
        private Button btncancelar;
        private PictureBox pictureBox1;
    }
}