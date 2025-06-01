using Ejercicio3.Models;

namespace Ejercicio3
{
    public partial class FormPrincipal : Form
    {
        Servicio servicio = new Servicio();

        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void btnbtnRegistrarAlumnos_Click(object sender, EventArgs e)
        {
            string nombre = tbNombre1.Text;
            int libreta = Convert.ToInt32(  tbLibreta1.Text );
            servicio.RegistrarNombreYNumeroLibreta(nombre, libreta);

            nombre = tbNombre2.Text;
            libreta = Convert.ToInt32(tbLibreta2.Text);
            servicio.RegistrarNombreYNumeroLibreta(nombre, libreta);

            nombre = tbNombre3.Text;
            libreta = Convert.ToInt32(tbLibreta3.Text);
            servicio.RegistrarNombreYNumeroLibreta(nombre, libreta);
        }

        private void btnMostrarListaOrdenada_Click(object sender, EventArgs e)
        {
            tbResultado.Text = $@"
{servicio.Nombre0,20}|{servicio.NumeroLibreta0,10}
{servicio.Nombre1,20}|{servicio.NumeroLibreta1,10}
{servicio.Nombre2,20}|{servicio.NumeroLibreta2,10}";
        }
    }
}
