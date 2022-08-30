using System;
using Biblioteca;
namespace Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cuenta miCuenta =new Cuenta("Julio Cesar Urquiza",10000f);

            miCuenta.ingresar(5000);

            Console.WriteLine(miCuenta.mostrar());

            miCuenta.ingresar(-5000);

            Console.WriteLine(miCuenta.mostrar());

            miCuenta.retirar(10000);

            Console.WriteLine(miCuenta.mostrar());

            miCuenta.retirar(5001);

            Console.WriteLine(miCuenta.mostrar());


            Console.ReadLine();
        }
    }
}
