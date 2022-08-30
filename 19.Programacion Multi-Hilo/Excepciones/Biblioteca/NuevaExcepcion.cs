using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{

    public class NuevaExcepcion : Exception
    {
        public NuevaExcepcion(string message) : base(message)
        {
        }

        public NuevaExcepcion(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
