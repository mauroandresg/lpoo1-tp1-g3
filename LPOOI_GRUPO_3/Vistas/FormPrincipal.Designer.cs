namespace Vistas
{
    partial class FormPrincipal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cAgregar = new System.Windows.Forms.ToolStripMenuItem();
            this.atletasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.categoriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.disciplinaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.sISTEMAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearToolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.crearRolToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearToolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.sALIRToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cAgregar,
            this.sISTEMAToolStripMenuItem,
            this.sALIRToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(644, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cAgregar
            // 
            this.cAgregar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.atletasToolStripMenuItem,
            this.categoriaToolStripMenuItem,
            this.disciplinaToolStripMenuItem});
            this.cAgregar.Name = "cAgregar";
            this.cAgregar.Size = new System.Drawing.Size(152, 20);
            this.cAgregar.Text = "             AGREGAR              ";
            // 
            // atletasToolStripMenuItem
            // 
            this.atletasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crearToolStripMenuItem1});
            this.atletasToolStripMenuItem.Name = "atletasToolStripMenuItem";
            this.atletasToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.atletasToolStripMenuItem.Text = "Atletas";
            // 
            // crearToolStripMenuItem1
            // 
            this.crearToolStripMenuItem1.Name = "crearToolStripMenuItem1";
            this.crearToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.crearToolStripMenuItem1.Text = "Crear";
            this.crearToolStripMenuItem1.Click += new System.EventHandler(this.crearToolStripMenuItem1_Click);
            // 
            // categoriaToolStripMenuItem
            // 
            this.categoriaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crearToolStripMenuItem2});
            this.categoriaToolStripMenuItem.Name = "categoriaToolStripMenuItem";
            this.categoriaToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.categoriaToolStripMenuItem.Text = "Categoria";
            // 
            // crearToolStripMenuItem2
            // 
            this.crearToolStripMenuItem2.Name = "crearToolStripMenuItem2";
            this.crearToolStripMenuItem2.Size = new System.Drawing.Size(102, 22);
            this.crearToolStripMenuItem2.Text = "Crear";
            this.crearToolStripMenuItem2.Click += new System.EventHandler(this.crearToolStripMenuItem2_Click);
            // 
            // disciplinaToolStripMenuItem
            // 
            this.disciplinaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crearToolStripMenuItem3});
            this.disciplinaToolStripMenuItem.Name = "disciplinaToolStripMenuItem";
            this.disciplinaToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.disciplinaToolStripMenuItem.Text = "Disciplina";
            // 
            // crearToolStripMenuItem3
            // 
            this.crearToolStripMenuItem3.Name = "crearToolStripMenuItem3";
            this.crearToolStripMenuItem3.Size = new System.Drawing.Size(102, 22);
            this.crearToolStripMenuItem3.Text = "Crear";
            this.crearToolStripMenuItem3.Click += new System.EventHandler(this.crearToolStripMenuItem3_Click);
            // 
            // sISTEMAToolStripMenuItem
            // 
            this.sISTEMAToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarUsuarioToolStripMenuItem,
            this.crearRolToolStripMenuItem});
            this.sISTEMAToolStripMenuItem.Name = "sISTEMAToolStripMenuItem";
            this.sISTEMAToolStripMenuItem.Size = new System.Drawing.Size(159, 20);
            this.sISTEMAToolStripMenuItem.Text = "       ADMINISTRACION       ";
            // 
            // agregarUsuarioToolStripMenuItem
            // 
            this.agregarUsuarioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crearToolStripMenuItem4,
            this.modificarToolStripMenuItem,
            this.eliminarToolStripMenuItem3});
            this.agregarUsuarioToolStripMenuItem.Name = "agregarUsuarioToolStripMenuItem";
            this.agregarUsuarioToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.agregarUsuarioToolStripMenuItem.Text = "Agregar usuario";
            // 
            // crearToolStripMenuItem4
            // 
            this.crearToolStripMenuItem4.Name = "crearToolStripMenuItem4";
            this.crearToolStripMenuItem4.Size = new System.Drawing.Size(152, 22);
            this.crearToolStripMenuItem4.Text = "Crear";
            this.crearToolStripMenuItem4.Click += new System.EventHandler(this.crearToolStripMenuItem4_Click);
            // 
            // modificarToolStripMenuItem
            // 
            this.modificarToolStripMenuItem.Name = "modificarToolStripMenuItem";
            this.modificarToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.modificarToolStripMenuItem.Text = "Modificar";
            // 
            // eliminarToolStripMenuItem3
            // 
            this.eliminarToolStripMenuItem3.Name = "eliminarToolStripMenuItem3";
            this.eliminarToolStripMenuItem3.Size = new System.Drawing.Size(152, 22);
            this.eliminarToolStripMenuItem3.Text = "Eliminar";
            // 
            // crearRolToolStripMenuItem
            // 
            this.crearRolToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crearToolStripMenuItem5,
            this.eliminarToolStripMenuItem4});
            this.crearRolToolStripMenuItem.Image = global::Vistas.Properties.Resources.candado;
            this.crearRolToolStripMenuItem.Name = "crearRolToolStripMenuItem";
            this.crearRolToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.crearRolToolStripMenuItem.Text = "Crear Rol";
            // 
            // crearToolStripMenuItem5
            // 
            this.crearToolStripMenuItem5.Name = "crearToolStripMenuItem5";
            this.crearToolStripMenuItem5.Size = new System.Drawing.Size(117, 22);
            this.crearToolStripMenuItem5.Text = "Crear";
            // 
            // eliminarToolStripMenuItem4
            // 
            this.eliminarToolStripMenuItem4.Name = "eliminarToolStripMenuItem4";
            this.eliminarToolStripMenuItem4.Size = new System.Drawing.Size(117, 22);
            this.eliminarToolStripMenuItem4.Text = "Eliminar";
            // 
            // sALIRToolStripMenuItem
            // 
            this.sALIRToolStripMenuItem.Name = "sALIRToolStripMenuItem";
            this.sALIRToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.sALIRToolStripMenuItem.Text = "SALIR";
            this.sALIRToolStripMenuItem.Click += new System.EventHandler(this.sALIRToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(644, 357);
            this.panel1.TabIndex = 1;
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 381);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormPrincipal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sISTEMAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sALIRToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cAgregar;
        private System.Windows.Forms.ToolStripMenuItem atletasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crearToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem categoriaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crearToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem disciplinaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crearToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem agregarUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crearToolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem crearRolToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crearToolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem modificarToolStripMenuItem;
    }
}