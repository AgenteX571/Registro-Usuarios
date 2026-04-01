using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Datos
{
    public class EmpleadosRepository
    {
        public class Empleado
        {
            public int Id { get; set; }
            public string Nombre { get; set; }
            public int Edad { get; set; }
            public string Correo { get; set; }
            public string Puesto { get; set; }
        }

        public void AgregarEmpleado(string _nombre, int _edad, string _correo, string _puesto)
        {
            string query = "exec sp_Crear_Empleado @Nombre, @Edad, @Correo, @Puesto";
            using (SqlConnection cxn = new SqlConnection(cnn.db))
            {
                cxn.Open();
                using (SqlCommand cmd = new SqlCommand(query, cxn))
                {
                    cmd.Parameters.AddWithValue("@Nombre", _nombre);
                    cmd.Parameters.AddWithValue("@Edad", _edad);
                    cmd.Parameters.AddWithValue("@Correo", _correo);
                    cmd.Parameters.AddWithValue("@Puesto", _puesto);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public List<Empleado> ObtenerEmpleados(string _nombre)
        {
            List<Empleado> empleados = new List<Empleado>();
            string query = "exec sp_Obtener_Empleados @Nombre";
            using (SqlConnection cxn = new SqlConnection(cnn.db))
            {
                cxn.Open();
                using (SqlCommand cmd = new SqlCommand(query, cxn))
                {
                    using (SqlDataReader rd = cmd.ExecuteReader())
                    {
                        while (rd.Read())
                        {
                            Empleado empleado = new Empleado
                            {
                                Id = int.Parse(rd["ID"].ToString()),
                                Nombre = rd["Nombre"].ToString(),
                                Edad = int.Parse(rd["Edad"].ToString()),
                                Correo = rd["Correo"].ToString(),
                                Puesto = rd["Puesto"].ToString()
                            };
                            empleados.Add(empleado);
                        }
                    }
                }
            }
            return empleados;
        }

        public Empleado BuscarEmpleado(int _id)
        {
            string query = "exec sp_Buscar_Empleado @ID";
            using (SqlConnection cxn = new SqlConnection(cnn.db))
            {
                cxn.Open();
                using (SqlCommand cmd = new SqlCommand(query, cxn))
                {
                    cmd.Parameters.AddWithValue("@ID", _id);
                    using (SqlDataReader rd = cmd.ExecuteReader())
                    {
                        if (rd.Read())
                        {
                            Empleado empleado = new Empleado
                            {
                                Id = int.Parse(rd["ID"].ToString()),
                                Nombre = rd["Nombre"].ToString(),
                                Edad = int.Parse(rd["Edad"].ToString()),
                                Correo = rd["Correo"].ToString(),
                                Puesto = rd["Puesto"].ToString()
                            };
                            return empleado;
                        }
                    }
                }
            }
            return null;
        }

        public void ActualizarEmpleado(int _id, string _nombre, int _edad, string _correo, string _puesto)
        {
            string query = "exec sp_Actualizar_Empleado @ID, @Nombre, @Edad, @Correo, @Puesto";
            using (SqlConnection cxn = new SqlConnection(cnn.db))
            {
                cxn.Open();
                using (SqlCommand cmd = new SqlCommand(query, cxn))
                {
                    cmd.Parameters.AddWithValue("@ID", _id);
                    cmd.Parameters.AddWithValue("@Nombre", _nombre);
                    cmd.Parameters.AddWithValue("@Edad", _edad);
                    cmd.Parameters.AddWithValue("@Correo", _correo);
                    cmd.Parameters.AddWithValue("@Puesto", _puesto);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void EliminarEmpleado(int _id)
        {
            string query = "exec sp_Eliminar_Empleado @ID";
            using (SqlConnection cxn = new SqlConnection(cnn.db))
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
