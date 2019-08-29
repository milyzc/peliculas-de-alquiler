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

namespace PeliculasDeAlquiler.Modulos.Directores
{
    public partial class NuevoDirector : Form
    {

        DirectoresRepositorio _directoresRepositorio;

        public NuevoDirector()
        {
            InitializeComponent();
            _directoresRepositorio = new DirectoresRepositorio();
        }       
         
        

        private void NuevoDirector_Load(object sender, EventArgs e)
        {
            txtNombre.Focus();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            var director = new Director();
            director.Nombre = txtNombre.Text;
            director.Nacionalidad = txtNacionalidad.Text;
            director.FechaNacimiento = dateTimePicker1.Value.Date;

            //Validacion de datos del director con funciones dentro de clase director
            if (!director.NombreValido())
            {
                MessageBox.Show("Nombre Invalido!");
                txtNombre.Text = " ";
                txtNombre.Focus();
                return;
            }

            if (!director.ValidarNacionalidad())
            {
                MessageBox.Show("Nacionalidad invalida!");
                txtNacionalidad.Text = "";
                txtNacionalidad.Focus();
                return;
            }

            if (!director.ValidarFechaNacimiento())
            {
                MessageBox.Show("Fecha de nacimiendo invalida!");
                dateTimePicker1.Focus();
            }

            if (_directoresRepositorio.Guardar(director))
            {
                MessageBox.Show("Se agrego director con exito!");
                this.Dispose();
            }
        }
    }
}
