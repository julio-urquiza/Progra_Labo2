using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Biblioteca
{
    internal class PuestoAtencion
    {
        public enum Puesto
        {
            caja1,caja2
        }
        private static int numeroActual;
        private Puesto puesto;

        public static int NumeroActual { get => numeroActual++; }

        private PuestoAtencion()
        {
            numeroActual = 0;
        }
        public PuestoAtencion(Puesto puesto):this()
        {
            this.puesto = puesto;
        }
        public bool Atender(Cliente cli)
        {
            if (cli is not null)
            {
                Thread.Sleep(3000);
                return true;
            }
            return false ;
        }
    }
}
