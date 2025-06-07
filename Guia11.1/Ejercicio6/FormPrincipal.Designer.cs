namespace Ejercicio6
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
            btnRegistrar = new Button();
            groupBox3 = new GroupBox();
            tbDistancia = new TextBox();
            groupBox2 = new GroupBox();
            rbPublico = new RadioButton();
            rbAutomovil = new RadioButton();
            rbMotocicleta = new RadioButton();
            rbBicicleta = new RadioButton();
            groupBox4 = new GroupBox();
            btnVer = new Button();
            tbResultados = new TextBox();
            groupBox1.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnRegistrar);
            groupBox1.Controls.Add(groupBox3);
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Location = new Point(15, 17);
            groupBox1.Margin = new Padding(4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4);
            groupBox1.Size = new Size(541, 245);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ingresar número";
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(430, 105);
            btnRegistrar.Margin = new Padding(4);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(96, 61);
            btnRegistrar.TabIndex = 3;
            btnRegistrar.Text = "Registrar Encuesta";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(tbDistancia);
            groupBox3.Location = new Point(16, 161);
            groupBox3.Margin = new Padding(4);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(4);
            groupBox3.Size = new Size(404, 74);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Distancia aproximada según el vehículo seleccionado";
            // 
            // tbDistancia
            // 
            tbDistancia.Location = new Point(116, 30);
            tbDistancia.Margin = new Padding(4);
            tbDistancia.Name = "tbDistancia";
            tbDistancia.Size = new Size(127, 29);
            tbDistancia.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(rbPublico);
            groupBox2.Controls.Add(rbAutomovil);
            groupBox2.Controls.Add(rbMotocicleta);
            groupBox2.Controls.Add(rbBicicleta);
            groupBox2.Location = new Point(16, 30);
            groupBox2.Margin = new Padding(4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(4);
            groupBox2.Size = new Size(404, 129);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Tipo de transporte de uso más frecuente";
            // 
            // rbPublico
            // 
            rbPublico.AutoSize = true;
            rbPublico.Location = new Point(32, 98);
            rbPublico.Margin = new Padding(4);
            rbPublico.Name = "rbPublico";
            rbPublico.Size = new Size(301, 25);
            rbPublico.TabIndex = 4;
            rbPublico.TabStop = true;
            rbPublico.Text = "Transporte público(colectivo, remis, etc)";
            rbPublico.UseVisualStyleBackColor = true;
            // 
            // rbAutomovil
            // 
            rbAutomovil.AutoSize = true;
            rbAutomovil.Location = new Point(32, 75);
            rbAutomovil.Margin = new Padding(4);
            rbAutomovil.Name = "rbAutomovil";
            rbAutomovil.Size = new Size(100, 25);
            rbAutomovil.TabIndex = 2;
            rbAutomovil.TabStop = true;
            rbAutomovil.Text = "Automovil";
            rbAutomovil.UseVisualStyleBackColor = true;
            // 
            // rbMotocicleta
            // 
            rbMotocicleta.AutoSize = true;
            rbMotocicleta.Location = new Point(32, 53);
            rbMotocicleta.Margin = new Padding(4);
            rbMotocicleta.Name = "rbMotocicleta";
            rbMotocicleta.Size = new Size(108, 25);
            rbMotocicleta.TabIndex = 1;
            rbMotocicleta.TabStop = true;
            rbMotocicleta.Text = "Motocicleta";
            rbMotocicleta.UseVisualStyleBackColor = true;
            // 
            // rbBicicleta
            // 
            rbBicicleta.AutoSize = true;
            rbBicicleta.Location = new Point(32, 30);
            rbBicicleta.Margin = new Padding(4);
            rbBicicleta.Name = "rbBicicleta";
            rbBicicleta.Size = new Size(84, 25);
            rbBicicleta.TabIndex = 0;
            rbBicicleta.TabStop = true;
            rbBicicleta.Text = "Bicicleta";
            rbBicicleta.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(btnVer);
            groupBox4.Controls.Add(tbResultados);
            groupBox4.Location = new Point(15, 270);
            groupBox4.Margin = new Padding(4);
            groupBox4.Name = "groupBox4";
            groupBox4.Padding = new Padding(4);
            groupBox4.Size = new Size(541, 237);
            groupBox4.TabIndex = 1;
            groupBox4.TabStop = false;
            groupBox4.Text = "Resultados";
            // 
            // btnVer
            // 
            btnVer.Location = new Point(432, 83);
            btnVer.Margin = new Padding(4);
            btnVer.Name = "btnVer";
            btnVer.Size = new Size(96, 76);
            btnVer.TabIndex = 5;
            btnVer.Text = "Ver Resultados";
            btnVer.UseVisualStyleBackColor = true;
            btnVer.Click += btnVer_Click;
            // 
            // tbResultados
            // 
            tbResultados.Location = new Point(8, 31);
            tbResultados.Margin = new Padding(4);
            tbResultados.Multiline = true;
            tbResultados.Name = "tbResultados";
            tbResultados.Size = new Size(414, 196);
            tbResultados.TabIndex = 0;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(593, 510);
            Controls.Add(groupBox4);
            Controls.Add(groupBox1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "FormPrincipal";
            Text = "Encuesta de transporte";
            groupBox1.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnRegistrar;
        private GroupBox groupBox3;
        private TextBox tbDistancia;
        private GroupBox groupBox2;
        private RadioButton rbPublico;
        private RadioButton rbAutomovil;
        private RadioButton rbMotocicleta;
        private RadioButton rbBicicleta;
        private GroupBox groupBox4;
        private Button btnVer;
        private TextBox tbResultados;
    }
}
