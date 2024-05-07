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
    public partial class FormCateg : Form
    {
        public FormCateg()
        {
            InitializeComponent();
        }

        List<Categoria> categorias = new List<Categoria>();
        int i = 0;

        private void btnCrearCat_Click(object sender, EventArgs e)
        {
            
            Categoria nuevaCat = new Categoria();
            nuevaCat.Cat_id = i + 1;
            i = i + 1;
            nuevaCat.Cat_nombre = textNombreCat.Text;
            nuevaCat.Cat_descripcion = textDescripcionCat.Text;

            if (textNombreCat.Text == " " || textDescripcionCat.Text == " ")
            {
                MessageBox.Show("Nombre o Descripcion no debe estar vacio");
            }
            else
            {
                categorias.Add(nuevaCat);
                MessageBox.Show("Categoria agregada correctamente");
                MessageBox.Show( "DETALLE"+"\n" + 
                "Nombre de Categoria: " + nuevaCat.Cat_nombre.ToString() + "\n" + 
                "Descripcion: " + nuevaCat.Cat_descripcion.ToString());

                textNombreCat.Text = " ";
                textDescripcionCat.Text = " ";
            }
           
        }
    }
}
