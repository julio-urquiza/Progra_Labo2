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
    public partial class Form2 : Form
    {
        public Form2(DataGridView dtgv1)
        {
            InitializeComponent();
            this.dtgv.DataSource = dtgv1.DataSource;

        }
    }
}
