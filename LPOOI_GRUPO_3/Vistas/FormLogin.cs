﻿using System;
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
            Boolean bUserFound = false;

            Usuario user1 = new Usuario("juan","123");
            Usuario user2 = new Usuario("maria", "456");

            if(user1.Usu_NombreUsuario == textName.Text && user1.Usu_contraseña == textPassword.Text){
                bUserFound = true;
            }
            else if(user2.Usu_NombreUsuario == textName.Text && user2.Usu_contraseña == textPassword.Text)
            {
                bUserFound = true; 
            }
            if (bUserFound)
            {
                MessageBox.Show("Bienvenido" + textName.Text);
            }
            else
            {
                MessageBox.Show("Datos incorrectos");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }

        private void textName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
