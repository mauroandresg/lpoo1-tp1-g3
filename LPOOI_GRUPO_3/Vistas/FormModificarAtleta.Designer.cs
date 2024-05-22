namespace Vistas
{
    partial class FormModificarAtleta
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
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.textBoxBuscar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewAtleta = new System.Windows.Forms.DataGridView();
            this.textBoxNombreAtleta = new System.Windows.Forms.TextBox();
            this.textBoxNacionalidadAtleta = new System.Windows.Forms.TextBox();
            this.textBoxApellidoAtleta = new System.Windows.Forms.TextBox();
            this.textBoxDNIatleta = new System.Windows.Forms.TextBox();
            this.textBoxIdAtleta = new System.Windows.Forms.TextBox();
            this.textBoxEntrenadorAtleta = new System.Windows.Forms.TextBox();
            this.textBoxGeneroAtleta = new System.Windows.Forms.TextBox();
            this.textBoxAlturaAtleta = new System.Windows.Forms.TextBox();
            this.textBoxPesoAtleta = new System.Windows.Forms.TextBox();
            this.textBoxFechaNacAtleta = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.textBoxDireccionAtleta = new System.Windows.Forms.TextBox();
            this.textBoxEmailAtleta = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.buttonModificar = new System.Windows.Forms.Button();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAtleta)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(188, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "BUSCAR ATLETA";
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.buttonBuscar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.buttonBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBuscar.Location = new System.Drawing.Point(208, 207);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(134, 37);
            this.buttonBuscar.TabIndex = 1;
            this.buttonBuscar.Text = "BUSCAR";
            this.buttonBuscar.UseVisualStyleBackColor = false;
            this.buttonBuscar.Click += new System.EventHandler(this.buttonBuscar_Click);
            // 
            // textBoxBuscar
            // 
            this.textBoxBuscar.Location = new System.Drawing.Point(166, 164);
            this.textBoxBuscar.Name = "textBoxBuscar";
            this.textBoxBuscar.Size = new System.Drawing.Size(209, 20);
            this.textBoxBuscar.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(163, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(194, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "ingrese nombre del atleta";
            // 
            // dataGridViewAtleta
            // 
            this.dataGridViewAtleta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAtleta.Location = new System.Drawing.Point(56, 250);
            this.dataGridViewAtleta.Name = "dataGridViewAtleta";
            this.dataGridViewAtleta.Size = new System.Drawing.Size(434, 184);
            this.dataGridViewAtleta.TabIndex = 4;
            this.dataGridViewAtleta.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewAtleta_SelectionChanged);
            // 
            // textBoxNombreAtleta
            // 
            this.textBoxNombreAtleta.Location = new System.Drawing.Point(142, 136);
            this.textBoxNombreAtleta.Name = "textBoxNombreAtleta";
            this.textBoxNombreAtleta.Size = new System.Drawing.Size(100, 20);
            this.textBoxNombreAtleta.TabIndex = 5;
            // 
            // textBoxNacionalidadAtleta
            // 
            this.textBoxNacionalidadAtleta.Location = new System.Drawing.Point(142, 164);
            this.textBoxNacionalidadAtleta.Name = "textBoxNacionalidadAtleta";
            this.textBoxNacionalidadAtleta.Size = new System.Drawing.Size(100, 20);
            this.textBoxNacionalidadAtleta.TabIndex = 6;
            // 
            // textBoxApellidoAtleta
            // 
            this.textBoxApellidoAtleta.Location = new System.Drawing.Point(142, 108);
            this.textBoxApellidoAtleta.Name = "textBoxApellidoAtleta";
            this.textBoxApellidoAtleta.Size = new System.Drawing.Size(100, 20);
            this.textBoxApellidoAtleta.TabIndex = 7;
            // 
            // textBoxDNIatleta
            // 
            this.textBoxDNIatleta.Location = new System.Drawing.Point(142, 80);
            this.textBoxDNIatleta.Name = "textBoxDNIatleta";
            this.textBoxDNIatleta.Size = new System.Drawing.Size(100, 20);
            this.textBoxDNIatleta.TabIndex = 8;
            // 
            // textBoxIdAtleta
            // 
            this.textBoxIdAtleta.Location = new System.Drawing.Point(142, 52);
            this.textBoxIdAtleta.Name = "textBoxIdAtleta";
            this.textBoxIdAtleta.Size = new System.Drawing.Size(100, 20);
            this.textBoxIdAtleta.TabIndex = 9;
            // 
            // textBoxEntrenadorAtleta
            // 
            this.textBoxEntrenadorAtleta.Location = new System.Drawing.Point(142, 192);
            this.textBoxEntrenadorAtleta.Name = "textBoxEntrenadorAtleta";
            this.textBoxEntrenadorAtleta.Size = new System.Drawing.Size(100, 20);
            this.textBoxEntrenadorAtleta.TabIndex = 10;
            // 
            // textBoxGeneroAtleta
            // 
            this.textBoxGeneroAtleta.Location = new System.Drawing.Point(142, 220);
            this.textBoxGeneroAtleta.Name = "textBoxGeneroAtleta";
            this.textBoxGeneroAtleta.Size = new System.Drawing.Size(100, 20);
            this.textBoxGeneroAtleta.TabIndex = 11;
            // 
            // textBoxAlturaAtleta
            // 
            this.textBoxAlturaAtleta.Location = new System.Drawing.Point(142, 248);
            this.textBoxAlturaAtleta.Name = "textBoxAlturaAtleta";
            this.textBoxAlturaAtleta.Size = new System.Drawing.Size(100, 20);
            this.textBoxAlturaAtleta.TabIndex = 12;
            // 
            // textBoxPesoAtleta
            // 
            this.textBoxPesoAtleta.Location = new System.Drawing.Point(142, 276);
            this.textBoxPesoAtleta.Name = "textBoxPesoAtleta";
            this.textBoxPesoAtleta.Size = new System.Drawing.Size(100, 20);
            this.textBoxPesoAtleta.TabIndex = 13;
            // 
            // textBoxFechaNacAtleta
            // 
            this.textBoxFechaNacAtleta.Location = new System.Drawing.Point(142, 302);
            this.textBoxFechaNacAtleta.Name = "textBoxFechaNacAtleta";
            this.textBoxFechaNacAtleta.Size = new System.Drawing.Size(100, 20);
            this.textBoxFechaNacAtleta.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(38, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "id Atleta";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(38, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "DNI Atleta";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(38, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Apellido Atleta";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(38, 136);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Nombre Atleta";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(38, 164);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Nacionalidad";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(38, 192);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Entrenador";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(38, 220);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "Genero";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(38, 248);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 13);
            this.label10.TabIndex = 22;
            this.label10.Text = "Altura";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(38, 276);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(35, 13);
            this.label11.TabIndex = 23;
            this.label11.Text = "Peso";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(38, 302);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(69, 13);
            this.label12.TabIndex = 24;
            this.label12.Text = "Fecha Nac";
            // 
            // textBoxDireccionAtleta
            // 
            this.textBoxDireccionAtleta.Location = new System.Drawing.Point(142, 328);
            this.textBoxDireccionAtleta.Name = "textBoxDireccionAtleta";
            this.textBoxDireccionAtleta.Size = new System.Drawing.Size(100, 20);
            this.textBoxDireccionAtleta.TabIndex = 25;
            // 
            // textBoxEmailAtleta
            // 
            this.textBoxEmailAtleta.Location = new System.Drawing.Point(142, 354);
            this.textBoxEmailAtleta.Name = "textBoxEmailAtleta";
            this.textBoxEmailAtleta.Size = new System.Drawing.Size(100, 20);
            this.textBoxEmailAtleta.TabIndex = 26;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(38, 328);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(61, 13);
            this.label13.TabIndex = 27;
            this.label13.Text = "Direccion";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(42, 354);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(37, 13);
            this.label14.TabIndex = 28;
            this.label14.Text = "Email";
            // 
            // buttonModificar
            // 
            this.buttonModificar.BackColor = System.Drawing.Color.White;
            this.buttonModificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonModificar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.buttonModificar.FlatAppearance.BorderSize = 4;
            this.buttonModificar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.buttonModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonModificar.Location = new System.Drawing.Point(45, 397);
            this.buttonModificar.Name = "buttonModificar";
            this.buttonModificar.Size = new System.Drawing.Size(110, 37);
            this.buttonModificar.TabIndex = 29;
            this.buttonModificar.Text = "MODIFICAR";
            this.buttonModificar.UseVisualStyleBackColor = false;
            this.buttonModificar.Click += new System.EventHandler(this.buttonModificar_Click);
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.BackColor = System.Drawing.Color.White;
            this.buttonEliminar.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.buttonEliminar.FlatAppearance.BorderSize = 4;
            this.buttonEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEliminar.Location = new System.Drawing.Point(184, 397);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(110, 37);
            this.buttonEliminar.TabIndex = 30;
            this.buttonEliminar.Text = "ELIMINAR";
            this.buttonEliminar.UseVisualStyleBackColor = false;
            this.buttonEliminar.Click += new System.EventHandler(this.buttonEliminar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.dataGridViewAtleta);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBoxBuscar);
            this.panel1.Controls.Add(this.buttonBuscar);
            this.panel1.Location = new System.Drawing.Point(72, 37);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(533, 456);
            this.panel1.TabIndex = 31;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Controls.Add(this.buttonEliminar);
            this.panel2.Controls.Add(this.buttonModificar);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.textBoxEmailAtleta);
            this.panel2.Controls.Add(this.textBoxDireccionAtleta);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.textBoxFechaNacAtleta);
            this.panel2.Controls.Add(this.textBoxPesoAtleta);
            this.panel2.Controls.Add(this.textBoxAlturaAtleta);
            this.panel2.Controls.Add(this.textBoxGeneroAtleta);
            this.panel2.Controls.Add(this.textBoxEntrenadorAtleta);
            this.panel2.Controls.Add(this.textBoxIdAtleta);
            this.panel2.Controls.Add(this.textBoxDNIatleta);
            this.panel2.Controls.Add(this.textBoxApellidoAtleta);
            this.panel2.Controls.Add(this.textBoxNacionalidadAtleta);
            this.panel2.Controls.Add(this.textBoxNombreAtleta);
            this.panel2.Location = new System.Drawing.Point(677, 37);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(364, 456);
            this.panel2.TabIndex = 32;
            // 
            // FormModificarAtleta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(1109, 517);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FormModificarAtleta";
            this.Text = "FormModificarAtleta";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAtleta)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonBuscar;
        private System.Windows.Forms.TextBox textBoxBuscar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridViewAtleta;
        private System.Windows.Forms.TextBox textBoxNombreAtleta;
        private System.Windows.Forms.TextBox textBoxNacionalidadAtleta;
        private System.Windows.Forms.TextBox textBoxApellidoAtleta;
        private System.Windows.Forms.TextBox textBoxDNIatleta;
        private System.Windows.Forms.TextBox textBoxIdAtleta;
        private System.Windows.Forms.TextBox textBoxEntrenadorAtleta;
        private System.Windows.Forms.TextBox textBoxGeneroAtleta;
        private System.Windows.Forms.TextBox textBoxAlturaAtleta;
        private System.Windows.Forms.TextBox textBoxPesoAtleta;
        private System.Windows.Forms.TextBox textBoxFechaNacAtleta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBoxDireccionAtleta;
        private System.Windows.Forms.TextBox textBoxEmailAtleta;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button buttonModificar;
        private System.Windows.Forms.Button buttonEliminar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}