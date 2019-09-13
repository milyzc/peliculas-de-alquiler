using PeliculasDeAlquiler.Helpers;
using PeliculasDeAlquiler.Modelos;
using System;
using System.Collections.Generic;
using System.Data;

namespace PeliculasDeAlquiler.Repositorios
{
    public class GenerosRepositorio
    {

        public List<Genero> ObtenerGeneros()
        {
            var generosDTRows = ObtenerGenerosDT().Rows;

            var generos = new List<Genero>();
            foreach (DataRow fila in generosDTRows)
            {
                if (fila.HasErrors)
                    continue;
                var genero = new Genero()
                {
                    Id = Convert.ToInt32(fila[0]),
                    Tipo = fila[1].ToString()
                };
                generos.Add(genero);
            }

            return generos;
        }

        public DataTable ObtenerGenerosDT()
        {
            string sqltxt = "SELECT * FROM generos";
            var generosDTRows = AccesoBD.Singleton().consulta(sqltxt);
            return generosDTRows;
        }
    }
}
