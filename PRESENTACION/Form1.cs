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
    public partial class Form1 : Form
    {
    
        public Form1()
        {
            InitializeComponent();
            personalizarDiseño();
        }

        private void personalizarDiseño()
        {
            panelServicios.Visible = false;
        }

        private void ocultarSubMenu()
        {
            if (panelServicios.Visible == true)
            {
                panelServicios.Visible = false;
            }
        }

        private void mostrarSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                ocultarSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }

        private void btnServicios_Click(object sender, EventArgs e)
        {
            mostrarSubMenu(panelServicios);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            panePrueba.Controls.Clear();
            FormServicioPersonal form = new FormServicioPersonal();
            form.TopLevel = false;
            panePrueba.Controls.Add(form);
            form.Size = panePrueba.Size;
            form.Show();
            ocultarSubMenu();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panePrueba.Controls.Clear();
            Calendario calendario = new Calendario();
            calendario.TopLevel = false;

            panePrueba.Controls.Add(calendario);

            calendario.Size = panePrueba.Size;

            calendario.Show();

            ocultarSubMenu();
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            panePrueba.Controls.Clear();
            FormularioCliente formularioCliente = new FormularioCliente();
            formularioCliente.TopLevel = false;      
            panePrueba.Controls.Add(formularioCliente);
            formularioCliente.Size = panePrueba.Size;
            formularioCliente.Show();
            ocultarSubMenu();
        }

        private void btnReserva_Click(object sender, EventArgs e)
        {
            panePrueba.Controls.Clear();
            FormInformeReservas formInformeReservas = new FormInformeReservas();
            formInformeReservas.TopLevel = false;
            panePrueba.Controls.Add(formInformeReservas);
            formInformeReservas.Size = panePrueba.Size;
            formInformeReservas.Show();
            ocultarSubMenu();
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            panePrueba.Controls.Clear();
            Calendario calendario = new Calendario();
            calendario.TopLevel = false;

            panePrueba.Controls.Add(calendario);

            calendario.Size = panePrueba.Size;

            calendario.Show();

            ocultarSubMenu();
        }

        private void btnReportePago_Click(object sender, EventArgs e)
        {
            panePrueba.Controls.Clear();
            FormReportePago reporte = new FormReportePago();
            reporte.TopLevel = false;
            panePrueba.Controls.Add(reporte);
            reporte.Size = panePrueba.Size;
            reporte.Show();
            ocultarSubMenu();
        }

        private void cerrarSesionToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void salirProgramaToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            DialogResult salir = MessageBox.Show("Desea salir del programa", "Ermasy", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (salir == DialogResult.Yes)
            {
                Application.ExitThread();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            panePrueba.Controls.Clear();
            FormServicioInstalacion form = new FormServicioInstalacion();
            form.TopLevel = false;
            panePrueba.Controls.Add(form);
            form.Size = panePrueba.Size;
            form.Show();
            ocultarSubMenu();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
