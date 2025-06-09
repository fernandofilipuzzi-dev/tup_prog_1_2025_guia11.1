using Ejercicio7.Models;

namespace Ejercicio7
{
    public partial class FormPrincipal : Form
    {
        Servicio servicio = new Servicio();

        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            int nro = Convert.ToInt32(tbNumeroTransaccion.Text);
            int rubro = Convert.ToInt32(nudRubro.Value);
            int cantidad = Convert.ToInt32(nudCantidadProductos.Value);
            double monto = Convert.ToDouble(tbNumeroTransaccion.Text);

            servicio.EvaluarTransaccionPuntoDeVenta(nro, rubro, cantidad, monto);

            tbNumeroTransaccion.Clear();
            nudRubro.Value = 1;
            nudCantidadProductos.Value = 1;
            tbNumeroTransaccion.Clear();
        }

        private void btnTransaccionMayor_Click(object sender, EventArgs e)
        {
            tbResultados.Text= $@"Transacción con mayor monto en ventas


Número de transacción: {servicio.NumeroTransaccionMayor}
Monto Total: ${servicio.MontoTransaccionMayor:f2}";
        }
    }
}
