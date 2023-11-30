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
    public partial class NewSerInstalacion : Form
    {
        static ServicioReserva servicioReserva = new ServicioReserva();
        static ServicioCliente servicioCliente = new ServicioCliente();
        public static ServicioServicioInstalacion servicio = new ServicioServicioInstalacion();
        
        static List<ServicioInstalacion> servicios = new List<ServicioInstalacion>();
        static int indiceServicio = servicio.indiceServicio();
        public NewSerInstalacion()
        {
            InitializeComponent();
            txtIdservicio.Text = (indiceServicio+1).ToString();
        }

        public NewSerInstalacion(string tipoInstalacion)
        {
            InitializeComponent();
            txtTipoInstalacion .Text = tipoInstalacion;
            txtTipoInstalacion.Enabled = false;
            txtIdservicio.Text = (indiceServicio+1).ToString();
        }
        public NewSerInstalacion(int id, string tipoInstalacion)
        {
            InitializeComponent();
            txtIdReserva.Text = id.ToString();
            txtIdReserva.Enabled = false;
            txtTipoInstalacion.Text = tipoInstalacion.ToString();
            txtIdservicio.Text = (indiceServicio + 1).ToString();
        }

        private List<ServicioInstalacion> agregar()
        {

            int idReserva; string cedula;
            ServicioInstalacion servicioInstalacion = new ServicioInstalacion();
            servicioInstalacion.IdServicio = int.Parse(txtIdservicio.Text);
            idReserva = int.Parse(txtIdReserva.Text);
            servicioInstalacion.reserva = servicioReserva.buscarReserva(idReserva);
            servicioInstalacion.TipoInstalacion = txtTipoInstalacion.Text;
            servicioInstalacion.cantidad = int.Parse(txtCantidad.Text);
            servicioInstalacion.TipoServicio = "Servicio Instalacion";

            servicios.Add(servicioInstalacion);
            return servicios;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FormServicioInstalacion s = new FormServicioInstalacion(agregar());
            MessageBox.Show("Servicio agregado");

            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void NewSerInstalacion_Load(object sender, EventArgs e)
        {
           
        }
    }
}
