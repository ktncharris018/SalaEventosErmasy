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
    public partial class FormNewSerPersonal : Form
    {
        static ServicioReserva servicioReserva = new ServicioReserva();
        static ServicioCliente servicioCliente = new ServicioCliente();
        public static ServicioServicioPersonal servicio = new ServicioServicioPersonal();

        static List<ServicioPersonal> servicios = new List<ServicioPersonal>();
        public FormNewSerPersonal()
        {
            InitializeComponent();
        }

        public FormNewSerPersonal(string tipoPersonal)
        {
            InitializeComponent();
            txtTipoPersonal.Text = tipoPersonal.ToString();
            
        }

        public FormNewSerPersonal(int id,string tipoPersonal)
        {
            InitializeComponent();
            txtIdReserva.Text = id.ToString();
            txtIdReserva.Enabled = false;
            txtTipoPersonal.Text = tipoPersonal.ToString();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FormServicioPersonal s = new FormServicioPersonal(agregar());
       
            this.Close();
        }
        private List<ServicioPersonal> agregar()
        {
          
            int idReserva; string cedula;
            ServicioPersonal servicioPersonal = new ServicioPersonal();
            servicioPersonal.IdServicio = int.Parse(txtIdservicio.Text);
            idReserva = int.Parse(txtIdReserva.Text);
            servicioPersonal.reserva = servicioReserva.buscarReserva(idReserva);
            servicioPersonal.TipoPersonal = txtTipoPersonal.Text;
            servicioPersonal.cantidad = int.Parse(txtCantidad.Text);
            servicioPersonal.TipoServicio = "Servicio Personal";

            servicios.Add(servicioPersonal);
            return servicios;
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
