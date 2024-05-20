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
    public partial class FrmAtleta : Form
    {
        Atleta oAtleta = new Atleta();

        public FrmAtleta()
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
            if (string.IsNullOrEmpty(TxtDni.Text)
                || string.IsNullOrEmpty(TxtApellido.Text)
                || string.IsNullOrEmpty(TxtNacionalidad.Text)
                || string.IsNullOrEmpty(TxtNacionalidad.Text)
                || string.IsNullOrEmpty(TxtEntrenador.Text)
                || string.IsNullOrEmpty(TxtGenero.Text)
                || string.IsNullOrEmpty(TxtDireccion.Text)
                || string.IsNullOrEmpty(TxtEmail.Text)
                || (NumAltura.Value <= 0) || (NumPeso.Value <= 0))
            {
                return false;
            } else
            {
                return true;
            }
        }
    }
}
