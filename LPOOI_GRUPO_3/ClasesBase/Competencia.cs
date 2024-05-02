using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesBase
{
    public class Competencia
    {
        private int com_id;
        private string com_nombre;
        private string com_descripcion;
        private System.DateTime com_fechaInicio;
        private System.DateTime com_fechaFin;
        private string com_estado;
        private string com_organizador;
        private string com_ubicacion;
        private string com_sponsor;
        private int cat_id;

        public int Cat_id
        {
            get { return cat_id; }
            set { cat_id = value; }
        }
        private int dis_id;

        public string Com_sponsor
        {
            get { return com_sponsor; }
            set { com_sponsor = value; }
        }

        public string Com_ubicacion
        {
            get { return com_ubicacion; }
            set { com_ubicacion = value; }
        }

        public string Com_organizador
        {
            get { return com_organizador; }
            set { com_organizador = value; }
        }

        public string Com_estado
        {
            get { return com_estado; }
            set { com_estado = value; }
        }

        public System.DateTime Com_fechaFin
        {
            get { return com_fechaFin; }
            set { com_fechaFin = value; }
        }

        public System.DateTime Com_fechaInicio
        {
            get { return com_fechaInicio; }
            set { com_fechaInicio = value; }
        }

        public string Com_descripcion
        {
            get { return com_descripcion; }
            set { com_descripcion = value; }
        }

        public string Com_nombre
        {
            get { return com_nombre; }
            set { com_nombre = value; }
        }

        public int Com_id
        {
            get { return com_id; }
            set { com_id = value; }
        }
    }
}
