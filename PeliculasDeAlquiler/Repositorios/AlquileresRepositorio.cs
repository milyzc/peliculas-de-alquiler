using PeliculasDeAlquiler.Helpers;
using PeliculasDeAlquiler.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeliculasDeAlquiler.Repositorios
{
    public class AlquileresRepositorio
    {

        public AlquileresRepositorio() { }


        public IList<Alquiler> ObtenerTodos()
        {
            string sqltxt = "SELECT * FROM alquileres";

            var tmp = AccesoBD.Singleton().consulta(sqltxt);

            var alquileres = new List<Alquiler>();

            foreach (DataRow fila in tmp.Rows)
            {
                if (fila.HasErrors)
                    continue;
                var a = new Alquiler()
                {
                    Id = int.Parse(fila.ItemArray[0].ToString()),
                    Cliente = fila.ItemArray[1]?.ToString(),
                    MontoFinal = decimal.Parse(fila.ItemArray[4]?.ToString()),                    
                };
                a.AsignarFechaDesde(fila.ItemArray[2]?.ToString());
                a.AsignarFechaHasta(fila.ItemArray[3]?.ToString());
                alquileres.Add(a);
            }
            return alquileres;
        }

        public void Guardar(Alquiler v)
        {
            using (var tx = AccesoBD.Singleton().IniciarTransaccion())
            {
                try
                {
                    string sqltxt = $"INSERT [dbo].[Alquileres] ([Cliente], [FechaDesde], [FechaHasta], [MontoFinal])" +
                        $" VALUES ('{v.Cliente}', '{UtilsDB.GetFecha(v.FechaDesde)}', '{UtilsDB.GetFecha(v.FechaHasta)}', {v.MontoFinal})";
                    v.Id = AccesoBD.Singleton().EjecutarTransaccion(sqltxt);
                    if (v.Id == 0)
                        throw new ApplicationException();

                    foreach (var d in v.DetallesAlquileres)
                    {
                        sqltxt = $"INSERT [dbo].[DetallesDeAlquiler] " +
                            $"([AlquilerId], [PeliculaId], [Precio], [Observaciones]) " +
                            $"VALUES ({v.Id}, {d.Pelicula.Id}, {d.PrecioUnitario}, '{d.Observaciones}')";
                        AccesoBD.Singleton().EjecutarTransaccion(sqltxt);

                        sqltxt = $"SELECT stock FROM peliculas WHERE id={d.Pelicula.Id}";

                        var stock =
                            int.Parse(AccesoBD.Singleton().ConsultaDuranteTransaccion(sqltxt).Rows[0]["stock"].ToString());

                        sqltxt = $"UPDATE [dbo].[Peliculas] SET Stock = '{stock - 1}' WHERE id={d.Pelicula.Id}"; //solo se alquila de a una pelicula
                        AccesoBD.Singleton().EjecutarTransaccion(sqltxt);
                    }

                    tx.Commit();
                }
                catch (Exception ex)
                {
                    tx.Rollback();
                    throw new ApplicationException("No se pudo realizar la operación.");
                }
                finally
                {
                    AccesoBD.Singleton().cerrar();
                }
            }

        }

    }
}
