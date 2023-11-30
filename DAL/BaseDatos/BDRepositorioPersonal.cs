using ENTITY.Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAL.BaseDatos
{
    public class BDRepositorioPersonal
    {
        private SqlConnection cn = new SqlConnection("Data Source=LAPTOP-SUIG96PD;Initial Catalog=SalaEventos;Integrated Security=True;Encrypt=False");
        public bool Crear(Personal c)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("insert into Personal(cedula,nombre,apellido,telefono) values ('" + c.cedula.ToString() + "','" + c.nombre.ToString() + "','" + c.apellido.ToString() + ",'" + c.telefono.ToString() + "')", cn);

                cmd.CommandType = CommandType.Text;
                cn.Open();
                cmd.ExecuteNonQuery();
                cn.Close();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al agregar el Personal: {ex.Message}");
                return false;

            }
        }
        public Personal buscarPersonal(string cedula)
        {
            try
            {
                foreach (Personal p in listaPersonal())
                {
                    if (cedula == p.cedula)
                    {
                        return p;
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
        public bool Modificar(Personal p)
        {
            List<Personal> personals = listaPersonal(); 

            try
            {
                SqlCommand cmd = new SqlCommand("update Personal set cedula = '" + p.cedula.ToString() + "', nombre = '" + p.nombre.ToString() + "', apellido = '" + p.apellido.ToString() + "', telefono = '" + p.telefono.ToString() + "' where cedula = " + p.cedula.ToString() + "", cn);
                cmd.CommandType = CommandType.Text;
                cn.Open();
                cmd.ExecuteNonQuery();
                cn.Close();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al modificar el Empleado: {ex.Message}");
                return false;
            }
        }
        public bool Eliminar(string cedula)
        {
            List<Personal> cLientes = listaPersonal();

            try
            {
                SqlCommand cmd = new SqlCommand("delete from Personal where cedula = " + cedula.ToString() + "", cn);
                cmd.CommandType = CommandType.Text;
                cn.Open();
                cmd.ExecuteNonQuery();
                cn.Close();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al eliminar el Empleado: {ex.Message}");
                return false;
            }
        }

        public List<Personal> listaPersonal()
        {
            List<Personal> lista = new List<Personal>();


            try
            {
                SqlCommand cmd = new SqlCommand("select * from Personal", cn);
                cmd.CommandType = CommandType.Text;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Personal c = new Personal();
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
                MessageBox.Show($"Error al listar los Empleados: {ex.Message}");
            }
            return lista;
        }
    }
}
