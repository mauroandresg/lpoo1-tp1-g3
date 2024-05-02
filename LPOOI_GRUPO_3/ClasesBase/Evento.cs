using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesBase
{
    public class Evento
    {
        private int eve_id;
        private string eve_estado;
        private System.DateTime eve_horaInicio;

        public System.DateTime Eve_horaInicio
        {
            get { return eve_horaInicio; }
            set { eve_horaInicio = value; }
        }
        private System.DateTime eve_horaFin;

        public System.DateTime Eve_horaFin
        {
            get { return eve_horaFin; }
            set { eve_horaFin = value; }
        }

        public string Eve_estado
        {
            get { return eve_estado; }
            set { eve_estado = value; }
        }

        public int Eve_id
        {
            get { return eve_id; }
            set { eve_id = value; }
        }

        private int atl_id;
        private int com_id;
    }
}
