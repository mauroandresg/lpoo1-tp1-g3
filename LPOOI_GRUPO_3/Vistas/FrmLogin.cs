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
    public partial class FrmLogin : Form
    {
        public bool AutenticacionRealizada { get; private set; } // Propiedad: resultado de autenticación

        bool usuarioValido = false;
        bool contraValida = false;

        public FrmLogin()
        {
            InitializeComponent();
            this.AutenticacionRealizada = false; // Se obliga a realizar la autenticacion al iniciar el form
        }

        private void BtnIngresar_Click(object sender, EventArgs e)
        {
            if (usuarioValido && contraValida)
            {
                // Implementar validacion usando la BD
            } else
            {
                ValidarUsuario();
                ValidarContrasenia();
                MessageBox.Show("Ingrese sus crendenciales", "Faltan datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TxtUsuario_Validating(object sender, CancelEventArgs e)
        {
            ValidarUsuario();
        }

        private void TxtContra_Validating(object sender, CancelEventArgs e)
        {
            ValidarContrasenia();
        }

        private void ValidarUsuario()
        {
            if (string.IsNullOrEmpty(TxtUsuario.Text))
            {
                usuarioValido = false;
                errorProvider.SetError(this.TxtUsuario, "Ingrese un nombre de usuario");
            }
            else
            {
                usuarioValido = true;
                errorProvider.SetError(this.TxtUsuario, string.Empty);
            }
        }

        private void ValidarContrasenia()
        {
            if (string.IsNullOrEmpty(TxtContra.Text))
            {
                contraValida = false;
                errorProvider.SetError(this.TxtContra, "Ingrese una contraseña");
            }
            else
            {
                contraValida = true;
                errorProvider.SetError(this.TxtContra, string.Empty);
            }
        }


        /// ELIMINAR EN ENTREGA ///
        private void Login_DoubleClick(object sender, EventArgs e)
        {   // Saltar autenticación solo para acelarar la etapa de desarrollo
            MessageBox.Show("Saltando autenticación...", "Interno", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            this.AutenticacionRealizada = true;
            this.Close();
        }
        ///////////////////////////
    }
}
