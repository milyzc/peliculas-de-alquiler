using PeliculasDeAlquiler.Modulos.Directores;
using PeliculasDeAlquiler.Modulos.Peliculas;
using PeliculasDeAlquiler.Modulos.Ventas;
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
        GenerosRepositorio _generosRepositorio;

        public ConsultarPeliculas()
        {
            InitializeComponent();
            _peliculasRepositorio = new PeliculasRepositorio();
            _generosRepositorio = new GenerosRepositorio();
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
            var generos = _generosRepositorio.ObtenerGenerosDT();
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

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            var modal = new NuevaPeliculaForm();
            modal.ShowDialog();
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            var seleccionadas = DgvPeliculas.SelectedRows;
            if (seleccionadas.Count == 0 || seleccionadas.Count > 1)
            {
                MessageBox.Show("Debe seleccionar una fila");
                return;
            }
            foreach (DataGridViewRow fila in seleccionadas)
            {
                var id = fila.Cells[0].Value;

                var ventana = new EditarPeliculaForm(id.ToString());
                ventana.ShowDialog();
                ActualizarPeliculas();
            }
        }

        private void ventasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new VentasForm(this);
            form.Show();
            this.Hide();
        }
    }
}
