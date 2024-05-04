using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesBase
{
    public class Disciplina
    {
        private string dis_ID;
        public string Dis_ID
        {
            get { return dis_ID; }
            set { dis_ID = value; }
        }

        private string dis_Nombre;
        public string Dis_Nombre
        {
            get { return dis_Nombre; }
            set { dis_Nombre = value; }
        }

        private string dis_Descripcion;
        public string Dis_Descripcion
        {
            get { return dis_Descripcion; }
            set { dis_Descripcion = value; }
        }
    }
}
