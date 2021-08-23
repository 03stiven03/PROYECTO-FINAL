using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Tarea
{
    class Conexion
    {
        public static MySqlConnection GetConexion()
        {
            string servidor = "localhost";
            string puerto = "3306";
            string user = "root";
            string pass = "";
            string bd = "gestion";


            string cadenaConexion = "Server=" + servidor + "; port=" + puerto + "; user id=" + user + "; password=" + pass + "; database=" + bd;

            MySqlConnection conexion = new MySqlConnection(cadenaConexion);
            return conexion;
        }


    }
}
