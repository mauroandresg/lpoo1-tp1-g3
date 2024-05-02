using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesBase
{
    public class Categoria
    {
        private string cat_id;

        public string Cat_id
        {
            get { return cat_id; }
            set { cat_id = value; }
        }
        private string cat_nombre;

        public string Cat_nombre
        {
            get { return cat_nombre; }
            set { cat_nombre = value; }
        }

        private string cat_descripcion;

        public string Cat_descripcion
        {
            get { return cat_descripcion; }
            set { cat_descripcion = value; }
        }
    }
}
