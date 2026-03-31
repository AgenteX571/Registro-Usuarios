using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Datos;

namespace Logica_Negocios
{
    public class Negocio_Cliente
    {
        Capa_Datos.ClientesRepository data_clientes = new Capa_Datos.ClientesRepository();

        public void AgregarCliente(string _nombre, int _edad, string _email)
        {
            data_clientes.AgregarCliente(_nombre, _edad, _email);
        }

        public List<Capa_Datos.ClientesRepository.Clientes> ObtenerClientes(string _nombre)
        {
            return data_clientes.ObtenerClientes(_nombre);
        }

        public Capa_Datos.ClientesRepository.Clientes BuscarCliente(int _id)
        {
            return data_clientes.BuscarCliente(_id);
        }

        public void ActualizarCliente(int _id, string _nombre, int _edad, string _email)
        {
            data_clientes.ActualizarCliente(_id, _nombre, _edad, _email);
        }

        public void EliminarCliente(int _id)
        {
            data_clientes.EliminarCliente(_id);
        }

        public bool VerificarCliente(string _nombre, int _edad, string _correo) 
        {
            var clientes = data_clientes.ObtenerClientes(_nombre);

            foreach (var cliente in clientes)
            {
                if ((cliente.Nombre == _nombre) && (cliente.Edad == _edad) && (cliente.Email == _correo))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
