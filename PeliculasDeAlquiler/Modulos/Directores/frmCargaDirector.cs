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
    public partial class frmCargaDirector : Form
    {
        DirectoresRepositorio _directoresRepositorio;

        public frmCargaDirector()
        {
            InitializeComponent();
            _directoresRepositorio = new DirectoresRepositorio();
        }

        private void btnCargarDirector_Click(object sender, EventArgs e)
        {
            var director = new Director();
            director.Nombre = txtNombreDirector.Text;
            director.Nacionalidad = txtNacionalidadDirector.Text;
            director.FechaNacimiento = dtpFechaDirector.Value;

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
                MessageBox.Show("fecha mala");
                return;
            }

            if (_directoresRepositorio.Guardar(director))
            {
                MessageBox.Show("Se agrego el director con exito");
                this.Dispose();
            }
        }

    }
}
