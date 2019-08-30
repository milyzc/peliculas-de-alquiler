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
            txtNombre.Text = director.Nombre;
            txtNacionalidad.Text = director.Nacionalidad;
            // Si la fechaNacimiento es distinta que el valorMenor, entonces setea la fechaNac del director, sino setea la fecha de Hoy
            dtpFechaNacimiento.Value = director.FechaNacimiento != DateTime.MinValue ? 
                director.FechaNacimiento : DateTime.Today; //para obligarlo a cambiar la fecha en aquellos que no tengan fecha en la BD
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            var datosDirector = new Director();
            datosDirector.Id = director.Id;
            datosDirector.Nombre = txtNombre.Text;
            datosDirector.Nacionalidad = txtNacionalidad.Text;
            datosDirector.FechaNacimiento = dtpFechaNacimiento.Value.Date;
            
            // Todo lo que ingresa el usuario lo valido y verifico.

            //Si el metodo devuelve un false, lo camia a true, para que entre al if
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
                //Libera los recursos
                this.Dispose();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
