using System;
using Biblioteca;
namespace Vistas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            VehiculoTerrestre vehiculo = new VehiculoTerrestre(4, 4, Colores.Gris);
            Moto moto = new Moto(2, 0, Colores.Rojo, 240);
            Camion camion = new Camion(6, 2, Colores.Blanco, 12, 300000);

            Mostrar(vehiculo);
            Mostrar(moto);
            Mostrar(camion);    




            Console.ReadLine();
        }
        public static void Mostrar (VehiculoTerrestre vehiculo)
        {
            Console.WriteLine($"Esto es un {vehiculo.GetType().Name}");
        }
    }
}
