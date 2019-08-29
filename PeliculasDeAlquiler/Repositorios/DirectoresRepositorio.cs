using PeliculasDeAlquiler.Helpers;
using PeliculasDeAlquiler.Modelos;
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
                $"VALUES ('{director.Nombre}', '{director.Nacionalidad}', '{director.FechaNacimiento.ToString("yyyy-MM-dd")}')";

            return _BD.EjecutarSQL(sqltxt);
        }

        public bool Eliminar(string directorId)
        {
            string sqltxt = $"DELETE FROM [dbo].[Directores] WHERE id = {directorId}";

            return _BD.EjecutarSQL(sqltxt);
        }


    }
}
