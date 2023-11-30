using DAL.Repositorios;
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
    public class BDRepositorioServicioInstalacion
    {

        private SqlConnection cn = new SqlConnection("Data Source=LAPTOP-SUIG96PD;Initial Catalog=SalaEventos;Integrated Security=True;Encrypt=False");
        private readonly BDRepositorioReserva repositorio;
        public BDRepositorioServicioInstalacion()
        {
            repositorio = new BDRepositorioReserva();
        }
        public bool Crear(ServicioInstalacion s)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("insert into ServicioInstalacion(idServicio,idReserva,tipoServicio,tipoInstalacion,cantidad,valorServicio) values ('" + s.IdServicio.ToString() + "','" + s.reserva.idReserva.ToString() + "','" + s.TipoServicio.ToString() + "','" + s.TipoInstalacion.ToString() + "','"+ s.cantidad + "','"+s.ValorServicio+"')", cn);

                cmd.CommandType = CommandType.Text;
                cn.Open();
                cmd.ExecuteNonQuery();
                cn.Close();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al agregar el Servicio: {ex.Message}");
                return false;

            }
        }
        public ServicioInstalacion buscarServicio(int id)
        {
            try
            {
                foreach (ServicioInstalacion s in listaServicios())
                {
                    if (id == s.IdServicio)
                    {
                        return s;
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

        public List<ServicioInstalacion> listaServicios()
        {
            List<ServicioInstalacion> lista = new List<ServicioInstalacion>();


            try
            {
                int id;
                SqlCommand cmd = new SqlCommand("select * from ServicioInstalacion", cn);
                cmd.CommandType = CommandType.Text;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    ServicioInstalacion s = new ServicioInstalacion();
                    s.IdServicio = int.Parse(dr["idServicio"].ToString());
                    id = int.Parse(dr["idReserva"].ToString());
                    s.reserva = repositorio.buscarReserva(id);
                    s.TipoServicio = dr["tipoServicio"].ToString();
                    s.TipoInstalacion = dr["tipoInstalacion"].ToString();
                    s.cantidad = int.Parse(dr["cantidad"].ToString());
                    s.ValorServicio = decimal.Parse(dr["valorServicio"].ToString());
                    lista.Add(s);
                }
                cn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al listar los Servicios de instalacion: {ex.Message}");
            }
            return lista;
        }
    }
}
