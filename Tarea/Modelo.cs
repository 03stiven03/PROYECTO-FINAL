using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace Tarea
{
    class Modelo
    {
        public int registro(Usuarios usuario)
        {
            MySqlConnection conexion = Conexion.GetConexion();
            conexion.Open();

            string sql = "INSERT INTO usuarios (user_name,Nombre,Apellido,tel_num,Correo,Contraseña,confirmar) VALUES(@user_name,@Nombre,@apellido,@numero,@Correo,@Contrase; @confirmar)";

            MySqlCommand comando = new MySqlCommand(sql, conexion);

            comando.Parameters.AddWithValue("@user_name", usuario.User_name);
            comando.Parameters.AddWithValue("@Nombre", usuario.Nombre);
            comando.Parameters.AddWithValue("@apellido", usuario.Apellido);
            comando.Parameters.AddWithValue("@numero", usuario.Numero);
            comando.Parameters.AddWithValue("@Correo", usuario.Correo);
            comando.Parameters.AddWithValue("@Contrase", usuario.Contraseña);
            comando.Parameters.AddWithValue("@confirmar", usuario.Confirmar);

            int resultado = comando.ExecuteNonQuery();

            return resultado;
        }
        public bool usuario_exite(string usuario)
        {
            MySqlDataReader lector;
            MySqlConnection conexion = Conexion.GetConexion();
            conexion.Open();

            string sql = "INSERT INTO usuarios (SELECT Id_usuario from usuarios where user_name like @user_name )";

            MySqlCommand comando = new MySqlCommand(sql, conexion);

            comando.Parameters.AddWithValue("@user_name", usuario);
            lector = comando.ExecuteReader();

            if (lector.HasRows)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
