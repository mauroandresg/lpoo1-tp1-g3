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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCrearCat
            // 
            this.btnCrearCat.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCrearCat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnCrearCat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCrearCat.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCrearCat.FlatAppearance.BorderSize = 2;
            this.btnCrearCat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.btnCrearCat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrearCat.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearCat.Location = new System.Drawing.Point(226, 165);
            this.btnCrearCat.Name = "btnCrearCat";
            this.btnCrearCat.Size = new System.Drawing.Size(140, 37);
            this.btnCrearCat.TabIndex = 0;
            this.btnCrearCat.Text = "Crear";
            this.btnCrearCat.UseVisualStyleBackColor = false;
            this.btnCrearCat.Click += new System.EventHandler(this.btnCrearCat_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Location = new System.Drawing.Point(30, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre :";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label2.Location = new System.Drawing.Point(30, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Descripcion :";
            // 
            // textNombreCat
            // 
            this.textNombreCat.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textNombreCat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textNombreCat.Location = new System.Drawing.Point(208, 40);
            this.textNombreCat.Name = "textNombreCat";
            this.textNombreCat.Size = new System.Drawing.Size(205, 26);
            this.textNombreCat.TabIndex = 3;
            // 
            // textDescripcionCat
            // 
            this.textDescripcionCat.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textDescripcionCat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textDescripcionCat.Location = new System.Drawing.Point(208, 98);
            this.textDescripcionCat.Name = "textDescripcionCat";
            this.textDescripcionCat.Size = new System.Drawing.Size(205, 26);
            this.textDescripcionCat.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label3.Location = new System.Drawing.Point(247, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(274, 39);
            this.label3.TabIndex = 5;
            this.label3.Text = "Crear Categoria";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.Maroon;
            this.panel1.Controls.Add(this.textDescripcionCat);
            this.panel1.Controls.Add(this.textNombreCat);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnCrearCat);
            this.panel1.Location = new System.Drawing.Point(155, 170);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(472, 245);
            this.panel1.TabIndex = 6;
            // 
            // FormCateg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(769, 526);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Name = "FormCateg";
            this.Text = "FormCateg";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
        private System.Windows.Forms.Panel panel1;
    }
}