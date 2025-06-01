namespace Ejercicio1
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
            btnReiniciar = new Button();
            groupBox4 = new GroupBox();
            lbCantidad = new Label();
            label12 = new Label();
            btnMostrarCantidad = new Button();
            groupBox3 = new GroupBox();
            lbPromedio = new Label();
            label8 = new Label();
            btnMostrarPromedio = new Button();
            groupBox2 = new GroupBox();
            label5 = new Label();
            lbMinimo = new Label();
            lbMaximo = new Label();
            label2 = new Label();
            btnMostrarMaximoMinimo = new Button();
            groupBox1 = new GroupBox();
            label1 = new Label();
            btnRegistrarNumero = new Button();
            tbValor = new TextBox();
            groupBox4.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnReiniciar
            // 
            btnReiniciar.Location = new Point(159, 462);
            btnReiniciar.Margin = new Padding(5, 6, 5, 6);
            btnReiniciar.Name = "btnReiniciar";
            btnReiniciar.Size = new Size(197, 45);
            btnReiniciar.TabIndex = 7;
            btnReiniciar.Text = "Reiniciar variables";
            btnReiniciar.UseVisualStyleBackColor = true;
            btnReiniciar.Click += btnReiniciar_Click;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(lbCantidad);
            groupBox4.Controls.Add(label12);
            groupBox4.Controls.Add(btnMostrarCantidad);
            groupBox4.Location = new Point(17, 372);
            groupBox4.Margin = new Padding(5, 6, 5, 6);
            groupBox4.Name = "groupBox4";
            groupBox4.Padding = new Padding(5, 6, 5, 6);
            groupBox4.Size = new Size(492, 78);
            groupBox4.TabIndex = 10;
            groupBox4.TabStop = false;
            groupBox4.Text = "Mostrar Cantidad de ingresados";
            // 
            // lbCantidad
            // 
            lbCantidad.AutoSize = true;
            lbCantidad.BackColor = SystemColors.ActiveCaption;
            lbCantidad.Location = new Point(205, 40);
            lbCantidad.Margin = new Padding(5, 0, 5, 0);
            lbCantidad.Name = "lbCantidad";
            lbCantidad.Size = new Size(85, 21);
            lbCantidad.TabIndex = 2;
            lbCantidad.Text = "lbCantidad";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(105, 40);
            label12.Margin = new Padding(5, 0, 5, 0);
            label12.Name = "label12";
            label12.Size = new Size(75, 21);
            label12.TabIndex = 1;
            label12.Text = "Cantidad:";
            // 
            // btnMostrarCantidad
            // 
            btnMostrarCantidad.Location = new Point(344, 23);
            btnMostrarCantidad.Margin = new Padding(5, 6, 5, 6);
            btnMostrarCantidad.Name = "btnMostrarCantidad";
            btnMostrarCantidad.Size = new Size(123, 44);
            btnMostrarCantidad.TabIndex = 0;
            btnMostrarCantidad.Text = "Actualizar";
            btnMostrarCantidad.UseVisualStyleBackColor = true;
            btnMostrarCantidad.Click += btnMostrarCantidad_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(lbPromedio);
            groupBox3.Controls.Add(label8);
            groupBox3.Controls.Add(btnMostrarPromedio);
            groupBox3.Location = new Point(17, 281);
            groupBox3.Margin = new Padding(5, 6, 5, 6);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(5, 6, 5, 6);
            groupBox3.Size = new Size(492, 88);
            groupBox3.TabIndex = 9;
            groupBox3.TabStop = false;
            groupBox3.Text = "Procesar promedio";
            // 
            // lbPromedio
            // 
            lbPromedio.AutoSize = true;
            lbPromedio.BackColor = SystemColors.ActiveCaption;
            lbPromedio.Location = new Point(205, 46);
            lbPromedio.Margin = new Padding(5, 0, 5, 0);
            lbPromedio.Name = "lbPromedio";
            lbPromedio.Size = new Size(91, 21);
            lbPromedio.TabIndex = 2;
            lbPromedio.Text = "lbPromedio";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(71, 46);
            label8.Margin = new Padding(5, 0, 5, 0);
            label8.Name = "label8";
            label8.Size = new Size(109, 21);
            label8.TabIndex = 1;
            label8.Text = "Valor máximo:";
            // 
            // btnMostrarPromedio
            // 
            btnMostrarPromedio.Location = new Point(344, 34);
            btnMostrarPromedio.Margin = new Padding(5, 6, 5, 6);
            btnMostrarPromedio.Name = "btnMostrarPromedio";
            btnMostrarPromedio.Size = new Size(123, 45);
            btnMostrarPromedio.TabIndex = 0;
            btnMostrarPromedio.Text = "Actualizar";
            btnMostrarPromedio.UseVisualStyleBackColor = true;
            btnMostrarPromedio.Click += btnMostrarPromedio_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(lbMinimo);
            groupBox2.Controls.Add(lbMaximo);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(btnMostrarMaximoMinimo);
            groupBox2.Location = new Point(17, 156);
            groupBox2.Margin = new Padding(5, 6, 5, 6);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(5, 6, 5, 6);
            groupBox2.Size = new Size(492, 113);
            groupBox2.TabIndex = 8;
            groupBox2.TabStop = false;
            groupBox2.Text = "Procesar máximo y mínimo";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(73, 70);
            label5.Margin = new Padding(5, 0, 5, 0);
            label5.Name = "label5";
            label5.Size = new Size(107, 21);
            label5.TabIndex = 3;
            label5.Text = "Valor mínimo:";
            // 
            // lbMinimo
            // 
            lbMinimo.AutoSize = true;
            lbMinimo.BackColor = SystemColors.ActiveCaption;
            lbMinimo.Location = new Point(204, 70);
            lbMinimo.Margin = new Padding(5, 0, 5, 0);
            lbMinimo.Name = "lbMinimo";
            lbMinimo.Size = new Size(77, 21);
            lbMinimo.TabIndex = 3;
            lbMinimo.Text = "lbMinimo";
            // 
            // lbMaximo
            // 
            lbMaximo.AutoSize = true;
            lbMaximo.BackColor = SystemColors.ActiveCaption;
            lbMaximo.Location = new Point(204, 39);
            lbMaximo.Margin = new Padding(5, 0, 5, 0);
            lbMaximo.Name = "lbMaximo";
            lbMaximo.Size = new Size(79, 21);
            lbMaximo.TabIndex = 2;
            lbMaximo.Text = "lbMaximo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(71, 39);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(109, 21);
            label2.TabIndex = 1;
            label2.Text = "Valor máximo:";
            // 
            // btnMostrarMaximoMinimo
            // 
            btnMostrarMaximoMinimo.Location = new Point(341, 46);
            btnMostrarMaximoMinimo.Margin = new Padding(5, 6, 5, 6);
            btnMostrarMaximoMinimo.Name = "btnMostrarMaximoMinimo";
            btnMostrarMaximoMinimo.Size = new Size(123, 45);
            btnMostrarMaximoMinimo.TabIndex = 0;
            btnMostrarMaximoMinimo.Text = "Actualizar";
            btnMostrarMaximoMinimo.UseVisualStyleBackColor = true;
            btnMostrarMaximoMinimo.Click += btnMostrarMaximoMinimo_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(btnRegistrarNumero);
            groupBox1.Controls.Add(tbValor);
            groupBox1.Location = new Point(17, 18);
            groupBox1.Margin = new Padding(5, 6, 5, 6);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(5, 6, 5, 6);
            groupBox1.Size = new Size(492, 136);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Procesar número";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(85, 40);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(142, 21);
            label1.TabIndex = 2;
            label1.Text = "Ingrese un número";
            // 
            // btnRegistrarNumero
            // 
            btnRegistrarNumero.Location = new Point(171, 78);
            btnRegistrarNumero.Margin = new Padding(5, 6, 5, 6);
            btnRegistrarNumero.Name = "btnRegistrarNumero";
            btnRegistrarNumero.Size = new Size(158, 48);
            btnRegistrarNumero.TabIndex = 1;
            btnRegistrarNumero.Text = "Registrar número";
            btnRegistrarNumero.UseVisualStyleBackColor = true;
            btnRegistrarNumero.Click += btnRegistrarNumero_Click;
            // 
            // tbValor
            // 
            tbValor.Location = new Point(258, 37);
            tbValor.Margin = new Padding(5, 6, 5, 6);
            tbValor.Name = "tbValor";
            tbValor.Size = new Size(112, 29);
            tbValor.TabIndex = 0;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(523, 513);
            Controls.Add(btnReiniciar);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "FormPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ejercicio 1 - Introduccion";
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
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
        private GroupBox groupBox3;
        private Label lbPromedio;
        private Label label8;
        private Button btnMostrarPromedio;
        private GroupBox groupBox2;
        private Label label5;
        private Label lbMinimo;
        private Label lbMaximo;
        private Label label2;
        private Button btnMostrarMaximoMinimo;
        private GroupBox groupBox1;
        private Label label1;
        private Button btnRegistrarNumero;
        private TextBox tbValor;
    }
}
