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
            this.KeyPreview = true;
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
                // abrir el formulario principal
                Menu menu = new Menu();
                menu.Owner = this;
                menu.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_contraseña.Text = "";
            }
        }

        private void txt_nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                txt_contraseña.Focus();
            }
        }

        private void txt_contraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btn_iniciar.Focus();
                btn_iniciar.PerformClick();
            }
        }

        private void Login_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
                e.Handled = true;
            }
        }
    }
}
