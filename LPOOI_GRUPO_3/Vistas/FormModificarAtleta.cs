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
    public partial class FormModificarAtleta : Form
    {
        public FormModificarAtleta()
        {
            InitializeComponent();
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            if (textBoxBuscar.Text != "")
            {
                dataGridViewAtleta.DataSource = TrabajarAtleta.buscarAtleta(textBoxBuscar.Text);
            }
            else
            {
                MessageBox.Show("Campo de busqueda no debe estar vacio");
            }
        }

        private void dataGridViewAtleta_SelectionChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewAtleta.CurrentRow != null)
            {
                textBoxDNIatleta.Text = "";
                textBoxApellidoAtleta.Text = "";
                textBoxNombreAtleta.Text = "";
                textBoxNacionalidadAtleta.Text = "";
                textBoxEntrenadorAtleta.Text = "";
                textBoxGeneroAtleta.Text = "";
                textBoxAlturaAtleta.Text = "";
                textBoxPesoAtleta.Text = "";
                textBoxFechaNacAtleta.Text = "";
                textBoxDireccionAtleta.Text = "";
                textBoxEmailAtleta.Text = "";

                textBoxIdAtleta.Text = dataGridViewAtleta.CurrentRow.Cells["Id Atleta"].Value.ToString();
                textBoxDNIatleta.Text = dataGridViewAtleta.CurrentRow.Cells["DNI"].Value.ToString();
                textBoxApellidoAtleta.Text = dataGridViewAtleta.CurrentRow.Cells["Apellido"].Value.ToString();
                textBoxNombreAtleta.Text = dataGridViewAtleta.CurrentRow.Cells["Nombre"].Value.ToString();
                textBoxNacionalidadAtleta.Text = dataGridViewAtleta.CurrentRow.Cells["Nacionalidad"].Value.ToString();
                textBoxEntrenadorAtleta.Text = dataGridViewAtleta.CurrentRow.Cells["Entrenador"].Value.ToString();
                textBoxGeneroAtleta.Text = dataGridViewAtleta.CurrentRow.Cells["Genero"].Value.ToString();
                textBoxAlturaAtleta.Text = dataGridViewAtleta.CurrentRow.Cells["Altura"].Value.ToString();
                textBoxPesoAtleta.Text = dataGridViewAtleta.CurrentRow.Cells["Peso"].Value.ToString();
                textBoxFechaNacAtleta.Text = dataGridViewAtleta.CurrentRow.Cells["Fecha Nac"].Value.ToString();
                textBoxDireccionAtleta.Text = dataGridViewAtleta.CurrentRow.Cells["Direccion"].Value.ToString();
                textBoxEmailAtleta.Text = dataGridViewAtleta.CurrentRow.Cells["Email"].Value.ToString();
            }
        }

        private void buttonModificar_Click(object sender, EventArgs e)
        {
            if (textBoxDNIatleta.Text == "" || textBoxApellidoAtleta.Text == "" || textBoxNombreAtleta.Text == "" ||
                textBoxNacionalidadAtleta.Text == "" || textBoxEntrenadorAtleta.Text == "" || textBoxGeneroAtleta.Text == "" ||
                textBoxAlturaAtleta.Text == "" || textBoxPesoAtleta.Text == "" || textBoxFechaNacAtleta.Text == "" ||
                textBoxDireccionAtleta.Text == "" || textBoxEmailAtleta.Text == "")
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
                    Atleta atleta = new Atleta
                    {
                        Atl_id = Convert.ToInt32(textBoxIdAtleta.Text),
                        Atl_dni= textBoxDNIatleta.Text,
                        Atl_apellido = textBoxApellidoAtleta.Text,
                        Atl_nombre = textBoxNombreAtleta.Text,
                        Atl_nacionalidad = textBoxNacionalidadAtleta.Text,
                        Atl_entrenador = textBoxEntrenadorAtleta.Text,
                        Atl_genero = Convert.ToChar(textBoxGeneroAtleta.Text),
                        Atl_altura = Convert.ToDouble(textBoxAlturaAtleta.Text),
                        Atl_peso = Convert.ToDouble(textBoxPesoAtleta.Text),
                        Atl_fechaNac = Convert.ToDateTime(textBoxFechaNacAtleta.Text),
                        Atl_direccion = textBoxDireccionAtleta.Text,
                        Atl_email = textBoxEmailAtleta.Text
                    };

                    TrabajarAtleta.modificarAtleta(atleta);
                    MessageBox.Show("Información actualizada correctamente");

                    textBoxDNIatleta.Text = "";
                    textBoxApellidoAtleta.Text = "";
                    textBoxNombreAtleta.Text = "";
                    textBoxNacionalidadAtleta.Text = "";
                    textBoxEntrenadorAtleta.Text = "";
                    textBoxGeneroAtleta.Text = "";
                    textBoxAlturaAtleta.Text = "";
                    textBoxPesoAtleta.Text = "";
                    textBoxFechaNacAtleta.Text = "";
                    textBoxDireccionAtleta.Text = "";
                    textBoxEmailAtleta.Text = "";
                }
            }
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            if (textBoxIdAtleta.Text == "")
            {
                MessageBox.Show("Los campos no deben estar vacios");
            }
            int atl_id = Convert.ToInt32(textBoxIdAtleta.Text);

            TrabajarAtleta.eliminarAtleta(atl_id);

            MessageBox.Show("Usuario eliminado correctamente");

            textBoxDNIatleta.Text = "";
            textBoxApellidoAtleta.Text = "";
            textBoxNombreAtleta.Text = "";
            textBoxNacionalidadAtleta.Text = "";
            textBoxEntrenadorAtleta.Text = "";
            textBoxGeneroAtleta.Text = "";
            textBoxAlturaAtleta.Text = "";
            textBoxPesoAtleta.Text = "";
            textBoxFechaNacAtleta.Text = "";
            textBoxDireccionAtleta.Text = "";
            textBoxEmailAtleta.Text = "";
        }

    }
}
