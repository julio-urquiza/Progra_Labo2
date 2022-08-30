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

namespace MiCalculadora
{
    public partial class FormCalculadora : Form
    {
        public FormCalculadora()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            /*
            if (MessageBox.Show("¿Desea Salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                this.Close();
            }
            */
            this.Close();
        }
        private void btnConvertirABinario_Click(object sender, EventArgs e)
        {
            lblResultado.Text = Operando.DecimalBinario(txtNumero1.Text);
        }
        private void btnConvertirADecimal_Click(object sender, EventArgs e)
        {
            lblResultado.Text = Operando.BinarioDecimal(txtNumero1.Text);
        }
        private void btnOperar_Click(object sender, EventArgs e)
        {
            double resultado=Operar(txtNumero1.Text, txtNumero2.Text, cmbOperador.Text);
            if(resultado!=double.MinValue)
            {
                lblResultado.Text = resultado.ToString();
            }
            else
            {
                lblResultado.Text = "ERROR";
            }
            lstOperaciones.Items.Add($"{txtNumero1.Text} {cmbOperador.Text} {txtNumero2.Text} = {lblResultado.Text}");
        }
        public static double Operar(string numero1,string numero2,string operador)
        {
            Operando operando1 = new Operando(numero1);
            Operando operando2 = new Operando(numero2);
            char signo;
            char.TryParse(operador, out signo);
            return Calculadora.Operar(operando1, operando2, signo);
        }
        private void btnLimpear_Click(object sender, EventArgs e)
        {
            this.Limpiar();
        }
        public void Limpiar()
        {
            lblResultado.Text = "0";
            lstOperaciones.Items.Clear();
            txtNumero1.Text = "0";
            txtNumero2.Text = "0";
            cmbOperador.Text = "";
        }

        private void FormCalculadora_Load(object sender, EventArgs e)
        {
            this.Limpiar();
        }

        private void FormCalculadora_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Desea Salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.No)
            {
                e.Cancel=true;
            }
        }
    }
}
