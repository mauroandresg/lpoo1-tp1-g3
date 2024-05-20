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
    public partial class FormModificarUsuario : Form
    {
        public FormModificarUsuario()
        {
            InitializeComponent();
            //dataGridViewUsuarios.SelectionChanged += dataGridViewUsuarios_SelectionChanged;
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            if (textBoxBuscar.Text != "")
            {
                dataGridViewUsuarios.DataSource = TrabajarUsuario.buscarUsuario(textBoxBuscar.Text);
            }
            else
            {
                MessageBox.Show("Campo de busqueda no debe estar vacio");
            }
        }
        private void dataGridViewUsuarios_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewUsuarios.CurrentRow != null)
            {
                comboBoxRol.Text = "";
                textBoxUserId.Text = "";
                textBoxUser.Text = "";
                textBoxPass.Text = "";
                textBoxNomAp.Text = "";

                comboBoxRol.SelectedText = dataGridViewUsuarios.CurrentRow.Cells["rol"].Value.ToString();
                textBoxUserId.Text = dataGridViewUsuarios.CurrentRow.Cells["Usuario id"].Value.ToString();
                textBoxNomAp.Text = dataGridViewUsuarios.CurrentRow.Cells["Nombre y Apellido "].Value.ToString();
                textBoxUser.Text = dataGridViewUsuarios.CurrentRow.Cells["Usuario"].Value.ToString();
                textBoxPass.Text = dataGridViewUsuarios.CurrentRow.Cells["Contraseña"].Value.ToString();
            }
        }

        private void buttonEliminar_Click_1(object sender, EventArgs e)
        {
            
            int usu_id = Convert.ToInt32(textBoxUserId.Text);
            TrabajarUsuario.eliminarUsuario(usu_id);
            MessageBox.Show("Usuario eliminado correctamente");
            
            comboBoxRol.Text = "";
            textBoxUserId.Text = "";
            textBoxUser.Text = "";
            textBoxPass.Text = "";
            textBoxNomAp.Text = "";
        }

        private void buttonModificar_Click(object sender, EventArgs e)
        {
            if (textBoxNomAp.Text == "" || textBoxUser.Text == "" || textBoxPass.Text == "")
            {
                MessageBox.Show("Los campos no deben estar vacíos");
            }
            else
            {
                var confirmResult = MessageBox.Show("¿Estás seguro de que deseas modificar este usuario?",
                                             "Confirmar Modificación",
                                             MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    Usuario user = new Usuario
                    {
                        Usu_NombreUsuario = textBoxUser.Text,
                        Usu_contraseña = textBoxPass.Text,
                        Usu_ApellidoNombre = textBoxNomAp.Text,
                        Usu_id = Convert.ToInt32(textBoxUserId.Text)
                    };
                    TrabajarUsuario.modificarUsuario(user);
                    MessageBox.Show("Información actualizada correctamente");

                    comboBoxRol.Text = "";
                    textBoxUserId.Text = "";
                    textBoxUser.Text = "";
                    textBoxPass.Text = "";
                    textBoxNomAp.Text = "";
                }
            }
        }
    }
 }

