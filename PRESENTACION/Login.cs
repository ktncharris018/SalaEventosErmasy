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
    public partial class Login : Form
    {
        static ServicioUsuario servicioUsuario = new ServicioUsuario();
        static ServicioCliente cliente = new ServicioCliente();
        public Login()
        {
            InitializeComponent();

        }

        private void btnLoogin_Click(object sender, EventArgs e)
        {
            if (servicioUsuario.Login(txtUserName.Text, txtPassword.Text))
            {
                Usuario usuario = servicioUsuario.buscarUsuario(txtUserName.Text, txtPassword.Text);
                LlamarForm(usuario);
            }
            else
                MessageBox.Show("Credenciales incorrectas");

            LimpiarTexto();
        }

        private void LlamarForm(Usuario usuario)
        {
            if (usuario.tipoUsuario == "Administrador")
            {
                MessageBox.Show("Ingreso admin");
            }
            else
            {
                Form1 form = new Form1();
                form.Show();
            }
        }

        private void LimpiarTexto()
        {
            txtUserName.Text = string.Empty;
            txtPassword.Text = string.Empty;
        }
    }
}
