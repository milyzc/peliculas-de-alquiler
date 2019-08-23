using PeliculasDeAlquiler.Helpers;
using System.Data;

namespace PeliculasDeAlquiler.Repositorios
{
    public class PeliculasRepositorio
    {
        
        // código adaptada de clase 01
        /// <summary>
        /// Solo ciertas ciertas clases tiene acceso a la BD
        /// </summary>
        private acceso_BD _BD ;

        public PeliculasRepositorio()
        {
            _BD = new acceso_BD();
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
            string sqltxt = "SELECT p.Id, p.Titulo, p.FechaLanzamiento, g.Tipo, d.Nombre FROM peliculas p, Directores d, Generos g WHERE p.GeneroId = g.ID and p.DirectorId = d.Id ";

            //aquí dos acciones. 1)ejecuta el SQL atravéz del objeto <_BD> utilizando la función
            //<consulta> pasando por parámentro de la función el comando SQL, esta función devuelve una tabla.
            //2)Devuelve con el comando <return> a travéz de la función <consulta_login> el resultado 
            //del SQL.
            return _BD.consulta(sqltxt);
        }

        public DataTable ObtenerGeneros()
        {
            string sqltxt = "SELECT * FROM Generos";
            return _BD.consulta(sqltxt);
        }

        public DataTable Filtrar(string generoID)
        {
            string sqltxt = "SELECT p.Id, p.Titulo, p.FechaLanzamiento, g.Tipo, d.Nombre FROM peliculas p, Directores d, Generos g WHERE p.GeneroId = g.Id and p.DirectorId = d.Id and g.Id = " + generoID;
            //string sqltxt = "SELECT * FROM peliculas where GeneroId=" + generoID;
            return _BD.consulta(sqltxt);
        }


    }
}
