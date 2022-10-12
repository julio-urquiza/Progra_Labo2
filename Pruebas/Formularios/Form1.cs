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
    public partial class Form1 : Form
    {
        Pepinillo pe;
        int i;
        string pepe;
        public Form1()
        {
            InitializeComponent();
            pe = new Pepinillo(1,"julio");
            pepe = "abc";
            i = 4;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2(pe,i,pepe);
            f2.ShowDialog();
            this.label1.Text+= pe.marca;
            this.label1.Text += pe.cantidad;
            this.label1.Text += pepe;

        }
    }
}
