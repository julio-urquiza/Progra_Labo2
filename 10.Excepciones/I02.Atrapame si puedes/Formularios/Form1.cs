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
        
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                this.validarParametros();
                this.validarPor0();

                int kilometros=int.Parse(txtKilometros.Text);
                int litros=int.Parse(txtLitros.Text);
                float resulatado = (float)kilometros/litros;
                this.rtbMostrar.Text += $"{resulatado}{Environment.NewLine}";
            }
            catch (ParametrosVaciosException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch(DivideByZeroException ex)
            {
                MessageBox.Show("No se puede dividir por 0");
            }
            catch(FormatException ex)
            {
                MessageBox.Show("Deve ingrear numeros");
            }
        }
        private void validarParametros()
        {
            if(string.IsNullOrWhiteSpace(txtKilometros.Text) && string.IsNullOrWhiteSpace(txtLitros.Text))
            {
                throw new ParametrosVaciosException();
            }
        }
        private void validarPor0()
        {
            if(txtLitros.Text=="0")
            {
                throw new DivideByZeroException();
            }
        }
        

      
    }
}
