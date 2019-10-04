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
    }
}
