namespace Vistas
{
    partial class FormAtleta
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
            this.btnCrearAtleta = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textNombre = new System.Windows.Forms.TextBox();
            this.textApellido = new System.Windows.Forms.TextBox();
            this.lbCrearAtleta = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCrearAtleta
            // 
            this.btnCrearAtleta.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearAtleta.Location = new System.Drawing.Point(94, 256);
            this.btnCrearAtleta.Name = "btnCrearAtleta";
            this.btnCrearAtleta.Size = new System.Drawing.Size(204, 44);
            this.btnCrearAtleta.TabIndex = 0;
            this.btnCrearAtleta.Text = "Crear";
            this.btnCrearAtleta.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Apellido";
            // 
            // textNombre
            // 
            this.textNombre.Location = new System.Drawing.Point(94, 124);
            this.textNombre.Name = "textNombre";
            this.textNombre.Size = new System.Drawing.Size(204, 20);
            this.textNombre.TabIndex = 3;
            // 
            // textApellido
            // 
            this.textApellido.Location = new System.Drawing.Point(94, 162);
            this.textApellido.Name = "textApellido";
            this.textApellido.Size = new System.Drawing.Size(204, 20);
            this.textApellido.TabIndex = 4;
            // 
            // lbCrearAtleta
            // 
            this.lbCrearAtleta.AutoSize = true;
            this.lbCrearAtleta.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCrearAtleta.Location = new System.Drawing.Point(112, 57);
            this.lbCrearAtleta.Name = "lbCrearAtleta";
            this.lbCrearAtleta.Size = new System.Drawing.Size(159, 31);
            this.lbCrearAtleta.TabIndex = 5;
            this.lbCrearAtleta.Text = "Crear Atleta";
            // 
            // Formulario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 406);
            this.Controls.Add(this.lbCrearAtleta);
            this.Controls.Add(this.textApellido);
            this.Controls.Add(this.textNombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCrearAtleta);
            this.Name = "Formulario";
            this.Text = "Formulario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCrearAtleta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textNombre;
        private System.Windows.Forms.TextBox textApellido;
        private System.Windows.Forms.Label lbCrearAtleta;
    }
}