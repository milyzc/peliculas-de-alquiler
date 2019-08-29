﻿using PeliculasDeAlquiler.Modulos.Directores;
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
            var generos = _peliculasRepositorio.ObtenerGeneros();
            //foreach(DataRow genero in generos)
            //{
            //    comboGeneros.Items.Add(genero.ItemArray[1]);
            //}

            comboGeneros.ValueMember = "Id";
            comboGeneros.DisplayMember = "Tipo";
            comboGeneros.DataSource = generos;
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
                    DateTime.Parse(pelicula.ItemArray[2].ToString()).ToString("dd-MM-yyyy"),
                    pelicula.ItemArray[3].ToString(),
                    pelicula.ItemArray[4].ToString(),
                    pelicula.ItemArray[5].ToString()
                };

                DgvPeliculas.Rows.Add(fila);
            }
            //DgvPeliculas.Columns[0].Visible = false;
            //DgvPeliculas.Columns[0].DisplayIndex = 0;
            //DgvPeliculas.Columns[1].DisplayIndex = 1;
            //DgvPeliculas.Columns[2].DisplayIndex = 2;
            //DgvPeliculas.Update();
        }

        private void ActualizarCombo()
        {
            var generos = _peliculasRepositorio.ObtenerGenerosDT();
            CbGeneros.ValueMember = "Id";
            CbGeneros.DisplayMember = "Tipo";
            CbGeneros.DataSource = generos;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DgvPeliculas.Rows.Clear();
            var valor = CbGeneros.SelectedValue;
            var peliculas = _peliculasRepositorio.ObtenerPeliculasDTFiltros(valor.ToString()).Rows;
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
        }

        private void directoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var directoresForm = new DirectoresForm(this);
            directoresForm.Show();
            this.Hide(); 
        }

        private void DgvPeliculas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnBuscarPelicula_Click(object sender, EventArgs e)
        {
            var generoId = comboGeneros.SelectedValue.ToString();

            DgvPeliculas.Rows.Clear();
            var peliculas = _peliculasRepositorio.ObtenerPeliculasPorIdGenero(generoId).Rows;
            var filas = new List<DataGridViewRow>();
            foreach (DataRow pelicula in peliculas)
            {
                if (pelicula.HasErrors)
                    continue; // no corto el ciclo
                var fila = new string[] {
                    pelicula.ItemArray[0].ToString(),
                    pelicula.ItemArray[1].ToString(),
                    DateTime.Parse(pelicula.ItemArray[2].ToString()).ToString("dd-MM-yyyy"),
                    pelicula.ItemArray[3].ToString(),
                    pelicula.ItemArray[4].ToString(),
                    pelicula.ItemArray[5].ToString()
                };

                DgvPeliculas.Rows.Add(fila);
            }


        }
    }
}
