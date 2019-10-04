using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PeliculasDeAlquiler.Modelos;

namespace PeliculasDeAlquiler.Modelos
{
    public class Alquiler
    {
        public int Id { get; set; }
        public DateTime FechaDesde { get; set; }
        public DateTime FechaHasta { get; set; }
        public IList<DetalleAlquiler> DetallesAlquileres { get; set; }
        public decimal MontoFinal { get; set; }
        public string Cliente { get; set; }


        public void AsignarFechaDesde(string valor)
        {
            DateTime fecha = DateTime.MinValue;
            DateTime.TryParse(valor, out fecha);
            FechaDesde = fecha;
        }
        public void AsignarFechaHasta(string valor)
        {
            DateTime fecha = DateTime.MinValue;
            DateTime.TryParse(valor, out fecha);
            FechaHasta = fecha;
        }

        public string MostrarFechaDesde()
        {
            return FechaDesde != DateTime.MinValue ? FechaDesde.ToString("dd/MM/yyyy") : null;
        }


        public string MostrarFechaHasta()
        {
            return FechaHasta != DateTime.MinValue ? FechaHasta.ToString("dd/MM/yyyy") : null;
        }
    }
}
