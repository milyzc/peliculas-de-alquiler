using PeliculasDeAlquiler.Modelos;
using PeliculasDeAlquiler.Repositorios;
using System;
using System.Windows.Forms;

namespace PeliculasDeAlquiler.Modulos.Directores
{
    public partial class FormNuevoDirector : Form
    {
        DirectoresRepositorio _directoresRepositorio;

        public FormNuevoDirector()
        {
            InitializeComponent();
            _directoresRepositorio = new DirectoresRepositorio();
        }

        private void NuevoDirector_Load(object sender, EventArgs e)
        {

        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            var director = new Director();
            director.Nombre = TxtNombre.Text;
            director.Nacionalidad = TxtNacionalidad.Text;
            director.FechaNacimiento = DtpFechaNacimiento.Value.Date; // para que la hora me la de en 00:00 

            // Todo lo que ingresa el usuario lo valido y verifico.

            if (!director.NombreValido())
            {
                MessageBox.Show("Nombre inválido");
                return;
            }
            if (!director.ValidarNacionalidad())
            {
                MessageBox.Show("Nacionalidad inválida");
                return;
            }
                
            if (!director.ValidarFechaNacimiento())
            {
                MessageBox.Show("Fecha nacimiento inválido");
                return;
            }                

            if (_directoresRepositorio.Guardar(director))
            {
                MessageBox.Show("Se registro con éxito");
                this.Dispose();
            }

        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
