using System;

namespace Biblioteca
{
    public abstract class Persona
    {
        private string nombre;

        public Persona(string nombre)
        {
            this.nombre = nombre;
        }

        public string Nombre 
        {
            get { return this.nombre; }
            set { this.nombre = value; }
        }

    }
}
