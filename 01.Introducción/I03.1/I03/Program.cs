using System;

namespace I03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Mostrar por pantalla todos los números primos que haya hasta el número que ingrese el usuario por consola.
            //Validar que el dato ingresado por el usuario sea un número.
            //Volver a pedir el dato hasta que sea válido o el usuario ingrese "salir".
            //Si ingresa "salir", cerrar la consola.
            //Al finalizar, preguntar al usuario si desea volver a operar.Si la respuesta es afirmativa, iterar.De lo contrario, cerrar la consola.

            int numero;
            int contador;
            string cadena;
            bool resultado;
            do
            {
                do
                {
                    Console.WriteLine("ingrese un numero: ");
                    cadena = Console.ReadLine();
                    resultado = int.TryParse(cadena, out numero);

                } while ( !(resultado || string.Equals(cadena, "salir")) );

                if (resultado)
                {
                    for (int i = 1; i <= numero; i++)
                    {
                        contador = 0;
                        for (int j = 1; j <= i; j++)
                        {
                            if (i % j == 0)
                            {
                                contador++;
                            }
                        }
                        if (contador <= 2)
                        {
                            Console.WriteLine(i);
                        }

                    }
                }
                Console.WriteLine("Desea volver a operar:");
            }while (false);
            Console.ReadLine();
        }
        
    }
}
