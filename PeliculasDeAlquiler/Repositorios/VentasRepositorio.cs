using PeliculasDeAlquiler.Helpers;
using PeliculasDeAlquiler.Modelos;
using System;
using System.Collections.Generic;
using System.Data;

namespace PeliculasDeAlquiler.Repositorios
{
    public class VentasRepositorio
    {
        public VentasRepositorio()
        {

        }

        public IList<Venta> ObtenerVentas()
        {
            string sqltxt = "SELECT * FROM ventas";

            var tmp = AccesoBD.Singleton().consulta(sqltxt);

            var ventas = new List<Venta>();

            foreach (DataRow fila in tmp.Rows)
            {
                if (fila.HasErrors)
                    continue;

                DateTime fecha = DateTime.MinValue;

                DateTime.TryParse(fila.ItemArray[1]?.ToString(), out fecha);

                var venta = new Venta()
                {
                    Id = int.Parse(fila.ItemArray[0].ToString()),
                    Fecha = fecha,
                    MontoFinal = decimal.Parse(fila.ItemArray[2]?.ToString()),
                    Cliente = fila.ItemArray[3]?.ToString()
                };
                ventas.Add(venta);
            }
            return ventas;
        }

    
    }
}
