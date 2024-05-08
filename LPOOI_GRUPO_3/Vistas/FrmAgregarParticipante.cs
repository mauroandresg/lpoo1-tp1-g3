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
    public partial class FrmAgregarParticipante : Form
    {
        public FrmAgregarParticipante()
        {
            InitializeComponent();
        }

        private void btnGuardarParticipante_Click(object sender, EventArgs e)
        {
            Atleta oAtletaNuevo = new Atleta();

            oAtletaNuevo.Atl_DNI = txtDniParticipante.Text;
            oAtletaNuevo.Atl_Apellido = txtApellidoParticipante.Text;
            oAtletaNuevo.Atl_Nombre = txtNombreParticipante.Text;
            oAtletaNuevo.Atl_Nacionalidad = txtNacionalidadParticipante.Text;
            oAtletaNuevo.Atl_Entrenador = txtEntrenadorParticipante.Text;
            oAtletaNuevo.Atl_Genero = Convert.ToChar( txtGeneroParticipante.Text);
            oAtletaNuevo.Atl_Altura = Convert.ToDouble(txtAlturaParticipante.Text);
            oAtletaNuevo.Atl_Peso = Convert.ToDouble(txtPesoParticipante.Text);
            oAtletaNuevo.Atl_FechaNac = Convert.ToDateTime(txtFechaNacParticipante.Text);
            oAtletaNuevo.Atl_Direccion = txtDireccionParticipante.Text;
            oAtletaNuevo.Atl_Email = txtEmailParticipante.Text;

            MessageBox.Show("DNI: " + oAtletaNuevo.Atl_DNI + "\n" +
                            "Apellido: " + oAtletaNuevo.Atl_Apellido + "\n" +
                            "Nombre: " + oAtletaNuevo.Atl_Nombre + "\n" +
                            "Nacionalidad: " + oAtletaNuevo.Atl_Nacionalidad + "\n" +
                            "Entrenado: " + oAtletaNuevo.Atl_Entrenador + "\n" +
                            "Genero: " + oAtletaNuevo.Atl_Genero + "\n" +
                            "Altura: " + oAtletaNuevo.Atl_Altura + "\n" +
                            "Peso: " + oAtletaNuevo.Atl_Peso + "\n" +
                            "Fecha de nacimiento: " + oAtletaNuevo.Atl_FechaNac + "\n" +
                            "Direccion: " + oAtletaNuevo.Atl_Direccion + "\n" +
                            "Email: " + oAtletaNuevo.Atl_Email, "NUEVO PARTICIPANTE");

        }

    }
}
