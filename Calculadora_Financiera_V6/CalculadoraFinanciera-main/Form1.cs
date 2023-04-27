namespace Calculadora_Financiera
{
    public partial class Form1 : Form
    {
        double descuento = 0;
        String tipoCliente = "";

        Form2 Datos; //Es para inializar una nueva ventana llamada "Datos"
        public Form1()
        {
            InitializeComponent();
            Datos = new Form2(); //El nombre "Datos" es igual a decir crear una nueva ventana. 
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button_Realizar_Click(object sender, EventArgs e)
        {
            if (comboBox_TipoCliente.SelectedIndex != 3)
            {
                this.Hide();

                Datos.Descuento = descuento; // Establecer el descuento en Form2
                Datos.ShowDialog(); //Al presionarlo se muestra esa ventana de "Datos"
            }
            else
            {
                MessageBox.Show("Este tipo de usuario no puede acceder al sistema");
            }
        }

        private void button_SalirvPrincipal_Click(object sender, EventArgs e)
        {
            //Ac� creamos un mensaje flotante para confirmar que queremos salir del app
            if (MessageBox.Show("�Est� seguro que desea salir?", "Salir de la aplicaci�n", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void comboBox_TipoCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Este c�digo es para leer la opci�n para descuento o no. Establece el descuento seg�n el tipo de cliente seleccionado
            // Verificar si el �ndice seleccionado es diferente de -1
            if (comboBox_TipoCliente.SelectedIndex != -1)
            {
                descuento = 0;
                tipoCliente = comboBox_TipoCliente.SelectedItem.ToString().ToUpper();

                switch (tipoCliente)
                {
                    case "A1":
                    case "A2":
                        descuento = 0.02;
                        break;
                    case "C":
                        MessageBox.Show("Cr�dito denegado.");
                        return;
                }
            }

        }


    }
}