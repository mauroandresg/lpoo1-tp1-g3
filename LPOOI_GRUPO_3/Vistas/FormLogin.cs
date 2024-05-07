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

            Usuario user1 = new Usuario(1,"juan","123","ca",1);
            Usuario user2 = new Usuario(2, "maria", "456", "sanchez", 2);
            Usuario user3 = new Usuario(3, "carlos", "789", "torres", 3);
      
            Roles rol1 = new Roles(1, "Administrador");
            Roles rol2 = new Roles(2, "Vendedor");
            Roles rol3 = new Roles(3, "Operador");

        public FormLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Boolean bUserFound = false;

            FormPrincipal oFormMain = new FormPrincipal();

            if(user1.Usu_NombreUsuario == textName.Text && user1.Usu_contraseña == textPassword.Text){
                bUserFound = true;
            }
            else if(user2.Usu_NombreUsuario == textName.Text && user2.Usu_contraseña == textPassword.Text)
            {
                bUserFound = true; 
            }
            if (bUserFound)
            {
                MessageBox.Show("Bienvenido "  + textName.Text);
                oFormMain.ShowDialog();
            }
            else
            {
                MessageBox.Show("Datos incorrectos");
            }
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
