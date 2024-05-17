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
    public partial class FrmAltaParticipante : Form
    {
        Atleta oAtleta = new Atleta();

        public FrmAltaParticipante()
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
            if (string.IsNullOrEmpty(txtDni.Text)
                || string.IsNullOrEmpty(txtApellido.Text)
                || string.IsNullOrEmpty(txtNacionalidad.Text)
                || string.IsNullOrEmpty(txtNacionalidad.Text)
                || string.IsNullOrEmpty(txtEntrenador.Text)
                || string.IsNullOrEmpty(txtGenero.Text)
                || string.IsNullOrEmpty(txtDireccion.Text)
                || string.IsNullOrEmpty(txtEmail.Text)
                || (numAltura.Value <= 0) || (numPeso.Value <= 0))
            {
                return false;
            } else
            {
                return true;
            }
        }
    }
}
