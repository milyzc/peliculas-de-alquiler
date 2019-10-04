using System;

namespace PeliculasDeAlquiler.Modelos
{
    public class DetalleAlquiler
    {
        public int Id { get; set; }

        public Pelicula Pelicula { get; set; }

        public decimal PrecioUnitario { get; set; }

        public string Observaciones { get; set; }


        public void Validar()
        {
            if (!string.IsNullOrEmpty(Observaciones) && Observaciones.Length > 200)
                throw new ApplicationException("La observaciones no deben superar los 200 caracteres");
        }
    }
}
