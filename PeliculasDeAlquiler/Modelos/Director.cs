using System;

namespace PeliculasDeAlquiler.Modelos
{
    public class Director
    {
        private int _id;

        public int Id {
            get { return _id; }
            set { _id = value; }
        }

        public string Nombre { get; set; }

        public string Nacionalidad { get; set; }

        public DateTime FechaNacimiento { get; set; }

        public bool NombreValido()
        {
            if (!string.IsNullOrEmpty(Nombre) && Nombre.Length < 51)
                return true;
            return false;
        }

        public bool ValidarNacionalidad()
        {
            if (!string.IsNullOrEmpty(Nacionalidad) && Nacionalidad.Length < 51)
                return true;
            return false;
        }

        public bool ValidarFechaNacimiento()
        {
            if (FechaNacimiento != DateTime.MinValue && FechaNacimiento < DateTime.Today)
                return true;
            return false;
        }
    }
}
