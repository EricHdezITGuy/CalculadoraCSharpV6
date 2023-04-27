namespace Calculadora_Financiera
{
    public partial class Bienvenida : Form
    {
        Datos_Préstamo datos_prestamo;
        public Bienvenida()
        {
            InitializeComponent();
            datos_prestamo = new Datos_Préstamo();
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