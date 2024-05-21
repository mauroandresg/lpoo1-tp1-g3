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
        private string apellido;
        private string nombre;
        private string nacionalidad;
        private string entrenador;
        private char genero;
        private float altura;
        private float peso;
        private DateTime fechaNac;
        private string direccion;
        private string email;

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

        private string atl_email;

        public string Atl_email
        {
            get { return atl_email; }
            set { atl_email = value; }
        }
        public Atleta(int id, string dni, string apellido, string nombre, string nacionalidad, string entrenador, char genero, float altura, float peso, DateTime fechaNac, string direccion, string email)
        {
            atl_id = id;
            atl_apellido = apellido;
            atl_nombre = nombre;
            atl_nacionalidad = nacionalidad;
            atl_entrenador = entrenador;
            atl_genero = genero;
            atl_altura = altura;
            atl_peso = peso;
            atl_fechaNac = fechaNac;
            atl_direccion = direccion;
            atl_email = email;
        }
        public Atleta()
        {

        }
    }
}