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
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void agregarParticipanteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAgregarParticipante oFrmAgregarParticipante = new FrmAgregarParticipante();
            oFrmAgregarParticipante.Show();
        }

        private void agregarDisciplinaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAgregarDisciplina oFrmAgregarDisciplina = new FrmAgregarDisciplina();
            oFrmAgregarDisciplina.Show();
        }

        private void agregarEventoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAgregarCategoria oFrmAgregarCategoria = new FrmAgregarCategoria();
            oFrmAgregarCategoria.Show();
        }

    }
}
