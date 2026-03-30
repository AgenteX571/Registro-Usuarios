using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Capa_Datos
{
    public class UsuariosRepository
    {
        public class Usuario
        {
            public int Id { get; set; }
            public string Nombre { get; set; }
            public string Contraseña { get; set; }
        }

        public void AgregarUsuario(string _nombre, string _contraseña)
        {
            using (SqlConnection cxn = new SqlConnection(cnn.db))
            {
                cxn.Open();
                string query = "execute procedure sp_Crear_Usuario @Nombre, @Contraseña";
                using (SqlCommand cmd = new SqlCommand(query, cxn))
                {
                    cmd.Parameters.AddWithValue("@Nombre", _nombre);
                    cmd.Parameters.AddWithValue("@Contraseña", _contraseña);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public List<Usuario> ObtenerUsuarios(string _nombre = "")
        {
            List<Usuario> usuarios = new List<Usuario>();
            using (SqlConnection cxn = new SqlConnection(cnn.db))
            {
                cxn.Open();
                string query = "execute sp_Obtener_Usuarios @Nombre";
                using (SqlCommand cmd = new SqlCommand(query, cxn))
                {
                    cmd.Parameters.AddWithValue("@Nombre", _nombre);

                    using (SqlDataReader rd = cmd.ExecuteReader())
                    {
                        while (rd.Read())
                        {
                            Usuario usuario = new Usuario
                            {
                                Id = int.Parse(rd["Id"].ToString()),
                                Nombre = rd["Nombre"].ToString(),
                                Contraseña = rd["Contraseña"].ToString()
                            };
                            usuarios.Add(usuario);
                        }
                    }
                }
            }
            return usuarios;
        }

        public Usuario BuscarUsuario(int _id) 
        {
            string query = "execute sp_Buscar_Usuario @Id";
            using (SqlConnection cxn = new SqlConnection(cnn.db))
            {
                cxn.Open();
                using (SqlCommand cmd = new SqlCommand(query, cxn))
                {
                    cmd.Parameters.AddWithValue("@Id", _id);

                    using (SqlDataReader rd = cmd.ExecuteReader())
                    {
                        Usuario usuario = new Usuario
                        {
                            Id = int.Parse(rd["Id"].ToString()),
                            Nombre = rd["Nombre"].ToString(),
                            Contraseña = rd["Contraseña"].ToString()
                        };
                        return usuario;
                    }
                }
            }
        }

        public void ActualizarUsuario(int _id, string _nombre, string _contraseña) 
        {
            string query = "execute sp_Actualizar_Usuario @Id, @Nombre, @Contraseña";
            using (SqlConnection cxn = new SqlConnection(cnn.db))
            {
                cxn.Open();
                using (SqlCommand cmd = new SqlCommand(query, cxn))
                {
                    cmd.Parameters.AddWithValue("@Id", _id);
                    cmd.Parameters.AddWithValue("@Nombre", _nombre);
                    cmd.Parameters.AddWithValue("@Contraseña", _contraseña);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void EliminarUsuario(int _id) 
        {
            string query = "execute sp_Eliminar_Usuario @Id";
            using (SqlConnection cxn = new SqlConnection(cnn.db)) 
            {
                cxn.Open();
                using (SqlCommand cmd = new SqlCommand(query, cxn)) 
                {
                    cmd.Parameters.AddWithValue("@Id", _id);

                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
