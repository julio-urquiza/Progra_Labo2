using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    internal class Negocio
    {
        private PuestoAtencion caja;
        Queue<Cliente> clientes;
        private string nombre;

        public Queue<Cliente> Clientes { get => clientes; set => clientes = value; }

        public Negocio()
        {
            this.caja = new PuestoAtencion(PuestoAtencion.Puesto.caja1);
            this.clientes=new Queue<Cliente>();
        }
        public Negocio(string nombre):this()
        {
            this.nombre = nombre;
        }
        public static bool operator ==(Negocio n,Cliente c)
        {
            return false;
        }
        public static bool operator !=(Negocio n,Cliente c)
        {
            return !(n == c);
        }
        public static bool operator +(Negocio n,Cliente c)
        {
            return false; 
        }

    }
}
