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
    public class RepositorioCliente
    {
        private readonly string FileName = "Clientes.txt";

        public bool Crear(Cliente cliente)
        {
            try
            {
                FileStream file = new FileStream(FileName, FileMode.Append);
                StreamWriter writer = new StreamWriter(file);
                writer.WriteLine($"{cliente.cedula};{cliente.nombre};{cliente.apellido};{cliente.telefono}");
                writer.Close();
                file.Close();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al crear El cliente: {ex.Message}");
                return false;

            }
        }

        public Cliente buscarCliente(string cedula)
        {
            try
            {
                foreach (var cliente in listaClientes())
                {
                    if (cedula == cliente.cedula)
                    {
                        return cliente;
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
        public bool Modificar(Cliente cliente) //200
        {
            List<Cliente> clientes = new List<Cliente>();
            clientes = listaClientes();

            try
            {
                FileStream file = new FileStream(FileName, FileMode.Create);
                file.Close();

                foreach (var ClienteAnterior in clientes)//100
                {
                    if (ClienteAnterior.cedula != cliente.cedula)
                    {
                        Crear(ClienteAnterior);
                    }
                    else
                        Crear(cliente);
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al modificar el cliente: {ex.Message}");
                return false;
            }
        }

        public bool Eliminar(string cedula)
        {
            List<Cliente> clientes = new List<Cliente>();
            clientes = listaClientes();

            try
            {
                FileStream file = new FileStream(FileName, FileMode.Create);
                file.Close();

                foreach (var cliente in clientes)
                {
                    if (cliente.cedula != cedula)
                    {
                        Crear(cliente);
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al elminar el cliente: {ex.Message}");
                return false;
            }
        }

        public List<Cliente> listaClientes()
        {
            List<Cliente> clientes = new List<Cliente>();
            try
            {
                FileStream file = new FileStream(FileName, FileMode.OpenOrCreate, FileAccess.Read);
                StreamReader reader = new StreamReader(file);
                string linea = string.Empty;
                while ((linea = reader.ReadLine()) != null)
                {
                    Cliente cliente = Map(linea);
                    clientes.Add(cliente);
                }
                reader.Close();
                file.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al listar los clientes: {ex.Message}");
            }
            return clientes;
        }
        private Cliente Map(String linea)
        {
            try
            {
                Cliente cliente = new Cliente();
                char delimiter = ';';
                string[] matrizCliente = linea.Split(delimiter);
                cliente.cedula = matrizCliente[0];
                cliente.nombre = matrizCliente[1];
                cliente.apellido = matrizCliente[2];
                cliente.telefono = int.Parse((matrizCliente[3]));
                
                return cliente;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al mapear: {ex.Message}");
                return null;
            }
        }
    }
}
