using System;
using System.Collections.Generic;
using System.Text;

namespace Tarea
{
    class Usuarios
    {
        int id,numero;
        String user_name, nombre, apellido, correo, contraseña,confirmar;

        public string User_name { get => user_name; set => user_name = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Correo { get => correo; set => correo = value; }
        public string Contraseña { get => contraseña; set => contraseña = value; }
        public string Confirmar { get => confirmar; set => confirmar = value; }
        public int Id { get => id; set => id = value; }
        public int Numero { get => numero; set => numero = value; }
    }
}
