using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesBase
{
    public class Atleta : ClasesBase.IAtleta
    {
        private int atl_id;

        public int Atl_id
        {
            get { return atl_id; }
            set { atl_id = value; }
        }
        private string atl_dni;

        public string Atl_dni
        {
            get { return atl_dni; }
            set { atl_dni = value; }
        }

        private string atl_apellido;

        public string Atl_apellido
        {
            get { return atl_apellido; }
            set { atl_apellido = value; }
        }
        private string atl_nombre;

        public string Atl_nombre
        {
            get { return atl_nombre; }
            set { atl_nombre = value; }
        }
        private string atl_nacionalidad;

        public string Atl_nacionalidad
        {
            get { return atl_nacionalidad; }
            set { atl_nacionalidad = value; }
        }

        private char atl_genero;

        public char Atl_genero
        {
            get { return atl_genero; }
            set { atl_genero = value; }
        }

        private string atl_entrenador;

        public string Atl_entrenador
        {
            get { return atl_entrenador; }
            set { atl_entrenador = value; }
        }

        private double atl_altura;

        public double Atl_altura
        {
            get { return atl_altura; }
            set { atl_altura = value; }
        }

        private double atl_peso;

        public double Atl_peso
        {
            get { return atl_peso; }
            set { atl_peso = value; }
        }

        private DateTime atl_fechaNac;

        public DateTime Atl_fechaNac
        {
            get { return atl_fechaNac; }
            set { atl_fechaNac = value; }
        }
        private string atl_direccion;

        public string Atl_direccion
        {
            get { return atl_direccion; }
            set { atl_direccion = value; }
        }

        private string alt_email;

        public string Alt_email
        {
            get { return alt_email; }
            set { alt_email = value; }
        }
    }
}