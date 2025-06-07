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
            int año = Convert.ToInt32(nudAño.Value);
            lbCantidadDias.Text = $"{servicio.DeterminarLosDíasDelMes(mes, año)}";

            if (servicio.DeterminarSiEsBisiesto(año))
            {
                lbEsBisiesto.Text = "Es año bisiesto";
            }
            else 
            {
                lbEsBisiesto.Text = "No es año bisiesto";
            }
        }
    }
}
