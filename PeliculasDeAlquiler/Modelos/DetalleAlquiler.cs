using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
