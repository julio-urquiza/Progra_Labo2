using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bioblioteca;
using Microsoft.VisualBasic;

namespace Formulario
{
    public partial class FormAdministrador : Form
    {
        private Dictionary<int, Persona> lista;
        private int i;
        public FormAdministrador(Dictionary<int, Persona> lista,int i)
        {
            InitializeComponent();
            this.lista = lista;
            this.i = i;
        }

        private void buttonDarDeAlta_Click(object sender, EventArgs e)
        {
            lista[1].Nombre = "2134578";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
