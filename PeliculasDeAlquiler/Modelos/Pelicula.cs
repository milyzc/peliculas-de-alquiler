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

        public Director Director { get; set; }

        public Genero Genero { get; set; }

        public decimal? PrecioUnitario { get; set; }

        public int? Stock { get; set; }


        public string MostrarFechaLanzamiento()
        {
            return FechaLanzamiento != DateTime.MinValue ? FechaLanzamiento.ToString("dd/MM/yyyy") : null;
        }

        public void AsignarFechaLanzamiento(string fechaLanzamiento)
        {
            DateTime fecha = DateTime.MinValue;
            DateTime.TryParse(fechaLanzamiento?.ToString(), out fecha);
            FechaLanzamiento = fecha;
        }

        public void AsignarPrecioUnitario(object precioUnitario)
        {
            if (precioUnitario == null)
            {
                PrecioUnitario = null;
                return;
            }
            decimal precio = 0;
            decimal.TryParse(precioUnitario?.ToString(), out precio);
            PrecioUnitario = precio;
        }

        public void AsignarStock(object stock)
        {
            int stockDisponble = 0;
            if (stock == null)
            {
                Stock = stockDisponble;
                return;
            }            
            int.TryParse(stock?.ToString(), out stockDisponble);
            Stock = stockDisponble;
        }
    }
}
