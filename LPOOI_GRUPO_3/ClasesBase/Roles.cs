using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesBase
{
    public class Roles
    {
        public int Rol_Codigo { get; set; }
        public string Rol_Descripcion { get; set; }


        public Roles(int codigo, string descripcion)
        {
            Rol_Codigo = codigo;
            Rol_Descripcion = descripcion;
        }
    }
}
