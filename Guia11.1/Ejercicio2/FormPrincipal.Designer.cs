namespace Ejercicio2
{
    partial class FormPrincipal
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
            groupBox4 = new GroupBox();
            btnMostrarMontoPorcentaje = new Button();
            tbResultado = new TextBox();
            groupBox2 = new GroupBox();
            btnRegistrarEdades = new Button();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            tbEdad4 = new TextBox();
            tbEdad3 = new TextBox();
            tbEdad2 = new TextBox();
            tbEdad1 = new TextBox();
            groupBox1 = new GroupBox();
            label1 = new Label();
            btnRegistrarMonto = new Button();
            tbMontoARepartir = new TextBox();
            groupBox4.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(btnMostrarMontoPorcentaje);
            groupBox4.Controls.Add(tbResultado);
            groupBox4.Location = new Point(15, 270);
            groupBox4.Margin = new Padding(6, 8, 6, 8);
            groupBox4.Name = "groupBox4";
            groupBox4.Padding = new Padding(6, 8, 6, 8);
            groupBox4.Size = new Size(482, 185);
            groupBox4.TabIndex = 15;
            groupBox4.TabStop = false;
            groupBox4.Text = "Monto y Porcentajes de las niñas";
            // 
            // btnMostrarMontoPorcentaje
            // 
            btnMostrarMontoPorcentaje.Location = new Point(384, 78);
            btnMostrarMontoPorcentaje.Margin = new Padding(6, 8, 6, 8);
            btnMostrarMontoPorcentaje.Name = "btnMostrarMontoPorcentaje";
            btnMostrarMontoPorcentaje.Size = new Size(89, 50);
            btnMostrarMontoPorcentaje.TabIndex = 24;
            btnMostrarMontoPorcentaje.Text = "Actualizar";
            btnMostrarMontoPorcentaje.UseVisualStyleBackColor = true;
            btnMostrarMontoPorcentaje.Click += btnMostrarMontoPorcentaje_Click;
            // 
            // tbResultado
            // 
            tbResultado.Location = new Point(12, 28);
            tbResultado.Margin = new Padding(6, 8, 6, 8);
            tbResultado.Multiline = true;
            tbResultado.Name = "tbResultado";
            tbResultado.Size = new Size(363, 148);
            tbResultado.TabIndex = 3;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnRegistrarEdades);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(tbEdad4);
            groupBox2.Controls.Add(tbEdad3);
            groupBox2.Controls.Add(tbEdad2);
            groupBox2.Controls.Add(tbEdad1);
            groupBox2.Location = new Point(15, 107);
            groupBox2.Margin = new Padding(6, 8, 6, 8);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(6, 8, 6, 8);
            groupBox2.Size = new Size(482, 159);
            groupBox2.TabIndex = 13;
            groupBox2.TabStop = false;
            groupBox2.Text = "Solicitud de las edades de las niñas";
            // 
            // btnRegistrarEdades
            // 
            btnRegistrarEdades.Location = new Point(143, 97);
            btnRegistrarEdades.Margin = new Padding(6, 8, 6, 8);
            btnRegistrarEdades.Name = "btnRegistrarEdades";
            btnRegistrarEdades.Size = new Size(171, 50);
            btnRegistrarEdades.TabIndex = 23;
            btnRegistrarEdades.Text = "Registrar edades";
            btnRegistrarEdades.UseVisualStyleBackColor = true;
            btnRegistrarEdades.Click += btnRegistrarEdades_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(270, 63);
            label5.Margin = new Padding(6, 0, 6, 0);
            label5.Name = "label5";
            label5.Size = new Size(57, 21);
            label5.TabIndex = 22;
            label5.Text = "Edad 4";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(270, 30);
            label4.Margin = new Padding(6, 0, 6, 0);
            label4.Name = "label4";
            label4.Size = new Size(60, 21);
            label4.TabIndex = 21;
            label4.Text = "Edad 3:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(54, 63);
            label3.Margin = new Padding(6, 0, 6, 0);
            label3.Name = "label3";
            label3.Size = new Size(60, 21);
            label3.TabIndex = 20;
            label3.Text = "Edad 2:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(58, 30);
            label2.Margin = new Padding(6, 0, 6, 0);
            label2.Name = "label2";
            label2.Size = new Size(56, 21);
            label2.TabIndex = 3;
            label2.Text = "Edad1:";
            // 
            // tbEdad4
            // 
            tbEdad4.Location = new Point(342, 60);
            tbEdad4.Margin = new Padding(6, 8, 6, 8);
            tbEdad4.Name = "tbEdad4";
            tbEdad4.Size = new Size(72, 29);
            tbEdad4.TabIndex = 19;
            tbEdad4.Text = "tbEdad4";
            // 
            // tbEdad3
            // 
            tbEdad3.Location = new Point(342, 27);
            tbEdad3.Margin = new Padding(6, 8, 6, 8);
            tbEdad3.Name = "tbEdad3";
            tbEdad3.Size = new Size(72, 29);
            tbEdad3.TabIndex = 18;
            tbEdad3.Text = "tbEdad3";
            // 
            // tbEdad2
            // 
            tbEdad2.Location = new Point(129, 60);
            tbEdad2.Margin = new Padding(6, 8, 6, 8);
            tbEdad2.Name = "tbEdad2";
            tbEdad2.Size = new Size(72, 29);
            tbEdad2.TabIndex = 17;
            tbEdad2.Text = "tbEdad2";
            // 
            // tbEdad1
            // 
            tbEdad1.Location = new Point(129, 27);
            tbEdad1.Margin = new Padding(6, 8, 6, 8);
            tbEdad1.Name = "tbEdad1";
            tbEdad1.Size = new Size(72, 29);
            tbEdad1.TabIndex = 16;
            tbEdad1.Text = "tbEdad1";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(btnRegistrarMonto);
            groupBox1.Controls.Add(tbMontoARepartir);
            groupBox1.Location = new Point(15, 21);
            groupBox1.Margin = new Padding(6, 8, 6, 8);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(6, 8, 6, 8);
            groupBox1.Size = new Size(482, 87);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            groupBox1.Text = "Solicitud de monto a repartir";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(51, 40);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(59, 21);
            label1.TabIndex = 2;
            label1.Text = "Monto:";
            // 
            // btnRegistrarMonto
            // 
            btnRegistrarMonto.Location = new Point(299, 25);
            btnRegistrarMonto.Margin = new Padding(6, 8, 6, 8);
            btnRegistrarMonto.Name = "btnRegistrarMonto";
            btnRegistrarMonto.Size = new Size(144, 50);
            btnRegistrarMonto.TabIndex = 1;
            btnRegistrarMonto.Text = "Registrar monto";
            btnRegistrarMonto.UseVisualStyleBackColor = true;
            btnRegistrarMonto.Click += btnRegistrarMonto_Click;
            // 
            // tbMontoARepartir
            // 
            tbMontoARepartir.Location = new Point(126, 37);
            tbMontoARepartir.Margin = new Padding(6, 8, 6, 8);
            tbMontoARepartir.Name = "tbMontoARepartir";
            tbMontoARepartir.Size = new Size(111, 29);
            tbMontoARepartir.TabIndex = 0;
            tbMontoARepartir.Text = "tbMonto";
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(514, 465);
            Controls.Add(groupBox4);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "FormPrincipal";
            Text = "Ejercicio 2 - las niñas";
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnReiniciar;
        private GroupBox groupBox4;
        private Label lbCantidad;
        private Label label12;
        private Button btnMostrarCantidad;
        private GroupBox groupBox2;
        private Button btnMostrarMaximoMinimo;
        private GroupBox groupBox1;
        private Label label1;
        private Button btnRegistrarMonto;
        private TextBox tbMontoARepartir;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox tbEdad4;
        private TextBox tbEdad3;
        private TextBox tbEdad2;
        private TextBox tbEdad1;
        private TextBox tbResultado;
        private Button btnMostrarMontoPorcentaje;
        private Button btnRegistrarEdades;
    }
}
