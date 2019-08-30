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
    public partial class EditarDirector : Form
        
    {

        DirectoresRepositorio _directoresRepositorio;
        Director director;

        public EditarDirector()
        {
            InitializeComponent();
            _directoresRepositorio = new DirectoresRepositorio();
        }
        public EditarDirector(string directorId)
        {
            InitializeComponent();
            _directoresRepositorio = new DirectoresRepositorio();
            director = _directoresRepositorio.ObtenerDirector(directorId);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void EditarDirector_Load(object sender, EventArgs e)
        {
            txtNombre.Text = director.Nombre;
            txtNacionalidad.Text = director.Nacionalidad;
            dtpFechaNacimiento.Value = director.FechaNacimiento != DateTime.MinValue ?
            director.FechaNacimiento : DateTime.Today;//para obligarlo a cambiarle la fecha en aquellos
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            var datosDirector = new Director();
            datosDirector.Id = director.Id;
            datosDirector.Nombre = txtNombre.Text;
            datosDirector.Nacionalidad = txtNacionalidad.Text;
            datosDirector.FechaNacimiento = dtpFechaNacimiento.Value.Date;
            //se verifica lo que el usuario ingreso
            if (!datosDirector.NombreValido())
            {
                MessageBox.Show("Nombre invalido");
                return;
            }
            if (!datosDirector.ValidarNacionalidad())
            {
                MessageBox.Show("Nacionaliad invalida");
                return;
            }
            if (!datosDirector.ValidarFechaNacimiento())
            {
                MessageBox.Show("Fecha de Nacimiento invalido");
                return;
            }
            if (_directoresRepositorio.Actualizar(datosDirector))
            {
                MessageBox.Show("Se registro con èxito");
                this.Dispose();
            }
        }
    }
}
