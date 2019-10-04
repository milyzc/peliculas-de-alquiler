using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PeliculasDeAlquiler.Modelos;
using PeliculasDeAlquiler.Helpers;
using System.Data;

namespace PeliculasDeAlquiler.Repositorios
{
    public class AlquileresRepositorio
    {
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
            }return alquileres;
        }
    }
}
