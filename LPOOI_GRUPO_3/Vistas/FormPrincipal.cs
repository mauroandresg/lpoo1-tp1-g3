using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ClasesBase;

namespace Vistas
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void sALIRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void crearToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormAtleta f = new FormAtleta();
            addForm(f);
        }
        public void addForm(Form f)
        {
            if (this.panel1.Controls.Count > 0)
            {
                this.panel1.Controls.RemoveAt(0);
            }

            f.TopLevel = false;
            this.panel1.Controls.Add(f);
            f.Dock = DockStyle.Fill;
            f.Show();

        }

        private void crearToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FormCateg f = new FormCateg();
            addForm(f);
        }

        private void verTodosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<Atleta> listaAtleta = Atleta.ObtenerListaAtleta();

            foreach (Atleta atleta in listaAtleta)
            {
                listaAtleta.ToString();
            }
        }

    }
}
