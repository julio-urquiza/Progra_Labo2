using System;
using System.Collections.Generic;
using static System.Environment;

namespace Consola
{
    class Program
    {
        public delegate int DelegadoComparacion(string primerTexto, string segundoTexto);

        static void Main(string[] args)
        {
            // Borrar o agregar la primera barra para switchear entre las pruebas fijas y el ingreso de texto por consola. 
            //*
            string primerTexto = "Vive como si fueras a morir mañana; aprende como si el mundo fuera a durar para siempre.";
            // Cant. caracteres: 88, Cant. palabras: 17 , Cant. vocales: 34, Cant. signos puntuación: 2 
            string segundoTexto = "La vida es como montar en bicicleta; para mantener el equilibrio debes seguir moviéndote.";
            // Cant. caracteres: 89, Cant. palabras: 13, Cant. vocales: 35, Cant. signos puntuación: 2

            /*/
            Console.WriteLine("Ingrese el primer texto:");
            string primerTexto = Console.ReadLine();

            Console.WriteLine("Ingrese el segundo texto:");
            string segundoTexto = Console.ReadLine();
            //*/

            //DelegadoComparacion delegado= (cadena1, cadena2) => ContarPalabras(cadena1) - ContarPalabras(cadena2));

            Console.WriteLine($"{NewLine}1era Comparación - Texto con más caracteres:");
            Comparar(primerTexto,segundoTexto,(cadena1,cadena2)=> cadena1.Length-cadena2.Length);
            // Punto 2

            Console.WriteLine($"{NewLine}2da Comparación - Texto con más palabras:");
            Comparar(primerTexto, segundoTexto, (cadena1, cadena2) => ContarPalabras(cadena1) - ContarPalabras(cadena2));
            //Comparar(primerTexto,segundoTexto,delegado);
            ;
            // Punto 3

            Console.WriteLine($"{NewLine}3era Comparación - Texto con más vocales:");
            Comparar(primerTexto, segundoTexto,(cadena1,cadena2)=> ContarVocales(cadena1)-ContarVocales(cadena2));
            // Punto 4

            Console.WriteLine($"{NewLine}4ta Comparación - Texto con más signos de puntuación:");
            Comparar(primerTexto, segundoTexto, (cadena1, cadena2) => ContarSignosPuntuacion(cadena1) - ContarSignosPuntuacion(cadena2));
            // Punto 5
        }
        public static int ContarPalabras(string texto)
        {
            return texto.Split(' ', StringSplitOptions.RemoveEmptyEntries).Length;
        }
        public static void Comparar(string texto1,string texto2,DelegadoComparacion delegado)
        {
            int comparacion = delegado(texto1, texto2);
            //si el preimer texto es mayor a cero
            if (comparacion>0)
            {
                Console.WriteLine("el primer texto es mayor al segundo texto");
            }
            else if(comparacion<0)
            {
                Console.WriteLine("el primer texto es menor al segundo texto");
            }   
            else
            {
                Console.WriteLine("el primer texto es igual al segundo texto");
            }
        }
        public static int ContarVocales(string texto)
        {
            List<char> vocales = new List<char>()
            {
                'a', 'á', 'A', 'Á', 'e', 'é', 'E', 'É',
                'i', 'í', 'I', 'Í', 'o', 'ó', 'O', 'Ó',
                'u', 'ú', 'U', 'Ú'
            };

            return ContarCaracteres(texto, vocales);
        }

        public static int ContarSignosPuntuacion(string texto)
        {
            List<char> signosPuntuacion = new List<char>()
            {
                '.', ';', ','
            };

            return ContarCaracteres(texto, signosPuntuacion);
        }

        public static int ContarCaracteres(string texto, List<char> caracteres)
        {
            int cantidadCaracteres = 0;

            foreach (char caracter in texto)
            {
                if (caracteres.Contains(caracter))
                {
                    cantidadCaracteres++;
                }
            }

            return cantidadCaracteres;
        }
    }
}
