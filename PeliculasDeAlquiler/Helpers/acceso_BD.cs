using System.Data;
using System.Data.OleDb;
//Esta clase en parte de una de las capas de programación en el modelo de tres capas.
//Es la capa de atrás (backend) que conecta con la base de datos y realiza toda acción
//con la base de datos
namespace PeliculasDeAlquiler.Helpers
{
    public sealed class AccesoBD
    {
        private static AccesoBD _accesoDBSingleton;
        // instancia objeto <conexion> de tipo <OleDbConnection>
        private readonly OleDbConnection _conexion;

        //instancia objeto <cmd> del tipo <OleDbCommand>
        private readonly OleDbCommand _cmd;

        // probar poner protected para que vean la diferencia
        private AccesoBD() // para evitar que pueda ser instanciada por otras clases;
        {
            _conexion = new OleDbConnection();
            _cmd = new OleDbCommand();

        }        

        public static AccesoBD Singleton()
        {
            if (_accesoDBSingleton == null)
                _accesoDBSingleton = new AccesoBD();
            return _accesoDBSingleton;
        }


        //se crea uan variable local a la clase <cadena_conexio> para alojar la cadena de conexión
        //con la base de datos que se desea conecta.
        //Esta cadena de conexion se obtiene del explorador de servidores.
        //El explorador de servidores brinda la cande de conexion, pero recordar que es incompleta,
        //pues no suministra el componete <Password> que debe agregado manualmente por el programador

        //string cadena_conexion = "Provider=SQLNCLI11;Data Source=maquis;Persist Security Info=True;User ID=avisuales1;Initial Catalog=pav1-db-peliculas;password=avisuales1"; //workstation id=pav1-db.mssql.somee.com;packet size=4096;user id=milizc_SQLLogin_1;pwd=2s9o1yeexo;data source=pav1-db.mssql.somee.com;persist security info=False;initial catalog=pav1-db
        private readonly string cadena_conexion = "Provider=SQLNCLI11;workstation id=pav1-db.mssql.somee.com;packet size=4096;user id=milizc_SQLLogin_1;pwd=2s9o1yeexo;data source=pav1-db.mssql.somee.com;persist security info=False;initial catalog=pav1-db";


        //procedimiento privado <conectar> que prepara la conexión con la base de dato
        private void conectar()
        {
            //asigan al objeto <conexion> la cadena de conexion
            _conexion.ConnectionString = cadena_conexion;
            //agrega la conexion (se crea el pipe entre la aplicación y la base de datos)
            _conexion.Open();
            //se comunica al objeto <cmd> sobre que conexion debe trabajar
            _cmd.Connection = _conexion;
            //se establece el tipo de comando que va ha ejecutar
            _cmd.CommandType = CommandType.Text;
        }

        //procedimiento privado <cerrar> que finaliza la conexión con la base de datos
        private void cerrar()
        {
            //cierra la conexión con la base de datos
            _conexion.Close();
        }
        //función pública <consulta> que permite a través de parámetro de entra recibir
        //un comando SQL del tipo SELECT para ser ejecutado en la base de datos.
        //Este comando SELECT selecciona un conjunto de datos en la base de datos, que
        //es devuelto un cursor a travéz de <cmd>.
        //Por esto la función tiene como valor de devolución una DataTable.
        public DataTable consulta(string comando)
        {
            //ejecuta el procedimiento local <conectar>
            conectar();
            //asigna a <cmd> el comando que se debe ejecutar, que viene por parámetro
            //de entrada <comando>
            _cmd.CommandText = comando;
            //instancia un objeto <tabla> del tipo DataTable
            DataTable tabla = new DataTable();
            //aquí dos acciones. 1) Ejecuta el comando SQL que ingreso por parámetro de entrada
            //en el pedazo de comando <cmd.ExecuteReader()>
            //2) Carga la tabla con el valor de resultado del comando SQL en el pedazo de texto
            //<tabla.Load(. . . )>
            tabla.Load(_cmd.ExecuteReader());
            //ejecuta el procedimiento <cerrar>
            cerrar();
            //devuelve el valor calculado a través de la función
            return tabla;
        }

        public bool EjecutarSQL(string comando)
        {
            conectar();

            _cmd.CommandText = comando;

            var filasAfectadas = _cmd.ExecuteNonQuery(); //Cantidad de filas afectadas

            //ejecuta el procedimiento <cerrar>
            cerrar();

            return filasAfectadas > 0;
        }


        public bool EjecutarSentenciaPreparadaSQL(string comando)
        {
            conectar();

            _cmd.CommandText = comando;

            var filasAfectadas = _cmd.ExecuteNonQuery(); //Cantidad de filas afectadas

            //ejecuta el procedimiento <cerrar>
            cerrar();

            return filasAfectadas > 0;
        }
    }
}
