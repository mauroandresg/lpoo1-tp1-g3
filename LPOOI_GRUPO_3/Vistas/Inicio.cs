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
    public partial class Inicio : Form
    {
        Categoria cat = new Categoria();
        Disciplina dis = new Disciplina();
        Atleta atl = new Atleta();

        public Inicio()
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
            Formulario frmFormulario = new Formulario();
            frmFormulario.TituloTxt = "Nueva Categoria";
            frmFormulario.TipoFormulario = TipoForm.CATEGORIA;
            frmFormulario.Show();

            if (frmFormulario.NuevaEntidadCreada == true)
            {
                cat = frmFormulario.NuevaCat;
            }
        }

        private void MItemDisCrear_Click(object sender, EventArgs e)
        {
            Formulario frmFormulario = new Formulario();
            frmFormulario.TituloTxt = "Nueva Disciplina";
            frmFormulario.TipoFormulario = TipoForm.DISCIPLINA;
            frmFormulario.Show();

            if (frmFormulario.NuevaEntidadCreada == true)
            {
                dis = frmFormulario.NuevaDis;
            }
        }

        private void MItemPartCrear_Click(object sender, EventArgs e)
        {
            Formulario frmFormulario = new Formulario();
            frmFormulario.TipoFormulario = TipoForm.ATLETA;
            frmFormulario.TituloTxt = "Nuevo Atleta";
            frmFormulario.Show();

            if (frmFormulario.NuevaEntidadCreada == true)
            {
                atl = frmFormulario.NuevoAtl;
            }
        }
    }
}
