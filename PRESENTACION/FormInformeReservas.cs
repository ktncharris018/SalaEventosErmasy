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
    public partial class FormInformeReservas : Form
    {
        static ServicioReserva servicioReserva = new ServicioReserva();
        static ServicioReportePago reportePago = new ServicioReportePago();
        public FormInformeReservas()
        {
            InitializeComponent();
            LlenarTablaReservas(servicioReserva.listaReservas());
        }

        private void LlenarTablaReservas(List<Reserva> lista)
        {
            tblReservas.Rows.Clear();
            foreach (Reserva reserva in lista)
            {
                tblReservas.Rows.Add(reserva.idReserva,reserva.fecha.ToString("d"),formato(reserva.horaInicio),formato(reserva.horaFin),reserva.cliente.cedula,reserva.tipoEvento,reserva.estado);
            }
            
        }

        private string formato(TimeSpan hora)
        {
            return $"{(int)hora.TotalHours:D2}:{hora.Minutes:D2}";
        }

        private void cmbTipoEvento_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTipoEvento.Text == "Seleccionar")
            {
                LlenarTablaReservas(servicioReserva.listaReservas());
            }
                LlenarTablaReservas(servicioReserva.FiltroTipoEvento(cmbTipoEvento.Text));
        }

        private void tblReservas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void item2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Servicio Instalcion Funicionando");
            
            //AbrirFormularios(form);
        }

        private int IndiceTabla()
        {
            int i = 0;
            i = (int)tblReservas.CurrentRow.Cells[0].Value;
            
            return i;
        }
    
        private void item1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Servicio Personal");
            FormNewSerPersonal form = new FormNewSerPersonal(IndiceTabla(),item1ToolStripMenuItem.Text);
            AbrirFormularios(form);
        }
        private void AbrirFormularios(Form form)
        {

            form.Show();

        }

        private void pagadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reserva r = servicioReserva.buscarReserva(IndiceTabla());
            r.estado = "Pagado";
            MessageBox.Show(servicioReserva.Modificar(r));
            LlenarTablaReservas(servicioReserva.listaReservas());
            CrearReporte(r);
        }

        private void CrearReporte(Reserva reserva)
        {
            ReportePago reporte = new ReportePago();
            reporte.IdReportePago = 1;
            reporte.Fecha = DateTime.Now;
            reporte.TotalPagar = 0;
            reporte.reserva = reserva;
            reportePago.Crear(reporte);
        }
    }
}
