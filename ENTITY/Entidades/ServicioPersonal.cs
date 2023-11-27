using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY.Entidades
{
    public class ServicioPersonal : Servicio
    {
        public string TipoPersonal { get; set; }

        public const decimal ValorLogistica = 50000;
        public const decimal ValorMusicos = 6000;

        public ServicioPersonal()
        {

        }
        public ServicioPersonal(int IdServicio, Reserva reserva, string TipoServicio, int cantidad, decimal ValorServicio) 
            :base(IdServicio,reserva,TipoServicio,cantidad,ValorServicio) 
        {
        
        }
    }
}
