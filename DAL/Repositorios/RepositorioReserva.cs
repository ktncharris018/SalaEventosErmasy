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
    public class RepositorioReserva
    {
        private readonly string FileName = "Reservas.txt";
        private readonly RepositorioCliente repositorioCliente;
        public RepositorioReserva() 
        {
            repositorioCliente = new RepositorioCliente();  
        }
        public bool Crear(Reserva r)
        {
            try
            {
                FileStream file = new FileStream(FileName, FileMode.Append);
                StreamWriter writer = new StreamWriter(file);
                writer.WriteLine($"{r.idReserva};{r.cliente.cedula};{r.fecha.ToString("d")};{r.horaInicio};{r.horaFin};{r.tipoEvento};{r.observaciones};{r.estado}");
                writer.Close();
                file.Close();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al crear la reserva: {ex.Message}");
                return false;

            }
        }

        public Reserva buscarReserva(int idReserva)
        {
            try
            {
                foreach (var reserva in listaReservas())
                {
                    if (idReserva == reserva.idReserva)
                    {
                        return reserva;
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
        public bool Modificar(Reserva reserva)
        {
            List<Reserva> reservas = new List<Reserva>();
            reservas = listaReservas();

            try
            {
                FileStream file = new FileStream(FileName, FileMode.Create);
                file.Close();

                foreach (var ReservaAnterior in reservas)
                {
                    if (ReservaAnterior.idReserva != reserva.idReserva)
                    {
                        Crear(ReservaAnterior);
                    }
                    else
                        Crear(reserva);
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al modificar la reserva: {ex.Message}");
                return false;
            }
        }
        public List<Reserva> listaReservas()
        {
            List<Reserva> reservas = new List<Reserva>();
            try
            {
                FileStream file = new FileStream(FileName, FileMode.OpenOrCreate, FileAccess.Read);
                StreamReader reader = new StreamReader(file);
                string linea = string.Empty;
                while ((linea = reader.ReadLine()) != null)
                {
                    Reserva reserva = Map(linea);
                    reservas.Add(reserva);
                }
                reader.Close();
                file.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al listar las reservas: {ex.Message}");
            }
            return reservas;
        }
        private Reserva Map(String linea)
        {
            try
            {
                Reserva reserva = new Reserva();
                char delimiter = ';';
                string[] matrizReserva = linea.Split(delimiter);
                reserva.idReserva = int.Parse(matrizReserva[0]);
                var cedula = matrizReserva[1];
                reserva.cliente = repositorioCliente.buscarCliente(cedula);
                reserva.fecha = DateTime.Parse(matrizReserva[2]);
                reserva.horaInicio = TimeSpan.Parse(matrizReserva[3]);
                reserva.horaFin = TimeSpan.Parse(matrizReserva[4]);
                reserva.tipoEvento = matrizReserva[5];
                reserva.observaciones = matrizReserva[6];
                reserva.estado = matrizReserva[7];

                return reserva;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al mapear: {ex.Message}");
                return null;
            }
        }
    }
}
