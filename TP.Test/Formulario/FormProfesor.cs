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

namespace Formulario
{
    public partial class FormProfesor : Form
    {
        private Dictionary<int, Persona> lista;
        private int i;

        public FormProfesor(Dictionary<int, Persona> lista,int i)
        {
            InitializeComponent();
            this.lista = lista;
            this.i = i;
        }
    }
}
