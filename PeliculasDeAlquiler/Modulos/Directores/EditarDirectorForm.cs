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

namespace PeliculasDeAlquiler.Modulos.Directores
{
    public partial class EditarDirectorForm : Form
    {
        DirectoresRepositorio _directoresRepositorio;
        Director director;

        public EditarDirectorForm()
        {
            InitializeComponent();
            _directoresRepositorio = new DirectoresRepositorio();
        }

        public EditarDirectorForm(string directorId)
        {
            InitializeComponent();
            _directoresRepositorio = new DirectoresRepositorio();
            director = _directoresRepositorio.ObtenerDirector(directorId);
        }

        private void EditarDirectorForm_Load(object sender, EventArgs e)
        {
            TxtNombre.Text = director.Nombre;
            TxtNacionalidad.Text = director.Nacionalidad;
            DtpFechaNacimiento.Value = director.FechaNacimiento != DateTime.MinValue ? director.FechaNacimiento : DateTime.Today; // para obligarlo a cambiar la fecha en aquellos que no tengan fecha en la BD
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            var datosDirector = new Director();
            datosDirector.Id = director.Id;
            datosDirector.Nombre = TxtNombre.Text;
            datosDirector.Nacionalidad = TxtNacionalidad.Text;
            datosDirector.FechaNacimiento = DtpFechaNacimiento.Value.Date; // para que la hora me la de en 00:00 

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

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
