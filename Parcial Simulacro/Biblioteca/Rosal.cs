using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Rosal: Planta
    {
        public enum Color
        {
            Roja, Blanca, Amarilla, Rosa, Azul
        }

        private Color florColor;


        public Rosal(string nombre, int tamanio,Color flor ):base(nombre,tamanio)
        {
            this.florColor= flor;
        }
        public Rosal(string nombre, int tamanio) : this(nombre, tamanio,Color.Rosa)
        {
        }
        
        public override bool TieneFlores { get=>true; }
        public override bool TieneFruto { get=>false; }


        public override string ResumenDeDatos()
        {
            StringBuilder retorno= new StringBuilder();
            retorno.AppendLine(base.ResumenDeDatos());
            retorno.AppendLine(this.florColor.ToString());
            return retorno.ToString();
        }


    }
}
