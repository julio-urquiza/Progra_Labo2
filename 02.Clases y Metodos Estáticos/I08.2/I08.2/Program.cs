//Crear un método estático que reciba una fecha y calcule el número de días que pasaron 
//desde esa fecha hasta la fecha actual. Tener en cuenta los años bisiestos.
//Pedir por consola la fecha de nacimiento de una persona (día, mes y año) y calcule el 
//número de días vividos por esa persona hasta la fecha actual utilizando el método 
//desarrollado anteriormente.
//Ayudarse con las funcionalidades del tipo DateTime para resolver el ejercicio.

using System;
using Biblioteca;
namespace Vistas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime fecha = new DateTime();

            //fecha = DateTime.Parse(Console.ReadLine());
            do
            {
                Console.WriteLine("ingrese una fecha de nacimiento: ");
            } while (!DateTime.TryParse(Console.ReadLine(), out fecha));
            
            Console.Write("la fecha es : ");
            Console.WriteLine(fecha.ToShortDateString());
            Console.WriteLine(Fechas.CalcularDias(fecha));


            Console.ReadLine();
        }
    }
}
