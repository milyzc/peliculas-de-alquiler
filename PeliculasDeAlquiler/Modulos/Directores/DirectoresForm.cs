using PeliculasDeAlquiler.Repositorios;
using System;
using System.Data;
using System.Windows.Forms;

namespace PeliculasDeAlquiler.Modulos.Directores
{
    public partial class DirectoresForm : Form
    {
        DirectoresRepositorio _directoresRepositorio;
        ConsultarPeliculas _consultarPeliculasForm;

        public DirectoresForm()
        {
            InitializeComponent();
            _directoresRepositorio = new DirectoresRepositorio();
        }

        public DirectoresForm(ConsultarPeliculas consultarPeliculasForm)
        {
            InitializeComponent();
            _directoresRepositorio = new DirectoresRepositorio();
            _consultarPeliculasForm = consultarPeliculasForm;
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            ActualizarDirectores();
        }

        private void ActualizarDirectores()
        {
            DgvDirectores.Rows.Clear();
            var peliculas = _directoresRepositorio.ObtenerDirectoresDT().Rows;
            ActualizarGrilla(peliculas);
        }

        private void ActualizarGrilla(DataRowCollection registros)
        {
            foreach (DataRow registro in registros)
            {
                if (registro.HasErrors)
                    continue; // no corto el ciclo
                DateTime fecha = DateTime.MinValue;
                DateTime.TryParse(registro.ItemArray[3]?.ToString(), out fecha);

                var fila = new string[] {
                    registro.ItemArray[0].ToString(), // Codigo
                    registro.ItemArray[1].ToString(), // Nombre
                    registro.ItemArray[2].ToString(), // Nacionalidad
                    fecha != DateTime.MinValue ? fecha.ToString("dd/MM/yyyy") : null // FechaNacimiento
                };

                DgvDirectores.Rows.Add(fila);
            }
        }

        private void Directores_Load(object sender, EventArgs e)
        {
            ActualizarDirectores();
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            var ventana = new FormNuevoDirector();
            ventana.ShowDialog();
            ActualizarDirectores();
        }

        private void DirectoresForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            _consultarPeliculasForm.Show();
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            // código para borrar un director

            var seleccionadas = DgvDirectores.SelectedRows;
            if (seleccionadas.Count == 0 || seleccionadas.Count > 1)
            {
                MessageBox.Show("Debe seleccionar una fila");
                return;
            }

            foreach(DataGridViewRow fila in seleccionadas)
            {
                var id = fila.Cells[0].Value;
                var nombre = fila.Cells[1].Value;
                var nacionalidad = fila.Cells[2].Value;

                //pregunto confirmación
                var confirmación = MessageBox.Show($"Está seguro que desea eliminar a {nombre},{nacionalidad}?",
                    "Confirmar operación",
                    MessageBoxButtons.YesNo);

                if (confirmación.Equals(DialogResult.No))
                    return;

                if (_directoresRepositorio.Eliminar(id.ToString()))
                {
                    MessageBox.Show("Se eliminó exitosamente");
                    ActualizarDirectores();
                }
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            var seleccionadas = DgvDirectores.SelectedRows;
            if (seleccionadas.Count == 0 || seleccionadas.Count > 1)
            {
                MessageBox.Show("Debe selccionar una fila");
                return;
            }

            foreach (DataGridViewRow fila in seleccionadas)
            {
                var id = fila.Cells[0].Value;

                var ventana = new EditarDirectorForm(id.ToString());
                ventana.ShowDialog();
                ActualizarDirectores();
            }
        }
    }
}
