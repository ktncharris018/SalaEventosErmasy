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
    public partial class FormServicioInstalacion : Form
    {
        static ServicioServicioInstalacion servicioInstalacion = new ServicioServicioInstalacion();
        static List<ServicioInstalacion> lista = new List<ServicioInstalacion>();
        public FormServicioInstalacion()
        {
            InitializeComponent();
        }

        public FormServicioInstalacion(List<ServicioInstalacion> servicios)
        {
            InitializeComponent();
            lista = servicios;
        }

        private void LlenarTabla()
        {
            tblServicioInstalacion.Rows.Clear();
            foreach (ServicioInstalacion servicio in lista)
            {
                servicio.ValorServicio = servicioInstalacion.CalcularValorServicioInstalaciones(servicio);
                tblServicioInstalacion.Rows.Add(servicio.IdServicio, servicio.reserva.idReserva, servicio.TipoInstalacion, servicio.cantidad, servicio.ValorServicio);
            }
        }
     
        private void cmbTipoPersonal_SelectedIndexChanged(object sender, EventArgs e)
        {
            NewSerInstalacion form = new NewSerInstalacion(cmbTipoPersonal.Text);
            form.ShowDialog();
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            foreach (ServicioInstalacion s in lista)
            {
                servicioInstalacion.Crear(s);
            }
            MessageBox.Show("Servicios agregados");
            tblServicioInstalacion.Rows.Clear();
            lista.Clear();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            LlenarTabla();
        }
    }
}
