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
    public partial class FormularioCliente : Form
    {
        static ServicioCliente servicioCliente = new ServicioCliente();
        public FormularioCliente()
        {
            InitializeComponent();
            LlenarTablaCliente();
        }

        private void LlenarTablaCliente()
        {

            foreach (Cliente cliente in servicioCliente.listaClientes())
            {
                tblClientes.Rows.Add(cliente.cedula,cliente.nombre,cliente.apellido,cliente.telefono);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormNuevoCliente form  = new FormNuevoCliente();
            form.ShowDialog();
        }

        private void btnActualizarTabla_Click(object sender, EventArgs e)
        {
            tblClientes.Rows.Clear();
            LlenarTablaCliente();
        }

        private void tblClientes_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            var fila = tblClientes.Rows[e.RowIndex];
            
            if (fila.Cells[1].Value == null || fila.Cells[2].Value == null || fila.Cells[3].Value == null)
            {
                MessageBox.Show("Este campo es obligatorio");
                tblClientes.Rows.Clear();
                LlenarTablaCliente();
            }
            else
            {
                Cliente cliente = new Cliente
                {

                    cedula = fila.Cells[0].Value.ToString(),
                    nombre = fila.Cells[1].Value.ToString(),
                    apellido = fila.Cells[2].Value.ToString(),
                    telefono = (int)long.Parse(fila.Cells[3].Value.ToString())

                };
                var respuesta = MessageBox.Show("desea actualizar los datos ", "actualizar datos", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (respuesta == DialogResult.Yes)
                {
                    MessageBox.Show(servicioCliente.Modificar(cliente));

                }
            }
        }

        private void tblClientes_KeyPress(object sender, KeyPressEventArgs e)
        {
         
        }

        private void tblClientes_KeyDown(object sender, KeyEventArgs e)
        {
            var respuesta = MessageBox.Show("Desea Eliminar este cliente ", "Eliminar cliente", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes)
            {
                MessageBox.Show(servicioCliente.Eliminar(Convert.ToString(tblClientes.CurrentRow.Cells[0].Value)));
                tblClientes.Rows.Clear();
                LlenarTablaCliente();

            } 
        }
    }
}
