using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesBase
{
    public class Usuario
    {
        public int Usu_ID { get; set; }
        public string Usu_NombreUsuario { get; set; }
        public string Usu_Contrasenia { get; set; }
        public string Usu_ApellidoNombre { get; set; }
        public int Rol_Codigo { get; set; } // Association with Roles

        public Usuario()
        { }

        public Usuario(string usu_NombreUsuario, string usu_Contrasenia, string usu_ApellidoNombre, int rol_Codigo)
        {
            Usu_NombreUsuario = usu_NombreUsuario;
            Usu_Contrasenia = usu_Contrasenia;
            Usu_ApellidoNombre = usu_ApellidoNombre;
            Rol_Codigo = rol_Codigo;
        }
    }
}
