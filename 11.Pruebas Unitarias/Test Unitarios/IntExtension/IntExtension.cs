using System;

namespace Biblioteca
{
    public static class IntExtension
    {
        public static string FizzBuzz(this int numero)
        {
            string retorno = string.Empty;
            if (numero % 3 == 0)
            {
                retorno += "Fizz";
            }
            if (numero % 5 == 0)
            {
                retorno += "Buzz";
            }
            if (string.IsNullOrEmpty(retorno))
            {
                retorno = numero.ToString();
            }

            return retorno;
        }
    }
}
