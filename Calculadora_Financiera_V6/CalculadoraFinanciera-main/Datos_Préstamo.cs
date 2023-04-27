using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora_Financiera
{
    public partial class Datos_Préstamo : Form
    {
        Bienvenida bienvenida;
        public Datos_Préstamo()
        {
            InitializeComponent();
            bienvenida = new Bienvenida();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            bienvenida.ShowDialog();
        }
    }
}
