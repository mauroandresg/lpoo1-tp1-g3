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
    public partial class FrmAgregarDisciplina : Form
    {
        public FrmAgregarDisciplina()
        {
            InitializeComponent();
        }

        private void btnGuardarDisciplina_Click(object sender, EventArgs e)
        {
            Disciplina oDisciplinaNueva = new Disciplina();

            oDisciplinaNueva.Dis_Nombre = txtNombreNuevaDisciplina.Text;
            oDisciplinaNueva.Dis_Descripcion = txtDescripcionNuevaDisciplina.Text;

            MessageBox.Show("Nombre: " + oDisciplinaNueva.Dis_Nombre + "\n" + "Descipcion: " + oDisciplinaNueva.Dis_Descripcion, "NUEVA DISCIPLINA");

        }
    }
}
