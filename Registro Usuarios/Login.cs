using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logica_Negocios;

namespace Registro_Usuarios
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        Logica_Negocios.Negocio_Usuarios logica_usuario = new Logica_Negocios.Negocio_Usuarios();

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_iniciar_Click(object sender, EventArgs e)
        {
            // datos usuario
            string nombre = txt_nombre.Text;
            string contraseña = txt_contraseña.Text;

            // llamando a la validacion
            if (logica_usuario.ValidarUsuario(nombre, contraseña))
            {
                MessageBox.Show("Bienvenido " + nombre, "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
