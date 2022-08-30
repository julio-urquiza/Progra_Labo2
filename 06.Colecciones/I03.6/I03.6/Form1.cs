using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace I03._6
{
    public partial class Form1 : Form
    {
        Dictionary<string, int> palabras;
        public Form1()
        {
            InitializeComponent();
            palabras = new Dictionary<string, int>();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            char[] separadores = { ' ', ',', '.', '\n' };
            string[] cadena=richTextBox.Text.Split(separadores,StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < cadena.Length; i++)
            {
                if (!palabras.ContainsKey(cadena[i]))
                {
                    palabras.Add(cadena[i],1);
                }
                else
                {
                    palabras[cadena[i]]++;
                }

            }
            
            MessageBox.Show(Mostrar(palabras));
        }
        private static string Mostrar(Dictionary<string, int> palabras)
        {
            StringBuilder stringBuilder = new StringBuilder();  
            foreach(KeyValuePair<string, int> kvp in palabras)
            {
                stringBuilder.AppendLine($"palabra: {kvp.Key} - apariciones: {kvp.Value}");
            }
            return stringBuilder.ToString();
        }

        
    }
}
