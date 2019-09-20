using System;
using System.Collections.Generic;

namespace PeliculasDeAlquiler.Modelos
{
    public class Venta
    {
        public int Id { get; set; }

        public DateTime Fecha { get; set; }

        public IList<DetalleVenta> DetallesVenta { get; set; }

        public decimal MontoFinal { get; set; }

        public string Cliente { get; set; }

        public void Validar()
        {
            if(string.IsNullOrEmpty(Cliente))
                throw new ApplicationException("El cliente es requerido");
            if (Fecha == DateTime.MinValue || Fecha.Ticks < DateTime.Today.Ticks)
                throw new ApplicationException("Fecha inválida");
            if(DetallesVenta == null || DetallesVenta.Count == 0)
                throw new ApplicationException("Al menos se requiere una película");
            if(MontoFinal == 0)
                throw new ApplicationException("Al menos se requiere una película");
        }

        public string MostrarVenta()
        {
            return Fecha != DateTime.MinValue ? Fecha.ToString("dd/MM/yyyy") : null;
        }

        public string FechaVenta()
        {
            return Fecha != DateTime.MinValue ? Fecha.ToString("yyyy-MM-dd") : null;
        }

    }
}
