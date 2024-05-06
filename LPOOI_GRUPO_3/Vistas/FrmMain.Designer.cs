namespace Vistas
{
    partial class FrmMain
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
            this.sistemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.competenciasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.participantesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eventosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eventosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarParticipanteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mostrarParticipanteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarDisciplinaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mostrarDisciplinaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarCompetenciaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mostrarCompetenciaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarEventoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mostrarEventoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eventoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarEventoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mostrarEventoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sistemaToolStripMenuItem,
            this.competenciasToolStripMenuItem,
            this.participantesToolStripMenuItem,
            this.eventosToolStripMenuItem,
            this.eventosToolStripMenuItem1,
            this.eventoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(849, 36);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // sistemaToolStripMenuItem
            // 
            this.sistemaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem});
            this.sistemaToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sistemaToolStripMenuItem.Name = "sistemaToolStripMenuItem";
            this.sistemaToolStripMenuItem.Size = new System.Drawing.Size(92, 32);
            this.sistemaToolStripMenuItem.Text = "Sistema";
            // 
            // competenciasToolStripMenuItem
            // 
            this.competenciasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarCompetenciaToolStripMenuItem,
            this.mostrarCompetenciaToolStripMenuItem});
            this.competenciasToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.competenciasToolStripMenuItem.Name = "competenciasToolStripMenuItem";
            this.competenciasToolStripMenuItem.Size = new System.Drawing.Size(147, 32);
            this.competenciasToolStripMenuItem.Text = "Competencias";
            // 
            // participantesToolStripMenuItem
            // 
            this.participantesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarParticipanteToolStripMenuItem,
            this.mostrarParticipanteToolStripMenuItem});
            this.participantesToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.participantesToolStripMenuItem.Name = "participantesToolStripMenuItem";
            this.participantesToolStripMenuItem.Size = new System.Drawing.Size(135, 32);
            this.participantesToolStripMenuItem.Text = "Participantes";
            // 
            // eventosToolStripMenuItem
            // 
            this.eventosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarDisciplinaToolStripMenuItem,
            this.mostrarDisciplinaToolStripMenuItem});
            this.eventosToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eventosToolStripMenuItem.Name = "eventosToolStripMenuItem";
            this.eventosToolStripMenuItem.Size = new System.Drawing.Size(108, 32);
            this.eventosToolStripMenuItem.Text = "Disciplina";
            // 
            // eventosToolStripMenuItem1
            // 
            this.eventosToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarEventoToolStripMenuItem,
            this.mostrarEventoToolStripMenuItem});
            this.eventosToolStripMenuItem1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eventosToolStripMenuItem1.Name = "eventosToolStripMenuItem1";
            this.eventosToolStripMenuItem1.Size = new System.Drawing.Size(109, 32);
            this.eventosToolStripMenuItem1.Text = "Categoria";
            this.eventosToolStripMenuItem1.Click += new System.EventHandler(this.eventosToolStripMenuItem1_Click);
            // 
            // agregarParticipanteToolStripMenuItem
            // 
            this.agregarParticipanteToolStripMenuItem.Name = "agregarParticipanteToolStripMenuItem";
            this.agregarParticipanteToolStripMenuItem.Size = new System.Drawing.Size(214, 24);
            this.agregarParticipanteToolStripMenuItem.Text = "Agregar Participante";
            // 
            // mostrarParticipanteToolStripMenuItem
            // 
            this.mostrarParticipanteToolStripMenuItem.Name = "mostrarParticipanteToolStripMenuItem";
            this.mostrarParticipanteToolStripMenuItem.Size = new System.Drawing.Size(214, 24);
            this.mostrarParticipanteToolStripMenuItem.Text = "Mostrar Participante";
            // 
            // agregarDisciplinaToolStripMenuItem
            // 
            this.agregarDisciplinaToolStripMenuItem.Name = "agregarDisciplinaToolStripMenuItem";
            this.agregarDisciplinaToolStripMenuItem.Size = new System.Drawing.Size(201, 24);
            this.agregarDisciplinaToolStripMenuItem.Text = "Agregar Disciplina";
            // 
            // mostrarDisciplinaToolStripMenuItem
            // 
            this.mostrarDisciplinaToolStripMenuItem.Name = "mostrarDisciplinaToolStripMenuItem";
            this.mostrarDisciplinaToolStripMenuItem.Size = new System.Drawing.Size(201, 24);
            this.mostrarDisciplinaToolStripMenuItem.Text = "Mostrar Disciplina";
            // 
            // agregarCompetenciaToolStripMenuItem
            // 
            this.agregarCompetenciaToolStripMenuItem.Name = "agregarCompetenciaToolStripMenuItem";
            this.agregarCompetenciaToolStripMenuItem.Size = new System.Drawing.Size(224, 24);
            this.agregarCompetenciaToolStripMenuItem.Text = "Agregar Competencia";
            // 
            // mostrarCompetenciaToolStripMenuItem
            // 
            this.mostrarCompetenciaToolStripMenuItem.Name = "mostrarCompetenciaToolStripMenuItem";
            this.mostrarCompetenciaToolStripMenuItem.Size = new System.Drawing.Size(224, 24);
            this.mostrarCompetenciaToolStripMenuItem.Text = "Mostrar Competencia";
            // 
            // agregarEventoToolStripMenuItem
            // 
            this.agregarEventoToolStripMenuItem.Name = "agregarEventoToolStripMenuItem";
            this.agregarEventoToolStripMenuItem.Size = new System.Drawing.Size(245, 32);
            this.agregarEventoToolStripMenuItem.Text = "Agregar Categoria";
            // 
            // mostrarEventoToolStripMenuItem
            // 
            this.mostrarEventoToolStripMenuItem.Name = "mostrarEventoToolStripMenuItem";
            this.mostrarEventoToolStripMenuItem.Size = new System.Drawing.Size(245, 32);
            this.mostrarEventoToolStripMenuItem.Text = "Mostrar Categoria";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(152, 32);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // eventoToolStripMenuItem
            // 
            this.eventoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarEventoToolStripMenuItem1,
            this.mostrarEventoToolStripMenuItem1});
            this.eventoToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eventoToolStripMenuItem.Name = "eventoToolStripMenuItem";
            this.eventoToolStripMenuItem.Size = new System.Drawing.Size(84, 32);
            this.eventoToolStripMenuItem.Text = "Evento";
            // 
            // agregarEventoToolStripMenuItem1
            // 
            this.agregarEventoToolStripMenuItem1.Name = "agregarEventoToolStripMenuItem1";
            this.agregarEventoToolStripMenuItem1.Size = new System.Drawing.Size(220, 32);
            this.agregarEventoToolStripMenuItem1.Text = "Agregar Evento";
            // 
            // mostrarEventoToolStripMenuItem1
            // 
            this.mostrarEventoToolStripMenuItem1.Name = "mostrarEventoToolStripMenuItem1";
            this.mostrarEventoToolStripMenuItem1.Size = new System.Drawing.Size(220, 32);
            this.mostrarEventoToolStripMenuItem1.Text = "Mostrar Evento";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkKhaki;
            this.ClientSize = new System.Drawing.Size(849, 494);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Sistema de competencias deportivas";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sistemaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem competenciasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarCompetenciaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mostrarCompetenciaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem participantesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarParticipanteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mostrarParticipanteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eventosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarDisciplinaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mostrarDisciplinaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eventosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem agregarEventoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mostrarEventoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eventoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarEventoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mostrarEventoToolStripMenuItem1;

    }
}