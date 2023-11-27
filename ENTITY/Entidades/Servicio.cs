using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY.Entidades
{
    public class Servicio
    {
        public int IdServicio { get; set; }
        public Reserva reserva { get; set; }
        public string TipoServicio { get; set; }
        public int cantidad { get; set; }
        public decimal ValorServicio { get; set; }


        public Servicio()
        {

        }

        public Servicio(int IdServicio, Reserva reserva, string TipoServicio, int cantidad, decimal ValorServicio)
        {
            this.IdServicio = IdServicio;
            this.reserva = reserva;
            this.TipoServicio = TipoServicio;
            this.cantidad = cantidad;
            this.ValorServicio = ValorServicio;
        }
    }
}
