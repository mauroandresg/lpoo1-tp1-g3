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
    public partial class FormDisciplina : Form
    {
        public FormDisciplina()
        {
            InitializeComponent();
        }


        List<Discipolina> disciplinas = new List<Discipolina>();
        int i = 0;

        private void btnCrear_Click(object sender, EventArgs e)
        {
            Discipolina nuevaDisciplina = new Discipolina();

            nuevaDisciplina.Dis_id = i + 1;
            i = i + 1;
            nuevaDisciplina.Dis_nombre = textBoxNombre.Text;
            nuevaDisciplina.Dis_descripcion = textBoxDescripcion.Text;

            if (nuevaDisciplina.Dis_nombre == " " || nuevaDisciplina.Dis_descripcion == " ")
            {
                MessageBox.Show("Nombre o Descripcion no debe estar vacio");
            }
            else
            {
                disciplinas.Add(nuevaDisciplina);
                MessageBox.Show("Disciplina creada correctamente \n" + 
                "Nombre: " + nuevaDisciplina.Dis_nombre + "\n" +
                "Descripcion: " + nuevaDisciplina.Dis_descripcion);
            }

        }
    }
}
