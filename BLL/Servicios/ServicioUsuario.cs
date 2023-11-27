using DAL.Repositorios;
using ENTITY.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace BLL.Servicios
{
    public class ServicioUsuario
    {
        private readonly RepositorioUsuario repositorio;
        public ServicioUsuario()
        {
            repositorio = new RepositorioUsuario();
        }

        public string Crear(Usuario usuario)
        {
            try
            {
                Usuario usuarioAnterior = repositorio.buscarUsuario(usuario.cedula);
                if (usuarioAnterior != null)
                {
                    return ("No se puede crear este Usuario, debido a que ya existe uno con esta identificacion");
                }

                repositorio.Crear(usuario);
                return ($"El usuario {usuario.cedula} se ha creado correctamente");
            }
            catch (Exception ex)
            {
                return ($"Error al crear el usuario: {ex.Message}");
            }
        }

        public string Modificar(Usuario usuario)
        {
            if (repositorio.Modificar(usuario))
            {
                return "Usuario modificado exitosamente";
            }
            else
                return "Error al modifcar al usuario";
        }

        public List<Usuario> listaUsuariosl()
        {
            return repositorio.listaUsuarios();
        }

        public Usuario buscarUsuario(string cedula)
        {
            return repositorio.buscarUsuario(cedula);
        }

        public Usuario buscarUsuario(string UserName, string password)
        {
            foreach (var u in listaUsuariosl())
            {
                if (UserName == u.UserName && password == u.password)
                {
                    return u;
                }
            }
            return null;
        }


        public bool Login(string UserName, string password)
        {
            foreach (Usuario u in repositorio.listaUsuarios())
            {
                if (UserName == u.UserName && password == u.password)
                {
                    return true;
                }
                else
                    return false;
            }
            return false;
        }
    }
}
