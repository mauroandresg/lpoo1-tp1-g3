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

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (CamposCompletos())
            {
                switch (TipoFormulario)
                {
                    case TipoForm.DISCIPLINA:
                        NuevaDis = new Disciplina();
                        NuevaDis.Dis_Nombre = TxtDisNombre.Text;
                        NuevaDis.Dis_Descripcion = TxtDisDescripcion.Text;
                        break;
                    case TipoForm.CATEGORIA:
                        NuevaCat = new Categoria();
                        NuevaCat.Cat_Nombre = TxtCatNombre.Text;
                        NuevaCat.Cat_Descripcion = TxtCatDescripcion.Text;
                        break;
                    case TipoForm.ATLETA:
                        NuevoAtl = new Atleta();
                        NuevoAtl.Atl_DNI = TxtAtlDNI.Text;
                        NuevoAtl.Atl_Apellido = TxtAtlApellido.Text;
                        NuevoAtl.Atl_Nombre = TxtAtlNombre.Text;
                        NuevoAtl.Atl_Nacionalidad = TxtAtlNacionalidad.Text;
                        NuevoAtl.Atl_Entrenador = TxtAtlEntrenador.Text;
                        if (!string.IsNullOrEmpty(TxtAtlGenero.Text))
                        {
                            NuevoAtl.Atl_Genero = TxtAtlGenero.Text.First();
                        }
                        NuevoAtl.Atl_Altura = (double)NumAtlAltura.Value;
                        NuevoAtl.Atl_Peso = (double)NumAtlPeso.Value;
                        NuevoAtl.Atl_FechaNac = DateAtlFechaNac.Value;
                        NuevoAtl.Atl_Direccion = TxtAtlDireccion.Text;
                        NuevoAtl.Atl_Email = TxtAtlEmail.Text;
                        break;
                    default:
                        break;
                }
                this.NuevaEntidadCreada = true;
                this.Close();
            }
            else
            {
                MessageBox.Show("Complete todos los campos!", "Faltan datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool CamposCompletos()
        {
            bool resultado = true;
            switch (TipoFormulario)
            {
                case TipoForm.DISCIPLINA:
                    if (string.IsNullOrEmpty(TxtDisNombre.Text) || string.IsNullOrEmpty(TxtDisDescripcion.Text))
                    { resultado = false; }
                    break;
                case TipoForm.CATEGORIA:
                    if (string.IsNullOrEmpty(TxtCatNombre.Text) || string.IsNullOrEmpty(TxtCatDescripcion.Text))
                    { resultado = false; }
                    break;
                case TipoForm.ATLETA:
                    string[] camposAtleta = { TxtAtlDNI.Text, TxtAtlApellido.Text, TxtAtlNombre.Text, TxtAtlNacionalidad.Text, TxtAtlEntrenador.Text, TxtAtlGenero.Text, TxtAtlDireccion.Text, TxtAtlEmail.Text };
                    foreach (var item in camposAtleta)
                    {
                        if (item.Length == 0) resultado = false;
                    }
                    if (NumAtlAltura.Value==0 || NumAtlPeso.Value==0)
                    { resultado = false; }
                    break;
            }
            return resultado;
        }
    }
}
