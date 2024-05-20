namespace Vistas
{
    partial class FrmAtleta
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
            this.LblTitulo = new System.Windows.Forms.Label();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.TxtDni = new System.Windows.Forms.TextBox();
            this.LblDni = new System.Windows.Forms.Label();
            this.LblApellido = new System.Windows.Forms.Label();
            this.TxtApellido = new System.Windows.Forms.TextBox();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.LblNombre = new System.Windows.Forms.Label();
            this.TxtEntrenador = new System.Windows.Forms.TextBox();
            this.LblEntrenador = new System.Windows.Forms.Label();
            this.TxtNacionalidad = new System.Windows.Forms.TextBox();
            this.LblNacionalidad = new System.Windows.Forms.Label();
            this.TxtGenero = new System.Windows.Forms.TextBox();
            this.LblGenero = new System.Windows.Forms.Label();
            this.LblAltura = new System.Windows.Forms.Label();
            this.LblPeso = new System.Windows.Forms.Label();
            this.NumAltura = new System.Windows.Forms.NumericUpDown();
            this.LblFechaNac = new System.Windows.Forms.Label();
            this.NumPeso = new System.Windows.Forms.NumericUpDown();
            this.TxtDireccion = new System.Windows.Forms.TextBox();
            this.LblDireccion = new System.Windows.Forms.Label();
            this.DateFechaNac = new System.Windows.Forms.DateTimePicker();
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.LblEmail = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.NumAltura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumPeso)).BeginInit();
            this.SuspendLayout();
            // 
            // LblTitulo
            // 
            this.LblTitulo.AutoSize = true;
            this.LblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitulo.Location = new System.Drawing.Point(12, 9);
            this.LblTitulo.Name = "LblTitulo";
            this.LblTitulo.Padding = new System.Windows.Forms.Padding(0, 0, 0, 8);
            this.LblTitulo.Size = new System.Drawing.Size(107, 32);
            this.LblTitulo.TabIndex = 0;
            this.LblTitulo.Text = "Participante";
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.Location = new System.Drawing.Point(167, 336);
            this.BtnAgregar.Margin = new System.Windows.Forms.Padding(3, 8, 3, 3);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(75, 23);
            this.BtnAgregar.TabIndex = 1;
            this.BtnAgregar.Text = "Agregar";
            this.BtnAgregar.UseVisualStyleBackColor = true;
            this.BtnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // TxtDni
            // 
            this.TxtDni.Location = new System.Drawing.Point(89, 45);
            this.TxtDni.Name = "TxtDni";
            this.TxtDni.Size = new System.Drawing.Size(153, 20);
            this.TxtDni.TabIndex = 2;
            // 
            // LblDni
            // 
            this.LblDni.AutoSize = true;
            this.LblDni.Location = new System.Drawing.Point(12, 48);
            this.LblDni.Name = "LblDni";
            this.LblDni.Size = new System.Drawing.Size(26, 13);
            this.LblDni.TabIndex = 3;
            this.LblDni.Text = "DNI";
            // 
            // LblApellido
            // 
            this.LblApellido.AutoSize = true;
            this.LblApellido.Location = new System.Drawing.Point(12, 74);
            this.LblApellido.Name = "LblApellido";
            this.LblApellido.Size = new System.Drawing.Size(44, 13);
            this.LblApellido.TabIndex = 4;
            this.LblApellido.Text = "Apellido";
            // 
            // TxtApellido
            // 
            this.TxtApellido.Location = new System.Drawing.Point(89, 71);
            this.TxtApellido.Name = "TxtApellido";
            this.TxtApellido.Size = new System.Drawing.Size(153, 20);
            this.TxtApellido.TabIndex = 5;
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(89, 97);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(153, 20);
            this.TxtNombre.TabIndex = 7;
            // 
            // LblNombre
            // 
            this.LblNombre.AutoSize = true;
            this.LblNombre.Location = new System.Drawing.Point(12, 100);
            this.LblNombre.Name = "LblNombre";
            this.LblNombre.Size = new System.Drawing.Size(44, 13);
            this.LblNombre.TabIndex = 6;
            this.LblNombre.Text = "Nombre";
            // 
            // TxtEntrenador
            // 
            this.TxtEntrenador.Location = new System.Drawing.Point(89, 149);
            this.TxtEntrenador.Name = "TxtEntrenador";
            this.TxtEntrenador.Size = new System.Drawing.Size(153, 20);
            this.TxtEntrenador.TabIndex = 9;
            // 
            // LblEntrenador
            // 
            this.LblEntrenador.AutoSize = true;
            this.LblEntrenador.Location = new System.Drawing.Point(12, 152);
            this.LblEntrenador.Name = "LblEntrenador";
            this.LblEntrenador.Size = new System.Drawing.Size(59, 13);
            this.LblEntrenador.TabIndex = 8;
            this.LblEntrenador.Text = "Entrenador";
            // 
            // TxtNacionalidad
            // 
            this.TxtNacionalidad.Location = new System.Drawing.Point(89, 123);
            this.TxtNacionalidad.Name = "TxtNacionalidad";
            this.TxtNacionalidad.Size = new System.Drawing.Size(153, 20);
            this.TxtNacionalidad.TabIndex = 11;
            // 
            // LblNacionalidad
            // 
            this.LblNacionalidad.AutoSize = true;
            this.LblNacionalidad.Location = new System.Drawing.Point(12, 126);
            this.LblNacionalidad.Name = "LblNacionalidad";
            this.LblNacionalidad.Size = new System.Drawing.Size(69, 13);
            this.LblNacionalidad.TabIndex = 10;
            this.LblNacionalidad.Text = "Nacionalidad";
            // 
            // TxtGenero
            // 
            this.TxtGenero.Location = new System.Drawing.Point(89, 175);
            this.TxtGenero.Name = "TxtGenero";
            this.TxtGenero.Size = new System.Drawing.Size(153, 20);
            this.TxtGenero.TabIndex = 13;
            // 
            // LblGenero
            // 
            this.LblGenero.AutoSize = true;
            this.LblGenero.Location = new System.Drawing.Point(12, 178);
            this.LblGenero.Name = "LblGenero";
            this.LblGenero.Size = new System.Drawing.Size(42, 13);
            this.LblGenero.TabIndex = 12;
            this.LblGenero.Text = "Género";
            // 
            // LblAltura
            // 
            this.LblAltura.AutoSize = true;
            this.LblAltura.Location = new System.Drawing.Point(12, 204);
            this.LblAltura.Name = "LblAltura";
            this.LblAltura.Size = new System.Drawing.Size(34, 13);
            this.LblAltura.TabIndex = 14;
            this.LblAltura.Text = "Altura";
            // 
            // LblPeso
            // 
            this.LblPeso.AutoSize = true;
            this.LblPeso.Location = new System.Drawing.Point(12, 230);
            this.LblPeso.Name = "LblPeso";
            this.LblPeso.Size = new System.Drawing.Size(31, 13);
            this.LblPeso.TabIndex = 16;
            this.LblPeso.Text = "Peso";
            // 
            // NumAltura
            // 
            this.NumAltura.Location = new System.Drawing.Point(89, 201);
            this.NumAltura.Name = "NumAltura";
            this.NumAltura.Size = new System.Drawing.Size(153, 20);
            this.NumAltura.TabIndex = 18;
            // 
            // LblFechaNac
            // 
            this.LblFechaNac.AutoSize = true;
            this.LblFechaNac.Location = new System.Drawing.Point(12, 256);
            this.LblFechaNac.Name = "LblFechaNac";
            this.LblFechaNac.Size = new System.Drawing.Size(108, 13);
            this.LblFechaNac.TabIndex = 19;
            this.LblFechaNac.Text = "Fecha de Nacimiento";
            // 
            // NumPeso
            // 
            this.NumPeso.Location = new System.Drawing.Point(89, 227);
            this.NumPeso.Name = "NumPeso";
            this.NumPeso.Size = new System.Drawing.Size(153, 20);
            this.NumPeso.TabIndex = 21;
            // 
            // TxtDireccion
            // 
            this.TxtDireccion.Location = new System.Drawing.Point(89, 279);
            this.TxtDireccion.Name = "TxtDireccion";
            this.TxtDireccion.Size = new System.Drawing.Size(153, 20);
            this.TxtDireccion.TabIndex = 23;
            // 
            // LblDireccion
            // 
            this.LblDireccion.AutoSize = true;
            this.LblDireccion.Location = new System.Drawing.Point(12, 282);
            this.LblDireccion.Name = "LblDireccion";
            this.LblDireccion.Size = new System.Drawing.Size(52, 13);
            this.LblDireccion.TabIndex = 22;
            this.LblDireccion.Text = "Dirección";
            // 
            // DateFechaNac
            // 
            this.DateFechaNac.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateFechaNac.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.DateFechaNac.Location = new System.Drawing.Point(126, 253);
            this.DateFechaNac.Name = "DateFechaNac";
            this.DateFechaNac.Size = new System.Drawing.Size(116, 20);
            this.DateFechaNac.TabIndex = 24;
            // 
            // TxtEmail
            // 
            this.TxtEmail.Location = new System.Drawing.Point(89, 305);
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(153, 20);
            this.TxtEmail.TabIndex = 26;
            // 
            // LblEmail
            // 
            this.LblEmail.AutoSize = true;
            this.LblEmail.Location = new System.Drawing.Point(12, 308);
            this.LblEmail.Name = "LblEmail";
            this.LblEmail.Size = new System.Drawing.Size(32, 13);
            this.LblEmail.TabIndex = 25;
            this.LblEmail.Text = "Email";
            // 
            // FrmAtleta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(254, 371);
            this.Controls.Add(this.TxtEmail);
            this.Controls.Add(this.LblEmail);
            this.Controls.Add(this.DateFechaNac);
            this.Controls.Add(this.TxtDireccion);
            this.Controls.Add(this.LblDireccion);
            this.Controls.Add(this.NumPeso);
            this.Controls.Add(this.LblFechaNac);
            this.Controls.Add(this.NumAltura);
            this.Controls.Add(this.LblPeso);
            this.Controls.Add(this.LblAltura);
            this.Controls.Add(this.TxtGenero);
            this.Controls.Add(this.LblGenero);
            this.Controls.Add(this.TxtNacionalidad);
            this.Controls.Add(this.LblNacionalidad);
            this.Controls.Add(this.TxtEntrenador);
            this.Controls.Add(this.LblEntrenador);
            this.Controls.Add(this.TxtNombre);
            this.Controls.Add(this.LblNombre);
            this.Controls.Add(this.TxtApellido);
            this.Controls.Add(this.LblApellido);
            this.Controls.Add(this.LblDni);
            this.Controls.Add(this.TxtDni);
            this.Controls.Add(this.BtnAgregar);
            this.Controls.Add(this.LblTitulo);
            this.Name = "FrmAtleta";
            this.Text = "Atletas";
            ((System.ComponentModel.ISupportInitialize)(this.NumAltura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumPeso)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblTitulo;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.TextBox TxtDni;
        private System.Windows.Forms.Label LblDni;
        private System.Windows.Forms.Label LblApellido;
        private System.Windows.Forms.TextBox TxtApellido;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.Label LblNombre;
        private System.Windows.Forms.TextBox TxtEntrenador;
        private System.Windows.Forms.Label LblEntrenador;
        private System.Windows.Forms.TextBox TxtNacionalidad;
        private System.Windows.Forms.Label LblNacionalidad;
        private System.Windows.Forms.TextBox TxtGenero;
        private System.Windows.Forms.Label LblGenero;
        private System.Windows.Forms.Label LblAltura;
        private System.Windows.Forms.Label LblPeso;
        private System.Windows.Forms.NumericUpDown NumAltura;
        private System.Windows.Forms.Label LblFechaNac;
        private System.Windows.Forms.NumericUpDown NumPeso;
        private System.Windows.Forms.TextBox TxtDireccion;
        private System.Windows.Forms.Label LblDireccion;
        private System.Windows.Forms.DateTimePicker DateFechaNac;
        private System.Windows.Forms.TextBox TxtEmail;
        private System.Windows.Forms.Label LblEmail;
    }
}