using DAL.Repositorios;
using ENTITY.Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAL.BaseDatos
{
    public class BDRepositorioReserva
    {

        private SqlConnection cn = new SqlConnection("Data Source=LAPTOP-SUIG96PD;Initial Catalog=SalaEventos;Integrated Security=True;Encrypt=False");
        private readonly RepositorioCliente repositorio;
        public BDRepositorioReserva()
        {
            repositorio = new RepositorioCliente();
        }
        public bool Crear(Reserva r)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("insert into Reserva(idReserva,cliente,fecha,horaInicio,horaFin,tipoEvento,observaciones,estado) values ('" + r.idReserva.ToString() + "','"+r.cliente.cedula+ "','" + r.fecha.ToString("d") + "','" + r.horaInicio.ToString() + ",'" + r.horaFin.ToString() + "','" +r.tipoEvento + "','"+r.observaciones + "','" +r.estado+"')", cn);

                cmd.CommandType = CommandType.Text;
                cn.Open();
                cmd.ExecuteNonQuery();
                cn.Close();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al realizar la reserva: {ex.Message}");
                return false;

            }
        }
        public Reserva buscarReserva(int id)
        {
            try
            {
                foreach (Reserva r in listaReserva())
                {
                    if (id == r.idReserva)
                    {
                        return r;
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

        public List<Reserva> listaReserva()
        {
            List<Reserva> lista = new List<Reserva>();


            try
            {
                string id;
                SqlCommand cmd = new SqlCommand("select * from Reserva", cn);
                cmd.CommandType = CommandType.Text;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Reserva r = new Reserva();
                    r.idReserva = int.Parse(dr["idReserva"].ToString());
                    id = dr["cliente"].ToString();
                    r.cliente = repositorio.buscarCliente(id);
                    r.fecha = DateTime.Parse(dr["fecha"].ToString());
                    r.horaInicio = TimeSpan.Parse(dr["horaInicio"].ToString());
                    r.horaFin = TimeSpan.Parse(dr["horaFin"].ToString());
                    r.tipoEvento = dr["observaciones"].ToString();
                    r.estado = dr["estado"].ToString();
              
                    lista.Add(r);
                }
                cn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al listar las Reservas: {ex.Message}");
            }
            return lista;
        }
    }
}
