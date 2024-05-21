using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesBase
{
    public class Atleta
    {
        private int atl_id;
        private string atl_dni;
        private string atl_apellido;
        private string atl_nombre;
        private string atl_nacionalidad;
        private string atl_entrenador;
        private char atl_genero;
        private double atl_altura;
        private double atl_peso;
        private DateTime atl_fechaNac;
        private string atl_direccion;
        private string atl_email;

        public string Atl_email
        {
            get { return atl_email; }
            set { atl_email = value; }
        }

        public string Atl_direccion
        {
            get { return atl_direccion; }
            set { atl_direccion = value; }
        }

        public DateTime Atl_fechaNac
        {
            get { return atl_fechaNac; }
            set { atl_fechaNac = value; }
        }

        public double Atl_peso
        {
            get { return atl_peso; }
            set { atl_peso = value; }
        }

        public double Atl_altura
        {
            get { return atl_altura; }
            set { atl_altura = value; }
        }

        public char Atl_genero
        {
            get { return atl_genero; }
            set { atl_genero = value; }
        }

        public string Atl_entrenador
        {
            get { return atl_entrenador; }
            set { atl_entrenador = value; }
        }

        public string Atl_nacionalidad
        {
            get { return atl_nacionalidad; }
            set { atl_nacionalidad = value; }
        }

        public string Atl_nombre
        {
            get { return atl_nombre; }
            set { atl_nombre = value; }
        }

        public string Atl_apellido
        {
            get { return atl_apellido; }
            set { atl_apellido = value; }
        }

        public string Atl_dni
        {
            get { return atl_dni; }
            set { atl_dni = value; }
        }

        public int Atl_id
        {
            get { return atl_id; }
            set { atl_id = value; }
        }
    }
}