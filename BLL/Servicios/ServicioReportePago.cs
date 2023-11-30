using DAL.BaseDatos;
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

        //private readonly BDRepositorioReportePago repositorioReporte;
        //private readonly BDRepositorioServicioPersonal servicioPersonal;
        //private readonly BDRepositorioServicioInstalacion servicioInstalacion;

        public ServicioReportePago() 
        {
            //repositorioReporte = new BDRepositorioReportePago();
            //servicioPersonal = new BDRepositorioServicioPersonal();
            //servicioInstalacion = new BDRepositorioServicioInstalacion();

            repositorioReporte = new RepositorioReportePago();
            servicioPersonal = new RepositorioServicioPersonal();
            servicioInstalacion = new RepositorioServicioInstalacion();
        }
        public string Crear(ReportePago reporte)
        {
            try
            {
                reporte.TotalPagar = (decimal)TotalReserva(reporte.reserva);
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

        public int indiceReporte()
        {
            List<ReportePago> lista = listaReportes();
            ReportePago reporte = lista[lista.Count - 1];
            return reporte.IdReportePago + 1;
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

        public double TotalReserva(Reserva r)
        {
            double valor = 0;
            decimal num = (decimal)NumHoras(r);
            valor = (double)(TotalServicio(r) + (num * Reserva.ValorHora));

            return valor;
        }

        private double NumHoras(Reserva r)
        { 
            double Num;
            Num = (r.horaInicio - r.horaFin).TotalHours;
            return Num;
        }
    }
}
