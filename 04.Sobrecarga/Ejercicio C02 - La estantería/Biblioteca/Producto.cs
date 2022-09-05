using System;

namespace Biblioteca
{
    public class Producto
    {
        private string codigoDeBarra;
        private string marca;
        private float precio;

        public Producto(string marca, string codigoDeBarra, float precio)
        {
            this.marca = marca;
            this.codigoDeBarra = codigoDeBarra;
            this.precio = precio;
        }

        public static explicit operator string(Producto p)
        {
            return p.codigoDeBarra;
        }
        public string GetMarca()
        {
            return this.marca;
        }
        public float GetPrecio()
        {
            return this.precio;
        }
        public static string MostrarProducto(Producto p)
        {
            return String.Format("Marca :{0}, Precio:{1}, codigo de barras_{2} ", p.marca, p.precio, p.codigoDeBarra);
        }
        public static bool operator ==(Producto p1,string marca)
        {
            return p1.marca == marca;
        }
        public static bool operator !=(Producto p1, string marca)
        {
            return !(p1==marca);
        }
        public static bool operator ==(Producto p1,Producto p2)
        {
            if (p1 is not null && p2 is not null)
            {
                return p1.marca == p2.marca && p1.codigoDeBarra==p2.codigoDeBarra;
            }
            return false;
        }
        public static bool operator !=(Producto p1, Producto p2)
        {
            return !(p1==p2);
        }
    }
}
