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
    public partial class FormularioEvento : Form
    {
        static ServicioReserva servicioReserva = new ServicioReserva();
        static ServicioCliente servicioCliente = new ServicioCliente();
        public FormularioEvento()
        {
            
            InitializeComponent();
        }

        private void FormularioEvento_Load(object sender, EventArgs e)
        {
            txtIdReserva.Text = servicioReserva.idReserva().ToString();
            txtFecha.Text = ControlUsuarioDias.static_Dia + "/" + Calendario.static_Mes + "/" + Calendario.static_Año;
           // dateTimeHoraInicio.Text = string.Format("{HH:mm:ss}");
        }
        private string formato(TimeSpan hora)
        {
            return $"{(int)hora.TotalHours:D2}:{hora.Minutes:D2}";
        }
        private void btnCrearReserva_Click(object sender, EventArgs e)
        {
            if (ValidarVacios())
            {
                MessageBox.Show("Falta el campo de cedula cliente");
            }
            else
            {
                DateTime inicio;
                DateTime fin;

                Reserva reserva = new Reserva();
                reserva.idReserva = int.Parse(txtIdReserva.Text);
                reserva.fecha = DateTime.Parse(txtFecha.Text);

                inicio = DateTime.Parse(dateTimeHoraInicio.Text);
                fin = DateTime.Parse(dateTimeHoraFin.Text);

                TimeSpan tiempoInicio = inicio.TimeOfDay;
                TimeSpan tiempoFin = fin.TimeOfDay;

                reserva.horaInicio = tiempoInicio;
                reserva.horaFin = tiempoFin;
                reserva.cliente = servicioCliente.buscarCliente(txtCliente.Text);
                reserva.tipoEvento = cmbTipoEvento.Text;
                reserva.observaciones = txtObservaciones.Text;
                
                MessageBox.Show(servicioReserva.Crear(reserva));
                this.Close();
            }
  
        }

        private bool ValidarVacios()
        {
            if (txtCliente.Text == string.Empty)
            {
                return true;
            }
            return false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
