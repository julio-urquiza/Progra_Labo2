using System;
using System.Text;
namespace Biblioteca
{
    public class Estante
    {
        private Producto[] productos;
        private int ubicacionEstante;

        private Estante(int capacidad)
        {
            this.productos = new Producto[capacidad];
        }
        public Estante(int capacidad, int ubicacion) : this(capacidad)
        {
            this.ubicacionEstante = ubicacion;
        }
        public Producto[] GetProductos()
        {
            return this.productos;
        }
        public static string MostrarEstante(Estante e)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Ubicación del estante: {e.ubicacionEstante}");
            foreach (Producto producto in e.productos)
            {
                sb.AppendLine(Producto.Mostrarproducto(producto));
            }
            return sb.ToString();
        }
        public static bool operator ==(Estante e, Producto p)
        {
            bool retorno = false;
            foreach(Producto producto in e.productos)
            {
                if(producto==p)
                {
                    retorno = true;
                }
            }
            return retorno;
        }
        public static bool operator !=(Estante e, Producto p)
        {
            return !(e == p);
        }
        public static bool operator +(Estante e, Producto p)
        {
            bool retorno = false;
            if(e!=p)
            {
                for (int i = 0; i < e.productos.Length; i++)
                {
                    if(e.productos[i] is null)
                    {
                        e.productos[i] = p;
                        retorno = true;
                    }
                }
            }
            return retorno;
        }
        public static Estante operator -(Estante e, Producto p)
        {
            if(e==p)
            {
                for(int i=0;i<e.productos.Length;i++)
                {
                    if(e.productos[i]==p)
                    {
                        e.productos = null;
                    }
                }
            }
            return e; 
        }









    }
}
