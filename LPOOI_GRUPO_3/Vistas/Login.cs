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
    public partial class Login : Form
    {
        public bool AutenticacionCorrecta { get; private set; } // Propiedad: resultado de autenticación

        bool usr_valido = false;
        bool contra_valido = false;

        public Login()
        {
            InitializeComponent();
            this.AutenticacionCorrecta = false; // Se obliga a realizar la autenticacion al iniciar el form
        }

        private void BtnIngresar_Click(object sender, EventArgs e)
        {
            if (usr_valido && contra_valido)
            {
                // Precarga de roles
                Roles r1 = new Roles(1, "Vendedor");
                Roles r2 = new Roles(2, "Operador");
                Roles r3 = new Roles(3, "Administrador");

                // Precarga de usuarios
                Usuario u1 = new Usuario("cami_tor", "contra1234", "Torres Camila", 1);
                Usuario u2 = new Usuario("ariel_op", "contraSegura", "Amparo Ariel", 2);
                Usuario u3 = new Usuario("indi_xd", "admin", "Benson Indigo", 3);

                Usuario[] usuarios = { u1, u2, u3 };

                // Autenticación de credenciales
                bool autorizado = false;
                int index = -1;
                for (int i = 0; i < usuarios.Length; i++)
                {
                    if (string.Equals(usuarios[i].Usu_NombreUsuario, TxtUsuario.Text)
                        && string.Equals(usuarios[i].Usu_Contrasenia, TxtContra.Text))
                    {
                        autorizado = true;
                        index = i;
                    }
                }
                if (autorizado)
                {
                    string msg = "Ingresando como " + usuarios[index].Usu_ApellidoNombre + "...\n" + "Desea continuar?";
                    DialogResult result = MessageBox.Show(msg, "Credenciales Aceptadas", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        this.AutenticacionCorrecta = true; // Se guarda el resultado de la autenticacion
                        this.Close();
                    }
                } else
                {
                    MessageBox.Show("Usuario o contraseña invalidos...", "Credenciales Denegadas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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

        /// ELIMINAR EN ENTREGA ///
        private void Login_DoubleClick(object sender, EventArgs e)
        {   // Saltar autenticación solo para acelarar la etapa de desarrollo
            MessageBox.Show("Saltando autenticación...", "Interno", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            this.AutenticacionCorrecta = true;
            this.Close();
        }
        ///////////////////////////
    }
}
