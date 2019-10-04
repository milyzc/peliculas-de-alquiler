namespace PeliculasDeAlquiler.Modelos
{
    public class DetalleAlquiler
    {
        public int Id { get; set; }

        public Pelicula Pelicula { get; set; }

        public decimal PrecioUnitario { get; set; }

        public string Observaciones { get; set; }
    }
}
