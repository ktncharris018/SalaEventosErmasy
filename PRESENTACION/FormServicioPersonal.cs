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
    public partial class FormServicioPersonal : Form
    {
        static ServicioServicioPersonal servicioPersonal = new ServicioServicioPersonal();
        public FormServicioPersonal()
        {
            InitializeComponent();
        
        }
        static List<ServicioPersonal> lista = new List<ServicioPersonal>();
        public FormServicioPersonal(List<ServicioPersonal> servicioPersonals)
        {
            MessageBox.Show("Constructor"+servicioPersonals.Count.ToString());
            InitializeComponent();
           
            lista = servicioPersonals;
        }

        //private void btnAgregar_Click(object sender, EventArgs e)
        //{
        //    FormNewSerPersonal form = new FormNewSerPersonal();
        //    form.ShowDialog();
        //}

        private void LlenarTabla()
        {
            tblServicioPersonal.Rows.Clear();
            foreach (ServicioPersonal servicio in lista)
            {
                servicio.ValorServicio = servicioPersonal.CalcularValorServicioPersonal(servicio);
                tblServicioPersonal.Rows.Add(servicio.IdServicio,servicio.reserva.idReserva,servicio.TipoPersonal,servicio.cantidad,servicio.ValorServicio);
            }
        }

        private void cmbTipoPersonal_Click(object sender, EventArgs e)
        {
            
        }

        private void cmbTipoPersonal_SelectionChangeCommitted(object sender, EventArgs e)
        {
          
        }

        private void cmbTipoPersonal_SelectedValueChanged(object sender, EventArgs e)
        {
            FormNewSerPersonal form = new FormNewSerPersonal(cmbTipoPersonal.Text);
            form.ShowDialog();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            LlenarTabla();
          
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            foreach (ServicioPersonal s in lista)
            {
                servicioPersonal.Crear(s);
            }
            MessageBox.Show("Servicios agregados");
            tblServicioPersonal.Rows.Clear();
            lista.Clear();
        }
    }
}
