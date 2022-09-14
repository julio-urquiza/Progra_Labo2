using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Biblioteca
{
    public enum Puesto
    {
        Caja1,Caja2
    }
    public class PuestoAtencion
    {
        private static int numeroActual;
        private Puesto puesto;

        static PuestoAtencion()
        {
            PuestoAtencion.numeroActual = 0;
        }

        public PuestoAtencion(Puesto puesto)
        {
            this.puesto = puesto;
        }

        public int NumeroActual
        {
            get { return numeroActual++; }
        }
        public bool Atender(Cliente cli)
        {
            bool retorno = false;
            if(cli is not null)
            {
                Thread.Sleep(5000);
                retorno=true;
            }
            return retorno;
        }
    }
}
