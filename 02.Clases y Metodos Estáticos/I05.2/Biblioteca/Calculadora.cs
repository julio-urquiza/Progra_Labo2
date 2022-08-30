using System;
using System.Text;

namespace Biblioteca
{
    public static class Calculadora
    {
        public static string TablasDeMultiplicar(int numero)
        {
            StringBuilder retorno= new StringBuilder();

            for (int i = 1; i <= 10; i++)
            {
                retorno.AppendLine($"{numero}*{i}={numero * i}");
            }
            return retorno.ToString();
        }
    }
}
