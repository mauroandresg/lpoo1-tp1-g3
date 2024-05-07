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
            numericUpDownAltura.Maximum = 3; // Valor máximo permitido
        }

        List<Atleta> atletas = new List<Atleta>();
        int i = 0;
        private void btnCrearAtleta_Click(object sender, EventArgs e)
        {
            Atleta nuevoAtleta = new Atleta();

            nuevoAtleta.Atl_id = i + 1;
            nuevoAtleta.Atl_nombre = textNombre.Text;
            nuevoAtleta.Atl_apellido = textApellido.Text;
            nuevoAtleta.Atl_dni = textDNI.Text;
            nuevoAtleta.Atl_nacionalidad = textNacionalidad.Text;
            nuevoAtleta.Atl_entrenador = textEntrenador.Text;
            nuevoAtleta.Atl_peso = (float)numericUpDownPeso.Value;
            nuevoAtleta.Atl_altura = (float)numericUpDownAltura.Value;
            nuevoAtleta.Atl_genero = comboBoxGenero.SelectedItem.ToString().ToCharArray()[0];
            nuevoAtleta.Atl_direccion = textBoxDireccion.Text;
            nuevoAtleta.Alt_email = textBoxEmail.Text;

            if (nuevoAtleta.Atl_nombre == " " || nuevoAtleta.Atl_apellido == " " ||
                nuevoAtleta.Atl_dni == " " || nuevoAtleta.Atl_nacionalidad == " " ||
                nuevoAtleta.Atl_nacionalidad == " " || nuevoAtleta.Atl_entrenador == " " ||
                nuevoAtleta.Atl_direccion == " " || nuevoAtleta.Alt_email == " ")
            {
                MessageBox.Show("Los campos no deben estar vacio");
            }
            else
            {
                atletas.Add(nuevoAtleta);

                MessageBox.Show("Atleta creado con exito");
                MessageBox.Show("Alteta \n" + "Nombre: " + nuevoAtleta.Atl_nombre + "\n" + "Apellido: " + nuevoAtleta.Atl_apellido + "\n" + "Nacionalidad: " + nuevoAtleta.Atl_nacionalidad + "\n" + "Genero: " + nuevoAtleta.Atl_genero);

                textNombre.Text = " ";
                textApellido.Text = " ";
                textBoxDireccion.Text = " ";
                textBoxEmail.Text = " ";
                textNacionalidad.Text = " ";
                textEntrenador.Text = " ";
                textDNI.Text = " ";
                numericUpDownAltura.Value = 0;
                numericUpDownPeso.Value = 0;
            }
           
        }
    }
}
