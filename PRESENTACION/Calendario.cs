using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRESENTACION
{
    public partial class Calendario : Form
    {
        int Mes, Año;
        public static int static_Mes, static_Año;
        public Calendario()
        {
            InitializeComponent();
        }

        private void Calendario_Load(object sender, EventArgs e)
        {
            PantallaDias();
        }

        private void CalendarioDias()
        {
            string NombreMes = DateTimeFormatInfo.CurrentInfo.GetMonthName(Mes);
            lbFecha.Text = NombreMes + " " + Año;

            static_Mes = Mes;
            static_Año = Año;

            DateTime IniciarMes = new DateTime(Año, Mes, 1);

            int Dias = DateTime.DaysInMonth(Año, Mes);

            int DiasSemana = Convert.ToInt32(IniciarMes.DayOfWeek.ToString("d")) + 1;

            for (int i = 1; i < DiasSemana; i++)
            {
                ControlUsuario control = new ControlUsuario();
                ContenedorDias.Controls.Add(control);
            }

            for (int i = 1; i <= Dias; i++)
            {
                ControlUsuarioDias controlDias = new ControlUsuarioDias();
                controlDias.Dias(i);
                ContenedorDias.Controls.Add(controlDias);
            }
        }

        private void PantallaDias()
        {
          
            DateTime now = DateTime.Now;

            Mes = now.Month;
            Año = now.Year;

            CalendarioDias();
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            ContenedorDias.Controls.Clear();

            Mes--;
            CalendarioDias();
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            ContenedorDias.Controls.Clear();

            Mes ++;

            CalendarioDias();
        }

    }
}
