using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class MiClase
    {
        private string nombre;

        public MiClase(string nombre)
        {
            this.Nombre = nombre;
        }

        public string Nombre 
        {
            get { return nombre; }
            set 
            { 
                if(string.IsNullOrWhiteSpace(value))
                {
                    throw new NombreInvalidoException("el nombre no puede ser solo espacios");
                }
                nombre = value;  
            } 
        }
    }
}
