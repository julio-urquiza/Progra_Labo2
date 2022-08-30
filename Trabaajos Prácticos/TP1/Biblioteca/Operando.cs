using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Operando
    {
        private double numero;
        public string Numero 
        {
            set => this.numero = ValidarOperando(value); 
        }

        public Operando()
        {
            numero=0;
        }
        public Operando(double numero)
        {
            this.numero = numero;
        }
        public Operando(string strNumero)
        {
            this.Numero = strNumero;
        }
        private static double ValidarOperando(string strNumero)
        {
            double retorno;
            double.TryParse(strNumero, out retorno);
            return retorno;
        }
        private static bool EsBinario(string binario)
        {
            bool retorno = true;

            for(int i=0; i < binario.Length; i++)
            {
                if (binario[i] != '0' && binario[i] != '1')
                {
                    retorno=false;
                }
            }
            return retorno;
        }
        public static string BinarioDecimal(string binario)
        {
            if(EsBinario(binario))
            {
                double numero = 0;
                int j=0;
                for(int i=binario.Length-1; i >=0; i--,j++)
                {
                    if(binario[i] == '1')
                    {
                        numero += Math.Pow(2,j);
                    }    
                }
                return numero.ToString();
            }
            else
            {
                return "Valor Inválido";
            }
        }
        public static string DecimalBinario(double numero)
        {
            return Convert.ToString((int)numero, 2);
        }
        public static string DecimalBinario(string strNumero)
        {
            return DecimalBinario(ValidarOperando(strNumero));
        }
        public static double operator -(Operando n1,Operando n2)
        {
            return n1.numero - n2.numero;
        }
        public static double operator +(Operando n1, Operando n2)
        {
            return n1.numero + n2.numero;
        }
        public static double operator /(Operando n1, Operando n2)
        {
            double retorno=double.MinValue;
            if(n2.numero!=0)
            {
                retorno= n1.numero / n2.numero;
            }
            return retorno;
        }
        public static double operator *(Operando n1, Operando n2)
        {
            return n1.numero * n2.numero;
        }


    }
}
