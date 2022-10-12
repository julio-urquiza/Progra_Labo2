using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Biblioteca;

namespace Formularios
{
    public partial class Form2 : Form
    {
        Pepinillo pe;
        int i;
        string cade;
        public Form2(Pepinillo p,int e,string cadena)
        {
            InitializeComponent();
            pe = p;
            i= e;
            cade = cadena;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            pe.marca = "papadaa";
            pe.cantidad = 6;
            i = 7;
            cade = "hola";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
