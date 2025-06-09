namespace Ejercicio7
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
            nudRubro = new NumericUpDown();
            tbResultados = new TextBox();
            btnIngresar = new Button();
            btnTransaccionMayor = new Button();
            button3 = new Button();
            button4 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            nudCantidadProductos = new NumericUpDown();
            textBox2 = new TextBox();
            label5 = new Label();
            tbNumeroTransaccion = new TextBox();
            ((System.ComponentModel.ISupportInitialize)nudRubro).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudCantidadProductos).BeginInit();
            SuspendLayout();
            // 
            // nudRubro
            // 
            nudRubro.Location = new Point(219, 84);
            nudRubro.Margin = new Padding(4);
            nudRubro.Maximum = new decimal(new int[] { 5, 0, 0, 0 });
            nudRubro.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudRubro.Name = "nudRubro";
            nudRubro.Size = new Size(133, 29);
            nudRubro.TabIndex = 2;
            nudRubro.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // tbResultados
            // 
            tbResultados.Location = new Point(23, 251);
            tbResultados.Margin = new Padding(4);
            tbResultados.Multiline = true;
            tbResultados.Name = "tbResultados";
            tbResultados.Size = new Size(329, 239);
            tbResultados.TabIndex = 4;
            // 
            // btnIngresar
            // 
            btnIngresar.Location = new Point(389, 72);
            btnIngresar.Margin = new Padding(4);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(151, 82);
            btnIngresar.TabIndex = 5;
            btnIngresar.Text = "Ingresar Resumen de Venta";
            btnIngresar.UseVisualStyleBackColor = true;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // btnTransaccionMayor
            // 
            btnTransaccionMayor.Location = new Point(377, 251);
            btnTransaccionMayor.Margin = new Padding(4);
            btnTransaccionMayor.Name = "btnTransaccionMayor";
            btnTransaccionMayor.Size = new Size(174, 72);
            btnTransaccionMayor.TabIndex = 6;
            btnTransaccionMayor.Text = "Transacción mayor monto";
            btnTransaccionMayor.UseVisualStyleBackColor = true;
            btnTransaccionMayor.Click += btnTransaccionMayor_Click;
            // 
            // button3
            // 
            button3.Location = new Point(377, 331);
            button3.Margin = new Padding(4);
            button3.Name = "button3";
            button3.Size = new Size(174, 66);
            button3.TabIndex = 7;
            button3.Text = "Porcentaje de cantidad por rubro";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(377, 405);
            button4.Margin = new Padding(4);
            button4.Name = "button4";
            button4.Size = new Size(174, 70);
            button4.TabIndex = 8;
            button4.Text = "Recaudación Total";
            button4.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(39, 43);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(172, 21);
            label1.TabIndex = 9;
            label1.Text = "Número de transacción";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(158, 84);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(53, 21);
            label2.TabIndex = 10;
            label2.Text = "Rubro";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(39, 127);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(167, 21);
            label3.TabIndex = 11;
            label3.Text = "Cantidad de Productos";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(114, 171);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(92, 21);
            label4.TabIndex = 12;
            label4.Text = "Monto Total";
            // 
            // nudCantidadProductos
            // 
            nudCantidadProductos.Location = new Point(219, 125);
            nudCantidadProductos.Margin = new Padding(4);
            nudCantidadProductos.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            nudCantidadProductos.Name = "nudCantidadProductos";
            nudCantidadProductos.Size = new Size(133, 29);
            nudCantidadProductos.TabIndex = 13;
            nudCantidadProductos.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // textBox2
            // 
            textBox2.Location = new Point(219, 168);
            textBox2.Margin = new Padding(4);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(127, 29);
            textBox2.TabIndex = 14;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(23, 226);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(86, 21);
            label5.TabIndex = 15;
            label5.Text = "Resultados";
            // 
            // tbNumeroTransaccion
            // 
            tbNumeroTransaccion.Location = new Point(219, 40);
            tbNumeroTransaccion.Margin = new Padding(4);
            tbNumeroTransaccion.Name = "tbNumeroTransaccion";
            tbNumeroTransaccion.Size = new Size(127, 29);
            tbNumeroTransaccion.TabIndex = 16;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(562, 518);
            Controls.Add(tbNumeroTransaccion);
            Controls.Add(label5);
            Controls.Add(textBox2);
            Controls.Add(nudCantidadProductos);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(btnTransaccionMayor);
            Controls.Add(btnIngresar);
            Controls.Add(tbResultados);
            Controls.Add(nudRubro);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "FormPrincipal";
            Text = "Rubros";
            ((System.ComponentModel.ISupportInitialize)nudRubro).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudCantidadProductos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private ComboBox comboBox1;
        private NumericUpDown nudRubro;
        private TextBox tbResultados;
        private Button btnIngresar;
        private Button btnTransaccionMayor;
        private Button button3;
        private Button button4;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private NumericUpDown nudCantidadProductos;
        private TextBox textBox2;
        private Label label5;
        private TextBox tbNumeroTransaccion;
    }
}
