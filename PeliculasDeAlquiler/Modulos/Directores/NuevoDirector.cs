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
    public partial class NuevoDirector : Form
    {
        DirectoresRepositorio directoresRepositorio;

        public NuevoDirector()
        {
            InitializeComponent();
            directoresRepositorio = new DirectoresRepositorio();

        }

        private void textBoxNombre_TextChanged(object sender, EventArgs e)
        {


        }

        private void botonGuardar_Click(object sender, EventArgs e)
        {
            var director = new Director();
            director.Nombre = textBoxNombre.Text;
            director.Nacionalidad = textBoxNacionalidad.Text;
            director.FechaNacimiento = dateTime.Value.Date;

            if (!director.NombreValido())
            {
                MessageBox.Show("Nombre invalido");
                return;

            }
            if (!director.ValidarNacionalidad())
            {
                MessageBox.Show("Nacionalidad invalida");
                return;

            }
            if (!director.ValidarFechaNacimiento())
            {
                MessageBox.Show("Fecha invalida");
                return;

            }

            if (directoresRepositorio.Guardar(director) )
            {
                MessageBox.Show("se registro con exito");
                this.Dispose();
            }


        }

    }
}

