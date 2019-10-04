using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PeliculasDeAlquiler.Helpers;
using PeliculasDeAlquiler.Modelos;
using PeliculasDeAlquiler.Repositorios;

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
    }
}
