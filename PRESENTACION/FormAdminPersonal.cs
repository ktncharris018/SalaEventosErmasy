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
    public partial class FormAdminPersonal : Form
    {
        static ServicioPersonalS servicio = new ServicioPersonalS();
        public FormAdminPersonal()
        {
            InitializeComponent();
            LlenarTablaPersonals();
        }

        private void LlenarTablaPersonals()
        {
            tblPersonal.Rows.Clear();
            foreach (Personal personal in servicio.listaPersonals())
            {
                tblPersonal.Rows.Add(personal.cedula, personal.nombre, personal.apellido, personal.telefono);
            }
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            Personal personal = new Personal();
            personal.cedula = txtCedula.Text;
            personal.nombre = txtNombre.Text;
            personal.apellido = txtApellido.Text;
            personal.telefono = int.Parse(txtTelefono.Text);
          
            MessageBox.Show(servicio.Crear(personal));
            LlenarTablaPersonals();
        }

        private void tblPersonal_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            var fila = tblPersonal.Rows[e.RowIndex];

            if (fila.Cells[1].Value == null || fila.Cells[2].Value == null || fila.Cells[3].Value == null)
            {
                MessageBox.Show("Este campo es obligatorio");
                tblPersonal.Rows.Clear();
                LlenarTablaPersonals();
            }
            else
            {
                Personal personal = new Personal()
                {

                    cedula = fila.Cells[0].Value.ToString(),
                    nombre = fila.Cells[1].Value.ToString(),
                    apellido = fila.Cells[2].Value.ToString(),
                    telefono = (int)long.Parse(fila.Cells[3].Value.ToString())

                };
                var respuesta = MessageBox.Show("desea actualizar los datos ", "actualizar datos", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (respuesta == DialogResult.Yes)
                {
                    MessageBox.Show(servicio.Modificar(personal));

                }
            }
        }

        private void tblPersonal_KeyDown(object sender, KeyEventArgs e)
        {
            var respuesta = MessageBox.Show("Desea Eliminar este Empleado ", "Eliminar Empleado", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes)
            {
                MessageBox.Show(servicio.Eliminar(Convert.ToString(tblPersonal.CurrentRow.Cells[0].Value)));
                tblPersonal.Rows.Clear();
                LlenarTablaPersonals();

            }
        }
    }
}
