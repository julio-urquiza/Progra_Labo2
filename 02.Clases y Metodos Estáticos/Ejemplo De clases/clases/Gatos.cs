using System;

namespace clases
{
    public class Gatos
    {
        public string color;
        public int cantPatas;

        public Gatos(string color,int cantpatas)
        {
            this.color = color;
            this.cantPatas = cantpatas;
        }
        public static bool operator ==(Gatos g1,Gatos g2)
        {
            if(g1.color==g2.color || g1.cantPatas==g2.cantPatas)
            {
                return true;
            }
            return false;
        }
        public static bool operator !=(Gatos g1,Gatos g2)
        {
            return !(g1 == g2);
        }
    }
}
