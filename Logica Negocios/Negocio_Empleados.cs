using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Datos;

namespace Logica_Negocios
{
    public class Negocio_Empleados
    {
        Capa_Datos.EmpleadosRepository datos_empleados = new Capa_Datos.EmpleadosRepository();

        public void AgregarEmpleado(string _nombre, int _edad, string _correo, string _puesto)
        {
            datos_empleados.AgregarEmpleado(_nombre, _edad, _correo, _puesto);
        }

        public List<Capa_Datos.EmpleadosRepository.Empleado> ObtenerEmpleados(string _nombre)
        {
            return datos_empleados.ObtenerEmpleados(_nombre);
        }

        public Capa_Datos.EmpleadosRepository.Empleado BuscarEmpleadoPor(int _id)
        {
            return datos_empleados.BuscarEmpleado(_id);
        }

        public void ActualizarEmpleado(int _id, string _nombre, int _edad, string _correo, string _puesto)
        {
            datos_empleados.ActualizarEmpleado(_id, _nombre, _edad, _correo, _puesto);
        }

        public void EliminarEmpleado(int _id)
        {
                datos_empleados.EliminarEmpleado(_id);
        }

        public bool VerificarEmpleado(string _nombre, int _edad, string _correo, string _puesto)
        {
            var empleados = datos_empleados.ObtenerEmpleados(_nombre);
            foreach (var empleado in empleados)
            {
                if ((empleado.Nombre == _nombre) && (empleado.Edad == _edad) && (empleado.Correo == _correo) && (empleado.Puesto == _puesto))
                {
                    return true;
                }
            }

            return false;
        }
    }
}
