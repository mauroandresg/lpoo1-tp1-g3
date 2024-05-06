namespace Vistas
{
    partial class Inicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio));
            this.menuSup = new System.Windows.Forms.MenuStrip();
            this.MItemCompetencias = new System.Windows.Forms.ToolStripMenuItem();
            this.MItemEventos = new System.Windows.Forms.ToolStripMenuItem();
            this.MItemLugares = new System.Windows.Forms.ToolStripMenuItem();
            this.MItemHistoricos = new System.Windows.Forms.ToolStripMenuItem();
            this.MItemAdmin = new System.Windows.Forms.ToolStripMenuItem();
            this.MItemCategorias = new System.Windows.Forms.ToolStripMenuItem();
            this.MItemCatCrear = new System.Windows.Forms.ToolStripMenuItem();
            this.MItemCatMostrar = new System.Windows.Forms.ToolStripMenuItem();
            this.MItemDisciplinas = new System.Windows.Forms.ToolStripMenuItem();
            this.MItemDisCrear = new System.Windows.Forms.ToolStripMenuItem();
            this.MItemDisMostrar = new System.Windows.Forms.ToolStripMenuItem();
            this.MItemParticipantes = new System.Windows.Forms.ToolStripMenuItem();
            this.MItemPartCrear = new System.Windows.Forms.ToolStripMenuItem();
            this.MItemPartMostrar = new System.Windows.Forms.ToolStripMenuItem();
            this.MItemSistema = new System.Windows.Forms.ToolStripMenuItem();
            this.MItemAcerca = new System.Windows.Forms.ToolStripMenuItem();
            this.MItemSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSup.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuSup
            // 
            this.menuSup.BackColor = System.Drawing.SystemColors.Window;
            this.menuSup.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MItemCompetencias,
            this.MItemAdmin,
            this.MItemSistema});
            this.menuSup.Location = new System.Drawing.Point(0, 0);
            this.menuSup.Name = "menuSup";
            this.menuSup.Size = new System.Drawing.Size(800, 24);
            this.menuSup.TabIndex = 0;
            this.menuSup.Text = "menuSup";
            // 
            // MItemCompetencias
            // 
            this.MItemCompetencias.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MItemEventos,
            this.MItemLugares,
            this.MItemHistoricos});
            this.MItemCompetencias.Name = "MItemCompetencias";
            this.MItemCompetencias.Size = new System.Drawing.Size(95, 20);
            this.MItemCompetencias.Text = "Competencias";
            // 
            // MItemEventos
            // 
            this.MItemEventos.Enabled = false;
            this.MItemEventos.Name = "MItemEventos";
            this.MItemEventos.Size = new System.Drawing.Size(127, 22);
            this.MItemEventos.Text = "Eventos";
            // 
            // MItemLugares
            // 
            this.MItemLugares.Enabled = false;
            this.MItemLugares.Name = "MItemLugares";
            this.MItemLugares.Size = new System.Drawing.Size(127, 22);
            this.MItemLugares.Text = "Lugares";
            // 
            // MItemHistoricos
            // 
            this.MItemHistoricos.Enabled = false;
            this.MItemHistoricos.Name = "MItemHistoricos";
            this.MItemHistoricos.Size = new System.Drawing.Size(127, 22);
            this.MItemHistoricos.Text = "Historicos";
            // 
            // MItemAdmin
            // 
            this.MItemAdmin.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MItemCategorias,
            this.MItemDisciplinas,
            this.MItemParticipantes});
            this.MItemAdmin.Name = "MItemAdmin";
            this.MItemAdmin.Size = new System.Drawing.Size(100, 20);
            this.MItemAdmin.Text = "Administración";
            // 
            // MItemCategorias
            // 
            this.MItemCategorias.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MItemCatCrear,
            this.MItemCatMostrar});
            this.MItemCategorias.Name = "MItemCategorias";
            this.MItemCategorias.Size = new System.Drawing.Size(180, 22);
            this.MItemCategorias.Text = "Categorias";
            // 
            // MItemCatCrear
            // 
            this.MItemCatCrear.Name = "MItemCatCrear";
            this.MItemCatCrear.Size = new System.Drawing.Size(180, 22);
            this.MItemCatCrear.Text = "Crear";
            this.MItemCatCrear.Click += new System.EventHandler(this.MItemCatCrear_Click);
            // 
            // MItemCatMostrar
            // 
            this.MItemCatMostrar.Name = "MItemCatMostrar";
            this.MItemCatMostrar.Size = new System.Drawing.Size(180, 22);
            this.MItemCatMostrar.Text = "Mostrar";
            this.MItemCatMostrar.Click += new System.EventHandler(this.MItemCatMostrar_Click);
            // 
            // MItemDisciplinas
            // 
            this.MItemDisciplinas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MItemDisCrear,
            this.MItemDisMostrar});
            this.MItemDisciplinas.Name = "MItemDisciplinas";
            this.MItemDisciplinas.Size = new System.Drawing.Size(180, 22);
            this.MItemDisciplinas.Text = "Disciplinas";
            // 
            // MItemDisCrear
            // 
            this.MItemDisCrear.Name = "MItemDisCrear";
            this.MItemDisCrear.Size = new System.Drawing.Size(180, 22);
            this.MItemDisCrear.Text = "Crear";
            this.MItemDisCrear.Click += new System.EventHandler(this.MItemDisCrear_Click);
            // 
            // MItemDisMostrar
            // 
            this.MItemDisMostrar.Name = "MItemDisMostrar";
            this.MItemDisMostrar.Size = new System.Drawing.Size(180, 22);
            this.MItemDisMostrar.Text = "Mostrar";
            this.MItemDisMostrar.Click += new System.EventHandler(this.MItemDisMostrar_Click);
            // 
            // MItemParticipantes
            // 
            this.MItemParticipantes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MItemPartCrear,
            this.MItemPartMostrar});
            this.MItemParticipantes.Name = "MItemParticipantes";
            this.MItemParticipantes.Size = new System.Drawing.Size(180, 22);
            this.MItemParticipantes.Text = "Participantes";
            // 
            // MItemPartCrear
            // 
            this.MItemPartCrear.Name = "MItemPartCrear";
            this.MItemPartCrear.Size = new System.Drawing.Size(180, 22);
            this.MItemPartCrear.Text = "Crear";
            this.MItemPartCrear.Click += new System.EventHandler(this.MItemPartCrear_Click);
            // 
            // MItemPartMostrar
            // 
            this.MItemPartMostrar.Name = "MItemPartMostrar";
            this.MItemPartMostrar.Size = new System.Drawing.Size(180, 22);
            this.MItemPartMostrar.Text = "Mostrar";
            this.MItemPartMostrar.Click += new System.EventHandler(this.MItemPartMostrar_Click);
            // 
            // MItemSistema
            // 
            this.MItemSistema.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MItemAcerca,
            this.MItemSalir});
            this.MItemSistema.Name = "MItemSistema";
            this.MItemSistema.Size = new System.Drawing.Size(60, 20);
            this.MItemSistema.Text = "Sistema";
            // 
            // MItemAcerca
            // 
            this.MItemAcerca.Image = global::Vistas.Properties.Resources.information;
            this.MItemAcerca.Name = "MItemAcerca";
            this.MItemAcerca.Size = new System.Drawing.Size(185, 22);
            this.MItemAcerca.Text = "Acerca de Sport Flow";
            this.MItemAcerca.Click += new System.EventHandler(this.MItemAcerca_Click);
            // 
            // MItemSalir
            // 
            this.MItemSalir.Image = global::Vistas.Properties.Resources.logout;
            this.MItemSalir.Name = "MItemSalir";
            this.MItemSalir.Size = new System.Drawing.Size(185, 22);
            this.MItemSalir.Text = "Salir";
            this.MItemSalir.Click += new System.EventHandler(this.MItemSalir_Click);
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuSup);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuSup;
            this.Name = "Inicio";
            this.Text = "Inicio";
            this.menuSup.ResumeLayout(false);
            this.menuSup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuSup;
        private System.Windows.Forms.ToolStripMenuItem MItemSistema;
        private System.Windows.Forms.ToolStripMenuItem MItemCompetencias;
        private System.Windows.Forms.ToolStripMenuItem MItemAcerca;
        private System.Windows.Forms.ToolStripMenuItem MItemEventos;
        private System.Windows.Forms.ToolStripMenuItem MItemLugares;
        private System.Windows.Forms.ToolStripMenuItem MItemHistoricos;
        private System.Windows.Forms.ToolStripMenuItem MItemAdmin;
        private System.Windows.Forms.ToolStripMenuItem MItemCategorias;
        private System.Windows.Forms.ToolStripMenuItem MItemCatCrear;
        private System.Windows.Forms.ToolStripMenuItem MItemCatMostrar;
        private System.Windows.Forms.ToolStripMenuItem MItemDisciplinas;
        private System.Windows.Forms.ToolStripMenuItem MItemDisCrear;
        private System.Windows.Forms.ToolStripMenuItem MItemDisMostrar;
        private System.Windows.Forms.ToolStripMenuItem MItemParticipantes;
        private System.Windows.Forms.ToolStripMenuItem MItemPartCrear;
        private System.Windows.Forms.ToolStripMenuItem MItemPartMostrar;
        private System.Windows.Forms.ToolStripMenuItem MItemSalir;
    }
}