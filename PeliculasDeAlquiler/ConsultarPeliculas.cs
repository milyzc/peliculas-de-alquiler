using PeliculasDeAlquiler.Repositorios;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace PeliculasDeAlquiler
{
    public partial class ConsultarPeliculas : Form
    {
        PeliculasRepositorio _peliculasRepositorio;
        public ConsultarPeliculas()
        {
            InitializeComponent();
            _peliculasRepositorio = new PeliculasRepositorio();
        }

        private void ConsultarPeliculas_Load(object sender, EventArgs e)
        {
            ActualizarPeliculas();
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            ActualizarPeliculas();
        }

        private void ActualizarPeliculas()
        {
            DgvPeliculas.Rows.Clear();
            var peliculas = _peliculasRepositorio.ObtenerPeliculasDT().Rows;
            foreach (DataRow pelicula in peliculas)
            {
                if (pelicula.HasErrors)
                    continue; // no corto el ciclo
                var fila = new string[] {
                    pelicula.ItemArray[0].ToString(),
                    pelicula.ItemArray[1].ToString(),
                    pelicula.ItemArray[2].ToString(),
                    pelicula.ItemArray[3].ToString(),
                    pelicula.ItemArray[4].ToString()
                };

                DgvPeliculas.Rows.Add(fila);
            }
        }
    }
}
