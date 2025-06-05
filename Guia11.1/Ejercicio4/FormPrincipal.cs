using Ejercicio4.Models;

namespace Ejercicio4
{
    public partial class FormPrincipal : Form
    {
        Servicio servicio = new Servicio();

        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {

            servicio.RegistrarJugadores(tbNombre1.Text, tbNombre2.Text);

            groupBox1.Enabled = false;
            groupBox2.Enabled = true;
        }

        private void btnAnotar_Click(object sender, EventArgs e)
        {
            int resultado1 = Convert.ToInt32(nudResultado1.Value);
            int resultado2 = Convert.ToInt32(nudResultado2.Value);
            servicio.RegistrarResultadoSet(resultado1, resultado2);

            lbNroSet.Text = $"{servicio.NumeroSetsRegistrados+1}";
            nudResultado1.Value = 0;
            nudResultado2.Value = 0;

            if (servicio.NumeroSetsRegistrados == 3)
            {
                groupBox2.Enabled = false;
                groupBox3.Enabled = false;
                tbResultado.Text = $"El ganador es: {servicio.DeterminarGanador()}";
            }
        }
    }
}
