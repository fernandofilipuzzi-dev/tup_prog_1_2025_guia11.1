using Ejercicio6.Models;

namespace Ejercicio6
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
            int tipoTransporte = 0;

            if (rbBicicleta.Checked) tipoTransporte = 1;
            else if (rbMotocicleta.Checked) tipoTransporte = 2;
            else if (rbAutomovil.Checked) tipoTransporte = 3;
            else if (rbPublico.Checked) tipoTransporte = 4;

            double distancia = Convert.ToDouble(tbDistancia.Text);

            servicio.RegistrarEncuesta(tipoTransporte, distancia);

            rbBicicleta.Checked = false;
            rbMotocicleta.Checked = false;
            rbAutomovil.Checked = false;
            rbPublico.Checked = false;
            tbDistancia.Clear();

        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            tbResultados.Clear();
            tbResultados.Text = $@"Promedio de distancia recorrida por tipo de vehículo

  Bicicleta: {servicio.CalcularPromedioPorTipo(1):f2}
  Motocicleta: {servicio.CalcularPromedioPorTipo(2):f2}
  Automóvil:  {servicio.CalcularPromedioPorTipo(3):f2}
  Transporte público: {servicio.CalcularPromedioPorTipo(4):f2}

Total de encuestados:
            {servicio.CantidadEncuestados}
            ";

        }
    }
}
