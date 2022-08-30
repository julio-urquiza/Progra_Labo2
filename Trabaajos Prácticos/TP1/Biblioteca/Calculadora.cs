using System;

namespace Biblioteca
{
    public static class Calculadora
    {
        private static char ValidarOperador(char operador)
        {
            char retorno='+';
            if(operador == '-' || operador== '+' || operador == '/' || operador== '*')
            {
                retorno=operador;
            }
            return retorno;
        }
        public static double Operar(Operando nun1,Operando nun2,char operador)
        {
            double retorno=0;
            switch(ValidarOperador(operador))
            {
                case '+': retorno = nun1 + nun2;
                    break;
                case '-': retorno = nun1 - nun2;
                    break;
                case '*': retorno = nun1 * nun2;
                    break;
                case '/': retorno = nun1 / nun2;
                    break;
            }
            return retorno;
        }

    }
}
