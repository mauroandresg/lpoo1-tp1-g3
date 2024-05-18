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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            Usuario usuario1 = new Usuario("Mauro", "100", 1);
            Usuario usuario2 = new Usuario("Yasmin", "200", 2);
            Usuario usuario3 = new Usuario("Belen", "300", 3);

            Roles rol1 = new Roles(1, "Administrador");
            Roles rol2 = new Roles(2, "Vendedor");
            Roles rol3 = new Roles(3, "Operador");

            Boolean bUsuarioBuscado = false;
            string rolUsuario = "";

            if (usuario1.Usu_NombreUsuario == txtUsuario.Text && usuario1.Usu_Contraseña == txtContraseña.Text)
            {
                bUsuarioBuscado = true;
                rolUsuario = rol1.Rol_Descripcion;
            }
            else if (usuario2.Usu_NombreUsuario == txtUsuario.Text && usuario2.Usu_Contraseña == txtContraseña.Text)
            {
                bUsuarioBuscado = true;
                rolUsuario = rol2.Rol_Descripcion;
            }
            else if (usuario3.Usu_NombreUsuario == txtUsuario.Text && usuario3.Usu_Contraseña == txtContraseña.Text)
            {
                bUsuarioBuscado = true;
                rolUsuario = rol3.Rol_Descripcion;
            }
            if (bUsuarioBuscado)
            {
                MessageBox.Show(String.Format("Bienvenido {0}, tu rol es: {1}", txtUsuario.Text, rolUsuario));
                Principal principalForm = new Principal();
                principalForm.Show();
                this.Hide();
            }
            else if (txtUsuario.Text != usuario1.Usu_NombreUsuario && txtUsuario.Text != usuario2.Usu_NombreUsuario && txtUsuario.Text != usuario3.Usu_NombreUsuario)
            {
                MessageBox.Show("El usuario no existe");
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrecta");
            }
        }
    }
}
    
