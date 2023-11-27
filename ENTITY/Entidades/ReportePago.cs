using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY.Entidades
{
    public class ReportePago
    {
        public int IdReportePago { get; set; }
        public DateTime Fecha { get; set; }
        public Reserva reserva { get; set; }
        public decimal TotalPagar {  get; set; }

        public ReportePago()
        {

        }
    }
}
