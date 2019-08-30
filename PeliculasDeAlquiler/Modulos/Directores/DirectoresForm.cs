﻿using PeliculasDeAlquiler.Repositorios;
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
            dgvDirectores.Rows.Clear();
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

                dgvDirectores.Rows.Add(fila);
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
            var seleccionadas = dgvDirectores.SelectedRows;
            if (seleccionadas.Count == 0 || seleccionadas.Count > 1)
            {
                MessageBox.Show("Debe Seleccionar algun director.");
                return;
            }

            foreach (DataGridViewRow fila in seleccionadas)
            {
                var nombre = fila.Cells[1].Value;
                var nacionalidad = fila.Cells[2].Value;
                var id = fila.Cells[0].Value;

                //Caja de texto para confirmar.
                var confirmacion = MessageBox.Show($"Esta seguro que desea eliminar {nombre}, {nacionalidad}?", "Confirmar Operacion", MessageBoxButtons.YesNo);
                
                if (confirmacion.Equals(DialogResult.No))
                    return;

                if (_directoresRepositorio.Eliminar(id.ToString()))
                {
                    MessageBox.Show("Se eliminó correctamente");
                    ActualizarDirectores();
                }
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            var seleccion = dgvDirectores.SelectedRows;
            if (seleccion.Count == 0 || seleccion.Count > 1)
            {
                MessageBox.Show("Seleccione un Director a Editar.");
                return;
            }

            foreach (DataGridViewRow fila in seleccion)
            {
                var id = fila.Cells[0].Value;

                var ventana = new EditarDirectorForm(id.ToString());
                ventana.ShowDialog();
                ActualizarDirectores();
            }
        }
    }
}
