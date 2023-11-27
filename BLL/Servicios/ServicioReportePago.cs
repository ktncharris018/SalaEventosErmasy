using DAL.Repositorios;
using ENTITY.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Servicios
{
    public class ServicioReportePago
    {
        private readonly RepositorioReportePago repositorioReporte;
        private readonly RepositorioServicioPersonal servicioPersonal;
        private readonly RepositorioServicioInstalacion servicioInstalacion;
        public ServicioReportePago() 
        {
            repositorioReporte = new RepositorioReportePago();
            servicioPersonal = new RepositorioServicioPersonal();
            servicioInstalacion = new RepositorioServicioInstalacion();
        }
        public string Crear(ReportePago reporte)
        {
            try
            {
                repositorioReporte.Crear(reporte);
                return ($"Reporte Creado correctamente");
            }
            catch (Exception ex)
            {
                return ($"Error al crear el reporte: {ex.Message}");
            }
        }

        public ReportePago BuscarReporte(int id)
        {
            return repositorioReporte.buscarReporte(id);
        }

        public List<ReportePago> listaReportes()
        {
            return repositorioReporte.listaReportes();
        }

        public decimal SubTotalPersonal(Reserva reserva)
        {
            decimal valor = 0;
            foreach (var servicio in servicioPersonal.listaServicios())
            {
                if (servicio.reserva.idReserva == reserva.idReserva)
                {
                    if(servicio.TipoServicio == "Servicio Personal")
                    {
                        valor = valor + servicio.ValorServicio;
                    }

                }
            }
            return valor;
        }
        public decimal SubTotalInstalacion(Reserva reserva)
        {
            decimal valor = 0;
            foreach (var servicio in servicioInstalacion.listaServicios())
            {
                if (servicio.reserva.idReserva == reserva.idReserva)
                {
                    if (servicio.TipoServicio == "Servicio Instalacion")
                    {
                        valor = valor + servicio.ValorServicio;
                    }

                }
            }
            return valor;
        }

        public decimal TotalServicio(Reserva r)
        {
            decimal valor = 0;
            valor = SubTotalInstalacion(r) + SubTotalPersonal(r);

            return valor;
        }

        //public double TotalReserva(Reserva r)
        //{
        //    double valor = 0; 
        //    valor = TotalServicio(r) + (NumHoras(r) * Reserva.ValorHora);

        //    return valor;
        //}

        private double NumHoras(Reserva r)
        { 
            double Num;
            Num = (r.horaInicio - r.horaFin).TotalHours;
            return Num;
        }
    }
}
