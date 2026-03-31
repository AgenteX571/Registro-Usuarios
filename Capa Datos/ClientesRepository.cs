using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Datos
{
    public class ClientesRepository
    {
        public class Clientes
        {
            public int Id { get; set; }
            public string Nombre { get; set; }
            public int Edad { get; set; }
            public string Email { get; set; }
        }

        public void AgregarCliente(string _nombre, int _edad, string _email)
        {
            string query = "execute procedure sp_Crear_Cliente @Nombre, @Edad, @Correo";
            using (SqlConnection cxn = new SqlConnection())
            {
                cxn.Open();
                using (SqlCommand cmd = new SqlCommand(query, cxn))
                {
                    cmd.Parameters.AddWithValue("@Nombre", _nombre);
                    cmd.Parameters.AddWithValue("@Edad", _edad);
                    cmd.Parameters.AddWithValue("@Correo", _email);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public List<Clientes> ObtenerClientes(string _nombre)
        {
            string query = "execute procedure sp_Obtener_Clientes @Nombre";
            using (SqlConnection cxn = new SqlConnection())
            {
                cxn.Open();
                using (SqlCommand cmd = new SqlCommand(query, cxn))
                {
                    cmd.Parameters.AddWithValue("@Nombre", _nombre);
                    using (SqlDataReader rd = cmd.ExecuteReader())
                    {
                        List<Clientes> clientes = new List<Clientes>();
                        while (rd.Read())
                        {
                            Clientes cliente = new Clientes
                            {
                                Id = int.Parse(rd["ID"].ToString()),
                                Nombre = rd["Nombre"].ToString(),
                                Edad = int.Parse(rd["Edad"].ToString()),
                                Email = rd["Correo"].ToString()
                            };
                            clientes.Add(cliente);
                        }
                        return clientes;
                    }
                }
            }
        }

        public Clientes BuscarCliente(int _id)
        {
            string query = "execute procedure sp_Buscar_Cliente @ID";
            using (SqlConnection cxn = new SqlConnection())
            {
                cxn.Open();
                using (SqlCommand cmd = new SqlCommand(query, cxn))
                {
                    cmd.Parameters.AddWithValue("@ID", _id);
                    using (SqlDataReader rd = cmd.ExecuteReader())
                    {
                        if (rd.Read())
                        {
                            Clientes cliente = new Clientes
                            {
                                Id = int.Parse(rd["ID"].ToString()),
                                Nombre = rd["Nombre"].ToString(),
                                Edad = int.Parse(rd["Edad"].ToString()),
                                Email = rd["Correo"].ToString()
                            };
                            return cliente;
                        }
                        else
                        {
                            return null;
                        }
                    }
                }
            }
        }

        public void ActualizarCliente(int _id, string _nombre, int _edad, string _correo)
        {
            string query = "execute procedure sp_Actualizar_Cliente @ID, @Nombre, @Edad, @Correo";
            using (SqlConnection cxn = new SqlConnection())
            {
                cxn.Open();
                using (SqlCommand cmd = new SqlCommand(query, cxn))
                {
                    cmd.Parameters.AddWithValue("@ID", _id);
                    cmd.Parameters.AddWithValue("@Nombre", _nombre);
                    cmd.Parameters.AddWithValue("@Edad", _edad);
                    cmd.Parameters.AddWithValue("@Correo", _correo);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void EliminarCliente(int _id)
        {
            string query = "execute procedure sp_Eliminar_Cliente @ID";
            using (SqlConnection cxn = new SqlConnection())
            {
                cxn.Open();
                using (SqlCommand cmd = new SqlCommand(query, cxn))
                {
                    cmd.Parameters.AddWithValue("@ID", _id);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
