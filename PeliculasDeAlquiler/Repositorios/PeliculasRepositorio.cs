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
            string sqltxt = "SELECT p.Id, p.Titulo, p.FechaLanzamiento as 'Lanzamiento' , g.Tipo, d.Nombre as 'Director' , d.Nacionalidad FROM peliculas p INNER JOIN generos g ON p.GeneroId = g.Id inner join directores d on p.DirectorId = d.Id;";

            //aquí dos acciones. 1)ejecuta el SQL atravéz del objeto <_BD> utilizando la función
            //<consulta> pasando por parámentro de la función el comando SQL, esta función devuelve una tabla.
            //2)Devuelve con el comando <return> a travéz de la función <consulta_login> el resultado 
            //del SQL.
            return _BD.consulta(sqltxt);
        }

        public DataTable ObtenerGeneros()
        {
            //se define una variable local a la función <sqltxt> del tipo <string> donde en el 
            //momento de su creación se le asigan su contenido, que es el comando SELECT  
            //necesario para poder establecer la veracidad del usuario.
            string sqltxt = "SELECT * from generos";

            //aquí dos acciones. 1)ejecuta el SQL atravéz del objeto <_BD> utilizando la función
            //<consulta> pasando por parámentro de la función el comando SQL, esta función devuelve una tabla.
            //2)Devuelve con el comando <return> a travéz de la función <consulta_login> el resultado 
            //del SQL.            return _BD.consulta(sqltxt);
            return _BD.consulta(sqltxt);
        }

        public DataTable ObtenerPeliculasPorIdGenero(string generoId)
        {
            //se define una variable local a la función <sqltxt> del tipo <string> donde en el 
            //momento de su creación se le asigan su contenido, que es el comando SELECT  
            //necesario para poder establecer la veracidad del usuario.

            string sqltxt = "select p.Id, p.Titulo, p.FechaLanzamiento as 'Lanzamiento' , g.Tipo, d.Nombre as 'Director' , d.Nacionalidad FROM peliculas p INNER JOIN generos g ON p.GeneroId = g.Id inner join directores d on p.DirectorId = d.Id and p.generoId = " + generoId + ";";

            //aquí dos acciones. 1)ejecuta el SQL atravéz del objeto <_BD> utilizando la función
            //<consulta> pasando por parámentro de la función el comando SQL, esta función devuelve una tabla.
            //2)Devuelve con el comando <return> a travéz de la función <consulta_login> el resultado 
            //del SQL.            return _BD.consulta(sqltxt);
            return _BD.consulta(sqltxt);
        }
    }
}
