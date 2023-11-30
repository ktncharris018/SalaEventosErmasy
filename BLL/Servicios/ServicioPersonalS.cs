using DAL.BaseDatos;
using DAL.Repositorios;
using ENTITY.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Servicios
{
    public class ServicioPersonalS
    {
        private readonly RepositorioPersonal repositorio;
        //private readonly BDRepositorioPersonal repositorio;
        public ServicioPersonalS() 
        {
            repositorio = new RepositorioPersonal();
            //repositorio = new BDRepositorioPersonal();  
        }

        public string Crear(Personal personal)
        {
            try
            {
                Personal PersonalAnterior = repositorio.buscarPersonal(personal.cedula);
                if (PersonalAnterior != null)
                {
                    return ("No se puede crear este Empleado, debido a que ya existe uno con esta identificacion");
                }

                repositorio.Crear(personal);
                return ($"El Empleado {personal.cedula} se ha creado correctamente");
            }
            catch (Exception ex)
            {
                return ($"Error al crear el Empleadp: {ex.Message}");
            }
        }
        public Personal buscarPersonal(string cedula)
        {
            return repositorio.buscarPersonal(cedula);
        }

        public string Modificar(Personal personal)
        {
            if (repositorio.Modificar(personal))
            {
                return "Empleado Modificado exitosamente";
            }
            else
                return "No se pudo modificar el Empleado";
        }

        public string Eliminar(string cedula)
        {
            if (repositorio.Eliminar(cedula))
            {
                return "Empleado Elimindado exitosamente";
            }
            else
                return "Error al eliminar";
        }
        public List<Personal> listaPersonals()
        {
            return repositorio.listaPersonal();
        }
    }
}
