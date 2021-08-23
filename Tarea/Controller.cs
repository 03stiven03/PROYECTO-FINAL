using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace Tarea
{
    class Controller
    {
        public string control_registro (Usuarios usuario)
        {
            //string num = usuario.Numero.ToString();
            Modelo modelo = new Modelo();
            string respuesta = "";

            if (string.IsNullOrEmpty(usuario.User_name) || string.IsNullOrEmpty(usuario.Nombre)
                || string.IsNullOrEmpty(usuario.Apellido) || string.IsNullOrEmpty(usuario.Numero.ToString())
                || string.IsNullOrEmpty(usuario.Correo) || string.IsNullOrEmpty(usuario.Contraseña)
                || string.IsNullOrEmpty(usuario.Confirmar))
            {
                respuesta = "Debe llenar todos los campos";
            }
            else
            {
                if(usuario.Contraseña == usuario.Confirmar)
                {
                    if (modelo.usuario_exite(usuario.User_name))
                    {
                        respuesta = "Este Usuario ya existe";
                    }
                    else
                    {
                        usuario.Contraseña = generarSHA1(usuario.Contraseña);
                        modelo.registro(usuario);
                    }

                }
                else
                {
                    respuesta = "Las contraseñas no coinciden";
                }
            }
            return respuesta;

            }
        private string generarSHA1(string cadena)
        {
            UTF8Encoding enc = new UTF8Encoding();
            Byte[] data = enc.GetBytes(cadena);
            byte[] resultado;

            SHA1CryptoServiceProvider sha = new SHA1CryptoServiceProvider();
            resultado = sha.ComputeHash(data);

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < resultado.Length; i++)
            {
                if (resultado[i] < 16)
                {
                    sb.Append("0");
                }
                sb.Append(resultado[i].ToString("x"));
            }

            return sb.ToString();
        }

        }




    }

