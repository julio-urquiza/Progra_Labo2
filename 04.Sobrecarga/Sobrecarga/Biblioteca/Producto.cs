using System;
using System.Text;

namespace Biblioteca
{
    public class Producto
    {
        private int id;
        private string nombre;
        private int precio;
        private int stock;

        public string Nombre 
        {
            get
            {
                return this.nombre;
            }
            set
            {
                this.nombre = value;
            }
        }
        public int Precio 
        {
            get
            { 
                return this.precio; 
            }

            set
            {
                this.precio = value;
            }
        }
        public int Stock 
        {
            get
            {
                return this.stock;
            }
            set
            {
                this.stock= value;
            }
        }
        public int Id 
        { 
            get
            {
                return this.id;
            }
            set
            {
                this.id = value;
            }
        }

        public Producto(string nombre)
        {
            this.nombre= nombre;
            this.precio= 0;
            this.stock= 0;
            this.id = 0;
        }
        public Producto(string nombre,int precio):this(nombre)
        {
            this.precio= precio;
            this.stock = 0;
            this.id = 0;
        }
        public Producto(string nombre,int precio,int stock):this(nombre,precio)
        {
            this.stock= stock;
            this.id = 0;
        }
        public Producto(string nombre, int precio, int stock,int id) : this(nombre, precio,stock)
        {
            this.id=id;
        }

        public void Mostrar()
        {
            StringBuilder cadena=new StringBuilder();

            cadena.AppendLine(string.Format("Id:{0}", this.id));
            cadena.AppendLine(string.Format("Nombre:{0}", this.nombre));
            cadena.AppendLine(string.Format("Precio:{0}", this.precio));
            cadena.AppendLine(string.Format("Stock:{0}", this.stock));

            Console.WriteLine(cadena.ToString());
        }
        public void Mostrar(ConsoleColor color)
        {
            Console.BackgroundColor = color;
            this.Mostrar();
        }

        public static int operator + (Producto p1,Producto p2)
        {
            return (p1.stock*p1.precio)+(p2.stock*p2.precio);
        }
        public static int operator +(Producto p1, int n)
        {
            return p1.stock + n;
        }
        public static int operator -(Producto p1, Producto p2)
        {
            return (p1.stock * p1.precio) - (p2.stock * p2.precio);
        }
        public static int operator -(Producto p1, int n)
        {
            return p1.stock - n;
        }
        public static bool operator ==(Producto p1,int n)
        {
            return p1.stock == n;
        }
        public static bool operator !=(Producto p1,int n)
        {
            return !(p1== n);
        }

        public static explicit operator int(Producto p1)
        {
            return p1.precio;
        }
        public static implicit operator string(Producto p1)
        {
            return p1.nombre;
        }




    }

}
