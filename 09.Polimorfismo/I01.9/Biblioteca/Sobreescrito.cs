using System;

namespace Biblioteca
{
    public abstract class Sobreescrito
    {
        private string miAtributo;

        protected abstract string MiAtributo { get; }

        public Sobreescrito()
        {
            this.miAtributo = "Probar abstractos";
        }
        public abstract string MiMetodo();
     
        public override string ToString()
        {
            return "¡Este es mi método ToString sobrescrito!";
        }
        public override bool Equals(object obj)
        {
            return this.GetType().Name== obj.GetType().Name;
        }
        public override int GetHashCode()
        {
            return 1142510181;
        }

    }
}
