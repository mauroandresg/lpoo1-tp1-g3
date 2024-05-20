namespace Vistas
{
    partial class FormUsuario
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.usuRol = new System.Windows.Forms.ComboBox();
            this.usuApellido = new System.Windows.Forms.TextBox();
            this.usuNombre = new System.Windows.Forms.TextBox();
            this.usuEmail = new System.Windows.Forms.TextBox();
            this.usuUsuario = new System.Windows.Forms.TextBox();
            this.usuContraseña = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(88, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Datos del Usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Rol";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(68, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Apellido";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(68, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nombre";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(68, 214);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Email";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(68, 255);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Usuario";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(68, 293);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Contraseña";
            // 
            // usuRol
            // 
            this.usuRol.FormattingEnabled = true;
            this.usuRol.Location = new System.Drawing.Point(140, 84);
            this.usuRol.Name = "usuRol";
            this.usuRol.Size = new System.Drawing.Size(149, 21);
            this.usuRol.TabIndex = 7;
            // 
            // usuApellido
            // 
            this.usuApellido.Location = new System.Drawing.Point(140, 125);
            this.usuApellido.Name = "usuApellido";
            this.usuApellido.Size = new System.Drawing.Size(149, 20);
            this.usuApellido.TabIndex = 8;
            // 
            // usuNombre
            // 
            this.usuNombre.Location = new System.Drawing.Point(140, 166);
            this.usuNombre.Name = "usuNombre";
            this.usuNombre.Size = new System.Drawing.Size(149, 20);
            this.usuNombre.TabIndex = 9;
            // 
            // usuEmail
            // 
            this.usuEmail.Location = new System.Drawing.Point(140, 207);
            this.usuEmail.Name = "usuEmail";
            this.usuEmail.Size = new System.Drawing.Size(149, 20);
            this.usuEmail.TabIndex = 10;
            // 
            // usuUsuario
            // 
            this.usuUsuario.Location = new System.Drawing.Point(140, 247);
            this.usuUsuario.Name = "usuUsuario";
            this.usuUsuario.Size = new System.Drawing.Size(149, 20);
            this.usuUsuario.TabIndex = 11;
            // 
            // usuContraseña
            // 
            this.usuContraseña.Location = new System.Drawing.Point(140, 285);
            this.usuContraseña.Name = "usuContraseña";
            this.usuContraseña.Size = new System.Drawing.Size(149, 20);
            this.usuContraseña.TabIndex = 12;
            // 
            // FormUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 386);
            this.Controls.Add(this.usuContraseña);
            this.Controls.Add(this.usuUsuario);
            this.Controls.Add(this.usuEmail);
            this.Controls.Add(this.usuNombre);
            this.Controls.Add(this.usuApellido);
            this.Controls.Add(this.usuRol);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormUsuario";
            this.Text = "FormUsuario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox usuRol;
        private System.Windows.Forms.TextBox usuApellido;
        private System.Windows.Forms.TextBox usuNombre;
        private System.Windows.Forms.TextBox usuEmail;
        private System.Windows.Forms.TextBox usuUsuario;
        private System.Windows.Forms.TextBox usuContraseña;
    }
}