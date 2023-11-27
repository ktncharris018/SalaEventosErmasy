using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY.Entidades
{
    public class Persona
    {
        public string cedula { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public int telefono { get; set; }


        public Persona()
        {

        }

        public Persona(string cedula, string nombre, string apellido, int telefono)
        {
            this.cedula = cedula;
            this.nombre = nombre;
            this.apellido = apellido;
            this.telefono = telefono;
        }
    }
}
