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
    public partial class FrmUsuario : Form
    {
        public FrmUsuario()
        {
            InitializeComponent();
        }

        private void FrmUsuario_Load(object sender, EventArgs e)
        {
            ComRol_Load();
            DGridUsuario_Load();
        }

        private void ComRol_Load()
        {
            ComRol.DisplayMember = "Descripcion";
            ComRol.ValueMember = "Codigo";
            ComRol.DataSource = TrabajarUsuario.ListarRoles();
        }

        private void DGridUsuario_Load()
        {
            DGridUsuario.DataSource = TrabajarUsuario.Listar();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            Usuario oUsuario = new Usuario();
            oUsuario.Rol_Codigo = (int) ComRol.SelectedValue;
            oUsuario.Usu_ApellidoNombre = TxtApellidoNombre.Text;
            oUsuario.Usu_NombreUsuario = TxtUsuario.Text;
            oUsuario.Usu_Contrasenia = TxtContrasenia.Text;

            TrabajarUsuario.Insertar(oUsuario);
            DGridUsuario_Load();
        }

        private void BtnBuscardor_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtBuscador.Text))
            {
                DGridUsuario_Load();
            } else {
                DGridUsuario.DataSource = TrabajarUsuario.Buscar(TxtBuscador.Text);
            }
        }

        private void DGridUsuario_CurrentCellChanged(object sender, EventArgs e)
        {
            if (DGridUsuario.CurrentRow != null)
            {
                ComRol.SelectedValue = DGridUsuario.CurrentRow.Cells["Codigo Rol"].Value.ToString();
                TxtApellidoNombre.Text = DGridUsuario.CurrentRow.Cells["Apellido y Nombre"].Value.ToString();
                TxtUsuario.Text = DGridUsuario.CurrentRow.Cells["Usuario"].Value.ToString();
                TxtContrasenia.Text = DGridUsuario.CurrentRow.Cells["Contraseña"].Value.ToString();
            }
        }
    }
}
