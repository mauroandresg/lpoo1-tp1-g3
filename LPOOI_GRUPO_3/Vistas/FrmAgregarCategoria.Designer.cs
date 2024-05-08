namespace Vistas
{
    partial class FrmAgregarCategoria
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
            this.txtNombreNuevaCategoria = new System.Windows.Forms.TextBox();
            this.txtCategoriaNuevaDescripcion = new System.Windows.Forms.TextBox();
            this.btnGuadarNuevaCategoria = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(133, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nueva categoria";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(134, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(134, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Descripcion";
            // 
            // txtNombreNuevaCategoria
            // 
            this.txtNombreNuevaCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreNuevaCategoria.Location = new System.Drawing.Point(264, 112);
            this.txtNombreNuevaCategoria.Name = "txtNombreNuevaCategoria";
            this.txtNombreNuevaCategoria.Size = new System.Drawing.Size(174, 30);
            this.txtNombreNuevaCategoria.TabIndex = 3;
            // 
            // txtCategoriaNuevaDescripcion
            // 
            this.txtCategoriaNuevaDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCategoriaNuevaDescripcion.Location = new System.Drawing.Point(264, 185);
            this.txtCategoriaNuevaDescripcion.Name = "txtCategoriaNuevaDescripcion";
            this.txtCategoriaNuevaDescripcion.Size = new System.Drawing.Size(282, 30);
            this.txtCategoriaNuevaDescripcion.TabIndex = 4;
            // 
            // btnGuadarNuevaCategoria
            // 
            this.btnGuadarNuevaCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuadarNuevaCategoria.Location = new System.Drawing.Point(326, 260);
            this.btnGuadarNuevaCategoria.Name = "btnGuadarNuevaCategoria";
            this.btnGuadarNuevaCategoria.Size = new System.Drawing.Size(112, 33);
            this.btnGuadarNuevaCategoria.TabIndex = 5;
            this.btnGuadarNuevaCategoria.Text = "Guardar";
            this.btnGuadarNuevaCategoria.UseVisualStyleBackColor = true;
            this.btnGuadarNuevaCategoria.Click += new System.EventHandler(this.btnGuadarNuevaCategoria_Click);
            // 
            // FrmAgregarCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkKhaki;
            this.ClientSize = new System.Drawing.Size(631, 343);
            this.Controls.Add(this.btnGuadarNuevaCategoria);
            this.Controls.Add(this.txtCategoriaNuevaDescripcion);
            this.Controls.Add(this.txtNombreNuevaCategoria);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmAgregarCategoria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar nueva categoria";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNombreNuevaCategoria;
        private System.Windows.Forms.TextBox txtCategoriaNuevaDescripcion;
        private System.Windows.Forms.Button btnGuadarNuevaCategoria;
    }
}