using ENTITY.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAL.BaseDatos
{
    public class BDRepositorioCliente
    {
        private SqlConnection cn = new SqlConnection("Data Source=LAPTOP-SUIG96PD;Initial Catalog=SalaEventos;Integrated Security=True;Encrypt=False");
        public bool Crear(Cliente c)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("insert into Cliente(cedula,nombre,apellido,telefono) values ('" + c.cedula.ToString() + "','" + c.nombre.ToString() + "','" + c.apellido.ToString()+ ",'" + c.telefono.ToString() +"')", cn);

                cmd.CommandType = CommandType.Text;
                cn.Open();
                cmd.ExecuteNonQuery();
                cn.Close();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al agregar el cliente: {ex.Message}");
                return false;

            }
        }
        public Cliente buscarCliente(string cedula)
        {
            try
            {
                foreach (Cliente c in listaClientes())
                {
                    if (cedula == c.cedula)
                    {
                        return c;
                    }
                }
                return null;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al buscar por identificaion: {ex.Message}");
                return null;
            }
        }
        public bool Modificar(Cliente cliente)
        {
            List<Cliente> clientes = listaClientes(); // Obtener la lista actual de Usuarios

            try
            {
                SqlCommand cmd = new SqlCommand("update Cliente set cedula = '" + cliente.cedula.ToString() + "', nombre = '" + cliente.nombre.ToString() + "', apellido = '" + cliente.apellido.ToString() + "', telefono = '" + cliente.telefono.ToString() + "' where cedula = " + cliente.cedula.ToString() + "", cn);
                cmd.CommandType = CommandType.Text;
                cn.Open();
                cmd.ExecuteNonQuery();
                cn.Close();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al modificar el Usuario: {ex.Message}");
                return false;
            }
        }
        public bool Eliminar(string cedula)
        {
            List<Cliente> cLientes = listaClientes();

            try
            {
                SqlCommand cmd = new SqlCommand("delete from Cliente where cedula = " + cedula.ToString() + "", cn);
                cmd.CommandType = CommandType.Text;
                cn.Open();
                cmd.ExecuteNonQuery();
                cn.Close();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al eliminar el Cliente: {ex.Message}");
                return false;
            }
        }

        public List<Cliente> listaClientes()
        {
            List<Cliente> lista = new List<Cliente>();


            try
            {
                SqlCommand cmd = new SqlCommand("select * from Cliente", cn);
                cmd.CommandType = CommandType.Text;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Cliente c = new Cliente();
                    c.cedula = dr["cedula"].ToString();
                    c.nombre = dr["nombre"].ToString();
                    c.apellido = dr["apellido"].ToString();
                    c.telefono = int.Parse(dr["telefono"].ToString());
                 
                    lista.Add(c);
                }
                cn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al listar los Clientes: {ex.Message}");
            }
            return lista;
        }
    }
}
