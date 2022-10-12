using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bioblioteca
{
    public class Profesor : Persona
    {
        public Profesor(string nombre, string apellido, long documento, int id) : base(nombre, apellido, documento, id)
        {
        }
    }
}
