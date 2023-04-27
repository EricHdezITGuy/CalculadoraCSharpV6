using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Calculadora_Financiera.Form2;

namespace Calculadora_Financiera
{
    public partial class Form2 : Form
    {
        //Inialización de variables globales
        int cantidadMeses = 0;
        double tasaInteres = 0;
        int opcionPrestamo = 0;
        int opcion_cantidadMeses = 0;
        double monto = 0;
        public double Descuento { get; set; }
        List<Solicitud> solicitudes = new List<Solicitud>();

        public Form2()
        {
            InitializeComponent();
        }

        private void button_Atrás_Click(object sender, EventArgs e)
        {
            this.Hide(); //Esconder esta ventana "Datos"
            Form1 Bienvenida = new Form1(); //Se crea una nueva ventana Bienvenida
            Bienvenida.Show(); //Se muestra
        }

        //Botón de SALIR, antes de programar no le cambié el nombre
        private void button1_Click(object sender, EventArgs e)
        {
            //Acá creamos un mensaje flotante para confirmar que queremos salir del app
            if (MessageBox.Show("¿Está seguro que desea salir?", "Salir de la aplicación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void comboBox_TipoPréstamo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string garantias = "";

            switch (comboBox_TipoPréstamo.SelectedIndex)
            {
                case 0:
                    garantias = "Fiduciarias, Hipotecarias o Prendaria.\r\nMonto Max: ¢15.000.000.00.\r\nIntereses: 15%\r\nPlazo Máximo: 60 meses\r\n";
                    tasaInteres = 0.15;
                    break;
                case 1:
                    garantias = "Constancia Salarial\r\nDeducción de Planilla.\r\nMonto Max: ¢1.000.000.00.\r\nIntereses: 18%\r\nPlazo Máximo: 24 meses\r\n";
                    tasaInteres = 0.18;
                    break;
                case 2:
                    garantias = "Fiduciarias o\r\nHipotecarias.\r\nMonto Max: ¢15.000.000.00\r\nIntereses: 12%\r\nPlazo Máximo: 84 meses\r\n";
                    tasaInteres = 0.12;
                    break;
                case 3:
                    garantias = "Fiduciarias o\r\nHipotecarias.\r\nMonto Max: ¢15.000.000.00\r\nIntereses: 12%\r\nPlazo Máximo: 84 meses\r\n";
                    tasaInteres = 0.12;
                    break;
                case 4:
                    garantias = "Fiduciarias,\r\nHipotecarias o\r\nPrendaria. \r\nMonto Max: ¢15.000.000.00\r\nIntereses: 18%\r\nPlazo Máximo: 60 meses\r\n";
                    tasaInteres = 0.18;
                    break;
            }

            richTextBox1.Text = "Garantía para la línea seleccionada:\r\n" + garantias;
        }

        private void label_MontoT_Click(object sender, EventArgs e)
        {

        }

        private void label_CuotaMensual_Click(object sender, EventArgs e)
        {

        }
        private void textBox_MontoSolicitar_TextChanged(object sender, EventArgs e)
        {
            // Verifica si el monto del préstamo ingresado es válido y lo almacena en la variable
            if (double.TryParse(textBox_MontoSolicitar.Text, NumberStyles.Currency, CultureInfo.InvariantCulture, out monto))
            {
            }
            else
            {
                MessageBox.Show("Ingrese un valor numérico válido para el monto del préstamo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comboBox_PlazoMeses_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Verifica si la cantidad de meses  ingresada es válida y la almacena en la variable
            if (int.TryParse(comboBox_PlazoMeses.SelectedIndex.ToString(), out cantidadMeses))
            {
                // usa el valor recibido en la conversión de String a int

                // Establece la tasa de interés según la opción de préstamo seleccionada
                int opcion_cantidadMeses = comboBox_PlazoMeses.SelectedIndex;
                {
                    switch (opcion_cantidadMeses)
                    {
                        case 0:
                            cantidadMeses = 24;
                            break;
                        case 1:
                            cantidadMeses = 60;
                            break;
                        case 2:
                            cantidadMeses = 84;
                            break;
                        default:
                            MessageBox.Show("Opción de plazo de meses no es válida.", "Error");
                            return;
                    }
                }
            }
            else
            {
                // entrada no válida
            }
        }

        // funcion para validar 
        private string ValidarPrestamo()
        {
            string mensaje = "";
            double monto = Double.Parse(textBox_MontoSolicitar.Text); // asignar variable
            if (monto > 1000000 && comboBox_TipoPréstamo.SelectedIndex == 1)
            {
                mensaje += "El tipo de préstamo seleccionado no puede superar el millón de colones, por favor vuelva a intentarlo\n";

            }

            if (monto > 15000000)
            {
                mensaje += "El tipo de préstamo seleccionado no puede superar 15 millones de colones, por favor vuelva a intentarlo\n";
            }
            if (comboBox_PlazoMeses.SelectedIndex == 2 && comboBox_TipoPréstamo.SelectedIndex == 0)
            {
                mensaje += "El plan de meses seleccionado no está disponible, por favor vuelva a intentarlo\n";
            }
            if (comboBox_PlazoMeses.SelectedIndex == 4 && comboBox_TipoPréstamo.SelectedIndex == 0)
            {
                mensaje += "El plan de meses seleccionado no está disponible, por favor vuelva a intentarlo\n";
            }
            if (comboBox_PlazoMeses.SelectedIndex == 1 && comboBox_TipoPréstamo.SelectedIndex == 1)
            {
                mensaje += "El plan de meses seleccionado no está disponible, por favor vuelva a intentarlo\n";
            }
            if (comboBox_PlazoMeses.SelectedIndex == 2 && comboBox_TipoPréstamo.SelectedIndex == 1)
            {
                mensaje += "El plan de meses seleccionado no está disponible, por favor vuelva a intentarlo\n";
            }
            return mensaje;


        }


        private void button_Calcular_Click(object sender, EventArgs e)
        {
            string mensaje = ValidarPrestamo();
            if (mensaje == "")
            {
                // Inicialización de las variables
                double monto, interesMensual, cuotaMensual, montoTotal;
                monto = Double.Parse(textBox_MontoSolicitar.Text); // asignar variable
                interesMensual = (tasaInteres * (1 - Descuento)) / 12;

                double factor = Math.Pow(1 + interesMensual, cantidadMeses);
                cuotaMensual = monto * (interesMensual * factor) / (factor - 1);
                montoTotal = cuotaMensual * cantidadMeses;

                // Mostrar resultados con dos decimales
                label_CuotaMensual.Text = cuotaMensual.ToString("N2");
                label_MontoT.Text = montoTotal.ToString("N2");
            }
            else
            {
                MessageBox.Show(mensaje);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox_TipoPréstamo.Items.AddRange(new object[] {
        "Personal Regular",
        "Personal Rápido",
        "Reparación y ampliación de vivienda",
        "Compra de Lote",
        "Compra de Vehículo Nuevo"});

            richTextBox1.ReadOnly = true;
            richTextBox1.Font = new Font(richTextBox1.Font, FontStyle.Italic);
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label_MontoTotal_Click(object sender, EventArgs e)
        {

        }

        public class Solicitud
        {
            public double Monto { get; set; }
            public int CantidadMeses { get; set; }
            public double TasaInteres { get; set; }
            public double CuotaMensual { get; set; }
            public double MontoTotal { get; set; }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Solicitud solicitud = new Solicitud
            {
                Monto = Double.Parse(textBox_MontoSolicitar.Text),
                CantidadMeses = cantidadMeses,
                TasaInteres = tasaInteres,
                CuotaMensual = double.Parse(label_CuotaMensual.Text),
                MontoTotal = double.Parse(label_MontoT.Text)
            };

            solicitudes.Add(solicitud);
            MessageBox.Show("La solicitud ha sido guardada.");
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void buttonVerSolicitud_Click(object sender, EventArgs e)
        {
            StringBuilder historialSolicitudes = new StringBuilder();

            foreach (Solicitud solicitud in solicitudes)
            {
                historialSolicitudes.AppendLine($"Monto: {solicitud.Monto:N2}, Meses: {solicitud.CantidadMeses}, Tasa de interés: {solicitud.TasaInteres * 100:N2}%, Cuota mensual: {solicitud.CuotaMensual:N2}, Monto total: {solicitud.MontoTotal:N2}");
            }

            MessageBox.Show(historialSolicitudes.ToString(), "Historial de solicitudes");
        }

    }
}