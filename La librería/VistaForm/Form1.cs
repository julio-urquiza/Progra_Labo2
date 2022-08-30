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
namespace VistaForm
{
    public partial class Form1 : Form
    {
        private Vendedor vendedor;
        public Form1()
        {
            InitializeComponent();
            vendedor=new Vendedor("Juan");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Biografía p1 = (Biografía)"Life (Keith Richards)";
            Biografía p2 = new Biografía("White line fever (Lemmy)", 5);
            Biografía p3 = new Biografía("Commando (Johnny Ramone)", 2, 5000);
            Comic p4 = new Comic("La Muerte de Superman (Superman)", true, 1, 1850);
            Comic p5 = new Comic("Año Uno (Batman)", false, 3, 1270);

            this.lsStock.Items.Add(p1);
            this.lsStock.Items.Add(p2);
            this.lsStock.Items.Add(p3);
            this.lsStock.Items.Add(p4);
            this.lsStock.Items.Add(p5);
        }

        private void btnvender_Click(object sender, EventArgs e)
        {
            if(vendedor+(Publicacion)this.lsStock.SelectedItem)
            {
                this.rtbInforme.Text += "Venta realizada\n";
            }
            else
            {
                this.rtbInforme.Text += "La venta no pudo realizarse\n";
            }
        }

        private void btnVerInforme_Click(object sender, EventArgs e)
        {
            this.rtbInforme.Text = Vendedor.ObtenerInformacionDeVentas(vendedor);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Desea Salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
