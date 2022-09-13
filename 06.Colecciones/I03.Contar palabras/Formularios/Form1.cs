using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formularios
{
    public partial class FormContar : Form
    {
        Dictionary<string, int> diccionario;
        public FormContar()
        {
            InitializeComponent();
            diccionario=new Dictionary<string, int>();
        }

        private void buttonContar_Click(object sender, EventArgs e)
        {
            List<string>palabras=richTextBox.Text.Split(' ').ToList();
            foreach(string palabra in palabras)
            {
                if(!diccionario.ContainsKey(palabra))
                {
                    diccionario.Add(palabra, 1);
                }
                else
                {
                    diccionario[palabra]++;
                }
            }
            MessageBox.Show(mostrarDiccionario(diccionario));
        }
        private static string mostrarDiccionario(Dictionary<string,int> d)
        {
            StringBuilder sb= new StringBuilder();
            sb.AppendLine("Diccionario");
            foreach(KeyValuePair<string,int> kvp in d)
            {
                sb.AppendLine($"clave: {kvp.Key}, valor: {kvp.Value}");
            }
            return sb.ToString();
        }
    }
}
