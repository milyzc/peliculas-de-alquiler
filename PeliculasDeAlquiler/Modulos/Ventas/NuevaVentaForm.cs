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
            var fila = DgvPeliculas.Rows[e.RowIndex];
            int cantidad = 0;
            if (!int.TryParse(fila.Cells["Cantidad"].Value?.ToString(), out cantidad))
            {
                fila.Cells["Cantidad"].Value = null;
                fila.Cells["Subtotal"].Value = null;
                ActualizarTotal();
                return;
            }
            var precioUnitario = decimal.Parse(fila.Cells["PrecioUnitario"].Value.ToString());
            var subtotal = cantidad * precioUnitario;
            fila.Cells["Subtotal"].Value = subtotal;
            ActualizarTotal();
            return;
        }

        private void ActualizarTotal()
        {
            var filas = DgvPeliculas.Rows;

            decimal total = 0;
            foreach (DataGridViewRow fila in filas)
            {
                if (fila.Cells["Subtotal"].Value == null)
                    continue;
                total += decimal.Parse(fila.Cells["Subtotal"].Value.ToString());
            }
            if (total != 0)
                TxtTotal.Text = total.ToString();
            else
                TxtTotal.Text = null;
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                var venta = new Venta()
                {
                    Cliente = TxtCliente.Text,
                    Fecha = DateTime.Today,
                    DetallesVenta = PreparaDetallesVenta(),
                    MontoFinal = string.IsNullOrEmpty(TxtTotal.Text) ? 0 : decimal.Parse(TxtTotal.Text)
                };
                venta.Validar();
                _ventasRepositorio.Guardar(venta);
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
