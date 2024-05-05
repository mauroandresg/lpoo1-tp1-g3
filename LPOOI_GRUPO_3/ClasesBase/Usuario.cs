using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesBase
{
    public class Usuario
    {
        private int usu_id;
        private string usu_NombreUsuario;
        private string usu_contraseña;
        private string usu_ApellidoNombre;
        private int rol_codigo;

        public int Rol_codigo
        {
            get { return rol_codigo; }
            set { rol_codigo = value; }
        }

        public string Usu_ApellidoNombre
        {
            get { return usu_ApellidoNombre; }
            set { usu_ApellidoNombre = value; }
        }

        public string Usu_contraseña
        {
            get { return usu_contraseña; }
            set { usu_contraseña = value; }
        }

        public string Usu_NombreUsuario
        {
            get { return usu_NombreUsuario; }
            set { usu_NombreUsuario = value; }
        }

        public int Usu_id
        {
            get { return usu_id; }
            set { usu_id = value; }
        }

        public Usuario(string username, string password, int rol) {
            usu_NombreUsuario = username;
            usu_contraseña = password;
            rol_codigo = rol;
        }
    }
}
