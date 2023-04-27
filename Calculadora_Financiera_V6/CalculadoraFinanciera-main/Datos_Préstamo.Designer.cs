namespace Calculadora_Financiera
{
    partial class Datos_Préstamo
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
            label1 = new Label();
            Tipo_prestamo = new ComboBox();
            T_prestamo = new Label();
            lblMonto = new Label();
            monto = new TextBox();
            label2 = new Label();
            label3 = new Label();
            plazo_meses = new ComboBox();
            Label_montot = new Label();
            label_cuotam = new Label();
            label4 = new Label();
            label5 = new Label();
            monto_total = new Label();
            cuota_mensual = new Label();
            button1 = new Button();
            butatrás = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(48, 40);
            label1.Name = "label1";
            label1.Size = new Size(225, 21);
            label1.TabIndex = 0;
            label1.Text = "Rellene los espacios solicitados";
            // 
            // Tipo_prestamo
            // 
            Tipo_prestamo.FormattingEnabled = true;
            Tipo_prestamo.Items.AddRange(new object[] { "Personal Regular", "Personal Rápido", "Reparación y ampliación de vivienda", "Compra de Lote", "Compra de Vehículo Nuevo" });
            Tipo_prestamo.Location = new Point(190, 102);
            Tipo_prestamo.Name = "Tipo_prestamo";
            Tipo_prestamo.Size = new Size(144, 23);
            Tipo_prestamo.TabIndex = 1;
            // 
            // T_prestamo
            // 
            T_prestamo.AutoSize = true;
            T_prestamo.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            T_prestamo.Location = new Point(51, 102);
            T_prestamo.Name = "T_prestamo";
            T_prestamo.Size = new Size(130, 20);
            T_prestamo.TabIndex = 2;
            T_prestamo.Text = "Tipo de préstamo:";
            // 
            // lblMonto
            // 
            lblMonto.AutoSize = true;
            lblMonto.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblMonto.Location = new Point(48, 150);
            lblMonto.Name = "lblMonto";
            lblMonto.Size = new Size(124, 20);
            lblMonto.TabIndex = 3;
            lblMonto.Text = "Monto a solicitar:";
            // 
            // monto
            // 
            monto.Location = new Point(190, 147);
            monto.Name = "monto";
            monto.Size = new Size(186, 23);
            monto.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(171, 155);
            label2.Name = "label2";
            label2.Size = new Size(13, 15);
            label2.TabIndex = 5;
            label2.Text = "₡";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(51, 207);
            label3.Name = "label3";
            label3.Size = new Size(105, 20);
            label3.TabIndex = 6;
            label3.Text = "Plazo a meses:";
            // 
            // plazo_meses
            // 
            plazo_meses.FormattingEnabled = true;
            plazo_meses.Items.AddRange(new object[] { "12 meses (1año)", "24 meses (2años)", "36 meses (3años)", "48 meses(4años)", "60 meses(5años)", "84 meses(7años)" });
            plazo_meses.Location = new Point(171, 204);
            plazo_meses.Name = "plazo_meses";
            plazo_meses.Size = new Size(117, 23);
            plazo_meses.TabIndex = 7;
            // 
            // Label_montot
            // 
            Label_montot.AutoSize = true;
            Label_montot.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Label_montot.Location = new Point(443, 86);
            Label_montot.Name = "Label_montot";
            Label_montot.Size = new Size(95, 21);
            Label_montot.TabIndex = 8;
            Label_montot.Text = "Monto Total:";
            // 
            // label_cuotam
            // 
            label_cuotam.AutoSize = true;
            label_cuotam.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label_cuotam.Location = new Point(421, 126);
            label_cuotam.Name = "label_cuotam";
            label_cuotam.Size = new Size(117, 21);
            label_cuotam.TabIndex = 9;
            label_cuotam.Text = "Cuota Mensual:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(544, 86);
            label4.Name = "label4";
            label4.Size = new Size(16, 15);
            label4.TabIndex = 10;
            label4.Text = "₡ ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(544, 131);
            label5.Name = "label5";
            label5.Size = new Size(16, 15);
            label5.TabIndex = 11;
            label5.Text = "₡ ";
            // 
            // monto_total
            // 
            monto_total.AutoSize = true;
            monto_total.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            monto_total.Location = new Point(574, 86);
            monto_total.Name = "monto_total";
            monto_total.Size = new Size(50, 20);
            monto_total.TabIndex = 12;
            monto_total.Text = "label6";
            // 
            // cuota_mensual
            // 
            cuota_mensual.AutoSize = true;
            cuota_mensual.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            cuota_mensual.Location = new Point(574, 131);
            cuota_mensual.Name = "cuota_mensual";
            cuota_mensual.Size = new Size(50, 20);
            cuota_mensual.TabIndex = 13;
            cuota_mensual.Text = "label7";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.Red;
            button1.Location = new Point(496, 204);
            button1.Name = "button1";
            button1.Size = new Size(107, 47);
            button1.TabIndex = 14;
            button1.Text = "Calcular";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // butatrás
            // 
            butatrás.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            butatrás.Location = new Point(465, 313);
            butatrás.Name = "butatrás";
            butatrás.Size = new Size(95, 47);
            butatrás.TabIndex = 15;
            butatrás.Text = "Atrás";
            butatrás.UseVisualStyleBackColor = true;
            butatrás.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(301, 313);
            button3.Name = "button3";
            button3.Size = new Size(99, 47);
            button3.TabIndex = 16;
            button3.Text = "Enviar solicitud";
            button3.UseVisualStyleBackColor = true;
            // 
            // Datos_Préstamo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button3);
            Controls.Add(butatrás);
            Controls.Add(button1);
            Controls.Add(monto_total);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label_cuotam);
            Controls.Add(Label_montot);
            Controls.Add(plazo_meses);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(monto);
            Controls.Add(lblMonto);
            Controls.Add(T_prestamo);
            Controls.Add(Tipo_prestamo);
            Controls.Add(label1);
            Name = "Datos_Préstamo";
            Text = "Datos_Préstamo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox Tipo_prestamo;
        private Label T_prestamo;
        private Label lblMonto;
        private TextBox monto;
        private Label label2;
        private Label label3;
        private ComboBox plazo_meses;
        private Label Label_montot;
        private Label label_cuotam;
        private Label label4;
        private Label label5;
        private Label monto_total;
        private Label cuota_mensual;
        private Button button1;
        private Button butatrás;
        private Button button3;
    }
}