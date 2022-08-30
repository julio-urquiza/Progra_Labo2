using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Biografía:Publicacion
    {
        public Biografía(string nombre) : base(nombre)
        {
        }

        public Biografía(string nombre, int stock) : base(nombre, stock)
        {
        }

        public Biografía(string nombre, int stock, float importe) : base(nombre, stock, importe)
        {
        }

        protected override bool EsColor { get => false; }
        public override bool HayStock 
        { 
            get { return this.stock > 0; }
        }

        public static explicit operator Biografía(string nombre)
        {
            return new Biografía (nombre);
        }
    }
}
