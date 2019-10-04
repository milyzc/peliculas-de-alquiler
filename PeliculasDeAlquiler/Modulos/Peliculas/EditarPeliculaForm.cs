using PeliculasDeAlquiler.Helpers;
using PeliculasDeAlquiler.Modelos;
using PeliculasDeAlquiler.Repositorios;
using System;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace PeliculasDeAlquiler.Modulos.Peliculas
{
    public partial class EditarPeliculaForm : Form
    {
        private PeliculasRepositorio _peliculasRepositorio;
        private DirectoresRepositorio _directoresRepositorio;
        private GenerosRepositorio _generosRepositorio;
        private Pelicula pelicula;
        private Director director;

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
            TxtTitulo.Text = pelicula.Titulo;
            CkInactivo.Checked = !pelicula.Activo;
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirma nueva película", "Confirmación", MessageBoxButtons.OKCancel) == DialogResult.Cancel)
                return;

            StringBuilder mensaje = new StringBuilder("La operación ");
            var exito = false;
            try
            {
                var pelicula = PrepararPelicula();
                if (_peliculasRepositorio.Actualizar(pelicula))
                {
                    mensaje.Append("se realizó con exito.");
                    exito = true;
                }
            }
            catch (InvalidOperationException)
            {
                mensaje.Append("no se realizó. Hubo un problema en la conexión a la BD");
            }
            catch (Exception)
            {
                mensaje.Append("no se realizó. Ops. Hubo un problema inesperado.");
            }
            finally
            {
                MessageBox.Show(mensaje.ToString());
                if (exito)
                    Dispose();
            }
        }

        private Pelicula PrepararPelicula()
        {
            pelicula.Titulo = TxtTitulo.Text;
            pelicula.FechaLanzamiento = DtpFechaLanzamiento.Value.Date;
            pelicula.Director = director;
            pelicula.Genero = new Genero() { Id = int.Parse(CmbGeneros.SelectedValue.ToString()) };
            pelicula.Activo = !CkInactivo.Checked;
            return pelicula;
        }

        private void LtbDirectores_SelectedIndexChanged(object sender, EventArgs e)
        {
            var seleccionado = (DataRowView) LtbDirectores.SelectedItem;
            if (seleccionado == null)
                return;
            director = new Director();
            director.Id = int.Parse(seleccionado.Row.ItemArray[0].ToString());
            director.Nombre = seleccionado.Row.ItemArray[1].ToString();
            TxtDirector.Text = director.Nombre;
            TxtDirector.Enabled = false;
        }

        private void QuitarSeleccionDirector()
        {
            director = null;
            LtbDirectores.ClearSelected();
            TxtDirector.Text = null;
            TxtDirector.Enabled = true;
        }

        private void BtnQuitarSeleccion_Click(object sender, EventArgs e)
        {
            QuitarSeleccionDirector();
        }

        private void EditarPeliculaForm_FormClosing(object sender, FormClosingEventArgs e)
        {
                Dispose();
        }
    }
}
