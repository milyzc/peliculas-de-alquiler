using PeliculasDeAlquiler.Helpers;
using PeliculasDeAlquiler.Modelos;
using PeliculasDeAlquiler.Repositorios;
using System;
using System.Data;
using System.Data.OleDb;
using System.Text;
using System.Windows.Forms;

namespace PeliculasDeAlquiler.Modulos.Peliculas
{
    public partial class NuevaPeliculaForm : Form
    {
        private PeliculasRepositorio _peliculasRepositorio;
        private DirectoresRepositorio _directoresRepositorio;
        private GenerosRepositorio _generosRepositorio;
        private Director director;

        public NuevaPeliculaForm()
        {
            InitializeComponent();
            _peliculasRepositorio = new PeliculasRepositorio();
            _directoresRepositorio = new DirectoresRepositorio();
            _generosRepositorio = new GenerosRepositorio();
        }

        private void LblNombre_Click(object sender, EventArgs e)
        {

        }

        private void TxtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void NuevaPeliculaForm_Load(object sender, EventArgs e)
        {
            Utils.CargarCombo(ref CmbGeneros, _generosRepositorio.ObtenerGenerosDT(), "Id", "Tipo");
            Utils.CargarListBox(ref LtbDirectores, _directoresRepositorio.ObtenerDirectoresDT(), "Id", "Nombre");
            QuitarSeleccionDirector();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (TxtTitulo.Text == "")
            {
                MessageBox.Show("debe ingresar nombre valido");
                return;
            }
            

            StringBuilder mensaje = new StringBuilder("La operación ");
            try
            {
                var pelicula = PrepararPelicula();
                if(pelicula.Director==null)
                {
                    mensaje.Clear();
                    mensaje.Append("debe seleccionar un director");
                    return;
                }
                else {
                    if (MessageBox.Show("Confirma nueva película", "Confirmación", MessageBoxButtons.OKCancel) == DialogResult.Cancel)
                    {
                        mensaje.Append("se cancelo");
                        return;
                    }
                    _peliculasRepositorio.Guardar(pelicula);
                    mensaje.Append("se realizó con exito.");
                }
                /*else
            {
                if(MessageBox.Show("Confirma nueva película", "Confirmación", MessageBoxButtons.OKCancel) == DialogResult.Cancel)
                return;
            }*/
            }
            catch(ApplicationException ex)
            {
                mensaje.Append($"no se realizo. {ex.Message})");
            }
            catch (InvalidOperationException ex)
            {
                mensaje.Append("no se realizó. Hubo un problema en la conexión a la BD");
            }
            catch (OleDbException ex)
            {
                mensaje.Append("no se realizó. Hubo un problema en la conexión a la BD");
            }
            catch (Exception exc)
            {
                mensaje.Append("no se realizó. Ops. Hubo un problema inesperado.");
            }
            finally
            {
                MessageBox.Show(mensaje.ToString());
            }

        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Está seguro que desea salir?", "Salir", MessageBoxButtons.OKCancel) == DialogResult.OK)
                Dispose();
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

        private void button1_Click(object sender, EventArgs e)
        {
            QuitarSeleccionDirector();
        }

        private void QuitarSeleccionDirector()
        {
            director = null;
            LtbDirectores.ClearSelected();
            TxtDirector.Text = null;
            TxtDirector.Enabled = true;
        }

        private Pelicula PrepararPelicula()
        {
            // Agregar validaciones
            if (director == null)
               throw new ApplicationException("seleccione director");
             
            var pelicula = new Pelicula()
            {
                Titulo = TxtTitulo.Text,
                FechaLanzamiento = DtpFechaLanzamiento.Value.Date,
                Director = director,
                Genero = new Genero() { Id = int.Parse(CmbGeneros.SelectedValue.ToString()) }
            };
            return pelicula;
        }
        
    }
}
