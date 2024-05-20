using ClasesBase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Vistas
{
    public partial class FrmInicio : Form
    {
        public int CodigoRol { get; set; }

        public FrmInicio()
        {
            InitializeComponent();
        }

        private void FrmInicio_Load(object sender, EventArgs e)
        {
            foreach (ToolStripItem item in MItemGestionar.DropDownItems)
            {
                item.Enabled = false;
            }
            AdministrarAcceso();
        }

        private void AdministrarAcceso()
        {
            switch (CodigoRol)
            {
                case 1: // Administrador
                    MItemGesUsuario.Enabled = true;
                    break;
                case 2: // Operador
                    MItemGesAtleta.Enabled = true;
                    MItemGesCompeticion.Enabled = true;
                    break;
                case 3: // Auditor
                    foreach (ToolStripItem item in MItemGestionar.DropDownItems)
                    {
                        item.Enabled = true;
                    }
                    break;
                default:
                    break;
            }
        }

        private void MItemAcerca_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sport Flow - version 0.2 \nDesarrollado por grupo LPOO1-G3");
        }

        private void MItemSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MItemGesCategoria_Click(object sender, EventArgs e)
        {
            FrmAltaCategoria frmCategoria = new FrmAltaCategoria();
            frmCategoria.Show();
        }

        private void MItemGesDisciplina_Click(object sender, EventArgs e)
        {
            FrmAltaDisciplina frmDisciplina = new FrmAltaDisciplina();
            frmDisciplina.Show();
        }

        private void MItemGesAtleta_Click(object sender, EventArgs e)
        {
            FrmAltaParticipante frmParticipante = new FrmAltaParticipante();
            frmParticipante.Show();
        }
    }
}
