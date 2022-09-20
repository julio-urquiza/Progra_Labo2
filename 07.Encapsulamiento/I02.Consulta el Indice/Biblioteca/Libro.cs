using System;
using System.Collections.Generic;

namespace Biblioteca
{
    public class Libro
    {
        private List<string> paginas;

        public Libro()
        {
            this.paginas=new List<string>();
        }

        public string this[int i]
        {
            get
            {
                string retorno=string.Empty;
                if (i >= 0 && i < this.paginas.Count)
                {
                    retorno=paginas[i];
                }
                return retorno;
            }
            set
            { 
                if (i > this.paginas.Count)
                {
                    this.paginas.Add(value);
                }
                else if(i>=0)
                {
                    this.paginas.Insert(i, value);
                }
            } 
        }
    }
}
