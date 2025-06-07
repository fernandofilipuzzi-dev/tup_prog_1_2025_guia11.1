using Ejercicio5.Models;

namespace Ejercicio5
{
    public partial class FormPrincipal : Form
    {
        Servicio servicio = new Servicio();

        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int mes = Convert.ToInt32(nudMes.Value);
            int a�o = Convert.ToInt32(nudA�o.Value);
            lbCantidadDias.Text = $"{servicio.DeterminarLosD�asDelMes(mes, a�o)}";

            if (servicio.DeterminarSiEsBisiesto(a�o))
            {
                lbEsBisiesto.Text = "Es a�o bisiesto";
            }
            else 
            {
                lbEsBisiesto.Text = "No es a�o bisiesto";
            }
        }
    }
}
