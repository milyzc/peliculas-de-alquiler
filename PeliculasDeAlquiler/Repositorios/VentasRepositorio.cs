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

        public void Guardar(Venta v)
        {
            using (var tx = AccesoBD.Singleton().IniciarTransaccion())
            {
                try
                {
                    string sqltxt = $"INSERT [dbo].[Ventas] ([Cliente], [FechaVenta], [MontoFinal])" +
                        $" VALUES ('{v.Cliente}', '{v.FechaVenta()}', {v.MontoFinal})";
                    v.Id = AccesoBD.Singleton().EjecutarTransaccion(sqltxt);
                    if (v.Id == 0)
                        throw new ApplicationException();

                    foreach (var d in v.DetallesVenta)
                    {
                        sqltxt = $"INSERT [dbo].[DetallesDeVentas] " +
                            $"([VentaId], [PeliculaId], [Cantidad], [PrecioUnitario]) " +
                            $"VALUES ({v.Id}, {d.Pelicula.Id}, {d.Cantidad}, {d.PrecioUnitario})";
                        AccesoBD.Singleton().EjecutarTransaccion(sqltxt);

                        sqltxt = $"SELECT stock FROM peliculas WHERE id={d.Pelicula.Id}";

                        var stock = 
                            int.Parse(AccesoBD.Singleton().ConsultaDuranteTransaccion(sqltxt).Rows[0]["stock"].ToString());

                        sqltxt = $"UPDATE [dbo].[Peliculas] SET Stock = '{stock - d.Cantidad}' WHERE id={d.Pelicula.Id}";
                        AccesoBD.Singleton().EjecutarTransaccion(sqltxt);
                    }

                    tx.Commit();
                }
                catch (Exception ex)
                {
                    tx.Rollback();
                    throw new ApplicationException("No se pudo guardar la venta.");
                }finally
                {
                    AccesoBD.Singleton().cerrar();
                }
            }

        }
    }
}
