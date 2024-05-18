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
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void sistemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login oLogin = new Login();
            oLogin.Show();
            this.Close();
        }

        private void competenciasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAgregarDisciplina oFormAgregarDisciplina = new FormAgregarDisciplina();
            oFormAgregarDisciplina.Show();
            MessageBox.Show("Competencias seleccionadas");
        }

        private void participantesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAgregarParticipante oFormAgregarParticipante = new FormAgregarParticipante();
            oFormAgregarParticipante.Show();
            MessageBox.Show("Participantes seleccionados");
        }

        private void eventosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAgregarCategoria oFormAgregarCategoria = new FormAgregarCategoria();
            oFormAgregarCategoria.Show();
            MessageBox.Show("Eventos seleccionados");
        }
    }
}
