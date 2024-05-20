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
    public partial class FormUsuario : Form
    {
        public FormUsuario()
        {
            InitializeComponent();
        }

        private void FormUsuario_Load(object sender, EventArgs e)
        {
            load_combo_roles();
            load_usuarios();
        }

        private void load_usuarios()
        {
            DataTable usuarios = TrabajarUsuario.listUsuarios();
            dataGridViewUsuarios.DataSource = TrabajarUsuario.listUsuarios();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
       private void load_combo_roles()
        {
            comboBoxRol.DisplayMember = "rol_descripcion";  // Campo para mostrar en el ComboBox
            comboBoxRol.ValueMember = "rol_id";  // Campo para el valor del ComboBox
            comboBoxRol.DataSource = TrabajarUsuario.listRoles();
        }

       private void buttonGuardar_Click(object sender, EventArgs e)
       {
           Usuario oUser = new Usuario();

           oUser.Rol_codigo = (int) comboBoxRol.SelectedValue;
           oUser.Usu_ApellidoNombre = textBoxNomYape.Text;
           oUser.Usu_NombreUsuario = textBoxUser.Text;
           oUser.Usu_contraseña = textBoxPass.Text;

           TrabajarUsuario.insertarUsuario(oUser);
           load_usuarios();
       }
    }
}
