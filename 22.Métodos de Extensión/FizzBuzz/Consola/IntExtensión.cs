using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consola
{
    public static class IntExtensión
    {
        public static string FizzBuzz(this int numero,string pepe)
        {
            string retorno=string.Empty;
            if(numero%3==0)
            {
                retorno += "Fizz";
            }
            if (numero%5==0)
            {
                retorno += "Buzz";
            }
            if(string.IsNullOrEmpty(retorno))
            {
                retorno = numero.ToString();
            }

            return retorno;
        }
    }
}
