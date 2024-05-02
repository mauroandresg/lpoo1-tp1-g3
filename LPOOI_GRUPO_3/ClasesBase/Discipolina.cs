using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesBase
{
    public class Discipolina
    {
        private string dis_id;
        private string dis_nombre;
        private string dis_descripcion;

        public string Dis_descripcion
        {
            get { return dis_descripcion; }
            set { dis_descripcion = value; }
        }

        public string Dis_nombre
        {
            get { return dis_nombre; }
            set { dis_nombre = value; }
        }

        public string Dis_id
        {
            get { return dis_id; }
            set { dis_id = value; }
        }
    }
}
