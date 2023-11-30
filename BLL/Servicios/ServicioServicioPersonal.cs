
using DAL.Repositorios;
using ENTITY.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Servicios
{
    public class ServicioServicioPersonal
    {
        private readonly RepositorioServicioPersonal repositorioServicio;
        private readonly RepositorioReserva repositorioReserva;
        public ServicioServicioPersonal()
        {
            repositorioServicio = new RepositorioServicioPersonal();
            repositorioReserva = new RepositorioReserva();
        }

        public string Crear(ServicioPersonal servicio)
        {
            try
            {
                Reserva reserva = repositorioReserva.buscarReserva(servicio.reserva.idReserva);
                if (reserva == null)
                {
                    return ("No se puede Agregar este servicio, debido a que No existe una reserva con esta identificacion");
                }
                servicio.ValorServicio = CalcularValorServicioPersonal(servicio);
                servicio.IdServicio = indiceServicio();
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

        public List<ServicioPersonal> listaServicios()
        {
            return repositorioServicio.listaServicios();
        }

        public int indiceServicio()
        {
            List<ServicioPersonal> lista = listaServicios();
            ServicioPersonal servicio = lista[lista.Count - 1];
            return servicio.IdServicio + 1;
        }
        public decimal CalcularValorServicioPersonal(ServicioPersonal servicio)
        {
            decimal valor = 0;
            if (servicio.TipoPersonal == "Logistica")
            {
                valor = servicio.cantidad * ServicioPersonal.ValorLogistica;
            }
            else if (servicio.TipoPersonal == "Musico")
            {
                valor = servicio.cantidad * ServicioPersonal.ValorMusicos;
            }
            return valor;
        }

    }
}
