using System;

namespace I06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int año;
            Console.WriteLine("ingrese año: ");
            año= int.Parse(Console.ReadLine());

            if (año%4==0)
            { 
                if(año%100==0)
                {
                    if(año%400==0)
                    {
                        Console.WriteLine("el año {0} es bisiesto", año);
                    }
                }
                else
                { 
                    Console.WriteLine("el año {0} es bisiesto",año);
                }
               
            }
            Console.ReadLine();

        }
    }
}
