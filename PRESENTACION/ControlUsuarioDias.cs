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
    public partial class ControlUsuarioDias : UserControl
    {
        public static string static_Dia;
        static ServicioReserva ServicioReserva = new ServicioReserva();
        public ControlUsuarioDias()
        {
            InitializeComponent();
        }

        private void ControlUsuarioDias_Load(object sender, EventArgs e)
        {

        }
        public void Dias(int NumDia)
        {
            lbDias.Text = NumDia + "";
        }

        private void ControlUsuarioDias_Click(object sender, EventArgs e)
        {
            var respuesta = MessageBox.Show("Desea realizar una reserva ","Realizar reserva",MessageBoxButtons.YesNo);
            if (respuesta == DialogResult.Yes)
            {
                static_Dia = lbDias.Text;
                FormularioEvento fr = new FormularioEvento();
                fr.Show();
            }
          
        }

        private void validarFecha()
        {

        }

        private void prueba()
        {
            var respuesta = MessageBox.Show("desea actualizar los datos ", "actualizar datos", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes)
            {
               // MessageBox.Show(servicioCliente.Modificar(cliente));
               // LlenarTablaCliente();
            }
            //LlenarTablaCliente();
        }
    }
}
