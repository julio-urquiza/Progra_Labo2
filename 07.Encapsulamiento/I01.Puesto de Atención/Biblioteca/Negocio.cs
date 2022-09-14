using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Negocio
    {
        private PuestoAtencion caja;
        private Queue<Cliente> clientes;
        private string nombre;

        public int ClientesPendientes
        {
            get { return this.clientes.Count; }
        }
        public Cliente Cliente
        {
            get 
            { 
                Cliente cliente=null;
                if(ClientesPendientes>0)
                {
                    cliente=this.clientes.Dequeue(); 
                }
                return cliente;
            }
            set { _ = this + value; }
        }
        private Negocio()
        {
            this.clientes=new Queue<Cliente>();
            this.caja = new PuestoAtencion(Puesto.Caja1);
        }

        public Negocio(string nombre):this()
        {
            this.nombre = nombre;
        }
        public static bool operator ==(Negocio n,Cliente c)
        {
            bool retorno = false;
            if(c is not null )
            {
                retorno = n.clientes.Contains(c);
            }
            return retorno;
        }
        public static bool operator !=(Negocio n, Cliente c)
        {
            return !(n==c);
        }
        public static bool operator ~(Negocio n)
        {
            bool retorno=false;
            if(n.caja.Atender(n.Cliente))
            {
                retorno=true;
            }
            return retorno;
        }
        public static bool operator +(Negocio n, Cliente c)
        {
            bool retorno=false;
            if(c is not null && n!=c)
            {
                n.clientes.Enqueue(c);
                retorno=true;
            }
            return retorno;
        }
    }
}
