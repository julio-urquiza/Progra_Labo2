using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bioblioteca
{
    public class Administrador : Persona
    {
        
        public Administrador(string nombre, string apellido, long documento, int id) : base(nombre, apellido, documento, id)
        {
        }
    }
}
