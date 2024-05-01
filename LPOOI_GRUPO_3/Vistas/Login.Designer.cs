﻿namespace Vistas
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.lblTitulo = new System.Windows.Forms.Label();
            this.PicLogo = new System.Windows.Forms.PictureBox();
            this.PnlLogo = new System.Windows.Forms.Panel();
            this.LblSubtitulo = new System.Windows.Forms.Label();
            this.LblUsuario = new System.Windows.Forms.Label();
            this.BtnIngresar = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.LblContra = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.PicLogo)).BeginInit();
            this.PnlLogo.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lblTitulo.Location = new System.Drawing.Point(19, 16);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Padding = new System.Windows.Forms.Padding(0, 8, 0, 0);
            this.lblTitulo.Size = new System.Drawing.Size(140, 37);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Bienvenido!";
            // 
            // PicLogo
            // 
            this.PicLogo.Image = ((System.Drawing.Image)(resources.GetObject("PicLogo.Image")));
            this.PicLogo.InitialImage = null;
            this.PicLogo.Location = new System.Drawing.Point(8, 73);
            this.PicLogo.Margin = new System.Windows.Forms.Padding(0);
            this.PicLogo.Name = "PicLogo";
            this.PicLogo.Size = new System.Drawing.Size(150, 75);
            this.PicLogo.TabIndex = 1;
            this.PicLogo.TabStop = false;
            // 
            // PnlLogo
            // 
            this.PnlLogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PnlLogo.Controls.Add(this.PicLogo);
            this.PnlLogo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.PnlLogo.Location = new System.Drawing.Point(297, 19);
            this.PnlLogo.Name = "PnlLogo";
            this.PnlLogo.Padding = new System.Windows.Forms.Padding(8);
            this.PnlLogo.Size = new System.Drawing.Size(168, 223);
            this.PnlLogo.TabIndex = 2;
            // 
            // LblSubtitulo
            // 
            this.LblSubtitulo.AutoSize = true;
            this.LblSubtitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.LblSubtitulo.Location = new System.Drawing.Point(19, 53);
            this.LblSubtitulo.Margin = new System.Windows.Forms.Padding(3, 0, 3, 32);
            this.LblSubtitulo.Name = "LblSubtitulo";
            this.LblSubtitulo.Size = new System.Drawing.Size(264, 17);
            this.LblSubtitulo.TabIndex = 3;
            this.LblSubtitulo.Text = "Accede a tu cuenta con tus credenciales";
            // 
            // LblUsuario
            // 
            this.LblUsuario.AutoSize = true;
            this.LblUsuario.Location = new System.Drawing.Point(19, 94);
            this.LblUsuario.Name = "LblUsuario";
            this.LblUsuario.Size = new System.Drawing.Size(96, 13);
            this.LblUsuario.TabIndex = 4;
            this.LblUsuario.Text = "Nombre de usuario";
            // 
            // BtnIngresar
            // 
            this.BtnIngresar.Location = new System.Drawing.Point(19, 219);
            this.BtnIngresar.Name = "BtnIngresar";
            this.BtnIngresar.Size = new System.Drawing.Size(75, 23);
            this.BtnIngresar.TabIndex = 5;
            this.BtnIngresar.Text = "Ingresar";
            this.BtnIngresar.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(19, 110);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(140, 20);
            this.textBox1.TabIndex = 6;
            // 
            // LblContra
            // 
            this.LblContra.AutoSize = true;
            this.LblContra.Location = new System.Drawing.Point(20, 137);
            this.LblContra.Name = "LblContra";
            this.LblContra.Size = new System.Drawing.Size(61, 13);
            this.LblContra.TabIndex = 7;
            this.LblContra.Text = "Contraseña";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(19, 153);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(140, 20);
            this.textBox2.TabIndex = 8;
            // 
            // Login
            // 
            this.AcceptButton = this.BtnIngresar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 261);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.LblContra);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.BtnIngresar);
            this.Controls.Add(this.LblUsuario);
            this.Controls.Add(this.LblSubtitulo);
            this.Controls.Add(this.PnlLogo);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Login";
            this.Padding = new System.Windows.Forms.Padding(16);
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.PicLogo)).EndInit();
            this.PnlLogo.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.PictureBox PicLogo;
        private System.Windows.Forms.Panel PnlLogo;
        private System.Windows.Forms.Label LblSubtitulo;
        private System.Windows.Forms.Label LblUsuario;
        private System.Windows.Forms.Button BtnIngresar;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label LblContra;
        private System.Windows.Forms.TextBox textBox2;
    }
}