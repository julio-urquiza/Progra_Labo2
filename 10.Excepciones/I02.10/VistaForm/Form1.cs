using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VistaForm
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
                //if(this.txtBoxKilometros.Text == "" || this.txtBoxKilometros.Text == "")
                if(this.txtBoxKilometros.Text==String.Empty || this.txtBoxLitros.Text==String.Empty)
                {
                    throw new ParametrosVaciosException("alguno de los parametros esta vacio");
                }
                int kilometros=int.Parse(this.txtBoxKilometros.Text);
                int litros=int.Parse(this.txtBoxLitros.Text);

                this.richTextBox1.Text = $"kilometros por litro: {Calculador.Calcular(kilometros,litros)}";
            }
            catch(ParametrosVaciosException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (FormatException ex)
            {
                MessageBox.Show("el formato de entrada no es el correcto");
            }
            catch (DivideByZeroException ex)
            {
                MessageBox.Show("no se puede dividir por Cero");
            }
            finally
            {
                MessageBox.Show("este el el finally");
            }
        }
    }
}
