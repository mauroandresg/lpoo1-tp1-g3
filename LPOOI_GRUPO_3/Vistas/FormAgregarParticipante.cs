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
    public partial class FormAgregarParticipante : Form
    {
        public FormAgregarParticipante()
        {
            InitializeComponent();
        }

        private void agregarParticipante_Click(object sender, EventArgs e)
        {
            Atleta AtletaNuevo = new Atleta();

            AtletaNuevo.Atl_DNI = Dni.Text;
            AtletaNuevo.Atl_Nombre = Nombre.Text;
            AtletaNuevo.Atl_Apellido = Apellido.Text;
            AtletaNuevo.Atl_Nacionalidad = Nacionalidad.Text;
            AtletaNuevo.Atl_Entrenador = Entrenador.Text;
            AtletaNuevo.Atl_Genero = Genero.Text;
            AtletaNuevo.Alt_Altura = Convert.ToDouble(Altura.Text);
            AtletaNuevo.Alt_Peso = Convert.ToDouble(Peso.Text);
            AtletaNuevo.Alt_FechaNac = Convert.ToDateTime(FechaNac.Text);
            AtletaNuevo.Atl_Direccion = Direccion.Text;
            AtletaNuevo.Atl_Email = Email.Text;

            MessageBox.Show("DNI: " + AtletaNuevo.Atl_DNI + "\n" +
                           "Nombre: " + AtletaNuevo.Atl_Nombre + "\n" +
                           "Apellido: " + AtletaNuevo.Atl_Apellido + "\n" +
                           "Nacionalidad: " + AtletaNuevo.Atl_Nacionalidad + "\n" +
                           "Entrenado: " + AtletaNuevo.Atl_Entrenador + "\n" +
                           "Genero: " + AtletaNuevo.Atl_Genero + "\n" +
                           "Altura: " + AtletaNuevo.Alt_Altura + "\n" +
                           "Peso: " + AtletaNuevo.Alt_Peso + "\n" +
                           "Fecha de nacimiento: " + AtletaNuevo.Alt_FechaNac + "\n" +
                           "Direccion: " + AtletaNuevo.Atl_Direccion + "\n" +
                           "Email: " + AtletaNuevo.Atl_Email, "Agregado correctamente");
        }
    }
}
