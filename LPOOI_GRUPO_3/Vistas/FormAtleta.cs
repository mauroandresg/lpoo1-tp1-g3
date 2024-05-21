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
    public partial class FormAtleta : Form
    {
        public FormAtleta()
        {
            InitializeComponent();
        }

        private void FormAtleta_Load(object sender, EventArgs e)
        {
            comboBoxGenero.Items.Add("M"); // Agrega el elemento "M" al ComboBox
            comboBoxGenero.Items.Add("F"); // Agrega el elemento "F" al ComboBox

            numericUpDownPeso.DecimalPlaces = 2; // Configura el número de decimales
            numericUpDownPeso.Minimum = 0; // Valor mínimo permitido
            numericUpDownPeso.Maximum = 100; // Valor máximo permitido

            numericUpDownAltura.DecimalPlaces = 2; // Configura el número de decimales
            numericUpDownAltura.Minimum = 0; // Valor mínimo permitido
            numericUpDownAltura.Maximum = 100; // Valor máximo permitido
        }

        private void btnCrearAtleta_Click(object sender, EventArgs e)
        {

            if (textNombre.Text == "" || textApellido.Text == "" || textDNI.Text == "")
            {
                MessageBox.Show("Los campos no deben estar vacios");
            }
            else
            {
                // Crear una nueva instancia de Atleta y asignar valores
                Atleta atleta = new Atleta
                {
                    Atl_nombre = textNombre.Text,
                    Atl_apellido = textApellido.Text,
                    Atl_dni = textDNI.Text,
                    Atl_genero = string.IsNullOrEmpty(comboBoxGenero.Text) ? '\0' : comboBoxGenero.Text[0],
                    Atl_nacionalidad = textNacionalidad.Text,
                    Atl_direccion = textBoxDireccion.Text,
                    Atl_entrenador = textEntrenador.Text,
                    Atl_email = textBoxEmail.Text,
                    Atl_altura = Convert.ToDouble(numericUpDownAltura.Value),
                    Atl_peso = Convert.ToDouble(numericUpDownPeso.Value),
                    Atl_fechaNac = dateTimeFechaNac.Value
                };

                // Guardar el atleta en la base de datos
                TrabajarAtleta.guardarAtleta(atleta);

                // Limpiar los campos después de guardar
                textDNI.Clear();
                textApellido.Clear();
                textNombre.Clear();
                textNacionalidad.Clear();
                textEntrenador.Clear();
                comboBoxGenero.SelectedIndex = -1;
                numericUpDownAltura.Value = 0;
                numericUpDownPeso.Value = 0;
                textBoxDireccion.Clear();
                textBoxEmail.Clear();

                MessageBox.Show("Atleta guardado correctamente");
            }
        }
    }
}
