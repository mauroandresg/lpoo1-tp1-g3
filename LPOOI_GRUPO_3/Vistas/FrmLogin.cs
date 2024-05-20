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
        public int CodigoRol { get; private set; } // Propiedad: Codigo de Rol del usurio autenticado

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
                if (TrabajarUsuario.Autenticar(TxtUsuario.Text, TxtContra.Text)==true)
                {
                    DataRow dr = TrabajarUsuario.Buscar(TxtUsuario.Text, TxtContra.Text);
                    Usuario u = TrabajarUsuario.ToUsuario(dr);
                    string mensaje = "Bienvenido "+u.Usu_ApellidoNombre+"! \nDesea continuar?";
                    DialogResult result = MessageBox.Show(mensaje, "Credenciales Aceptadas", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        this.AutenticacionRealizada = true; // Se guarda el resultado de la autenticacion
                        this.CodigoRol = u.Rol_Codigo; // Se guarda el Rol del usuario autenticado
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Usuario o contraseña invalidos...", "Credenciales Denegadas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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


        //// ELIMINAR EN ENTREGA ////
        private void Login_DoubleClick(object sender, EventArgs e)
        {   // Saltar autenticación solo para acelarar la etapa de desarrollo
            MessageBox.Show("Saltando autenticación...", "Interno", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            this.AutenticacionRealizada = true;
            this.Close();
        }
    }
}
