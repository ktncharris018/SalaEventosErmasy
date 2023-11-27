
using DAL.Repositorios;
using ENTITY.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Servicios
{
    public class ServicioServicios
    {
        private readonly RepositorioServicio repositorioServicio;
        private readonly RepositorioReserva repositorioReserva;
        public ServicioServicios()
        {
            repositorioServicio = new RepositorioServicio();
            repositorioReserva = new RepositorioReserva();
        }

        public string Crear(Servicio servicio)
        {
            try
            {
                Reserva reserva = repositorioReserva.buscarReserva(servicio.reserva.idReserva);
                if (reserva != null)
                {
                    return ("No se puede Agregar este servicio, debido a que No existe una reserva con esta identificacion");
                }

                repositorioServicio.Crear(servicio);
                return ($"E servicio se ha agregado correctamente");
            }
            catch (Exception ex)
            {
                return ($"Error al agregar el servico: {ex.Message}");
            }
        }

        public Servicio buscarServicio(int idServicio)
        {
            return repositorioServicio.buscarServicio(idServicio);
        }

        public List<Servicio> listaServicios()
        {
            return repositorioServicio.listaServicios();
        }

        private decimal CalcularValorServicioPersonal(ServicioPersonal servicio)
        {
            decimal valor = 0;
            if (servicio.TipoPersonal == "logistica")
            {
                valor = servicio.cantidad * ServicioPersonal.ValorLogistica;
            }
            else if (servicio.TipoPersonal == "Musico")
            {
                valor = servicio.cantidad * ServicioPersonal.ValorMusicos;
            }
            return valor;
        }

        private decimal CalcularValorServicioInstalaciones(ServicioInstalacion servicio)
        {
            decimal valor = 0;
            if (servicio.TipoInstalacion == "Sonido")
            {
                valor = servicio.cantidad * ServicioInstalacion.ValorSonido;
            }
            else if (servicio.TipoInstalacion == "Iluminacion")
            {
                valor = servicio.cantidad * ServicioInstalacion.ValorIluminacion;
            }

            return valor;
        }

    }
}
