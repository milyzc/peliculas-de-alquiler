using PeliculasDeAlquiler.Helpers;
using PeliculasDeAlquiler.Modelos;
using System;
using System.Data;

namespace PeliculasDeAlquiler.Repositorios
{
    public class DirectoresRepositorio
    {

        // código adaptada de clase 01
        /// <summary>
        /// Solo ciertas ciertas clases tiene acceso a la BD
        /// </summary>
        private acceso_BD _BD;

        public DirectoresRepositorio()
        {
            _BD = new acceso_BD();
        }
        public DataTable ObtenerDirectoresDT()
        {
            //se define una variable local a la función <sqltxt> del tipo <string> donde en el 
            //momento de su creación se le asigan su contenido, que es el comando SELECT  
            //necesario para poder establecer la veracidad del usuario.
            string sqltxt = "SELECT * FROM directores";

            return _BD.consulta(sqltxt);
        }

        public bool Guardar(Director director)
        {
            string sqltxt = $"INSERT [dbo].[Directores] ([Nombre], [Nacionalidad], [FechaNacimiento]) " +
                $"VALUES ('{director.Nombre}', " +
                $"'{director.Nacionalidad}', '{director.FechaNacimiento.ToString("yyyy-MM-dd")}')";

            return _BD.EjecutarSQL(sqltxt);
        }

        public bool Eliminar(string directorId)
        {
            string sqltxt = $"DELETE FROM [dbo].[Directores] WHERE id = {directorId}";

            return _BD.EjecutarSQL(sqltxt);
        }
        
        public Director ObtenerDirector(string directorId)
        {
            string sqltxt = $"SELECT * FROM [dbo].[Directores] WHERE id = {directorId}";
            var tablaTemporal = _BD.consulta(sqltxt);

            if (tablaTemporal.Rows.Count == 0)
                return null;

            var director = new Director();
            foreach (DataRow fila in tablaTemporal.Rows)
            {
                if (fila.HasErrors)
                    continue;// no corto el ciclo

                //tratamiento de fechas
                DateTime fecha = DateTime.MinValue;

                DateTime.TryParse(fila.ItemArray[3]?.ToString(), out fecha);

                director.Id = int.Parse(fila.ItemArray[0].ToString());
                director.Nombre = fila.ItemArray[1].ToString();
                director.Nacionalidad = fila.ItemArray[2].ToString();
                director.FechaNacimiento = fecha ;
            }
            return director;

            
        }

        public bool EditarDirector(Director director)
        {
            string sqltxt = $"UPDATE [dbo].[Directores] SET Nombre = '{director.Nombre}', Nacionalidad = '{director.Nacionalidad}', FechaNacimiento = '{director.FechaNacimiento.ToString("yyyy-MM-dd")}' WHERE id={director.Id}";

            return _BD.EjecutarSQL(sqltxt);
        }






    }


}
