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
    public partial class FormAdminReservas : Form
    {
        static ServicioReserva servicio = new ServicioReserva();    
        public FormAdminReservas()
        {
            InitializeComponent();
            cmbEstado.SelectedIndex = 0;
            cmbTipoEvento.SelectedIndex = 0;
            LlenarTablaReservas(servicio.listaReservas());
            txtReservasProgramas.Text = servicio.ReservasMes().ToString();
        }

        private void LlenarTablaReservas(List<Reserva> lista)
        {
            tblReservas.Rows.Clear();
            foreach (Reserva reserva in lista)
            {
                tblReservas.Rows.Add(reserva.idReserva, reserva.fecha.ToString("d"), formato(reserva.horaInicio), formato(reserva.horaFin), reserva.cliente.cedula, reserva.tipoEvento, reserva.estado);
            }

        }

        private string formato(TimeSpan hora)
        {
            return $"{(int)hora.TotalHours:D2}:{hora.Minutes:D2}";
        }

        private void cmbTipoEvento_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTipoEvento.SelectedIndex == 0)
            {
                LlenarTablaReservas(servicio.listaReservas());
            }
            else
            {
                LlenarTablaReservas(servicio.FiltroTipoEvento(cmbTipoEvento.Text));
            }
        }

        private void cmbEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbEstado.SelectedIndex == 0)
            {
                LlenarTablaReservas(servicio.listaReservas());
            }
            else
            {
                LlenarTablaReservas(servicio.FiltroPorEstado(cmbEstado.Text));
            }
        }
    }
}
