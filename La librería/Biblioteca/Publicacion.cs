using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public abstract class Publicacion
    {
        protected float importe;
        protected string nombre;
        protected int stock;


        public Publicacion(string nombre)
        {
            this.nombre = nombre;
            this.stock = 0;
            this.importe = 0;
        }

        protected Publicacion(string nombre, int stock) : this(nombre)
        {
            this.stock = stock;
        }

        protected Publicacion(string nombre, int stock, float importe) : this(nombre,stock)
        {
            this.importe = importe;
        }


        protected abstract bool EsColor { get; }
        public virtual bool HayStock 
        {
            get { return this.stock>0 && this.importe>0; }
        }
        public int Stock 
        { 
            get => this.stock;
            set
            {
                if(value>0)
                {
                    this.stock = value;
                }
            } 
        }
        public float Importe { get => this.importe; set => this.importe = value; }


        public override string ToString()
        {
            return this.nombre; 
        }
        public string ObetenerInformacion()
        {
            StringBuilder retorno=new StringBuilder(); 
            retorno.AppendLine($"Nombre: {this.nombre}");
            retorno.AppendLine($"Stock: {this.stock}");
            if(this.EsColor)
            {
                retorno.AppendLine("Es Color: SI");
            }
            else
            {
                retorno.AppendLine("Es Color: NO");
            }
            retorno.AppendLine($"Valor: ${this.Importe}");
            return retorno.ToString();
        }

    }
}
