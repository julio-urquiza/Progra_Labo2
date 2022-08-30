using System;
using System.Text;


namespace Biblioteca
{
    public class Boligrafo
    {
        const short cantidadTintaMaxima=100;
        private ConsoleColor color;
        private short tinta;

        public Boligrafo(short tinta, ConsoleColor color)
        {
            this.tinta = tinta;
            this.color = color;
        }
        public short GetTinta()
        { 
            return this.tinta; 
        }
        public ConsoleColor GetColor()
        {
            return this.color;
        }
        private void SetTinta(short tinta)
        {
            short cantidadTinta=this.tinta;
            cantidadTinta += tinta;
            if(cantidadTinta>=0 && cantidadTinta<=Boligrafo.cantidadTintaMaxima)
            {
                this.tinta=cantidadTinta;
            }
        }
        public void SetTintapublic(short tinta)
        { this.SetTinta(tinta); }
        public void Recargar()
        {
            this.SetTinta((short)(Boligrafo.cantidadTintaMaxima-this.tinta));
        }
        public bool Pintar(short gasto,out string dibujo)
        {
            bool retorno = false;
            StringBuilder sb = new StringBuilder();
            int cantidadTinta = this.tinta;
            for (int i = 1; i <= gasto && i <= cantidadTinta; i++)
            { 
                this.SetTinta(-1);
                sb.Append("*");
                retorno=true;
            }
            dibujo = sb.ToString();
            return retorno;
        }
    }
}
