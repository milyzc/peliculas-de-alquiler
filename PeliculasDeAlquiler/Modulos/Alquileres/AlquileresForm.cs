using PeliculasDeAlquiler.Modelos;
using PeliculasDeAlquiler.Repositorios;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PeliculasDeAlquiler.Modulos.Alquileres
{
    public partial class AlquileresForm : Form
    {

        private AlquileresRepositorio _alquileresRepositorio;
        ConsultarPeliculas _consultarPeliculasForm;

        public AlquileresForm()
        {
            InitializeComponent();
        }


        public AlquileresForm(ConsultarPeliculas consultarPeliculasForm)
        {
            InitializeComponent();
            _consultarPeliculasForm = consultarPeliculasForm;
            _alquileresRepositorio = new AlquileresRepositorio();

        }

        private void AlquileresForm_Load(object sender, EventArgs e)
        {
            ActualizarGrilla();
        }

        private void ActualizarGrilla()
        {
            var alquileres = _alquileresRepositorio.ObtenerTodos();
            ActualizarGrilla(alquileres);
        }

        private void ActualizarGrilla(IList<Alquiler> registros)
        {
            DgvVentas.Rows.Clear();
            foreach (Alquiler registro in registros)
            {
                var fila = new string[] {
                    registro.Id.ToString(), // Codigo                    
                    registro.Cliente.ToString(), // Nombre y apellido
                    registro.MostrarFechaDesde(),
                    registro.MostrarFechaHasta(),
                    registro.MontoFinal.ToString(),
                };

                DgvVentas.Rows.Add(fila);
            }
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            ActualizarGrilla();
        }

        private void AlquileresForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            _consultarPeliculasForm.Show();
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            var modal = new NuevoAlquilerForm();
            modal.ShowDialog();
            ActualizarGrilla();
        }
    }
}
