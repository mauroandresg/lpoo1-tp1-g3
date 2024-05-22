namespace Vistas
{
    partial class FormLogin
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
            this.textName = new System.Windows.Forms.TextBox();
            this.textPassword = new System.Windows.Forms.TextBox();
            this.buttonAceptar = new System.Windows.Forms.Button();
            this.user = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textName
            // 
            this.textName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textName.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.textName.Location = new System.Drawing.Point(244, 31);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(254, 45);
            this.textName.TabIndex = 1;
            // 
            // textPassword
            // 
            this.textPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textPassword.BackColor = System.Drawing.SystemColors.Window;
            this.textPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.textPassword.Location = new System.Drawing.Point(244, 119);
            this.textPassword.Name = "textPassword";
            this.textPassword.Size = new System.Drawing.Size(254, 45);
            this.textPassword.TabIndex = 1;
            this.textPassword.UseSystemPasswordChar = true;
            // 
            // buttonAceptar
            // 
            this.buttonAceptar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonAceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.buttonAceptar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAceptar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonAceptar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.buttonAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.buttonAceptar.ForeColor = System.Drawing.Color.Black;
            this.buttonAceptar.Location = new System.Drawing.Point(299, 209);
            this.buttonAceptar.Name = "buttonAceptar";
            this.buttonAceptar.Size = new System.Drawing.Size(134, 37);
            this.buttonAceptar.TabIndex = 2;
            this.buttonAceptar.Text = "Aceptar";
            this.buttonAceptar.UseVisualStyleBackColor = false;
            this.buttonAceptar.Click += new System.EventHandler(this.button1_Click);
            // 
            // user
            // 
            this.user.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.user.AutoSize = true;
            this.user.BackColor = System.Drawing.Color.Black;
            this.user.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.user.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.user.Location = new System.Drawing.Point(26, 34);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(135, 39);
            this.user.TabIndex = 3;
            this.user.Text = "Usuario";
            // 
            // password
            // 
            this.password.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.password.AutoSize = true;
            this.password.BackColor = System.Drawing.Color.Black;
            this.password.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.password.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.password.Location = new System.Drawing.Point(26, 125);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(193, 39);
            this.password.TabIndex = 4;
            this.password.Text = "Contraseña";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(328, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 39);
            this.label1.TabIndex = 5;
            this.label1.Text = "BIENVENIDO";
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.password);
            this.panel1.Controls.Add(this.user);
            this.panel1.Controls.Add(this.buttonAceptar);
            this.panel1.Controls.Add(this.textPassword);
            this.panel1.Controls.Add(this.textName);
            this.panel1.Location = new System.Drawing.Point(153, 165);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(572, 284);
            this.panel1.TabIndex = 6;
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(832, 499);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Name = "FormLogin";
            this.Text = "FormLogin";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.TextBox textPassword;
        private System.Windows.Forms.Button buttonAceptar;
        private System.Windows.Forms.Label user;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
    }
}