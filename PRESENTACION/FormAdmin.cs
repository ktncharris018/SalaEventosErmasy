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
    public partial class FormAdmin : Form
    {
        public FormAdmin()
        {
            InitializeComponent();
        }

        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void salirDelProgramaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult salir = MessageBox.Show("Desea salir del programa", "Ermasy", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (salir == DialogResult.Yes)
            {
                Application.ExitThread();
            }
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            FormAdminReservas form = new FormAdminReservas();
            CargarFormulario(form);
        }

        private void btnPersonal_Click(object sender, EventArgs e)
        {
            FormAdminPersonal form = new FormAdminPersonal();
            CargarFormulario(form);
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {

        }

        private void CargarFormulario(Form form)
        {
            panePrueba.Controls.Clear();
            form.TopLevel = false;
            panePrueba.Controls.Add(form);
            form.Size = panePrueba.Size;
            form.Show();
        
        }

        private void FormAdmin_Load(object sender, EventArgs e)
        {
            FormAdminReservas form = new FormAdminReservas();
            CargarFormulario(form);
        }
    }
}
