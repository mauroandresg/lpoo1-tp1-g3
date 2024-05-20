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
            dataGridViewUsuarios.SelectionChanged += dataGridViewUsuarios_SelectionChanged;
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

        private void buttonModificar_Click(object sender, EventArgs e)
        {
            if(textBoxNomAp.Text == "" || textBoxUser.Text == "" || textBoxPass.Text == "")
            {
                MessageBox.Show("Los campos no deben estar vacios");
            }
            else
            {
                if (dataGridViewUsuarios.SelectedRows.Count > 0)
                {
                    DataGridViewRow row = dataGridViewUsuarios.SelectedRows[0];
                    row.Cells["Nombre Y Apellido"].Value = textBoxNomAp.Text;
                    row.Cells["Usuario"].Value = textBoxUser.Text;
                    row.Cells["Contraseña"].Value = textBoxPass.Text;
                    MessageBox.Show("Información actualizada correctamente");
                }
            }
        }

        private void dataGridViewUsuarios_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewUsuarios.CurrentRow != null)
            {
                comboBoxRol.SelectedValue = dataGridViewUsuarios.CurrentRow.Cells["Rol"].Value.ToString();
                textBoxNomAp.Text = dataGridViewUsuarios.CurrentRow.Cells["Nombre y Apellido "].Value.ToString();
                textBoxUser.Text = dataGridViewUsuarios.CurrentRow.Cells["Usuario"].Value.ToString();
                textBoxPass.Text = dataGridViewUsuarios.CurrentRow.Cells["Contraseña"].Value.ToString();
            }
        }
    }
}
