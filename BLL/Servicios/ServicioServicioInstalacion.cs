using DAL.Repositorios;
using ENTITY.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Servicios
{
    public class ServicioServicioInstalacion
    {
        private readonly RepositorioServicioInstalacion repositorioServicio;
        private readonly RepositorioReserva repositorioReserva;
        public ServicioServicioInstalacion()
        {
            repositorioServicio = new RepositorioServicioInstalacion();
            repositorioReserva = new RepositorioReserva();
        }

        public string Crear(ServicioInstalacion servicio)
        {
            try
            {
                Reserva reserva = repositorioReserva.buscarReserva(servicio.reserva.idReserva);
                if (reserva == null)
                {
                    return ("No se puede Agregar este servicio, debido a que No existe una reserva con esta identificacion");
                }
                servicio.ValorServicio = CalcularValorServicioInstalaciones(servicio);
                servicio.IdServicio = indiceServicio();
                repositorioServicio.Crear(servicio);
                return ($"E servicio se ha agregado correctamente");
            }
            catch (Exception ex)
            {
                return ($"Error al agregar el servico: {ex.Message}");
            }
        }
        public ServicioInstalacion BuscarServicio(int idServicio)
        {
            return repositorioServicio.buscarServicio(idServicio);
        }

        public List<ServicioInstalacion> listaServicio()
        {
            return repositorioServicio.listaServicios();
        }

        public int indiceServicio()
        {
            List<ServicioInstalacion> lista = listaServicio();
            ServicioInstalacion servicio = lista[lista.Count - 1];
            return servicio.IdServicio+1;
        }

        public decimal CalcularValorServicioInstalaciones(ServicioInstalacion servicio)
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
