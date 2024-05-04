using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesBase
{
    public class Categoria
    {
        private string cat_ID;
        public string Cat_ID
        {
            get { return cat_ID; }
            set { cat_ID = value; }
        }

        private string cat_Nombre;
        public string Cat_Nombre
        {
            get { return cat_Nombre; }
            set { cat_Nombre = value; }
        }

        private string cat_Descripcion;
        public string Cat_Descripcion
        {
            get { return cat_Descripcion; }
            set { cat_Descripcion = value; }
        }
    }
}
