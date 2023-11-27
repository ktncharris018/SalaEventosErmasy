using DAL.Repositorios;
using ENTITY.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BLL.Servicios
{
    public class ServicioCliente
    {
        private readonly RepositorioCliente repositorio;
        public ServicioCliente()
        {
            repositorio = new RepositorioCliente();
        }

        public string Crear(Cliente cliente)
        {
            try
            {
                Cliente clienteAnterior = repositorio.buscarCliente(cliente.cedula);
                if (clienteAnterior != null)
                {
                    return ("No se puede crear este Cliente, debido a que ya existe uno con esta identificacion");
                }

                repositorio.Crear(cliente);
                return ($"El cliente {cliente.cedula} se ha creado correctamente");
            }
            catch (Exception ex)
            {
                return ($"Error al crear el cliente: {ex.Message}");
            }
        }

        public Cliente buscarCliente(string cedula)
        {
            return repositorio.buscarCliente(cedula);
        }

        public string Modificar(Cliente cliente)
        {
            if (repositorio.Modificar(cliente))
            {
                 return "Cliente Modificado exitosamente";
            }
            else
                return "No se pudo modificar el cliente";
        }

        public string Eliminar(string cedula)
        {
            if (repositorio.Eliminar(cedula))
            {
                return "Cliente Elimindado exitosamente";
            }
            else
                return "Error al eliminar";
        }
        public List<Cliente> listaClientes()
        {
            return repositorio.listaClientes();
        }
    }
}
