using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Datos;

namespace Logica_Negocios
{
    public class Negocio_Usuarios
    {
        Capa_Datos.UsuariosRepository data_usuario = new UsuariosRepository();

        public void AgregarUsuario(string _nombre, string _contraseña)
        {
            data_usuario.AgregarUsuario(_nombre, _contraseña);
        }

        public List<Capa_Datos.UsuariosRepository.Usuario> ObtenerUsuarios(string _nombre = "")
        {
            return data_usuario.ObtenerUsuarios(_nombre);
        }

        public Capa_Datos.UsuariosRepository.Usuario ObtenerUsuarioId(int _id)
        {
            return data_usuario.BuscarUsuario(_id);
        }

        public void ActualizarUsuario(int _id, string _nombre, string _contraseña)
        {
            data_usuario.ActualizarUsuario(_id, _nombre, _contraseña);
        }

        public void EliminarUsuario(int _id)
        {
            data_usuario.EliminarUsuario(_id);
        }

        public bool ValidarUsuario(string _nombre, string _contraseña)
        {
            var usuarios = data_usuario.ObtenerUsuarios(_nombre);
            foreach (var usuario in usuarios)
            {
                if ((usuario.Nombre == _nombre) && (usuario.Contraseña == _contraseña))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
