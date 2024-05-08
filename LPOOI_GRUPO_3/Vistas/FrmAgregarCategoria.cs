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
    public partial class FrmAgregarCategoria : Form
    {
        public FrmAgregarCategoria()
        {
            InitializeComponent();
        }

        private void btnGuadarNuevaCategoria_Click(object sender, EventArgs e)
        {
            Categoria oCategoriaNueva = new Categoria();

            oCategoriaNueva.Cat_Nombre = txtNombreNuevaCategoria.Text;
            oCategoriaNueva.Cat_Descripcion = txtCategoriaNuevaDescripcion.Text;

            MessageBox.Show("Nombre: " + oCategoriaNueva.Cat_Nombre + "\n" + "Descripcion: " + oCategoriaNueva.Cat_Descripcion, "NUEVA CATEGORIA");

        }
    }
}
