using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Vendedor
    {
        private string nombre;
        private List<Publicacion> ventas;


        private Vendedor()
        {
            this.ventas = new List<Publicacion>();
        }
        public Vendedor(string nombre) : this()
        {
            this.nombre = nombre;
        }


        public static string ObtenerInformacionDeVentas(Vendedor vendedor)
        {
            if(vendedor != null)
            {
                float ganancias = 0;
                StringBuilder retorno=new StringBuilder();
                retorno.AppendLine($"NOMBRE: {vendedor.nombre}");
                foreach(Publicacion publicacion in vendedor.ventas)
                {
                    retorno.AppendLine("------------------------------------");
                    retorno.Append("PUBLICACION: ");
                    retorno.AppendLine(publicacion.ObetenerInformacion());
                    ganancias += publicacion.Importe;
                }
                retorno.AppendLine($"Ganancia Total: {ganancias}");
                return retorno.ToString();
            }
            return "vendedor no válido";
        }
        public static bool operator +(Vendedor vendedor,Publicacion publicacion)
        {
            if(publicacion != null && vendedor !=null && publicacion.HayStock)
            {
                vendedor.ventas.Add(publicacion);
                publicacion.Stock--;
                return true;
            }
            return false;
        }
       


    }
}
