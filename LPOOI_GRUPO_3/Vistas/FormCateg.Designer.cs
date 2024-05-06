namespace Vistas
{
    partial class FormCateg
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
            this.btnCrearCat = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textNombreCat = new System.Windows.Forms.TextBox();
            this.textDescripcionCat = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCrearCat
            // 
            this.btnCrearCat.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearCat.Location = new System.Drawing.Point(96, 198);
            this.btnCrearCat.Name = "btnCrearCat";
            this.btnCrearCat.Size = new System.Drawing.Size(158, 38);
            this.btnCrearCat.TabIndex = 0;
            this.btnCrearCat.Text = "Crear";
            this.btnCrearCat.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Descripcion";
            // 
            // textNombreCat
            // 
            this.textNombreCat.Location = new System.Drawing.Point(96, 85);
            this.textNombreCat.Name = "textNombreCat";
            this.textNombreCat.Size = new System.Drawing.Size(158, 20);
            this.textNombreCat.TabIndex = 3;
            // 
            // textDescripcionCat
            // 
            this.textDescripcionCat.Location = new System.Drawing.Point(96, 145);
            this.textDescripcionCat.Name = "textDescripcionCat";
            this.textDescripcionCat.Size = new System.Drawing.Size(158, 20);
            this.textDescripcionCat.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(80, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(207, 31);
            this.label3.TabIndex = 5;
            this.label3.Text = "Crear Categoria";
            // 
            // FormCateg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 340);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textDescripcionCat);
            this.Controls.Add(this.textNombreCat);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCrearCat);
            this.Name = "FormCateg";
            this.Text = "FormCateg";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCrearCat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textNombreCat;
        private System.Windows.Forms.TextBox textDescripcionCat;
        private System.Windows.Forms.Label label3;
    }
}