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
    public enum TipoForm
    {
        DISCIPLINA, CATEGORIA, ATLETA
    }

    public partial class Formulario : Form
    {
        public string TituloTxt { get; set; } // Texto que se le asigna a LblTituloFormulario
        public TipoForm TipoFormulario { get; set; } // Indica que tipo de entidad creara este formulario
        public bool NuevaEntidadCreada { get; private set; } // Registra si se creo o no, una nueva entidad

        public Categoria NuevaCat { get; set; } // Almacena la nueva entidad Categoria
        public Disciplina NuevaDis { get; set; } // Almacena la nueva entidad Disciplina
        public Atleta NuevoAtl { get; set; } // Almacena la nueva entidad Atleta

        public Formulario()
        {
            InitializeComponent();
            NuevaEntidadCreada = false; // Por defecto no existe ninguna entidad nueva
        }

        private void Formulario_Load(object sender, EventArgs e)
        {
            LblTituloFormulario.Text = TituloTxt;
            switch (TipoFormulario) // Muestra el formulario correspondiente al tipo
            {
                case TipoForm.DISCIPLINA:
                    this.PanelDisciplina.Visible = true;
                    break;
                case TipoForm.CATEGORIA:
                    this.PanelCategoria.Visible = true;
                    break;
                case TipoForm.ATLETA:
                    this.PanelAtleta.Visible = true;
                    break;
                default:
                    break;
            }
        }
    }
}
