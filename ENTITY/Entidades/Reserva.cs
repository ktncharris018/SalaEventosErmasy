using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY.Entidades
{
    public class Reserva
    {
        public int idReserva { get; set; }
        public DateTime fecha { get; set; }
        public TimeSpan horaInicio { get; set; }
        public TimeSpan horaFin { get; set; }
        public Cliente cliente { get; set; }
        public string tipoEvento { get; set; }
        public string observaciones { get; set; }
        public string estado { get; set; }

        public const decimal ValorHora = 2000;

        public Reserva()
        {
            estado = "Pendiente";
        }

    
        
    }
}
