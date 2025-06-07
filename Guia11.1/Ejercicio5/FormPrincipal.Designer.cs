namespace Ejercicio5
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
            btnCalcular = new Button();
            groupBox1 = new GroupBox();
            label3 = new Label();
            label2 = new Label();
            lbEsBisiesto = new Label();
            label4 = new Label();
            nudAño = new NumericUpDown();
            label1 = new Label();
            lbCantidadDias = new Label();
            nudMes = new NumericUpDown();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudAño).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudMes).BeginInit();
            SuspendLayout();
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(315, 51);
            btnCalcular.Margin = new Padding(4);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(125, 78);
            btnCalcular.TabIndex = 0;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(lbEsBisiesto);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(nudAño);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(lbCantidadDias);
            groupBox1.Controls.Add(nudMes);
            groupBox1.Controls.Add(btnCalcular);
            groupBox1.Location = new Point(13, 13);
            groupBox1.Margin = new Padding(4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4);
            groupBox1.Size = new Size(464, 175);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Determinar los días del mes";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(47, 130);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(128, 21);
            label3.TabIndex = 4;
            label3.Text = "¿Es Año Bisiesto?";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(47, 105);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(128, 21);
            label2.TabIndex = 4;
            label2.Text = "Cantidad de días:";
            // 
            // lbEsBisiesto
            // 
            lbEsBisiesto.AutoSize = true;
            lbEsBisiesto.BackColor = SystemColors.ActiveCaption;
            lbEsBisiesto.Location = new Point(184, 130);
            lbEsBisiesto.Margin = new Padding(4, 0, 4, 0);
            lbEsBisiesto.Name = "lbEsBisiesto";
            lbEsBisiesto.Size = new Size(91, 21);
            lbEsBisiesto.TabIndex = 2;
            lbEsBisiesto.Text = "lbEsBisiesto";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(184, 26);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(38, 21);
            label4.TabIndex = 3;
            label4.Text = "Año";
            // 
            // nudAño
            // 
            nudAño.Location = new Point(183, 51);
            nudAño.Margin = new Padding(5, 6, 5, 6);
            nudAño.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            nudAño.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudAño.Name = "nudAño";
            nudAño.Size = new Size(90, 29);
            nudAño.TabIndex = 1;
            nudAño.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(88, 26);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(42, 21);
            label1.TabIndex = 3;
            label1.Text = "Mes:";
            // 
            // lbCantidadDias
            // 
            lbCantidadDias.AutoSize = true;
            lbCantidadDias.BackColor = SystemColors.ActiveCaption;
            lbCantidadDias.Location = new Point(183, 105);
            lbCantidadDias.Margin = new Padding(4, 0, 4, 0);
            lbCantidadDias.Name = "lbCantidadDias";
            lbCantidadDias.Size = new Size(115, 21);
            lbCantidadDias.TabIndex = 2;
            lbCantidadDias.Text = "lbCantidadDias";
            // 
            // nudMes
            // 
            nudMes.Location = new Point(75, 51);
            nudMes.Margin = new Padding(4);
            nudMes.Maximum = new decimal(new int[] { 12, 0, 0, 0 });
            nudMes.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudMes.Name = "nudMes";
            nudMes.Size = new Size(70, 29);
            nudMes.TabIndex = 1;
            nudMes.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(488, 197);
            Controls.Add(groupBox1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4);
            Name = "FormPrincipal";
            Text = "Año bisiesto";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudAño).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudMes).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnCalcular;
        private GroupBox groupBox1;
        private Label label1;
        private Label lbCantidadDias;
        private NumericUpDown nudMes;
        private Label label2;
        private Label label4;
        private NumericUpDown nudAño;
        private Label label3;
        private Label lbEsBisiesto;
    }
}
