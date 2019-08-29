using PeliculasDeAlquiler.Modelos;
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
    public partial class abmDirector : Form
    {
        public abmDirector()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            var director = new Director();
            director.Nombre = txtNombre.Text;
            director.Nacionalidad = txtNacionalidad.Text;
            director.FechaNacimiento = dateTimeFechaNacimiento.Value;

            if (!director.NombreValido())
            {
                MessageBox.Show("Nombre Invalido");
                return;
            }
            if (!director.ValidarNacionalidad())
            {
                MessageBox.Show("La Nacionalidad es incorrecta");
                return;
            }
            if (!director.ValidarFechaNacimiento())
            {
                MessageBox.Show("La fecha Ingresada es invalida");
                return;
            }
        }
    }
}
