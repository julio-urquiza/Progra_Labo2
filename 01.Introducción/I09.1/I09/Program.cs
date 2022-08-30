using System;

namespace I09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int altura;
            Console.Write("indique la altura: ");
            altura = int.Parse(Console.ReadLine());

            for (int i = 0; i < altura; i++)
            {
                Console.Write("    ");
                for (int j = altura-i; j >0 ; j--)
                {
                    Console.Write(' ');
                }

                Console.Write('*');
                for (int j = 0; j < i * 2; j++)
                {
                    Console.Write('*');
                }
                Console.Write("\n");
            }
            Console.ReadLine();
        }
    }
}
