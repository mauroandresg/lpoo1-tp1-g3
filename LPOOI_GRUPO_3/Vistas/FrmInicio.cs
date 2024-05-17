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
        public FrmInicio()
        {
            InitializeComponent();
        }

        private void MItemAcerca_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sport Flow - version 0.1 \nDesarrollado por grupo LPOO1-G3");
        }

        private void MItemSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MItemCatCrear_Click(object sender, EventArgs e)
        {
            FrmAltaCategoria frmCategoria = new FrmAltaCategoria();
            frmCategoria.Show();
        }

        private void MItemDisCrear_Click(object sender, EventArgs e)
        {
            FrmAltaDisciplina frmDisciplina = new FrmAltaDisciplina();
            frmDisciplina.Show();
        }

        private void MItemPartCrear_Click(object sender, EventArgs e)
        {
            FrmAltaParticipante frmParticipante = new FrmAltaParticipante();
            frmParticipante.Show();
        }

        private void MItemCatMostrar_Click(object sender, EventArgs e)
        {
            // Implementar usando la BD
        }

        private void MItemDisMostrar_Click(object sender, EventArgs e)
        {
            // Implementar usando la BD
        }

        private void MItemPartMostrar_Click(object sender, EventArgs e)
        {
            // Implementar usando la BD
        }
    }
}
