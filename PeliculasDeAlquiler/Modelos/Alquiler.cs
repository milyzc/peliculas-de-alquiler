using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public void Validar()
        {
            if (string.IsNullOrEmpty(Cliente))
                throw new ApplicationException("El cliente es requerido");
            if (FechaDesde == DateTime.MinValue || FechaDesde.Ticks < DateTime.Today.Ticks)
                throw new ApplicationException("Fecha desde inválida");
            if (FechaHasta == DateTime.MinValue || FechaHasta.Ticks < DateTime.Today.Ticks)
                throw new ApplicationException("Fecha hasta inválida");
            if (DetallesAlquileres == null || DetallesAlquileres.Count == 0)
                throw new ApplicationException("Al menos se requiere una película");
            else
                foreach (var da in DetallesAlquileres)
                    da.Validar();
            if (MontoFinal == 0)
                throw new ApplicationException("Al menos se requiere una película");
        }


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
