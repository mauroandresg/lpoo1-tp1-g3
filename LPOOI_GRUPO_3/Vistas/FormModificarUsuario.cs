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
    public partial class FormModificarUsuario : Form
    {
        public FormModificarUsuario()
        {
            InitializeComponent();
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            if (textBoxBuscar.Text != "")
            {
                dataGridView1.DataSource = TrabajarUsuario.buscarUsuario(textBoxBuscar.Text);
            }
            else
            {
                MessageBox.Show("Campo de busqueda no debe estar vacio");
            }
        }
    }
}
