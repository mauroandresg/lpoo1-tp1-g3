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
    public partial class FrmAltaDisciplina : Form
    {
        Disciplina oDisciplina = new Disciplina();

        public FrmAltaDisciplina()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (CamposCompletos()==true)
            {
                // Implementar la carga de datos en BD
            }
            else
            {
                MessageBox.Show("Complete todos los campos!", "Faltan datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool CamposCompletos()
        {
            if (string.IsNullOrEmpty(txtNombre.Text) || string.IsNullOrEmpty(txtDescripcion.Text))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
