using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY.Entidades
{
    public class ServicioInstalacion:Servicio
    {

        public string TipoInstalacion {  get; set; }

        public const decimal ValorSonido = 30000;
        public const decimal ValorIluminacion = 4000;
        public ServicioInstalacion() 
        {
        
        }
    }
}
