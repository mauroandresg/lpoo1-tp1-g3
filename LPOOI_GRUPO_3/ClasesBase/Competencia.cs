﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesBase
{
    class Competencia
    {
        public int Com_ID { get; set; }
        public string Com_Nombre { get; set; }
        public string Com_Descripcion { get; set; }
        public DateTime Com_FechaInicio { get; set; }
        public DateTime Com_FechaFin { get; set; }
        public string Com_Estado { get; set; }
        public string Com_Organizador { get; set; }
        public string Com_Ubicacion { get; set; }
        public string Com_Sponsors { get; set; }
        public int Cat_ID { get; set; } //ID de Categoria
        public int Dis_ID { get; set; } //ID de Disciplina 
    }
}
