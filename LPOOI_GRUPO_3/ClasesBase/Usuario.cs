﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesBase
{
    class Usuario
    {
        public int Usu_ID { get; set; }
        public string Usu_NombreUsuario { get; set; }
        public string Usu_Contrasenia { get; set; }
        public string Usu_ApellidoNombre { get; set; }
        public int Rol_Codigo { get; set; } // Association with Roles
    }
}
