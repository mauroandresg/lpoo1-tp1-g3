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
            this.btnCrearCat.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCrearCat.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearCat.Location = new System.Drawing.Point(311, 240);
            this.btnCrearCat.Name = "btnCrearCat";
            this.btnCrearCat.Size = new System.Drawing.Size(140, 49);
            this.btnCrearCat.TabIndex = 0;
            this.btnCrearCat.Text = "Crear";
            this.btnCrearCat.UseVisualStyleBackColor = true;
            this.btnCrearCat.Click += new System.EventHandler(this.btnCrearCat_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(207, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(207, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Descripcion";
            // 
            // textNombreCat
            // 
            this.textNombreCat.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textNombreCat.Location = new System.Drawing.Point(280, 127);
            this.textNombreCat.Name = "textNombreCat";
            this.textNombreCat.Size = new System.Drawing.Size(205, 20);
            this.textNombreCat.TabIndex = 3;
            // 
            // textDescripcionCat
            // 
            this.textDescripcionCat.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textDescripcionCat.Location = new System.Drawing.Point(280, 187);
            this.textDescripcionCat.Name = "textDescripcionCat";
            this.textDescripcionCat.Size = new System.Drawing.Size(205, 20);
            this.textDescripcionCat.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(278, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(207, 31);
            this.label3.TabIndex = 5;
            this.label3.Text = "Crear Categoria";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormCateg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(789, 491);
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