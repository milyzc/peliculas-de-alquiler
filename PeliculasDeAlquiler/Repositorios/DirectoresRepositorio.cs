using PeliculasDeAlquiler.Helpers;
using PeliculasDeAlquiler.Modelos;
using System;
using System.Collections.Generic;
using System.Data;

namespace PeliculasDeAlquiler.Repositorios
{
    public class DirectoresRepositorio
    {

        // código adaptada de clase 01
        /// <summary>
        /// Solo ciertas ciertas clases tiene acceso a la BD
        /// </summary>
        

        public DirectoresRepositorio()
        {
            
        }

        public DataTable ObtenerDirectoresDT()
        {
            string sqltxt = "SELECT * FROM directores";

            return AccesoBD.Singleton().consulta(sqltxt);
        }

        public List<Director> ObtenerDirectores()
        {
            var tablaTemporal = ObtenerDirectoresDT();
            var directores = new List<Director>();            
            foreach (DataRow fila in tablaTemporal.Rows)
            {
                var director = new Director();
                if (fila.HasErrors)
                    continue; // no corto el ciclo

                // tratamiento de fechas
                DateTime fecha = DateTime.MinValue;

                // Si lo que esta en la BD de datos se puede parsear a date se lo parsea y almacena en la varaible fecha
                DateTime.TryParse(fila.ItemArray[3]?.ToString(), out fecha);

                director.Id = int.Parse(fila.ItemArray[0].ToString()); // Codigo
                director.Nombre = fila.ItemArray[1].ToString(); // Nombre
                director.Nacionalidad = fila.ItemArray[2].ToString(); // Nacionalidad
                director.FechaNacimiento = fecha;

                directores.Add(director);
            }
            return directores;
        }

        public bool Guardar(Director director)
        {
            string sqltxt = $"INSERT [dbo].[Directores] ([Nombre], [Nacionalidad], [FechaNacimiento]) " +
                $"VALUES ('{director.Nombre}', '{director.Nacionalidad}', '{director.FechaNacimiento.ToString("yyyy-MM-dd")}')";

            return AccesoBD.Singleton().EjecutarSQL(sqltxt);
        }

        public bool Actualizar(Director director)
        {
            string sqltxt = $"UPDATE [dbo].[Directores] SET Nombre = '{director.Nombre}', " +
                $"Nacionalidad = '{director.Nacionalidad}', " +
                $"FechaNacimiento = '{director.FechaNacimiento.ToString("yyyy-MM-dd")}' WHERE id={director.Id}";

            return AccesoBD.Singleton().EjecutarSQL(sqltxt);
        }

        public bool Eliminar(string directorId)
        {
            string sqltxt = $"DELETE FROM [dbo].[Directores] WHERE id = {directorId}";

            return AccesoBD.Singleton().EjecutarSQL(sqltxt);
        }


        public Director ObtenerDirector(string directorId)
        {
            string sqltxt = $"SELECT * FROM [dbo].[Directores] WHERE id = {directorId}";
            var tablaTemporal = AccesoBD.Singleton().consulta(sqltxt);

            if (tablaTemporal.Rows.Count == 0)
                return null;

            var director = new Director();
            foreach (DataRow fila in tablaTemporal.Rows)
            {
                if (fila.HasErrors)
                    continue; // no corto el ciclo

                // tratamiento de fechas
                DateTime fecha = DateTime.MinValue;

                // Si lo que esta en la BD de datos se puede parsear a date se lo parsea y almacena en la varaible fecha
                DateTime.TryParse(fila.ItemArray[3]?.ToString(), out fecha);

                director.Id = int.Parse(fila.ItemArray[0].ToString()); // Codigo
                director.Nombre = fila.ItemArray[1].ToString(); // Nombre
                director.Nacionalidad = fila.ItemArray[2].ToString(); // Nacionalidad
                director.FechaNacimiento = fecha;
            }

            return director;
        }

    }
}
