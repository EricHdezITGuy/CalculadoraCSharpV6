namespace Calculadora_Financiera
{
    public partial class Bienvenida : Form
    {
        Datos_Pr�stamo datos_prestamo;
        public Bienvenida()
        {
            InitializeComponent();
            datos_prestamo = new Datos_Pr�stamo();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            

        }

        private void BotRealizar_Click(object sender, EventArgs e)
        {
            datos_prestamo.ShowDialog();
        }
    }
}