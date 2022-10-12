using System;

namespace Biblioteca
{
    public class Pepinillo
    {
        public int cantidad;
        public string marca;

        public Pepinillo(int cantidad, string marca)
        {
            this.cantidad = cantidad;
            this.marca = marca;
        }
        public override string ToString()
        {
            return "hola que tal soy un pepinillo";
        }
    }
}
