namespace Calculadora_Financiera
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label_Bienvenido = new Label();
            label_NombreSolicitante = new Label();
            label_TipoCliente = new Label();
            textBox_NombreSolicitante = new TextBox();
            comboBox_TipoCliente = new ComboBox();
            label_PreguntaIniciar = new Label();
            button_Realizar = new Button();
            button_SalirvPrincipal = new Button();
            SuspendLayout();
            // 
            // label_Bienvenido
            // 
            label_Bienvenido.AutoSize = true;
            label_Bienvenido.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label_Bienvenido.Location = new Point(110, 35);
            label_Bienvenido.Margin = new Padding(6, 0, 6, 0);
            label_Bienvenido.Name = "label_Bienvenido";
            label_Bienvenido.Size = new Size(644, 32);
            label_Bienvenido.TabIndex = 0;
            label_Bienvenido.Text = "¡Bienvenido a la calculadora financiera de préstamo virtual!";
            // 
            // label_NombreSolicitante
            // 
            label_NombreSolicitante.AutoSize = true;
            label_NombreSolicitante.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label_NombreSolicitante.Location = new Point(51, 99);
            label_NombreSolicitante.Name = "label_NombreSolicitante";
            label_NombreSolicitante.Size = new Size(207, 25);
            label_NombreSolicitante.TabIndex = 1;
            label_NombreSolicitante.Text = "Nombre del solicitante:";
            // 
            // label_TipoCliente
            // 
            label_TipoCliente.AutoSize = true;
            label_TipoCliente.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label_TipoCliente.Location = new Point(56, 165);
            label_TipoCliente.Name = "label_TipoCliente";
            label_TipoCliente.Size = new Size(140, 25);
            label_TipoCliente.TabIndex = 2;
            label_TipoCliente.Text = "Tipo de cliente:";
            // 
            // textBox_NombreSolicitante
            // 
            textBox_NombreSolicitante.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_NombreSolicitante.Location = new Point(264, 92);
            textBox_NombreSolicitante.Name = "textBox_NombreSolicitante";
            textBox_NombreSolicitante.Size = new Size(376, 27);
            textBox_NombreSolicitante.TabIndex = 3;
            // 
            // comboBox_TipoCliente
            // 
            comboBox_TipoCliente.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox_TipoCliente.FormattingEnabled = true;
            comboBox_TipoCliente.Items.AddRange(new object[] { "A1", "A2", "B", "C" });
            comboBox_TipoCliente.Location = new Point(264, 166);
            comboBox_TipoCliente.Name = "comboBox_TipoCliente";
            comboBox_TipoCliente.Size = new Size(118, 28);
            comboBox_TipoCliente.TabIndex = 4;
            comboBox_TipoCliente.SelectedIndexChanged += comboBox_TipoCliente_SelectedIndexChanged;
            // 
            // label_PreguntaIniciar
            // 
            label_PreguntaIniciar.AutoSize = true;
            label_PreguntaIniciar.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label_PreguntaIniciar.Location = new Point(328, 241);
            label_PreguntaIniciar.Name = "label_PreguntaIniciar";
            label_PreguntaIniciar.Size = new Size(195, 20);
            label_PreguntaIniciar.TabIndex = 5;
            label_PreguntaIniciar.Text = "¿Desea iniciar una consulta?";
            // 
            // button_Realizar
            // 
            button_Realizar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button_Realizar.Location = new Point(236, 286);
            button_Realizar.Name = "button_Realizar";
            button_Realizar.Size = new Size(146, 54);
            button_Realizar.TabIndex = 6;
            button_Realizar.Text = "Realizar";
            button_Realizar.UseVisualStyleBackColor = true;
            button_Realizar.Click += button_Realizar_Click;
            // 
            // button_SalirvPrincipal
            // 
            button_SalirvPrincipal.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            button_SalirvPrincipal.Location = new Point(444, 286);
            button_SalirvPrincipal.Name = "button_SalirvPrincipal";
            button_SalirvPrincipal.Size = new Size(124, 54);
            button_SalirvPrincipal.TabIndex = 7;
            button_SalirvPrincipal.Text = "Salir";
            button_SalirvPrincipal.UseVisualStyleBackColor = true;
            button_SalirvPrincipal.Click += button_SalirvPrincipal_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightBlue;
            ClientSize = new Size(826, 448);
            Controls.Add(button_SalirvPrincipal);
            Controls.Add(button_Realizar);
            Controls.Add(label_PreguntaIniciar);
            Controls.Add(comboBox_TipoCliente);
            Controls.Add(textBox_NombreSolicitante);
            Controls.Add(label_TipoCliente);
            Controls.Add(label_NombreSolicitante);
            Controls.Add(label_Bienvenido);
            Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = SystemColors.ControlText;
            Margin = new Padding(6, 7, 6, 7);
            Name = "Form1";
            Text = "Bienvenida";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_Bienvenido;
        private Label label_NombreSolicitante;
        private Label label_TipoCliente;
        private TextBox textBox_NombreSolicitante;
        private ComboBox comboBox_TipoCliente;
        private Label label_PreguntaIniciar;
        private Button button_Realizar;
        private Button button_SalirvPrincipal;
    }
}