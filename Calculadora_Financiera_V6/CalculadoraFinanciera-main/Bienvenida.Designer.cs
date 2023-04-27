namespace Calculadora_Financiera
{
    partial class Bienvenida
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
            lblBienvenida = new Label();
            label1 = new Label();
            textBox1 = new TextBox();
            BoxClientes = new ComboBox();
            lblTipoCliente = new Label();
            label2 = new Label();
            BotRealizar = new Button();
            BotSalir = new Button();
            SuspendLayout();
            // 
            // lblBienvenida
            // 
            lblBienvenida.AutoSize = true;
            lblBienvenida.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblBienvenida.Location = new Point(129, 37);
            lblBienvenida.Name = "lblBienvenida";
            lblBienvenida.Size = new Size(560, 30);
            lblBienvenida.TabIndex = 0;
            lblBienvenida.Text = "¡Bienvenido a la calculadora financiera de préstamo virtual!";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(44, 111);
            label1.Name = "label1";
            label1.Size = new Size(164, 20);
            label1.TabIndex = 1;
            label1.Text = "Nombre del solicitante:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(221, 111);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(389, 23);
            textBox1.TabIndex = 2;
            // 
            // BoxClientes
            // 
            BoxClientes.FormattingEnabled = true;
            BoxClientes.Items.AddRange(new object[] { "A1", "A2", "B", "C" });
            BoxClientes.Location = new Point(221, 174);
            BoxClientes.Name = "BoxClientes";
            BoxClientes.Size = new Size(71, 23);
            BoxClientes.TabIndex = 3;
            // 
            // lblTipoCliente
            // 
            lblTipoCliente.AutoSize = true;
            lblTipoCliente.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblTipoCliente.Location = new Point(44, 177);
            lblTipoCliente.Name = "lblTipoCliente";
            lblTipoCliente.Size = new Size(111, 20);
            lblTipoCliente.TabIndex = 4;
            lblTipoCliente.Text = "Tipo de cliente:";
            lblTipoCliente.Click += label2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(293, 241);
            label2.Name = "label2";
            label2.Size = new Size(204, 21);
            label2.TabIndex = 5;
            label2.Text = "¿Desea iniciar una consulta?";
            // 
            // BotRealizar
            // 
            BotRealizar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            BotRealizar.Location = new Point(209, 305);
            BotRealizar.Name = "BotRealizar";
            BotRealizar.Size = new Size(132, 50);
            BotRealizar.TabIndex = 6;
            BotRealizar.Text = "Realizar";
            BotRealizar.UseVisualStyleBackColor = true;
            BotRealizar.Click += BotRealizar_Click;
            // 
            // BotSalir
            // 
            BotSalir.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            BotSalir.Location = new Point(430, 305);
            BotSalir.Name = "BotSalir";
            BotSalir.Size = new Size(122, 50);
            BotSalir.TabIndex = 7;
            BotSalir.Text = "Salir";
            BotSalir.UseVisualStyleBackColor = true;
            // 
            // Bienvenida
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BotSalir);
            Controls.Add(BotRealizar);
            Controls.Add(label2);
            Controls.Add(lblTipoCliente);
            Controls.Add(BoxClientes);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(lblBienvenida);
            Name = "Bienvenida";
            Text = "Bienvenida";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblBienvenida;
        private Label label1;
        private TextBox textBox1;
        private ComboBox BoxClientes;
        private Label lblTipoCliente;
        private Label label2;
        private Button BotRealizar;
        private Button BotSalir;
    }
}