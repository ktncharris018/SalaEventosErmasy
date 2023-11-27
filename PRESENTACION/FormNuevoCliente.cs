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
    public partial class FormNuevoCliente : Form
    {
        static ServicioCliente servicioCliente = new ServicioCliente();
        public FormNuevoCliente()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            cliente.cedula = txtCedula.Text;
            cliente.nombre = txtNombre.Text;
            cliente.apellido = txtApellido.Text;
            cliente.telefono = int.Parse(txtTelefono.Text);
            cliente.cuenta = 00;

            MessageBox.Show(servicioCliente.Crear(cliente));
            this.Close();
            
        }
    }
}
