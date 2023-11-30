using BLL.Servicios;
using ENTITY.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRESENTACION
{
    public partial class FormReportePago : Form
    {
        static ServicioReportePago servicioReporte = new ServicioReportePago();
        public FormReportePago()
        {
            InitializeComponent();
            LlenarTablaReportes();
        }

        private void LlenarTablaReportes()
        {
            foreach (ReportePago r in servicioReporte.listaReportes())
            {
                tblReportePago.Rows.Add(r.IdReportePago,r.Fecha.ToString("d"),r.reserva.cliente.cedula,r.reserva.tipoEvento,servicioReporte.SubTotalPersonal(r.reserva).ToString(),
                    servicioReporte.SubTotalInstalacion(r.reserva).ToString(),servicioReporte.TotalServicio(r.reserva),servicioReporte.TotalReserva(r.reserva),"Facturar");
            }
        }
    }
}
