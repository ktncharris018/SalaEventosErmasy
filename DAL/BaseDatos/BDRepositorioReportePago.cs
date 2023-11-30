using ENTITY.Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL.Repositorios;

namespace DAL.BaseDatos
{
    public class BDRepositorioReportePago
    {

        private SqlConnection cn = new SqlConnection("Data Source=LAPTOP-SUIG96PD;Initial Catalog=SalaEventos;Integrated Security=True;Encrypt=False");
        private readonly RepositorioReserva repositorio;
        public BDRepositorioReportePago()
        {
            repositorio = new RepositorioReserva();
        }
        public bool Crear(ReportePago r)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("insert into ReportePago(idReporte,fecha,idReserva,totalPagar) values ('" + r.IdReportePago.ToString() + "','" + r.Fecha.ToString("d") + "','" + r.reserva.idReserva.ToString() + ",'" + r.TotalPagar.ToString() + "')", cn);

                cmd.CommandType = CommandType.Text;
                cn.Open();
                cmd.ExecuteNonQuery();
                cn.Close();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al agregar el Reporte: {ex.Message}");
                return false;

            }
        }
        public ReportePago buscarReporte(int id)
        {
            try
            {
                foreach (ReportePago r in listaReportes())
                {
                    if (id == r.IdReportePago)
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
     
        public List<ReportePago> listaReportes()
        {
            List<ReportePago> lista = new List<ReportePago>();


            try
            {
                int id;
                SqlCommand cmd = new SqlCommand("select * from ReportePago", cn);
                cmd.CommandType = CommandType.Text;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    ReportePago r = new ReportePago();
                    r.IdReportePago = int.Parse(dr["cedula"].ToString());
                    r.Fecha = DateTime.Parse(dr["nombre"].ToString());
                    id = int.Parse(dr["idReserva"].ToString());
                    r.reserva = repositorio.buscarReserva(id);
                    r.TotalPagar = decimal.Parse(dr["telefono"].ToString());

                    lista.Add(r);
                }
                cn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al listar los Reportes: {ex.Message}");
            }
            return lista;
        }
    }
}
