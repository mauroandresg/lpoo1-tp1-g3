using ClasesBase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Vistas
{
    public partial class Inicio : Form
    {
        Categoria cat;
        Disciplina dis;
        Atleta atl;

        public Inicio()
        {
            InitializeComponent();
        }

        private void MItemAcerca_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sport Flow - version 0.1 \nDesarrollado por grupo LPOO1-G3");
        }

        private void MItemSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MItemCatCrear_Click(object sender, EventArgs e)
        {
            Formulario frmFormulario = new Formulario();
            frmFormulario.TituloTxt = "Nueva Categoria";
            frmFormulario.TipoFormulario = TipoForm.CATEGORIA;
            frmFormulario.ShowDialog();

            if (frmFormulario.NuevaEntidadCreada == true)
            {
                cat = new Categoria();
                cat = frmFormulario.NuevaCat;
            }
        }

        private void MItemDisCrear_Click(object sender, EventArgs e)
        {
            Formulario frmFormulario = new Formulario();
            frmFormulario.TituloTxt = "Nueva Disciplina";
            frmFormulario.TipoFormulario = TipoForm.DISCIPLINA;
            frmFormulario.ShowDialog();

            if (frmFormulario.NuevaEntidadCreada == true)
            {
                dis = new Disciplina();
                dis = frmFormulario.NuevaDis;
            }
        }

        private void MItemPartCrear_Click(object sender, EventArgs e)
        {
            Formulario frmFormulario = new Formulario();
            frmFormulario.TipoFormulario = TipoForm.ATLETA;
            frmFormulario.TituloTxt = "Nuevo Atleta";
            frmFormulario.ShowDialog();

            if (frmFormulario.NuevaEntidadCreada == true)
            {
                atl = new Atleta();
                atl = frmFormulario.NuevoAtl;
            }
        }

        private void MItemCatMostrar_Click(object sender, EventArgs e)
        {
            if (cat != null)
            {
                StringBuilder mensaje = new StringBuilder();
                mensaje.AppendLine("Categoría" + Environment.NewLine);
                mensaje.AppendLine("Nombre: " + cat.Cat_Nombre);
                mensaje.AppendLine("Descripción: " + cat.Cat_Descripcion);
                MessageBox.Show(mensaje.ToString(), "Nueva Categoría");
            } else
	        {
                MensajeMostrarVacio();
	        }
        }

        private void MItemDisMostrar_Click(object sender, EventArgs e)
        {
            if (dis != null)
            {
                StringBuilder mensaje = new StringBuilder();
                mensaje.AppendLine("Disciplina" + Environment.NewLine);
                mensaje.AppendLine("Nombre: " + dis.Dis_Nombre);
                mensaje.AppendLine("Descripción: " + dis.Dis_Descripcion);
                MessageBox.Show(mensaje.ToString(), "Nueva Disciplina"); 
            } else
	        {
                MensajeMostrarVacio();
	        }
        }

        private void MItemPartMostrar_Click(object sender, EventArgs e)
        {
            if (atl != null)
            {
                StringBuilder mensaje = new StringBuilder();
                mensaje.AppendLine("Atleta" + Environment.NewLine);
                mensaje.AppendLine("DNI: " + atl.Atl_DNI + " - Genero: " + atl.Atl_Genero);
                mensaje.AppendLine("Nombre y Apellido: " + atl.Atl_Nombre + " " + atl.Atl_Apellido);
                mensaje.AppendLine("Nacionalidad: " + atl.Atl_Nacionalidad);
                mensaje.AppendLine("Entrenador: " + atl.Atl_Entrenador);
                mensaje.AppendLine("Altura: " + atl.Atl_Altura + "Mts - Peso:" + atl.Atl_Peso + "KG");
                mensaje.AppendLine("Fecha de nacimiento: " + atl.Atl_FechaNac.ToShortDateString());
                mensaje.AppendLine("Dirección/Domicilio: " + atl.Atl_Direccion);
                mensaje.AppendLine("Email de contacto: " + atl.Atl_Email);
                MessageBox.Show(mensaje.ToString(), "Nuevo participante"); 
            } else
	        {
                MensajeMostrarVacio();
	        }
        }

        private void MensajeMostrarVacio() {
            MessageBox.Show("Aún no se cargaron datos...", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
