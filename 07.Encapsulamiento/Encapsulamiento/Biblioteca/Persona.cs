using System;

namespace Biblioteca
{
    public enum Color
    {
        rojo,verde,auzl
    }
    public class Persona
    {
        private string nombre;
        private string apellido;
        private int edad;
        private Color color;

        private string[] dias = {"lunes","martes","miercoles"};

        public Persona(string nombre, string apellido, int edad,Color color)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.edad = edad;
            this.color= color;
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }
        public int Edad
        {
            get { return edad; }
            set { edad = value; }
        }

        public string this[int index]
        {
            get { return dias[index]; }
            set { dias[index] = value; }
        }
    }
}
