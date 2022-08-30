/*
Realizar un programa que permita realizar operaciones matemáticas simples 
(suma, resta, multiplicación y división).
Crear una clase llamada Calculadora que posea dos métodos estáticos (de clase):
Calcular (público): Recibirá tres parámetros, el primer operando, el segundo operando y
la operación matemática. El método devolverá el resultado de la operación.
Validar (privado): Recibirá como parámetro el segundo operando. Este método se debe 
utilizar sólo cuando la operación elegida sea la DIVISIÓN. Este método devolverá true 
si el operando es distinto de cero.
Se le debe pedir al usuario que ingrese dos números y la operación que desea 
realizar (ingresando el caracter +, -, * o /).
El usuario decidirá cuándo finalizar el programa.
*/
using System;

namespace Bibioteca
{
    public static class Calculadora
    {
        public static string Calcular(float numero1,float numero2,char operacion)
        {
            string retorno="ERROR";
            switch (operacion)
            {
                case '+':
                    retorno = $"{numero1 + numero2}";
                    break;
                case '-':
                    retorno = $"{numero1 - numero2}";
                    break;
                case '*':
                    retorno = $"{numero1 * numero2}";
                    break;
                case '/':
                    if (Validar(numero2))
                    {
                        retorno = $"{numero1 / numero2}";
                    }
                    break;
            }
            return retorno;
        }
        private static bool Validar(float numero)
        {
            bool retorno=false;
            if(numero!=0)
            {
                retorno=true;
            }
            return retorno;
        }
    }


}
