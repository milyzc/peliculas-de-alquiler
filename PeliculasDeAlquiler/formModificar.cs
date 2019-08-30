using PeliculasDeAlquiler.Modelos;
using PeliculasDeAlquiler.Repositorios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PeliculasDeAlquiler
{
    public partial class formModificar : Form
    {
        DirectoresRepositorio _directoresRepositorio;
        Director director;

        public formModificar()
        {
            InitializeComponent();
            _directoresRepositorio = new DirectoresRepositorio();
        }

        public formModificar(string directorId)
        {
            InitializeComponent();
            _directoresRepositorio = new DirectoresRepositorio();
            director = _directoresRepositorio.ObtenerDirector(directorId);
        }



        private void formModificar_Load(object sender, EventArgs e)
        {
            txtNombre.Text = director.Nombre;
            txtNacionalidad.Text = director.Nacionalidad;
            dtFechaNac.Value=director.FechaNacimiento != DateTime.MinValue ? 
                director.FechaNacimiento : DateTime.Today;

        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            var datosDirector = new Director();
            datosDirector.Id = director.Id;
            datosDirector.Nombre = txtNombre.Text;
            datosDirector.Nacionalidad = txtNacionalidad.Text;
            datosDirector.FechaNacimiento = dtFechaNac.Value.Date; // para que la hora me la de en 00:00 

            // Todo lo que ingresa el usuario lo valido y verifico.

            if (!datosDirector.NombreValido())
            {
                MessageBox.Show("Nombre inválido");
                return;
            }
            if (!datosDirector.ValidarNacionalidad())
            {
                MessageBox.Show("Nacionalidad inválida");
                return;
            }

            if (!datosDirector.ValidarFechaNacimiento())
            {
                MessageBox.Show("Fecha nacimiento inválido");
                return;
            }

            if (_directoresRepositorio.Actualizar(datosDirector))
            {
                MessageBox.Show("Se actualizó con éxito");
                this.Dispose();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
