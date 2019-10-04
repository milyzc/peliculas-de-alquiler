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
    public partial class AlquileresForm : Form
    {
        AlquileresRepositorio _alquileresRepositorio;
        ConsultarPeliculas _consultarPeliculasForm;

        public AlquileresForm(ConsultarPeliculas consultarPeliculasForm)
        {
            InitializeComponent();
            _alquileresRepositorio = new AlquileresRepositorio();
            _consultarPeliculasForm = consultarPeliculasForm;
        }

        public AlquileresForm()
        {
            InitializeComponent();
            _alquileresRepositorio = new AlquileresRepositorio();
        }

        private void AlquileresForm_Load(object sender, EventArgs e)
        {
            ActualizarAlquileres();
        }

        private void ActualizarAlquileres()
        {
            var alquileres = _alquileresRepositorio.ObtenerTodos();
            ActualizarGrilla(alquileres);
        }

        private void ActualizarGrilla(IList<Alquiler> registros)
        {
            dgvAlquileres.Rows.Clear();
            foreach (Alquiler registro in registros)
            {
                var fila = new string[]
                {
                    registro.Id.ToString(),
                    registro.Cliente.ToString(),
                    registro.MostrarFechaDesde(),
                    registro.MostrarFechaHasta(),
                    registro.MontoFinal.ToString(),
                };

                dgvAlquileres.Rows.Add(fila);
            }
        }

        
    }
}
