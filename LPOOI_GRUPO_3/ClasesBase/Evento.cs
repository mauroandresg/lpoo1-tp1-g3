using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesBase
{
    class Evento
    {
        public int Eve_ID { get; set; }
        public int Com_ID { get; set; } //ID de Competicion
        public int Atl_ID { get; set; } //ID de Atleta
        public string Eve_Estado { get; set; }
        public DateTime Eve_HoraInicio { get; set; }
        public DateTime Eve_HoraFin { get; set; }
    }
}
