using PeliculasDeAlquiler.Modelos;
using PeliculasDeAlquiler.Repositorios;
using System;
using System.Collections.Generic;
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
            var peliculas = _directoresRepositorio.ObtenerDirectores();
            ActualizarGrilla(peliculas);
        }

        private void ActualizarGrilla(List<Director> registros)
        {
            DgvDirectores.Rows.Clear();
            foreach (Director registro in registros)
            {
                var fila = new string[] {
                    registro.Id.ToString(), // Codigo
                    registro.Nombre.ToString(), // Nombre
                    registro.Nacionalidad.ToString(), // Nacionalidad
                    registro.FechaNacimiento != DateTime.MinValue ? registro.FechaNacimiento.ToString("dd/MM/yyyy") : null // FechaNacimiento
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
            var seleccionadas = DgvDirectores.SelectedRows;
            if (seleccionadas.Count == 0 || seleccionadas.Count > 1)
            {
                MessageBox.Show("Debe seleccionar una fila");
                return;
            }                

            foreach (DataGridViewRow fila in seleccionadas)
            {
                var nombre = fila.Cells[1].Value;
                var nacionalidad = fila.Cells[2].Value;
                var id = fila.Cells[0].Value;

                //pregunto confirmación
                var confirmacion = MessageBox.Show($"Esta seguro que desea eliminar a {nombre}, {nacionalidad}?", 
                    "Confirmar operación", 
                    MessageBoxButtons.YesNo);

                if (confirmacion.Equals(DialogResult.No))
                    return;
                
                if (_directoresRepositorio.Eliminar(id.ToString()))
                {
                    MessageBox.Show("Se eliminó exitosamente");
                    ActualizarDirectores();
                }
            }
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            var seleccionadas = DgvDirectores.SelectedRows;
            if (seleccionadas.Count == 0 || seleccionadas.Count > 1)
            {
                MessageBox.Show("Debe seleccionar una fila");
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
