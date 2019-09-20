namespace PeliculasDeAlquiler.Modelos
{
    public class DetalleVenta
    {
        public int Id { get; set; }

        public Pelicula Pelicula { get; set; }

        public int Cantidad { get; set; }

        public decimal PrecioUnitario { get; set; }
    }
}
