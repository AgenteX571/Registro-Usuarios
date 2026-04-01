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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        // Variables del form
        bool data = false;
        int id_actual = 0;

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }

        // Metodos del panel de clientes
        Logica_Negocios.Negocio_Cliente logica_cliente = new Logica_Negocios.Negocio_Cliente();

        private void btn_buscar_cliente_Click(object sender, EventArgs e)
        {
            dataGridView_Clientes.Rows.Clear();
            dataGridView_Clientes.Refresh();

            var clientes = logica_cliente.ObtenerClientes(txt_buscar_cliente.Text);
            foreach (var cliente in clientes)
            {
                dataGridView_Clientes.Rows.Add(cliente.Id, cliente.Nombre, cliente.Edad, cliente.Email);
            }
        }

        private void btn_crear_cliente_Click(object sender, EventArgs e)
        {
            if ((txt_nombre_cliente.Text != string.Empty) && (txt_edad_cliente.Text != string.Empty) && (txt_Correo_cliente.Text != string.Empty))
            {
                if (data)
                {
                    MessageBox.Show("Este cliente ya existe, por favor elija otro", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    LimpiarFormularioCliente();
                }
                else
                {
                    logica_cliente.AgregarCliente(txt_nombre_cliente.Text, int.Parse(txt_edad_cliente.Text), txt_Correo_cliente.Text);
                    MessageBox.Show("Cliente creado exitosamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarFormularioCliente();
                }
            }
            else
            {
                MessageBox.Show("Por favor, complete todos los campos para crear un cliente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LimpiarFormularioCliente()
        {
            txt_nombre_cliente.Text = string.Empty;
            txt_edad_cliente.Text = string.Empty;
            txt_Correo_cliente.Text = string.Empty;
            data = false;
        }

        private void btn_editar_cliente_Click(object sender, EventArgs e)
        {
            if (dataGridView_Clientes.CurrentRow != null)
            {
                id_actual = int.Parse(dataGridView_Clientes.CurrentRow.Cells[0].Value.ToString());
                txt_nombre_cliente.Text = dataGridView_Clientes.CurrentRow.Cells[1].Value.ToString();
                txt_edad_cliente.Text = dataGridView_Clientes.CurrentRow.Cells[2].Value.ToString();
                txt_Correo_cliente.Text = dataGridView_Clientes.CurrentRow.Cells[3].Value.ToString();

                dataGridView_Clientes.Rows.Clear();
                dataGridView_Clientes.Refresh();

                data = true;
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un cliente para editar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_actualizar_cliente_Click(object sender, EventArgs e)
        {
            if (data)
            {
                logica_cliente.ActualizarCliente(id_actual, txt_nombre_cliente.Text, int.Parse(txt_edad_cliente.Text), txt_Correo_cliente.Text);
                MessageBox.Show("Cliente actualizado exitosamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarFormularioCliente();
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un cliente para actualizar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_borrar_cliente_Click(object sender, EventArgs e)
        {
            if (data)
            {
                logica_cliente.EliminarCliente(id_actual);
                MessageBox.Show("Cliente Eliminado exitosamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarFormularioCliente();
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un cliente para eliminar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LimpiarFormularioCliente();
            panel_empleados.Visible = false;
            panel_clientes.Visible = true;
        }

        // Metodos del panel de empleados
        Logica_Negocios.Negocio_Empleados logica_empleados = new Logica_Negocios.Negocio_Empleados();

        private void btn_buscar_empleado_Click(object sender, EventArgs e)
        {
            dataGridView_empleados.Rows.Clear();
            dataGridView_empleados.Refresh();

            var empleados = logica_empleados.ObtenerEmpleados(txt_buscar_empleado.Text);
            foreach (var empleado in empleados)
            {
                dataGridView_empleados.Rows.Add(empleado.Id, empleado.Nombre, empleado.Edad, empleado.Correo, empleado.Puesto);
            }
        }

        private void btn_crear_empleado_Click(object sender, EventArgs e)
        {
            if ((txt_nombre_empleados.Text != string.Empty) && (txt_correo_empleados.Text != string.Empty) &&
                (txt_edad_empleados.Text != string.Empty) && (txt_puesto.Text != string.Empty))
            {
                if (data)
                {
                    MessageBox.Show("Este Empleado ya existe, por favor elija otro", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    LimpiarFormularioEmpleado();
                }
                else
                {
                    logica_empleados.AgregarEmpleado(txt_nombre_empleados.Text, int.Parse(txt_edad_empleados.Text), txt_correo_empleados.Text, txt_puesto.Text);
                    MessageBox.Show("Empleado creado exitosamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarFormularioEmpleado();
                }
            }
            else
            {
                MessageBox.Show("Por favor, complete todos los campos para crear un cliente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_editar_empleado_Click(object sender, EventArgs e)
        {
            if (dataGridView_empleados.CurrentRow != null)
            {
                id_actual = int.Parse(dataGridView_empleados.CurrentRow.Cells[0].Value.ToString()); 
                txt_nombre_empleados.Text = dataGridView_empleados.CurrentRow.Cells[1].Value.ToString();
                txt_edad_empleados.Text = dataGridView_empleados.CurrentRow.Cells[2].Value.ToString();
                txt_correo_empleados.Text = dataGridView_empleados.CurrentRow.Cells[3].Value.ToString();
                txt_puesto.Text = dataGridView_empleados.CurrentRow.Cells[4].Value.ToString();
                dataGridView_empleados.Rows.Clear();
                dataGridView_empleados.Refresh();
                data = true;
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un empleado para editar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_actualizar_empleado_Click(object sender, EventArgs e)
        {
            if (data)
            {
                logica_empleados.ActualizarEmpleado(id_actual, txt_nombre_empleados.Text, int.Parse(txt_edad_empleados.Text), txt_correo_empleados.Text, txt_puesto.Text);
                MessageBox.Show("Empleado actualizado exitosamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarFormularioEmpleado();
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un empleado para actualizar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_borrar_empleado_Click(object sender, EventArgs e)
        {
            if (data)
            {
                logica_empleados.EliminarEmpleado(id_actual);
                MessageBox.Show("Empleado Eliminado exitosamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarFormularioEmpleado();
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un empleado para eliminar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LimpiarFormularioEmpleado()
        {
            txt_buscar_empleado.Text = string.Empty;
            txt_nombre_empleados.Text = string.Empty;
            txt_edad_empleados.Text = string.Empty;
            txt_correo_empleados.Text = string.Empty;
            txt_puesto.Text = string.Empty;
            dataGridView_empleados.Rows.Clear();
            dataGridView_empleados.Refresh();
            data = false;
        }

        private void empleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LimpiarFormularioEmpleado();
            panel_clientes.Visible = false;
            panel_empleados.Visible = true;
        }
    }
}
