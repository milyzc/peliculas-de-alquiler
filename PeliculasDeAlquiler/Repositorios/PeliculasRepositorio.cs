using PeliculasDeAlquiler.Helpers;
using PeliculasDeAlquiler.Modelos;
using System;
using System.Collections.Generic;
using System.Data;

namespace PeliculasDeAlquiler.Repositorios
{
    public class PeliculasRepositorio
    {
        
        // código adaptada de clase 01
        /// <summary>
        /// Solo ciertas ciertas clases tiene acceso a la BD
        /// </summary>
        private AccesoBD _BD ;

        public PeliculasRepositorio()
        {
            _BD = AccesoBD.Singleton(); // ver not lazy (on demand)
        }



        //se define una función pública <consulta_login> que recibe dos parámetros de entrada
        //que permite evaluar en la base de datos en la tabla <users> si la combinación de 
        //<usuario> y <pssw> existen, en caso de exitir devuelte una tabla con contenido, por lo
        //contrario devuelve una tabla vacía
        public DataTable ObtenerPeliculasDT()
        {
            //se define una variable local a la función <sqltxt> del tipo <string> donde en el 
            //momento de su creación se le asigan su contenido, que es el comando SELECT  
            //necesario para poder establecer la veracidad del usuario.
            string sqltxt = "SELECT * FROM peliculas";

            //aquí dos acciones. 1)ejecuta el SQL atravéz del objeto <_BD> utilizando la función
            //<consulta> pasando por parámentro de la función el comando SQL, esta función devuelve una tabla.
            //2)Devuelve con el comando <return> a travéz de la función <consulta_login> el resultado 
            //del SQL.
            return _BD.consulta(sqltxt);
        }

        public IList<Pelicula> ObtenerPeliculasParaVenta()
        {
            string sqltxt = "SELECT p.Id, p.Titulo, p.GeneroId, g.Tipo as Genero, p.PrecioSugerido, p.Stock, p.DirectorId, p.FechaLanzamiento FROM peliculas p JOIN Generos g on p.GeneroId = g.Id WHERE p.activo=1";

            var tmp = _BD.consulta(sqltxt);
            var peliculas = new List<Pelicula>();            
            foreach (DataRow fila in tmp.Rows)
            {                
                if (fila.HasErrors)
                    continue; // no corto el ciclo

                var pelicula = new Pelicula();
                var genero = new Genero()
                {
                    Id = int.Parse(fila["GeneroId"].ToString()),
                    Tipo = fila["Genero"].ToString()
                };
                pelicula.Id = int.Parse(fila["Id"].ToString());
                pelicula.Titulo = fila["Titulo"].ToString();
                pelicula.Genero = genero;
                pelicula.AsignarFechaLanzamiento(fila["FechaLanzamiento"]?.ToString());
                pelicula.AsignarPrecioUnitario(fila["PrecioSugerido"]);
                pelicula.AsignarStock(fila["Stock"]);
                pelicula.Director = new Director() { Id = int.Parse(fila["DirectorId"].ToString()) };
                peliculas.Add(pelicula);
            }
            return peliculas;
        }

        public DataTable ObtenerPeliculasDTFiltros(string generoId)
        {

            string sqltxt = "SELECT * FROM peliculas where GeneroId=" + generoId;

            return _BD.consulta(sqltxt);
        }

        public bool Guardar(Pelicula p)
        {
            string sqltxt = $"INSERT [dbo].[Peliculas] ([Titulo], [FechaLanzamiento], [GeneroId], [DirectorId], [Activo]) VALUES ('{p.Titulo}', '{p.FechaLanzamiento.ToString("yyyy-MM-dd")}', {p.Genero.Id},{p.Director.Id}, {UtilsDB.GetBit(p.Activo)})";

            return AccesoBD.Singleton().EjecutarSQL(sqltxt);
        }

        public bool Actualizar(Pelicula p)
        {
            string sqltxt = $"UPDATE [dbo].[Peliculas] SET Titulo = '{p.Titulo}', FechaLanzamiento = '{p.FechaLanzamiento.ToString("yyyy-MM-dd")}', GeneroId = {p.Genero.Id}, DirectorId = {p.Director.Id}, Activo = {UtilsDB.GetBit(p.Activo)} WHERE Id = {p.Id}";

            return AccesoBD.Singleton().EjecutarSQL(sqltxt);
        }

        public Pelicula Obtener(string id)
        {
            string sqltxt = $"SELECT * FROM [dbo].[Peliculas] WHERE id = {id}";
            var tablaTemporal = AccesoBD.Singleton().consulta(sqltxt);

            if (tablaTemporal.Rows.Count == 0)
                return null;

            var pelicula = new Pelicula();
            foreach (DataRow fila in tablaTemporal.Rows)
            {
                if (fila.HasErrors)
                    continue; // no corto el ciclo

                // tratamiento de fechas
                DateTime fecha = DateTime.MinValue;

                // Si lo que esta en la BD de datos se puede parsear a date se lo parsea y almacena en la varaible fecha
                DateTime.TryParse(fila.ItemArray[2]?.ToString(), out fecha);

                pelicula.Id = int.Parse(fila.ItemArray[0].ToString()); // Codigo
                pelicula.Titulo = fila.ItemArray[1].ToString();
                pelicula.FechaLanzamiento = fecha; //
                pelicula.Genero = new Genero() { Id = int.Parse(fila.ItemArray[3].ToString()) };
                pelicula.Director = new Director() { Id = int.Parse(fila.ItemArray[4].ToString()) };
                pelicula.Activo = (bool) fila.ItemArray[7];
            }

            return pelicula;
        }
    }
}
