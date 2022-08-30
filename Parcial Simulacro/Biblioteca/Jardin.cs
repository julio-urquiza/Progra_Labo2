using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Jardin
    {
        public enum Tipo
        {
            Terroso,Arenoso
        }

        private int espacioTotal;
        private List<Planta> plantas;
        private static Tipo suelo;
        
        public static Tipo TipoSuelo { set=>Jardin.suelo=value; }
        static Jardin()
        {
            Jardin.suelo = Jardin.Tipo.Terroso;
        }
        private Jardin()
        {
            this.plantas = new List<Planta>();
        }
        public Jardin(int espacioTotal):this()
        {
            this.espacioTotal = espacioTotal;
        }
        
        private int EspacioTotal()
        {
            int acumulador=0;
            foreach(Planta planta in plantas)
            {
                acumulador += planta.Tamanio;
            }
            return acumulador;
        }
        private int EspacioTotal(Planta planta)
        {
            return this.EspacioTotal() + planta.Tamanio;
        }
        public static bool operator +(Jardin jardin,Planta planta)
        {
            if(jardin.EspacioTotal(planta)<=jardin.espacioTotal && planta is not null && jardin is not null)
            {
                jardin.plantas.Add(planta);
                return true;
            }
            return false;
        }
        public override string ToString()
        {
            StringBuilder retorno = new StringBuilder();
            retorno.AppendLine($"Composicion Del jardin: {Jardin.suelo}");
            retorno.AppendLine($"Espacio ocupado: {this.EspacioTotal()} de {this.espacioTotal}");
            foreach(Planta planta in plantas)
            {
                retorno.AppendLine(planta.ResumenDeDatos());
            }
            return retorno.ToString();
        }



    }
}
