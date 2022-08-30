using System;
using Biblioteca;
namespace Vistas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string cadena;
            string cadenaWhile;
            Cuenta nuevaCuenta = new Cuenta("Julio", 35);
            Console.WriteLine("{0},{1}",nuevaCuenta.titular,nuevaCuenta.cantidad);
            do
            {
                Console.WriteLine("Ingrese mostrar, ingresar, o retirar");
                cadena = Console.ReadLine();
                switch (cadena)
                {
                    case "mostrar":
                        Console.WriteLine(nuevaCuenta.MostrarDatosCuenta());
                        break;
                    case "ingresar":
                        nuevaCuenta.Ingresar(1500.2m);
                        break;
                    case "retirar":
                        nuevaCuenta.Retirar(20m);
                        break;
                    default:
                        break;
                }
                Console.WriteLine("Desea seguir operando?:");
                cadenaWhile=Console.ReadLine();
            } while (cadenaWhile=="si");




            Console.ReadLine();
        }
    }
}
