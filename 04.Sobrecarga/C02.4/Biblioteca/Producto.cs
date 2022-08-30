using System;
using System.Text;
namespace Biblioteca
{
    public class Producto
    {
        private string marca;
        private string codigoDeBarra;
        private float precio;

        public Producto(string marca, string codigoDeBarra, float precio)
        {
            this.marca = marca;
            this.codigoDeBarra = codigoDeBarra;
            this.precio = precio;
        }
        public string GetMarca()
        {
            return this.marca;
        }
        public float GetPrecio()
        {
            return this.precio;
        }
        public string GetCodigoDeBarra()
        {
            return this.codigoDeBarra;
        }
        public static string Mostrarproducto(Producto p)
        {
            return $"Marca {p.GetMarca()} - Codigo {p.GetCodigoDeBarra()} - ${p.GetPrecio()}";
        }

        public static explicit operator string(Producto p)
        {
            return p.GetCodigoDeBarra();
        }
        public static bool operator ==(Producto p1, Producto p2)
        {
            if(p1 is not null && p2 is not null)
            {
                return p1.GetCodigoDeBarra() == p2.GetCodigoDeBarra();
            }
            return false;
        }
        public static bool operator !=(Producto p1, Producto p2)
        {
            return !(p1 == p2);
        }
        public static bool operator ==(Producto p,string marca)
        {
            return p.GetMarca()==marca;
        }
        public static bool operator !=(Producto p, string marca)
        {
            return !(p==marca);
        }




    }
}
