using PeliculasDeAlquiler.Modelos;
using PeliculasDeAlquiler.Repositorios;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PeliculasDeAlquiler.Modulos.Ventas
{
    public partial class VentasForm : Form
    {
        public readonly VentasRepositorio _ventasRepositorio;
        ConsultarPeliculas _consultarPeliculasForm;

        public VentasForm(ConsultarPeliculas consultarPeliculasForm)
        {
            InitializeComponent();
            _ventasRepositorio = new VentasRepositorio();
            _consultarPeliculasForm = consultarPeliculasForm;
        }

        private void VentasForm_Load(object sender, EventArgs e)
        {
            ActualizarPeliculasParaVenta();
        }

        private void ActualizarPeliculasParaVenta()
        {
            var ventas = _ventasRepositorio.ObtenerVentas();
            ActualizarGrilla(ventas);
        }

        private void ActualizarGrilla(IList<Venta> registros)
        {
            DgvVentas.Rows.Clear();
            foreach (Venta registro in registros)
            {
                var fila = new string[] {
                    registro.Id.ToString(), // Codigo
                    registro.Fecha != DateTime.MinValue ? registro.Fecha.ToString("dd/MM/yyyy") : null,
                    registro.Cliente.ToString(), // Nombre y apellido
                    registro.MontoFinal.ToString(),                     
                };

                DgvVentas.Rows.Add(fila);
            }
        }

        private void VentasForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            _consultarPeliculasForm.Show();
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            var modal = new NuevaVentaForm();
            modal.ShowDialog();
            ActualizarPeliculasParaVenta();
        }
    }
}
