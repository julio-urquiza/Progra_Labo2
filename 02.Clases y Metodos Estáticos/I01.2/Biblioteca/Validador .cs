using System;

namespace Biblioteca
{
    public class Validador
    {
        /// <summary>
        /// Valida que el la variable Valor este entre el rango del minimo y maximo
        /// </summary>
        /// <param name="valor"></param>
        /// <param name="min"></param>
        /// <param name="max"></param>
        /// <returns>devuelve un bool </returns>
        public static bool Validar(int valor, int min, int max)
        {
            bool retorno=false;
            if (min < max && valor >= max && valor <= min)
            {
                retorno = true;
            }
            return retorno;
        }
    }
}
