using PeliculasDeAlquiler.Helpers;
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

namespace PeliculasDeAlquiler.Modulos.Peliculas
{
    public partial class EditarPeliculaForm : Form
    {
        private PeliculasRepositorio _peliculasRepositorio;
        private DirectoresRepositorio _directoresRepositorio;
        private GenerosRepositorio _generosRepositorio;
        private Pelicula pelicula;

        public EditarPeliculaForm()
        {
            InitializeComponent();
        }

        public EditarPeliculaForm(string id)
        {
            InitializeComponent();
            _peliculasRepositorio = new PeliculasRepositorio();
            _directoresRepositorio = new DirectoresRepositorio();
            _generosRepositorio = new GenerosRepositorio();

            pelicula = _peliculasRepositorio.Obtener(id);
        }

        private void EditarPeliculaForm_Load(object sender, EventArgs e)
        {
            Utils.CargarCombo(ref CmbGeneros, _generosRepositorio.ObtenerGenerosDT(), "Id", "Tipo");
            Utils.CargarListBox(ref LtbDirectores, _directoresRepositorio.ObtenerDirectoresDT(), "Id", "Nombre");
            Utils.Set(ref CmbGeneros, pelicula.Genero.Id);
            Utils.Set(ref LtbDirectores, pelicula.Director.Id);
        }
    }
}
