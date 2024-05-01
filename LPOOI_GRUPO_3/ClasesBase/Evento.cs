using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesBase
{
    public class Evento
    {
        public int Eve_ID { get; set; }
        public int Com_ID { get; set; } // Association with Competencia
        public int Atl_ID { get; set; } // Association with Atleta
        public string Eve_Estado { get; set; }
        public DateTime Eve_HoraInicio { get; set; }
        public DateTime Eve_HoraFin { get; set; }
    }
}
