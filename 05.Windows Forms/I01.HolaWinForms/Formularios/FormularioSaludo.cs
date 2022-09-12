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
    public partial class FormularioSaludo : Form
    {
        public FormularioSaludo(string nombre,string apellido,string materiaFavorita)
        {
            InitializeComponent();
            this.labelSoy.Text += string.Format("{0},{1}",nombre,apellido);
            this.labelSoy.Text += string.Format(" y mi materia favorita es {0}",materiaFavorita);

        }
    }
}
