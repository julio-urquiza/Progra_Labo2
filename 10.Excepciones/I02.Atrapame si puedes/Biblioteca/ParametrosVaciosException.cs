using System;

namespace Biblioteca
{
    public class ParametrosVaciosException : Exception
    {
        public ParametrosVaciosException() : base("Los parametros estan vacios")
        {
        }
    }
}
