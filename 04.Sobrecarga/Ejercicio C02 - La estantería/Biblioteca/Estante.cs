using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


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
        public Estante(int capacidad,int ubicacion):this(capacidad)
        {
            this.ubicacionEstante=ubicacion;
        }
        public Producto[] GetProductos()
        {
            return this.productos;
        }
        public static string MostrarEstante(Estante e)
        {
            StringBuilder retorno=new StringBuilder();
            retorno.AppendFormat("Ubicaion de estante: {0}\n", e.ubicacionEstante);
            foreach(Producto p in e.productos)
            {
                if(p is not null)
                {
                    retorno.AppendLine(Producto.MostrarProducto(p));
                }
            }
            return retorno.ToString();
        }
        public static bool operator ==(Estante e, Producto p)
        {
            //e.GetProductos().Contains(p);
            foreach(Producto producto in e.productos)
            {
                if(producto==p)
                {
                    return true;
                }
            }
            return false;
        }

        public static bool operator !=(Estante e,Producto p)
        {
            return !(e==p);
        }
        public static bool operator +(Estante e,Producto p)
        {
            if(e!=p)
            {
                for (int i = 0; i < e.productos.Length; i++)
                {
                    if (e.productos[i] is null)
                    {
                        e.productos[i] = p;
                        return true;
                    }
                }
            }
            return false;
        }
        public static Estante operator -(Estante e,Producto p)
        {
            for(int i=0;i < e.productos.Length;i++)
            {
                if(e.productos[i]==p)
                {
                    e.productos[i]= null;
                    break;
                }
            }
            return e;
        }

    }
}
