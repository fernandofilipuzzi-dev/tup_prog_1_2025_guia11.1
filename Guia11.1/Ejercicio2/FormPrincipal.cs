using Ejercicio2.Models;

namespace Ejercicio2
{
    public partial class FormPrincipal : Form
    {
        Servicio servicio = new Servicio();

        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void btnRegistrarMonto_Click(object sender, EventArgs e)
        {
            //double montoARepartir = Convert.ToDouble( Console.ReadLine() );
            double montoARepartir = Convert.ToDouble(tbMontoARepartir.Text);
            servicio.RegistrarMontoARepartir(montoARepartir);
        }

        private void btnRegistrarEdades_Click(object sender, EventArgs e)
        {
            int edad = Convert.ToInt32( tbEdad1.Text );
            servicio.RegistrarEdad(edad, 0);

            edad = Convert.ToInt32( tbEdad2.Text );
            servicio.RegistrarEdad(edad, 1);

            edad = Convert.ToInt32( tbEdad3.Text );
            servicio.RegistrarEdad(edad, 2);

            edad = Convert.ToInt32( tbEdad4.Text );
            servicio.RegistrarEdad(edad, 3);
        }

        private void btnMostrarMontoPorcentaje_Click(object sender, EventArgs e)
        {
            servicio.CalcularMontosYPorcentajesARepartir();

            tbResultado.Text = $@"
Niña 1 ({servicio.Edad0}), Porcentaje: {servicio.Porcentaje0:f2}, Monto: ${servicio.Monto0:f2}
Niña 2 ({servicio.Edad1}), Porcentaje: {servicio.Porcentaje1:f2}, Monto: ${servicio.Monto1:f2}
Niña 3 ({servicio.Edad2}), Porcentaje: {servicio.Porcentaje2:f2}, Monto: ${servicio.Monto2:f2}
Niña 4 ({servicio.Edad3}), Porcentaje: {servicio.Porcentaje3:f2}, Monto: ${servicio.Monto3:f2}";

        }
    }
}
