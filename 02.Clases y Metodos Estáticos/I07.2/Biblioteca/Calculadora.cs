using System;

namespace Biblioteca
{
    public static class Calculadora
    {
        public static double CalcularHipotenusa(double bases,double altura)
        {
            return Math.Sqrt(Math.Pow(bases,2)+Math.Pow(altura,2));
        }
    }
}
