using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PeliculasDeAlquiler.Modelos;
using PeliculasDeAlquiler.Repositorios;

namespace PeliculasDeAlquiler.Modulos.Directores
{
    public partial class ModificarDir : Form
    {
        DirectoresRepositorio _directorRepositorio;
        Director director;

        public ModificarDir()
        {
            InitializeComponent();
            _directorRepositorio = new DirectoresRepositorio();
        }
        public ModificarDir(string directorId)
        {
            InitializeComponent();
            _directorRepositorio = new DirectoresRepositorio();
            director = _directorRepositorio.ObtenerDirector(directorId);
        }
       
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var datosDirector = new Director();
            datosDirector.Id = director.Id;
            datosDirector.Nombre = txtName.Text;
            datosDirector.Nacionalidad = txtNac.Text;
            datosDirector.FechaNacimiento = fecNac.Value.Date;
            if (_directorRepositorio.Editar(datosDirector))
            {
                MessageBox.Show("La edicion ha finalizado correctamente");
                this.Dispose();
            }
        }

       

        private void ModificarDir_Load(object sender, EventArgs e)
        {
            txtName.Text = director.Nombre;
            txtNac.Text = director.Nacionalidad;
            fecNac.Value = director.FechaNacimiento != DateTime.MinValue ? director.FechaNacimiento : DateTime.Today ;
        }
    }
}
