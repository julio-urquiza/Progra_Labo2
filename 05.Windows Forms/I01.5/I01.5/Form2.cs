using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace I01._5
{
    public partial class Form2 : Form
    {
        public Form2(string nombre, string apellido)
        {
            InitializeComponent();
            this.label2.Text = "hola "+nombre + " " + apellido;
        }

   
    }
}
