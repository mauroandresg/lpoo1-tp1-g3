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

            Atleta atleta = new Atleta();

            atleta.Atl_nombre = textNombre.Text;
            atleta.Atl_apellido = textApellido.Text;
            atleta.Atl_dni = textDNI.Text;
            atleta.Atl_genero = Convert.ToChar(comboBoxGenero.Text);
            atleta.Atl_nacionalidad = textNacionalidad.Text;
            atleta.Atl_direccion = textBoxDireccion.Text;
            atleta.Atl_email = textBoxEmail.Text;
            atleta.Atl_altura = Convert.ToDouble(numericUpDownAltura.Value);
            atleta.Atl_peso = Convert.ToDouble(numericUpDownPeso.Value);
            atleta.Atl_fechaNac = dateTimeFechaNac.Value;

            if (textNombre.Text == "" || textApellido.Text == "" || textDNI.Text == "")
            {
                MessageBox.Show("Los campos no deben estar vacios");
            }
            else
            {
                TrabajarAtleta.guardarAtleta(atleta);

                textDNI.Text = "";
                textApellido.Text = "";
                textNombre.Text = "";
                textNacionalidad.Text = "";
                textEntrenador.Text = "";
                comboBoxGenero.SelectedValue = "";
                numericUpDownAltura.Value = 0;
                numericUpDownPeso.Value = 0;
                textBoxDireccion.Text = "";
                textBoxEmail.Text = "";

                MessageBox.Show("Usuario guardado correctamente");
            }
        }

        private void dateTimeFechaNac_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxGenero_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
