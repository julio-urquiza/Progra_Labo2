using System;

namespace Biblioteca
{
    public static class CalculadoraDeArea
    {
        public static double CalcularAreaCuadrado(double longitudLado) 
        {
            return Math.Pow(longitudLado,2);
        }

        public static double CalcularAreaTriangulo(double bases, double altura) 
        {
            
            return (bases*altura)/2;
        }

        public static double CalcularAreaCirculo(double radio) 
        {
            return Math.Pow(radio,2)*Math.PI;
        }
    }
}
