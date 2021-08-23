using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bt_regist_Click(object sender, EventArgs e)
        {
            Usuarios usuario = new Usuarios();

            usuario.User_name = txt_userName.Text;
            usuario.Nombre  = txt_Nombre.Text;
            usuario.Apellido= txt_Apellido.Text;
           // usuario.Numero = int.Parse(txt_numero.Text);
            usuario.Correo = txt_correo.Text;
            usuario.Contraseña= txt_contra.Text;
            usuario.Confirmar= txt_confirmar.Text;




            try { 
            Controller control = new Controller();
           string respuesta = control.control_registro(usuario);

            if(respuesta.Length > 0)
            {
                MessageBox.Show(respuesta,"Mensaje de error",MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show(respuesta, "Usuario Registrado", MessageBoxButtons.OK);
            }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void txt_contra_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
