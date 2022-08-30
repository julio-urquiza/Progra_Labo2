using System;
using System.Collections;
using System.Collections.Generic;


namespace clase05
{
    internal class Program
    {

        public static int Comparar(int a, int v)
        {
            return v - a;
        }
        static void Main(string[] args)
        {
            #region ordenar listar
            List<int> list = new List<int>()
            {
                3,4,5,45,76,12,7,
            };
            Console.WriteLine("mustra la lista sin ordenar");
            foreach(int i in list)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("lista ordenada");
            list.Sort();
            foreach (int i in list)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("lista ordenada alrevez");
            list.Sort(Comparar);
            foreach (int i in list)
            {
                Console.WriteLine(i);
            }
            #endregion


            #region stack
            Stack<int> numero= new Stack<int>();
            numero.Push(1);
            numero.Push(2);
            numero.Push(3);
            numero.Push(4);
            numero.Push(5);
            numero.Push(6);

            numero.Pop();
            numero.Peek();

            foreach (char c in numero)
            {
                Console.WriteLine(c);
            }
            #endregion


            #region Queue
            Queue<string> cola = new Queue<string>();
            cola.Enqueue("pablo");
            cola.Enqueue("roberto");
            cola.Enqueue("julio");

            foreach(string s in cola)
            {
                Console.WriteLine(s);
            }

            Console.WriteLine($"atendiendo a :{cola.Dequeue()}");//elimina el primero que le sale
            Console.WriteLine($"este es :{cola.Peek()}");//te trae el primer que sale si hacerle nada

            #endregion


            #region Dictionary
            Dictionary<string, string> comidas = new Dictionary<string, string>();
            comidas.Add("taco", "mexico");
            comidas.Add("Mole", "mexico");
            comidas.Add("ceviche", "peru");
            comidas.Add("choripan", "argentina");

            foreach(KeyValuePair<string,string> item in comidas)
            {
                Console.WriteLine($"la comida {item.Key} es de {item.Value}");
            }
            foreach(string item in comidas.Keys)
            {
                Console.WriteLine(item);
            }





            #endregion


            #region List-GENERICA- esta si la usamos
            List<string> mascotas = new List<string>()
            {
                "juan","lalo","fifi"
            };
            mascotas.Add("pipo");
            mascotas.Add("ninga");
            mascotas.Add("Bola de nieve");

            Console.WriteLine($"la mascota es {mascotas[2]}");

            foreach(string s in mascotas)
            {
                Console.WriteLine($"Forech- la mascota es {s}");
            }
            for(int i = 0; i < mascotas.Count; i++)
            {
                Console.WriteLine($"Forech- la mascota es {mascotas[i]}");

            }
            mascotas.Insert(1, "pepe");

            Console.WriteLine($"la posicion de pipo es {mascotas.IndexOf("pipo")}");
            mascotas.Remove("pipo");

            #endregion


            #region ArrayList-NO GENERICA- no la usamos
            ArrayList arrayList = new ArrayList();
            arrayList.Add(15);
            arrayList.Add("pepe");
            arrayList.Add(false);
            #endregion




            Console.ReadLine();

        }
    }
}
