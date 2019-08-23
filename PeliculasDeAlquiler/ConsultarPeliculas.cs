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
            ActualizarCombo();
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            ActualizarPeliculas();
            
        }

        private void ActualizarPeliculas()
        {
            // push desde aula 7 genero y puebo conflicto con sql andandooooo
            DgvPeliculas.Rows.Clear();
            var peliculas = _peliculasRepositorio.ObtenerPeliculasDT().Rows;
            var filas = new List<DataGridViewRow>();
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
            //DgvPeliculas.Columns[0].DisplayIndex = 0;
            //DgvPeliculas.Columns[1].DisplayIndex = 1;
            //DgvPeliculas.Columns[2].DisplayIndex = 2;
            //DgvPeliculas.Update();
        }

        private void ActualizarCombo()
        {
            var generos = _peliculasRepositorio.ObtenerGenerosDT();
            //pk de mi tabla
            CbGeneros.ValueMember = "Id";
            //lo que quiero mostrar de mi tabla en mi combo
            CbGeneros.DisplayMember = "Tipo";
            //Cargo mi tabla
            CbGeneros.DataSource = generos;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DgvPeliculas.Rows.Clear();
            //trae el indice del valor seleccionado en el combo
            var valor = CbGeneros.SelectedValue;
            var peliculas = _peliculasRepositorio.ObtenerPeliculasDTFiltros(valor.ToString()).Rows;
            var filas = new List<DataGridViewRow>();
            foreach (DataRow pelicula in peliculas)
            {
                if (pelicula.HasErrors)
                    continue; //no corto el ciclo
                var fila = new string[]{
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
