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
    public class RepositorioReportePago
    {
        private readonly string FileName = "ReportePago.txt";
        private static RepositorioReserva repositorio;

        public RepositorioReportePago() 
        {
            repositorio = new RepositorioReserva();
        }

        public bool Crear(ReportePago reporte)
        {
            try
            {
                FileStream file = new FileStream(FileName, FileMode.Append);
                StreamWriter writer = new StreamWriter(file);
                writer.WriteLine($"{reporte.IdReportePago};{reporte.Fecha.ToString("d")};{reporte.reserva.idReserva};{reporte.TotalPagar}");
                writer.Close();
                file.Close();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al crear El Reporte de pago: {ex.Message}");
                return false;

            }
        }
        public ReportePago buscarReporte(int id)
        {
            try
            {
                foreach (var reporte in listaReportes())
                {
                    if (id == reporte.IdReportePago)
                    {
                        return reporte;
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
        public List<ReportePago> listaReportes()
        {
            List<ReportePago> reportes = new List<ReportePago>();
            try
            {
                FileStream file = new FileStream(FileName, FileMode.OpenOrCreate, FileAccess.Read);
                StreamReader reader = new StreamReader(file);
                string linea = string.Empty;
                while ((linea = reader.ReadLine()) != null)
                {
                    ReportePago reporte = Map(linea);
                    reportes.Add(reporte);
                }
                reader.Close();
                file.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al listar los Reportes: {ex.Message}");
            }
            return reportes;
        }
        private ReportePago Map(String linea)
        {
            try
            {
                int id;
                ReportePago reporte = new ReportePago();
                char delimiter = ';';
                string[] matrizReporte = linea.Split(delimiter);
                reporte.IdReportePago = int.Parse(matrizReporte[0]);
                reporte.Fecha = DateTime.Parse(matrizReporte[1]);
                id = int.Parse(matrizReporte[2]);
                reporte.reserva = repositorio.buscarReserva(id);
                reporte.TotalPagar = decimal.Parse((matrizReporte[3]));

                return reporte;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al mapear: {ex.Message}");
                return null;
            }
        }
    }
  
}
