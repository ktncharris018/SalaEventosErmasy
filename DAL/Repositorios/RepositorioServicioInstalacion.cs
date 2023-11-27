using ENTITY.Entidades;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAL.Repositorios
{
    public class RepositorioServicioInstalacion
    {
        private readonly string FileName = "SeriviciosInstalacion.txt";
        private readonly RepositorioReserva repositorioReserva;
        public RepositorioServicioInstalacion()
        {
            repositorioReserva = new RepositorioReserva();
        }

        public bool Crear(ServicioInstalacion servicio)
        {
            try
            {
                FileStream file = new FileStream(FileName, FileMode.Append);
                StreamWriter writer = new StreamWriter(file);
                writer.WriteLine($"{servicio.IdServicio};{servicio.reserva.idReserva};{servicio.TipoServicio};{servicio.TipoInstalacion};{servicio.cantidad};{servicio.ValorServicio}");
                writer.Close();
                file.Close();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al agregar el servicio: {ex.Message}");
                return false;

            }
        }
        public ServicioInstalacion buscarServicio(int IdServicio)
        {
            try
            {
                foreach (var servicio in listaServicios())
                {
                    if (IdServicio == servicio.IdServicio)
                    {
                        return servicio;
                    }
                }
                return null;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al buscar por id: {ex.Message}");
                return null;
            }
        }
        public List<ServicioInstalacion> listaServicios()
        {
            List<ServicioInstalacion> servicios = new List<ServicioInstalacion>();
            try
            {
                FileStream file = new FileStream(FileName, FileMode.OpenOrCreate, FileAccess.Read);
                StreamReader reader = new StreamReader(file);
                string linea = string.Empty;
                while ((linea = reader.ReadLine()) != null)
                {
                    ServicioInstalacion servicio = Map(linea);
                    servicios.Add(servicio);
                }
                reader.Close();
                file.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al listar los servicios: {ex.Message}");
            }
            return servicios;
        }
        private ServicioInstalacion Map(String linea)
        {
            try
            {
                int idReserva;
                ServicioInstalacion servicio = new ServicioInstalacion();
                char delimiter = ';';
                string[] matrizServicio = linea.Split(delimiter);
                servicio.IdServicio = int.Parse(matrizServicio[0]);
                idReserva = int.Parse(matrizServicio[1]);
                servicio.reserva = repositorioReserva.buscarReserva(idReserva);
                servicio.TipoServicio = matrizServicio[2];
                servicio.TipoInstalacion = matrizServicio[3];
                servicio.cantidad = int.Parse(matrizServicio[4]);
                servicio.ValorServicio = decimal.Parse((matrizServicio[5]));

                return servicio;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al mapear: {ex.Message}");
                return null;
            }
        }
    }

}
