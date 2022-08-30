using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public static class Informes
    {
        public static Conductor CoductutorQueHizoMasKm(Conductor[] conductores)
        {
            int kilometros = int.MinValue;
            int acumulador;
            Conductor conductor2=null;
            foreach (Conductor conductor in conductores)
            {
                acumulador = 0;
                if (conductor is not null)
                {
                    foreach(Dia dia in conductor.Dias)
                    {
                        if(dia is not null)
                        {
                            acumulador+= dia.Kilometros;
                        }
                    }
                }
                if (acumulador>kilometros)
                {
                    kilometros = acumulador;
                    conductor2 = conductor;
                }
            }
            return conductor2;
        }


    }
}
