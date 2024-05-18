namespace Vistas
{
    partial class FormAgregarParticipante
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
            this.Dni = new System.Windows.Forms.TextBox();
            this.Nombre = new System.Windows.Forms.TextBox();
            this.Apellido = new System.Windows.Forms.TextBox();
            this.Nacionalidad = new System.Windows.Forms.TextBox();
            this.Entrenador = new System.Windows.Forms.TextBox();
            this.Genero = new System.Windows.Forms.TextBox();
            this.Altura = new System.Windows.Forms.TextBox();
            this.Peso = new System.Windows.Forms.TextBox();
            this.FechaNac = new System.Windows.Forms.TextBox();
            this.Direccion = new System.Windows.Forms.TextBox();
            this.Email = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Agrega el nuevo participante";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Dni
            // 
            this.Dni.Location = new System.Drawing.Point(121, 47);
            this.Dni.Name = "Dni";
            this.Dni.Size = new System.Drawing.Size(151, 20);
            this.Dni.TabIndex = 1;
            // 
            // Nombre
            // 
            this.Nombre.Location = new System.Drawing.Point(121, 73);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(151, 20);
            this.Nombre.TabIndex = 2;
            // 
            // Apellido
            // 
            this.Apellido.Location = new System.Drawing.Point(121, 99);
            this.Apellido.Name = "Apellido";
            this.Apellido.Size = new System.Drawing.Size(151, 20);
            this.Apellido.TabIndex = 3;
            // 
            // Nacionalidad
            // 
            this.Nacionalidad.Location = new System.Drawing.Point(121, 125);
            this.Nacionalidad.Name = "Nacionalidad";
            this.Nacionalidad.Size = new System.Drawing.Size(151, 20);
            this.Nacionalidad.TabIndex = 4;
            // 
            // Entrenador
            // 
            this.Entrenador.Location = new System.Drawing.Point(121, 151);
            this.Entrenador.Name = "Entrenador";
            this.Entrenador.Size = new System.Drawing.Size(151, 20);
            this.Entrenador.TabIndex = 5;
            // 
            // Genero
            // 
            this.Genero.Location = new System.Drawing.Point(121, 177);
            this.Genero.Name = "Genero";
            this.Genero.Size = new System.Drawing.Size(151, 20);
            this.Genero.TabIndex = 6;
            // 
            // Altura
            // 
            this.Altura.Location = new System.Drawing.Point(121, 203);
            this.Altura.Name = "Altura";
            this.Altura.Size = new System.Drawing.Size(151, 20);
            this.Altura.TabIndex = 7;
            // 
            // Peso
            // 
            this.Peso.Location = new System.Drawing.Point(121, 229);
            this.Peso.Name = "Peso";
            this.Peso.Size = new System.Drawing.Size(151, 20);
            this.Peso.TabIndex = 8;
            // 
            // FechaNac
            // 
            this.FechaNac.Location = new System.Drawing.Point(121, 256);
            this.FechaNac.Name = "FechaNac";
            this.FechaNac.Size = new System.Drawing.Size(151, 20);
            this.FechaNac.TabIndex = 9;
            // 
            // Direccion
            // 
            this.Direccion.Location = new System.Drawing.Point(121, 283);
            this.Direccion.Name = "Direccion";
            this.Direccion.Size = new System.Drawing.Size(151, 20);
            this.Direccion.TabIndex = 10;
            // 
            // Email
            // 
            this.Email.Location = new System.Drawing.Point(121, 308);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(151, 20);
            this.Email.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(57, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 51);
            this.label2.TabIndex = 12;
            this.label2.Text = "Dni\r\nApellido\r\nNombre\r\n";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // FormAgregarParticipante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 345);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.Direccion);
            this.Controls.Add(this.FechaNac);
            this.Controls.Add(this.Peso);
            this.Controls.Add(this.Altura);
            this.Controls.Add(this.Genero);
            this.Controls.Add(this.Entrenador);
            this.Controls.Add(this.Nacionalidad);
            this.Controls.Add(this.Apellido);
            this.Controls.Add(this.Nombre);
            this.Controls.Add(this.Dni);
            this.Controls.Add(this.label1);
            this.Name = "FormAgregarParticipante";
            this.Text = "FormAgregarParticipante";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Dni;
        private System.Windows.Forms.TextBox Nombre;
        private System.Windows.Forms.TextBox Apellido;
        private System.Windows.Forms.TextBox Nacionalidad;
        private System.Windows.Forms.TextBox Entrenador;
        private System.Windows.Forms.TextBox Genero;
        private System.Windows.Forms.TextBox Altura;
        private System.Windows.Forms.TextBox Peso;
        private System.Windows.Forms.TextBox FechaNac;
        private System.Windows.Forms.TextBox Direccion;
        private System.Windows.Forms.TextBox Email;
        private System.Windows.Forms.Label label2;
    }
}