namespace Vistas
{
    partial class FrmAgregarDisciplina
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
            this.txtNombreNuevaDisciplina = new System.Windows.Forms.TextBox();
            this.txtDescripcionNuevaDisciplina = new System.Windows.Forms.TextBox();
            this.btnGuardarDisciplina = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 177);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(82, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(224, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nueva disciplina";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(80, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nombre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(83, 228);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Descripcion";
            // 
            // txtNombreNuevaDisciplina
            // 
            this.txtNombreNuevaDisciplina.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreNuevaDisciplina.Location = new System.Drawing.Point(212, 156);
            this.txtNombreNuevaDisciplina.Name = "txtNombreNuevaDisciplina";
            this.txtNombreNuevaDisciplina.Size = new System.Drawing.Size(223, 30);
            this.txtNombreNuevaDisciplina.TabIndex = 4;
            // 
            // txtDescripcionNuevaDisciplina
            // 
            this.txtDescripcionNuevaDisciplina.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcionNuevaDisciplina.Location = new System.Drawing.Point(212, 223);
            this.txtDescripcionNuevaDisciplina.Name = "txtDescripcionNuevaDisciplina";
            this.txtDescripcionNuevaDisciplina.Size = new System.Drawing.Size(349, 30);
            this.txtDescripcionNuevaDisciplina.TabIndex = 5;
            // 
            // btnGuardarDisciplina
            // 
            this.btnGuardarDisciplina.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarDisciplina.Location = new System.Drawing.Point(308, 277);
            this.btnGuardarDisciplina.Name = "btnGuardarDisciplina";
            this.btnGuardarDisciplina.Size = new System.Drawing.Size(105, 35);
            this.btnGuardarDisciplina.TabIndex = 6;
            this.btnGuardarDisciplina.Text = "Guardar";
            this.btnGuardarDisciplina.UseVisualStyleBackColor = true;
            this.btnGuardarDisciplina.Click += new System.EventHandler(this.btnGuardarDisciplina_Click);
            // 
            // FrmAgregarDisciplina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkKhaki;
            this.ClientSize = new System.Drawing.Size(622, 350);
            this.Controls.Add(this.btnGuardarDisciplina);
            this.Controls.Add(this.txtDescripcionNuevaDisciplina);
            this.Controls.Add(this.txtNombreNuevaDisciplina);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmAgregarDisciplina";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar nueva disciplina";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNombreNuevaDisciplina;
        private System.Windows.Forms.TextBox txtDescripcionNuevaDisciplina;
        private System.Windows.Forms.Button btnGuardarDisciplina;
    }
}