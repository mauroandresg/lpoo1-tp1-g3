namespace Vistas
{
    partial class FrmUsuario
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
            this.GBoxDatos = new System.Windows.Forms.GroupBox();
            this.LblRol = new System.Windows.Forms.Label();
            this.LblApellidoNombre = new System.Windows.Forms.Label();
            this.LblUsuario = new System.Windows.Forms.Label();
            this.LblContrasenia = new System.Windows.Forms.Label();
            this.TxtApellidoNombre = new System.Windows.Forms.TextBox();
            this.TxtUsuario = new System.Windows.Forms.TextBox();
            this.TxtContrasenia = new System.Windows.Forms.TextBox();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.ComRol = new System.Windows.Forms.ComboBox();
            this.DGridUsuario = new System.Windows.Forms.DataGridView();
            this.TxtBuscador = new System.Windows.Forms.TextBox();
            this.BtnBuscardor = new System.Windows.Forms.Button();
            this.GBoxDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGridUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // GBoxDatos
            // 
            this.GBoxDatos.Controls.Add(this.ComRol);
            this.GBoxDatos.Controls.Add(this.TxtContrasenia);
            this.GBoxDatos.Controls.Add(this.TxtUsuario);
            this.GBoxDatos.Controls.Add(this.TxtApellidoNombre);
            this.GBoxDatos.Controls.Add(this.LblContrasenia);
            this.GBoxDatos.Controls.Add(this.LblUsuario);
            this.GBoxDatos.Controls.Add(this.LblApellidoNombre);
            this.GBoxDatos.Controls.Add(this.LblRol);
            this.GBoxDatos.Location = new System.Drawing.Point(481, 130);
            this.GBoxDatos.Name = "GBoxDatos";
            this.GBoxDatos.Padding = new System.Windows.Forms.Padding(8);
            this.GBoxDatos.Size = new System.Drawing.Size(300, 190);
            this.GBoxDatos.TabIndex = 0;
            this.GBoxDatos.TabStop = false;
            this.GBoxDatos.Text = "Datos del Usuario";
            // 
            // LblRol
            // 
            this.LblRol.AutoSize = true;
            this.LblRol.Location = new System.Drawing.Point(11, 37);
            this.LblRol.Margin = new System.Windows.Forms.Padding(3, 16, 3, 24);
            this.LblRol.Name = "LblRol";
            this.LblRol.Size = new System.Drawing.Size(23, 13);
            this.LblRol.TabIndex = 0;
            this.LblRol.Text = "Rol";
            // 
            // LblApellidoNombre
            // 
            this.LblApellidoNombre.AutoSize = true;
            this.LblApellidoNombre.Location = new System.Drawing.Point(11, 74);
            this.LblApellidoNombre.Margin = new System.Windows.Forms.Padding(3, 0, 3, 24);
            this.LblApellidoNombre.Name = "LblApellidoNombre";
            this.LblApellidoNombre.Size = new System.Drawing.Size(92, 13);
            this.LblApellidoNombre.TabIndex = 1;
            this.LblApellidoNombre.Text = "Apellido y Nombre";
            // 
            // LblUsuario
            // 
            this.LblUsuario.AutoSize = true;
            this.LblUsuario.Location = new System.Drawing.Point(11, 111);
            this.LblUsuario.Margin = new System.Windows.Forms.Padding(3, 0, 3, 24);
            this.LblUsuario.Name = "LblUsuario";
            this.LblUsuario.Size = new System.Drawing.Size(98, 13);
            this.LblUsuario.TabIndex = 2;
            this.LblUsuario.Text = "Nombre de Usuario";
            // 
            // LblContrasenia
            // 
            this.LblContrasenia.AutoSize = true;
            this.LblContrasenia.Location = new System.Drawing.Point(11, 148);
            this.LblContrasenia.Name = "LblContrasenia";
            this.LblContrasenia.Size = new System.Drawing.Size(61, 13);
            this.LblContrasenia.TabIndex = 3;
            this.LblContrasenia.Text = "Contraseña";
            // 
            // TxtApellidoNombre
            // 
            this.TxtApellidoNombre.Location = new System.Drawing.Point(139, 71);
            this.TxtApellidoNombre.Name = "TxtApellidoNombre";
            this.TxtApellidoNombre.Size = new System.Drawing.Size(150, 20);
            this.TxtApellidoNombre.TabIndex = 5;
            // 
            // TxtUsuario
            // 
            this.TxtUsuario.Location = new System.Drawing.Point(139, 108);
            this.TxtUsuario.Name = "TxtUsuario";
            this.TxtUsuario.Size = new System.Drawing.Size(150, 20);
            this.TxtUsuario.TabIndex = 6;
            // 
            // TxtContrasenia
            // 
            this.TxtContrasenia.Location = new System.Drawing.Point(139, 145);
            this.TxtContrasenia.Name = "TxtContrasenia";
            this.TxtContrasenia.Size = new System.Drawing.Size(150, 20);
            this.TxtContrasenia.TabIndex = 7;
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.Location = new System.Drawing.Point(686, 331);
            this.BtnGuardar.Margin = new System.Windows.Forms.Padding(3, 8, 3, 3);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(95, 23);
            this.BtnGuardar.TabIndex = 1;
            this.BtnGuardar.Text = "Guardar Usuario";
            this.BtnGuardar.UseVisualStyleBackColor = true;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // ComRol
            // 
            this.ComRol.FormattingEnabled = true;
            this.ComRol.Location = new System.Drawing.Point(139, 34);
            this.ComRol.Name = "ComRol";
            this.ComRol.Size = new System.Drawing.Size(150, 21);
            this.ComRol.TabIndex = 3;
            // 
            // DGridUsuario
            // 
            this.DGridUsuario.AllowUserToAddRows = false;
            this.DGridUsuario.AllowUserToDeleteRows = false;
            this.DGridUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGridUsuario.Location = new System.Drawing.Point(19, 45);
            this.DGridUsuario.Margin = new System.Windows.Forms.Padding(3, 3, 16, 3);
            this.DGridUsuario.Name = "DGridUsuario";
            this.DGridUsuario.ReadOnly = true;
            this.DGridUsuario.Size = new System.Drawing.Size(443, 386);
            this.DGridUsuario.TabIndex = 2;
            this.DGridUsuario.CurrentCellChanged += new System.EventHandler(this.DGridUsuario_CurrentCellChanged);
            // 
            // TxtBuscador
            // 
            this.TxtBuscador.Location = new System.Drawing.Point(19, 18);
            this.TxtBuscador.Name = "TxtBuscador";
            this.TxtBuscador.Size = new System.Drawing.Size(307, 20);
            this.TxtBuscador.TabIndex = 3;
            // 
            // BtnBuscardor
            // 
            this.BtnBuscardor.Location = new System.Drawing.Point(332, 16);
            this.BtnBuscardor.Name = "BtnBuscardor";
            this.BtnBuscardor.Size = new System.Drawing.Size(130, 23);
            this.BtnBuscardor.TabIndex = 4;
            this.BtnBuscardor.Text = "Buscar Apellido/Nombre";
            this.BtnBuscardor.UseVisualStyleBackColor = true;
            this.BtnBuscardor.Click += new System.EventHandler(this.BtnBuscardor_Click);
            // 
            // FrmUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnBuscardor);
            this.Controls.Add(this.TxtBuscador);
            this.Controls.Add(this.DGridUsuario);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.GBoxDatos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmUsuario";
            this.Padding = new System.Windows.Forms.Padding(16);
            this.Text = "FrmUsuario";
            this.Load += new System.EventHandler(this.FrmUsuario_Load);
            this.GBoxDatos.ResumeLayout(false);
            this.GBoxDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGridUsuario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox GBoxDatos;
        private System.Windows.Forms.ComboBox ComRol;
        private System.Windows.Forms.TextBox TxtContrasenia;
        private System.Windows.Forms.TextBox TxtUsuario;
        private System.Windows.Forms.TextBox TxtApellidoNombre;
        private System.Windows.Forms.Label LblContrasenia;
        private System.Windows.Forms.Label LblUsuario;
        private System.Windows.Forms.Label LblApellidoNombre;
        private System.Windows.Forms.Label LblRol;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.DataGridView DGridUsuario;
        private System.Windows.Forms.TextBox TxtBuscador;
        private System.Windows.Forms.Button BtnBuscardor;
    }
}