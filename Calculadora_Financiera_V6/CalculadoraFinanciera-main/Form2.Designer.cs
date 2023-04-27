namespace Calculadora_Financiera
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            label_TextoInicio = new Label();
            label_TipoPréstamo = new Label();
            label_Monto = new Label();
            label_PlazoMeses = new Label();
            label_MontoTotal = new Label();
            label_Cuota = new Label();
            label7 = new Label();
            label8 = new Label();
            label_MontoT = new Label();
            label_CuotaMensual = new Label();
            button_Atrás = new Button();
            comboBox_TipoPréstamo = new ComboBox();
            comboBox_PlazoMeses = new ComboBox();
            textBox_MontoSolicitar = new TextBox();
            label11 = new Label();
            button_Calcular = new Button();
            button1 = new Button();
            imageList1 = new ImageList(components);
            richTextBox1 = new RichTextBox();
            btnGuardar = new Button();
            buttonVerSolicitud = new Button();
            SuspendLayout();
            // 
            // label_TextoInicio
            // 
            label_TextoInicio.AutoSize = true;
            label_TextoInicio.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label_TextoInicio.Location = new Point(52, 40);
            label_TextoInicio.Name = "label_TextoInicio";
            label_TextoInicio.Size = new Size(217, 20);
            label_TextoInicio.TabIndex = 0;
            label_TextoInicio.Text = "Rellene los espacios solicitados";
            // 
            // label_TipoPréstamo
            // 
            label_TipoPréstamo.AutoSize = true;
            label_TipoPréstamo.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label_TipoPréstamo.Location = new Point(25, 109);
            label_TipoPréstamo.Name = "label_TipoPréstamo";
            label_TipoPréstamo.Size = new Size(116, 17);
            label_TipoPréstamo.TabIndex = 1;
            label_TipoPréstamo.Text = "Tipo de préstamo:";
            // 
            // label_Monto
            // 
            label_Monto.AutoSize = true;
            label_Monto.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label_Monto.Location = new Point(25, 164);
            label_Monto.Name = "label_Monto";
            label_Monto.Size = new Size(110, 17);
            label_Monto.TabIndex = 2;
            label_Monto.Text = "Monto a solicitar:";
            // 
            // label_PlazoMeses
            // 
            label_PlazoMeses.AutoSize = true;
            label_PlazoMeses.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label_PlazoMeses.Location = new Point(25, 223);
            label_PlazoMeses.Name = "label_PlazoMeses";
            label_PlazoMeses.Size = new Size(94, 17);
            label_PlazoMeses.TabIndex = 3;
            label_PlazoMeses.Text = "Plazo a meses:";
            // 
            // label_MontoTotal
            // 
            label_MontoTotal.AutoSize = true;
            label_MontoTotal.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label_MontoTotal.Location = new Point(483, 103);
            label_MontoTotal.Name = "label_MontoTotal";
            label_MontoTotal.Size = new Size(93, 20);
            label_MontoTotal.TabIndex = 4;
            label_MontoTotal.Text = "Monto Total:";
            label_MontoTotal.Click += label_MontoTotal_Click;
            // 
            // label_Cuota
            // 
            label_Cuota.AutoSize = true;
            label_Cuota.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label_Cuota.Location = new Point(466, 153);
            label_Cuota.Name = "label_Cuota";
            label_Cuota.Size = new Size(110, 20);
            label_Cuota.TabIndex = 5;
            label_Cuota.Text = "Cuota Mensual:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(574, 103);
            label7.Name = "label7";
            label7.Size = new Size(13, 15);
            label7.TabIndex = 6;
            label7.Text = "₡";
            label7.Click += label7_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(574, 157);
            label8.Name = "label8";
            label8.Size = new Size(13, 15);
            label8.TabIndex = 7;
            label8.Text = "₡";
            // 
            // label_MontoT
            // 
            label_MontoT.AutoSize = true;
            label_MontoT.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label_MontoT.Location = new Point(593, 103);
            label_MontoT.Name = "label_MontoT";
            label_MontoT.Size = new Size(0, 20);
            label_MontoT.TabIndex = 8;
            label_MontoT.Click += label_MontoT_Click;
            // 
            // label_CuotaMensual
            // 
            label_CuotaMensual.AutoSize = true;
            label_CuotaMensual.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label_CuotaMensual.Location = new Point(593, 157);
            label_CuotaMensual.Name = "label_CuotaMensual";
            label_CuotaMensual.Size = new Size(0, 20);
            label_CuotaMensual.TabIndex = 9;
            label_CuotaMensual.Click += label_CuotaMensual_Click;
            // 
            // button_Atrás
            // 
            button_Atrás.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button_Atrás.Location = new Point(530, 351);
            button_Atrás.Name = "button_Atrás";
            button_Atrás.Size = new Size(121, 53);
            button_Atrás.TabIndex = 11;
            button_Atrás.Text = "Atrás";
            button_Atrás.UseVisualStyleBackColor = true;
            button_Atrás.Click += button_Atrás_Click;
            // 
            // comboBox_TipoPréstamo
            // 
            comboBox_TipoPréstamo.FormattingEnabled = true;
            comboBox_TipoPréstamo.Items.AddRange(new object[] { "Personal Regular - Tasa de interés: 15%", "Personal Rápido - Tasa de interés: 18%", "Reparación y ampliación de vivienda - Tasa de interés: 12%", "Compra de Lote - Tasa de interés: 12%", "Compra de Vehículo Nuevo - Tasa de interés: 18%" });
            comboBox_TipoPréstamo.Location = new Point(147, 108);
            comboBox_TipoPréstamo.Name = "comboBox_TipoPréstamo";
            comboBox_TipoPréstamo.Size = new Size(314, 23);
            comboBox_TipoPréstamo.TabIndex = 12;
            comboBox_TipoPréstamo.SelectedIndexChanged += comboBox_TipoPréstamo_SelectedIndexChanged;
            // 
            // comboBox_PlazoMeses
            // 
            comboBox_PlazoMeses.FormattingEnabled = true;
            comboBox_PlazoMeses.Items.AddRange(new object[] { "24 meses (2 años)", "60 meses (5 años)", "84 meses (7 años)" });
            comboBox_PlazoMeses.Location = new Point(136, 222);
            comboBox_PlazoMeses.Name = "comboBox_PlazoMeses";
            comboBox_PlazoMeses.Size = new Size(130, 23);
            comboBox_PlazoMeses.TabIndex = 13;
            comboBox_PlazoMeses.SelectedIndexChanged += comboBox_PlazoMeses_SelectedIndexChanged;
            // 
            // textBox_MontoSolicitar
            // 
            textBox_MontoSolicitar.Location = new Point(155, 164);
            textBox_MontoSolicitar.Name = "textBox_MontoSolicitar";
            textBox_MontoSolicitar.Size = new Size(212, 23);
            textBox_MontoSolicitar.TabIndex = 14;
            textBox_MontoSolicitar.TextChanged += textBox_MontoSolicitar_TextChanged;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(136, 167);
            label11.Name = "label11";
            label11.Size = new Size(13, 15);
            label11.TabIndex = 15;
            label11.Text = "₡";
            // 
            // button_Calcular
            // 
            button_Calcular.BackColor = Color.WhiteSmoke;
            button_Calcular.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button_Calcular.ForeColor = Color.Red;
            button_Calcular.Location = new Point(531, 198);
            button_Calcular.Name = "button_Calcular";
            button_Calcular.Size = new Size(120, 47);
            button_Calcular.TabIndex = 16;
            button_Calcular.Text = "Calcular";
            button_Calcular.UseVisualStyleBackColor = false;
            button_Calcular.Click += button_Calcular_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(531, 274);
            button1.Name = "button1";
            button1.Size = new Size(120, 51);
            button1.TabIndex = 17;
            button1.Text = "Salir";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth8Bit;
            imageList1.ImageSize = new Size(16, 16);
            imageList1.TransparentColor = Color.Transparent;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(62, 275);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(390, 193);
            richTextBox1.TabIndex = 18;
            richTextBox1.Text = "";
            richTextBox1.TextChanged += richTextBox1_TextChanged;
            // 
            // btnGuardar
            // 
            btnGuardar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnGuardar.Location = new Point(693, 272);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(86, 53);
            btnGuardar.TabIndex = 20;
            btnGuardar.Text = "Guardar Solicitud";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // buttonVerSolicitud
            // 
            buttonVerSolicitud.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonVerSolicitud.Location = new Point(693, 351);
            buttonVerSolicitud.Name = "buttonVerSolicitud";
            buttonVerSolicitud.Size = new Size(86, 53);
            buttonVerSolicitud.TabIndex = 21;
            buttonVerSolicitud.Text = "Ver Solicitud";
            buttonVerSolicitud.UseVisualStyleBackColor = true;
            buttonVerSolicitud.Click += buttonVerSolicitud_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCyan;
            ClientSize = new Size(804, 480);
            Controls.Add(buttonVerSolicitud);
            Controls.Add(btnGuardar);
            Controls.Add(richTextBox1);
            Controls.Add(button1);
            Controls.Add(button_Calcular);
            Controls.Add(label11);
            Controls.Add(textBox_MontoSolicitar);
            Controls.Add(comboBox_PlazoMeses);
            Controls.Add(comboBox_TipoPréstamo);
            Controls.Add(button_Atrás);
            Controls.Add(label_CuotaMensual);
            Controls.Add(label_MontoT);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label_Cuota);
            Controls.Add(label_MontoTotal);
            Controls.Add(label_PlazoMeses);
            Controls.Add(label_Monto);
            Controls.Add(label_TipoPréstamo);
            Controls.Add(label_TextoInicio);
            Name = "Form2";
            Text = "Datos";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_TextoInicio;
        private Label label_TipoPréstamo;
        private Label label_Monto;
        private Label label_PlazoMeses;
        private Label label_MontoTotal;
        private Label label_Cuota;
        private Label label7;
        private Label label8;
        private Label label_MontoT;
        private Label label_CuotaMensual;
        private Button button_Atrás;
        private ComboBox comboBox_TipoPréstamo;
        private ComboBox comboBox_PlazoMeses;
        private TextBox textBox_MontoSolicitar;
        private Label label11;
        private Button button_Calcular;
        private Button button1;
        private ImageList imageList1;
        private RichTextBox richTextBox1;
        private Button btnGuardar;
        private Button buttonVerSolicitud;
    }
}