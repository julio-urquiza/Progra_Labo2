using System;

namespace Biblioteca
{
    public static class Operaciones
    {
        public static int Factorial (int numero)
        {
            int retorno = 1;
            if (numero != 0)
            {
                for (int i = 1; i <= numero; i++)
                {
                    retorno *= i;
                }
            }
            return retorno;
        }
    }
}
