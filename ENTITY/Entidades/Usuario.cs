﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY.Entidades
{
    public class Usuario:Persona
    {
        public string UserName { get; set; }
        public string password { get; set; }
        public string tipoUsuario { get; set; }

        public Usuario()
        {

        }
        public Usuario(string cedula, string nombre, string apellido, int telefono)
            : base(cedula, nombre, apellido, telefono)
        {

        }

    }
}
