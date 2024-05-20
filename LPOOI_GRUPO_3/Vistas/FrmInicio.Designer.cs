namespace Vistas
{
    partial class FrmInicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInicio));
            this.MenuSup = new System.Windows.Forms.MenuStrip();
            this.MItemGestionar = new System.Windows.Forms.ToolStripMenuItem();
            this.MItemGesCategoria = new System.Windows.Forms.ToolStripMenuItem();
            this.MItemGesAtleta = new System.Windows.Forms.ToolStripMenuItem();
            this.MItemSistema = new System.Windows.Forms.ToolStripMenuItem();
            this.MItemSisAcerca = new System.Windows.Forms.ToolStripMenuItem();
            this.MItemSisSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.MItemGesDisciplina = new System.Windows.Forms.ToolStripMenuItem();
            this.MItemGesUsuario = new System.Windows.Forms.ToolStripMenuItem();
            this.MItemGesCompeticion = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuSup.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuSup
            // 
            this.MenuSup.BackColor = System.Drawing.SystemColors.Window;
            this.MenuSup.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MItemGestionar,
            this.MItemSistema});
            this.MenuSup.Location = new System.Drawing.Point(0, 0);
            this.MenuSup.Name = "MenuSup";
            this.MenuSup.Size = new System.Drawing.Size(800, 24);
            this.MenuSup.TabIndex = 0;
            this.MenuSup.Text = "MenuSup";
            // 
            // MItemGestionar
            // 
            this.MItemGestionar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MItemGesCategoria,
            this.MItemGesDisciplina,
            this.MItemGesAtleta,
            this.MItemGesCompeticion,
            this.MItemGesUsuario});
            this.MItemGestionar.Name = "MItemGestionar";
            this.MItemGestionar.Size = new System.Drawing.Size(102, 20);
            this.MItemGestionar.Text = "Gestionar Datos";
            // 
            // MItemGesCategoria
            // 
            this.MItemGesCategoria.Name = "MItemGesCategoria";
            this.MItemGesCategoria.Size = new System.Drawing.Size(180, 22);
            this.MItemGesCategoria.Text = "Categorias";
            this.MItemGesCategoria.Click += new System.EventHandler(this.MItemGesCategoria_Click);
            // 
            // MItemGesAtleta
            // 
            this.MItemGesAtleta.Name = "MItemGesAtleta";
            this.MItemGesAtleta.Size = new System.Drawing.Size(180, 22);
            this.MItemGesAtleta.Text = "Atletas";
            this.MItemGesAtleta.Click += new System.EventHandler(this.MItemGesAtleta_Click);
            // 
            // MItemSistema
            // 
            this.MItemSistema.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MItemSisAcerca,
            this.MItemSisSalir});
            this.MItemSistema.Name = "MItemSistema";
            this.MItemSistema.Size = new System.Drawing.Size(60, 20);
            this.MItemSistema.Text = "Sistema";
            // 
            // MItemSisAcerca
            // 
            this.MItemSisAcerca.Image = global::Vistas.Properties.Resources.information;
            this.MItemSisAcerca.Name = "MItemSisAcerca";
            this.MItemSisAcerca.Size = new System.Drawing.Size(185, 22);
            this.MItemSisAcerca.Text = "Acerca de Sport Flow";
            this.MItemSisAcerca.Click += new System.EventHandler(this.MItemAcerca_Click);
            // 
            // MItemSisSalir
            // 
            this.MItemSisSalir.Image = global::Vistas.Properties.Resources.logout;
            this.MItemSisSalir.Name = "MItemSisSalir";
            this.MItemSisSalir.Size = new System.Drawing.Size(185, 22);
            this.MItemSisSalir.Text = "Salir";
            this.MItemSisSalir.Click += new System.EventHandler(this.MItemSalir_Click);
            // 
            // MItemGesDisciplina
            // 
            this.MItemGesDisciplina.Name = "MItemGesDisciplina";
            this.MItemGesDisciplina.Size = new System.Drawing.Size(180, 22);
            this.MItemGesDisciplina.Text = "Disciplinas";
            this.MItemGesDisciplina.Click += new System.EventHandler(this.MItemGesDisciplina_Click);
            // 
            // MItemGesUsuario
            // 
            this.MItemGesUsuario.Name = "MItemGesUsuario";
            this.MItemGesUsuario.Size = new System.Drawing.Size(180, 22);
            this.MItemGesUsuario.Text = "Usuarios";
            // 
            // MItemGesCompeticion
            // 
            this.MItemGesCompeticion.Name = "MItemGesCompeticion";
            this.MItemGesCompeticion.Size = new System.Drawing.Size(180, 22);
            this.MItemGesCompeticion.Text = "Competiciones";
            // 
            // FrmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MenuSup);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MenuSup;
            this.Name = "FrmInicio";
            this.Text = "Inicio";
            this.Load += new System.EventHandler(this.FrmInicio_Load);
            this.MenuSup.ResumeLayout(false);
            this.MenuSup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MenuSup;
        private System.Windows.Forms.ToolStripMenuItem MItemSistema;
        private System.Windows.Forms.ToolStripMenuItem MItemSisAcerca;
        private System.Windows.Forms.ToolStripMenuItem MItemGestionar;
        private System.Windows.Forms.ToolStripMenuItem MItemGesCategoria;
        private System.Windows.Forms.ToolStripMenuItem MItemGesAtleta;
        private System.Windows.Forms.ToolStripMenuItem MItemSisSalir;
        private System.Windows.Forms.ToolStripMenuItem MItemGesDisciplina;
        private System.Windows.Forms.ToolStripMenuItem MItemGesCompeticion;
        private System.Windows.Forms.ToolStripMenuItem MItemGesUsuario;
    }
}