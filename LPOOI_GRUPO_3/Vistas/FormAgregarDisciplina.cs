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
    public partial class FormAgregarDisciplina : Form
    {
        public FormAgregarDisciplina()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Disciplina NuevaDisciplina = new Disciplina();

            NuevaDisciplina.Dis_Nombre = DiscNombre.Text;
            NuevaDisciplina.Dis_Descripcion = DiscDescripcion.Text;

            MessageBox.Show("Disciplina: " + NuevaDisciplina.Dis_Nombre + "\n" +
                            "Descripcion: " + NuevaDisciplina.Dis_Descripcion + "\n" +
                            "Agregada correctamente");

        }
    }
}
