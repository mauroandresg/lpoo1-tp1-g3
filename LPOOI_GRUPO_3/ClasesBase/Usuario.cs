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
        public string Usu_Contraseña { get; set; }
        public string Usu_ApellidoNombre { get; set; }
        public int Rol { get; set; } // Objeto Roles asociado al usuario

        public Usuario(string nombreUsuario, string contraseña, int rol)
        {
            Usu_NombreUsuario = nombreUsuario;
            Usu_Contraseña = contraseña;
            Rol = rol;
        }
    }
}
