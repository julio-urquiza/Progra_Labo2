using System;

namespace Biblioteca
{
    public class NombreInvalidoException:Exception
    {
        public NombreInvalidoException(string mensaje):base(mensaje)
        {

        }
        public NombreInvalidoException(string mensaje,Exception inner):base (mensaje,inner)
        {

        }
    }
}
