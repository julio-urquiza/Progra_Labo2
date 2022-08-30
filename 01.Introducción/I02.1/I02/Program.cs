using System;

namespace I02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero;
            Console.Write("Ingrese un numero mayor a cero: ");
            numero = int.Parse(Console.ReadLine());
           
            while (numero <= 0)
            {
                Console.Write("ERROR. ¡Reingresar número!: ");
                numero = int.Parse(Console.ReadLine());
            } 


            Console.WriteLine(Math.Pow(numero,3));
            Console.ReadLine();

        }
    }
}
