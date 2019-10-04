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

namespace PeliculasDeAlquiler.Modulos.Alquileres
{
    public partial class NuevoAlquilerForm : Form
    {
        PeliculasRepositorio _peliculasRepositorio;
        AlquileresRepositorio _alquileresRepositorio;

        public NuevoAlquilerForm()
        {
            InitializeComponent();
            _peliculasRepositorio = new PeliculasRepositorio();
            _alquileresRepositorio = new AlquileresRepositorio();
        }

        private void NuevoAlquilerForm_Load(object sender, EventArgs e)
        {
            var peliculas = _peliculasRepositorio.ObtenerPeliculasParaVenta();
            ActualizarGrilla(peliculas);
            lblFechaHoy.Text = DateTime.Today.ToString("dd/MM/yyyy");
        }

        private void ActualizarGrilla(IList<Pelicula> registros)
        {
            dgvPeliculas.Rows.Clear();
            var columns = dgvPeliculas.RowTemplate;
            foreach(Pelicula registro in registros)
            {
                dgvPeliculas.Rows.Add(PeliculaAFila(registro));
            }
        }

        private string[] PeliculaAFila(Pelicula p)
        {
            var fila = new string[]
            {
                p.Id.ToString(),
                p.Titulo,
                p.MostrarFechaLanzamiento(),
                p.Genero.Tipo,
                p.Genero.Id.ToString(),
                p.PrecioUnitario.ToString(),
                p.Stock.ToString(),
                null,
                null
            };
            return fila;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            var peliculasAgregadas = dgvPeliculasSeleccionadas.Rows;
            var seleccionadas = dgvPeliculas.SelectedRows;
            foreach (DataGridViewRow seleccionada in seleccionadas)
            {
                var codigo = seleccionada.Cells["codigoP"].Value?.ToString();
                foreach (DataGridViewRow agregada in peliculasAgregadas)
                {
                    if (agregada.Cells["codigo"].Value?.ToString() == codigo)
                    {
                        MessageBox.Show("Pelicula ya agregada");
                        return;
                    }
                }
                var fila = new string[] {
                    seleccionada.Cells["codigoP"].Value?.ToString(),
                    seleccionada.Cells["tituloP"].Value?.ToString() ,
                    null,
                    null,
                    null,
                    seleccionada.Cells["precioUnitarioP"].Value?.ToString(),
                    seleccionada.Cells["stockP"].Value?.ToString(),
                    seleccionada.Cells["precioUnitarioP"].Value.ToString(), // solo se alquila de a una pelicula
                    null
                };
                dgvPeliculasSeleccionadas.Rows.Add(fila);
                ActualizarTotal();
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                var a = new Alquiler()
                {
                    Cliente = txtCliente.Text,
                    FechaDesde = DateTime.Today,
                    FechaHasta = dtpFechaHasta.Value.Date,
                    DetallesAlquileres = PreparaDetalles(),
                    MontoFinal = string.IsNullOrEmpty(txtTotal.Text) ? 0 : decimal.Parse(txtTotal.Text)
                };
                a.Validar();
                _alquileresRepositorio.Guardar(a);
                MessageBox.Show("La operación se realizó con exito");
                this.Dispose();
            }
            catch (ApplicationException aex)
            {
                MessageBox.Show(aex.Message);
            }
            catch (Exception ex)
            {

                MessageBox.Show("Ocurrio un error inesperado");
            }
        }
    }
}
