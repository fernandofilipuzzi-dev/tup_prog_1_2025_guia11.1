namespace Ejercicio3
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
            btnMostrarListaOrdenada = new Button();
            tbResultado = new TextBox();
            groupBox1 = new GroupBox();
            label5 = new Label();
            tbNombre3 = new TextBox();
            label6 = new Label();
            tbLibreta3 = new TextBox();
            label3 = new Label();
            tbNombre2 = new TextBox();
            label4 = new Label();
            tbLibreta2 = new TextBox();
            label2 = new Label();
            tbNombre1 = new TextBox();
            label1 = new Label();
            btnRegistrarAlumno = new Button();
            tbLibreta1 = new TextBox();
            groupBox4.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(btnMostrarListaOrdenada);
            groupBox4.Controls.Add(tbResultado);
            groupBox4.Location = new Point(15, 265);
            groupBox4.Margin = new Padding(6, 8, 6, 8);
            groupBox4.Name = "groupBox4";
            groupBox4.Padding = new Padding(6, 8, 6, 8);
            groupBox4.Size = new Size(482, 185);
            groupBox4.TabIndex = 18;
            groupBox4.TabStop = false;
            groupBox4.Text = "Mostrar Lista Ordenada";
            // 
            // btnMostrarListaOrdenada
            // 
            btnMostrarListaOrdenada.Location = new Point(384, 78);
            btnMostrarListaOrdenada.Margin = new Padding(6, 8, 6, 8);
            btnMostrarListaOrdenada.Name = "btnMostrarListaOrdenada";
            btnMostrarListaOrdenada.Size = new Size(89, 50);
            btnMostrarListaOrdenada.TabIndex = 24;
            btnMostrarListaOrdenada.Text = "Actualizar";
            btnMostrarListaOrdenada.UseVisualStyleBackColor = true;
            btnMostrarListaOrdenada.Click += btnMostrarListaOrdenada_Click;
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
            // groupBox1
            // 
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(tbNombre3);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(tbLibreta3);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(tbNombre2);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(tbLibreta2);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(tbNombre1);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(btnRegistrarAlumno);
            groupBox1.Controls.Add(tbLibreta1);
            groupBox1.Location = new Point(15, 17);
            groupBox1.Margin = new Padding(6, 8, 6, 8);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(6, 8, 6, 8);
            groupBox1.Size = new Size(482, 242);
            groupBox1.TabIndex = 16;
            groupBox1.TabStop = false;
            groupBox1.Text = "Registro del alumno (libreta y nombre)";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(43, 130);
            label5.Margin = new Padding(6, 0, 6, 0);
            label5.Name = "label5";
            label5.Size = new Size(61, 21);
            label5.TabIndex = 12;
            label5.Text = "Libreta:";
            // 
            // tbNombre3
            // 
            tbNombre3.Location = new Point(357, 127);
            tbNombre3.Margin = new Padding(6, 8, 6, 8);
            tbNombre3.Name = "tbNombre3";
            tbNombre3.Size = new Size(111, 29);
            tbNombre3.TabIndex = 11;
            tbNombre3.Text = "tbNombre3";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(274, 130);
            label6.Margin = new Padding(6, 0, 6, 0);
            label6.Name = "label6";
            label6.Size = new Size(71, 21);
            label6.TabIndex = 10;
            label6.Text = "Nombre:";
            // 
            // tbLibreta3
            // 
            tbLibreta3.Location = new Point(126, 127);
            tbLibreta3.Margin = new Padding(6, 8, 6, 8);
            tbLibreta3.Name = "tbLibreta3";
            tbLibreta3.Size = new Size(111, 29);
            tbLibreta3.TabIndex = 9;
            tbLibreta3.Text = "tbLibreta3";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(43, 85);
            label3.Margin = new Padding(6, 0, 6, 0);
            label3.Name = "label3";
            label3.Size = new Size(61, 21);
            label3.TabIndex = 8;
            label3.Text = "Libreta:";
            // 
            // tbNombre2
            // 
            tbNombre2.Location = new Point(357, 82);
            tbNombre2.Margin = new Padding(6, 8, 6, 8);
            tbNombre2.Name = "tbNombre2";
            tbNombre2.Size = new Size(111, 29);
            tbNombre2.TabIndex = 7;
            tbNombre2.Text = "tbNombre2";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(274, 85);
            label4.Margin = new Padding(6, 0, 6, 0);
            label4.Name = "label4";
            label4.Size = new Size(71, 21);
            label4.TabIndex = 6;
            label4.Text = "Nombre:";
            // 
            // tbLibreta2
            // 
            tbLibreta2.Location = new Point(126, 82);
            tbLibreta2.Margin = new Padding(6, 8, 6, 8);
            tbLibreta2.Name = "tbLibreta2";
            tbLibreta2.Size = new Size(111, 29);
            tbLibreta2.TabIndex = 5;
            tbLibreta2.Text = "tbLibreta2";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(43, 40);
            label2.Margin = new Padding(6, 0, 6, 0);
            label2.Name = "label2";
            label2.Size = new Size(61, 21);
            label2.TabIndex = 4;
            label2.Text = "Libreta:";
            // 
            // tbNombre1
            // 
            tbNombre1.Location = new Point(357, 37);
            tbNombre1.Margin = new Padding(6, 8, 6, 8);
            tbNombre1.Name = "tbNombre1";
            tbNombre1.Size = new Size(111, 29);
            tbNombre1.TabIndex = 3;
            tbNombre1.Text = "tbNombre1";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(274, 40);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(71, 21);
            label1.TabIndex = 2;
            label1.Text = "Nombre:";
            // 
            // btnRegistrarAlumno
            // 
            btnRegistrarAlumno.Location = new Point(163, 182);
            btnRegistrarAlumno.Margin = new Padding(6, 8, 6, 8);
            btnRegistrarAlumno.Name = "btnRegistrarAlumno";
            btnRegistrarAlumno.Size = new Size(144, 50);
            btnRegistrarAlumno.TabIndex = 1;
            btnRegistrarAlumno.Text = "Registrar Alumnos";
            btnRegistrarAlumno.UseVisualStyleBackColor = true;
            btnRegistrarAlumno.Click += btnbtnRegistrarAlumnos_Click;
            // 
            // tbLibreta1
            // 
            tbLibreta1.Location = new Point(126, 37);
            tbLibreta1.Margin = new Padding(6, 8, 6, 8);
            tbLibreta1.Name = "tbLibreta1";
            tbLibreta1.Size = new Size(111, 29);
            tbLibreta1.TabIndex = 0;
            tbLibreta1.Text = "tbLibreta1";
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(513, 457);
            Controls.Add(groupBox4);
            Controls.Add(groupBox1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4);
            Name = "FormPrincipal";
            Text = "Ejercicio 3. Lista ordenada";
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox4;
        private Button btnMostrarListaOrdenada;
        private TextBox tbResultado;
        private GroupBox groupBox1;
        private Label label1;
        private Button btnRegistrarAlumno;
        private TextBox tbLibreta1;
        private Label label5;
        private TextBox tbNombre3;
        private Label label6;
        private TextBox tbLibreta3;
        private Label label3;
        private TextBox tbNombre2;
        private Label label4;
        private TextBox tbLibreta2;
        private Label label2;
        private TextBox tbNombre1;
    }
}
