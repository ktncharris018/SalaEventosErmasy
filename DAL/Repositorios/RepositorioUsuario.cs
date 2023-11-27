using ENTITY.Entidades;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAL.Repositorios
{
    public class RepositorioUsuario
    {
        private readonly string FileName = "Usuarios.txt";

        public bool Crear(Usuario usuario)
        {
            try
            {
                FileStream file = new FileStream(FileName, FileMode.Append);
                StreamWriter writer = new StreamWriter(file);
                writer.WriteLine($"{usuario.cedula};{usuario.nombre};{usuario.apellido};{usuario.telefono};{usuario.UserName};{usuario.password};{usuario.tipoUsuario}");
                writer.Close();
                file.Close();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al crear El usuario: {ex.Message}");
                return false;

            }
        }

        public Usuario buscarUsuario(string cedula)
        {
            try
            {
                foreach (var usuario in listaUsuarios())
                {
                    if (cedula == usuario.cedula)
                    {
                        return usuario;
                    }
                }
                return null;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al buscar por cedula: {ex.Message}");
                return null;
            }
        }

        public bool Modificar(Usuario usuario)
        {
            List<Usuario> usuarios = new List<Usuario>();
            usuarios = listaUsuarios();

            try
            {
                FileStream file = new FileStream(FileName, FileMode.Create);
                file.Close();

                foreach (var UsuarioAnterior in usuarios)
                {
                    if (UsuarioAnterior.cedula != usuario.cedula)
                    {
                        Crear(UsuarioAnterior);
                    }
                    else
                        Crear(usuario);
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al modificar el usuario: {ex.Message}");
                return false;
            }
        }

        public List<Usuario> listaUsuarios()
        {
            List<Usuario> usuarios = new List<Usuario>();
            try
            {
                FileStream file = new FileStream(FileName, FileMode.OpenOrCreate, FileAccess.Read);
                StreamReader reader = new StreamReader(file);
                string linea = string.Empty;
                while ((linea = reader.ReadLine()) != null)
                {
                    Usuario usuario = Map(linea);
                    usuarios.Add(usuario);
                }
                reader.Close();
                file.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al listar los usuarios: {ex.Message}");
            }
            return usuarios;
        }
        private Usuario Map(String linea)
        {
            try
            {
                Usuario usuario = new Usuario();
                char delimiter = ';';
                string[] matrizUsuario = linea.Split(delimiter);
                usuario.cedula = matrizUsuario[0];
                usuario.nombre = matrizUsuario[1];
                usuario.apellido = matrizUsuario[2];
                usuario.telefono = int.Parse((matrizUsuario[3]));
                usuario.UserName = matrizUsuario[4];
                usuario.password = matrizUsuario[5];
                usuario.tipoUsuario = matrizUsuario[6];
                return usuario;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al mapear: {ex.Message}");
                return null;
            }
        }

    }
}
