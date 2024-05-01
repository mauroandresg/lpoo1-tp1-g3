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
    public partial class Login : Form
    {
        bool usr_valido = false;
        bool contra_valido = false;
        public Login()
        {
            InitializeComponent();
        }

        private void BtnIngresar_Click(object sender, EventArgs e)
        {
            if (usr_valido && contra_valido)
            {
                // Autenticación de credenciales
                MessageBox.Show("Ingresando");
            } else
            {
                MessageBox.Show("Ingrese sus crendenciales", "Faltan datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TxtUsuario_Validated(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtUsuario.Text))
            {
                usr_valido = false;
                errorProvider.SetError(this.TxtUsuario, "Ingrese un nombre de usuario");
            } else
            {
                usr_valido = true;
                errorProvider.SetError(this.TxtUsuario, string.Empty);
            }
        }

        private void TxtContra_Validated(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtContra.Text))
            {
                contra_valido = false;
                errorProvider.SetError(this.TxtContra, "Ingrese una contraseña");
            }
            else
            {
                contra_valido = true;
                errorProvider.SetError(this.TxtContra, string.Empty);
            }
        }
    }
}
