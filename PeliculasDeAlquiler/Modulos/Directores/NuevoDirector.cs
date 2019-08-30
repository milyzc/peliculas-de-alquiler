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
        DirectoresRepositorio _directorRepositorio;
        public NuevoDirector()
        {
            InitializeComponent();
            _directorRepositorio = new DirectoresRepositorio();
            

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            var director = new Director();
            director.Nombre = txtNombre.Text;
            director.Nacionalidad = txtNacionalidad.Text;
            director.FechaNacimiento = dtpFechaNacimiento.Value.Date;// con esto la hra me da en 00:00

            //se verifica lo que el usuario ingreso
            if (!director.NombreValido()){
                MessageBox.Show("Nombre invalido");
                return;
            }
            if (!director.ValidarNacionalidad()){
                MessageBox.Show("Nacionaliad invalida");
                return;
            }
            if (!director.ValidarFechaNacimiento()){
                MessageBox.Show("Fecha de Nacimiento invalido");
                return;
            }
            if (_directorRepositorio.Guardar(director))
            {
                MessageBox.Show("Se registro con èxito");
                this.Dispose();
            }
            
        }

        private void txtNacionalidad_TextChanged(object sender, EventArgs e)
        {

        }

        private void NuevoDirector_Load(object sender, EventArgs e)
        {

        }
        //private void DirectoresForm_FormClosing(object sender, FormClosingEventArgs e) {
        //    _consultarPeliculasForm.Show();
        //}

    }
}
