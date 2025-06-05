namespace Ejercicio4
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
            groupBox1 = new GroupBox();
            label3 = new Label();
            tbNombre2 = new TextBox();
            tbNombre1 = new TextBox();
            label1 = new Label();
            btnRegistrar = new Button();
            groupBox2 = new GroupBox();
            lbNroSet = new Label();
            label5 = new Label();
            label4 = new Label();
            nudResultado2 = new NumericUpDown();
            nudResultado1 = new NumericUpDown();
            label2 = new Label();
            btnAnotar = new Button();
            tbResultado = new TextBox();
            groupBox3 = new GroupBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudResultado2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudResultado1).BeginInit();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(tbNombre2);
            groupBox1.Controls.Add(tbNombre1);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(btnRegistrar);
            groupBox1.Location = new Point(15, 17);
            groupBox1.Margin = new Padding(4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4);
            groupBox1.Size = new Size(455, 118);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Registrar Jugador";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(30, 75);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(141, 21);
            label3.TabIndex = 4;
            label3.Text = "Nombre Jugador 2";
            // 
            // tbNombre2
            // 
            tbNombre2.Location = new Point(179, 75);
            tbNombre2.Margin = new Padding(4);
            tbNombre2.Name = "tbNombre2";
            tbNombre2.Size = new Size(143, 29);
            tbNombre2.TabIndex = 3;
            tbNombre2.Text = "tbNombre2";
            // 
            // tbNombre1
            // 
            tbNombre1.Location = new Point(179, 38);
            tbNombre1.Margin = new Padding(4);
            tbNombre1.Name = "tbNombre1";
            tbNombre1.Size = new Size(143, 29);
            tbNombre1.TabIndex = 2;
            tbNombre1.Text = "tbNombre1";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 41);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(141, 21);
            label1.TabIndex = 1;
            label1.Text = "Nombre Jugador 1";
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(344, 41);
            btnRegistrar.Margin = new Padding(4);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(96, 55);
            btnRegistrar.TabIndex = 0;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lbNroSet);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(nudResultado2);
            groupBox2.Controls.Add(nudResultado1);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(btnAnotar);
            groupBox2.Enabled = false;
            groupBox2.Location = new Point(13, 143);
            groupBox2.Margin = new Padding(4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(4);
            groupBox2.Size = new Size(457, 145);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Anotar Sets";
            // 
            // lbNroSet
            // 
            lbNroSet.AutoSize = true;
            lbNroSet.BackColor = SystemColors.ActiveCaption;
            lbNroSet.Location = new Point(222, 26);
            lbNroSet.Margin = new Padding(4, 0, 4, 0);
            lbNroSet.Name = "lbNroSet";
            lbNroSet.Size = new Size(72, 21);
            lbNroSet.TabIndex = 6;
            lbNroSet.Text = "lbNroSet";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(121, 26);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(97, 21);
            label5.TabIndex = 5;
            label5.Text = "Número Set:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(166, 63);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(79, 21);
            label4.TabIndex = 4;
            label4.Text = "Jugador 2";
            // 
            // nudResultado2
            // 
            nudResultado2.Location = new Point(166, 90);
            nudResultado2.Margin = new Padding(5, 6, 5, 6);
            nudResultado2.Name = "nudResultado2";
            nudResultado2.Size = new Size(91, 29);
            nudResultado2.TabIndex = 3;
            // 
            // nudResultado1
            // 
            nudResultado1.Location = new Point(30, 91);
            nudResultado1.Margin = new Padding(5, 6, 5, 6);
            nudResultado1.Name = "nudResultado1";
            nudResultado1.Size = new Size(96, 29);
            nudResultado1.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 64);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(79, 21);
            label2.TabIndex = 1;
            label2.Text = "Jugador 1";
            // 
            // btnAnotar
            // 
            btnAnotar.Location = new Point(346, 75);
            btnAnotar.Margin = new Padding(4);
            btnAnotar.Name = "btnAnotar";
            btnAnotar.Size = new Size(96, 55);
            btnAnotar.TabIndex = 0;
            btnAnotar.Text = "Anotar";
            btnAnotar.UseVisualStyleBackColor = true;
            btnAnotar.Click += btnAnotar_Click;
            // 
            // tbResultado
            // 
            tbResultado.Location = new Point(8, 30);
            tbResultado.Margin = new Padding(4);
            tbResultado.Multiline = true;
            tbResultado.Name = "tbResultado";
            tbResultado.Size = new Size(441, 102);
            tbResultado.TabIndex = 2;
            tbResultado.Text = "tbResultado";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(tbResultado);
            groupBox3.Enabled = false;
            groupBox3.Location = new Point(13, 296);
            groupBox3.Margin = new Padding(4);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(4);
            groupBox3.Size = new Size(457, 140);
            groupBox3.TabIndex = 3;
            groupBox3.TabStop = false;
            groupBox3.Text = "Resumen";
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(478, 441);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4);
            Name = "FormPrincipal";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudResultado2).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudResultado1).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox tbNombre1;
        private Label label1;
        private Button btnRegistrar;
        private GroupBox groupBox2;
        private Label label2;
        private Button btnAnotar;
        private Label label3;
        private TextBox tbNombre2;
        private Label lbNroSet;
        private Label label5;
        private Label label4;
        private NumericUpDown nudResultado2;
        private NumericUpDown nudResultado1;
        private TextBox tbResultado;
        private GroupBox groupBox3;
    }
}
