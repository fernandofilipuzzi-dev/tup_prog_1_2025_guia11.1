using Ejercicio1.Models;

namespace Ejercicio1
{
    public partial class FormPrincipal : Form
    {
        Servicio servicio = new Servicio();

        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void btnRegistrarNumero_Click(object sender, EventArgs e)
        {
            int valor = Convert.ToInt32(tbValor.Text);
            servicio.RegistrarValor(valor);

            tbValor.Clear();
        }

        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            servicio = new Servicio();
        }

        private void btnMostrarMaximoMinimo_Click(object sender, EventArgs e)
        {
            if (servicio.Contador > 0)
            {
                lbMaximo.Text = $"{servicio.Maximo}";
                lbMinimo.Text = $"{servicio.Minimo}";
            }
            else
            {
                lbMaximo.Text = $"-";
                lbMinimo.Text = $"-";
            }
        }

        private void btnMostrarPromedio_Click(object sender, EventArgs e)
        {
            if (servicio.Contador > 0)
            {
                lbPromedio.Text = $"{servicio.CalcularPromedio():f2}";
            }
            else
            {
                lbPromedio.Text = $"-";
            }
        }

        private void btnMostrarCantidad_Click(object sender, EventArgs e)
        {
            if (servicio.Contador > 0)
            {
                lbCantidad.Text = $"{servicio.Contador}";
            }
            else
            {
                lbCantidad.Text = $"-";
            }
        }
    }
}
