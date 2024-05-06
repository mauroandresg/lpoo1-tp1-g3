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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnIngresar_Click_Click(object sender, EventArgs e)
        {

            Boolean bUserFound = false;

            Roles oRol2 = new Roles(2, "Vendedor");
            Roles oRol3 = new Roles(3, "Operador");

            Usuario oUsuario1 = new Usuario(1, "MartinF", "123", "Martin Flores", 1);
            Usuario oUsuario2 = new Usuario(2, "JuanC", "456", "Juan Cardozo", 2);
            Usuario oUsuario3 = new Usuario(3, "CarlosG", "789", "Carlos Gerez", 3);

            FrmMain oFrmMain = new FrmMain();

            if (oUsuario1.Usu_NombreUsuario == txtUserName.Text && oUsuario1.Usu_Contraseña == txtPassword.Text)
            {
                bUserFound = true;
            }
            else if (oUsuario2.Usu_NombreUsuario == txtUserName.Text && oUsuario2.Usu_Contraseña == txtPassword.Text)
            {
                bUserFound = true;
            }
            else if (oUsuario3.Usu_NombreUsuario == txtUserName.Text && oUsuario3.Usu_Contraseña == txtPassword.Text)
            {
                bUserFound = true;
            }


            if (bUserFound)
            {
                MessageBox.Show("Bienvenido/a: " + txtUserName.Text);
                oFrmMain.Show();
            }
            else
            {
                MessageBox.Show("Los datos son incorrectos");
            }
        }
    }
}
