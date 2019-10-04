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
        private PeliculasRepositorio _peliculasRepositorio;
        private AlquileresRepositorio _alquileresRepositorio;

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
            LblFechaHoy.Text = DateTime.Today.ToString("dd/MM/yyyy");
        }

        private void ActualizarGrilla(IList<Pelicula> registros)
        {
            DgvPeliculas.Rows.Clear();
            var columns = DgvPeliculas.RowTemplate;
            foreach (Pelicula registro in registros)
            {                
                DgvPeliculas.Rows.Add(PeliculaAFila(registro));
            }
        }

        private string[] PeliculaAFila(Pelicula p)
        {
            var fila = new string[] {
                    p.Id.ToString(),
                    p.Titulo ,
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

        private void DvgPeliculasSeleccionadas_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ActualizarTotal()
        {
            var filas = DvgPeliculasSeleccionadas.Rows;

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

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            var peliculasAgregadas = DvgPeliculasSeleccionadas.Rows;
            var seleccionadas = DgvPeliculas.SelectedRows;
            foreach (DataGridViewRow seleccionada in seleccionadas)
            {
                var codigo = seleccionada.Cells["CodigoP"].Value?.ToString();
                foreach (DataGridViewRow agregada in peliculasAgregadas)
                {
                    if(agregada.Cells["Codigo"].Value?.ToString() == codigo)
                    {
                        MessageBox.Show("Pelicula ya agregada");
                        return;
                    }
                }
                var fila = new string[] {
                    seleccionada.Cells["CodigoP"].Value?.ToString(),
                    seleccionada.Cells["TituloP"].Value?.ToString() ,
                    null,
                    null,
                    null,
                    seleccionada.Cells["PrecioUnitarioP"].Value?.ToString(),
                    seleccionada.Cells["StockP"].Value?.ToString(),
                    seleccionada.Cells["PrecioUnitarioP"].Value.ToString(), // solo se alquila de a una pelicula
                    null
                };
                DvgPeliculasSeleccionadas.Rows.Add(fila);
                ActualizarTotal();
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Está seguro que desea salir?", "Salir", MessageBoxButtons.OKCancel) == DialogResult.OK)
                Dispose();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                var a = new Alquiler()
                {
                    Cliente = TxtCliente.Text,
                    FechaDesde = DateTime.Today,
                    FechaHasta = DtpFechaHasta.Value.Date,
                    DetallesAlquileres = PreparaDetalles(),
                    MontoFinal = string.IsNullOrEmpty(TxtTotal.Text) ? 0 : decimal.Parse(TxtTotal.Text)
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

        public List<DetalleAlquiler> PreparaDetalles()
        {
            var detalles = new List<DetalleAlquiler>();

            var filas = DvgPeliculasSeleccionadas.Rows;

            foreach (DataGridViewRow fila in filas)
            {
                if (fila.Cells["Subtotal"].Value == null)
                    continue;
                var detalle = new DetalleAlquiler()
                {
                    PrecioUnitario = decimal.Parse(fila.Cells["PrecioUnitario"].Value?.ToString()),
                    Pelicula = new Pelicula() { Id = int.Parse(fila.Cells["Codigo"].Value?.ToString()) },
                    Observaciones = fila.Cells["Observaciones"].Value?.ToString()
                };
                detalles.Add(detalle);
            }
            return detalles;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
