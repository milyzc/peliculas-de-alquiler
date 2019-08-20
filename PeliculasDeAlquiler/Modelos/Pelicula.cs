using System;

namespace PeliculasDeAlquiler.Modelos
{
    // Agregar modificador de acceso a clase
    public class Pelicula
    {
        // si no le agrego constructor c# le asocia un constructor por default
        public int Id { get; set; }
        public string Titulo { get; set; }
        public DateTime FechaLanzamiento { get; set; }

    }
}
