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
    public partial class FormAgregarCategoria : Form
    {
        public FormAgregarCategoria()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Categoria CategoriaNueva = new Categoria();

            CategoriaNueva.Cat_Nombre = CategoriaNombre.Text;
            CategoriaNueva.Cat_Descripcion = DescCategoria.Text;

            MessageBox.Show("Categoria: " + CategoriaNueva.Cat_Nombre + "\n" +
                            "Descripcion: " + CategoriaNueva.Cat_Descripcion +  "\n" + 
                            "Agregada existosamente");
                               
        }
    }
}
