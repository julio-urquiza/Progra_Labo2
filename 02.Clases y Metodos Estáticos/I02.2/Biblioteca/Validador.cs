using System;

namespace Biblioteca
{
    public static class Validador
    {
        public static bool ValidarRespuesta(char caracter)
        {
            bool retorno=false;
            if(caracter== 's')
            {
                retorno = true;
            }
            return retorno;
        }
    }
}
