using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Tenista:Persona
    {
        private int edad;

        public Tenista(string nombre,int edad) : base(nombre)
        {
            this.edad = edad;
        }
    }
}
