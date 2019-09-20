using PeliculasDeAlquiler.Modelos;
using PeliculasDeAlquiler.Repositorios;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PeliculasDeAlquiler.Modulos.Ventas
{
    public partial class NuevaVentaForm : Form
    {
        PeliculasRepositorio _peliculasRepositorio;
        VentasRepositorio _ventasRepositorio;

        public NuevaVentaForm()
        {
            InitializeComponent();
            _peliculasRepositorio = new PeliculasRepositorio();
            _ventasRepositorio = new VentasRepositorio();
        }

        private void NuevaVentaForm_Load(object sender, EventArgs e)
        {
            var peliculas = _peliculasRepositorio.ObtenerPeliculasParaVenta();
            ActualizarGrilla(peliculas);
            LblFechaHoy.Text = DateTime.Today.ToString("dd/MM/yyyy");
        }

        private void ActualizarGrilla(IList<Pelicula> registros)
        {
            DgvPeliculas.Rows.Clear();
            var columns = DgvPeliculas.RowTemplate;
            foreach (Pelicula registro in registros)
            {
                var fila = new string[] {
                    registro.Id.ToString(),
                    registro.Titulo ,
                    registro.MostrarFechaLanzamiento(),
                    registro.Genero.Tipo,
                    registro.Genero.Id.ToString(),
                    registro.PrecioUnitario.ToString(),
                    registro.Stock.ToString(),
                    null,
                    null
                };
                DgvPeliculas.Rows.Add(fila);
            }
        }

        private void DgvPeliculas_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                // guardar venta con sus detalles y actualizar el stock
                
                MessageBox.Show("No estoy haciendo nada.");
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

        public List<DetalleVenta> PreparaDetallesVenta()
        {
            var detalles = new List<DetalleVenta>();

            var filas = DgvPeliculas.Rows;

            foreach (DataGridViewRow fila in filas)
            {
                if (fila.Cells["Subtotal"].Value == null)
                    continue;
                var detalle = new DetalleVenta()
                {
                    Cantidad = int.Parse(fila.Cells["Cantidad"].Value.ToString()),
                    PrecioUnitario = decimal.Parse(fila.Cells["PrecioUnitario"].Value.ToString()),
                    Pelicula = new Pelicula() { Id = int.Parse(fila.Cells["Codigo"].Value.ToString()) }
                };
                detalles.Add(detalle);
            }
            return detalles;
        }
    }
}
