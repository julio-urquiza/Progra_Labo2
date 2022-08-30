using System;

namespace Biblioteca
{
    public static class Validador
    {
        public static bool Validar(int valor, int min, int max)
        {
            if(valor > min && valor < max)
            {
                return true;
            }
            return false;
        }

    }
}
