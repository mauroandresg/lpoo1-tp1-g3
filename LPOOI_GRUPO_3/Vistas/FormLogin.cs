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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Usuario usuario = TrabajarUsuario.ObtenerUsuario(textName.Text, textPassword.Text);
            if (usuario != null)
            {
                MessageBox.Show("Bienvenido " + usuario.Usu_ApellidoNombre);
                FormPrincipal oFormMain = new FormPrincipal();

                switch (usuario.Rol_codigo)
                {
                    case 1: // Administrador
                        oFormMain.AccesoGestionUsuarios = true;
                        break;
                    case 2: // Operador
                        oFormMain.AccesoAtletasCompeticiones = true;
                        break;
                    case 3: // Auditor
                        oFormMain.AccesoTotal = true;
                        break;
                    default:
                        MessageBox.Show("Rol no reconocido.");
                        return;
                }

                this.Hide();
                oFormMain.ShowDialog();
               // this.Show();
            }
            else
            {
                MessageBox.Show("Datos incorrectos");
            }
        }
    }
}
